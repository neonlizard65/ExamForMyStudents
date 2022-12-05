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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Exam.Pages
{
    /// <summary>
    /// Interaction logic for QuestionPage.xaml
    /// </summary>
    public partial class QuestionPage : Page
    {

        public QuestionPage(string MoveType)
        {   //MoveType = Далее или Назад
            InitializeComponent();
            Img.Visibility = Visibility.Collapsed;

            //////////////////////////////////////////////////
            ///////////////////КНОПКА ДАЛЕЕ///////////////////
            /////////////////////////////////////////////////
            if (MoveType == "Далее")
            {
                ExamData.totalquestcount++;
                if (ExamData.totalquestcount == 30)
                {
                    Next.Visibility = Visibility.Collapsed;
                    Finish.Visibility = Visibility.Visible;
                }
                else
                {
                    Next.Visibility = Visibility.Visible;
                    Finish.Visibility = Visibility.Collapsed;
                }
                if (ExamData.totalquestcount <= 1)
                {
                    Previous.Visibility = Visibility.Collapsed;
                }
                else
                {
                    Previous.Visibility = Visibility.Visible;
                }
                if (ExamData.totalquestcount <= 8)
                {
                    if(ExamData.mparchcount < 8)
                    {
                        DataContext = ExamData.Questions.multiplechoice.architecture[ExamData.mparchcount];
                        if(ExamData.Questions.multiplechoice.architecture[ExamData.mparchcount].ImagePath != "")
                        {
                            BitmapImage img = new BitmapImage();
                            img.BeginInit();
                            img.UriSource = new Uri(ExamData.Questions.multiplechoice.architecture[ExamData.mparchcount].ImagePath);
                            img.EndInit();
                            Img.Source = img;
                            Img.Visibility = Visibility.Visible;
                        }
                        else
                        {
                            Img.Visibility = Visibility.Collapsed;
                        }
                        switch (ExamData.Questions.multiplechoice.architecture[ExamData.mparchcount].UserAnswer)
                        {
                            case "1":
                                Choice1.IsChecked = true;
                                break;
                            case "2":
                                Choice2.IsChecked = true;
                                break;
                            case "3":
                                Choice3.IsChecked = true;
                                break;
                            case "4":
                                Choice4.IsChecked = true;
                                break;
                            case "5":
                                Choice5.IsChecked = true;
                                break;
                            case null:
                                Choice1.IsChecked = false; 
                                Choice2.IsChecked = false; 
                                Choice3.IsChecked = false; 
                                Choice4.IsChecked = false; 
                                Choice5.IsChecked = false;
                                break;

                        }
                        ExamData.mparchcount++;
                    }
                    if (GlobalVariables.LastMove == "Назад")
                    {
                        DataContext = ExamData.Questions.multiplechoice.architecture[ExamData.mparchcount];
                        if (ExamData.Questions.multiplechoice.architecture[ExamData.mparchcount].ImagePath != "")
                        {
                            BitmapImage img = new BitmapImage();
                            img.BeginInit();
                            img.UriSource = new Uri(ExamData.Questions.multiplechoice.architecture[ExamData.mparchcount].ImagePath);
                            img.EndInit();
                            Img.Source = img;
                            Img.Visibility = Visibility.Visible;
                        }
                        else
                        {
                            Img.Visibility = Visibility.Collapsed;
                        }
                        switch (ExamData.Questions.multiplechoice.architecture[ExamData.mparchcount].UserAnswer)
                        {
                            case "1":
                                Choice1.IsChecked = true;
                                break;
                            case "2":
                                Choice2.IsChecked = true;
                                break;
                            case "3":
                                Choice3.IsChecked = true;
                                break;
                            case "4":
                                Choice4.IsChecked = true;
                                break;
                            case "5":
                                Choice5.IsChecked = true;
                                break;
                            case null:
                                Choice1.IsChecked = false;
                                Choice2.IsChecked = false;
                                Choice3.IsChecked = false;
                                Choice4.IsChecked = false;
                                Choice5.IsChecked = false;
                                break;

                        }
                        ExamData.mparchcount++;
                    }
                    MPVisibility();
                }
                else if (ExamData.totalquestcount >= 9 && ExamData.totalquestcount <= 10)
                {
                    if (ExamData.exarchcount < 2)
                    {
                        DataContext = ExamData.Questions.extendedanswer.architecture[ExamData.exarchcount];
                        ExamData.exarchcount++;
                    }
                    if (GlobalVariables.LastMove == "Назад")
                    {
                        if(ExamData.totalquestcount != 9)
                        {
                            DataContext = ExamData.Questions.extendedanswer.architecture[ExamData.exarchcount];
                            ExamData.exarchcount++;
                        }
                        else
                        {
                            ExamData.mparchcount++;
                        }
                    }
                    ExVisibility();
                }
                else if (ExamData.totalquestcount >= 11 && ExamData.totalquestcount <= 18)
                {
                    if (ExamData.mpnetcount < 8)
                    {
                        DataContext = ExamData.Questions.multiplechoice.network[ExamData.mpnetcount];
                        if (ExamData.Questions.multiplechoice.network[ExamData.mpnetcount].ImagePath != "")
                        {
                            BitmapImage img = new BitmapImage();
                            img.BeginInit();
                            img.UriSource = new Uri(ExamData.Questions.multiplechoice.network[ExamData.mpnetcount].ImagePath);
                            img.EndInit();
                            Img.Source = img;
                            Img.Visibility = Visibility.Visible;
                        }
                        else
                        {
                            Img.Visibility = Visibility.Collapsed;
                        }
                        switch (ExamData.Questions.multiplechoice.network[ExamData.mpnetcount].UserAnswer)
                        {
                            case "1":
                                Choice1.IsChecked = true;
                                break;
                            case "2":
                                Choice2.IsChecked = true;
                                break;
                            case "3":
                                Choice3.IsChecked = true;
                                break;
                            case "4":
                                Choice4.IsChecked = true;
                                break;
                            case "5":
                                Choice5.IsChecked = true;
                                break;
                            case null:
                                Choice1.IsChecked = false;
                                Choice2.IsChecked = false;
                                Choice3.IsChecked = false;
                                Choice4.IsChecked = false;
                                Choice5.IsChecked = false;
                                break;
                        }
                        ExamData.mpnetcount++;
                    }
                    if (GlobalVariables.LastMove == "Назад")
                    {
                        if (ExamData.totalquestcount != 11)
                        {
                            DataContext = ExamData.Questions.multiplechoice.network[ExamData.mpnetcount];
                            if (ExamData.Questions.multiplechoice.network[ExamData.mpnetcount].ImagePath != "")
                            {
                                BitmapImage img = new BitmapImage();
                                img.BeginInit();
                                img.UriSource = new Uri(ExamData.Questions.multiplechoice.network[ExamData.mpnetcount].ImagePath);
                                img.EndInit();
                                Img.Source = img;
                                Img.Visibility = Visibility.Visible;
                            }
                            else
                            {
                                Img.Visibility = Visibility.Collapsed;
                            }
                            switch (ExamData.Questions.multiplechoice.network[ExamData.mpnetcount].UserAnswer)
                            {
                                case "1":
                                    Choice1.IsChecked = true;
                                    break;
                                case "2":
                                    Choice2.IsChecked = true;
                                    break;
                                case "3":
                                    Choice3.IsChecked = true;
                                    break;
                                case "4":
                                    Choice4.IsChecked = true;
                                    break;
                                case "5":
                                    Choice5.IsChecked = true;
                                    break;
                                case null:
                                    Choice1.IsChecked = false;
                                    Choice2.IsChecked = false;
                                    Choice3.IsChecked = false;
                                    Choice4.IsChecked = false;
                                    Choice5.IsChecked = false;
                                    break;
                            }
                            ExamData.mpnetcount++;
                        }
                        else
                        {
                            ExamData.exarchcount++;
                        }
                    }
                    MPVisibility();
                }
                else if (ExamData.totalquestcount >= 19 && ExamData.totalquestcount <= 20)
                {
                    if (ExamData.exnetcount < 2)
                    {
                        DataContext = ExamData.Questions.extendedanswer.network[ExamData.exnetcount];
                        ExamData.exnetcount++;
                    }
                    if (GlobalVariables.LastMove == "Назад")
                    {
                        if(ExamData.totalquestcount != 19)
                        {
                            DataContext = ExamData.Questions.extendedanswer.network[ExamData.exnetcount];
                            ExamData.exnetcount++;
                        }
                        else
                        {
                            ExamData.mpnetcount++;
                        }
                    }
                    ExVisibility();
                }
                else if (ExamData.totalquestcount >= 21 && ExamData.totalquestcount <= 28)
                {
                    if (ExamData.mposcount < 8)
                    {
                        DataContext = ExamData.Questions.multiplechoice.os[ExamData.mposcount];
                        switch (ExamData.Questions.multiplechoice.os[ExamData.mposcount].UserAnswer)
                        {
                            case "1":
                                Choice1.IsChecked = true;
                                break;
                            case "2":
                                Choice2.IsChecked = true;
                                break;
                            case "3":
                                Choice3.IsChecked = true;
                                break;
                            case "4":
                                Choice4.IsChecked = true;
                                break;
                            case "5":
                                Choice5.IsChecked = true;
                                break;
                            case null:
                                Choice1.IsChecked = false;
                                Choice2.IsChecked = false;
                                Choice3.IsChecked = false;
                                Choice4.IsChecked = false;
                                Choice5.IsChecked = false;
                                break;
                        }
                        ExamData.mposcount++;
                    }
                    if (GlobalVariables.LastMove == "Назад")
                    {
                        if(ExamData.totalquestcount != 21)
                        {
                            DataContext = ExamData.Questions.multiplechoice.os[ExamData.mposcount];
                            switch (ExamData.Questions.multiplechoice.os[ExamData.mposcount].UserAnswer)
                            {
                                case "1":
                                    Choice1.IsChecked = true;
                                    break;
                                case "2":
                                    Choice2.IsChecked = true;
                                    break;
                                case "3":
                                    Choice3.IsChecked = true;
                                    break;
                                case "4":
                                    Choice4.IsChecked = true;
                                    break;
                                case "5":
                                    Choice5.IsChecked = true;
                                    break;
                                case null:
                                    Choice1.IsChecked = false;
                                    Choice2.IsChecked = false;
                                    Choice3.IsChecked = false;
                                    Choice4.IsChecked = false;
                                    Choice5.IsChecked = false;
                                    break;
                            }
                            ExamData.mposcount++;
                        }
                        else
                        {
                            ExamData.exnetcount++;
                        }
                        
                    }

                    MPVisibility();
                }
                else if (ExamData.totalquestcount >= 29 && ExamData.totalquestcount <= 30)
                {
                    if (ExamData.exoscount < 2)
                    {
                        DataContext = ExamData.Questions.extendedanswer.os[ExamData.exoscount];
                        ExamData.exoscount++;
                    }
                    if (GlobalVariables.LastMove == "Назад")
                    {
                        if(ExamData.totalquestcount != 29)
                        {
                            DataContext = ExamData.Questions.extendedanswer.os[ExamData.exoscount];
                            ExamData.exoscount++;
                        }
                        else
                        {
                            ExamData.mposcount++;
                        }

                    }
                    ExVisibility();
                }
                GlobalVariables.LastMove = "Далее";
            }
            //////////////////////////////////////////////////
            ///////////////////КНОПКА НАЗАД///////////////////
            /////////////////////////////////////////////////
            else if(MoveType == "Назад")
            {
                ExamData.totalquestcount--;
                if (ExamData.totalquestcount == 30)
                {
                    Next.Visibility = Visibility.Collapsed;
                    Finish.Visibility = Visibility.Visible;
                }
                else
                {
                    Next.Visibility = Visibility.Visible;
                    Finish.Visibility = Visibility.Collapsed;
                }
                if (ExamData.totalquestcount <= 1)
                {
                    Previous.Visibility = Visibility.Collapsed;
                }
                else
                {
                    Previous.Visibility = Visibility.Visible;
                }
                if (ExamData.totalquestcount <= 8)
                {
                    if (ExamData.mparchcount > 0)
                    {
                        ExamData.mparchcount--;
                    }
                    if(GlobalVariables.LastMove == "Далее")
                    {
                        if (ExamData.totalquestcount != 8)
                        {
                            ExamData.mparchcount--;
                        }
                        else
                        {
                            ExamData.exarchcount--;
                        }
                    }
                    DataContext = ExamData.Questions.multiplechoice.architecture[ExamData.mparchcount];
                    if (ExamData.Questions.multiplechoice.architecture[ExamData.mparchcount].ImagePath != "")
                    {
                        BitmapImage img = new BitmapImage();
                        img.BeginInit();
                        img.UriSource = new Uri(ExamData.Questions.multiplechoice.architecture[ExamData.mparchcount].ImagePath);
                        img.EndInit();
                        Img.Source = img;
                        Img.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        Img.Visibility = Visibility.Collapsed;
                    }
                    switch (ExamData.Questions.multiplechoice.architecture[ExamData.mparchcount].UserAnswer)
                    {
                        case "1":
                            Choice1.IsChecked = true;
                            break;
                        case "2":
                            Choice2.IsChecked = true;
                            break;
                        case "3":
                            Choice3.IsChecked = true;
                            break;
                        case "4":
                            Choice4.IsChecked = true;
                            break;
                        case "5":
                            Choice5.IsChecked = true;
                            break;
                        case null:
                            Choice1.IsChecked = false;
                            Choice2.IsChecked = false;
                            Choice3.IsChecked = false;
                            Choice4.IsChecked = false;
                            Choice5.IsChecked = false;
                            break;
                    }
                    MPVisibility();
                }
                else if (ExamData.totalquestcount >= 9 && ExamData.totalquestcount <= 10)
                {
                    if (ExamData.exarchcount > 0)
                    {
                        ExamData.exarchcount--;
                    }
                    if (GlobalVariables.LastMove == "Далее" )
                    {
                        if(ExamData.totalquestcount != 10)
                        {
                            ExamData.exarchcount--;
                        }
                        else
                        {
                            ExamData.mpnetcount--;
                        }
                            
                    }
                    DataContext = ExamData.Questions.extendedanswer.architecture[ExamData.exarchcount];
                    ExVisibility();
                }
                else if (ExamData.totalquestcount >= 11 && ExamData.totalquestcount <= 18)
                {
                    if (ExamData.mpnetcount > 0)
                    {
                        ExamData.mpnetcount--;
                    }
                    if (GlobalVariables.LastMove == "Далее")
                    {
                        if(ExamData.totalquestcount != 18)
                        {
                            ExamData.mpnetcount--;
                        }
                        else
                        {
                            ExamData.exnetcount--;
                        }
                       
                    }
                    DataContext = ExamData.Questions.multiplechoice.network[ExamData.mpnetcount];
                    if (ExamData.Questions.multiplechoice.network[ExamData.mpnetcount].ImagePath != "")
                    {
                        BitmapImage img = new BitmapImage();
                        img.BeginInit();
                        img.UriSource = new Uri(ExamData.Questions.multiplechoice.network[ExamData.mpnetcount].ImagePath);
                        img.EndInit();
                        Img.Source = img;
                        Img.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        Img.Visibility = Visibility.Collapsed;
                    }
                    switch (ExamData.Questions.multiplechoice.network[ExamData.mpnetcount].UserAnswer)
                    {
                        case "1":
                            Choice1.IsChecked = true;
                            break;
                        case "2":
                            Choice2.IsChecked = true;
                            break;
                        case "3":
                            Choice3.IsChecked = true;
                            break;
                        case "4":
                            Choice4.IsChecked = true;
                            break;
                        case "5":
                            Choice5.IsChecked = true;
                            break;
                        case null:
                            Choice1.IsChecked = false;
                            Choice2.IsChecked = false;
                            Choice3.IsChecked = false;
                            Choice4.IsChecked = false;
                            Choice5.IsChecked = false;
                            break;
                    }
                    MPVisibility();
                }
                else if (ExamData.totalquestcount >= 19 && ExamData.totalquestcount <= 20)
                {
                    if (ExamData.exnetcount > 0)
                    {
                        ExamData.exnetcount--;
                    }
                    if (GlobalVariables.LastMove == "Далее")
                    {
                        if(ExamData.totalquestcount != 20)
                        {
                            ExamData.exnetcount--;
                        }
                        else
                        {
                            ExamData.mposcount--;
                        }
                       
                    }
                    DataContext = ExamData.Questions.extendedanswer.network[ExamData.exnetcount];
                    ExVisibility();
                }
                else if (ExamData.totalquestcount >= 21 && ExamData.totalquestcount <= 28)
                {
                    if (ExamData.mposcount > 0)
                    {
                        ExamData.mposcount--;
                    }
                    if (GlobalVariables.LastMove == "Далее")
                    {
                        if(ExamData.totalquestcount != 28)
                        {
                            ExamData.mposcount--;
                        }
                        else
                        {
                            ExamData.exoscount--;
                        }
                    }
                    DataContext = ExamData.Questions.multiplechoice.os[ExamData.mposcount];
                    switch (ExamData.Questions.multiplechoice.os[ExamData.mposcount].UserAnswer)
                    {
                        case "1":
                            Choice1.IsChecked = true;
                            break;
                        case "2":
                            Choice2.IsChecked = true;
                            break;
                        case "3":
                            Choice3.IsChecked = true;
                            break;
                        case "4":
                            Choice4.IsChecked = true;
                            break;
                        case "5":
                            Choice5.IsChecked = true;
                            break;
                        case null:
                            Choice1.IsChecked = false;
                            Choice2.IsChecked = false;
                            Choice3.IsChecked = false;
                            Choice4.IsChecked = false;
                            Choice5.IsChecked = false;
                            break;
                    }
                    MPVisibility();
                }
                else if (ExamData.totalquestcount >= 29 && ExamData.totalquestcount <= 30)
                {
                    if (ExamData.exoscount > 0)
                    {
                        ExamData.exoscount--;
                    }
                    if (GlobalVariables.LastMove == "Далее" && ExamData.totalquestcount != 30)
                    {
                        ExamData.exoscount--;
                    }
                    DataContext = ExamData.Questions.extendedanswer.os[ExamData.exoscount];
                    ExVisibility();
                }
                GlobalVariables.LastMove = "Назад";
            }

            indexLbl.Content = $"{ExamData.totalquestcount}/30";
        }

        private void Previous_Click(object sender, RoutedEventArgs e)
        {
            GlobalVariables.MainFrame.Navigate(new QuestionPage("Назад"));
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            GlobalVariables.MainFrame.Navigate(new QuestionPage("Далее"));
        }

        private bool FirstFinish = true;
        private void Finish_Click(object sender, RoutedEventArgs e)
        {
            for(int i = 0; i < 8; i++)
            {
                if(i < 2)
                {
                    if(String.IsNullOrEmpty(ExamData.Questions.extendedanswer.architecture[i].UserAnswer) ||
                    String.IsNullOrEmpty(ExamData.Questions.extendedanswer.network[i].UserAnswer) ||
                    String.IsNullOrEmpty(ExamData.Questions.extendedanswer.os[i].UserAnswer))
                    {
                        MessageBox.Show("Заполните все ответы!", "Внимание!", MessageBoxButton.OK);
                        return;
                    }
                 
                }
                if (String.IsNullOrEmpty(ExamData.Questions.multiplechoice.architecture[i].UserAnswer) ||
                    String.IsNullOrEmpty(ExamData.Questions.multiplechoice.network[i].UserAnswer) ||
                    String.IsNullOrEmpty(ExamData.Questions.multiplechoice.os[i].UserAnswer))
                {
                    MessageBox.Show("Заполните все ответы!", "Внимание!", MessageBoxButton.OK);
                    return;
                }
            }
            if (FirstFinish)
            {
                MessageBox.Show("Проверьте все свои ответы, перед тем как отослать!", "Внимание!", MessageBoxButton.OK);
                FirstFinish = false;
            }
            else
            {
                for (int i = 0; i < 8; i++)
                {
                    if (ExamData.Questions.multiplechoice.architecture[i].UserAnswer == ExamData.Questions.multiplechoice.architecture[i].RightChoice)
                    {
                        GlobalVariables.RightAnswerCount++;
                    }
                    if (ExamData.Questions.multiplechoice.network[i].UserAnswer == ExamData.Questions.multiplechoice.network[i].RightChoice)
                    {
                        GlobalVariables.RightAnswerCount++;
                    }
                    if (ExamData.Questions.multiplechoice.os[i].UserAnswer == ExamData.Questions.multiplechoice.os[i].RightChoice)
                    {
                        GlobalVariables.RightAnswerCount++;
                    }
                }
                GlobalVariables.MainFrame.Navigate(new ResultPage());
            }
        }

        private void MPVisibility()
        {
            Choice1.Visibility = Visibility.Visible;
            Choice2.Visibility = Visibility.Visible;
            Choice3.Visibility = Visibility.Visible;
            Choice4.Visibility = Visibility.Visible;
            Choice5.Visibility = Visibility.Visible;
            exText.Visibility = Visibility.Collapsed;
        }
        private void ExVisibility()
        {
            Choice1.Visibility = Visibility.Collapsed;
            Choice2.Visibility = Visibility.Collapsed;
            Choice3.Visibility = Visibility.Collapsed;
            Choice4.Visibility = Visibility.Collapsed;
            Choice5.Visibility = Visibility.Collapsed;
            exText.Visibility = Visibility.Visible;
        }

        private void Choice1_Checked(object sender, RoutedEventArgs e)
        {
            if((DataContext as Architecture) != null)
            {
                (DataContext as Architecture).UserAnswer = "1";
            }
            else if ((DataContext as Network) != null)
            {
                (DataContext as Network).UserAnswer = "1";
            }
            else if ((DataContext as OS) != null)
            {
                (DataContext as OS).UserAnswer = "1";
            }

        }

        private void Choice2_Checked(object sender, RoutedEventArgs e)
        {
            if ((DataContext as Architecture) != null)
            {
                (DataContext as Architecture).UserAnswer = "2";
            }
            else if ((DataContext as Network) != null)
            {
                (DataContext as Network).UserAnswer = "2";
            }
            else if ((DataContext as OS) != null)
            {
                (DataContext as OS).UserAnswer = "2";
            }
        }

        private void Choice3_Checked(object sender, RoutedEventArgs e)
        {
            if ((DataContext as Architecture) != null)
            {
                (DataContext as Architecture).UserAnswer = "3";
            }
            else if ((DataContext as Network) != null)
            {
                (DataContext as Network).UserAnswer = "3";
            }
            else if ((DataContext as OS) != null)
            {
                (DataContext as OS).UserAnswer = "3";
            }
        }

        private void Choice4_Checked(object sender, RoutedEventArgs e)
        {
            if ((DataContext as Architecture) != null)
            {
                (DataContext as Architecture).UserAnswer = "4";
            }
            else if ((DataContext as Network) != null)
            {
                (DataContext as Network).UserAnswer = "4";
            }
            else if ((DataContext as OS) != null)
            {
                (DataContext as OS).UserAnswer = "4";
            }
        }

        private void Choice5_Checked(object sender, RoutedEventArgs e)
        {
            if ((DataContext as Architecture) != null)
            {
                (DataContext as Architecture).UserAnswer = "5";
            }
            else if ((DataContext as Network) != null)
            {
                (DataContext as Network).UserAnswer = "5";
            }
            else if ((DataContext as OS) != null)
            {
                (DataContext as OS).UserAnswer = "5";
            }
        }
    }
}
