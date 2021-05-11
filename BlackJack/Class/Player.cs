using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Class
{
    public class Player : ICloneable
    {
        public string Name { get; set; }
        public int Chips { get; set; }
        public List<Card> CardList { get; set; }
        public int HandTotal { get; set; }
        public bool IsBlackJack { get; set; }
        public bool ShowTotal { get; set; }
        public Player(string name, bool showTotal)
        {
            Chips = 100;
            CardList = new List<Card>();
            HandTotal = 0;
            IsBlackJack = false;
            ShowTotal = true;
            Name = name;
            ShowTotal = showTotal;
        }

        public Player(){}


        public object Clone()
        {
            return new Player()
            {
                ShowTotal = ShowTotal,
                Name = Name,
                IsBlackJack = IsBlackJack,
                HandTotal = 0,
                Chips = 0,
                CardList = new List<Card>()
            };
        }
    }
}
