using System.Collections.Generic;
using System.Linq;

char firstNotRepeatingCharacter(string s)
{
    Dictionary<char, int> dup = new Dictionary<char, int>();

    foreach (char c in s.ToCharArray())
    {
        if (dup.Keys.Contains(c))
        {
            dup[c] += 1;
        }
        else
            dup.Add(c, 1);

    }
    if (dup.Values.Contains(1))
        return dup.First(b => b.Value == 1).Key;
    else
        return '_';

}
