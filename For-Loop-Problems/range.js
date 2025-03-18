let args = process.argv.slice(2);
if (args.length < 2) {
    console.log("Usage: node script.js <start> <end>");
    process.exit(1);
}
let start = parseInt(args[0]);
let end = parseInt(args[1]);
if (isNaN(start) || isNaN(end) || start < 2 || end < 2 || start > end) {
    console.log("Invalid input! Please enter two integers (start ≤ end) and both ≥ 2.");
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
console.log(`Prime numbers between ${start} and ${end}:`);
for (let num = start; num <= end; num++) {
    if (isPrime(num)) {
        process.stdout.write(num + " "); 
    }
}
console.log();
