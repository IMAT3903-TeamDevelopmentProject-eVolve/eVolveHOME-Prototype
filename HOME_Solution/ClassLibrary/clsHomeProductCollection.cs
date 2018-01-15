using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsHomeProductCollection
    {
        //private data member for the list

        //Class Constructor Here


        
        public List<clsHomeProduct> HomeProductList { get; set; }
        public clsHomeProduct ThisHomeProduct { get; set; }
        public int Count { get; set; }

        public int Add()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }
    }
}