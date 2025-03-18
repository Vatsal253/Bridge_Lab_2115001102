const args = process.argv.slice(2);
const year = parseInt(args[0]);

if (isNaN(year) || year < 1000 || year > 9999) {
    console.log("Invalid input! Please enter a 4-digit year.");
} else {
    if ((year % 4 === 0 && year % 100 !== 0) || (year % 400 === 0)) {
        console.log(`${year} is a Leap Year.`);
    } else {
        console.log(`${year} is not a Leap Year.`);
    }
}
