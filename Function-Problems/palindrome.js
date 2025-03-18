function isPalindrome(num) {
    let originalNum = num.toString();
    let reversedNum = originalNum.split('').reverse().join('');
    return originalNum === reversedNum;
}
function checkTwoPalindromes(num1, num2) {
    let result1 = isPalindrome(num1) ? " Palindrome" : " Not a Palindrome";
    let result2 = isPalindrome(num2) ? " Palindrome" : " Not a Palindrome";

    console.log(`🔹 ${num1} -> ${result1}`);
    console.log(`🔹 ${num2} -> ${result2}`);
}
checkTwoPalindromes(121, 12321); 
checkTwoPalindromes(456, 789);   
