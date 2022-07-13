using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Einav
{
    public class Card
    {
        private string name;//  שם הקלף תכונה
        private int cardvalue = 0;//  ערך הקלף
        public enum Shape { diamonds, clubs, spades, hearts }// צורה של הקלף 
        private Shape shape;
        private Image image;// תמונת הקלף

        public Card(string name, int cardvalue, Shape shape, Image image)
        {
            this.name = name;
            this.cardvalue = cardvalue;
            this.image = image;
            this.shape = shape;
           
        }
        public Image getImage()
        {
            return (this.image);
        }
        public void setImage(Image g)
        {
           image = g;
        }
        public Card(Shape shape, Image image)//  בונה קלף רק עם צורה ותמונה 
        {
            this.shape = shape;
        }

        public int getvalue()// מחזיר את ערך הקלף 
        {
            return (this.cardvalue);
        }
        public void setValue(int value)// מעדכן את ערך הקלף 
        {
            this.cardvalue = value;
        }


        public Shape gettype()// מחזיר את צורת הקלף 
        {
            return (this.shape);
        }

        

    }
}
