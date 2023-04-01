/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number[]}
 */
var twoSum = function(nums, target) {
    //function findIndicesSumGiven(array,targetValue){
    const hashTable ={};
    let neededValue;
    for(let i=0;i<nums.length;i++){
        neededValue = target - nums[i];
        if(neededValue in hashTable){
            return [i,hashTable[neededValue]];
        }else{
            hashTable[nums[i]]=i;
        }
    }
    return[];
//}
    
};