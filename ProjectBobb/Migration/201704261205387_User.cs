namespace ProjectBobb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class User : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "database_firewall_rules",
                c => new
                    {
                        id = c.Int(nullable: false),
                        name = c.String(nullable: false, maxLength: 128),
                        start_ip_address = c.String(nullable: false, maxLength: 45, unicode: false),
                        end_ip_address = c.String(nullable: false, maxLength: 45, unicode: false),
                        create_date = c.DateTime(nullable: false),
                        modify_date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.id, t.name, t.start_ip_address, t.end_ip_address, t.create_date, t.modify_date });
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Email = c.String(nullable: false, maxLength: 40),
                        Password = c.String(nullable: false, maxLength: 20),
                        Firstname = c.String(nullable: false, maxLength: 20),
                        Lastname = c.String(nullable: false, maxLength: 25),
                        Phonenumber = c.String(nullable: false),
                        Picture = c.String(),
                    })
                .PrimaryKey(t => t.Email);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("sys.database_firewall_rules");
        }
    }
}
