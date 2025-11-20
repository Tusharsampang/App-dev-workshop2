public class ParameterDemo
{
    public void Increase(ref int number)
    {
        number = number + 10;
    }

    public void GetFullName(out string fullname)
    {
        fullname = "Tushar Sampang"; // Your full name
    }

    public int SumAll(params int[] numbers)
    {
        int sum = 0;

        foreach (int n in numbers)
        {
            sum += n;
        }

        return sum;
    }
}
