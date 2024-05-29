
namespace PageProject
{
    public class EnumHelper
    {
        public static IEnumerable<T> EnumToList<T>()
        {
            if (typeof(T).IsSubclassOf(typeof(Enum)) == false)
                throw new ArgumentException();

            return Enum.GetValues(typeof(T)).Cast<T>().ToList();
        }
    }
}
