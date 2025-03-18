function generateRandomNumbers() {
    let numbers = [];
    for (let i = 0; i < 10; i++) {
        numbers.push(Math.floor(Math.random() * (999 - 100 + 1)) + 100); 
    }
    return numbers;
}
function findSecondLargestAndSmallest(arr) {
    let firstMax = -Infinity, secondMax = -Infinity;
    let firstMin = Infinity, secondMin = Infinity;
    for (let num of arr) {
        if (num > firstMax) {
            secondMax = firstMax;
            firstMax = num;
        } else if (num > secondMax && num !== firstMax) {
            secondMax = num;
        }
        if (num < firstMin) {
            secondMin = firstMin;
            firstMin = num;
        } else if (num < secondMin && num !== firstMin) {
            secondMin = num;
        }
    }
    console.log(` Random Numbers: ${arr.join(", ")}`);
    console.log(` 2nd Smallest: ${secondMin}`);
    console.log(` 2nd Largest: ${secondMax}`);
}
let randomNumbers = generateRandomNumbers();
findSecondLargestAndSmallest(randomNumbers);
