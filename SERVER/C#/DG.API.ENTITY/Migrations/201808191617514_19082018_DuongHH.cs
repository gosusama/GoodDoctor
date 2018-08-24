namespace DG.API.ENTITY.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _19082018_DuongHH : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Address",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 50),
                        AddressID = c.String(nullable: false, maxLength: 50),
                        AddressName = c.String(nullable: false),
                        NumberPhone = c.String(maxLength: 11),
                        ClinicID = c.String(maxLength: 50),
                        I_CREATE_DATE = c.DateTime(),
                        I_CREATE_BY = c.String(maxLength: 50),
                        I_UPDATE_DATE = c.DateTime(),
                        I_UPDATE_BY = c.String(maxLength: 50),
                        I_STATE = c.String(maxLength: 50),
                        UNITCODE = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.AU_NHOMQUYEN",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 50),
                        ID_GRP_PER = c.String(nullable: false, maxLength: 50),
                        NAME_GRP_PER = c.String(maxLength: 100),
                        DESC = c.String(maxLength: 200),
                        STATE = c.Int(nullable: false),
                        I_CREATE_DATE = c.DateTime(),
                        I_CREATE_BY = c.String(maxLength: 50),
                        I_UPDATE_DATE = c.DateTime(),
                        I_UPDATE_BY = c.String(maxLength: 50),
                        I_STATE = c.String(maxLength: 50),
                        UNITCODE = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.AU_NHOMQUYEN_CHUCNANG",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 50),
                        ID_GRP_PER = c.String(nullable: false, maxLength: 50),
                        ID_FUNC = c.String(nullable: false, maxLength: 50),
                        VIEW = c.Boolean(nullable: false),
                        ADD = c.Boolean(nullable: false),
                        EDIT = c.Boolean(nullable: false),
                        DELETE = c.Boolean(nullable: false),
                        CONFIRM = c.Boolean(nullable: false),
                        STATE = c.Int(nullable: false),
                        I_CREATE_DATE = c.DateTime(),
                        I_CREATE_BY = c.String(maxLength: 50),
                        I_UPDATE_DATE = c.DateTime(),
                        I_UPDATE_BY = c.String(maxLength: 50),
                        I_STATE = c.String(maxLength: 50),
                        UNITCODE = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.AU_NGUOIDUNG_NHOMQUYEN",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 50),
                        USERNAME = c.String(nullable: false, maxLength: 50),
                        ID_GRP_PER = c.String(nullable: false, maxLength: 50),
                        I_CREATE_DATE = c.DateTime(),
                        I_CREATE_BY = c.String(maxLength: 50),
                        I_UPDATE_DATE = c.DateTime(),
                        I_UPDATE_BY = c.String(maxLength: 50),
                        I_STATE = c.String(maxLength: 50),
                        UNITCODE = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.AU_NGUOIDUNG_QUYEN",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 50),
                        USERNAME = c.String(nullable: false, maxLength: 50),
                        ID_FUNC = c.String(nullable: false, maxLength: 50),
                        VIEW = c.Boolean(nullable: false),
                        ADD = c.Boolean(nullable: false),
                        EDIT = c.Boolean(nullable: false),
                        DELETE = c.Boolean(nullable: false),
                        CONFIRM = c.Boolean(nullable: false),
                        STATE = c.Int(nullable: false),
                        I_CREATE_DATE = c.DateTime(),
                        I_CREATE_BY = c.String(maxLength: 50),
                        I_UPDATE_DATE = c.DateTime(),
                        I_UPDATE_BY = c.String(maxLength: 50),
                        I_STATE = c.String(maxLength: 50),
                        UNITCODE = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Clinic",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 50),
                        ClinicID = c.String(nullable: false, maxLength: 50),
                        ClinicName = c.String(nullable: false),
                        ClinicDesc = c.String(),
                        PageRelationship = c.String(),
                        Type = c.String(),
                        I_CREATE_DATE = c.DateTime(),
                        I_CREATE_BY = c.String(maxLength: 50),
                        I_UPDATE_DATE = c.DateTime(),
                        I_UPDATE_BY = c.String(maxLength: 50),
                        I_STATE = c.String(maxLength: 50),
                        UNITCODE = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Diseases",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 50),
                        DiseasesID = c.String(nullable: false, maxLength: 50),
                        DiseasesName = c.String(nullable: false, maxLength: 50),
                        DiseasesDesc = c.String(),
                        I_CREATE_DATE = c.DateTime(),
                        I_CREATE_BY = c.String(maxLength: 50),
                        I_UPDATE_DATE = c.DateTime(),
                        I_UPDATE_BY = c.String(maxLength: 50),
                        I_STATE = c.String(maxLength: 50),
                        UNITCODE = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.DiseasesType",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 50),
                        DiseasesTypeID = c.String(nullable: false, maxLength: 50),
                        DiseasesTypeName = c.String(nullable: false, maxLength: 50),
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
            DropTable("dbo.DiseasesType");
            DropTable("dbo.Diseases");
            DropTable("dbo.Clinic");
            DropTable("dbo.AU_NGUOIDUNG_QUYEN");
            DropTable("dbo.AU_NGUOIDUNG_NHOMQUYEN");
            DropTable("dbo.AU_NHOMQUYEN_CHUCNANG");
            DropTable("dbo.AU_NHOMQUYEN");
            DropTable("dbo.Address");
        }
    }
}
