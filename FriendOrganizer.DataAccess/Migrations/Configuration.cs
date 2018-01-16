namespace FriendOrganizer.DataAccess.Migrations
{
    using FriendOrganizer.Model;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<FriendOrganizerDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FriendOrganizerDBContext context)
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
