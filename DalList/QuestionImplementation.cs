using DO;
using DalApi;
using Dal;
namespace DalList;

internal class QuestionImplementation : IQuestion
{
    public int Create(Question question)
    {
        Question newQuestion = new Question
        {
            questionId = DataSource.QuestionConfig.GetNextId(),
            questionType = question.questionType,
            content = question.content,
            isCorect = question.isCorect
        };

        DataSource.questions.Add(newQuestion);
        return newQuestion.questionId;
    }
    public void Delete(int questionId)
    {
        var question = DataSource.questions.FirstOrDefault(q => q.questionId == questionId);
        if (question != null)
        {
            DataSource.questions.Remove(question);
        }
        else
        {
            throw new DalDoesNotExistException();
        }
    }
    public Question? Read(int questionId)
    {
        return DataSource.questions.FirstOrDefault(q => q.questionId == questionId);
    }
    public List<Question> ReadAll()
    {
        return DataSource.questions.ToList();
    }
    public void Update(Question updatedQuestion)
    {
        var question = DataSource.questions.FirstOrDefault(q => q.questionId == updatedQuestion.questionId);
        if (question != null)
        {
            DataSource.questions.Remove(question);
            DataSource.questions.Add(updatedQuestion);
        }
        else
        {
            throw new DalDoesNotExistException();
        }
    }
}