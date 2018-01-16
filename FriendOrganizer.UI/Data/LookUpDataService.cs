using FriendOrganizer.DataAccess;
using FriendOrganizer.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendOrganizer.UI.Data
{
    public class LookUpDataService : IFriendLookupDataService
    {
        private Func<FriendOrganizerDBContext> _contextCreator;

        public LookUpDataService(Func<FriendOrganizerDBContext> contextCreator)
        {
            _contextCreator = contextCreator;
        }

        public async Task<IEnumerable<LookUpItem>> GetFriendLookupAsync()
        {
            using(var ctx = _contextCreator())
            {
                return await ctx.Friends.AsNoTracking()
                    .Select(f => new LookUpItem
                    {
                        Id = f.Id,
                        DisplayMember = f.FirstName + " " + f.LastName
                    })
                    .ToListAsync();
            }
        }
    }
}
