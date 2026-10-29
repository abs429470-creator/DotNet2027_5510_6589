using System;
using System.Collections.Generic;
using System.Text;

namespace DalList
{
    public class DalExceptions: Exception
            {
        public DalExceptions(string message) : base(message) { }

    }
    public class MissingIdException : DalExceptions
    {
        public MissingIdException(): base("Missing Id") { }
    }
    public class MissingNameException : DalExceptions
    {
        public MissingNameException() : base("Missing Name") { }
    }
    public class DalDoesNotExistException : DalExceptions
    {
        public DalDoesNotExistException() : base("Dal Does Not Exist") { }
    }
    public class DalAlreadyExistsException : DalExceptions
    {
        public DalAlreadyExistsException() : base("Dal Already Exists") { }
    }

    public class DalInvalidValueException : DalExceptions
    {
        public DalInvalidValueException() : base("Dal Invalid Value") { }
    }
   
}
