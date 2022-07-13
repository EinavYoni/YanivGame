using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Einav
{
    class ComputerMove
    {
        Player computer;
        List<List<Card>> identicalCards = new List<List<Card>>();          
        List<Card> copyList = new List<Card>();
        List<Card> orderList;
        public ComputerMove(Player computer)
        {
            this.computer = computer;
        }
        public List<Card> copy()// פעולה שמעתיקה את הרשימה של הקלפים של המחשב לרשימה חדשה 
        {
           
            for (int i = 0; i < this.computer.playerCards.Count(); i++)
            {
                copyList.Add(computer.playerCards[i]);
            }
            return (copyList);// העתק של הרשימה על מנת שיהיה יותר קל לשחק 
        }

        public List<List<Card>> SearchIdenticalCards()//  למעשה מציג אופציות של המהלכים שהמחשב יכול לבצבע . מחפש האם יש קלפים בעלי אותו ערך ומכניס אותם לתוך רשימה 
        {
                copy();// רשימת עזר על מנת לא לפגוע ברשימה המקורית 
                int mone = 0; // בודק האם יש יותר מקלף אחד בעל אותו ערך         
                Card x;
                int j = 0; // משתנה שעוזר לנו לעבור לאופציה הבאה כלומר לרשימה הבאה  
                while (copyList.Count() != 0)
                {
                    List<Card> option = new List<Card>();
                    x = copyList[0];
                    copyList.Remove(copyList[0]);
                    option.Add(x);//מוסיף את הקלף הראשון לרשימת האופציות מאוחר יותר אם לא ימצא מתאים הוא יסיר אותו 
                   
                    for (int i = 0; i < copyList.Count(); i++)
                    {
                        if (copyList[i].getvalue() == x.getvalue() && x.getvalue() != 0)// במידה והקלפים הם בעלי אותו ערך ולא שווים לאפס שזהו קלף הדדמה זו יכולה להיות אופציה 
                        {
                            mone++; // מונה על מנצ לבדוק האם יש לפחות עוד קלף בעל אותו ערך                      
                            option.Add(copyList[i]);// מוסיף את הקלף בעל הערך הזהה לרשימה 
                            copyList.Remove(copyList[i]);//מ סיר את הקלף מהרשימה המועתקת 
                        }
                    }

                    if (mone != 0)// אם מצאנו אופציה טובה של קלפים כלומר המונה לא שווה לאפס 
                    {
                        identicalCards.Add(option);//מוסיף את רשימת הקלפים שמצאנו כרגע לרשימה של כל האופציות 
                        mone = 0;//מעדכן את המונה לאפס כי הוא עכשיו מחיל לחפש אופציה נוספת 
                        j++; // לאחר שכבר הוכנס לתא מהלך אשרי עובר לתא הבא בשביל להציג עוד מהלך אפשרי 
                    }
                    else// במידה ולא היה עוד קלף זהה לקלף ה X אנחנו נוציא אותו מהרשימה 
                    {
                        option.Remove(x);//במידה ולא מאנו קלף בעל ערך זהה לקלף שכבר הוכנס לרשימת האופציה אנחנו נסיר את הקלף מהרשימה 
                    }

                }              
            return (identicalCards);// מחזיר את כל האופציות שהמחשב יכול לבצע כל אופציה נתונה בתוך רשימה בתוך הרשימות 
        }

        public int mostCardsOption(List<List<Card>> c)// פעולה שמחזירה את האינדקס של הרשימה עם הכי הרבה קלפים 
        {
            int bigest = 0;// משתנה שמציג את מספר הקלפים הגדול ביותר שנוכל להוריד
            int numOfList = -1;//שומר את האינדקס של הרשימה בעלת מספר הקלפים הגדול ביותר שאפשר להוריד 
            for (int i = 0; i < c.Count(); i++)
            {
                if (c[i].Count() > bigest)
                {
                    numOfList = i;                 
                }
            }
            return numOfList;
        }

        public bool inTheplayerCards(Card card)// בודק האם נמצא קלף בעל ערך זהה בקלפים שמחזיק המחשב
        {
            for (int i = 0; i < computer.playerCards.Count(); i++)//עובר על הקלפים של השחקן 
            {
                if (computer.playerCards[i].getvalue() == card.getvalue())//בודק האם הערכים שלהם זההים 
                    return true;
            }
            return false;
        }
        public List<Card> order()// פעולה שמסדרת את הקלפים מהקטן לגדול 
        {
            copy();// מעתיק רשימת עזר בשביל שלא נהרוס את המקורית 
            List<Card> order = new List<Card>();//יוצר רשימה חדשה שאליה נכניס את הקלפים בסדר עולה
            int length = copyList.Count();
            for (int i = 0; i < length; i++)
            {
                Card small = theSmallestNum(copyList);//פעולה שמוצאת את הקלף בעל הערך הכי נמוך ברשימה 
                order.Add(small);//מוסיפה לרשימה המסודרת את הקלף הכי נמוך 
                copyList.Remove(small);//מסירה מהרשימת העזר את הקלף הכי נמוך 
            }
            return (order);//מחזיר את הרשימה המסודרת 
        }

        public List<Card> ascendingOrder()// בודק האם יש בקלפים סדר עולה ומאותו סוג ואם כן מחזיר רשימה עם קלפים אלה
        {
            List<Card> ascend = new List<Card>();//רשימה של קלפים שנכניס אליה את הקלפים בסדר מאותה צורה בסדר עולה אם קיימים כאלה ברשימת הקלפים שמחזיק המחשב
            orderList = order();//רשימת עזר בסדר עולה 
            int mone = 0;// לבדוק האם זה יותר משני קלפים בסדר עולה 
            bool v = true;//בודק האם יש רצף בסדר העולה 
            ascend.Add(orderList[0]);
            for (int i = 0; i < (orderList.Count()-1); i++)
            {
                if (orderList[i].getvalue() == (orderList[i + 1].getvalue() - 1))//בודק האם הערך של הקלף ה1 והקלף שאחריו שווים זה לזה במידה ומחסירים מהקלף שאחריו 1 
                {
                    ascend.Add(orderList[i + 1]);//מוסיפים גם את הקלף הזה לרשימה העולה 
                    if (v)//אם זה קרה ברצף 
                        mone++;//מסופים את כמות הפעמים שכבק היה לנו קלפים בסדר עולה 
                }
                else
                {
                    if (mone < 2)//אם היה רצף של פחות מ2 קלפים 
                    {
                        ascend.Clear();//נקה את כל הרשימה 
                        v = true;
                        mone = 0;//אפס את המונה לרצף הבא 
                        ascend.Add(orderList[i + 1]);//מוסיף את הקלף הבא לרשימת הסדר העולה 
                    }

           //במידה וכבר נמצאו 3 קלפים או יותר בסדר עולה והרצף נקטע אל תמשיך להוסיף קלפים מפני שיש רק 5 קלפים לכן ישנה רק אפשרות שיהיה סדר עולה פעם אחת בהתחשב בעובדה שסדר עולה חייב לכלול לפחות 3 קלפים 
                    else
                        v = false;
                }

            }
            if (mone < 2 || (!sameType(ascend)))//אם יש רצף עולה של פחות מ2 קלפים או שהקלפים הם לא בעלךי אותה צורה נקה את הרשימה כי לא קיים סדר עולה 
                ascend.Clear();

            return (ascend);//החזר רשימת סדר עולה אם אין מחזיר רשימה ריקה 
        }

        public bool sameType(List<Card> ascend)//פעולה הבודקת האם כל הקלפים ברשימה הם בעלי אותו סוג
        {
            for (int i = 1; i < ascend.Count; i++)// עובר על כל הקלפים 
            {
                if (ascend[i].gettype() != ascend[i - 1].gettype())//בודק האם הם כולם בעלי אותו צורה אם לא מחזיר שקר 
                    return false;
            }
            return true;//אם עברנו על כל הקלפים ואף אחד ללא החזיר שקר הפעולה תחזיר אמת 
    
       }

        public Card theSmallestNum(List<Card> c)// מוצא את הקלף הכי נמוך ברשימה
        {
            Card small = c[0];//מוציא את הקלף הראשון ברשימה 
            for (int i = 1; i < c.Count(); i++)//עובר על כל הקלפים ברשימה 
            {
                if (small.getvalue() >= c[i].getvalue())//בודק האם הקלף הוא בעל הערך הכי נמוך 
                {
                    small = c[i];//משנה את הקלף לקלף החדש בעל הערך הכי נמוך שנמצא 
                }
            }
            return (small);//מחזיר את הקלף 
        }
        public List<Card> WhatIsTheSmartestMove()//בודק מה הפעולה הכי חכמה שהמחשב צריך לעשות ואז מחזיר רשימה של קלפים או קלף שהמחשב צריך לזרוק 
        {
            List<Card> ascending = ascendingOrder();// מחזיר רשימה של קלפים בסדר עולה 
            List<List<Card>> c = SearchIdenticalCards();//מחזיר רשימת אופציות של קלפים בעלי ערך זהה 
            List<Card> themove = new List<Card>();//רשימה שבה נכניס את האופציה הטובה ביותר שהמחשב יכול לעשות 
            int option1 = mostCardsOption(c);//מחזיר את האינדקס של הרשימה שמורידה הכי הרבה קלפים מכל הרשימות 

            if (option1 != -1)//אם קיימת אופציה כזו בכלל של רשימה בעל הכי הרבה קלפים להוריד אז האינדקס של הרשימה לא שווה מינוס 1 
                if (c[option1].Count() > ascending.Count())//בודק איזה מהאופציות המחשב יוריד יותר קלפים   
                    return (c[option1]);//מחזיר את הרשימה עם האינקס של מספר הקלפים הגדול ביותר שהמחשב יכול להוריד 

            if (ascending.Count() != 0)//אם יש בכלל קלפים ברשימת הסדר העולה החזר רשימה זו 
                return (ascending);


         themove.Add(orderList[(orderList.Count()-1)]);//מוסיף לרשימת המהלך את הקלף בעל הערך הכי גבוה 
         return (themove);   // אם אין קלפים בעלי אותו ערך ואין קלפים בעלי סדר עולה המחשב יוריד את הקלף בעל הערך הכי גבוה בשביל להפחית את סכום הנקודות שיש  לו ביד     
       
        }
        public bool IsItInTheList(Card c)//פעולה המקבלת קלף ומחזירה אמת אם הוא נמצא ביד של המחשב
        {
            for (int i = 0; i < computer.playerCards.Count(); i++)
            {
                if (c == computer.playerCards[i])//בודק אם הקלפים זההים 
                    return true;
            }
            return false;
        }

        public bool PartOfAscendingOrder(Card car)// בודק האם הקלף משלים לסדר עולה עם הקלפים שנמצאים ביד המחשב
        {
            for (int i = 0; i < orderList.Count()-1; i++)
            {
                if (car.getvalue() - 1 == orderList[i + 1].getvalue() && orderList[i + 1].getvalue() == orderList[i].getvalue() + 1)//  4-1==3 &&3==2+1 .דוגמא קלפים של המחשב:2 ו3 קלפים שזרוקים הם 2
                    if (car.GetType() == orderList[i + 1].GetType() && orderList[i + 1].GetType() == orderList[i].GetType())//בודק האם כולם אותו סוג 
                    {
                        return true;//אומר למחשב שכדאי לו לקחת קלף הזרוק על השולחן 
                    }
                    else if (car.getvalue() - 1 == orderList[i + 1].getvalue() && orderList[i + 1].getvalue() == orderList[i].getvalue() - 1)//   6,8  והקלף שבזיקה הוא 7 -דוגמא האם 7-1==6 && 7==8-1 במקרה הזה הקלפים של המחשב הם 
                        if (car.GetType() == orderList[i + 1].GetType() && orderList[i + 1].GetType() == orderList[i].GetType()) //בודק האם כולם אותו סוג 
                        {
                            return true;// אומר למחשב שכדאי לו לקחת קלף הזרוק על השולחן 
                        }        
            }
            return false;//במידה והקלף שזרוק על השולחן לא משלים למחשב סדר עולה המחשב לא יקח אותו 
        }
        public void RemoveTheCards()// מוריד את הקלפים מהיד של המחשב 
        {
            List<Card> theComMove = WhatIsTheSmartestMove();//רואה את האופציה הכי טובה שהמחשב יכול לשחק 
            for (int i = 0; i < theComMove.Count(); i++)
            {
                if (IsItInTheList(theComMove[i]))//בודק האם הקלף שהוא האופציה הטובה ביותר למחשב לשחק נמצא בידו של המחשב ואז מסיר אותה 
                    computer.playerCards.Remove(theComMove[i]);
            }
        }

        public bool takeTHATcard(Card bincard)// ובודק הם סכום הקלפים כולל הקלף מהקופה קטן משבע בודק האם לקחת את הקלף מהזריקה במידה ולמחשב יש קלף אחד 
        {
            int SumOfTheSm=0;
            List<Card> smartMove= WhatIsTheSmartestMove();
            for (int i = 0; i < smartMove.Count(); i++)
            {
                SumOfTheSm += smartMove[i].getvalue();
            }
            if ((computer.cardSum() + bincard.getvalue())-SumOfTheSm <= 7)
                return true;

            int moneone = 0;
            for (int i = 0; i < 5; i++)
            {
                if (computer.playerCards[i].getvalue() != 0)
                    moneone++;
            }
            if (moneone == 1)
                if (bincard.getvalue() <= 7)
                    return true;

                    return false;
        }
        

    }
}
