using DO;
using DalApi;
using Dal;
using System.Reflection;
using Tools;

namespace DalList;

internal class QuestionExamineeImplementation : IQuestionExaminee
{
    public int Create(QuestionExaminee questionExaminee)
    {
        Tools.LogManager.Log(
            MethodBase.GetCurrentMethod()?.DeclaringType?.FullName ?? "DalList",
            MethodBase.GetCurrentMethod()?.Name ?? "Create",
            $"Start: questionExamineeId={questionExaminee.questionExamineeId}"
        );

        var searchQuestionExaminee = DataSource.questionExaminee.FirstOrDefault(qe => qe?.questionExamineeId == questionExaminee.questionExamineeId);
        if (searchQuestionExaminee != null)
        {
            Tools.LogManager.Log(
                MethodBase.GetCurrentMethod()?.DeclaringType?.FullName ?? "DalList",
                MethodBase.GetCurrentMethod()?.Name ?? "Create",
                $"Error: questionExamineeId={questionExaminee.questionExamineeId} already exists"
            );
            throw new DalInvalidValueException();
        }

        int newId = DataSource.QuestionExamineeConfig.GetNextId();

        QuestionExaminee newQuestionExaminee = questionExaminee with { questionExamineeId = newId };

        DataSource.questionExaminee.Add(newQuestionExaminee);

        Tools.LogManager.Log(
            MethodBase.GetCurrentMethod()?.DeclaringType?.FullName ?? "DalList",
            MethodBase.GetCurrentMethod()?.Name ?? "Create",
            $"End: created questionExamineeId={newId}"
        );

        return newId;
    }

    public void Delete(QuestionExaminee questionExaminee)
    {
        Tools.LogManager.Log(
            MethodBase.GetCurrentMethod()?.DeclaringType?.FullName ?? "DalList",
            MethodBase.GetCurrentMethod()?.Name ?? "Delete",
            $"Start: questionExamineeId={questionExaminee.questionExamineeId}"
        );

        var existingQuestionExaminee = DataSource.questionExaminee.FirstOrDefault(qe => qe?.questionExamineeId == questionExaminee.questionExamineeId);
        if (existingQuestionExaminee != null)
        {
            DataSource.questionExaminee.Remove(existingQuestionExaminee);
            Tools.LogManager.Log(
                MethodBase.GetCurrentMethod()?.DeclaringType?.FullName ?? "DalList",
                MethodBase.GetCurrentMethod()?.Name ?? "Delete",
                $"End: successfully deleted questionExamineeId={questionExaminee.questionExamineeId}"
            );
        }
        else
        {
            Tools.LogManager.Log(
                MethodBase.GetCurrentMethod()?.DeclaringType?.FullName ?? "DalList",
                MethodBase.GetCurrentMethod()?.Name ?? "Delete",
                $"Error: questionExamineeId={questionExaminee.questionExamineeId} does not exist"
            );
            throw new DalDoesNotExistException();
        }
    }

    public void Delete(int id)
    {
        Tools.LogManager.Log(
            MethodBase.GetCurrentMethod()?.DeclaringType?.FullName ?? "DalList",
            MethodBase.GetCurrentMethod()?.Name ?? "Delete",
            $"Start: id={id}"
        );

        var existingQuestionExaminee = DataSource.questionExaminee.FirstOrDefault(qe => qe?.questionExamineeId == id);
        if (existingQuestionExaminee != null)
        {
            DataSource.questionExaminee.Remove(existingQuestionExaminee);
            Tools.LogManager.Log(
                MethodBase.GetCurrentMethod()?.DeclaringType?.FullName ?? "DalList",
                MethodBase.GetCurrentMethod()?.Name ?? "Delete",
                $"End: successfully deleted id={id}"
            );
        }
        else
        {
            Tools.LogManager.Log(
                MethodBase.GetCurrentMethod()?.DeclaringType?.FullName ?? "DalList",
                MethodBase.GetCurrentMethod()?.Name ?? "Delete",
                $"Error: id={id} does not exist"
            );
            throw new DalDoesNotExistException();
        }
    }

    public QuestionExaminee? Read(int studentId, int testId, int questionId)
    {
        Tools.LogManager.Log(
            MethodBase.GetCurrentMethod()?.DeclaringType?.FullName ?? "DalList",
            MethodBase.GetCurrentMethod()?.Name ?? "Read",
            $"Start: studentId={studentId}, testId={testId}, questionId={questionId}"
        );

        var result = DataSource.questionExaminee.FirstOrDefault(qe => qe?.studentId == studentId && qe?.testId == testId && qe?.questionId == questionId);

        Tools.LogManager.Log(
            MethodBase.GetCurrentMethod()?.DeclaringType?.FullName ?? "DalList",
            MethodBase.GetCurrentMethod()?.Name ?? "Read",
            "End: read executed"
        );

        return result;
    }

    public QuestionExaminee? Read(int id)
    {
        Tools.LogManager.Log(
            MethodBase.GetCurrentMethod()?.DeclaringType?.FullName ?? "DalList",
            MethodBase.GetCurrentMethod()?.Name ?? "Read",
            $"Start: id={id}"
        );

        var result = DataSource.questionExaminee.FirstOrDefault(qe => qe?.questionExamineeId == id);

        Tools.LogManager.Log(
            MethodBase.GetCurrentMethod()?.DeclaringType?.FullName ?? "DalList",
            MethodBase.GetCurrentMethod()?.Name ?? "Read",
            $"End: read executed for id={id}"
        );

        return result;
    }

    public List<QuestionExaminee> ReadAll()
    {
        Tools.LogManager.Log(
            MethodBase.GetCurrentMethod()?.DeclaringType?.FullName ?? "DalList",
            MethodBase.GetCurrentMethod()?.Name ?? "ReadAll",
            "Start"
        );

        var list = DataSource.questionExaminee.Where(qe => qe != null).ToList()!;

        Tools.LogManager.Log(
            MethodBase.GetCurrentMethod()?.DeclaringType?.FullName ?? "DalList",
            MethodBase.GetCurrentMethod()?.Name ?? "ReadAll",
            $"End: returned {list.Count} items"
        );

        return list;
    }

    public void Update(QuestionExaminee updatedQuestionExaminee)
    {
        Tools.LogManager.Log(
            MethodBase.GetCurrentMethod()?.DeclaringType?.FullName ?? "DalList",
            MethodBase.GetCurrentMethod()?.Name ?? "Update",
            $"Start: questionExamineeId={updatedQuestionExaminee.questionExamineeId}"
        );

        var existingIndex = DataSource.questionExaminee.FindIndex(qe => qe?.questionExamineeId == updatedQuestionExaminee.questionExamineeId);
        if (existingIndex != -1)
        {
            DataSource.questionExaminee[existingIndex] = updatedQuestionExaminee;
            Tools.LogManager.Log(
                MethodBase.GetCurrentMethod()?.DeclaringType?.FullName ?? "DalList",
                MethodBase.GetCurrentMethod()?.Name ?? "Update",
                $"End: successfully updated questionExamineeId={updatedQuestionExaminee.questionExamineeId}"
            );
        }
        else
        {
            Tools.LogManager.Log(
                MethodBase.GetCurrentMethod()?.DeclaringType?.FullName ?? "DalList",
                MethodBase.GetCurrentMethod()?.Name ?? "Update",
                $"Error: questionExamineeId={updatedQuestionExaminee.questionExamineeId} does not exist"
            );
            throw new DalDoesNotExistException();
        }
    }
}