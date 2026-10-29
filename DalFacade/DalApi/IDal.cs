using DO;

namespace DalApi;
// הגדרת תכונת מעטפת  לכל ממשק הקיים בשכבת ה-DAL לקריאה בלבד 
public interface IDal
{
    IAnswer answer { get; }
    IStudents student { get; }
    IQuestionExaminee questionExaminee { get;}
    ITest test { get;}
    IQuestion question {get;}
}