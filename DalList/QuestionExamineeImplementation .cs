using DO;
using DalApi;
using Dal;
namespace DalList;
    
	internal class QuestionExamineeImplementation : IQuestionExaminee
    {
		public int Create(QuestionExaminee questionExaminee)
		{
            QuestionExaminee newQuestionExaminee = new QuestionExaminee()
            var searchQuestionExaminee = DataSource.questionExaminee.FirstOrDefault(qe => qe.questionExamineeId == questionExaminee.questionExamineeId);
            if (searchQuestionExaminee != null)
            {
                //לשלוח לעדכון או לזרוק שגיאה?
            }
            else
            {
                questionExaminee.questionExamineeId = DataSource.QuestionExamineeConfig.GetNextId();    
            studentId = questionExaminee.studentId,
                testId = questionExaminee.testId,
                questionId = questionExaminee.questionId,
                examineeAnswerId = questionExaminee.examineeAnswerId
            }
            DataSource.testAnswer.Add(newQuestionExaminee);
            return newQuestionExaminee.testId;
        }

        public void Delete(QuestionExaminee questionExaminee)
        {
            var existingQuestionExaminee = DataSource.questionExaminee.FirstOrDefault(qe => qe.questionExamineeId == questionExaminee.questionExamineeId);
            if (existingQuestionExaminee != null)
            {
                DataSource.questionExaminee.Remove(existingQuestionExaminee);
            }
            else
            {
                throw new KeyNotFoundException($"QuestionExaminee with Student ID {questionExaminee.studentId}, Test ID {questionExaminee.testId}, and Question ID {questionExaminee.questionId} not found.");
            }
        }

        public QuestionExaminee? Read(int studentId, int testId, int questionId)
        {
            return DataSource.questionExaminee.FirstOrDefault(qe => qe.questionExamineeId == questionExaminee.questionExamineeId);
        }

        public List<QuestionExaminee> ReadAll()
        {
            return DataSource.questionExaminee.ToList();
        }

        public void Update(QuestionExaminee updatedQuestionExaminee)
        {
            var existingQuestionExaminee = DataSource.questionExaminee.FirstOrDefault(qe => qe.questionExamineeId == updatedQuestionExaminee.questionExamineeId);
            if (existingQuestionExaminee != null)
            {
                DataSource.questionExaminee.Remove(existingQuestionExaminee);
                DataSource.questionExaminee.Add(updatedQuestionExaminee);
            }
            else
            {
                throw new KeyNotFoundException($"QuestionExaminee with Student ID {updatedQuestionExaminee.studentId}, Test ID {updatedQuestionExaminee.testId}, and Question ID {updatedQuestionExaminee.questionId} not found.");
            }
        }
    }
}