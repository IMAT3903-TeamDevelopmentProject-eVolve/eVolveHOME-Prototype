using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace Testing
{
    [TestClass]
    public class tstProduct
    {
        [TestMethod]
        public void HomeProductInstanceOK()
        {
            //create an instance of clsHomeProduct
            clsHomeProduct AHomeProduct = new clsHomeProduct();
            //Check to see if it exists
            Assert.IsNotNull(AHomeProduct);
        }

        [TestMethod]
        public void HomeProductIDOK()
        {
            clsHomeProduct AHomeProduct = new clsHomeProduct();
            Int32 TestData = 1;
            AHomeProduct.ProductID = TestData;
            Assert.AreEqual(AHomeProduct.ProductID, TestData);
        }

        [TestMethod]
        public void HomeProductNameOK()
        {
            clsHomeProduct AHomeProduct = new clsHomeProduct();

            string TestData = "TestProductName";

            AHomeProduct.Name = TestData;

            Assert.AreEqual(AHomeProduct.Name, TestData);
        }

        [TestMethod]
        public void HomeProductPriceOK()
        {
            clsHomeProduct AHomeProduct = new clsHomeProduct();

            Int32 TestData = 21;

            AHomeProduct.Price = TestData;

            Assert.AreEqual(AHomeProduct.Price, TestData);
        }

        [TestMethod]
        public void HomeProductTypeOK()
        {
            clsHomeProduct AHomeProduct = new clsHomeProduct();

            string TestData = "TestProductType";

            AHomeProduct.Type = TestData;

            Assert.AreEqual(AHomeProduct.Type, TestData);
        }

        [TestMethod]
        public void HomeProductCollectionOK()
        {
            clsHomeProduct AHomeProduct = new clsHomeProduct();

            string TestData = "TestProductCollection";

            AHomeProduct.Collection = TestData;

            Assert.AreEqual(AHomeProduct.Collection, TestData);
        }

        [TestMethod]
        public void HomeProductDescriptionOK()
        {
            clsHomeProduct AHomeProduct = new clsHomeProduct();

            string TestData = "TestProductDescription";

            AHomeProduct.Description = TestData;

            Assert.AreEqual(AHomeProduct.Description, TestData);
        }

        [TestMethod]
        public void HomeProductDimentionsOK()
        {
            clsHomeProduct AHomeProduct = new clsHomeProduct();

            string TestData = "31,31,31";

            AHomeProduct.Dimentions = TestData;

            Assert.AreEqual(AHomeProduct.Dimentions, TestData);
        }

        [TestMethod]
        public void HomeProductValidMethodOK()
        {
            //crate an instance of clsHomeProduct
            clsHomeProduct AHomeProduct = new clsHomeProduct();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the methid
            string Name = "TestProductName";
            Int32 Price = 21;
            string Type = "TestProductType";
            string Collection = "TestProductCollection";
            string Description = "testProductDescription";
            string Dimentions = "31,31,31";
            //invoke the method
            OK = AHomeProduct.Valid(Name, Price, Type, Collection, Description, Dimentions);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void HomeProductFindMethodOK()
        {
            clsHomeProduct AHomeProduct = new clsHomeProduct();

            Boolean Found = false;

            Int32 ProductID = 1;

            Found = AHomeProduct.Find(ProductID);

            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void HomeProductIDNotFound()
        {
            clsHomeProduct AHomeProduct = new clsHomeProduct();
            //bool to store the result of the search
            Boolean Found = false;
            //bool to store the result if data is ok
            Boolean OK = true;
            Int32 ProductID = 1;
            //invoke the methid
            Found = AHomeProduct.Find(ProductID);
            //check the ID 
            if (AHomeProduct.ProductID != 1)
            {
                OK = false;
            }
            //test to see if the results are correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void HomeProductNameNotFound()
        {
            clsHomeProduct AHomeProduct = new clsHomeProduct();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductID = 1;
            Found = AHomeProduct.Find(ProductID);
            if (AHomeProduct.Name != "TestProductName")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void HomeProductPriceNotFound()
        {
            clsHomeProduct AHomeProduct = new clsHomeProduct();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductID = 1;
            Found = AHomeProduct.Find(ProductID);
            if (AHomeProduct.Price != 100)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void HomeProductTypeNotFound()
        {
            clsHomeProduct AHomeProduct = new clsHomeProduct();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductID = 1;
            Found = AHomeProduct.Find(ProductID);
            if (AHomeProduct.Type != "TestProductType")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void HomeProductCollectionNotFound()
        {
            clsHomeProduct AHomeProduct = new clsHomeProduct();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductID = 1;
            Found = AHomeProduct.Find(ProductID);
            if (AHomeProduct.Collection != "TestProductCollection")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void HomeProductDescriptionNotFound()
        {
            clsHomeProduct AHomeProduct = new clsHomeProduct();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductID = 1;
            Found = AHomeProduct.Find(ProductID);
            if (AHomeProduct.Description != "TestProductDescription")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void HomeProductDimentionsNotFound()
        {
            clsHomeProduct AHomeProduct = new clsHomeProduct();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductID = 1;
            Found = AHomeProduct.Find(ProductID);
            if (AHomeProduct.Dimentions != "TestProductDimentions")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }



        // Testing Data Input Data types and entry lengths 

        [TestMethod]
        public void ProductNameMinLessOne()
        {
            clsHomeProduct AHomeProduct = new clsHomeProduct();
            Boolean OK = false;
            //Test Data for the method
            string Name = ""; // must contain 1 char
            Int32 Price = 21;
            string Type = "ExampleType";
            string Collection = "ExampleCollection";
            string Description = "ExampleDescription";
            string Dimentions = "ExampleDimentions";
            // invoke the method
            OK = AHomeProduct.Valid(Name, Price, Type, Collection, Description, Dimentions);
            //test for result 
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void ProductNameMin()
        {
            clsHomeProduct AHomeProduct = new clsHomeProduct();
            Boolean OK = false;
            //Test Data for the method
            string Name = "A"; // must contain 1 char
            Int32 Price = 21;
            string Type = "ExampleType";
            string Collection = "ExampleCollection";
            string Description = "ExampleDescription";
            string Dimentions = "ExampleDimentions";
            // invoke the method
            OK = AHomeProduct.Valid(Name, Price, Type, Collection, Description, Dimentions);
            //test for result 
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void ProductNameMinPlusOne()
        {
            clsHomeProduct AHomeProduct = new clsHomeProduct();
            Boolean OK = false;
            //Test Data for the method
            string Name = "AA"; // must contain 1 char
            Int32 Price = 21;
            string Type = "ExampleType";
            string Collection = "ExampleCollection";
            string Description = "ExampleDescription";
            string Dimentions = "ExampleDimentions";
            // invoke the method
            OK = AHomeProduct.Valid(Name, Price, Type, Collection, Description, Dimentions);
            //test for result 
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void ProductNameMaxLessOne()
        {
            clsHomeProduct AHomeProduct = new clsHomeProduct();
            Boolean OK = false;
            //Test Data for the method
            string Name = "AAAAAAAAA"; // must contain 1 char (9 char)
            Int32 Price = 21;
            string Type = "ExampleType";
            string Collection = "ExampleCollection";
            string Description = "ExampleDescription";
            string Dimentions = "ExampleDimentions";
            // invoke the method
            OK = AHomeProduct.Valid(Name, Price, Type, Collection, Description, Dimentions);
            //test for result 
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void ProductNameMax()
        {
            clsHomeProduct AHomeProduct = new clsHomeProduct();
            Boolean OK = false;
            //Test Data for the method
            string Name = "AAAAAAAAAA"; // must contain 1 char (10 char)
            Int32 Price = 21;
            string Type = "ExampleType";
            string Collection = "ExampleCollection";
            string Description = "ExampleDescription";
            string Dimentions = "ExampleDimentions";
            // invoke the method
            OK = AHomeProduct.Valid(Name, Price, Type, Collection, Description, Dimentions);
            //test for result 
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void ProductNameMaxPlusOne()
        {
            clsHomeProduct AHomeProduct = new clsHomeProduct();
            Boolean OK = false;
            //Test Data for the method
            string Name = "AAAAAAAAAAA"; // must contain 1 char (11 char)
            Int32 Price = 21;
            string Type = "ExampleType";
            string Collection = "ExampleCollection";
            string Description = "ExampleDescription";
            string Dimentions = "ExampleDimentions";
            // invoke the method
            OK = AHomeProduct.Valid(Name, Price, Type, Collection, Description, Dimentions);
            //test for result 
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void ProductNameMid()
        {
            clsHomeProduct AHomeProduct = new clsHomeProduct();
            Boolean OK = false;
            //Test Data for the method
            string Name = "AAAAA"; // must contain 1 char (5 char)
            Int32 Price = 21;
            string Type = "ExampleType";
            string Collection = "ExampleCollection";
            string Description = "ExampleDescription";
            string Dimentions = "ExampleDimentions";
            // invoke the method
            OK = AHomeProduct.Valid(Name, Price, Type, Collection, Description, Dimentions);
            //test for result 
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void ProductNameExtremeMax()
        {
            clsHomeProduct AHomeProduct = new clsHomeProduct();
            Boolean OK = false;
            //Test Data for the method
            string Name = ""; // must contain 1 char (500 char)
            Name = Name.PadRight(500, 'A'); // fill var with 500 'A'
            Int32 Price = 21;
            string Type = "ExampleType";
            string Collection = "ExampleCollection";
            string Description = "ExampleDescription";
            string Dimentions = "ExampleDimentions";
            // invoke the method
            OK = AHomeProduct.Valid(Name, Price, Type, Collection, Description, Dimentions);
            //test for result 
            Assert.IsFalse(OK);
        }
    }
}
