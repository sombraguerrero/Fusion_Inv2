using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace GamingInventory
{
    public class OwnerResult
    {
        decimal OwnerID_mem;
        int ItemCount_mem;
        string Badge_mem;
        string EmailAddr_mem;
        string PhoneNum_mem;
        string NameStr_mem;

        public OwnerResult()
        {
            OwnerID_mem = 0;
            ItemCount_mem = 0;
            Badge_mem = string.Empty;
            EmailAddr_mem = string.Empty;
            NameStr_mem = string.Empty;
            PhoneNum_mem = string.Empty;
        }

        public OwnerResult(decimal OwnerID, string Badge, string EmailAddr, string PhoneNum, string NameStr, int ItemCount)
        {
            OwnerID_mem = OwnerID;
            Badge_mem = Badge;
            EmailAddr_mem = EmailAddr;
            PhoneNum_mem = PhoneNum;
            NameStr_mem = NameStr;
            ItemCount_mem = ItemCount;
        }
        /****************************************
        override public string ToString()
        {
            return String.Format("{0} : {1} ", OwnerID_mem, NameStr_mem);
            //return String.Format("{0} : {1} | Badge: {2} | Phone: {3} | Email: {4} | Signed Return Policy: {5}", OwnerID, NameStr, Badge, PhoneNum, EmailAddr, SignedReturnPolicy);
        }

        public string EscapeCharInName()
        {
            string Escaped = string.Copy(NameStr_mem);
            List<int> ApostropheList = new List<int>();
            for (int i = 0; i < NameStr_mem.Length; i++)
            {
                if (NameStr_mem[i].Equals('\''))
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
        *****************************************************************************/

        public string BuildSelectQuery(MySqlCommand cmd)
        {
            StringBuilder SelectBuilder = new StringBuilder("select * from `gaminginv`.`owner` where ");
            List<int> PlaceHolder = new List<int>();
            if (!NameStr_mem.Equals(string.Empty))
                PlaceHolder.Add(1);
            if (!PhoneNum_mem.Equals(string.Empty))
                PlaceHolder.Add(2);
            if (!EmailAddr_mem.Equals(string.Empty))
                PlaceHolder.Add(3);
            if (!Badge_mem.Equals(string.Empty))
                PlaceHolder.Add(4);
            if (OwnerID_mem > 0)
                PlaceHolder.Add(5);
            for (int i = 0; i < PlaceHolder.Count - 1; i++)
            {
                switch (PlaceHolder.ElementAt(i))
                {
                    case 1:
                        SelectBuilder.Append("`Name` like %" + "@NameParam" + "% + and ");
                        cmd.Parameters.AddWithValue("@NameParam", NameStr_mem.ToLower());
                        break;
                    case 2:
                        SelectBuilder.Append("`Phone` = @PhoneParam and ");
                        cmd.Parameters.AddWithValue("@PhoneParam", PhoneNum_mem);
                        break;
                    case 3:
                        SelectBuilder.Append("`Email` like %" + "@EmailParam" + "% and ");
                        cmd.Parameters.AddWithValue("@EmailParam", EmailAddr_mem.ToLower());
                        break;
                    case 4:
                        SelectBuilder.Append("`BadgeName` like %" + "@BadgeParam" + "% and ");
                        cmd.Parameters.AddWithValue("@BadgeParam", Badge_mem.ToLower());
                        break;
                    case 5:
                        SelectBuilder.Append("`ID` = @IDParam and ");
                        cmd.Parameters.AddWithValue("@IDParam", OwnerID_mem);
                        break;
                }
            }
            switch (PlaceHolder.Last())
            {
                case 1:
                    SelectBuilder.Append("`Name` like %" + "@NameParam" + '%');
                    cmd.Parameters.AddWithValue("@NameParam", NameStr_mem.ToLower());
                    break;
                case 2:
                    SelectBuilder.Append("`Phone` = @PhoneParam");
                    cmd.Parameters.AddWithValue("@PhoneParam", PhoneNum_mem);
                    break;
                case 3:
                    SelectBuilder.Append("`Email` like %" + "@EmailParam" + '%');
                    cmd.Parameters.AddWithValue("@EmailParam", EmailAddr_mem.ToLower());
                    break;
                case 4:
                    SelectBuilder.Append("`BadgeName` = @BadgeParam");
                    cmd.Parameters.AddWithValue("@BadgeParam", Badge_mem.ToLower());
                    break;
                case 5:
                    SelectBuilder.Append("`ID` = @IDParam");
                    cmd.Parameters.AddWithValue("@IDParam", OwnerID_mem);
                    break;
            }
            SelectBuilder.Append(';');
            return SelectBuilder.ToString();
        }

        public string BuildUpdateQuery(MySqlCommand cmd)
        {
            StringBuilder UpdateBuilder = new StringBuilder("update `gaminginv`.`owner` set ");
            List<int> PlaceHolder = new List<int>();
            if (!NameStr_mem.Equals(string.Empty))
                PlaceHolder.Add(1);
            if (!PhoneNum_mem.Equals(string.Empty))
                PlaceHolder.Add(2);
            if (!EmailAddr_mem.Equals(string.Empty))
                PlaceHolder.Add(3);
            if (!Badge_mem.Equals(string.Empty))
                PlaceHolder.Add(4);
            for (int i = 0; i < PlaceHolder.Count - 1; i++)
            {
                switch (PlaceHolder.ElementAt(i))
                {
                    case 1:
                        UpdateBuilder.Append("`Name` = @NameParam" + ',');
                        cmd.Parameters.AddWithValue("@NameParam", NameStr_mem);
                        break;
                    case 2:
                        UpdateBuilder.Append("`Phone` = @PhoneParam" + ',');
                        cmd.Parameters.AddWithValue("@PhoneParam", PhoneNum_mem);
                        break;
                    case 3:
                        UpdateBuilder.Append("`Email` = @EmailParam" + ',');
                        cmd.Parameters.AddWithValue("@EmailParam", EmailAddr_mem);
                        break;
                    case 4:
                        UpdateBuilder.Append("`BadgeName` =  @BadgeParam" + ',');
                        cmd.Parameters.AddWithValue("@BadgeParam", Badge_mem);
                        break;
                }
            }
            switch (PlaceHolder.Last())
            {
                case 1:
                    UpdateBuilder.Append("`Name` = @NameParam");
                    cmd.Parameters.AddWithValue("@NameParam", NameStr_mem);
                    break;
                case 2:
                    UpdateBuilder.Append("`Phone` = @PhoneParam");
                    cmd.Parameters.AddWithValue("@PhoneParam", PhoneNum_mem);
                    break;
                case 3:
                    UpdateBuilder.Append("`Email` = @EmailParam");
                    cmd.Parameters.AddWithValue("@EmailParam", EmailAddr_mem);
                    break;
                case 4:
                    UpdateBuilder.Append("`BadgeName` = @BadgeParam");
                    cmd.Parameters.AddWithValue("@BadgeParam", Badge_mem);
                    break;
            }
            //UpdateBuilder.AppendFormat(" where `ID` = {0} or `Name` = \'{1}\' or `Phone` = \'{2}\' or `Email` = \'{3}\' or `BadgeName` = \'{4}\';", OwnerID, NameStr, PhoneNum, EmailAddr, Badge);
            UpdateBuilder.Append(" where `ID` = @FinalIDParam" + ';');
            cmd.Parameters.AddWithValue("@FinalIDParam", OwnerID_mem);
            return UpdateBuilder.ToString();
        }

        public void Update(MySqlConnection conn)
        {
            MySqlCommand thisUpdate = new MySqlCommand();
            thisUpdate.Connection = conn;
            thisUpdate.CommandText = BuildUpdateQuery(thisUpdate);
            thisUpdate.ExecuteNonQuery();
        }

        public string IDName { get { return NameStr_mem; } set { NameStr_mem = value; } }
        public decimal OwnerID { get { return OwnerID_mem; } set { OwnerID_mem = value; } }
        public string EmailAddress { get { return EmailAddr_mem; } set { EmailAddr_mem = value; } }
        public string PhoneNumber { get { return PhoneNum_mem; } set { PhoneNum_mem = value; } }
        public string BadgeName { get { return Badge_mem; } set { Badge_mem = value; } }
        public int ItemQty { get { return ItemCount_mem; } set { ItemCount_mem = value; } }

        public void Insert(MySqlConnection conn)
        {
            MySqlCommand GetNextID = new MySqlCommand("select max(`ID`) from `gaminginv`.`owner`", conn);
            MySqlCommand InsertOwner = new MySqlCommand();
            InsertOwner.Connection = conn;
            MySqlDataReader OwnerReader = GetNextID.ExecuteReader();
            int baseID = 0;
            if (OwnerReader.Read())
            {
                if (OwnerReader.IsDBNull(0))
                {
                    OwnerReader.Close();
                    InsertOwner.CommandText = "INSERT INTO `gaminginv`.`owner` (`ID`,`Name`, `Phone`, `Email`, `BadgeName`,`ItemCount`) VALUES(0,\'Priming Row\',\'0000000000\',\'ad_gaming@animedetour.com\',\'AD Gaming\',0);";
                    InsertOwner.ExecuteNonQuery();
                    OwnerReader = GetNextID.ExecuteReader();
                    OwnerReader.Read();
                    baseID = OwnerReader.GetInt32(0);
                }
                else
                    baseID = OwnerReader.GetInt32(0);
            }
            OwnerID_mem = baseID + 1000;
            OwnerReader.Close();
            InsertOwner.CommandText = "delete from `gaminginv`.`owner` where `ID` = 0";
            InsertOwner.ExecuteNonQuery();

            StringBuilder InsertBuilder = new StringBuilder();
            InsertBuilder.Append("INSERT INTO `gaminginv`.`owner` (`ID`,`Name`, `Phone`, `Email`, `BadgeName`,`ItemCount`) VALUES(");
            InsertBuilder.Append("@IDParam" + ',' + "@NameParam" + ',' + "@PhoneParam" + ',' + "@EmailParam" + ',' + "@BadgeParam" + ',' + "@CountParam" + ");");
            InsertOwner.Parameters.AddWithValue("@IDParam", OwnerID_mem);
            InsertOwner.Parameters.AddWithValue("@NameParam", NameStr_mem);
            InsertOwner.Parameters.AddWithValue("@PhoneParam", PhoneNum_mem);
            InsertOwner.Parameters.AddWithValue("@EmailParam", EmailAddr_mem);
            InsertOwner.Parameters.AddWithValue("@BadgeParam", Badge_mem);
            InsertOwner.Parameters.AddWithValue("@CountParam", ItemCount_mem);
            InsertOwner.CommandText = InsertBuilder.ToString();
            InsertOwner.ExecuteNonQuery();
        }
    }
}
