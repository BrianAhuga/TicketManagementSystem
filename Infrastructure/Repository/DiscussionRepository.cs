using Domain.Entities;
using Domain.Repository;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class DiscussionRepository : GenericRepository<Discussion>, IDiscussionRepository
    {
        public DiscussionRepository(AppDBContext dbContext) : base(dbContext)
        {
        }

        public List<Discussion> GetDiscussions(int ticketId)
        {
            return dbContext.Set<Discussion>()
                .Include(x => x.Attachments)
                .Include(x => x.User)
                .Where(x => x.TicketId == ticketId)
                .OrderBy(x => x.CreatedDate)
                .ToList();
        }
    }
}
