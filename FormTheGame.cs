using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Timers;
using System;
using System.Threading.Tasks;

namespace Einav
{
    public partial class FormTheGame : Form
    {
        Formgame formgame;// טופס הראשי 
        FormWIN formWIN;// טופס ניצחון
        FormLose formLose;// טופס הפסד 
        Player computerPlayer, humanPlayer;//מגדיר 2 שחקנים 
        Store pack;// מגדיר חבילה 
        List<PictureBox> cardsPlace;//רשימה האחראחית על כל התיבות תמונה של הקלפים של השחקן
        Point selectedCardL;//נקודה של הקלף האחרון שנבחר 
        Card lastCard;// הקלף האחרון שנבחר 
        List<Card> lastCardCho;//רשימה של כל הקלפים האחרונים שנבחרו על ידי השחקן 
        bool[] selected = new bool[6];//רשימת של אמת או שקר האם התיבה נבחרה או לא 
        hand playeCh;//מחלקת יד שאחראית על תקינות פעילותו של השחקן 
        int lasti = 0;//משתנה עזר 
        int sumOfCards = 0;//משתנה עזר של סכום הקלפים 
        List<Card> bincards = new List<Card>();// הקלפים שההשחקן והמחשב זורקים על השולחן
        bool someONECH = false;//בודק האם מישהו בכלל נבחר לפני ביצוע מהלך משתנה עזר 
        Graphics g;
        PictureBox[] cardComputerBox = new PictureBox[5];//רשימה של כל התיבת תמונה של המחשב 
        PictureBox[] cardPlayerBox = new PictureBox[6];//רשימה של כל התיבת תמונה של השחקן 

        
        

        public void fals(bool[] c)// מאתחל את כל המערך בשקר 
        {
            for (int i = 0; i < c.Length; i++)
            {
                selected[i] = false;       // מעדכן שאף אחד מהקלפים לא נבחר         
            }
        }

        public FormTheGame()
        {
            InitializeComponent();
            g = CreateGraphics();
            humanPlayer.play = true;  //בגלל שהשחקן הוא הראשון שמשחק הוא מעודכן לאמת                           
        }

        public static int humansum = 0;//// מגדיר 2 משתנים גלובלים של סכום השחקנים על מנת שאני אוכל להדפיס אותם בטופס הניצחון או הפסד 
        public static int computersum = 0;


        public FormTheGame(Formgame formgame,FormWIN formWIN,FormLose formLose)
        {
           
            InitializeComponent();
            this.formgame = formgame;//טופס משחק
            this.FormWIN = formWIN;//טופס ניצחון 
            this.formLose = formLose;//טופס הפסד
            buttonWin.Hide();//הסתר את כפתור הניצחון עד שלשחקן יגיע למצב שסכום קלפיו נמוך מ7 
            cardComputerBox[0] = cardComBox1;//מגדיר את התיבה תמונה של המחשב לתוך הרשימה 
            cardComputerBox[1] = cardComBox2;
            cardComputerBox[2] = cardComBox3;
            cardComputerBox[3] = cardComBox4;
            cardComputerBox[4] = cardComBox5;
            cardPlayerBox[1] = cardBox1;//מגדיר את התיבה תמונה של השחקן לתוך הרשימה 
            cardPlayerBox[2] = cardBox2;
            cardPlayerBox[3] = cardBox3;
            cardPlayerBox[4] = cardBox4;
            cardPlayerBox[5] = cardBox5;
              
        }

        public void locDown(PictureBox c)// מעלה את הקלף במידה ונבחר
        {
            selectedCardL = new Point(c.Location.X, c.Location.Y + 20);
            c.Location = selectedCardL;
           
        }

        public void locUp(PictureBox c)//מוריד את הקלף המידה ונבחר שוב 
        {
            selectedCardL = new Point(c.Location.X, c.Location.Y - 20);
            c.Location = selectedCardL;
        }
       

