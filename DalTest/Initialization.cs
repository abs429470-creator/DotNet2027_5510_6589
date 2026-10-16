using DO;
using DalApi;
   namespace DalTest;

public static class Initialization
{
    IDal static  s_dal ;

      public  static void createTest()
    {
        s_dal.Test.Create(new Test(0, testType.MATH, new DateTime(2027, 10, 12), 10));
        s_dal.Test.Create(new Test(0, testType.ENGLISH, new DateTime(2027, 8, 23), 10));
        s_dal.Test.Create(new Test(0, testType.GEOGRAPHY, new DateTime(2027, 7, 30), 10));
        s_dal.Test.Create(new Test(0, testType.GRAMMAR, new DateTime(2027, 9, 5), 10));
        s_dal.Test.Create(new Test(0, testType.TECHNOLOGY, new DateTime(2027, 6,25), 10));
    }

    public static void createAnswer()
    {
        s_dal.TestAnswer.Create(new TestAnswer(0, 1, "A"));
        s_dal.TestAnswer.Create(new TestAnswer(0, 2, "B"));
        s_dal.TestAnswer.Create(new TestAnswer(0, 3, "C"));
        s_dal.TestAnswer.Create(new TestAnswer(0, 4, "D"));
        s_dal.TestAnswer.Create(new TestAnswer(0, 5, "E"));
        s_dal.TestAnswer.Create(new TestAnswer(0, 6, "F"));
        s_dal.TestAnswer.Create(new TestAnswer(0, 7, "G"));
        s_dal.TestAnswer.Create(new TestAnswer(0, 8, "H"));
        s_dal.TestAnswer.Create(new TestAnswer(0, 9, "I"));
        s_dal.TestAnswer.Create(new TestAnswer(0, 10, "J"));
        s_dal.TestAnswer.Create(new TestAnswer(0, 11, "K"));
        s_dal.TestAnswer.Create(new TestAnswer(0, 12, "L"));
        s_dal.TestAnswer.Create(new TestAnswer(0, 13, "M"));
        s_dal.TestAnswer.Create(new TestAnswer(0, 14, "N"));
        s_dal.TestAnswer.Create(new TestAnswer(0, 15, "O"));
        s_dal.TestAnswer.Create(new TestAnswer(0, 16, "P"));
        s_dal.TestAnswer.Create(new TestAnswer(0, 17, "Q"));
        s_dal.TestAnswer.Create(new TestAnswer(0, 18, "R"));
        s_dal.TestAnswer.Create(new TestAnswer(0, 19, "S"));
        s_dal.TestAnswer.Create(new TestAnswer(0, 20, "T"));
    }

    //public static void createQuestionExaminee()
    //{
    //    s_dal.QuestionExaminee.Create(new QuestionExaminee(1, 1, 1, 1));
    //    s_dal.QuestionExaminee.Create(new QuestionExaminee(2, 1, 2, 2));
    //    s_dal.QuestionExaminee.Create(new QuestionExaminee(3, 1, 3, 3));
    //    s_dal.QuestionExaminee.Create(new QuestionExaminee(4, 1, 4, 4));
    //    s_dal.QuestionExaminee.Create(new QuestionExaminee(5, 1, 5, 5));
    //}

}