using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class Question
    {
        public Multiplechoice multiplechoice { get; set; }
        public Extendedanswer extendedanswer { get; set; }

    }
    public class Multiplechoice
    {
        public List<Architecture> architecture { get; set; }
        public List<Network> network { get; set; }
        public List<OS> os { get; set; }
    }

    public class MPBlueprint
    {
        public string QuestionID { get; set; }
        public string CategoryName { get; set; }
        public string CategoryId { get; set; }
        public string Question { get; set; }
        public string Choice1 { get; set; }
        public string Choice2 { get; set; }
        public string Choice3 { get; set; }
        public string Choice4 { get; set; }
        public string Choice5 { get; set; }
        public string RightChoice { get; set; }
        public string ImagePath { get; set; }
        public string? UserAnswer { get; set; }

        public MPBlueprint(string questionID, string categoryName, string categoryId, string question, string choice1, string choice2, string choice3, string choice4, string choice5, string rightChoice, string imagePath)
        {
            QuestionID = questionID;
            CategoryName = categoryName;
            CategoryId = categoryId;
            Question = question;
            Choice1 = choice1;
            Choice2 = choice2;
            Choice3 = choice3;
            Choice4 = choice4;
            Choice5 = choice5;
            RightChoice = rightChoice;
            ImagePath = imagePath;
        }
    }

    public class Architecture : MPBlueprint
    {
        public Architecture(string questionID, string categoryName, string categoryId, string question, string choice1, string choice2, string choice3, string choice4, string choice5, string rightChoice, string imagePath) : base(questionID, categoryName, categoryId, question, choice1, choice2, choice3, choice4, choice5, rightChoice, imagePath)
        {

        }
    }

    public class Network : MPBlueprint
    {
        public Network(string questionID, string categoryName, string categoryId, string question, string choice1, string choice2, string choice3, string choice4, string choice5, string rightChoice, string imagePath) : base(questionID, categoryName, categoryId, question, choice1, choice2, choice3, choice4, choice5, rightChoice, imagePath)
        {

        }
    }

    public class OS : MPBlueprint
    {
        public OS(string questionID, string categoryName, string categoryId, string question, string choice1, string choice2, string choice3, string choice4, string choice5, string rightChoice, string imagePath) : base(questionID, categoryName, categoryId, question, choice1, choice2, choice3, choice4, choice5, rightChoice, imagePath)
        {

        }
    }

    public class Extendedanswer
    {
        public List<Architecture1> architecture { get; set; }
        public List<Network1> network { get; set; }
        public List<OS1> os { get; set; }
    }

    public class ExBlueprint
    {
        public string QuestionID { get; set; }
        public string CategoryName { get; set; }
        public string CategoryId { get; set; }
        public string Question { get; set; }
        public string ImagePath { get; set; }
        public string? UserAnswer { get; set; }

        public ExBlueprint(string questionID, string categoryName, string categoryId, string question, string imagePath)
        {
            QuestionID = questionID;
            CategoryName = categoryName;
            CategoryId = categoryId;
            Question = question;
            ImagePath = String.Concat("https://185.20.227.127/api", imagePath);
    }
    }

    public class Architecture1 : ExBlueprint
    {
        public Architecture1(string questionID, string categoryName, string categoryId, string question, string imagePath) : base(questionID, categoryName, categoryId, question, imagePath)
        {

        }
    }

    public class Network1 : ExBlueprint
    {
        public Network1(string questionID, string categoryName, string categoryId, string question, string imagePath) : base(questionID, categoryName, categoryId, question, imagePath)
        {

        }
    }

    public class OS1 : ExBlueprint
    {
        public OS1(string questionID, string categoryName, string categoryId, string question, string imagePath) : base(questionID, categoryName, categoryId, question, imagePath)
        {

        }
    }
}