        private void FormTheGame_Load(object sender, EventArgs e)
        {       
            timer1.Interval = (1750);//מגדיר את זמן המתנת הטיימר
            computerThink.Hide();//// מסתיר את התמונה של המחשב החושב
            lastCard = new Card(Card.Shape.diamonds, (Bitmap)Properties.Resources.ResourceManager.GetObject("המאוחרה_של_הקלףעעע"));// מאתחל את התמונה של החבילה לסתם תמונה
            cardsPlace = new List<PictureBox> { cardBox1, cardBox2, cardBox3, cardBox4, cardBox5 };//מכניס את כל התיבות תמונה לתוך רשימה 
            computerPlayer = new Player(PlayerType.computer); //מגדיר שחקן מחשב 
             humanPlayer = new Player(PlayerType.human); // מגדיר שחקן בן אדם 
             pack = new Store(); // חבילת קלפים
             lastCardCho = new List<Card> { };// מגדיר קלף עזר הקלף האחרון שנבחר 
             playeCh = new hand(selected, lastCardCho);
            
         
            for (int i = 0; i < 5; i++)//מחלק 5 קלפים לכל שחקן
             {
                 computerPlayer.playerCards.Add(pack.popcards());    //  מחלק קלפים           
                 humanPlayer.playerCards.Add(pack.popcards());
             }
          
            for (int i = 0; i < 5; i++)
            {
                cardPlayerBox[i+1].Image=humanPlayer.playerCards[i].getImage();//מצייר את הקלפים של השחקן לפי מה שהוגרל 
            }
            for (int i = 0; i < 5; i++)// מגדיר את הקלפים של המשחב 
            {
                  cardComputerBox[i].Image=(Bitmap)Properties.Resources.ResourceManager.GetObject("המאוחרה_של_הקלףעעע");
            }
            deckOfCards.Hide();//מסך " הפתיחה של החבילה הסתר"
        }


        private void back_Click(object sender, EventArgs e)//במידה ולוחצים על כפתור חזור 
        {
            this.Hide();//הסתר את הטופס הנוכחי 
            formgame.Show();//הצג את הטופס הראשי 
        }

        private void cardBox1_Click(object sender, EventArgs e)
        {
            clickOnBoxNumber(1);
        }

        private void cardBox2_Click(object sender, EventArgs e)
        {
            clickOnBoxNumber(2);
        }

        private void cardBox3_Click(object sender, EventArgs e)
        {
            clickOnBoxNumber(3);
        }

        private void cardBox4_Click(object sender, EventArgs e)
        {
            clickOnBoxNumber(4);             
        }

        private void cardBox5_Click(object sender, EventArgs e)
        {
            clickOnBoxNumber(5);          
        }

        public void clickOnBoxNumber(int boxNum)// פעולות שקורות כאשר לוחצים על קלף 
        {
            someONECH = true; // משתנה עזר לדעת אם אחד מהקלפים נבחר בכלל
            if (selected[boxNum])//אם הקלף נבחר פעם שנייה אם שיבטל את הבחירה 
            {
                //     //מוריד את הקלף 
                locDown(cardPlayerBox[boxNum]);// מעדכן את המיקום
                selected[boxNum] = false;//מעדכן את זה שהקלף כבר לא נבחר
                return;
            }
            selected[boxNum] = true;// מראה שהתיבה הזאת נבחרה
            ////מעלה את הקלף שהשחקן בחר
            locUp(cardPlayerBox[boxNum]);
            lastCard = humanPlayer.playerCards[boxNum - 1]; // מעדכן את הקלף האחרון שנבחר 
        }

