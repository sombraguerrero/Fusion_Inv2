using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace GamingInventory
{
    public class OwnerResult
    {
        public string IDName { get; set; }
        public decimal OwnerID { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string BadgeName { get; set; }
        public int ItemQty { get; set; }

        public OwnerResult()
        {
            OwnerID = 0;
            ItemQty = 0;
            BadgeName = string.Empty;
            EmailAddress = string.Empty;
            IDName = string.Empty;
            PhoneNumber = string.Empty;
        }

        public OwnerResult(decimal OwnerID, string Badge, string EmailAddr, string PhoneNum, string NameStr, int ItemCount)
        {
            this.OwnerID = OwnerID;
            BadgeName = Badge;
            EmailAddress = EmailAddr;
            PhoneNumber = PhoneNum;
            IDName = NameStr;
            ItemQty = ItemCount;
        }

        public string BuildSelectQuery(MySqlCommand cmd)
        {
            StringBuilder SelectBuilder = new StringBuilder("select * from `gaminginv`.`owner` where ");
            List<int> PlaceHolder = new List<int>();
            if (!IDName.Equals(string.Empty))
                PlaceHolder.Add(1);
            if (!PhoneNumber.Equals(string.Empty))
                PlaceHolder.Add(2);
            if (!EmailAddress.Equals(string.Empty))
                PlaceHolder.Add(3);
            if (!BadgeName.Equals(string.Empty))
                PlaceHolder.Add(4);
            if (OwnerID > 0)
                PlaceHolder.Add(5);
            for (int i = 0; i < PlaceHolder.Count - 1; i++)
            {
                switch (PlaceHolder.ElementAt(i))
                {
                    case 1:
                        SelectBuilder.Append("`Name` like %" + "@NameParam" + "% + and ");
                        cmd.Parameters.AddWithValue("@NameParam", IDName.ToLower());
                        break;
                    case 2:
                        SelectBuilder.Append("`Phone` = @PhoneParam and ");
                        cmd.Parameters.AddWithValue("@PhoneParam", PhoneNumber);
                        break;
                    case 3:
                        SelectBuilder.Append("`Email` like %" + "@EmailParam" + "% and ");
                        cmd.Parameters.AddWithValue("@EmailParam", EmailAddress.ToLower());
                        break;
                    case 4:
                        SelectBuilder.Append("`BadgeName` like %" + "@BadgeParam" + "% and ");
                        cmd.Parameters.AddWithValue("@BadgeParam", BadgeName.ToLower());
                        break;
                    case 5:
                        SelectBuilder.Append("`ID` = @IDParam and ");
                        cmd.Parameters.AddWithValue("@IDParam", OwnerID);
                        break;
                }
            }
            switch (PlaceHolder.Last())
            {
                case 1:
                    SelectBuilder.Append("`Name` like %" + "@NameParam" + '%');
                    cmd.Parameters.AddWithValue("@NameParam", IDName.ToLower());
                    break;
                case 2:
                    SelectBuilder.Append("`Phone` = @PhoneParam");
                    cmd.Parameters.AddWithValue("@PhoneParam", PhoneNumber);
                    break;
                case 3:
                    SelectBuilder.Append("`Email` like %" + "@EmailParam" + '%');
                    cmd.Parameters.AddWithValue("@EmailParam", EmailAddress.ToLower());
                    break;
                case 4:
                    SelectBuilder.Append("`BadgeName` = @BadgeParam");
                    cmd.Parameters.AddWithValue("@BadgeParam", BadgeName.ToLower());
                    break;
                case 5:
                    SelectBuilder.Append("`ID` = @IDParam");
                    cmd.Parameters.AddWithValue("@IDParam", OwnerID);
                    break;
            }
            SelectBuilder.Append(';');
            return SelectBuilder.ToString();
        }

        public string BuildUpdateQuery(MySqlCommand cmd)
        {
            StringBuilder UpdateBuilder = new StringBuilder("update `gaminginv`.`owner` set ");
            List<int> PlaceHolder = new List<int>();
            if (!IDName.Equals(string.Empty))
                PlaceHolder.Add(1);
            if (!PhoneNumber.Equals(string.Empty))
                PlaceHolder.Add(2);
            if (!EmailAddress.Equals(string.Empty))
                PlaceHolder.Add(3);
            if (!BadgeName.Equals(string.Empty))
                PlaceHolder.Add(4);
            for (int i = 0; i < PlaceHolder.Count - 1; i++)
            {
                switch (PlaceHolder.ElementAt(i))
                {
                    case 1:
                        UpdateBuilder.Append("`Name` = @NameParam" + ',');
                        cmd.Parameters.AddWithValue("@NameParam", IDName);
                        break;
                    case 2:
                        UpdateBuilder.Append("`Phone` = @PhoneParam" + ',');
                        cmd.Parameters.AddWithValue("@PhoneParam", PhoneNumber);
                        break;
                    case 3:
                        UpdateBuilder.Append("`Email` = @EmailParam" + ',');
                        cmd.Parameters.AddWithValue("@EmailParam", EmailAddress);
                        break;
                    case 4:
                        UpdateBuilder.Append("`BadgeName` =  @BadgeParam" + ',');
                        cmd.Parameters.AddWithValue("@BadgeParam", BadgeName);
                        break;
                }
            }
            switch (PlaceHolder.Last())
            {
                case 1:
                    UpdateBuilder.Append("`Name` = @NameParam");
                    cmd.Parameters.AddWithValue("@NameParam", IDName);
                    break;
                case 2:
                    UpdateBuilder.Append("`Phone` = @PhoneParam");
                    cmd.Parameters.AddWithValue("@PhoneParam", PhoneNumber);
                    break;
                case 3:
                    UpdateBuilder.Append("`Email` = @EmailParam");
                    cmd.Parameters.AddWithValue("@EmailParam", EmailAddress);
                    break;
                case 4:
                    UpdateBuilder.Append("`BadgeName` = @BadgeParam");
                    cmd.Parameters.AddWithValue("@BadgeParam", BadgeName);
                    break;
            }
            //UpdateBuilder.AppendFormat(" where `ID` = {0} or `Name` = \'{1}\' or `Phone` = \'{2}\' or `Email` = \'{3}\' or `BadgeName` = \'{4}\';", OwnerID, NameStr, PhoneNum, EmailAddr, Badge);
            UpdateBuilder.Append(" where `ID` = @FinalIDParam" + ';');
            cmd.Parameters.AddWithValue("@FinalIDParam", OwnerID);
            return UpdateBuilder.ToString();
        }

        public void Update(MySqlConnection conn)
        {
            MySqlCommand thisUpdate = new MySqlCommand();
            thisUpdate.Connection = conn;
            thisUpdate.CommandText = BuildUpdateQuery(thisUpdate);
            thisUpdate.ExecuteNonQuery();
        }

        public void Insert(MySqlConnection conn)
        {
            MySqlCommand addOwnerCmd = new MySqlCommand();
            addOwnerCmd.Connection = conn;
            addOwnerCmd.CommandType = System.Data.CommandType.StoredProcedure;
            addOwnerCmd.CommandText = @"insertOwner";
            addOwnerCmd.Parameters.AddWithValue("@NameParam", IDName);
            addOwnerCmd.Parameters.AddWithValue("@PhoneParam", PhoneNumber);
            addOwnerCmd.Parameters.AddWithValue("@EmailParam", EmailAddress);
            addOwnerCmd.Parameters.AddWithValue("@BadgeParam", BadgeName);
            addOwnerCmd.ExecuteNonQuery();
        }
    }
}
