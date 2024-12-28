﻿namespace RerunTest.Models
{
    //Model class are objects that represents the shape of the data and business logic. It maintains the data of the application//
    public class Inventory
    {

        public int ProductID { get; set; }

        public string InventoryTag { get; set; }

        public string ProductName { get; set; }

        public string Description { get; set; }

        public DateTime DateAssigned { get; set; }

        public string Distributor { get; set; }

        public string Custodian { get; set; }


    }
}