        public void click ()
        {
            sumOfCards = 0;
            for (int i = 1; i < 6; i++)// עובר לבדוק מי נבחר
            {
                if (selected[i])//בודק איזה מהקלפים נבחר 
                {
                    lastCardCho.Add(humanPlayer.playerCards[i - 1]);// מוסיף את הקלפים שנבחרו לרשימת הקלפים שנבחרו 
                }
            }
            bool IsEmptyPack = lastCardCho.Count() == 0; // בודק האם ישנם קלפים בכלל שנבחרו

            if (!IsEmptyPack)//אם החבילה לא ריקה 
            {
                if (!playeCh.ok())//אם המהלך של השחקן אינו חוקי 
                {
                    MessageBox.Show("לא ניתן לשחק ");
                    sett();// מוריד את כל הקלפים שנבחרו 
                    someONECH = false;// מעדכן שאף קלף לא נבחר 
                    playeCh.setorderlist();// מעדכן רשימת עזר במחלקה האנד

                    return;

                }
                else
                {
                    start.Hide();//מסתיר את המסך ההתחלתי שרשום עליו הנח קלף 
                    deckOfCards.Show();//מראה את חבילת הקלפים 
                    deckOfCards.Image = lastCard.getImage(); //מכניס את התמונה של הקלף האחרון שנבחר לתוך החבילה של השולחן        

                }

            }
            else
            {
                
                MessageBox.Show("עלייך לבחור קלף ");//במידה ולא נבחר קלף המחשב ידרוש ממך את זה בהודעה  
                someONECH = false;// מעדכן שבאמת לא נבחר אף קלף 
                return;
            }
            set();//מאתחל מוריד את כל הקלפים שנבחרו  
            
            playeCh.setorderlist();// מעדכן רשימת עזר במחלקה האנד

        }
        public void sett()//   להפוך ליותר יעיל*** מנקה את הרשימה ומוריד את הקלפים הנבחרים
        {

            for (int i = 0; i < selected.Length; i++)
            {
                if (selected[i])//אם אחד התיבות נבחרה 
                {
                    locDown(cardsPlace[i - 1]);    // הורד את המיקום שלה             
                    selected[i] = false;//ועדכן אותה כך שנדע שהיא לא נבחרה 
                }

            }
            lastCardCho.Clear();//רשימת הקלפים שנבחרו תנוקה 
        }

        public void set ()// מנקה את הרשימה ומוריד את הקלפים הנבחרים
        {
            for (int i = 0; i < selected.Length; i++)
            {
                if (selected[i])//אם נבחר קלף 
                {
                    cardsPlace[i - 1].Hide();//הסתר את התיבה שלו 
                    //ועדכן אותו לקלף דמה כלומר אין לו משמעות 
                    humanPlayer.playerCards[i - 1] = new Card("0", 0, Card.Shape.diamonds, (Bitmap)Properties.Resources.ResourceManager.GetObject("המאוחרה_של_הקלףעעע"));//.setValue(0);
                    locDown(cardsPlace[i - 1]);//הורד את מיקומי של הקלף חזרה למקום
                    lasti = i;//עדכן את האינדקס של הקלף האחרון שנבחר 
                    selected[i] = false;//עדכן שהקלף לא נבחר 
                }

            }
        }

        public void newCard()//פעולה שמביאה קלף חדש 
        {

            if (!pack.IsEmptyPack())//אם הקופה אינה ריקה 
            {
                Card randcard = (pack.popcards());//קח קלף מתוך הקופה 
                //מעדכן את הקלף של המחשב לקלף החדש שהוגרל 
                    humanPlayer.playerCards[lasti - 1] = randcard;
                    humanPlayer.playerCards[lasti - 1].setValue(randcard.getvalue());
                    cardsPlace[lasti - 1].Show();//מראה את תיבת הקלף 
                    cardsPlace[lasti - 1].Image = humanPlayer.playerCards[lasti - 1].getImage();//מעדכן את התמונה 
                
            }
            else
                cardsPlace[lasti - 1].Hide();//מסתיר את הקלף 

            lastCardCho.Clear();//מנקה את הרשימה של הקלפיםן שנבחרו 
            

            
        }
        public void outCards()//במידה והשחקן לקחת את הקלף שנמצא בקלפים ששנזרקו 
        {
            //מעדכן את הקלף האחרון שנבחר לקף האחרון שנזרק
                humanPlayer.playerCards[lasti - 1] = bincards[bincards.Count - 1];//
                humanPlayer.playerCards[lasti - 1].setValue(bincards[bincards.Count - 1].getvalue());
                cardsPlace[lasti - 1].Show();//מראה את תיבת הקלף הנבחר 
                cardsPlace[lasti - 1].Image = humanPlayer.playerCards[lasti - 1].getImage();      

        }

        public bool SomeSelect()//בודק האם יש משהו שנבחר
        {
            for (int i = 0; i < 5; i++)//עובר על כלהקלפים
            {
                if (selected[i])//במידה והקלף נבחרמחזיר אמת 
                    return true;
            }
            return false;
        }

        private void start_Click(object sender, EventArgs e) 
        {
            if (someONECH)//בודק האם בכלל יש קלף שנבחר 
            {
                click();//בודק האם המהלך חוקי 
                newCard();//לוקח קלף חדש
                bincards.Add(lastCard);//מוסיף את הקלף האחרון לקלפים שנזרקו 
                stopPlayerStartTimer();// מתחיל את הטיימר ואוסר על השחקן לשחק תחיל את הטיימר ובתוכו מהלך המחשב 
            }
            else
                MessageBox.Show("עלייך לבחור קלף");//במידה ולא נבחר קלף המחשב רושם שעלייך לבחור קלף 
            someONECH = false;//מעדכן את כך שלא נבחר קלף 


        }

