let args = process.argv.slice(2); 
if (args.length < 1) {
    console.log("Usage: node script.js <number>");
    process.exit(1);
}
let n = parseInt(args[0]);
if (isNaN(n) || n < 0) {
    console.log("Invalid input! Please enter a non-negative integer.");
    process.exit(1);
}
console.log(`Powers of 2 up to 2^${n} or 256:`);
let power = 0;
let result = 1; 
while (power <= n && result <= 256) {
    console.log(`2^${power} = ${result}`);
    result *= 2;
    power++; 
}
