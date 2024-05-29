using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageProject
{
    class EnumHelper
    {
        public static IEnumerable<T> EnumToList<T>()

        {

            if (typeof(T).IsSubclassOf(typeof(Enum)) == false)

                throw new ArgumentException();

            return Enum.GetValues(typeof(T)).Cast<T>().ToList();



        }
    }
}
