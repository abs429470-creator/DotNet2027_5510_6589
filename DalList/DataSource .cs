
    namespace Dal
{

    internal static class DataSource
    {
        //רשימה המכילה את הפניות לכל ישות
        static internal list<students?> students = new list<students?>();
        static internal list<answer?> answers = new list<answer?>();
        static internal list<testAnswer?> testAnswer = new list<testAnswer?>();
        //מחלקה פנימית המגדירה את המיספור הרץ של השדות המוגדרים
        internal static class Config
        {
            internal const int constStartConfig;
            private static int startConfig = constStartConfig;
            internal static int GetNextId()
            {
                return startConfig++;
            }

        }
    }

}
