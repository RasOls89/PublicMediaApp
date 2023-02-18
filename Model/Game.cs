using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Game
    {
        public int GameId { get; set; }
        public string Titel { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public string Console { get; set; }
        public string Medium { get; set; }
        public string Developer { get; set; }
    }
}
