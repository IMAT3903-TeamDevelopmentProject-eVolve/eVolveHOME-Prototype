﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class clsHomeProduct
    {

        //private data members for the Products property
        private Int32 mProductID;
        //private data member for the product name
        private string mName;
        //private data member for the product price
        private Int32 mPrice;
        //private data member for the product type
        private string mType;
        //private data member for the product collection
        private string mCollection;
        //private data member for the product description
        private string mDescription;
        //private data member for the product dimentions
        private string mDimentions;

        //public Home Product Properties
        public int ProductID { get { return mProductID; } set{ mProductID = value; } }
        public string Name { get { return mName; } set { mName = value; } }
        public int Price { get { return mPrice; } set { mPrice = value; } }
        public string Type { get { return mType; } set { mType = value; } }
        public string Collection { get { return mCollection; } set { mCollection = value; } }
        public string Description { get { return mDescription; } set { mDescription = value; } }
        public string Dimentions { get { return mDimentions; } set { mDimentions = value; } }


        public bool Valid(string name, int price, string type, string collection, string description, string dimentions)
        {
            //crate a boolean var to flag the error
            Boolean OK = true;
            //if the Name is null
            if (name.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the name is larger than 10 chars
            if (name.Length > 10)
            {
                OK = false;
            }
            //if price is larger than 50000
            if (price > 50000)
            {
                OK = false;
            }
            //if type is null
            if (type.Length == 0)
            {
                OK = false;
            }
            //if type is larger than 10 chars
            if (type.Length > 10)
            {
                OK = false;
            }
            //if collection is larger than 20
            if (collection.Length > 20)
            {
                OK = false;
            }
            //if description is larger than 50
            if (description.Length > 50)
            {
                OK = false;
            }
            //if dimentions is larger than 15
            if (dimentions.Length > 15)
            {
                OK = false;
            }
            //return the value of OK
            return OK;
        }

        public bool Find(int productID)
        {
            throw new NotImplementedException();

            // Db connection is required to run the find method


            /*
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the productID to the search
            DB.AddParameter("@ProductID", ProductID);
            //execute the stor proc
            DB.Execute("sproc_tblHomeProduct_FilterByProductID");
            //if one record is found
            if (DB.Count == 1)
            {
                //copy from the DB to the private data members
                mProductID = Convert.ToInt32(DB.DataTable.Rows[0]["ProductID"]);
                mName = Convert.ToInt32(DB.DataTable.Rows[0]["Name"]);
                mPrice = Convert.ToInt32(DB.DataTable.Rows[0]["Price"]);
                mType = Convert.ToInt32(DB.DataTable.Rows[0]["Type"]);
                mCollection = Convert.ToInt32(DB.DataTable.Rows[0]["Collection"]);
                mDescription = Convert.ToInt32(DB.DataTable.Rows[0]["Description"]);
                mDimentions = Convert.ToInt32(DB.DataTable.Rows[0]["Dimentions"]);

                //return that everything worked
                return true;
            }
            //if no record was found
            else
            {
                //return false, indicating a problem
                return false;
            }

            */
        }
    }
}