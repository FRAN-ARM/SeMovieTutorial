﻿
namespace SeMovieTutorial.Northwind.Forms
{
    using Serenity.ComponentModel;
    using System;
    using System.ComponentModel;

    [ColumnsScript("Northwind.Region")]
    [BasedOnRow(typeof(Entities.RegionRow), CheckNames = true)]
    public class RegionColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 RegionID { get; set; }
        [EditLink, Width(300)]
        public String RegionDescription { get; set; }
    }
}