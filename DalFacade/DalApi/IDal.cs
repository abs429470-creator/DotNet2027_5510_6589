    namespace DalApi;
// הגדרת תכונת מעטפת  לכל ממשק הקיים בשכבת ה-DAL לקריאה בלבד 
public interface IDal
{
    IAnswer Answer { get; }
    IStudent Student { get; }
    ITestAnswer TestAnswer { get;}
}