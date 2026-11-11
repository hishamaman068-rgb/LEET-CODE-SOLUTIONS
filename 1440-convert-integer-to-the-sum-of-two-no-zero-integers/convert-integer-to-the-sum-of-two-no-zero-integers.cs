public class Solution {
    public int[] GetNoZeroIntegers(int n) {
          int p1 = 1, p2 = n - 1;

  while (p1.ToString().Contains("0") || p2.ToString().Contains("0"))
  {
      p1++;
      p2--;
  }

  return new int[] { p1, p2 };
    }
}