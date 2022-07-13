using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Einav
{
    public enum PlayerType { computer, human };
    
    class Player
    {
        PlayerType type;// סוג השחקן מחשב או בן אדם
        public List<Card> playerCards;// הקלפים שהשחקן מחזיק  
        public bool play;// האם השחקן משחק כרגע 
        public Player(PlayerType playerType) // פעולה בונה 
        {
            this.type = playerType;
            playerCards = new List<Card>();
        }
        public Player(bool Play)// פעולה המעדכנת האם השחקן משחק כרגע או לא 
        {
            Play = play;
        }
        public bool isplay()// פעולה המחזירה האם השחקן משחק או לא 
        {
            return play;
        }

        public int cardSum()// פעולה המחשבת את סכום הקלפים של השחקן
        {
            int sum = 0;
            for (int i = 0; i < playerCards.Count(); i++)// עוברת על מספר הקלפים של השחקן 
            {
                sum = sum + playerCards[i].getvalue();//מוסיפה לסכום את סכום הקלף 
            }
            return sum;// מחזירה את הסכום 
        }

    }
}
