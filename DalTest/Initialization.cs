using DO;
using DalApi;
   namespace DalTest;

public static class Initialization
{
    IDal static  s_dal ;

        public static void createstudent()
    {
        s_dal.Student.create(new Student {});
    }


}