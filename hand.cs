using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Einav
{
    class hand
    {

        private bool[] isPlay;// תכונה האם השחקן משחק כרגע 
        private List<Card> cards;//רשימת הקלפים של השחקן 
        List<Card> OrderedList = new List<Card>();// משתנה עזר רשימה מסודרת לפי סדר עולה 

        public hand(bool[] isPlay, List<Card> cards)//פעולה בונה
        {
            this.isPlay = isPlay;
            this.cards = cards;
           
        }
        public int Sumcards(List<Card> cards, int sumcards)//מחזירה את סכום הקלפים ברשימה 
        {
            for (int i = 0; i < cards.Count; i++)
            {
                sumcards += cards[i].getvalue();
            }
            return (sumcards);
        }

        public bool ISascendingOrder() // פעולה שבודקת האם האיברים בליסט בסדר עולה-בהפרש של אחד  
        {
            if (OrderedList.Count < 3)// בודק האם בכלל יש יותר או לפחות 3 איברים אחרת מחזיר שקר 
                return false;
            
            for (int i = 0; i<2; i++)
            {
                if (OrderedList[i].getvalue() != OrderedList[i + 1].getvalue() + 1)// בודק האם 2 איברים עוקבים הם בסדר עולה 
                {
                    return false;
                }

            }

            return true;
        }
        public bool sameType()//פעולה הבודקת האם כל הקלפים ברשימה הם בעלי אותו סוג
        {
            for (int i = 1; i < OrderedList.Count; i++)
            {
                if (OrderedList[i].gettype() != OrderedList[i - 1].gettype())// בודק האם איבר והאיבר הקודם לו ברשימה הם בעלי אותו סוג 
                    return false;
            }
            return true;
        }

        public bool sameValue()//בודק האם כל האיברים ברשימה הם בעלי אותו ערך 
        {
            for (int i = 1; i < OrderedList.Count; i++)
            {
                if (OrderedList[i].getvalue() != OrderedList[i - 1].getvalue())//בודק האם איבר והאיבר הקודם לו ברשימה הם בעלי אותו ערך 
                    return false;
            }
            return true;
        }
        public void setorderlist()//פעולה שמאתחלת את כל הרשימה המסודרת 
        {
            OrderedList.Clear();
        }

        public List <Card> list() // פעולה המחזירה את רשימת הקלפים של השחקן 
        {
            return (this.list());
        }

        public List<Card> Order(List<Card> cards, List<Card> OrderedList)// פעולה שלוקחת את הרשימה ומכניסה אותה לרשימה חדשה בסדר עולה
        {
            
            int i = 0, hight = 0;
            int x = cards[i].getvalue();

            while ((i + 1) < cards.Count)//הפעולה תפעל כל עוד מיקום הקלף פלוס אחד לא שווה למספר האיברים ברשימה זה על מנת למנוע חריגה 
                {
                    if (x < cards[i + 1].getvalue())//בודק מי הערך הכי גבוה ברשימה 
                    {
                        x = cards[i + 1].getvalue();//מעדכן את הערך הכי גבוה 
                        hight = i + 1;//שומר את האינדקס של הקלף הכי גבוה 
                    }
                    i++;
                }
            OrderedList.Add(cards[hight]);//מוסיף לרשימה המסודרת את הקלף הכי גבוה שמצאנו 
            cards.Remove(cards[hight]);//מסיר את הקלף הכי גבוה שמצאנו מהרשימה המקורית על מנת שנוכל למצוא את הקלף בעל הערך הכי גבוה השני 

            if (cards.Count != 0)// אם עדיין קיימים קלפים ברשימה 
                Order(cards, OrderedList);// הוא ימשיך לבצע את הפעולה עד שהרשימה של הקלפים תעבור כולה לרשימה המסודרת לפי הסדר 

            return (OrderedList);//מחזיר את הרשימה המסודרת 
        }
        public bool ok()//בודקת האם הפעולה שהשחקן עושה מקיימת את כל הכללים והחוקים של המשחק
        {
            Order(cards, OrderedList);// מעביר את הקלפים לרשימה מסודרת שיהיה לנו יותר קל לבדוק את חוקיות המהלך 
            if ((sameType() && ISascendingOrder() || sameValue()))// בודק האם הם באותו צורה ובסדר עולה או האם הלכולם יש את אותו ערך 
            {
                return true;
            }
            return false;//  אם אחד התנאים האלו לא מתקיימים המהלך לא חוקי והפעולה מחזירה שקר 
        }



    }
}
