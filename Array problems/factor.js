function getPrimeFactors(n) {
    let factors = [];
    while (n % 2 === 0) {
        factors.push(2);
        n = Math.floor(n / 2);
    }
    for (let i = 3; i * i <= n; i += 2) {
        while (n % i === 0) {
            factors.push(i);
            n = Math.floor(n / i);
        }
    }
    if (n > 2) {
        factors.push(n);
    }

    return factors;
}
const number = parseInt(process.argv[2]);

if (!isNaN(number) && number > 1) {
    const primeFactors = getPrimeFactors(number);
    console.log(` Prime Factors of ${number}: ${primeFactors.join(", ")}`);
} else {
    console.log(" Please provide a valid number greater than 1.");
}
