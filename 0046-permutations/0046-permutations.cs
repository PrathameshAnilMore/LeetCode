public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
    
        IList<IList<int>> result = new List<IList<int>>();
        GeneratePermutations(nums, 0, result);
        return result;
    }
    
    private void GeneratePermutations(int[] nums, int index, IList<IList<int>> result) {
        if (index == nums.Length) {
            result.Add(new List<int>(nums));
            return;
        }
        
        for (int i = index; i < nums.Length; i++) {
            Swap(nums, index, i);
            GeneratePermutations(nums, index + 1, result);
            Swap(nums, index, i);
        }
    }
    
    private void Swap(int[] nums, int i, int j) {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
        }
    }
    
