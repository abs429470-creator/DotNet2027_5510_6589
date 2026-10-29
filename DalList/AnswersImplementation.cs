using DO;
using DalApi;
using Dal;
namespace DalList;

internal class AnswersImplementation : IAnswer
{
    public int Create(Answer answer)
    {
        Answer newAnswer = new Answer
        {
            answerId = DataSource.AnswerConfig.GetNextId(),
            questionId = answer.questionId,
            content = answer.content
        };
        DataSource.answers.Add(newAnswer);
        return newAnswer.answerId;
    }
    public void Delete(int answerId)
    {
        var answer = DataSource.answers.FirstOrDefault(a => a.answerId == answerId);
        if (answer != null)
        {
            DataSource.answers.Remove(answer);
        }
        else
        {
            throw new DalDoesNotExistException();
        }
    }
    public Answer? Read(int answerId)
    {
        return DataSource.answers.FirstOrDefault(a => a.answerId == answerId);
    }
    public List<Answer> ReadAll()
    {
        return DataSource.answers.ToList();
    }
    public void Update(Answer updatedAnswer)
    {
        var answer = DataSource.answers.FirstOrDefault(a => a.answerId == updatedAnswer.answerId);
        if (answer != null)
        {
            DataSource.answers.Remove(answer);
            DataSource.answers.Add(updatedAnswer);
        }
        else
        {
            throw new DalDoesNotExistException();
        }
    }

}