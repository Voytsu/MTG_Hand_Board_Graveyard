using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MTG_Hand_Board_Graveyard.Models
{
    public class MTG_Hand_Board_GraveyardContext : DbContext
    {
        public MTG_Hand_Board_GraveyardContext (DbContextOptions<MTG_Hand_Board_GraveyardContext> options)
            : base(options)
        {
        }

        public DbSet<Card> Card { get; set; }
    }
}
