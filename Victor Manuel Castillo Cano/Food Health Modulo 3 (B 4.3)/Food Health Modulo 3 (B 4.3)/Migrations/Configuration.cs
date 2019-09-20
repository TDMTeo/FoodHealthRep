namespace Food_Health_Modulo_3__B_4._3_.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Food_Health_Modulo_3__B_4._3_.Models.Food_Health_Modulo_3__B_4_3_Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Food_Health_Modulo_3__B_4._3_.Models.Food_Health_Modulo_3__B_4_3_Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
