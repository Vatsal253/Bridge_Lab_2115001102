function getRandomMonth() {
    return Math.floor(Math.random() * 12) + 1;
}
function generateBirthdays() {
    let birthdayData = {};
    for (let i = 1; i <= 12; i++) {
        birthdayData[i] = [];
    }
    for (let i = 1; i <= 50; i++) {
        let month = getRandomMonth();
        birthdayData[month].push(`Person ${i}`);
    }

    return birthdayData;
}
let birthdayGroups = generateBirthdays();
console.log(" Birthdays grouped by month:");
for (let month in birthdayGroups) {
    if (birthdayGroups[month].length > 0) {
        console.log(` Month ${month}:`, birthdayGroups[month]);
    }
}
