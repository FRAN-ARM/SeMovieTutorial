﻿using FluentMigrator;
using FluentMigrator.Infrastructure;
using System;

namespace SeMovieTutorial.Migrations.DefaultDB
{

    [Migration(20160519154700)]
    public class DefaultDB_20160519_154700_GenreTable : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("Genre").InSchema("mov")
            .WithColumn("GenreId").AsInt32().NotNullable()
            .PrimaryKey().Identity()
            .WithColumn("Name").AsString(100).NotNullable();
            Alter.Table("Movie").InSchema("mov")
            .AddColumn("GenreId").AsInt32().Nullable()
            .ForeignKey("FK_Movie_GenreId", "mov", "Genre", "GenreId");
        }
    }
}