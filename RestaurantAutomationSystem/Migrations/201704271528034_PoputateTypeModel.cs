namespace RestaurantAutomationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PoputateTypeModel : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO TypeModels (Id, Name) VALUES (1, 'Meat')");
            Sql("INSERT INTO TypeModels (Id, Name) VALUES (2, 'Seafood')");
            Sql("INSERT INTO TypeModels (Id, Name) VALUES (3, 'Pizza')");
            Sql("INSERT INTO TypeModels (Id, Name) VALUES (4, 'Sub')");
            Sql("INSERT INTO TypeModels (Id, Name) VALUES (5, 'Gyro')");
            Sql("INSERT INTO TypeModels (Id, Name) VALUES (6, 'Baked')");
        }                                                            

        public override void Down()
        {
            Sql("DELETE FROM TypeModels WHERE Id IN (1, 2, 3, 4, 5, 6)");
        }
    }
}
