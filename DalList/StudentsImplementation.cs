using DO;
using DalApi;
namespace DalList
{
    internal class StudetsImplementation : IStudents

    {
        public int Create(Student student)
        {
            Student newStudent = student;
            newStudent.studentId = DataSource.Config.GetNextId();
            DataSource.students.Add(newStudent);
            return newsStudent.studentId;
        }

        public Students? Read(int studentId)
        {
           return DataSource.students.FirstOrDefault(s => s.studentId == studentId);
          
        }

        public List<Student> ReadAll()
        {
          return DataSource.students.ToList();
        }

        public void Update(Student student)
        {
            var updatedStudent = DataSource.students.FirstOrDefault(s => s.studentId == Student.studentId);
            if (updatedStudent != null)
            {
                DataSource.students.Remove(updatedStudent);
                DataSource.students.Add(student);
            }
            else
            {
                throw new KeyNotFoundException($"Student with ID {updatedStudent.studentId} not found.");
            }
        }
        public void Delete(int studentId)
        {
            var student = DataSource.students.FirstOrDefault(s => s.studentId == studentId);
            if (student != null)
            {
                DataSource.students.Remove(student);
            }
            else
            {
                throw new KeyNotFoundException($"Student with ID {studentId} not found.");
            }
        }
    }
}