        private void deckOfCards_Click(object sender, EventArgs e)//קלפים שנזרקים על השולחן
       {

           click();//בודק האם המהלך חוקי 
           if (someONECH)//בודק האם נבחר קלף בכלל
           {
               outCards();// לוקח את הקלף שמונח בקלפים שנזרקו 
               bincards.Add(lastCard);//מוסיף את הקלף האחרון לקלפים שנזרקו 
               humanPlayer.play = false;// אומר שתורו של השחקן נגמר 
               stopPlayerStartTimer();// מתחיל את הטיימר ואוסר על השחקן לשחק 
           }
           someONECH = false;//מעדכן שאף קלף לא נבחר  
           
        }


        private void FormTheGame_Click(object sender, EventArgs e)
        {
            
        }
        public bool isitin (Image g, List <Card> l)//מקבל רשימת קלף ותמונה ובודק האם התמונה  נמצאת ברשימה 
        {
            for (int i = 0; i < l.Count(); i++)
            {
                if ( l[i].getImage() == g)
                    return true;
            }
            return false;
        }

        public bool isitExists(Card c, List<Card> l)//מקבל  קלף ורשימת קלפים ובודק האם הקלף  נמצאת ברשימה 
        {
            for (int i = 0; i < l.Count(); i++)
            {
                if (l[i] == c)
                    return true;
            }
            return false;
        }

        public void move()
        {
            bool samevaluebuthight=false;// משתנה עזר בולאני שאומר לנו אם השחקן רוצה לזרוק קלף מסויים אך הוא נמצא גם בקלפים של המחשב
            if (computerPlayer.cardSum() <= 7)// בודק האם סכום הקלפים של המחשב קטן או שווה לשבע
            {
                if (humanPlayer.cardSum() < computerPlayer.cardSum())// אם לשחקן יש סכום קלפים נמוך
                {
                    this.Hide();//הסתר את הטופס הנוכחי 
                    FormWIN.Show(formgame);// הראה טופס ניצחון
                }
                else
                {
                    this.Hide();//הסתר את הטופס הנוכחי 
                    formLose.Show(formgame);// הראה טופס הפסד 
                }
                return;
            }


            ComputerMove comp = new ComputerMove(computerPlayer);//  מגדיר את השחקן בתוך מחלקת חשיבת המחשב 
            List<Card> compMove = comp.WhatIsTheSmartestMove();// מחזיר את המהלך הטוב ביותר שהמחשב יכול לבצע 
            int lasti = 0;// משתנה עזר 
            Card rand;
            deckOfCards.Image = compMove[compMove.Count() - 1].getImage(); //מכניס את התמונה של הקלף האחרון שנבחר לתוך החבילה של השולחן  
            samevaluebuthight = (comp.inTheplayerCards(bincards[bincards.Count() - 1]) && isitExists(bincards[bincards.Count() - 1], compMove));

         //או שיש לו קלף אחד אחרון והקלף שנזרק קטן משבע אחרון מקלפיו משלימים לשבע כולל הקלף מהקופה 
            //   או שמשלים לסדר עולה בקלפים. בודק האם הקלף האחרון שנזרק מופיע בקלפים של השחקן
            if (comp.takeTHATcard(bincards[bincards.Count() - 1]) || (comp.inTheplayerCards(bincards[bincards.Count() - 1]) || (comp.PartOfAscendingOrder(bincards[bincards.Count() - 1]) && !(isitExists(bincards[bincards.Count() - 1], compMove))))) 
            { 
                rand=bincards[bincards.Count()-1];
            }
                
            else //במידה והקלף שנזרק על השולחן לא תורם להשלמת סרייה כלשהי למהלך הבא המחשב יקח קלף רנדומלי מהקופה
                rand = (pack.popcards());
            if (samevaluebuthight && compMove.Count()>=1)//  אם הקלף שהמחשב רצה לזרוק זהה לקלף הגבוה שיש בקלפים שנזרקו המחשב יקח את הקלף השני הכי גבוה בחבילה אם קיימים יותר משני קלפים בידו של המחשב
            bincards.Add(compMove[compMove.Count() - 2]);// מוסיף לחבילת קלפים על השולחן את המהלך של המחשב
               else // אחרת שיקח פשוט את הקלף הכי גבוה שקיים 
                bincards.Add(compMove[compMove.Count() - 1]);
            for (int i = 0; i < cardComputerBox.Count(); i++)
            {
                if (isitExists(computerPlayer.playerCards[i], compMove))// מעדכן את כל הקלפים שהמחשב שיחק איתם לקלף הדמה 
                {
                    computerPlayer.playerCards[i] = new Card("0", 0, Card.Shape.diamonds, (Bitmap)Properties.Resources.ResourceManager.GetObject("המאוחרה_של_הקלףעעע"));
                    cardComputerBox[i].Hide();// מסתיר את התיבה שכרגע שיחקנו איתה 
                    lasti = i;
                }
            }
            cardComputerBox[lasti].Show();// הראה את תיבה שעדכנו
            computerPlayer.playerCards[lasti] = rand;// מעדכן את ערך קלפי המחשב 
            computerPlayer.playerCards[lasti].setValue(rand.getvalue());
        }

