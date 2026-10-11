using DO;
using DalApi;
    namespace DalList
    {
    internal class AnswersImplementation : IAnswers
    {
        public int AddAnswer(Answer answer)
        {
            answer.answerId = DataSource.Config.GetNextId();
            DataSource.answers.Add(answer);
            return answer.answerId;
        }
        public void DeleteAnswer(int answerId)
        {
            var answer = DataSource.answers.FirstOrDefault(a => a.answerId == answerId);
            if (answer != null)
            {
                DataSource.answers.Remove(answer);
            }
            else
            {
                throw new KeyNotFoundException($"Answer with ID {answerId} not found.");
            }
        }
        public Answer GetAnswer(int answerId)
        {
            var answer = DataSource.answers.FirstOrDefault(a => a.answerId == answerId);
            if (answer != null)
            {
                return answer;
            }
            else
            {
                throw new KeyNotFoundException($"Answer with ID {answerId} not found.");
            }
        }
        public IEnumerable<Answer> GetAllAnswers()
        {
            return DataSource.answers;
        }
        public void UpdateAnswer(Answer updatedAnswer)
        {
            var index = DataSource.answers.FindIndex(a => a.answerId == updatedAnswer.answerId);
            if (index != -1)
            {
                DataSource.answers[index] = updatedAnswer;
            }
            else
            {
                throw new KeyNotFoundException($"Answer with ID {updatedAnswer.answerId} not found.");
            }
        }

    }