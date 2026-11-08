using DO;
using DalApi;
namespace DalTest;

public static class Initialization
{
    public static IDal s_dal;

    public static void createTest()
    {
        s_dal.test.Create(new Test {testId= 0,testType= testType.MATH, dateOfTest=new DateTime(2027, 6, 15),count= 10 });
        s_dal.test.Create(new Test { testId = 0, testType = testType.ENGLISH, dateOfTest = new DateTime(2027, 8, 23), count = 10 });
        s_dal.test.Create(new Test { testId = 0, testType = testType.GEOGRAPHY, dateOfTest = new DateTime(2027, 7, 30), count = 10 });
        s_dal.test.Create(new Test { testId = 0, testType = testType.GRAMMAR, dateOfTest = new DateTime(2027, 9, 5), count = 10 });
        s_dal.test.Create(new Test { testId = 0, testType = testType.TECHNOLOGY, dateOfTest = new DateTime(2027, 6, 25), count = 10 });
    }

    public static void createAnswer()
    {
        s_dal.answer.Create(new Answer { answerId = 0, questionId = 1, content = "A" });
        s_dal.answer.Create(new Answer { answerId = 0, questionId = 2, content = "B" });
        s_dal.answer.Create(new Answer { answerId = 0, questionId = 3, content = "C" });
        s_dal.answer.Create(new Answer { answerId = 0, questionId = 4, content = "D" });
        s_dal.answer.Create(new Answer { answerId = 0, questionId = 5, content = "E" });
        s_dal.answer.Create(new Answer { answerId = 0, questionId = 6, content = "F" } );
        s_dal.answer.Create(new Answer{ answerId = 0, questionId = 7, content = "G" });
        s_dal.answer.Create(new Answer{ answerId = 0, questionId = 8, content = "H" });
        s_dal.answer.Create(new Answer{ answerId = 0, questionId = 9, content = "I" });
        s_dal.answer.Create(new Answer{ answerId = 0, questionId = 10, content = "J" });
        s_dal.answer.Create(new Answer{ answerId = 0, questionId = 11, content = "K" });
        s_dal.answer.Create(new Answer{ answerId = 0, questionId = 12, content = "L" });
        s_dal.answer.Create(new Answer{ answerId = 0, questionId = 13, content = "M" });
        s_dal.answer.Create(new Answer{ answerId = 0, questionId = 14, content = "N" });
        s_dal.answer.Create(new Answer{ answerId = 0, questionId = 15, content = "O" });
        s_dal.answer.Create(new Answer{ answerId = 0, questionId = 16, content = "P" });
        s_dal.answer.Create(new Answer{ answerId = 0, questionId = 17, content = "Q" });
        s_dal.answer.Create(new Answer{ answerId = 0, questionId = 18, content = "R" });
        s_dal.answer.Create(new Answer{ answerId = 0, questionId = 19, content = "S" });
        s_dal.answer.Create(new Answer{ answerId = 0, questionId = 20, content = "T" });
    }

    public static void createStudent() 
    {
        // מבחן מזהה 10 (MATH)
        s_dal.student.Create(new Students{ studentId = 301111111, studentName = "John Smith", testId = 10, mark = 90 });
        s_dal.student.Create(new Students{ studentId = 301111112, studentName = "Emma Johnson", testId = 10, mark = 85 });
        s_dal.student.Create(new Students{ studentId = 301111113, studentName = "Michael Brown", testId = 10, mark = 78 });
        s_dal.student.Create(new Students{ studentId = 301111114, studentName = "Sarah Davis", testId = 10, mark = 92 });
        s_dal.student.Create(new Students{ studentId = 301111115, studentName = "David Wilson", testId = 10, mark = 88 }   );

        // מבחן מזהה 11 (ENGLISH)
        s_dal.student.Create(new Students{ studentId = 302222221, studentName = "James Miller", testId = 11, mark = 95 });
        s_dal.student.Create(new Students{ studentId = 302222222, studentName = "Jessica Taylor", testId = 11, mark = 84 });
        s_dal.student.Create(new Students{ studentId = 302222223, studentName = "Daniel Anderson", testId = 11, mark = 91 });
        s_dal.student.Create(new Students{ studentId = 302222224, studentName = "Ashley Thomas", testId = 11, mark = 76 });
        s_dal.student.Create(new Students{ studentId = 302222225, studentName = "Matthew Jackson", testId = 11, mark = 89 });

        // מבחן מזהה 12 (GEOGRAPHY)
        s_dal.student.Create(new Students{ studentId = 303333331, studentName = "Joshua White", testId = 12, mark = 82 });
        s_dal.student.Create(new Students{ studentId = 303333332, studentName = "Amanda Harris", testId = 12, mark = 94 });
        s_dal.student.Create(new Students{ studentId = 303333333, studentName = "Andrew Martin", testId = 12, mark = 87 });
        s_dal.student.Create(new Students{ studentId = 303333334, studentName = "Megan Clark", testId = 12, mark = 90 });
        s_dal.student.Create(new Students{ studentId = 303333335, studentName = "Ryan Lewis", testId = 12, mark = 83 });

        // מבחן מזהה 13 (GRAMMAR)
        s_dal.student.Create(new Students{ studentId = 304444441, studentName = "Nicholas Robinson", testId = 13, mark = 86 });
        s_dal.student.Create(new Students{ studentId = 304444442, studentName = "Nicole Walker", testId = 13, mark = 93 });
        s_dal.student.Create(new Students{ studentId = 304444443, studentName = "Brandon Young", testId = 13, mark = 79 });
        s_dal.student.Create(new Students{ studentId = 304444444, studentName = "Samantha Allen", testId = 13, mark = 95 });
        s_dal.student.Create(new Students{ studentId = 304444445, studentName = "Tyler King", testId = 13, mark = 88 });

        // מבחן מזהה 14 (TECHNOLOGY)
        s_dal.student.Create(new Students{ studentId = 305555551, studentName = "Justin Wright", testId = 14, mark = 98 });
        s_dal.student.Create(new Students{ studentId = 305555552, studentName = "Rachel Scott", testId = 14, mark = 91 });
        s_dal.student.Create(new Students{ studentId = 305555553, studentName = "Christian Green", testId = 14, mark = 84 });
        s_dal.student.Create(new Students{ studentId = 305555554, studentName = "Lauren Baker", testId = 14, mark = 90 });
        s_dal.student.Create(new Students{ studentId = 305555555, studentName = "Ethan Adams", testId = 14, mark = 92 });
    }

