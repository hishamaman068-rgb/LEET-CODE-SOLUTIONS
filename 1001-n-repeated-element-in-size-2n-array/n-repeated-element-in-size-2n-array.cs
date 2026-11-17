public class Solution {
    public int RepeatedNTimes(int[] nums) {
        HashSet<int> set = new();

        foreach(int x in nums){
            if(set.Contains(x)){
                return x;
            }
            else{
                set.Add(x);
            }
        }
        return 0;
    }
}