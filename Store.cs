using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Security.Cryptography;

namespace Einav
{
    class Store
    {
        private List<Card> pack= new List<Card>();//מגדיר חבילת קלפים 

        Card card; // מגדיר קלף 
        //מגדיר את סוג הקלף 
        private List<Card.Shape> cardTypes = new List<Card.Shape>() { Card.Shape.spades, Card.Shape.clubs, Card.Shape.hearts, Card.Shape.diamonds };
        //מילון לקלפים המיוחדים 1,12,13 
        private Dictionary<int, string> specialCards = new Dictionary<int, string>() {  
            {1, "ace"}, //אם הןI שווה 1 בגדר ששמו אס
            {11, "jack"},
            {12, "queen"},
            {13, "king"},         
        };

        public static void Shuffle<T>(IList<T> list)//פעולה לערבוב החבילה 
        {
            RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
            int n = list.Count;
            while (n > 1)
            {
                byte[] box = new byte[1];
                do provider.GetBytes(box);
                while (!(box[0] < n * (Byte.MaxValue / n)));
                int k = (box[0] % n);
                n--;
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
        public Store()
        {

            
            string cardName;
            
            //תעבור על הרשימה ותיקח ערך מהרשימה של הסוג קלף עושה לפי הסדר
            foreach (Card.Shape cardType in cardTypes)  
            {
                for (int i = 2;   i <= 13; i++)
                {
                    cardName = i.ToString();// לוקח את המשתנה ן ומעביר אותו למחרוזת 

                    if (specialCards.ContainsKey(i))//מחפש האם הוא נמצא בתוך רשמית הקלפים המיוחדים  
                    {
                        cardName = specialCards[i];//אם הוא קלף מיוחד אז תקרא לו בשם המיוחד שלו 
                    }

                    char shortCardType = cardType.ToString()[0]; //לוקח את האות הראשונה בשם של הקלף המיוחד 

                    Bitmap cardImg = (Bitmap)Properties.Resources.ResourceManager.GetObject("_"+cardName + "_of_" + cardType);//ניגש לריסורס בשביל לקחת את התמונה השם של התמונה מתחיל בערך שלו 
                    card = new Card(i + shortCardType.ToString(), i, cardType, cardImg);
                    pack.Add(card);// מוסיף את הקלף לחבילה
                }
            }

            Shuffle<Card>(pack); // מערבב את החבילה 
        }
        public bool IsEmptyPack()//פעולה שבודקת האם החבילה ריקה ומחזירה אמת או שקר
        {
            if (this.pack.Count <= 0)
                return true;
            else
                return false;
        }

        public Card popcards()// מוציא קלף מהחבילה ומחזיר את הקלף
        {
                Card card = this.pack[0];
                this.pack.Remove(card);// מסיר את הקלף שהוא הוציא מהחבילה
                return (card);// מחזיר את הקלף 
        }

        public string getType(int i)
        {

            return cardTypes[i].ToString();
        }
    }
    
}
