using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace GamingInventory_V2
{
    public class ItemResult
    {
        public string OwnerValue { get; set; }
        public decimal IDValue { get; set; }
        public string TypeValue { get; set; }
        public string PlatformValue { get; set; }
        public string SerialValue { get; set; }
        public string DescriptionValue { get; set; }
        public string LastCheckInValue { get; set; }
        public string LastCheckOutValue { get; set; }
        public bool BindingCheckValue { get; set; }
        public string LogisticState { get; set; }
        public string LogisticStateUpdated { get; set; }

        public ItemResult()
        {
            OwnerValue = string.Empty;
            IDValue = 0;
            TypeValue = string.Empty;
            PlatformValue = string.Empty;
            SerialValue = string.Empty;
            DescriptionValue = string.Empty;
            LastCheckInValue = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            LastCheckOutValue = "1970-01-01 00:00:00";
            BindingCheckValue = false;
        }

        public ItemResult(string Owner, decimal ID, string Type, string Platform, string Serial, string Description, string LastCheckIn, string LastCheckOut, string LogisticState, string LogisticStateUpdated)
        {
            OwnerValue = Owner;
            IDValue = ID;
            TypeValue = Type;
            PlatformValue = Platform;
            SerialValue = Serial;
            DescriptionValue = Description;
            this.LogisticState = LogisticState;
            this.LogisticStateUpdated = LogisticStateUpdated;
        }

        public ItemResult(string Owner, decimal ID, string Type, string Platform, string Serial, string Description, string LastCheckIn)
        {
            OwnerValue = Owner;
            IDValue = ID;
            TypeValue = Type;
            PlatformValue = Platform;
            SerialValue = Serial;
            DescriptionValue = Description;
            LastCheckInValue = LastCheckIn;
            LastCheckOutValue = "1970-01-01 00:00:00";
            BindingCheckValue = false;
        }
        
        public ItemResult(string Owner, decimal ID, string Type, string Platform, string Serial, string Description, string LogisticState, string LogisticStateUpdated, bool Binding)
        {
            OwnerValue = Owner;
            IDValue = ID;
            TypeValue = Type;
            PlatformValue = Platform;
            SerialValue = Serial;
            DescriptionValue = Description;
            BindingCheckValue = Binding;
            this.LogisticState = LogisticState;
            this.LogisticStateUpdated = LogisticStateUpdated;
        }

        public ItemResult(string Platform, string Serial, string Description, string type)
        {
            PlatformValue = Platform;
            SerialValue = Serial;
            DescriptionValue = Description;
            TypeValue = type;
        }

        public override string ToString() => string.Format("{0} : {1} | In: {2} | Out: {3}", IDValue, OwnerValue, LastCheckInValue, LastCheckOutValue);

        public decimal Insert(MySqlConnection conn)
        {
            MySqlCommand addItemCmd = new MySqlCommand();
            addItemCmd.Connection = conn;
            addItemCmd.CommandType = System.Data.CommandType.StoredProcedure;
            addItemCmd.CommandText = @"insertItem";
            addItemCmd.Parameters.AddWithValue("@NameParam", OwnerValue);
            addItemCmd.Parameters.AddWithValue("@TypeParam", TypeValue);
            addItemCmd.Parameters.AddWithValue("@PlatformParam", PlatformValue);
            addItemCmd.Parameters.AddWithValue("@SerialParam", SerialValue);
            addItemCmd.Parameters.AddWithValue("@DescriptionParam", DescriptionValue);
            MySqlParameter returnP = addItemCmd.Parameters.Add("@returnParam", MySqlDbType.Decimal);
            returnP.Direction = System.Data.ParameterDirection.ReturnValue;
            addItemCmd.ExecuteNonQuery();
            return Convert.ToDecimal(returnP.Value);
        }

        public string BuildSelectQuery(MySqlCommand cmd, bool includeID, bool includeOwner, bool includePlatform, bool includeSerial, bool includeType, bool includeDescription)
        {
            StringBuilder SelectBuilder = new StringBuilder();

            SelectBuilder.Append("select * from `gaminginv`.`items` where ");
            List<int> PlaceHolder = new List<int>();
            if (includeID && IDValue > 0)
                PlaceHolder.Add(1);
            if (includeOwner && !OwnerValue.Equals(string.Empty))
                PlaceHolder.Add(2);
            if (includePlatform && !PlatformValue.Equals(string.Empty))
                PlaceHolder.Add(3);
            if (includeSerial && !SerialValue.Equals(string.Empty))
                PlaceHolder.Add(4);
            if (includeType && !TypeValue.Equals(string.Empty))
                PlaceHolder.Add(5);
            if (includeDescription && !DescriptionValue.Equals(string.Empty))
                PlaceHolder.Add(6);
            for (int i = 0; i < PlaceHolder.Count - 1; i++)
            {
                switch (PlaceHolder.ElementAt(i))
                {
                    case 1:
                        SelectBuilder.Append("`ID` = @IDParam and ");
                        cmd.Parameters.AddWithValue("@IDParam", IDValue);
                        break;
                    case 2:
                        SelectBuilder.Append("`Owner` = @OwnerParam and ");
                        cmd.Parameters.AddWithValue("@OwnerParam", OwnerValue.ToLower());
                        break;
                    case 3:
                        SelectBuilder.Append("`Platform` = @PlatformParam and ");
                        cmd.Parameters.AddWithValue("@PlatformParam", PlatformValue);
                        break;
                    case 4:
                        SelectBuilder.Append("`Serial` like @SerialParam and ");
                        cmd.Parameters.AddWithValue("@SerialParam", '%' + SerialValue.ToLower() + '%');
                        break;
                    case 5:
                        SelectBuilder.Append("`Type` = @TypeParam and ");
                        cmd.Parameters.AddWithValue("@TypeParam", TypeValue);
                        break;
                    case 6:
                        SelectBuilder.Append("`Description` like @DescriptionParam and ");
                        cmd.Parameters.AddWithValue("@DescriptionParam", '%' + DescriptionValue.ToLower() + '%');
                        break;
                }
            }
            if (PlaceHolder.Count > 0)
            {
                switch (PlaceHolder.Last())
                {
                    case 1:
                        SelectBuilder.Append("`ID` = @IDParam");
                        cmd.Parameters.AddWithValue("@IDParam", IDValue);
                        break;
                    case 2:
                        SelectBuilder.Append("`Owner` = @OwnerParam");
                        cmd.Parameters.AddWithValue("@OwnerParam", OwnerValue.ToLower());
                        break;
                    case 3:
                        SelectBuilder.Append("`Platform` = @PlatformParam");
                        cmd.Parameters.AddWithValue("@PlatformParam", PlatformValue);
                        break;
                    case 4:
                        SelectBuilder.Append("`Serial` like @SerialParam");
                        cmd.Parameters.AddWithValue("@SerialParam", '%' + SerialValue.ToLower() + '%');
                        break;
                    case 5:
                        SelectBuilder.Append("`Type` = @TypeParam");
                        cmd.Parameters.AddWithValue("@TypeParam", TypeValue);
                        break;
                    case 6:
                        SelectBuilder.AppendFormat("`Description` like @DescriptionParam");
                        cmd.Parameters.AddWithValue("@DescriptionParam", '%' + DescriptionValue.ToLower() + '%');
                        break;
                }
                SelectBuilder.Append(" and `LogisticState` = 'Arrived';");
                return SelectBuilder.ToString();
            }
            else
                return string.Empty;
        }

        public string BuildUpdateQuery(MySqlCommand cmd)
        {
            StringBuilder UpdateBuilder = new StringBuilder("update `gaminginv`.`items` set ");
            List<int> PlaceHolder = new List<int>();
            if (!TypeValue.Equals(string.Empty))
                PlaceHolder.Add(1);
            if (!PlatformValue.Equals(string.Empty))
                PlaceHolder.Add(2);
            if (!SerialValue.Equals(string.Empty))
                PlaceHolder.Add(3);
            if (!DescriptionValue.Equals(string.Empty))
                PlaceHolder.Add(4);

            for (int i = 0; i < PlaceHolder.Count - 1; i++)
            {
                switch (PlaceHolder.ElementAt(i))
                {
                    case 1:
                        UpdateBuilder.Append("`Type` = @TypeParam" + ',');
                        cmd.Parameters.AddWithValue("@TypeParam", TypeValue);
                        break;
                    case 2:
                        UpdateBuilder.Append("`Platform` = @PlatformParam" + ',');
                        cmd.Parameters.AddWithValue("@PlatformParam", PlatformValue);
                        break;
                    case 3:
                        UpdateBuilder.Append("`Serial` = @SerialParam" + ',');
                        cmd.Parameters.AddWithValue("@SerialParam", SerialValue);
                        break;
                    case 4:
                        UpdateBuilder.Append("`Description` = @DescriptionParam" + ',');
                        cmd.Parameters.AddWithValue("@DescriptionParam", DescriptionValue);
                        break;
                }
            }
            switch (PlaceHolder.Last())
            {
                case 1:
                    UpdateBuilder.Append("`Type` = @TypeParam");
                    cmd.Parameters.AddWithValue("@TypeParam", TypeValue);
                    break;
                case 2:
                    UpdateBuilder.Append("`Platform` = @PlatformParam");
                    cmd.Parameters.AddWithValue("@PlatformParam", PlatformValue);
                    break;
                case 3:
                    UpdateBuilder.Append("`Serial` = @SerialParam");
                    cmd.Parameters.AddWithValue("@SerialParam", SerialValue);
                    break;
                case 4:
                    UpdateBuilder.Append("`Description` = @DescriptionParam");
                    cmd.Parameters.AddWithValue("@DescriptionParam", DescriptionValue);
                    break;
            }
            UpdateBuilder.AppendFormat(" where `ID` = @IDParam" + ';');
            cmd.Parameters.AddWithValue("@IDParam", IDValue);
            return UpdateBuilder.ToString();
        }


        public void Update(MySqlConnection conn)
        {
            MySqlCommand UpdateItemCmd = new MySqlCommand();
            UpdateItemCmd.Connection = conn;
            UpdateItemCmd.CommandText = BuildUpdateQuery(UpdateItemCmd);
            UpdateItemCmd.ExecuteNonQuery();
        }

        public void UpsertCheckInOut(MySqlConnection conn, bool isCheckIn, bool conLive, bool isAudit=false)
        {
            //Write records checkin and checkout records only when con is live
            if (conLive)
            {

                MySqlCommand UpsertCommand = new MySqlCommand();
                UpsertCommand.Parameters.AddWithValue("@IDParam", IDValue);
                UpsertCommand.Connection = conn;

                if (isAudit)
                {
                    UpsertCommand.CommandText = "UPDATE `gaminginv`.`items` set `LogisticState` = @LogisticStateParam, `LogisticStateUpdated` = @LogisticStateUpdatedParam WHERE `ID` = @IDParam" + ';';
                    UpsertCommand.Parameters.AddWithValue("@LogisticStateParam", LogisticState);
                    UpsertCommand.Parameters.AddWithValue("@LogisticStateUpdatedParam", LogisticStateUpdated);
                    UpsertCommand.ExecuteNonQuery();
                }

                if (isCheckIn)
                {
                    UpsertCommand.CommandText = "UPDATE `gaminginv`.`items` SET `LastCheckIn` = @CheckInParam WHERE `ID` = @IDParam" + ';';
                    UpsertCommand.Parameters.AddWithValue("@CheckInParam", LastCheckInValue);
                    
                    UpsertCommand.ExecuteNonQuery();
                    UpsertCommand.CommandText = "INSERT INTO `gaminginv`.`checkinginout` (`Check`, `Direction`, `itemID`, `Duration`) VALUES(@CheckInParam" + ", \'In\'," + "@IDParam" + ", (select abs(timestampdiff(minute, `LastCheckIn`,`LastCheckOut`)) from `items` where `items`.`ID` = @IDParam" + "));";
                    UpsertCommand.ExecuteNonQuery();
                }
                else
                {
                    UpsertCommand.CommandText = "UPDATE `gaminginv`.`items` SET `LastCheckOut` = @CheckOutParam WHERE `ID` = @IDParam" + ';';
                    UpsertCommand.Parameters.AddWithValue("@CheckOutParam", LastCheckOutValue);
                    
                    UpsertCommand.ExecuteNonQuery();
                    UpsertCommand.CommandText = "INSERT INTO `gaminginv`.`checkinginout` (`Check`, `Direction`, `itemID`, `Duration`) VALUES(@CheckOutParam" + ", \'Out\'," + "@IDParam" + ", (select abs(timestampdiff(minute, `LastCheckIn`,`LastCheckOut`)) from `items` where `items`.`ID` = @IDParam" + "));";
                    UpsertCommand.ExecuteNonQuery();
                }
            }
        }
    }
}
