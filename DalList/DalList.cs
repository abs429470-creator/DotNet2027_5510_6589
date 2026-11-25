using DO;
using DalApi;


namespace Dal;
internal sealed class  DalList : IDal
{
    private DalList instance=new DalList();
    public DalList Instance  { get{ return this.instance; } }
    private DalList()
    {

    }
    public IStudents student => new StudentsImplementation();
    public IAnswer answer => new AnswersImplementation();
    public IQuestionExaminee questionExaminee => new QuestionExamineeImplementation();
    public ITest test => new TestImplementation();
    public IQuestion question => new QuestionImplementation();

  
}
