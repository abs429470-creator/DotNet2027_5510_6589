using DO;
using DalApi;
using Dal;
using System.Reflection;
using Tools;

namespace DalList
{
    internal class TestImplementation : ITest
    {
        public int Create(Test test)
        {
            Tools.LogManager.Log(
                MethodBase.GetCurrentMethod()?.DeclaringType?.FullName ?? "DalList",
                MethodBase.GetCurrentMethod()?.Name ?? "Create",
                $"Start: testType={test.testType}"
            );

            Test newTest = new Test
            {
                testId = DataSource.TestConfig.GetNextId(),
                testType = test.testType,
                dateOfTest = test.dateOfTest,
                count = test.count
            };
            DataSource.tests.Add(newTest);

            Tools.LogManager.Log(
                MethodBase.GetCurrentMethod()?.DeclaringType?.FullName ?? "DalList",
                MethodBase.GetCurrentMethod()?.Name ?? "Create",
                $"End: created testId={newTest.testId}"
            );

            return newTest.testId;
        }

        public Test? Read(int testId)
        {
            Tools.LogManager.Log(
                MethodBase.GetCurrentMethod()?.DeclaringType?.FullName ?? "DalList",
                MethodBase.GetCurrentMethod()?.Name ?? "Read",
                $"Start: testId={testId}"
            );

            var test = DataSource.tests.FirstOrDefault(t => t?.testId == testId);

            Tools.LogManager.Log(
                MethodBase.GetCurrentMethod()?.DeclaringType?.FullName ?? "DalList",
                MethodBase.GetCurrentMethod()?.Name ?? "Read",
                $"End: read executed for testId={testId}"
            );

            return test;
        }

        public List<Test> ReadAll()
        {
            Tools.LogManager.Log(
                MethodBase.GetCurrentMethod()?.DeclaringType?.FullName ?? "DalList",
                MethodBase.GetCurrentMethod()?.Name ?? "ReadAll",
                "Start"
            );

            var list = DataSource.tests.Where(t => t != null).ToList()!;

            Tools.LogManager.Log(
                MethodBase.GetCurrentMethod()?.DeclaringType?.FullName ?? "DalList",
                MethodBase.GetCurrentMethod()?.Name ?? "ReadAll",
                $"End: returned {list.Count} items"
            );

            return list;
        }

        public void Update(Test test)
        {
            Tools.LogManager.Log(
                MethodBase.GetCurrentMethod()?.DeclaringType?.FullName ?? "DalList",
                MethodBase.GetCurrentMethod()?.Name ?? "Update",
                $"Start: testId={test.testId}"
            );

            var index = DataSource.tests.FindIndex(t => t?.testId == test.testId);
            if (index != -1)
            {
                DataSource.tests.RemoveAt(index);
                DataSource.tests.Add(test);

                Tools.LogManager.Log(
                    MethodBase.GetCurrentMethod()?.DeclaringType?.FullName ?? "DalList",
                    MethodBase.GetCurrentMethod()?.Name ?? "Update",
                    $"End: successfully updated testId={test.testId}"
                );
            }
            else
            {
                Tools.LogManager.Log(
                    MethodBase.GetCurrentMethod()?.DeclaringType?.FullName ?? "DalList",
                    MethodBase.GetCurrentMethod()?.Name ?? "Update",
                    $"Error: testId={test.testId} does not exist"
                );
                throw new DalDoesNotExistException();
            }
        }

        public void Delete(int testId)
        {
            Tools.LogManager.Log(
                MethodBase.GetCurrentMethod()?.DeclaringType?.FullName ?? "DalList",
                MethodBase.GetCurrentMethod()?.Name ?? "Delete",
                $"Start: testId={testId}"
            );

            var test = DataSource.tests.FirstOrDefault(t => t?.testId == testId);
            if (test != null)
            {
                DataSource.tests.Remove(test);
                Tools.LogManager.Log(
                    MethodBase.GetCurrentMethod()?.DeclaringType?.FullName ?? "DalList",
                    MethodBase.GetCurrentMethod()?.Name ?? "Delete",
                    $"End: successfully deleted testId={testId}"
                );
            }
            else
            {
                Tools.LogManager.Log(
                    MethodBase.GetCurrentMethod()?.DeclaringType?.FullName ?? "DalList",
                    MethodBase.GetCurrentMethod()?.Name ?? "Delete",
                    $"Error: testId={testId} does not exist"
                );
                throw new KeyNotFoundException($"Test with ID {testId} not found.");
            }
        }
    }
}