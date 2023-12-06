using System;
using System.Collections.Generic;
using System.Text;

namespace EX5
{
    static class Utils
    {
        public const int MAX_STUDENTS = 15;
        public const int MAX_COURSES = 5;

        public static bool checkidNumber(string id)
        {
            if (id == null)
            {
                throw new ArgumentNullException();
            }
            if (id == "")
            {
                throw new ArgumentException("Error: Empty Id!!");
            }
            if (id[0] != '0')
            {
                throw new ArgumentException("The id doesnt start with a leading zero!");
            }

            foreach (char c in id)
            {
                if (c < '0' || c > '9')
                    throw new ArgumentException("Error: Enter numbers only!!");
            }
            try
            {
                int x = int.Parse(id);
                return true;
            }
            catch
            {
                throw new ArgumentException("Please enter numbers only!");
            }
        }

    }

}

