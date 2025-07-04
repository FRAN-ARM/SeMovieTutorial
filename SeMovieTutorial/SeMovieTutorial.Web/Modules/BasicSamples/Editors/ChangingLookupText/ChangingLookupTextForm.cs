﻿
namespace SeMovieTutorial.BasicSamples.Forms
{
    using Serenity.ComponentModel;
    using System;

    [FormScript("BasicSamples.ChangingLookupText")]
    [BasedOnRow(typeof(Northwind.Entities.OrderDetailRow), CheckNames = true)]
    public class ChangingLookupTextForm
    {
        [ChangingLookupTextEditor]
        public Int32 ProductID { get; set; }
        public Decimal UnitPrice { get; set; }
        public Int32 Quantity { get; set; }
        public Double Discount { get; set; }
    }
}