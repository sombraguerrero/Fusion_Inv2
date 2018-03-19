using System;
using System.Data;
using GamingInventory;

namespace GamingInventory_V2
{
    class SearchTable : DataTable
    {
        DataColumn ItemID;
        DataColumn ItemOwnerName;
        DataColumn ItemSerial;
        DataColumn ItemDescription;
        DataColumn ItemType;
        DataColumn ItemPlatform;
        DataColumn LastCheckIn;
        DataColumn LastCheckOut;
        DataColumn isCheckedIn;

        public SearchTable()
        {
            ItemID = new DataColumn("ItemID", Type.GetType("System.Decimal"));
            ItemOwnerName = new DataColumn("OwnerName");
            ItemSerial = new DataColumn("ItemSerial_Title");
            ItemDescription = new DataColumn("ItemDescription");
            ItemType = new DataColumn("ItemType");
            ItemPlatform = new DataColumn("ItemPlatform");
            LastCheckIn = new DataColumn("LastCheckIn");
            LastCheckOut = new DataColumn("LastCheckOut");
            isCheckedIn = new DataColumn("CheckedIn", Type.GetType("System.Boolean"));
            ItemID.Caption = "Item ID";
            ItemOwnerName.Caption = "Item Owner";
            ItemSerial.Caption = "Serial/Title";
            ItemDescription.Caption = "Item Description";
            ItemType.Caption = "Item Type";
            ItemPlatform.Caption = "Item Platform";
            LastCheckIn.Caption = "Last Check-In";
            LastCheckOut.Caption = "Last Check-Out";
            isCheckedIn.Caption = "Last Checked In";
            DataColumn[] cols = { ItemID, ItemOwnerName, ItemType, ItemPlatform, ItemSerial, ItemDescription, LastCheckIn, LastCheckOut, isCheckedIn };
            Columns.AddRange(cols);
        }
        public void MakeRowFromtItemResult(ItemResult result)
        {
            DataRow r = NewRow();
            r[ItemID] = result.IDValue;
            r[ItemDescription] = result.DescriptionValue;
            r[ItemOwnerName] = result.OwnerValue;
            r[ItemPlatform] = result.PlatformValue;
            r[ItemSerial] = result.SerialValue;
            r[ItemType] = result.TypeValue;
            r[LastCheckIn] = result.LastCheckInValue;
            r[LastCheckOut] = result.LastCheckOutValue;
            r[isCheckedIn] = result.BindingCheckValue;
            Rows.Add(r);
        }
    }
}
