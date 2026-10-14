using DO;
using DalApi;
namespace DalList;

internal class QuestionImplementation : IQuestion
{
    public int Create(Question question)
    {
        Question newQuestion = new Question
        {
            questionId = DataSource.Config.GetNextId(),
            testId = question.testId,
            questionContent = question.questionContent
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
            throw new KeyNotFoundException($"Question with ID {questionId} not found.");
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
            throw new KeyNotFoundException($"Question with ID {updatedQuestion.questionId} not found.");
        }
    }
}