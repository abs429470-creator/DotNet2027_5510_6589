    namespace DalApi;
// הגדרת תכונת מעטפת  לכל ממשק הקיים בשכבת ה-DAL לקריאה בלבד 
public interface IDal
{
    IAnswer Answer { get; }
    IStudents Student { get; }
    ITestAnswer TestAnswer { get;}
    ITest Test { get;}
    IQuestion question {get;}
}