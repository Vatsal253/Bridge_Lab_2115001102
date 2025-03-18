let args = process.argv.slice(2); 
let a = parseFloat(args[0]);
let b = parseFloat(args[1]);
let c = parseFloat(args[2]);
if (isNaN(a) || isNaN(b) || isNaN(c)) {
    console.log("Invalid input! Please enter three valid numbers.");
    process.exit(1); 
}
let result1 = a + b * c;
let result2 = a % b + c;
let result3 = c + a / b;
let result4 = a * b + c;
let results = [result1, result2, result3, result4];
let maxResult = Math.max(...results);
let minResult = Math.min(...results);
console.log(`1. a + b * c = ${result1}`);
console.log(`2. a % b + c = ${result2}`);
console.log(`3. c + a / b = ${result3}`);
console.log(`4. a * b + c = ${result4}`);
console.log(`Maximum value: ${maxResult}`);
console.log(`Minimum value: ${minResult}`);
