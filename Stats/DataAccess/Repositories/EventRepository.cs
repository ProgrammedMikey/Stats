using Stats.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Stats.DataAccess.Repositories
{
    public class EventRepository : Repository<GameEvent>
    {
        public EventRepository(StatsDbContext context) : base (context) { }
    }
}