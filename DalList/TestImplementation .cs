using DO;
using DalApi;
 namespace DalList
{

    internal  class TestImplementation:ITest
    {
        public int Create(Test test)
        {
            Test newTest = test;
            newTest.testId = DataSource.Config.GetNextId();
            DataSource.tests.Add(newTest);
            return newTest.testId;
        }

        public Test? Read(int testId)
        {
            return DataSource.tests.FirstOrDefault(t => t.testId == testId);
        }

        public List<Test> ReadAll()
        {
            return DataSource.tests.ToList();
        }

        public void Update(Test test)
        {
            var index = DataSource.tests.FindIndex(t => t.testId == test.testId);
            if (index != -1)
            {
                DataSource.tests.Remove(test);
                DataSource.tests.Add(test);
             }
            else
            {
                throw new KeyNotFoundException($"Test with ID {test.testId} not found.");
            }
        }
        public void Delete(int testId)
        {
            var test = DataSource.tests.FirstOrDefault(t => t.testId == testId);
            if (test != null)
            {
                DataSource.tests.Remove(test);
            }
            else
            {
                throw new KeyNotFoundException($"Test with ID {testId} not found.");
            }
        }

    }
}
