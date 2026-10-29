using DO;
using DalApi;
using Dal;

namespace DalList;

internal class QuestionExamineeImplementation : IQuestionExaminee
{
    public int Create(QuestionExaminee questionExaminee)
    {
        var searchQuestionExaminee = DataSource.questionExaminee.FirstOrDefault(qe => qe?.questionExamineeId == questionExaminee.questionExamineeId);
        if (searchQuestionExaminee != null)
        {
            throw new DalInvalidValueException();
        }

        int newId = DataSource.QuestionExamineeConfig.GetNextId();

        QuestionExaminee newQuestionExaminee = questionExaminee with { questionExamineeId = newId };

        DataSource.questionExaminee.Add(newQuestionExaminee);
        return newId;
    }

    public void Delete(QuestionExaminee questionExaminee)
    {
        var existingQuestionExaminee = DataSource.questionExaminee.FirstOrDefault(qe => qe?.questionExamineeId == questionExaminee.questionExamineeId);
        if (existingQuestionExaminee != null)
        {
            DataSource.questionExaminee.Remove(existingQuestionExaminee);
        }
        else
        {
            throw new DalDoesNotExistException();
        }
    }

    public void Delete(int id)
    {
        var existingQuestionExaminee = DataSource.questionExaminee  .FirstOrDefault(qe => qe?.questionExamineeId == id);
        if (existingQuestionExaminee != null)
        {
            DataSource.questionExaminee.Remove(existingQuestionExaminee);
        }
        else
        {
            throw new DalDoesNotExistException();
        }
    }

    public QuestionExaminee? Read(int studentId, int testId, int questionId)
    {
        return DataSource.questionExaminee.FirstOrDefault(qe => qe?.studentId == studentId && qe?.testId == testId && qe?.questionId == questionId);
    }

    public QuestionExaminee? Read(int id)
    {
        return DataSource.questionExaminee.FirstOrDefault(qe => qe?.questionExamineeId == id);
    }

    public List<QuestionExaminee> ReadAll()
    {
        return DataSource.questionExaminee.Where(qe => qe != null).ToList()!;
    }

    public void Update(QuestionExaminee updatedQuestionExaminee)
    {
        var existingIndex = DataSource.questionExaminee.FindIndex(qe => qe?.questionExamineeId == updatedQuestionExaminee.questionExamineeId);
        if (existingIndex != -1)
        {
            DataSource.questionExaminee[existingIndex] = updatedQuestionExaminee;
        }
        else
        {
            throw new DalDoesNotExistException();
        }
    }
}