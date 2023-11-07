using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.VietMul
{
    internal class Player
    {
        private string name;
        private int money;
        private Card[] card =new Card[3];
        public Player(string name, int money)
        {
            this.name = name;
            this.money = money;
        }
        public void DrawCard(string suit, int value, int num)
        {
            card[num] = new Card(suit, value);
        }

        public int GetCardValue(int num)
        {
            return card[num].GetValue();
        }
        public void LossCard()
        {
            for (int i = 0; i < card.Length; i++)
            {
                card[i] = null;
            }
        }
        public string GetName()
        {
            return name;    
        }
        public int GetMoney()
        { return money; }   
        public void EarnMoney(int amount)
        {
            money += amount;
        }
        public void LossMoney(int amount)
        {
            money -= amount;
        }
        public void ShowCard(int num)
        {
            card[num].ShowInfo();   
        }
    }
}
