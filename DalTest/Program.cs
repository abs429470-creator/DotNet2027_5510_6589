using DalApi;
using DalList;
using Dal;
using DO;

namespace DalTest;

public class Program
{
    private static readonly IDal s_dal = new DalList.DalList();

    static void Main(string[] args)
    {
        Initialization.Initialize(s_dal);
        MainMenu();
    }

    public static void MainMenu()
    {
        int choice;
        do
        {
            Console.WriteLine("Main Menu:");
            Console.WriteLine("1. Student Menu");
            Console.WriteLine("2. Test Menu");
            Console.WriteLine("3. Question Menu");
            Console.WriteLine("4. Answer Menu");
            Console.WriteLine("5. Question Examinee Menu");
            Console.WriteLine("6. Exit");
            choice = int.TryParse(Console.ReadLine(), out choice) ? choice : -1;
            switch (choice)
            {
                case 1:
                    StudentMenu();
                    break;
                case 2:
                    TestMenu();
                    break;
                case 3:
                    QuestionMenu();
                    break;
                case 4:
                    AnswerMenu();
                    break;
                case 5:
                    QuestionExamineeMenu();
                    break;
                case 6:
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        } while (choice != 6);
    }

    public static void StudentMenu()
    {
        int choice;
        do
        {
            Console.WriteLine("Student Menu:");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Update Student");
            Console.WriteLine("3. Read Student by ID");
            Console.WriteLine("4. Read All Students");
            Console.WriteLine("5. Delete Student");
            Console.WriteLine("6. Back to Main Menu");
            choice = int.TryParse(Console.ReadLine(), out choice) ? choice : -1;
            switch (choice)
            {
                case 1:
                    AddStudent();
                    break;
                case 2:
                    UpdateStudent();
                    break;
                case 3:
                    Read(s_dal.student);
                    break;
                case 4:
                    ReadAll(s_dal.student);
                    break;
                case 5:
                    Delete(s_dal.student);
                    break;
                case 6:
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        } while (choice != 6);
    }

    public static void TestMenu()
    {
        int choice;
        do
        {
            Console.WriteLine("Test Menu:");
            Console.WriteLine("1. Add Test");
            Console.WriteLine("2. Update Test");
            Console.WriteLine("3. Read Test by ID");
            Console.WriteLine("4. Read All Tests");
            Console.WriteLine("5. Delete Test");
            Console.WriteLine("6. Back to Main Menu");
            choice = int.TryParse(Console.ReadLine(), out choice) ? choice : -1;
            switch (choice)
            {
                case 1:
                    AddTest();
                    break;
                case 2:
                    UpdateTest();
                    break;
                case 3:
                    Read(s_dal.test);
                    break;
                case 4:
                    ReadAll(s_dal.test);
                    break;
                case 5:
                    Delete(s_dal.test);
                    break;
                case 6:
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        } while (choice != 6);
    }

    public static void QuestionMenu()
    {
        int choice;
        do
        {
            Console.WriteLine("Question Menu:");
            Console.WriteLine("1. Add Question");
            Console.WriteLine("2. Update Question");
            Console.WriteLine("3. Read Question by ID");
            Console.WriteLine("4. Read All Questions");
            Console.WriteLine("5. Delete Question");
            Console.WriteLine("6. Back to Main Menu");
            choice = int.TryParse(Console.ReadLine(), out choice) ? choice : -1;
            switch (choice)
            {
                case 1:
                    AddQuestion();
                    break;
                case 2:
                    UpdateQuestion();
                    break;
                case 3:
                    Read(s_dal.question);
                    break;
                case 4:
                    ReadAll(s_dal.question);
                    break;
                case 5:
                    Delete(s_dal.question);
                    break;
                case 6:
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        } while (choice != 6);
    }

    public static void AnswerMenu()
    {
        int choice;
        do
        {
            Console.WriteLine("Answer Menu:");
            Console.WriteLine("1. Add Answer");
            Console.WriteLine("2. Update Answer");
            Console.WriteLine("3. Read Answer by ID");
            Console.WriteLine("4. Read All Answers");
            Console.WriteLine("5. Delete Answer");
            Console.WriteLine("6. Back to Main Menu");
            choice = int.TryParse(Console.ReadLine(), out choice) ? choice : -1;
            switch (choice)
            {
                case 1:
                    AddAnswer();
                    break;
                case 2:
                    UpdateAnswer();
                    break;
                case 3:
                    Read(s_dal.answer);
                    break;
                case 4:
                    ReadAll(s_dal.answer);
                    break;
                case 5:
                    Delete(s_dal.answer);
                    break;
                case 6:
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        } while (choice != 6);
    }

    public static void QuestionExamineeMenu()
    {
        int choice;
        do
        {
            Console.WriteLine("Question Examinee Menu:");
            Console.WriteLine("1. Add Question Examinee");
            Console.WriteLine("2. Update Question Examinee");
            Console.WriteLine("3. Read Question Examinee by ID");
            Console.WriteLine("4. Read All Question Examinees");
            Console.WriteLine("5. Delete Question Examinee");
            Console.WriteLine("6. Back to Main Menu");
            choice = int.TryParse(Console.ReadLine(), out choice) ? choice : -1;
            switch (choice)
            {
                case 1:
                    AddQuestionExaminee();
                    break;
                case 2:
                    UpdateQuestionExaminee();
                    break;
                case 3:
                    Read(s_dal.questionExaminee);
                    break;
                case 4:
                    ReadAll(s_dal.questionExaminee);
                    break;
                case 5:
                    Delete(s_dal.questionExaminee);
                    break;
                case 6:
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        } while (choice != 6);
    }

    public static int GetValidId()
    {
        while (true)
        {
            string input = Console.ReadLine() ?? "";
            if (int.TryParse(input, out int id) && id >= 0 && input.Length <= 10)
            {
                return id;
            }
            Console.WriteLine("Invalid ID. Please enter a valid number (up to 10 digits):");
        }
    }

    public static Students createStudentByUser()
    {
        Console.WriteLine("Enter student ID:");
        int id = GetValidId();
        Console.WriteLine("Enter student name:");
        string name = Console.ReadLine() ?? "";
        Console.WriteLine("Enter test ID that the student took:");
        int testId = GetValidId();
        Console.WriteLine("Enter the mark that the student received:");
        int mark = int.TryParse(Console.ReadLine(), out int m) ? m : 0;

        return new Students
        {
            studentId = id,
            studentName = name,
            testId = testId,
            mark = mark
        };
    }

    public static Test createTestByUser()
    {
        Console.WriteLine("Select test type:");
        Console.WriteLine("1. MATH");
        Console.WriteLine("2. ENGLIS");
        Console.WriteLine("3. GEOGRAPHY");
        Console.WriteLine("4. GRAMMER");
        Console.WriteLine("5. TECHNOLOGY");
        testType tType = (testType)int.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Enter date of test :");
        DateTime date = DateTime.Parse(Console.ReadLine() ?? DateTime.Now.ToString());

        Console.WriteLine("Enter the number of questions in the test:");
        int count = int.TryParse(Console.ReadLine(), out int c) ? c : 0;

        return new Test
        {
            testType = tType,
            dateOfTest = date,
            count = count
        };
    }

    public static Question createQuestionByUser()
    {
        Console.WriteLine("Select question type:");
        Console.WriteLine("0. None");
        Console.WriteLine("1. Multiple Choice");
        Console.WriteLine("2. True/False");
        Console.WriteLine("3. Short Answer");
        questionType qType = (questionType)int.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Enter question content:");
        string content = Console.ReadLine() ?? "";

        Console.WriteLine("Enter the correct answer ID:");
        int isCorect = int.TryParse(Console.ReadLine(), out int c) ? c : 0;

        return new Question
        {
            questionType = qType,
            content = content,
            isCorect = isCorect
        };
    }

    public static Answer createAnswerByUser()
    {
        Console.WriteLine("Enter the question ID that this answer belongs to:");
        int qId = GetValidId();

        Console.WriteLine("Enter the answer content:");
        string content = Console.ReadLine() ?? "";

        return new Answer
        {
            questionId = qId,
            content = content
        };
    }

    public static QuestionExaminee createQuestionExamineeByUser()
    {
        Console.WriteLine("Enter the student ID:");
        int studentId = GetValidId();

        Console.WriteLine("Enter the test ID:");
        int testId = GetValidId();

        Console.WriteLine("Enter the question ID:");
        int questionId = GetValidId();

        Console.WriteLine("Enter the examinee answer ID:");
        int examineeAnswerId = int.TryParse(Console.ReadLine(), out int aId) ? aId : 0;

        return new QuestionExaminee
        {
            studentId = studentId,
            testId = testId,
            questionId = questionId,
            examineeAnswerId = examineeAnswerId
        };
    }

    public static void AddStudent()
    {
        Console.WriteLine("Adding a new student");
        try
        {
            var student = createStudentByUser();
            s_dal.student.Create(student);
            Console.WriteLine("Student added successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error adding student: {ex.Message}");
        }
    }

    public static void AddTest()
    {
        Console.WriteLine("Adding a new test");
        try
        {
            var test = createTestByUser();
            s_dal.test.Create(test);
            Console.WriteLine("Test added successfully.");
        }
        catch (DalExceptions ex)
        {
            Console.WriteLine($"Error adding test: {ex.Message}");
        }
    }

    public static void AddQuestion()
    {
        Console.WriteLine("Adding a new question");
        try
        {
            var question = createQuestionByUser();
            s_dal.question.Create(question);
            Console.WriteLine("Question added successfully.");
        }
        catch (DalExceptions ex)
        {
            Console.WriteLine($"Error adding question: {ex.Message}");
        }
    }

    public static void AddAnswer()
    {
        Console.WriteLine("Adding a new answer");
        try
        {
            var answer = createAnswerByUser();
            s_dal.answer.Create(answer);
            Console.WriteLine("Answer added successfully.");
        }
        catch (DalExceptions ex)
        {
            Console.WriteLine($"Error adding answer: {ex.Message}");
        }
    }

    public static void AddQuestionExaminee()
    {
        Console.WriteLine("Adding a new question examinee");
        try
        {
            var questionExaminee = createQuestionExamineeByUser();
            s_dal.questionExaminee.Create(questionExaminee);
            Console.WriteLine("Question examinee added successfully.");
        }
        catch (DalExceptions ex)
        {
            Console.WriteLine($"Error adding question examinee: {ex.Message}");
        }
    }

    public static void UpdateStudent()
    {
        Console.WriteLine("Updating a student");
        try
        {
            var student = createStudentByUser();
            s_dal.student.Update(student);
            Console.WriteLine("Student updated successfully.");
        }
        catch (DalExceptions ex)
        {
            Console.WriteLine($"Error updating student: {ex.Message}");
        }
    }

    public static void UpdateTest()
    {
        Console.WriteLine("Updating a test");
        try
        {
            var test = createTestByUser();
            s_dal.test.Update(test);
            Console.WriteLine("Test updated successfully.");
        }
        catch (DalExceptions ex)
        {
            Console.WriteLine($"Error updating test: {ex.Message}");
        }
    }

    public static void UpdateQuestion()
    {
        Console.WriteLine("Updating a question");
        try
        {
            var question = createQuestionByUser();
            s_dal.question.Update(question);
            Console.WriteLine("Question updated successfully.");
        }
        catch (DalExceptions ex)
        {
            Console.WriteLine($"Error updating question: {ex.Message}");
        }
    }

    public static void UpdateAnswer()
    {
        Console.WriteLine("Updating an answer");
        try
        {
            var answer = createAnswerByUser();
            s_dal.answer.Update(answer);
            Console.WriteLine("Answer updated successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error updating answer: {ex.Message}");
        }
    }

    public static void UpdateQuestionExaminee()
    {
        Console.WriteLine("Updating a question examinee");
        try
        {
            var questionExaminee = createQuestionExamineeByUser();
            s_dal.questionExaminee.Create(questionExaminee); // או Update בהתאם למימוש
            Console.WriteLine("Question examinee updated successfully.");
        }
        catch (DalExceptions ex)
        {
            Console.WriteLine($"Error updating question examinee: {ex.Message}");
        }
    }

    public static void ReadAll<T>(ICrud<T> crud)
    {
        try
        {
            var items = crud.ReadAll();
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
        catch (DalExceptions ex)
        {
            Console.WriteLine($"Error reading all items: {ex.Message}");
        }
    }

    public static void Read<T>(ICrud<T> crud)
    {
        Console.WriteLine("Enter the ID:");
        int id = GetValidId();
        try
        {
            var item = crud.Read(id);
            if (item != null)
            {
                Console.WriteLine(item);
            }
            else
            {
                Console.WriteLine($"Item with ID {id} not found.");
            }
        }
        catch (DalExceptions ex)
        {
            Console.WriteLine($"Error reading item: {ex.Message}");
        }
    }

    public static void Delete<T>(ICrud<T> crud)
    {
        Console.WriteLine("Enter the ID:");
        int id = GetValidId();
        try
        {
            crud.Delete(id);
            Console.WriteLine($"Item with ID {id} deleted successfully.");
        }
        catch (DalExceptions ex)
        {
            Console.WriteLine($"Error deleting item: {ex.Message}");
        }
    }
}
