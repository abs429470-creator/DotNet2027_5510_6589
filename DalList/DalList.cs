using DO;
using DalApi;

namespace DalList;
public class DalList : IDal
{
    public IStudents student => new StudentsImplementation();
    public IAnswer answer => new AnswersImplementation();
    public IQuestionExaminee questionExaminee => new QuestionExamineeImplementation();
    public ITest test => new TestImplementation();
    public IQuestion question => new QuestionImplementation();
}
