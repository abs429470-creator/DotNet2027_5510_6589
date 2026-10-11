    namespace DalApi;
// הגדרת תכונת מעטפת  לכל ממשק הקיים בשכבת ה-DAL לקריאה בלבד 
public interface IDal
{
    IAnswer answer { get; },
    IStudent student { get; },
    ITestAnswer testAnswer { get; }
}