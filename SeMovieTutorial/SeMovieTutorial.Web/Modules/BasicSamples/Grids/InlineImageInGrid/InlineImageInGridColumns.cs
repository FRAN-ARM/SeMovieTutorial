﻿
namespace SeMovieTutorial.BasicSamples.Columns
{
    using Serenity.ComponentModel;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;

    [ColumnsScript("BasicSamples.InlineImageInGrid")]
    [BasedOnRow(typeof(Northwind.Entities.ProductRow), CheckNames = true)]
    public class InlineImageInGridColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public String ProductID { get; set; }
        [EditLink, Width(250)]
        public String ProductName { get; set; }
        [InlineImageFormatter, Width(450)]
        public String ProductImage { get; set; }
        [NotMapped, InlineImageFormatter(FileProperty = "ProductImage", Thumb = true), Width(450)]
        public String ProductThumbnail { get; set; }
    }
}