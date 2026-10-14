namespace DalList;
public class DalList : IDal
{
    public IStudent Student => new StudentImplementation();
    public IAnswer Answer => new AnswerImplementation();
    public IQuestionExaminee QuestionExaminee => new QuestionExamineeImplementation();
    public ITest Test => new TestImplementation();
    public IQuestion Question => new QuestionImplementation();  
}
