using System;
using System.Collections.Generic;
using System.Text;
using FluentMigrator;

namespace OpenProjectDataContext.Migrations
{
    class _011120191410_CreateTable_UserSystems : Migration
    {
        public override void Down()
        {
            throw new NotImplementedException();
        }

        public override void Up()
        {
            Create.Table("UserSystems")
                .WithColumn("UserSystemId").AsInt32().NotNullable().ForeignKey()
                .WithColumn("UserId").AsInt32()
                .WithColumn("UserName").AsString(150)
                .WithColumn("Password").AsString(150)
                .WithColumn("AccessToken").AsString();
        }
    }
}
