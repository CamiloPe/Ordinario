namespace Ordinario.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicio : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Advisers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 30),
                        LastName = c.String(nullable: false, maxLength: 30),
                        PhoneNumber = c.String(maxLength: 20),
                        CellPhoneNumber = c.String(maxLength: 20),
                        Photo = c.String(maxLength: 250),
                        Email = c.String(maxLength: 30),
                        Department = c.String(maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Coaches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 30),
                        LastName = c.String(nullable: false, maxLength: 30),
                        Photo = c.String(maxLength: 250),
                        CellphoneNumber = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                        Adress = c.String(nullable: false, maxLength: 250),
                        postalCode = c.String(nullable: false, maxLength: 30),
                        phoneNumber = c.String(nullable: false, maxLength: 30),
                        webSite = c.String(maxLength: 100),
                        Email = c.String(nullable: false, maxLength: 150),
                        Photo = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 30),
                        LastName = c.String(nullable: false, maxLength: 30),
                        PhoneNumber = c.String(maxLength: 20),
                        CellphoneNumber = c.String(nullable: false, maxLength: 20),
                        Photo = c.String(maxLength: 250),
                        Email = c.String(nullable: false, maxLength: 30),
                        Department = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Coordinators",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 30),
                        LastName = c.String(nullable: false, maxLength: 30),
                        CellPhoneNumber = c.String(maxLength: 250),
                        Photo = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Majors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 30),
                        description = c.String(nullable: false, maxLength: 30),
                        Photo = c.String(maxLength: 250),
                        Email = c.String(),
                        CellphoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 30),
                        LastName = c.String(nullable: false, maxLength: 30),
                        Photo = c.String(maxLength: 250),
                        PhoneNumber = c.String(),
                        birthDate = c.String(),
                        CellphoneNumber = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
            DropTable("dbo.Majors");
            DropTable("dbo.Coordinators");
            DropTable("dbo.Contacts");
            DropTable("dbo.Companies");
            DropTable("dbo.Coaches");
            DropTable("dbo.Advisers");
        }
    }
}
