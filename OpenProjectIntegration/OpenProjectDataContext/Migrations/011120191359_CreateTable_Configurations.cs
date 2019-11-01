using System;
using System.Collections.Generic;
using System.Text;
using FluentMigrator;

namespace OpenProjectDataContext.Migrations
{
    class _011120191359_CreateTable_Configurations : Migration
    {
        public override void Down()
        {
            throw new NotImplementedException();
        }

        public override void Up()
        {
            Create.Table("Configurations")
                .WithColumn("ConfigurationsId").AsInt32().NotNullable().ForeignKey()
                .WithColumn("ProjectId").AsInt32()
                .WithColumn("ProjectName").AsString(150)
                .WithColumn("TypeId").AsInt32()
                .WithColumn("StringUri").AsString();
        }
    }
}
