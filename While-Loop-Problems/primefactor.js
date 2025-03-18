let args = process.argv.slice(2); 
if (args.length < 1) {
    console.log("Usage: node script.js <number>");
    process.exit(1);
}
let num = parseInt(args[0]);
if (isNaN(num) || num <= 1) {
    console.log("Invalid input! Please enter an integer greater than 1.");
    process.exit(1);
}
function primeFactors(n) {
    let factors = [];
    for (; n % 2 === 0; n /= 2) {
        factors.push(2);
    }
    for (let i = 3; i * i <= n; i += 2) {
        while (n % i === 0) {
            factors.push(i);
            n /= i;
        }
    }
    if (n > 2) {
        factors.push(n);
    }

    return factors;
}
console.log(`Prime factors of ${num}: ${primeFactors(num).join(", ")}`);
