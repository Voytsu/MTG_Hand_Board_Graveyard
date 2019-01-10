using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MTG_Hand_Board_Graveyard.Models
{
    public class Card
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Cost { get; set; }

        public string Description { get; set; }

        public int Lieu { get; set; }

    }
}
