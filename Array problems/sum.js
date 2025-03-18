function findTriplets(arr) {
    let n = arr.length;
    let triplets = [];
    arr.sort((a, b) => a - b);
    for (let i = 0; i < n - 2; i++) {
        if (i > 0 && arr[i] === arr[i - 1]) continue;

        let left = i + 1, right = n - 1;

        while (left < right) {
            let sum = arr[i] + arr[left] + arr[right];

            if (sum === 0) {
                triplets.push([arr[i], arr[left], arr[right]]);
                left++;
                right--;
                while (left < right && arr[left] === arr[left - 1]) left++;
                while (left < right && arr[right] === arr[right + 1]) right--;
            } else if (sum < 0) {
                left++; 
            } else {
                right--; 
            }
        }
    }

    return triplets;
}
const inputNumbers = process.argv.slice(2).map(Number);

if (inputNumbers.length < 3) {
    console.log(" Please provide at least 3 integers.");
} else {
    let result = findTriplets(inputNumbers);
    if (result.length > 0) {
        console.log(" Triplets that sum to zero:", result);
    } else {
        console.log(" No triplets found that sum to zero.");
    }
}
