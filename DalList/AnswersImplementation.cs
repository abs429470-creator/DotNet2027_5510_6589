using System.Reflection;
using DalApi;
using DO;

namespace Dal;

internal class AnswersImplementation : IAnswer
{
    public int Create(Answer answer)
    {
        Tools.LogManager.Log(
            MethodBase.GetCurrentMethod()?.DeclaringType?.FullName ?? "DalList",
            MethodBase.GetCurrentMethod()?.Name ?? "Create",
            $"Start: questionId={answer.questionId}"
        );

        Answer newAnswer = new Answer
        {
            answerId = DataSource.AnswerConfig.GetNextId(),
            questionId = answer.questionId,
            content = answer.content
        };
        DataSource.answers.Add(newAnswer);

        Tools.LogManager.Log(
            MethodBase.GetCurrentMethod()?.DeclaringType?.FullName ?? "DalList",
            MethodBase.GetCurrentMethod()?.Name ?? "Create",
            $"End: created answerId={newAnswer.answerId}"
        );

        return newAnswer.answerId;
    }

    public void Delete(int answerId)
    {
        Tools.LogManager.Log(
            MethodBase.GetCurrentMethod()?.DeclaringType?.FullName ?? "DalList",
            MethodBase.GetCurrentMethod()?.Name ?? "Delete",
            $"Start: answerId={answerId}"
        );

        var answer = DataSource.answers.FirstOrDefault(a => a.answerId == answerId);
        if (answer != null)
        {
            DataSource.answers.Remove(answer);
            Tools.LogManager.Log(
                MethodBase.GetCurrentMethod()?.DeclaringType?.FullName ?? "DalList",
                MethodBase.GetCurrentMethod()?.Name ?? "Delete",
                $"End: successfully deleted answerId={answerId}"
            );
        }
        else
        {
            Tools.LogManager.Log(
                MethodBase.GetCurrentMethod()?.DeclaringType?.FullName ?? "DalList",
                MethodBase.GetCurrentMethod()?.Name ?? "Delete",
                $"Error: answerId={answerId} does not exist"
            );
            throw new DalDoesNotExistException();
        }
    }

    public Answer? Read(int answerId)
    {
        Tools.LogManager.Log(
            MethodBase.GetCurrentMethod()?.DeclaringType?.FullName ?? "DalList",
            MethodBase.GetCurrentMethod()?.Name ?? "Read",
            $"Start: answerId={answerId}"
        );

        var result = DataSource.answers.FirstOrDefault(a => a.answerId == answerId);

        Tools.LogManager.Log(
            MethodBase.GetCurrentMethod()?.DeclaringType?.FullName ?? "DalList",
            MethodBase.GetCurrentMethod()?.Name ?? "Read",
            $"End: read executed for answerId={answerId}"
        );

        return result;
    }
    public Answer? Read(Func<Answer, bool> filter)
    {
        Tools.LogManager.Log(
            MethodBase.GetCurrentMethod()?.DeclaringType?.FullName ?? "DalList",
            MethodBase.GetCurrentMethod()?.Name ?? "Read",
            "Start"
        );

        if (filter == null)
            throw new ArgumentNullException(nameof(filter));

        var result = DataSource.answers.FirstOrDefault(qe => qe != null && filter(qe));

        Tools.LogManager.Log(
            MethodBase.GetCurrentMethod()?.DeclaringType?.FullName ?? "DalList",
            MethodBase.GetCurrentMethod()?.Name ?? "Read",
            "End"
        );

        return result;
    }


    public List<Answer> ReadAll(Func<Answer, bool>? filter = null)
    {
        Tools.LogManager.Log(
            MethodBase.GetCurrentMethod()?.DeclaringType?.FullName ?? "DalList",
            MethodBase.GetCurrentMethod()?.Name ?? "ReadAll",
            "Start"
        );

        var result = filter == null
            ? DataSource.answers.ToList()
            : DataSource.answers.Where(filter).ToList();

        Tools.LogManager.Log(
            MethodBase.GetCurrentMethod()?.DeclaringType?.FullName ?? "DalList",
            MethodBase.GetCurrentMethod()?.Name ?? "ReadAll",
            "End"
        );

        return result;
    }


    public void Update(Answer updatedAnswer)
    {
        Tools.LogManager.Log(
            MethodBase.GetCurrentMethod()?.DeclaringType?.FullName ?? "DalList",
            MethodBase.GetCurrentMethod()?.Name ?? "Update",
            $"Start: answerId={updatedAnswer.answerId}"
        );

        var answer = DataSource.answers.FirstOrDefault(a => a.answerId == updatedAnswer.answerId);
        if (answer != null)
        {
            DataSource.answers.Remove(answer);
            DataSource.answers.Add(updatedAnswer);

            Tools.LogManager.Log(
                MethodBase.GetCurrentMethod()?.DeclaringType?.FullName ?? "DalList",
                MethodBase.GetCurrentMethod()?.Name ?? "Update",
                $"End: successfully updated answerId={updatedAnswer.answerId}"
            );
        }
        else
        {
            Tools.LogManager.Log(
                MethodBase.GetCurrentMethod()?.DeclaringType?.FullName ?? "DalList",
                MethodBase.GetCurrentMethod()?.Name ?? "Update",
                $"Error: answerId={updatedAnswer.answerId} does not exist"
            );
            throw new DalDoesNotExistException();
        }
    }
}