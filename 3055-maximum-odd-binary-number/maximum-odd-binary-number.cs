public class Solution {
    public string MaximumOddBinaryNumber(string s) => string.Concat(
        new string(Enumerable.Repeat('1', s.Count(m => m == '1') - 1).ToArray()),
        new string(Enumerable.Repeat('0', s.Count(m => m == '0')).ToArray()),
        "1"
    );
}