using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
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
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            if(!String.IsNullOrEmpty(Group.Text) && !String.IsNullOrEmpty(Name.Text) && !String.IsNullOrEmpty(Surname.Text))
            {
                ErrorText.Visibility = Visibility.Collapsed;
                GlobalVariables.Group = Group.Text;
                GlobalVariables.Name = $"{Name.Text} {Surname.Text}";
                var httpClientHandler = new HttpClientHandler();
                httpClientHandler.ServerCertificateCustomValidationCallback = (message, cert, chain, sslPolicyErrors) =>
                {
                    return true;
                };
                HttpClient client = new HttpClient(httpClientHandler);
                var response = client.GetAsync("https://185.20.227.127/api/get_q.php").Result;
                string content = response.Content.ReadAsStringAsync().Result;
                var result = JsonSerializer.Deserialize<Exam.Question>(content);
                if (result != null)
                {
                    ExamData data = new ExamData(result);
                }
                GlobalVariables.MainFrame.Navigate(new QuestionPage("Далее"));
            }
            else
            {
                ErrorText.Visibility = Visibility.Visible;

            }

        }
    }
}
