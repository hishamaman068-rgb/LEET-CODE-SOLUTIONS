public class Solution {
    public int MostFrequentEven(int[] nums) {
        int c=0;
        for(int i=0;i<nums.Length;i++){
            if(nums[i]%2==1){
                nums[i]=-1;
                c++;
            }
        }
        if(c==nums.Length){
            return -1;
        }
        Array.Sort(nums);
        c= 0;
        int temp= 0;
        int k= 0;
        int prev=0;
        while(nums.Max()>-1){
            temp= 0;
            k=nums.Max();
            for(int i=0;i<nums.Length;i++){
                if(k==nums[i]){
                    temp++;
                    nums[i]=-1;
                }
            }
            if(temp>=c){
                prev =k;
                c=temp;
            }
        }
        return prev;
    }
}