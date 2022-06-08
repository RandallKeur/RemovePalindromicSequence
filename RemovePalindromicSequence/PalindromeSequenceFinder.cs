namespace RemovePalindromicSequence;

public class PalindromeSequenceFinder
{
    public int RemovePalindromeSequence(string inputString, int minSteps)
    {
        var lastIndex = inputString.Length - 1;
        var i = 0;
        List<char> stringList = new List<char>();
        if (inputString.Length == 0)
        {
            return minSteps;
        }
        else
        {
            minSteps++;
            while (lastIndex > i)
            {
                if (inputString[i] == inputString[lastIndex])
                {
                    i++;
                    lastIndex--;
                }
                else
                {
                    stringList.Add(inputString[lastIndex]);
                    lastIndex--;
                }
            }
            stringList.Reverse();
            var stringLeftover = new string(stringList.ToArray());
            return RemovePalindromeSequence(stringLeftover, minSteps);
        }
    }
}