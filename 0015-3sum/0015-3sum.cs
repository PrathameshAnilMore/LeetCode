public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
    //     Array.Sort(nums);
    // HashSet<IList<int>> result = new HashSet<IList<int>>();
    
    // for (int i = 0; i < nums.Length - 2; i++) {
    //     if (i > 0 && nums[i] == nums[i-1]) {
    //         continue; // skip duplicates
    //     }
    //     int j = i+1, k = nums.Length - 1;
    //     while (j < k) {
    //         int sum = nums[i] + nums[j] + nums[k];
    //         if (sum == 0) {
    //             result.Add(new List<int> {nums[i], nums[j], nums[k]});
    //             j++; k--;
    //         } else if (sum < 0) {
    //             j++;
    //         } else { // sum > 0
    //             k--;
    //         }
    //     }
    // }
    
    // return result.ToList();

//     Input
// nums =
// [-2,0,0,2,2]
// Use Testcase
// Output
// [[-2,0,2],[-2,0,2]]
// Expected
// [[-2,0,2]]

    Array.Sort(nums);  // Sort the array to make it easier to eliminate duplicates
    IList<IList<int>> result = new List<IList<int>>();

    for (int i = 0; i < nums.Length - 2; i++) {
        if (i > 0 && nums[i] == nums[i - 1]) {
            continue;  // Skip duplicate elements
        }

        int j = i + 1;
        int k = nums.Length - 1;

        while (j < k) {
            int sum = nums[i] + nums[j] + nums[k];

            if (sum == 0) {
                result.Add(new List<int>{nums[i], nums[j], nums[k]});
                j++;

                while (j < k && nums[j] == nums[j - 1]) {
                    j++;  // Skip duplicate elements
                }

                k--;
                while (j < k && nums[k] == nums[k + 1]) {
                    k--;  // Skip duplicate elements
                }
            }
            else if (sum < 0) {
                j++;
            }
            else {
                k--;
            }
        }
    }

    return result;
    
    
     }
}