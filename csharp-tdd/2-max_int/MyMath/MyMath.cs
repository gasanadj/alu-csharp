namespace MyMath;

    ///<summary>
    /// public class which has all the operations
    ///</summary>
public class Operations
{
    ///<summary>
    /// Method which returns the max number in a list of integers
    ///</summary>
    public static int Max(List<int> nums) {
        if (nums.Count == 0) {
            return 0;
        }
        int max = nums[0];
        for (int i = 0; i< nums.Count; i++) {
            if (nums[i] > max) {
                max = nums[i];
            }
        }
        return max;
    }

}


