using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace GamingInventory
{
    public class ItemResult
    {
        string Owner;
        decimal ID;
        string Type;
        string Platform;
        string Serial;
        string Description;
        string LastCheckIn;
        string LastCheckOut;
        bool Archived;
        bool BindingCheck;

        public ItemResult()
        {
            Owner = string.Empty;
            ID = 0;
            Type = string.Empty;
            Platform = string.Empty;
            Serial = string.Empty;
            Description = string.Empty;
            LastCheckIn = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            LastCheckOut = "1970-01-01 00:00:00";
            Archived = false;
            BindingCheck = false;
        }

        public ItemResult(string Owner, decimal ID, string Type, string Platform, string Serial, string Description, string LastCheckIn, string LastCheckOut, bool Archived, bool BindingCheck)
        {
            this.Owner = Owner;
            this.ID = ID;
            this.Type = Type;
            this.Platform = Platform;
            this.Serial = Serial;
            this.Description = Description;
            this.LastCheckIn = LastCheckIn;
            this.LastCheckOut = LastCheckOut;
            this.Archived = Archived;
            this.BindingCheck = BindingCheck;
        }

        public ItemResult(string Owner, decimal ID, string Type, string Platform, string Serial, string Description, string LastCheckIn)
        {
            this.Owner = Owner;
            this.ID = ID;
            this.Type = Type;
            this.Platform = Platform;
            this.Serial = Serial;
            this.Description = Description;
            this.LastCheckIn = LastCheckIn;
            LastCheckOut = "1970-01-01 00:00:00";
            Archived = false;
            BindingCheck = false;
        }

        public ItemResult(string Owner, decimal ID, string Type, string Platform, string Serial, string Description, bool Binding)
        {
            this.Owner = Owner;
            this.ID = ID;
            this.Type = Type;
            this.Platform = Platform;
            this.Serial = Serial;
            this.Description = Description;
            BindingCheck = Binding;
        }

        public ItemResult(string Platform, string Serial, string Description, bool finalCheck)
        {
            this.Platform = Platform;
            this.Serial = Serial;
            this.Description = Description;
            BindingCheck = finalCheck;
        }

        public string OwnerValue { get { return Owner; } set { Owner = value; } }
        public decimal IDValue { get { return ID; } set { ID = value; } }
        public string TypeValue { get { return Type; } set { Type = value; } }
        public string PlatformValue { get { return Platform; } set { Platform = value; } }
        public string SerialValue { get { return Serial; } set { Serial = value; } }
        public string DescriptionValue { get { return Description; } set { Description = value; } }
        public string LastCheckInValue { get { return LastCheckIn; } set { LastCheckIn = value; } }
        public string LastCheckOutValue { get { return LastCheckOut; } set { LastCheckOut = value; } }
        public bool ArchivedValue { get { return Archived; } set { Archived = value; } }
        public bool BindingCheckValue { get { return BindingCheck; } set { BindingCheck = value; } }

        public override string ToString()
        {
            return string.Format("{0} : {1} | In: {2} | Out: {3}", ID, Owner, LastCheckIn, LastCheckOut);
            //return string.Format("{0} : {1} | Description: {2} | Platform: {3} | Type: {4} | Serial {5} | In: {6} | Out: {7}", ID, Owner, Description, Platform, Type, Serial, LastCheckIn, LastCheckOut);
        }

        public void FinalCheckIn(MySqlConnection conn)
        {
            MySqlCommand FinalCheckInCmd = new MySqlCommand("UPDATE `ITEMS` SET `LASTCHECKOUT` = @CheckOutParam WHERE `ID` = @IDParam" + ';', conn);
            FinalCheckInCmd.Parameters.AddWithValue("@IDParam", ID);
            FinalCheckInCmd.Parameters.AddWithValue("@CheckOutParam", LastCheckOut);
            FinalCheckInCmd.ExecuteNonQuery();
        }

        public decimal Insert(MySqlConnection conn)
        {
            //MessageBox.Show(EscapedOwner);
            MySqlCommand GetOwnerInfo = new MySqlCommand("select `ID` from `gaminginv`.`owner` where `Name` = @NameParam" + ';', conn);
            GetOwnerInfo.Parameters.AddWithValue("@NameParam", Owner);
            uint currentID = 0;
            int currentOffset = 0;
            decimal generatedID;

            currentID = (uint)GetOwnerInfo.ExecuteScalar();
            GetOwnerInfo.CommandText = "select `ItemCount` from `gaminginv`.`owner` where `Name` = @NameParam" + ';';
            currentOffset = (int)GetOwnerInfo.ExecuteScalar();
            Console.Write(GetOwnerInfo.ExecuteScalar())
;            generatedID = currentID + (currentOffset + 1);

            GetOwnerInfo.CommandText = "insert into `gaminginv`.`items` (`Owner`,`ID`,`Type`,`Platform`,`Serial`,`Description`) values(@NameParam" + ',' + "@IDParam" + ',' + "@TypeParam" + ',' + "@PlatformParam" + ',' + "@SerialParam" + ',' + "@DescriptionParam" + ");";
            GetOwnerInfo.Parameters.AddWithValue("@IDParam", generatedID);
            GetOwnerInfo.Parameters.AddWithValue("@TypeParam", Type);
            GetOwnerInfo.Parameters.AddWithValue("@PlatformParam", Platform);
            GetOwnerInfo.Parameters.AddWithValue("@SerialParam", Serial);
            GetOwnerInfo.Parameters.AddWithValue("@DescriptionParam", Description);
            //GetOwnerInfo.Parameters.AddWithValue("@CheckInParam", "1970-01-01 00:00:00");
            GetOwnerInfo.ExecuteNonQuery();
            GetOwnerInfo.CommandText = "update `gaminginv`.`owner` set `ItemCount` = @CountParam where `ID` = @cIDParam" + ';';
            GetOwnerInfo.Parameters.AddWithValue("@CountParam", currentOffset + 1);
            GetOwnerInfo.Parameters.AddWithValue("@cIDParam", currentID);
            GetOwnerInfo.ExecuteNonQuery();
            return generatedID;
        }
        /****
        public int SearchItems(ListBox.ObjectCollection results, MySqlConnection conn)
        {
            int resultsCount = 0;
            MySqlCommand GetSearchedItems = new MySqlCommand(BuildSelectQuery(), conn);
            //MessageBox.Show(GetSearchedItems.CommandText);
            MySqlDataReader ItemsReader = GetSearchedItems.ExecuteReader();
            while (ItemsReader.Read())
            {
                results.Add(new ItemResult(ItemsReader.GetString("Owner"), ItemsReader.GetDecimal("ID"), ItemsReader.GetString("Type"), ItemsReader.GetString("Platform"), ItemsReader.GetString("Serial"), ItemsReader.GetString("Description"), ItemsReader.GetString("LastCheckIn"), ItemsReader.GetString("LastCheckOut")));
                resultsCount++;
            }
            ItemsReader.Close();
            return resultsCount;
        }
        

        public static string EscapeCharInField(string field)
        {
            string Escaped = string.Copy(field);
            List<int> ApostropheList = new List<int>();
            for (int i = 0; i < field.Length; i++)
            {
                if (field[i].Equals('\''))
                    ApostropheList.Add(i);
            }
            //MessageBox.Show(ApostropheList.Count.ToString());
            if (ApostropheList.Count > 0)
                Escaped = Escaped.Insert(ApostropheList[0], "\\");
            for (int index = 1; index < ApostropheList.Count; index++)
            {
                Escaped = Escaped.Insert(ApostropheList[index] + index, "\\");
            }
            return Escaped;
        }
        ***/
        public string BuildSelectQuery(MySqlCommand cmd, bool needBinding, bool includeID, bool includeOwner, bool includePlatform, bool includeSerial, bool includeType, bool includeDescription, bool includeArchived)
        {
            StringBuilder SelectBuilder = new StringBuilder();

            if (needBinding)
                SelectBuilder.Append("select `LastCheckout` < `LastCheckin` as \'Bound\', `Owner`, `ID`, `Type`, `Platform`, `Serial`, `Description`, `LastCheckIn`, `LastCheckOut`, `Archived`  from `gaminginv`.`items` where ");
            else
                SelectBuilder.Append("select * from `gaminginv`.`items` where ");
            List<int> PlaceHolder = new List<int>();
            if (includeID && ID > 0)
                PlaceHolder.Add(1);
            if (includeOwner && !Owner.Equals(string.Empty))
                PlaceHolder.Add(2);
            if (includePlatform && !Platform.Equals(string.Empty))
                PlaceHolder.Add(3);
            if (includeSerial && !Serial.Equals(string.Empty))
                PlaceHolder.Add(4);
            if (includeType && !Type.Equals(string.Empty))
                PlaceHolder.Add(5);
            if (includeDescription && !Description.Equals(string.Empty))
                PlaceHolder.Add(6);
            for (int i = 0; i < PlaceHolder.Count - 1; i++)
            {
                switch (PlaceHolder.ElementAt(i))
                {
                    case 1:
                        SelectBuilder.Append("`ID` = @IDParam and ");
                        cmd.Parameters.AddWithValue("@IDParam", ID);
                        break;
                    case 2:
                        SelectBuilder.Append("`Owner` = @OwnerParam and ");
                        cmd.Parameters.AddWithValue("@OwnerParam", Owner.ToLower());
                        break;
                    case 3:
                        SelectBuilder.Append("`Platform` = @PlatformParam and ");
                        cmd.Parameters.AddWithValue("@PlatformParam", Platform);
                        break;
                    case 4:
                        SelectBuilder.Append("`Serial` like @SerialParam and ");
                        cmd.Parameters.AddWithValue("@SerialParam", '%' + Serial.ToLower() + '%');
                        break;
                    case 5:
                        SelectBuilder.Append("`Type` = @TypeParam and ");
                        cmd.Parameters.AddWithValue("@TypeParam", Type);
                        break;
                    case 6:
                        SelectBuilder.Append("`Description` like @DescriptionParam and ");
                        cmd.Parameters.AddWithValue("@DescriptionParam", '%' + Description.ToLower() + '%');
                        break;
                }
            }
            if (PlaceHolder.Count > 0)
            {
                switch (PlaceHolder.Last())
                {
                    case 1:
                        SelectBuilder.Append("`ID` = @IDParam");
                        cmd.Parameters.AddWithValue("@IDParam", ID);
                        break;
                    case 2:
                        SelectBuilder.Append("`Owner` = @OwnerParam");
                        cmd.Parameters.AddWithValue("@OwnerParam", Owner.ToLower());
                        break;
                    case 3:
                        SelectBuilder.Append("`Platform` = @PlatformParam");
                        cmd.Parameters.AddWithValue("@PlatformParam", Platform);
                        break;
                    case 4:
                        SelectBuilder.Append("`Serial` like @SerialParam");
                        cmd.Parameters.AddWithValue("@SerialParam", '%' + Serial.ToLower() + '%');
                        break;
                    case 5:
                        SelectBuilder.Append("`Type` = @TypeParam");
                        cmd.Parameters.AddWithValue("@TypeParam", Type);
                        break;
                    case 6:
                        SelectBuilder.AppendFormat("`Description` like @DescriptionParam");
                        cmd.Parameters.AddWithValue("@DescriptionParam", '%' + Description.ToLower() + '%');
                        break;
                }
                if (!includeArchived)
                    SelectBuilder.Append(" and Archived = false");
                SelectBuilder.Append(';');
                return SelectBuilder.ToString();
            }
            else
                return string.Empty;
        }

        public string BuildUpdateQuery(MySqlCommand cmd)
        {
            StringBuilder UpdateBuilder = new StringBuilder("update `gaminginv`.`items` set ");
            List<int> PlaceHolder = new List<int>();
            if (!Type.Equals(string.Empty))
                PlaceHolder.Add(1);
            if (!Platform.Equals(string.Empty))
                PlaceHolder.Add(2);
            if (!Serial.Equals(string.Empty))
                PlaceHolder.Add(3);
            if (!Description.Equals(string.Empty))
                PlaceHolder.Add(4);

            for (int i = 0; i < PlaceHolder.Count - 1; i++)
            {
                switch (PlaceHolder.ElementAt(i))
                {
                    case 1:
                        UpdateBuilder.Append("`Type` = @TypeParam" + ',');
                        cmd.Parameters.AddWithValue("@TypeParam", Type);
                        break;
                    case 2:
                        UpdateBuilder.Append("`Platform` = @PlatformParam" + ',');
                        cmd.Parameters.AddWithValue("@PlatformParam", Platform);
                        break;
                    case 3:
                        UpdateBuilder.Append("`Serial` = @SerialParam" + ',');
                        cmd.Parameters.AddWithValue("@SerialParam", Serial);
                        break;
                    case 4:
                        UpdateBuilder.Append("`Description` = @DescriptionParam" + ',');
                        cmd.Parameters.AddWithValue("@DescriptionParam", Description);
                        break;
                }
            }
            switch (PlaceHolder.Last())
            {
                case 1:
                    UpdateBuilder.Append("`Type` = @TypeParam");
                    cmd.Parameters.AddWithValue("@TypeParam", Type);
                    break;
                case 2:
                    UpdateBuilder.Append("`Platform` = @PlatformParam");
                    cmd.Parameters.AddWithValue("@PlatformParam", Platform);
                    break;
                case 3:
                    UpdateBuilder.Append("`Serial` = @SerialParam");
                    cmd.Parameters.AddWithValue("@SerialParam", Serial);
                    break;
                case 4:
                    UpdateBuilder.Append("`Description` = @DescriptionParam");
                    cmd.Parameters.AddWithValue("@DescriptionParam", Description);
                    break;
            }
            UpdateBuilder.AppendFormat(",`Archived` = @ArchivedParam where `ID` = @IDParam" + ';');
            cmd.Parameters.AddWithValue("@ArchivedParam", Archived);
            cmd.Parameters.AddWithValue("@IDParam", ID);
            return UpdateBuilder.ToString();
        }

        public void Update(MySqlConnection conn)
        {
            MySqlCommand UpdateItemCmd = new MySqlCommand();
            UpdateItemCmd.Connection = conn;
            UpdateItemCmd.CommandText = BuildUpdateQuery(UpdateItemCmd);
            UpdateItemCmd.ExecuteNonQuery();
        }

        public void UpsertCheckInOut(MySqlConnection conn, bool isCheckIn, bool conLive)
        {
            //Write records checkin and checkout records only when con is live
            if (conLive)
            {

                MySqlCommand UpsertCommand = new MySqlCommand();
                UpsertCommand.Connection = conn;

                if (isCheckIn)
                {
                    UpsertCommand.CommandText = "UPDATE `gaminginv`.`items` SET `LastCheckIn` = @CheckInParam WHERE `ID` = @IDParam" + ';';
                    UpsertCommand.Parameters.AddWithValue("@CheckInParam", LastCheckIn);
                    UpsertCommand.Parameters.AddWithValue("@IDParam", ID);
                    UpsertCommand.ExecuteNonQuery();
                    UpsertCommand.CommandText = "INSERT INTO `gaminginv`.`checkinginout` (`Check`, `Direction`, `itemID`, `Duration`) VALUES(@CheckInParam" + ", \'In\'," + "@IDParam" + ", (select abs(timestampdiff(minute, `LastCheckIn`,`LastCheckOut`)) from `items` where `items`.`ID` = @IDParam" + "));";
                    UpsertCommand.ExecuteNonQuery();
                }
                else
                {
                    UpsertCommand.CommandText = "UPDATE `gaminginv`.`items` SET `LastCheckOut` = @CheckOutParam WHERE `ID` = @IDParam" + ';';
                    UpsertCommand.Parameters.AddWithValue("@CheckOutParam", LastCheckOut);
                    UpsertCommand.Parameters.AddWithValue("@IDParam", ID);
                    UpsertCommand.ExecuteNonQuery();
                    UpsertCommand.CommandText = "INSERT INTO `gaminginv`.`checkinginout` (`Check`, `Direction`, `itemID`, `Duration`) VALUES(@CheckOutParam" + ", \'Out\'," + "@IDParam" + ", (select abs(timestampdiff(minute, `LastCheckIn`,`LastCheckOut`)) from `items` where `items`.`ID` = @IDParam" + "));";
                    UpsertCommand.ExecuteNonQuery();
                }
            }
        }
    }
}
