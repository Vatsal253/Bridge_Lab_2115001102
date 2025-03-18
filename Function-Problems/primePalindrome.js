function isPrime(num) {
    if (num < 2) return false;
    for (let i = 2; i <= Math.sqrt(num); i++) {
        if (num % i === 0) return false;
    }
    return true;
}
function getPalindrome(num) {
    return parseInt(num.toString().split('').reverse().join(''));
}
function checkPrimeAndPalindrome(num) {
    if (!isPrime(num)) {
        console.log(` ${num} is NOT a Prime Number.`);
        return;
    }
    
    console.log(` ${num} is a Prime Number.`);
    let palindromeNum = getPalindrome(num);
    
    console.log(` Its Palindrome is ${palindromeNum}`);
    
    if (isPrime(palindromeNum)) {
        console.log(` ${palindromeNum} (Palindrome) is ALSO a Prime Number!`);
    } else {
        console.log(` ${palindromeNum} (Palindrome) is NOT a Prime Number.`);
    }
}
const Input = parseInt(process.argv[2]);

if (!isNaN(Input)) {
    checkPrimeAndPalindrome(Input);
} else {
    console.log(" Please provide a valid number as input.");
}
