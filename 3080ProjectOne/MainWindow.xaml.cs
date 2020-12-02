using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Diagnostics;
using System.Media;

namespace _3080ProjectOne
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Button PendingImage1; //Store 1st filpped card into this variable.
        Button PendingImage2; //To store the button you click on the second.
        DispatcherTimer Timer = new DispatcherTimer();
        List<Thickness> loc = new List<Thickness>();
        Random location = new Random();
        //MediaPlayer Sound1 = new MediaPlayer();
        SoundPlayer sound = new SoundPlayer();

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            sound.SoundLocation = "https://ccmsa12exco.github.io/ccmsa.github.io/bgm2.wav";
            sound.Play();

            /*
            Sound1.Open(new Uri("/3080ProjectOne;component/music/1-19 Glavenus - The Chase.mp3", UriKind.Relative));
            Sound1.Play();
            */


            Timer.Interval = new TimeSpan(0, 0, 1);
            Timer.Tick += Timer_Tick;

            List<Button> buttons = new List<Button>()
            {
                btn1, dupbtn1, btn2, dupbtn2, btn3, dupbtn3, btn4, dupbtn4, btn5, dupbtn5,
                btn6, dupbtn6, btn7, dupbtn7, btn8, dupbtn8, btn9, dupbtn9, btn10, dupbtn10
            };

            // This is the timer 1, the damn WPF does not have a timer toolbox, wtf?
            DispatcherTimer dt1 = new DispatcherTimer();
            dt1.Interval = TimeSpan.FromSeconds(1);
            dt1.Tick += Dt1_Tick;
            dt1.Start();

            foreach (Button button in buttons)
            {
                button.IsEnabled = false; 
            }

            
            //Here I will shuffle the cards. 
            foreach (Button button in buttons)
            {
                loc.Add(button.Margin);
            }

            foreach (Button button in buttons)
            {
                int next = location.Next(loc.Count);
                Thickness p = loc[next];
                button.Margin = p;
                loc.Remove(p);
            }

            //Assign the pictures of monsters to buttons. We give some time for users to preview the pictures. 
            Image image1 = new Image();
            image1.Source = new BitmapImage(new Uri("/3080ProjectOne;component/img/Blackveil_Vaal_Hazak_Icon.png", UriKind.Relative));
            btn1.Content = image1;

            Image image2 = new Image();
            image2.Source = new BitmapImage(new Uri("/3080ProjectOne;component/img/Blackveil_Vaal_Hazak_Icon.png", UriKind.Relative));
            dupbtn1.Content = image2;

            Image image3 = new Image();
            image3.Source = new BitmapImage(new Uri("/3080ProjectOne;component/img/Deviljho_Icon.png", UriKind.Relative));
            btn2.Content = image3;

            Image image4 = new Image();
            image4.Source = new BitmapImage(new Uri("/3080ProjectOne;component/img/Deviljho_Icon.png", UriKind.Relative));
            dupbtn2.Content = image4;

            Image image5 = new Image();
            image5.Source = new BitmapImage(new Uri("/3080ProjectOne;component/img/Glavenus_Icon.png", UriKind.Relative));
            btn3.Content = image5;

            Image image6 = new Image();
            image6.Source = new BitmapImage(new Uri("/3080ProjectOne;component/img/Glavenus_Icon.png", UriKind.Relative));
            dupbtn3.Content = image6;

            Image image7 = new Image();
            image7.Source = new BitmapImage(new Uri("/3080ProjectOne;component/img/Kulve_Taroth_Icon.png", UriKind.Relative));
            btn4.Content = image7;

            Image image8 = new Image();
            image8.Source = new BitmapImage(new Uri("/3080ProjectOne;component/img/Kulve_Taroth_Icon.png", UriKind.Relative));
            dupbtn4.Content = image8;

            Image image9 = new Image();
            image9.Source = new BitmapImage(new Uri("/3080ProjectOne;component/img/Kushala_Daora_Icon.png", UriKind.Relative));
            btn5.Content = image9;

            Image image10 = new Image();
            image10.Source = new BitmapImage(new Uri("/3080ProjectOne;component/img/Kushala_Daora_Icon.png", UriKind.Relative));
            dupbtn5.Content = image10;

            Image image11 = new Image();
            image11.Source = new BitmapImage(new Uri("/3080ProjectOne;component/img/Namielle_Icon.png", UriKind.Relative));
            btn6.Content = image11;

            Image image12 = new Image();
            image12.Source = new BitmapImage(new Uri("/3080ProjectOne;component/img/Namielle_Icon.png", UriKind.Relative));
            dupbtn6.Content = image12;

            Image image13 = new Image();
            image13.Source = new BitmapImage(new Uri("/3080ProjectOne;component/img/Ruiner_Nergigante_Icon.png", UriKind.Relative));
            btn7.Content = image13;

            Image image14 = new Image();
            image14.Source = new BitmapImage(new Uri("/3080ProjectOne;component/img/Ruiner_Nergigante_Icon.png", UriKind.Relative));
            dupbtn7.Content = image14;

            Image image15 = new Image();
            image15.Source = new BitmapImage(new Uri("/3080ProjectOne;component/img/Seething_Bazelgeuse_Icon.png", UriKind.Relative));
            btn8.Content = image15;

            Image image16 = new Image();
            image16.Source = new BitmapImage(new Uri("/3080ProjectOne;component/img/Seething_Bazelgeuse_Icon.png", UriKind.Relative));
            dupbtn8.Content = image16;

            Image image17 = new Image();
            image17.Source = new BitmapImage(new Uri("/3080ProjectOne;component/img/Velkhana_Icon.png", UriKind.Relative));
            btn9.Content = image17;

            Image image18 = new Image();
            image18.Source = new BitmapImage(new Uri("/3080ProjectOne;component/img/Velkhana_Icon.png", UriKind.Relative));
            dupbtn9.Content = image18;

            Image image19 = new Image();
            image19.Source = new BitmapImage(new Uri("/3080ProjectOne;component/img/Zinogre_Icon.png", UriKind.Relative));
            btn10.Content = image19;

            Image image20 = new Image();
            image20.Source = new BitmapImage(new Uri("/3080ProjectOne;component/img/Zinogre_Icon.png", UriKind.Relative));
            dupbtn10.Content = image20;
        }

        private int score = 0;

        private int time = -1; //Just one time use of this function, this simgle line costs me 5 hours.
        private void Timer_Tick(object sender, EventArgs e)
        {
            Image image1 = new Image();
            image1.Source = new BitmapImage(new Uri("/3080ProjectOne;component/img/MH10th-MHP3_Question_Mark_Icon.png", UriKind.Relative));
            PendingImage1.Content = image1;
            Image image2 = new Image();
            image2.Source = new BitmapImage(new Uri("/3080ProjectOne;component/img/MH10th-MHP3_Question_Mark_Icon.png", UriKind.Relative));
            PendingImage2.Content = image2;
            PendingImage1 = null;
            PendingImage2 = null;
            //MessageBox.Show(Convert.ToString(time));
            time--;
            if (time > 1) time--;
            else
            {
                Timer.Stop();
            }
        }

        private int increment1 = 6; //The increment1 is the downcount when you (re)starting the game. 
        private void Dt1_Tick(object sender, EventArgs e)
        {
            if (increment1>0) increment1--;
            if (increment1>0)   TimerLabel.Content = increment1.ToString();
            if (increment1 <= 0)    TimerLabel.Content = "0";
            if (increment1 == 0)
            {
                List<Button> buttons = new List<Button>()
                {
                    btn1, dupbtn1, btn2, dupbtn2, btn3, dupbtn3, btn4, dupbtn4, btn5, dupbtn5,
                    btn6, dupbtn6, btn7, dupbtn7, btn8, dupbtn8, btn9, dupbtn9, btn10, dupbtn10
                };

                foreach (Button button in buttons)
                {
                    Image image = new Image();
                    image.Source = new BitmapImage(new Uri("/3080ProjectOne;component/img/MH10th-MHP3_Question_Mark_Icon.png", UriKind.Relative));
                    button.Content = image;
                    button.IsEnabled = true; 
                }
                increment1--;
            }
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            //button1.Location = new Point(100, 100);
            if (PendingImage1 == btn1) return;
            if (PendingImage1 == null) //作爲第一次點擊的翻牌
            {
                PendingImage1 = btn1;
                Image image1 = new Image();
                image1.Source = new BitmapImage(new Uri("/3080ProjectOne;component/img/Blackveil_Vaal_Hazak_Icon.png", UriKind.Relative));
                btn1.Content = image1;
            }
            else if (PendingImage1 != null && PendingImage2 == null)//作爲第二次點擊的翻牌
            {
                PendingImage2 = btn1;
                Image image1 = new Image();
                image1.Source = new BitmapImage(new Uri("/3080ProjectOne;component/img/Blackveil_Vaal_Hazak_Icon.png", UriKind.Relative));
                btn1.Content = image1;
            }

            if (PendingImage1 != null && PendingImage2 != null)  // This if is very important and cannot be set to else if, check immediately!!
            {
                //MessageBox.Show("Both full");
                if (PendingImage1.Uid == PendingImage2.Uid)
                {
                    //MessageBox.Show("Same");
                    //btn2.Margin = dupbtn2.Margin; 
                    PendingImage1 = null; PendingImage2 = null;
                    btn1.IsEnabled = false; dupbtn1.IsEnabled = false;

                    score++; 
                    if (score == 10) MessageBox.Show("You Win!");

                    return;
                }
                else
                {
                    Timer.Start();
                }
            }
        }

        private void dupbtn1_Click(object sender, RoutedEventArgs e)
        {
            if (PendingImage1 == dupbtn1) return; // here change
            if (PendingImage1 == null)
            {
                PendingImage1 = dupbtn1; //here change
                Image image1 = new Image();
                image1.Source = new BitmapImage(new Uri("/3080ProjectOne;component/img/Blackveil_Vaal_Hazak_Icon.png", UriKind.Relative));
                dupbtn1.Content = image1; //here change
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = dupbtn1; //here change
                Image image1 = new Image();
                image1.Source = new BitmapImage(new Uri("/3080ProjectOne;component/img/Blackveil_Vaal_Hazak_Icon.png", UriKind.Relative));
                dupbtn1.Content = image1; //here change

            }
            if (PendingImage1 != null && PendingImage2 != null)  // This if is very important and cannot be set to else if, check immediately!!
            {
                if (PendingImage1.Uid == PendingImage2.Uid)
                {
                    //MessageBox.Show("Same");
                    PendingImage1 = null; PendingImage2 = null;
                    btn1.IsEnabled = false; dupbtn1.IsEnabled = false; //change every 2 buttons. Because button goes in pairs. 

                    score++;
                    if (score == 10) MessageBox.Show("You Win!");

                    return;
                }
                else
                {
                    Timer.Start();
                }
            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (PendingImage1 == btn2) return; // here change
            if (PendingImage1 == null)
            {
                PendingImage1 = btn2; //here change
                Image image3 = new Image();
                image3.Source = new BitmapImage(new Uri("/3080ProjectOne;component/img/Deviljho_Icon.png", UriKind.Relative));
                btn2.Content = image3;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = btn2; //here change
                Image image3 = new Image();
                image3.Source = new BitmapImage(new Uri("/3080ProjectOne;component/img/Deviljho_Icon.png", UriKind.Relative));
                btn2.Content = image3;

            }
            if (PendingImage1 != null && PendingImage2 != null)  // This if is very important and cannot be set to else if, check immediately!!
            {
                if (PendingImage1.Uid == PendingImage2.Uid)
                {
                    //MessageBox.Show("Same");
                    PendingImage1 = null; PendingImage2 = null;
                    btn2.IsEnabled = false; dupbtn2.IsEnabled = false; //change every 2 buttons. Because button goes in pairs. 

                    score++;
                    if (score == 10) MessageBox.Show("You Win!");

                    return;
                }
                else
                {
                    Timer.Start();
                }
            }
        }

        private void dupbtn2_Click(object sender, RoutedEventArgs e)
        {
            if (PendingImage1 == dupbtn2) return; // here change
            if (PendingImage1 == null)
            {
                PendingImage1 = dupbtn2; //here change
                Image image4 = new Image();
                image4.Source = new BitmapImage(new Uri("/3080ProjectOne;component/img/Deviljho_Icon.png", UriKind.Relative));
                dupbtn2.Content = image4;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = dupbtn2; //here change
                Image image4 = new Image();
                image4.Source = new BitmapImage(new Uri("/3080ProjectOne;component/img/Deviljho_Icon.png", UriKind.Relative));
                dupbtn2.Content = image4;
            }
            if (PendingImage1 != null && PendingImage2 != null)  // This if is very important and cannot be set to else if, check immediately!!
            {
                if (PendingImage1.Uid == PendingImage2.Uid)
                {
                    //MessageBox.Show("Same");
                    PendingImage1 = null; PendingImage2 = null;
                    btn2.IsEnabled = false; dupbtn2.IsEnabled = false; //change every 2 buttons. Because button goes in pairs. 

                    score++;
                    if (score == 10) MessageBox.Show("You Win!");

                    return;
                }
                else
                {
                    Timer.Start();
                }
            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (PendingImage1 == btn3) return; // here change
            if (PendingImage1 == null)
            {
                PendingImage1 = btn3; //here change
                Image image5 = new Image();
                image5.Source = new BitmapImage(new Uri("/3080ProjectOne;component/img/Glavenus_Icon.png", UriKind.Relative));
                btn3.Content = image5;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = btn3; //here change
                Image image5 = new Image();
                image5.Source = new BitmapImage(new Uri("/3080ProjectOne;component/img/Glavenus_Icon.png", UriKind.Relative));
                btn3.Content = image5;
            }
            if (PendingImage1 != null && PendingImage2 != null)  // This if is very important and cannot be set to else if, check immediately!!
            {
                if (PendingImage1.Uid == PendingImage2.Uid)
                {
                    //MessageBox.Show("Same");
                    PendingImage1 = null; PendingImage2 = null;
                    btn3.IsEnabled = false; dupbtn3.IsEnabled = false; //change every 2 buttons. Because button goes in pairs. 

                    score++;
                    if (score == 10) MessageBox.Show("You Win!");

                    return;
                }
                else
                {
                    Timer.Start();
                }
            }
        }

        private void dupbtn3_Click(object sender, RoutedEventArgs e)
        {
            if (PendingImage1 == dupbtn3) return; // here change
            if (PendingImage1 == null)
            {
                PendingImage1 = dupbtn3; //here change
                Image image6 = new Image();
                image6.Source = new BitmapImage(new Uri("/3080ProjectOne;component/img/Glavenus_Icon.png", UriKind.Relative));
                dupbtn3.Content = image6;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = dupbtn3; //here change
                Image image6 = new Image();
                image6.Source = new BitmapImage(new Uri("/3080ProjectOne;component/img/Glavenus_Icon.png", UriKind.Relative));
                dupbtn3.Content = image6;
            }
            if (PendingImage1 != null && PendingImage2 != null)  // This if is very important and cannot be set to else if, check immediately!!
            {
                if (PendingImage1.Uid == PendingImage2.Uid)
                {
                    //MessageBox.Show("Same");
                    PendingImage1 = null; PendingImage2 = null;
                    btn3.IsEnabled = false; dupbtn3.IsEnabled = false; //change every 2 buttons. Because button goes in pairs. 

                    score++;
                    if (score == 10) MessageBox.Show("You Win!");

                    return;
                }
                else
                {
                    Timer.Start();
                }
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (PendingImage1 == btn4) return; // here change
            if (PendingImage1 == null)
            {
                PendingImage1 = btn4; //here change
                Image image7 = new Image();
                image7.Source = new BitmapImage(new Uri("/3080ProjectOne;component/img/Kulve_Taroth_Icon.png", UriKind.Relative));
                btn4.Content = image7;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = btn4; //here change
                Image image7 = new Image();
                image7.Source = new BitmapImage(new Uri("/3080ProjectOne;component/img/Kulve_Taroth_Icon.png", UriKind.Relative));
                btn4.Content = image7;
            }
            if (PendingImage1 != null && PendingImage2 != null)  // This if is very important and cannot be set to else if, check immediately!!
            {
                if (PendingImage1.Uid == PendingImage2.Uid)
                {
                    //MessageBox.Show("Same");
                    PendingImage1 = null; PendingImage2 = null;
                    btn4.IsEnabled = false; dupbtn4.IsEnabled = false; //change every 2 buttons. Because button goes in pairs. 

                    score++;
                    if (score == 10) MessageBox.Show("You Win!");

                    return;
                }
                else
                {
                    Timer.Start();
                }
            }
        }

        private void dupbtn4_Click(object sender, RoutedEventArgs e)
        {
            if (PendingImage1 == dupbtn4) return; // here change
            if (PendingImage1 == null)
            {
                PendingImage1 = dupbtn4; //here change
                Image image8 = new Image();
                image8.Source = new BitmapImage(new Uri("/3080ProjectOne;component/img/Kulve_Taroth_Icon.png", UriKind.Relative));
                dupbtn4.Content = image8;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = dupbtn4; //here change
                Image image8 = new Image();
                image8.Source = new BitmapImage(new Uri("/3080ProjectOne;component/img/Kulve_Taroth_Icon.png", UriKind.Relative));
                dupbtn4.Content = image8;
            }
            if (PendingImage1 != null && PendingImage2 != null)  // This if is very important and cannot be set to else if, check immediately!!
            {
                if (PendingImage1.Uid == PendingImage2.Uid)
                {
                    //MessageBox.Show("Same");
                    PendingImage1 = null; PendingImage2 = null;
                    btn4.IsEnabled = false; dupbtn4.IsEnabled = false; //change every 2 buttons. Because button goes in pairs. 

                    score++;
                    if (score == 10) MessageBox.Show("You Win!");

                    return;
                }
                else
                {
                    Timer.Start();
                }
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (PendingImage1 == btn5) return; // here change
            if (PendingImage1 == null)
            {
                PendingImage1 = btn5; //here change
                Image image9 = new Image();
                image9.Source = new BitmapImage(new Uri("/3080ProjectOne;component/img/Kushala_Daora_Icon.png", UriKind.Relative));
                btn5.Content = image9;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = btn5; //here change
                Image image9 = new Image();
                image9.Source = new BitmapImage(new Uri("/3080ProjectOne;component/img/Kushala_Daora_Icon.png", UriKind.Relative));
                btn5.Content = image9;
            }
            if (PendingImage1 != null && PendingImage2 != null)  // This if is very important and cannot be set to else if, check immediately!!
            {
                if (PendingImage1.Uid == PendingImage2.Uid)
                {
                    //MessageBox.Show("Same");
                    PendingImage1 = null; PendingImage2 = null;
                    btn5.IsEnabled = false; dupbtn5.IsEnabled = false; //change every 2 buttons. Because button goes in pairs. 

                    score++;
                    if (score == 10) MessageBox.Show("You Win!");

                    return;
                }
                else
                {
                    Timer.Start();
                }
            }
        }

        private void dupbtn5_Click(object sender, RoutedEventArgs e)
        {
            if (PendingImage1 == dupbtn5) return; // here change
            if (PendingImage1 == null)
            {
                PendingImage1 = dupbtn5; //here change
                Image image10 = new Image();
                image10.Source = new BitmapImage(new Uri("/3080ProjectOne;component/img/Kushala_Daora_Icon.png", UriKind.Relative));
                dupbtn5.Content = image10;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = dupbtn5; //here change
                Image image10 = new Image();
                image10.Source = new BitmapImage(new Uri("/3080ProjectOne;component/img/Kushala_Daora_Icon.png", UriKind.Relative));
                dupbtn5.Content = image10;
            }
            if (PendingImage1 != null && PendingImage2 != null)  // This if is very important and cannot be set to else if, check immediately!!
            {
                if (PendingImage1.Uid == PendingImage2.Uid)
                {
                    //MessageBox.Show("Same");
                    PendingImage1 = null; PendingImage2 = null;
                    btn5.IsEnabled = false; dupbtn5.IsEnabled = false; //change every 2 buttons. Because button goes in pairs. 

                    score++;
                    if (score == 10) MessageBox.Show("You Win!");

                    return;
                }
                else
                {
                    Timer.Start();
                }
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (PendingImage1 == btn6) return; // here change
            if (PendingImage1 == null)
            {
                PendingImage1 = btn6; //here change
                Image image11 = new Image();
                image11.Source = new BitmapImage(new Uri("/3080ProjectOne;component/img/Namielle_Icon.png", UriKind.Relative));
                btn6.Content = image11;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = btn6; //here change
                Image image11 = new Image();
                image11.Source = new BitmapImage(new Uri("/3080ProjectOne;component/img/Namielle_Icon.png", UriKind.Relative));
                btn6.Content = image11;
            }
            if (PendingImage1 != null && PendingImage2 != null)  // This if is very important and cannot be set to else if, check immediately!!
            {
                if (PendingImage1.Uid == PendingImage2.Uid)
                {
                    //MessageBox.Show("Same");
                    PendingImage1 = null; PendingImage2 = null;
                    btn6.IsEnabled = false; dupbtn6.IsEnabled = false; //change every 2 buttons. Because button goes in pairs. 

                    score++;
                    if (score == 10) MessageBox.Show("You Win!");

                    return;
                }
                else
                {
                    Timer.Start();
                }
            }
        }

        private void dupbtn6_Click(object sender, RoutedEventArgs e)
        {
            if (PendingImage1 == dupbtn6) return; // here change
            if (PendingImage1 == null)
            {
                PendingImage1 = dupbtn6; //here change
                Image image12 = new Image();
                image12.Source = new BitmapImage(new Uri("/3080ProjectOne;component/img/Namielle_Icon.png", UriKind.Relative));
                dupbtn6.Content = image12;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = dupbtn6; //here change
                Image image12 = new Image();
                image12.Source = new BitmapImage(new Uri("/3080ProjectOne;component/img/Namielle_Icon.png", UriKind.Relative));
                dupbtn6.Content = image12;
            }
            if (PendingImage1 != null && PendingImage2 != null)  // This if is very important and cannot be set to else if, check immediately!!
            {
                if (PendingImage1.Uid == PendingImage2.Uid)
                {
                    //MessageBox.Show("Same");
                    PendingImage1 = null; PendingImage2 = null;
                    btn6.IsEnabled = false; dupbtn6.IsEnabled = false; //change every 2 buttons. Because button goes in pairs. 

                    score++;
                    if (score == 10) MessageBox.Show("You Win!");

                    return;
                }
                else
                {
                    Timer.Start();
                }
            }
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (PendingImage1 == btn7) return; // here change
            if (PendingImage1 == null)
            {
                PendingImage1 = btn7; //here change
                Image image13 = new Image();
                image13.Source = new BitmapImage(new Uri("/3080ProjectOne;component/img/Ruiner_Nergigante_Icon.png", UriKind.Relative));
                btn7.Content = image13;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = btn7; //here change
                Image image13 = new Image();
                image13.Source = new BitmapImage(new Uri("/3080ProjectOne;component/img/Ruiner_Nergigante_Icon.png", UriKind.Relative));
                btn7.Content = image13;
            }
            if (PendingImage1 != null && PendingImage2 != null)  // This if is very important and cannot be set to else if, check immediately!!
            {
                if (PendingImage1.Uid == PendingImage2.Uid)
                {
                    //MessageBox.Show("Same");
                    PendingImage1 = null; PendingImage2 = null;
                    btn7.IsEnabled = false; dupbtn7.IsEnabled = false; //change every 2 buttons. Because button goes in pairs. 

                    score++;
                    if (score == 10) MessageBox.Show("You Win!");

                    return;
                }
                else
                {
                    Timer.Start();
                }
            }
        }

        private void dupbtn7_Click(object sender, RoutedEventArgs e)
        {
            if (PendingImage1 == dupbtn7) return; // here change
            if (PendingImage1 == null)
            {
                PendingImage1 = dupbtn7; //here change
                Image image14 = new Image();
                image14.Source = new BitmapImage(new Uri("/3080ProjectOne;component/img/Ruiner_Nergigante_Icon.png", UriKind.Relative));
                dupbtn7.Content = image14;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = dupbtn7; //here change
                Image image14 = new Image();
                image14.Source = new BitmapImage(new Uri("/3080ProjectOne;component/img/Ruiner_Nergigante_Icon.png", UriKind.Relative));
                dupbtn7.Content = image14;
            }
            if (PendingImage1 != null && PendingImage2 != null)  // This if is very important and cannot be set to else if, check immediately!!
            {
                if (PendingImage1.Uid == PendingImage2.Uid)
                {
                    //MessageBox.Show("Same");
                    PendingImage1 = null; PendingImage2 = null;
                    btn7.IsEnabled = false; dupbtn7.IsEnabled = false; //change every 2 buttons. Because button goes in pairs. 

                    score++;
                    if (score == 10) MessageBox.Show("You Win!");

                    return;
                }
                else
                {
                    Timer.Start();
                }
            }
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (PendingImage1 == btn8) return; // here change
            if (PendingImage1 == null)
            {
                PendingImage1 = btn8; //here change
                Image image15 = new Image();
                image15.Source = new BitmapImage(new Uri("/3080ProjectOne;component/img/Seething_Bazelgeuse_Icon.png", UriKind.Relative));
                btn8.Content = image15;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = btn8; //here change
                Image image15 = new Image();
                image15.Source = new BitmapImage(new Uri("/3080ProjectOne;component/img/Seething_Bazelgeuse_Icon.png", UriKind.Relative));
                btn8.Content = image15;
            }
            if (PendingImage1 != null && PendingImage2 != null)  // This if is very important and cannot be set to else if, check immediately!!
            {
                if (PendingImage1.Uid == PendingImage2.Uid)
                {
                    //MessageBox.Show("Same");
                    PendingImage1 = null; PendingImage2 = null;
                    btn8.IsEnabled = false; dupbtn8.IsEnabled = false; //change every 2 buttons. Because button goes in pairs. 

                    score++;
                    if (score == 10) MessageBox.Show("You Win!");

                    return;
                }
                else
                {
                    Timer.Start();
                }
            }
        }

        private void dupbtn8_Click(object sender, RoutedEventArgs e)
        {
            if (PendingImage1 == dupbtn8) return; // here change
            if (PendingImage1 == null)
            {
                PendingImage1 = dupbtn8; //here change
                Image image16 = new Image();
                image16.Source = new BitmapImage(new Uri("/3080ProjectOne;component/img/Seething_Bazelgeuse_Icon.png", UriKind.Relative));
                dupbtn8.Content = image16;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = dupbtn8; //here change
                Image image16 = new Image();
                image16.Source = new BitmapImage(new Uri("/3080ProjectOne;component/img/Seething_Bazelgeuse_Icon.png", UriKind.Relative));
                dupbtn8.Content = image16;
            }
            if (PendingImage1 != null && PendingImage2 != null)  // This if is very important and cannot be set to else if, check immediately!!
            {
                if (PendingImage1.Uid == PendingImage2.Uid)
                {
                    //MessageBox.Show("Same");
                    PendingImage1 = null; PendingImage2 = null;
                    btn8.IsEnabled = false; dupbtn8.IsEnabled = false; //change every 2 buttons. Because button goes in pairs. 

                    score++;
                    if (score == 10) MessageBox.Show("You Win!");

                    return;
                }
                else
                {
                    Timer.Start();
                }
            }
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (PendingImage1 == btn9) return; // here change
            if (PendingImage1 == null)
            {
                PendingImage1 = btn9; //here change
                Image image17 = new Image();
                image17.Source = new BitmapImage(new Uri("/3080ProjectOne;component/img/Velkhana_Icon.png", UriKind.Relative));
                btn9.Content = image17;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = btn9; //here change
                Image image17 = new Image();
                image17.Source = new BitmapImage(new Uri("/3080ProjectOne;component/img/Velkhana_Icon.png", UriKind.Relative));
                btn9.Content = image17;
            }
            if (PendingImage1 != null && PendingImage2 != null)  // This if is very important and cannot be set to else if, check immediately!!
            {
                if (PendingImage1.Uid == PendingImage2.Uid)
                {
                    //MessageBox.Show("Same");
                    PendingImage1 = null; PendingImage2 = null;
                    btn9.IsEnabled = false; dupbtn9.IsEnabled = false; //change every 2 buttons. Because button goes in pairs. 

                    score++;
                    if (score == 10) MessageBox.Show("You Win!");

                    return;
                }
                else
                {
                    Timer.Start();
                }
            }
        }

        private void dupbtn9_Click(object sender, RoutedEventArgs e)
        { 
            if (PendingImage1 == dupbtn9) return; // here change
            if (PendingImage1 == null)
            {
                PendingImage1 = dupbtn9; //here change
                Image image18 = new Image();
                image18.Source = new BitmapImage(new Uri("/3080ProjectOne;component/img/Velkhana_Icon.png", UriKind.Relative));
                dupbtn9.Content = image18;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = dupbtn9; //here change
                Image image18 = new Image();
                image18.Source = new BitmapImage(new Uri("/3080ProjectOne;component/img/Velkhana_Icon.png", UriKind.Relative));
                dupbtn9.Content = image18;
            }
            if (PendingImage1 != null && PendingImage2 != null)  // This if is very important and cannot be set to else if, check immediately!!
            {
                if (PendingImage1.Uid == PendingImage2.Uid)
                {
                    //MessageBox.Show("Same");
                    PendingImage1 = null; PendingImage2 = null;
                    btn9.IsEnabled = false; dupbtn9.IsEnabled = false; //change every 2 buttons. Because button goes in pairs. 

                    score++;
                    if (score == 10) MessageBox.Show("You Win!");

                    return;
                }
                else
                {
                    Timer.Start();
                }
            }
        }

        private void btn10_Click(object sender, RoutedEventArgs e)
        {
            if (PendingImage1 == btn10) return; // here change
            if (PendingImage1 == null)
            {
                PendingImage1 = btn10; //here change
                Image image19 = new Image();
                image19.Source = new BitmapImage(new Uri("/3080ProjectOne;component/img/Zinogre_Icon.png", UriKind.Relative));
                btn10.Content = image19;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = btn10; //here change
                Image image19 = new Image();
                image19.Source = new BitmapImage(new Uri("/3080ProjectOne;component/img/Zinogre_Icon.png", UriKind.Relative));
                btn10.Content = image19;
            }
            if (PendingImage1 != null && PendingImage2 != null)  // This if is very important and cannot be set to else if, check immediately!!
            {
                if (PendingImage1.Uid == PendingImage2.Uid)
                {
                    //MessageBox.Show("Same");
                    PendingImage1 = null; PendingImage2 = null;
                    btn10.IsEnabled = false; dupbtn10.IsEnabled = false; //change every 2 buttons. Because button goes in pairs. 

                    score++;
                    if (score == 10) MessageBox.Show("You Win!");

                    return;
                }
                else
                {
                    Timer.Start();
                }
            }
        }

        private void dupbtn10_Click(object sender, RoutedEventArgs e)
        {
            if (PendingImage1 == dupbtn10) return; // here change
            if (PendingImage1 == null)
            {
                PendingImage1 = dupbtn10; //here change
                Image image20 = new Image();
                image20.Source = new BitmapImage(new Uri("/3080ProjectOne;component/img/Zinogre_Icon.png", UriKind.Relative));
                dupbtn10.Content = image20;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = dupbtn10; //here change
                Image image20 = new Image();
                image20.Source = new BitmapImage(new Uri("/3080ProjectOne;component/img/Zinogre_Icon.png", UriKind.Relative));
                dupbtn10.Content = image20;
            }
            if (PendingImage1 != null && PendingImage2 != null)  // This if is very important and cannot be set to else if, check immediately!!
            {
                if (PendingImage1.Uid == PendingImage2.Uid)
                {
                    //MessageBox.Show("Same");
                    PendingImage1 = null; PendingImage2 = null;
                    btn10.IsEnabled = false; dupbtn10.IsEnabled = false; //change every 2 buttons. Because button goes in pairs. 

                    score++;
                    if (score == 10) MessageBox.Show("You Win!");

                    return;
                }
                else
                {
                    Timer.Start();
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //This method copied from Internet. 
            Process.Start(Process.GetCurrentProcess().MainModule.FileName);
            Application.Current.Shutdown();
        }
    }
}
