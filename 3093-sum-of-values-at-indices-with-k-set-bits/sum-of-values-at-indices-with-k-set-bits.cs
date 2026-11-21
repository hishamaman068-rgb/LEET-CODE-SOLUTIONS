public class Solution {
    public int SumIndicesWithKSetBits(IList<int> nums, int k) {
        int sum = 0;

        for (int i = 0; i < nums.Count; i++) {
            int count = 0;
            string bi = Convert.ToString(i, 2);

            foreach (char ch in bi) {
                if (int.Parse(ch.ToString()) == 1) {
                    count++;
                }
            }

            if (count == k) {
                sum += nums[i];
            }
        }

        return sum;
    }
}