        private void FormTheGame_MouseClick(object sender, MouseEventArgs e)
        {
        }

        public FormWIN FormWIN { get; set; }

        private void buttonWin_Click(object sender, EventArgs e)
        {
            if (humanPlayer.cardSum() < computerPlayer.cardSum())// אם סכום הקלפים שלך יותר קטן מסכום קלפי המחשב 
            {
                FormWIN.Show(formgame);// הראה טופס ניצחון
            }
            else
                formLose.Show(formgame);// אחרת הראה טופס הפסד 
            this.Hide();//הסתר את הטופס הנוכחי 
                      
        }

        private void packk_Click(object sender, EventArgs e)//קופה
        {
            click();//בודק האם המהלך חוקי 
            if (someONECH)//בודק האם נבחר קלף בכלל
            {
                newCard();// לוקח קלף חדש מהקופה 
                bincards.Add(lastCard);//מוסיף את הקלף האחרון לקלפים שנזרקו  
                stopPlayerStartTimer();// מתחיל את הטיימר ואוסר על השחקן לשחק 

            }
            someONECH = false;//מעדכן שאף קלף לא נבחר 
            
            humanPlayer.play = false;// מעדכן שזה לא תורו של השחקן 
           
        }
        
        private void timer1_Tick(object sender, System.EventArgs e)
        {
            humansum = humanPlayer.cardSum();// מעדכן את המשתנים הגלובלים שיהיה ניקוד עדכני בטפסים האחרים

            timer1.Stop();//נותן רווח של זמן עד למהלך המחשב          
            move();// מהלך של המחשב
            computerThink.Hide();/// אחרי שהמחשב מסיים לשחק מסתירים את התמונה של המחשב החושב 
            if (playeCh.Sumcards(humanPlayer.playerCards, sumOfCards) <= 7)//  אם סכום הקלפים של השחקן עשוי להיות פחות מ7 או 7
            {
                buttonWin.Show();// הראה את הכפתור שמאפשר לו להכריז על ניצחון 
            }
            else
                buttonWin.Hide();// אם סכום הקלפים גדול מ7 הסתר את הפתור 
            // מעדכן את המשתנים הגלובלים שיהיה ניקוד עדכני בטפסים האחרים
            computersum = computerPlayer.cardSum();/////מעדכן את המשתנה הגלובלי 
            for (int i = 1; i < 6; i++)
            {
                cardPlayerBox[i].Cursor = Cursors.Hand;
            }

        }
        public void stopPlayerStartTimer()// מתחיל את הטיימר ומציג לשחקם שהוא אינו יכול לשחק 
        {
            for (int i = 1; i < 6; i++)// עושה שהעכבר יראה לשחקן שאסור לשחק יציג תמונה של איקס
            {
                cardPlayerBox[i].Cursor = Cursors.No;
            }
            computerThink.Show();//מראה את התמונה שאומרת שהמחשב חושב 
            timer1.Start();//מתחיל את הטיימר ובתוכו מהלך המחשב 
                
        }

        private void computerThink_Click(object sender, System.EventArgs e)
        {

        }


    }
}