    public static void createQuestion()
    {
        s_dal.question.Create(new Question{ questionId = 0, questionType = questionType.MATH, content = "מהו שורש המספר 144?", isCorect = 1 });
        s_dal.question.Create(new Question{ questionId = 0, questionType = questionType.MATH, content = "פתור את המשוואה: 3x + 6 = 15", isCorect = 2 });
        s_dal.question.Create(new Question{ questionId = 0, questionType = questionType.MATH, content = "מהו הערך של 15 אחוז מתוך 200?", isCorect = 3 });
        s_dal.question.Create(new Question{ questionId = 0, questionType = questionType.MATH, content = "מהו הערך של הפאי מעוגל לשני מקומות אחרי הנקודה?", isCorect = 4 });
        s_dal.question.Create(new Question{ questionId = 0, questionType = questionType.MATH, content = "כמה זה 7 כפול 8?", isCorect = 5 });
        s_dal.question.Create(new Question{ questionId = 0, questionType = questionType.MATH, content = "כמה זה 50 חלקי 5?", isCorect = 6 }   );
        s_dal.question.Create(new Question{ questionId = 0, questionType = questionType.MATH, content = "מהי תוצאת החזקה 9 בריבוע?", isCorect = 7 });

        s_dal.question.Create(new Question{ questionId = 0, questionType = questionType.ENGLISH, content = "What is the past tense of the verb 'run'?", isCorect = 8 });
        s_dal.question.Create(new Question{ questionId = 0, questionType = questionType.ENGLISH, content = "Complete the sentence: She ___ to the store yesterday.", isCorect = 9 });
        s_dal.question.Create(new Question{ questionId = 0, questionType = questionType.ENGLISH, content = "What is a synonym for the word 'happy'?", isCorect = 10 });
        s_dal.question.Create(new Question{ questionId = 0, questionType = questionType.ENGLISH, content = "What is the opposite of the word 'ancient'?", isCorect = 11 });
        s_dal.question.Create(new Question{ questionId = 0, questionType = questionType.ENGLISH, content = "Spell the plural form of the noun 'dictionary'.", isCorect = 12 });
        s_dal.question.Create(new Question{ questionId = 0, questionType = questionType.ENGLISH, content = "What is the antonym of 'difficult'?", isCorect = 13 });

        s_dal.question.Create(new Question{ questionId = 0, questionType = questionType.TECHNOLOGY, content = "מה ראשי התיבות של המונח CPU?", isCorect = 14 });
        s_dal.question.Create(new Question{ questionId = 0, questionType = questionType.TECHNOLOGY, content = "איזה מבנה נתונים פועל לפי עיקרון נכנס ראשון יוצא ראשון (FIFO)?", isCorect = 15 });
        s_dal.question.Create(new Question{ questionId = 0, questionType = questionType.TECHNOLOGY, content = "מהו סיומת קבצי קוד מקור בשפת C#?", isCorect = 16 });
        s_dal.question.Create(new Question{ questionId = 0, questionType = questionType.TECHNOLOGY, content = "מה ראשי התיבות של זיכרון ה-RAM?", isCorect = 17 });
        s_dal.question.Create(new Question{ questionId = 0, questionType = questionType.TECHNOLOGY, content = "איזה פרוטוקול משמש בעיקר לאבטחת אתרי אינטרנט?", isCorect = 18 });
        s_dal.question.Create(new Question{ questionId = 0, questionType = questionType.TECHNOLOGY, content = "מה ראשי התיבות של שפת המסדי נתונים SQL?", isCorect = 19 });
        s_dal.question.Create(new Question{ questionId = 0, questionType = questionType.TECHNOLOGY, content = "איזה רכיב נחשב ל'מוח' של המחשב?", isCorect = 20 });
    }
    
