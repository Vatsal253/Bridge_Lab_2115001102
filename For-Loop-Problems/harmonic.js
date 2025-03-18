let args = process.argv.slice(2); 
if (args.length < 1) {
    console.log("Usage: node script.js <n>");
    process.exit(1);
}
let n = parseInt(args[0]);
if (isNaN(n) || n <= 0) {
    console.log("Invalid input! Please enter a positive integer.");
    process.exit(1);
}
let harmonicNumber = 0;
for (let i = 1; i <= n; i++) {
    harmonicNumber += 1 / i;
}
console.log(`The ${n}th Harmonic Number is: ${harmonicNumber.toFixed(6)}`);
