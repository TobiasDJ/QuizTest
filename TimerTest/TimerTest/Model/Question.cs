using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimerTest.ScoreBehavior;

namespace TimerTest.Model
{
    public class Question
    {
        public IScoreBehavior _IScore { get; set; }
        public string _QuestionText { get; set; }
        public ICollection<Option> _OptionsList { get; set; }
        public int _QuestionID { get; set; }

        public  int  _QuizID { get; set; }
        public double _PointScore { get; set; }

        public Question(int quizID, int questionID, string question)
        {
            _IScore = (IScoreBehavior) new SimpleScore(20);
            _OptionsList = (ICollection<Option>) new List<Option>();
            _QuestionID = questionID;
            _QuizID = quizID;
            _QuestionText = question;
            _PointScore = 0;

        }


    }
}
