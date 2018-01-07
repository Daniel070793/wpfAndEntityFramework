namespace FriendOrganizer.DataAccess.Migrations
{
    using FriendOrganizer.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FriendOrganizer.DataAccess.FriendOrganizerDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FriendOrganizer.DataAccess.FriendOrganizerDBContext context)
        {
            context.Friends.AddOrUpdate(
                f => f.FirstName,
                new Friend { FirstName = "Daniel", LastName = "Sørensen" },
                new Friend { FirstName = "Martine", LastName = "Jensen" },
                new Friend { FirstName = "Test", LastName = "Testsen" },
                new Friend { FirstName = "Hej", LastName = "Hejsen" }
                );
        }
    }
}
