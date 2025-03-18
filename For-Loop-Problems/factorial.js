let args = process.argv.slice(2);

if (args.length < 1) {
    console.log("Usage: node script.js <number>");
    process.exit(1);
}

let num = parseInt(args[0]);
if (isNaN(num) || num < 0) {
    console.log("Invalid input! Please enter a non-negative integer.");
    process.exit(1);
}
function factorial(n) {
    if (n === 0 || n === 1) return 1; 
    let fact = 1;
    for (let i = 2; i <= n; i++) {
        fact *= i;
    }
    return fact;
}
console.log(`${num}! = ${factorial(num)}`);
