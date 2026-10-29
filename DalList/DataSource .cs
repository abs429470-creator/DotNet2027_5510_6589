using DO;
using DalApi;
namespace Dal
{

    internal static class DataSource
    {
        //רשימה המכילה את הפניות לכל ישות
        static internal List<Students?> students = new List<Students?>();
        static internal List<Answer?> answers = new List<Answer?>();
        static internal List<QuestionExaminee?> questionExaminee = new List<QuestionExaminee?>();
        static internal List<Question?> questions = new List<Question?>();
        static internal List<Test?> tests = new List<Test?>();
        //מחלקות פנימיות המגדירות את המיספור הרץ של הישויות שאלה,תשובה ומבחן
        internal static class AnswerConfig
        {
            internal const int constStartConfig=100;
            private static int startConfig = constStartConfig;
            internal static int GetNextId()
            {
                return startConfig++;
            }

        }

        internal static class QuestionConfig
        {
            internal const int constStartConfig = 1;
            private static int startConfig = constStartConfig;
            internal static int GetNextId()
            {
                return startConfig++;
            }

        }

        internal static class TestConfig
        {
            internal const int constStartConfig = 10;
            private static int startConfig = constStartConfig;
            internal static int GetNextId()
            {
                return startConfig++;
            }

        }
         internal static class QuestionExamineeConfig
        {
            internal const int constStartConfig = 1;
            private static int startConfig = constStartConfig;
            internal static int GetNextId()
            {
                return startConfig++;
            }
        }
    }

}
