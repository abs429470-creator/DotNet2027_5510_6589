using DO;
using DalApi;
using Dal;
namespace DalList
{
    internal class StudentsImplementation : IStudents
    {
        public int Create(Students student)
        {
            var exists = DataSource.students.Any(s => s?.studentId == student.studentId);
            if (exists)
            {
                throw new DalAlreadyExistsException();
            }

            DataSource.students.Add(student);
            return student.studentId;

        }

        public Students? Read(int studentId)
        {
           return DataSource.students.FirstOrDefault(s => s.studentId == studentId);
          
        }

        public List<Students> ReadAll()
        {
          return DataSource.students.ToList();
        }

        public void Update(Students student)
        {
            var updatedStudent = DataSource.students.FirstOrDefault(s => s.studentId == student.studentId);
            if (updatedStudent != null)
            {
                DataSource.students.Remove(updatedStudent);
                DataSource.students.Add(student);
            }
            else
            {
                throw new DalDoesNotExistException();
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
                throw new DalDoesNotExistException();
            }
        }
    }
}