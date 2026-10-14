
    namespace Dal
{

    internal static class DataSource
    {
        //רשימה המכילה את הפניות לכל ישות
        static internal list<students?> students = new list<students?>();
        static internal list<answer?> answers = new list<answer?>();
        static internal list<QuestionExaminee?> testAnswer = new list<QuestionExaminee?>();
        static internal list<question?> questions = new list<question?>();
        static internal list<test?> tests = new list<test?>();
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
    }

}
