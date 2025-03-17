let inches = 42;
let feet = inches / 12;
console.log(`42 inches is equal to ${feet} feet.`);
let lengthFeet = 60;
let widthFeet = 40;
let feetToMeters = 0.3048; 
let lengthMeters = lengthFeet * feetToMeters;
let widthMeters = widthFeet * feetToMeters;

console.log(`Rectangular plot of 60ft x 40ft is ${lengthMeters.toFixed(2)}m x ${widthMeters.toFixed(2)}m.`);
let areaSinglePlotFeet = lengthFeet * widthFeet; 
let totalAreaFeet = areaSinglePlotFeet * 25; 
let feetToAcre = 43560; 
let totalAreaAcres = totalAreaFeet / feetToAcre;
console.log(totalAreaAcres.toFixed(2));
