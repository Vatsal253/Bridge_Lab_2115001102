let args = process.argv.slice(2); 
if (args.length < 1) {
    console.log("Usage: node script.js <number>");
    process.exit(1);
}
let num = parseInt(args[0]);
if (isNaN(num) || num < 2) {
    console.log("Invalid input! Please enter an integer greater than or equal to 2.");
    process.exit(1);
}
function isPrime(n) {
    if (n === 2) return true; 
    if (n % 2 === 0) return false; 
    for (let i = 3; i <= Math.sqrt(n); i += 2) {
        if (n % i === 0) return false;
    }
    return true;
}
if (isPrime(num)) {
    console.log(`${num} is a Prime Number.`);
} else {
    console.log(`${num} is NOT a Prime Number.`);
}
