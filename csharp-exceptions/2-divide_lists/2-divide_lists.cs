using System;

class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> result = new List<int>();
        int div = 0;
        for (int i = 0; i < listLength; i++)
        {
            try
            {
                div = list1[i] / list2[i];
                result.Add(div);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Out of range");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Out of range");
            }
            catch (DivideByZeroException)
            {
                result.Add(0);
            }
        }
        return result;
    }
}
