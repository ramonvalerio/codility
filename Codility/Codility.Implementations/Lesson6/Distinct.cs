using System.Linq;

namespace Codility.Implementations.Lesson6
{
    public class Distinct
    {
        public int solution(int[] A)
        {
            return A.Distinct().Count();
        }
    }
}