let args = process.argv.slice(2);
if (args.length < 2) {
    console.log("Usage: node script.js <choice> <value>");
    console.log("Choices:");
    console.log("1. Feet to Inch");
    console.log("2. Feet to Meter");
    console.log("3. Inch to Feet");
    console.log("4. Meter to Feet");
    process.exit(1);
}
let choice = parseInt(args[0]);
let value = parseFloat(args[1]);
if (isNaN(choice) || isNaN(value)) {
    console.log("Invalid input! Please enter a valid choice (1-4) and a numeric value.");
    process.exit(1);
}
switch (choice) {
    case 1:
        console.log(`${value} Feet = ${value * 12} Inches`);
        break;
        
    case 2:
        console.log(`${value} Feet = ${(value * 0.3048).toFixed(2)} Meters`);
        break;
        
    case 3:
        console.log(`${value} Inches = ${(value / 12).toFixed(2)} Feet`);
        break;
        
    case 4:
        console.log(`${value} Meters = ${(value * 3.28084).toFixed(2)} Feet`);
        break;
        
    default:
        console.log("Invalid choice! Please enter a number between 1 and 4.");
}
