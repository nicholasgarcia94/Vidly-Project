namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetBirthdayOfCustomer : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthday = '2000-01-05' WHERE Id = 1");
        }
        
        public override void Down()
        {
        }
    }
}
