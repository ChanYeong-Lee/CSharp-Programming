using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.VietMul
{
    internal class Card
    {
        private string suit;
        private int value;
        private string cardName;
        public Card(string suit, int value)
        {
            this.suit = suit;
            this.value = value;
            this.cardName = suit + " " + value.ToString();
            switch (value)
            {
                case 1: this.cardName = suit + " A"; break;
                case 11: this.cardName = suit + " J"; break;
                case 12: this.cardName = suit + " Q"; break;
                case 13: this.cardName = suit + " K"; break;
                default: break;
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine(this.cardName);

        }
        public string GetSuit() { return this.suit; }
        public int GetValue() { return this.value; }
    }
}
