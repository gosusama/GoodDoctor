namespace DG.API.ENTITY.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_SYSUSER : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SYS_USER",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 50),
                        USERNAME = c.String(nullable: false, maxLength: 50),
                        PASSWORD = c.String(nullable: false, maxLength: 50),
                        FULLNAME = c.String(maxLength: 200),
                        PHONENUMBER = c.String(maxLength: 20),
                        USERID = c.String(maxLength: 20),
                        SEX = c.Int(nullable: false),
                        LEVEL = c.Int(),
                        STATUS = c.Int(nullable: false),
                        I_CREATE_DATE = c.DateTime(),
                        I_CREATE_BY = c.String(maxLength: 50),
                        I_UPDATE_DATE = c.DateTime(),
                        I_UPDATE_BY = c.String(maxLength: 50),
                        I_STATE = c.String(maxLength: 50),
                        UNITCODE = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SYS_USER");
        }
    }
}
