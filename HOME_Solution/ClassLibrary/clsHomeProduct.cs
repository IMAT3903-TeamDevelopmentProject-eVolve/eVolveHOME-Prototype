using System;

namespace ClassLibrary
{
    public class clsHomeProduct
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Type { get; set; }
        public string Collection { get; set; }
        public string Description { get; set; }
        public string Dimentions { get; set; }
        public int ProductID { get; set; }

        public bool Valid(string name, int price, string type, string collection, string description, string dimentions)
        {
            throw new NotImplementedException();
        }

        public bool Find(int productID)
        {
            throw new NotImplementedException();
        }
    }
}