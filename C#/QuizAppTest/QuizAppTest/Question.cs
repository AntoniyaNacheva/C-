using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace QuizAppTest
{
    internal class Question
    {
        public string QuestionText { get; }
        public string[] Answers { get; }
        public int CorrectAnswerIndex { get; }

        public Question(string questionText, string[] answers, int correctAnswerIndex)

        // Method to check if the answer is correct
        public bool IsCorrectAnswer(int choice)
    }
}
