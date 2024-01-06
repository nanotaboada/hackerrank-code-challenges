/**
*   Return the second largest number in the array.
*   @param {Number[]} nums - An array of numbers.
*   @return {Number} The second largest number in the array.
**/
function getSecondLargest(nums) {
    // Complete the function
    let largest = nums[0];
    let secondLargest = -Infinity;
    
    for (let i = 1; i < nums.length; i++) {
        
        if (nums[i] > largest) {
            secondLargest = largest;
            largest = nums[i];
        } else if (nums[i] < largest && nums[i] > secondLargest) {
            secondLargest = nums[i];
        }
    }

    return secondLargest;
}
