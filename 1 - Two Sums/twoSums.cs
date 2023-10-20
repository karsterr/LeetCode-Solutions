public class Solution {
    public int[] TwoSum(int[] num, int target) {
        int []res = new int[2];

        for (int x = 0; x < num.Length; x++){
            for (int y = x + 1; y < num.Length; y++){
                if (num[x] + num[y] == target){
                    res[0] = x;
                    res[1] = y;
                    return res;
                }
            }
        }
        return res;
    }
}