function generateRandomNumbers() {
    let numbers = [];
    for (let i = 0; i < 10; i++) {
        numbers.push(Math.floor(Math.random() * (999 - 100 + 1)) + 100); 
    }
    return numbers;
}
function findSecondLargestAndSmallestSorted(arr) {
    arr.sort((a, b) => a - b);

    console.log(` Sorted Numbers: ${arr.join(", ")}`);
    console.log(` 2nd Smallest: ${arr[1]}`);
    console.log(` 2nd Largest: ${arr[arr.length - 2]}`);
}
let randomNumbers = generateRandomNumbers();
console.log(` Random Numbers: ${randomNumbers.join(", ")}`);
findSecondLargestAndSmallestSorted(randomNumbers);
