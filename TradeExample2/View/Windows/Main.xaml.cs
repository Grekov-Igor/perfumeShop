using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;
using TradeExample.Model;
//using static System.Net.WebRequestMethods;
//using static System.Net.WebRequestMethods;

//using System.IO;
//using TradeExample.Model;
//using File = System.IO.File;

namespace TradeExample.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Window
    {
        public static User _user;
        public bool isCaptcha = false;
        string captchaText = "";
        DispatcherTimer dispatcherTimer = new DispatcherTimer()
        {
            Interval = TimeSpan.FromSeconds(1),
        };
        int counter = 0;

        char[] glossary = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();

        //static ParfEntities connection = new ParfEntities();
        //static public string getFileName(string path)
        //{
        //    return System.IO.Path.GetFileName(path)
        //        .Split('.')[0];
        //}
        public Main()
        {
            InitializeComponent();
            dispatcherTimer.Tick += DispatcherTimer_Tick;

            //// TODO поменять путь до папки с картинками
            //var filesPath = "C:\\Users\\igorg\\Desktop\\Сессия 1\\Товар_import";
            //var files = Directory.GetFiles(filesPath);
            //foreach (var file in files)
            //{
            //    var product = connection.Products.ToList()
            //        .Where(p => p.ProductArticleNumber.Contains(getFileName(file)))
            //        .FirstOrDefault();

            //    if (product != null)
            //    {
            //        product.ProductPhoto = File.ReadAllBytes(file);
            //        connection.SaveChanges();
            //    }
            //}

            //var product = Context._con.Products.ToList();
            //foreach (var item in product)
            //{
            //    if (item.ProductPhoto == null)
            //    {
            //        item.ProductPhoto = File.ReadAllBytes("C:\\Users\\igorg\\Desktop\\Сессия 1\\picture.png");
            //        Context._con.SaveChanges();
            //    }
            //}



        }

        private void DispatcherTimer_Tick(object sender, EventArgs e)
        {
            counter++;
            if(counter>=10)
            {
                AuthBtn.IsEnabled = true;
                counter = 0;
                dispatcherTimer.Stop();
            }
        }

        private void Auth(object sender, RoutedEventArgs e)
        {
            if(!isCaptcha)
            {
                if (!string.IsNullOrEmpty(LoginTB.Text) && !string.IsNullOrEmpty(PasswordTB.Text))
                {
                    var user = Context._con.Users.ToList()
                        .Where(p => p.UserPassword == PasswordTB.Text && p.UserLogin == LoginTB.Text)
                        .FirstOrDefault();
                    if (user != null)
                    {
                        _user = user;
                        App.CurrentUser = user;
                        MainMenu mainMenu = new MainMenu();
                        mainMenu.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Неправильный лоигн или пароль!");
                        CaptchaTB.Visibility = Visibility.Visible;
                        EntryCaptchaTB.Visibility = Visibility.Visible;
                        isCaptcha = true;
                        Random random = new Random();
                        var captcha = "";
                        for (var i = 0; i < 4; i++)
                        {
                            captcha += glossary[random.Next(0, glossary.Length)];
                        }
                        captchaText = captcha;
                        CaptchaTB1.Text = captchaText[0].ToString();
                        CaptchaTB2.Text = captchaText[1].ToString();
                        CaptchaTB3.Text = captchaText[2].ToString();
                        CaptchaTB4.Text = captchaText[3].ToString();
                    }


                }
                else
                {
                    MessageBox.Show("Сначала заполните все поля!");
                }
            } else
            {
                if (!string.IsNullOrEmpty(LoginTB.Text) && !string.IsNullOrEmpty(PasswordTB.Text) && !string.IsNullOrEmpty(EntryCaptchaTB.Text)) 
                {
                    if(EntryCaptchaTB.Text == captchaText)
                    {
                        var user = Context._con.Users.ToList()
                        .Where(p => p.UserPassword == PasswordTB.Text && p.UserLogin == LoginTB.Text)
                        .FirstOrDefault();
                        if (user != null)
                        {
                            _user = user;
                            App.CurrentUser = user;
                            MainMenu mainMenu = new MainMenu();
                            mainMenu.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Неправильный лоигн или пароль!");
                            CaptchaTB.Visibility = Visibility.Visible;
                            EntryCaptchaTB.Visibility = Visibility.Visible;
                            isCaptcha = true;
                            Random random = new Random();
                            var captcha = "";
                            for (var i = 0; i < 4; i++)
                            {
                                captcha += glossary[random.Next(0, glossary.Length)];
                            }
                            captchaText = captcha;
                            CaptchaTB1.Text = captchaText[0].ToString();
                            CaptchaTB2.Text = captchaText[1].ToString();
                            CaptchaTB3.Text = captchaText[2].ToString();
                            CaptchaTB4.Text = captchaText[3].ToString();
                            dispatcherTimer.Start();
                            AuthBtn.IsEnabled = false;
                        }

                    } else
                    {
                        MessageBox.Show("Капча введена неправильно. Система заблокирована на 10 секунд.");
                        dispatcherTimer.Start();
                        AuthBtn.IsEnabled = false;
                    }

                }
            }
            

        }

        private void AuthAsGhuest(object sender, RoutedEventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Close();


        }
    }
}
