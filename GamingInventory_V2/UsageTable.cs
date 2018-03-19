using System;
using System.Data;

namespace GamingInventory_V2
{
    class UsageTable : DataTable
    {
        DataColumn ItemID;
        DataColumn ItemOwnerName;
        DataColumn ItemSerial;
        DataColumn ItemDescription;
        DataColumn ItemType;
        DataColumn ItemPlatform;
        DataColumn ChkStamp;
        DataColumn ChkDirection;
        DataColumn ChkDuration;

        public UsageTable()
        {
            TableName = "CurrentTable";
            ItemID = new DataColumn("ItemID", Type.GetType("System.Decimal"));
            ItemOwnerName = new DataColumn("OwnerName");
            ItemSerial = new DataColumn("ItemSerial_Title");
            ItemDescription = new DataColumn("ItemDescription");
            ItemType = new DataColumn("ItemType");
            ItemPlatform = new DataColumn("ItemPlatform");
            ChkStamp = new DataColumn("Check");
            ChkDirection = new DataColumn("Direction");
            ChkDuration = new DataColumn("Duration(mins)", Type.GetType("System.Int32"));

            ItemID.Caption = "Item ID";
            ItemOwnerName.Caption = "Item Owner";
            ItemSerial.Caption = "Serial/Title";
            ItemDescription.Caption = "Item Description";
            ItemType.Caption = "Item Type";
            ItemPlatform.Caption = "Item Platform";
            ChkStamp.Caption = "Checking";
            ChkDirection.Caption = "In/Out";
            ChkDuration.Caption = "Duration (Minutes)";
            DataColumn[] cols = { ChkStamp, ChkDirection, ChkDuration, ItemID, ItemOwnerName, ItemType, ItemPlatform, ItemSerial, ItemDescription};
            Columns.AddRange(cols);
        }

        public void MakeRow(decimal ItemID, string ItemOwnerName, string ItemPlatform, string ItemSerial, string ItemDescription, string ItemType, string ChkDirection, string ChkStamp, int ChkDuration)
        {
            DataRow r = NewRow();
            r[this.ItemID] = ItemID;
            r[this.ItemDescription] = ItemDescription;
            r[this.ItemOwnerName] = ItemOwnerName;
            r[this.ItemPlatform] = ItemPlatform;
            r[this.ItemSerial] = ItemSerial;
            r[this.ItemType] = ItemType;
            r[this.ChkDirection] = ChkDirection;
            r[this.ChkDuration] = ChkDuration;
            r[this.ChkStamp] = ChkStamp;
            Rows.Add(r);
        }
    }
}
