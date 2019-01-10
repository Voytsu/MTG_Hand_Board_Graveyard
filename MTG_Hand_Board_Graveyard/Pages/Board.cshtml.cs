using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MTG_Hand_Board_Graveyard.Models;

namespace MTG_Hand_Board_Graveyard.Pages
{
    public class BoardModel : PageModel
    {
        private readonly MTG_Hand_Board_Graveyard.Models.MTG_Hand_Board_GraveyardContext _context;

        public BoardModel(MTG_Hand_Board_Graveyard.Models.MTG_Hand_Board_GraveyardContext context)
        {
            _context = context;
        }

        public IList<Card> Card { get;set; }

        public async Task OnGetAsync()
        {
            Card = await _context.Card.ToListAsync();
        }
    }
}
