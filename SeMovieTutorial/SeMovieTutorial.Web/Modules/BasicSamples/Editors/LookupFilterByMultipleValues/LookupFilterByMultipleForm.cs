﻿
namespace SeMovieTutorial.BasicSamples.Forms
{
    using Serenity.ComponentModel;
    using System;
    using System.ComponentModel;

    [FormScript("BasicSamples.LookupFilterByMultiple")]
    [BasedOnRow(typeof(Northwind.Entities.ProductRow), CheckNames = true)]
    public class LookupFilterByMultipleForm
    {
        [Category("General")]
        public String ProductName { get; set; }
        public String ProductImage { get; set; }
        public Boolean Discontinued { get; set; }
        public Int32 SupplierID { get; set; }
        [ProduceSeafoodCategoryEditor]
        public Int32 CategoryID { get; set; }
        [Category("Pricing")]
        public String QuantityPerUnit { get; set; }
        public Decimal UnitPrice { get; set; }
        [Category("Status")]
        public Int16 UnitsInStock { get; set; }
        public Int16 UnitsOnOrder { get; set; }
        public Int16 ReorderLevel { get; set; }
    }
}