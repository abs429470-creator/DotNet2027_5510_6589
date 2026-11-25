using DO;
using DalApi;
using Dal;
using System.Reflection;
using Tools;

namespace Dal;

internal class StudentsImplementation : IStudents
{
    public int Create(Students student)
    {
        Tools.LogManager.Log(
            MethodBase.GetCurrentMethod()?.DeclaringType?.FullName ?? "DalList",
            MethodBase.GetCurrentMethod()?.Name ?? "Create",
            $"Start: studentId={student.studentId}"
        );

        var exists = DataSource.students.Any(s => s?.studentId == student.studentId);
        if (exists)
        {
            Tools.LogManager.Log(
                MethodBase.GetCurrentMethod()?.DeclaringType?.FullName ?? "DalList",
                MethodBase.GetCurrentMethod()?.Name ?? "Create",
                $"Error: studentId={student.studentId} already exists"
            );
            throw new DalAlreadyExistsException();
        }

        DataSource.students.Add(student);

        Tools.LogManager.Log(
            MethodBase.GetCurrentMethod()?.DeclaringType?.FullName ?? "DalList",
            MethodBase.GetCurrentMethod()?.Name ?? "Create",
            $"End: created studentId={student.studentId}"
        );

        return student.studentId;
    }

    public Students? Read(int studentId)
    {
        Tools.LogManager.Log(
            MethodBase.GetCurrentMethod()?.DeclaringType?.FullName ?? "DalList",
            MethodBase.GetCurrentMethod()?.Name ?? "Read",
            $"Start: studentId={studentId}"
        );

        var student = DataSource.students.FirstOrDefault(s => s?.studentId == studentId);

        Tools.LogManager.Log(
            MethodBase.GetCurrentMethod()?.DeclaringType?.FullName ?? "DalList",
            MethodBase.GetCurrentMethod()?.Name ?? "Read",
            $"End: read executed for studentId={studentId}"
        );

        return student;
    }
    public Students? Read(Func<Students, bool> filter)
    {
        Tools.LogManager.Log(
            MethodBase.GetCurrentMethod()?.DeclaringType?.FullName ?? "DalList",
            MethodBase.GetCurrentMethod()?.Name ?? "Read",
            "Start"
        );

        if (filter == null)
            throw new ArgumentNullException(nameof(filter));

        var result = DataSource.students.FirstOrDefault(qe => qe != null && filter(qe));

        Tools.LogManager.Log(
            MethodBase.GetCurrentMethod()?.DeclaringType?.FullName ?? "DalList",
            MethodBase.GetCurrentMethod()?.Name ?? "Read",
            "End"
        );

        return result;
    }
    public List<Students> ReadAll(Func<Students, bool>? filter = null)
    {
        Tools.LogManager.Log(
            MethodBase.GetCurrentMethod()?.DeclaringType?.FullName ?? "DalList",
            MethodBase.GetCurrentMethod()?.Name ?? "ReadAll",
            "Start"
        );

        var result = filter == null
            ? DataSource.students.ToList()
            : DataSource.students.Where(filter).ToList();

        Tools.LogManager.Log(
            MethodBase.GetCurrentMethod()?.DeclaringType?.FullName ?? "DalList",
            MethodBase.GetCurrentMethod()?.Name ?? "ReadAll",
            "End"
        );

        return result;
    }

    public void Update(Students student)
    {
        Tools.LogManager.Log(
            MethodBase.GetCurrentMethod()?.DeclaringType?.FullName ?? "DalList",
            MethodBase.GetCurrentMethod()?.Name ?? "Update",
            $"Start: studentId={student.studentId}"
        );

        var updatedStudent = DataSource.students.FirstOrDefault(s => s?.studentId == student.studentId);
        if (updatedStudent != null)
        {
            DataSource.students.Remove(updatedStudent);
            DataSource.students.Add(student);

            Tools.LogManager.Log(
                MethodBase.GetCurrentMethod()?.DeclaringType?.FullName ?? "DalList",
                MethodBase.GetCurrentMethod()?.Name ?? "Update",
                $"End: successfully updated studentId={student.studentId}"
            );
        }
        else
        {
            Tools.LogManager.Log(
                MethodBase.GetCurrentMethod()?.DeclaringType?.FullName ?? "DalList",
                MethodBase.GetCurrentMethod()?.Name ?? "Update",
                $"Error: studentId={student.studentId} does not exist"
            );
            throw new DalDoesNotExistException();
        }
    }

    public void Delete(int studentId)
    {
        Tools.LogManager.Log(
            MethodBase.GetCurrentMethod()?.DeclaringType?.FullName ?? "DalList",
            MethodBase.GetCurrentMethod()?.Name ?? "Delete",
            $"Start: studentId={studentId}"
        );

        var student = DataSource.students.FirstOrDefault(s => s?.studentId == studentId);
        if (student != null)
        {
            DataSource.students.Remove(student);
            Tools.LogManager.Log(
                MethodBase.GetCurrentMethod()?.DeclaringType?.FullName ?? "DalList",
                MethodBase.GetCurrentMethod()?.Name ?? "Delete",
                $"End: successfully deleted studentId={studentId}"
            );
        }
        else
        {
            Tools.LogManager.Log(
                MethodBase.GetCurrentMethod()?.DeclaringType?.FullName ?? "DalList",
                MethodBase.GetCurrentMethod()?.Name ?? "Delete",
                $"Error: studentId={studentId} does not exist"
            );
            throw new DalDoesNotExistException();
        }
    }
}