﻿
namespace SeMovieTutorial.BasicSamples.Forms
{
    using Serenity.ComponentModel;
    using System;
    using System.ComponentModel;

    [FormScript("BasicSamples.StaticTextBlock")]
    public class StaticTextBlockForm
    {
        [DisplayName("Static Text")]
        [StaticTextBlock(Text = "Here is some static text")]
        public String StaticText { get; set; }

        [StringEditor]
        public String SomeInput { get; set; }

        [DisplayName("Static Html")]
        [StaticTextBlock(Text = "<h4 style='margin-top: 0px;'>Here is an HTML list:</h2><ul><li>Item 1</li><li>Item 2</li><li>Item 3</li></ul>", IsHtml = true)]
        public String HtmlList { get; set; }

        [DisplayName("From a Local Text")]
        [StaticTextBlock(Text = "Site.Dashboard.ContentDescription", IsLocalText = true, IsHtml = true)]
        public String FromLocalText { get; set; }

        [DisplayName("Display Field Value")]
        [StaticTextBlock(IsHtml = true)]
        public String DisplayFieldValue { get; set; }
    }
}