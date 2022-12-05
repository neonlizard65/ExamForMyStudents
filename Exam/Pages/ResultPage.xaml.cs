using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
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
    /// Interaction logic for ResultPage.xaml
    /// </summary>
    public partial class ResultPage : Page
    {
        public ResultPage()
        {
            InitializeComponent();
            Name.Content = GlobalVariables.Name; 
            Group.Content = GlobalVariables.Group;
            MpResult.Content = $"{ GlobalVariables.RightAnswerCount} / 24 правильных ответов";


            //SMTP
            try
            {

                SmtpClient mySmtpClient = new SmtpClient("smtp.gmail.com", 587);
                mySmtpClient.EnableSsl = true;

                // set smtp-client with basicAuthentication
                mySmtpClient.UseDefaultCredentials = false;
                System.Net.NetworkCredential basicAuthenticationInfo = new System.Net.NetworkCredential("alekseilapchik2001@gmail.com", "####################");
                mySmtpClient.Credentials = basicAuthenticationInfo;

                // add from,to mailaddresses
                MailAddress from = new MailAddress("alekseilapchik2001@gmail.com", "Экзамен");
                MailAddress to = new MailAddress("alekseilapchik2001@gmail.com", "Алексей");
                MailMessage myMail = new System.Net.Mail.MailMessage(from, to);


                // set subject and encoding
                myMail.Subject = $"{GlobalVariables.Group} {GlobalVariables.Name}";
                myMail.SubjectEncoding = System.Text.Encoding.UTF8;

                // set body-message and encoding
                StringBuilder sb = new StringBuilder();
                sb.Append("<br>Архитектура<br>");
                foreach (var x in ExamData.Questions.multiplechoice.architecture)
                {
                    sb.Append($"{x.Question}:<br>Правильный ответ:{x.RightChoice}<br>Ответ студента:{x.UserAnswer}<br>");
                }
                foreach (var x in ExamData.Questions.extendedanswer.architecture)
                {
                    sb.Append($"{x.Question}:<br>Ответ студента:{x.UserAnswer}<br>");
                }
                sb.Append("<br>Сети<br>");
                foreach (var x in ExamData.Questions.multiplechoice.network)
                {
                    sb.Append($"{x.Question}:<br>Правильный ответ:{x.RightChoice}<br>Ответ студента:{x.UserAnswer}<br>");
                }
                foreach (var x in ExamData.Questions.extendedanswer.network)
                {
                    sb.Append($"{x.Question}:<br>Ответ студента:{x.UserAnswer}<br>");
                }
                sb.Append("<br>ОС<br>");
                foreach (var x in ExamData.Questions.multiplechoice.os)
                {
                    sb.Append($"{x.Question}:<br>Правильный ответ:{x.RightChoice}<br>Ответ студента:{x.UserAnswer}<br>");
                }
                foreach (var x in ExamData.Questions.extendedanswer.os)
                {
                    sb.Append($"{x.Question}:<br>Ответ студента:{x.UserAnswer}<br>");
                }

                myMail.Body = $"{ GlobalVariables.RightAnswerCount} / 24 правильных ответов <br>{sb.ToString()}";
                myMail.BodyEncoding = System.Text.Encoding.UTF8;
                // text or html
                myMail.IsBodyHtml = true;

                mySmtpClient.Send(myMail);
            }

            catch (SmtpException ex)
            {
                throw new ApplicationException("SmtpException has occured: " + ex.Message);
            }
            catch { }


        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            var window = Window.GetWindow(this);
            window.Close();
        }
    }
}