    public static void createQuestionExaminee()
    {
        // מבחן 10 (MATH) — שאלה 1 אצל כל 5 התלמידים
        s_dal.questionExaminee.Create(new QuestionExaminee{ questionId = 1, studentId = 301111111, testId = 10, examineeAnswerId = 100 });
        s_dal.questionExaminee.Create(new QuestionExaminee{ questionId = 1, studentId = 301111112, testId = 10, examineeAnswerId = 101 });
        s_dal.questionExaminee.Create(new QuestionExaminee{ questionId = 1, studentId = 301111113, testId = 10, examineeAnswerId = 102 });
        s_dal.questionExaminee.Create(new QuestionExaminee{ questionId = 1, studentId = 301111114, testId = 10, examineeAnswerId = 103 });
        s_dal.questionExaminee.Create(new QuestionExaminee{ questionId = 1, studentId = 301111115, testId = 10, examineeAnswerId = 104 });

        // מבחן 11 (ENGLISH) — שאלה 8
        s_dal.questionExaminee.Create(new QuestionExaminee{ questionId = 8, studentId = 302222221, testId = 11, examineeAnswerId = 105 });
        s_dal.questionExaminee.Create(new QuestionExaminee{ questionId = 8, studentId = 302222222, testId = 11, examineeAnswerId = 106 });
        s_dal.questionExaminee.Create(new QuestionExaminee{ questionId = 8, studentId = 302222223, testId = 11, examineeAnswerId = 107 });
        s_dal.questionExaminee.Create(new QuestionExaminee{ questionId = 8, studentId = 302222224, testId = 11, examineeAnswerId = 108 });
        s_dal.questionExaminee.Create(new QuestionExaminee{ questionId = 8, studentId = 302222225, testId = 11, examineeAnswerId = 109 });

        // מבחן 12 (GEOGRAPHY) — שאלה 11 (נוצרת ב-createQuestion)
        s_dal.questionExaminee.Create(new QuestionExaminee{ questionId = 11, studentId = 303333331, testId = 12, examineeAnswerId = 110 });
        s_dal.questionExaminee.Create(new QuestionExaminee{ questionId = 11, studentId = 303333332, testId = 12, examineeAnswerId = 111 });
        s_dal.questionExaminee.Create(new QuestionExaminee{ questionId = 11, studentId = 303333333, testId = 12, examineeAnswerId = 112 });
        s_dal.questionExaminee.Create(new QuestionExaminee{ questionId = 11, studentId = 303333334, testId = 12, examineeAnswerId = 113 });
        s_dal.questionExaminee.Create(new QuestionExaminee{ questionId = 11, studentId = 303333335, testId = 12, examineeAnswerId = 114 });

        // מבחן 13 (GRAMMAR) — שאלה 12 (נוצרת ב-createQuestion)
        s_dal.questionExaminee.Create(new QuestionExaminee{ questionId = 12, studentId = 304444441, testId = 13, examineeAnswerId = 115 });
        s_dal.questionExaminee.Create(new QuestionExaminee{ questionId = 12, studentId = 304444442, testId = 13, examineeAnswerId = 116 });
        s_dal.questionExaminee.Create(new QuestionExaminee{ questionId = 12, studentId = 304444443, testId = 13, examineeAnswerId = 117 });
        s_dal.questionExaminee.Create(new QuestionExaminee{ questionId = 12, studentId = 304444444, testId = 13, examineeAnswerId = 118 });
        s_dal.questionExaminee.Create(new QuestionExaminee{ questionId = 12, studentId = 304444445, testId = 13, examineeAnswerId = 119 });

        // מבחן 14 (TECHNOLOGY) — שאלה 14
        s_dal.questionExaminee.Create(new QuestionExaminee{ questionId = 14, studentId = 305555551, testId = 14, examineeAnswerId = 120 });
        s_dal.questionExaminee.Create(new QuestionExaminee{ questionId = 14, studentId = 305555552, testId = 14, examineeAnswerId = 121 });
        s_dal.questionExaminee.Create(new QuestionExaminee{ questionId = 14, studentId = 305555553, testId = 14, examineeAnswerId = 122 });
        s_dal.questionExaminee.Create(new QuestionExaminee{ questionId = 14, studentId = 305555554, testId = 14, examineeAnswerId = 123 });
        s_dal.questionExaminee.Create(new QuestionExaminee{ questionId = 14, studentId = 305555555, testId = 14, examineeAnswerId = 124 });
    }

   

    public static void Initialize(IDal dal)
    {
        s_dal = dal;
        createTest();
        createAnswer();
        createStudent();
        createQuestion();
        createQuestionExaminee();
    }
}