const args = process.argv.slice(2);
const month = parseInt(args[0]);
const day = parseInt(args[1]);   
if (isNaN(month) || isNaN(day) || month < 1 || month > 12 || day < 1 || day > 31) {
    console.log("Invalid input! Please enter a valid month (1-12) and day (1-31).");
} else {
    const True =
        (month === 3 && day >= 20) || 
        (month > 3 && month < 6) ||   
        (month === 6 && day <= 20);   

    console.log(True); 
}
