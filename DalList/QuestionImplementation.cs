using DO;
using DalApi;
using Dal;
using System.Reflection;
using Tools;

namespace DalList;

internal class QuestionImplementation : IQuestion
{
    public int Create(Question question)
    {
        Tools.LogManager.Log(
            MethodBase.GetCurrentMethod()?.DeclaringType?.FullName ?? "DalList",
            MethodBase.GetCurrentMethod()?.Name ?? "Create",
            $"Start: questionId={question.questionId}"
        );

        Question newQuestion = new Question
        {
            questionId = DataSource.QuestionConfig.GetNextId(),
            questionType = question.questionType,
            content = question.content,
            isCorect = question.isCorect
        };

        DataSource.questions.Add(newQuestion);

        Tools.LogManager.Log(
            MethodBase.GetCurrentMethod()?.DeclaringType?.FullName ?? "DalList",
            MethodBase.GetCurrentMethod()?.Name ?? "Create",
            $"End: created questionId={newQuestion.questionId}"
        );

        return newQuestion.questionId;
    }

    public void Delete(int questionId)
    {
        Tools.LogManager.Log(
            MethodBase.GetCurrentMethod()?.DeclaringType?.FullName ?? "DalList",
            MethodBase.GetCurrentMethod()?.Name ?? "Delete",
            $"Start: questionId={questionId}"
        );

        var question = DataSource.questions.FirstOrDefault(q => q.questionId == questionId);
        if (question != null)
        {
            DataSource.questions.Remove(question);
            Tools.LogManager.Log(
                MethodBase.GetCurrentMethod()?.DeclaringType?.FullName ?? "DalList",
                MethodBase.GetCurrentMethod()?.Name ?? "Delete",
                $"End: successfully deleted questionId={questionId}"
            );
        }
        else
        {
            Tools.LogManager.Log(
                MethodBase.GetCurrentMethod()?.DeclaringType?.FullName ?? "DalList",
                MethodBase.GetCurrentMethod()?.Name ?? "Delete",
                $"Error: questionId={questionId} does not exist"
            );
            throw new DalDoesNotExistException();
        }
    }

    public Question? Read(int questionId)
    {
        Tools.LogManager.Log(
            MethodBase.GetCurrentMethod()?.DeclaringType?.FullName ?? "DalList",
            MethodBase.GetCurrentMethod()?.Name ?? "Read",
            $"Start: questionId={questionId}"
        );

        var question = DataSource.questions.FirstOrDefault(q => q.questionId == questionId);

        Tools.LogManager.Log(
            MethodBase.GetCurrentMethod()?.DeclaringType?.FullName ?? "DalList",
            MethodBase.GetCurrentMethod()?.Name ?? "Read",
            $"End: read executed for questionId={questionId}"
        );

        return question;
    }

    public List<Question> ReadAll()
    {
        Tools.LogManager.Log(
            MethodBase.GetCurrentMethod()?.DeclaringType?.FullName ?? "DalList",
            MethodBase.GetCurrentMethod()?.Name ?? "ReadAll",
            "Start"
        );

        var list = DataSource.questions.ToList();

        Tools.LogManager.Log(
            MethodBase.GetCurrentMethod()?.DeclaringType?.FullName ?? "DalList",
            MethodBase.GetCurrentMethod()?.Name ?? "ReadAll",
            $"End: returned {list.Count} items"
        );

        return list;
    }

    public void Update(Question updatedQuestion)
    {
        Tools.LogManager.Log(
            MethodBase.GetCurrentMethod()?.DeclaringType?.FullName ?? "DalList",
            MethodBase.GetCurrentMethod()?.Name ?? "Update",
            $"Start: questionId={updatedQuestion.questionId}"
        );

        var question = DataSource.questions.FirstOrDefault(q => q.questionId == updatedQuestion.questionId);
        if (question != null)
        {
            DataSource.questions.Remove(question);
            DataSource.questions.Add(updatedQuestion);

            Tools.LogManager.Log(
                MethodBase.GetCurrentMethod()?.DeclaringType?.FullName ?? "DalList",
                MethodBase.GetCurrentMethod()?.Name ?? "Update",
                $"End: successfully updated questionId={updatedQuestion.questionId}"
            );
        }
        else
        {
            Tools.LogManager.Log(
                MethodBase.GetCurrentMethod()?.DeclaringType?.FullName ?? "DalList",
                MethodBase.GetCurrentMethod()?.Name ?? "Update",
                $"Error: questionId={updatedQuestion.questionId} does not exist"
            );
            throw new DalDoesNotExistException();
        }
    }
}