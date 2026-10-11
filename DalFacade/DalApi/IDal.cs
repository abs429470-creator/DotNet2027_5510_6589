   namespace DalApi;
// הגדרת תכונת מעטפת  לכל ממשק הקיים בשכבת ה-DAL לקריאה בלבד 
public interface IDal<T>
{
    IAnswer answer { get; },
    ICrud crud { get; },
    IStudent student { get; },
    ITestAnswer testAnswer { get; }
}