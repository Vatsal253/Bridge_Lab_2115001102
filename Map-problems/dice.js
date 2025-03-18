function rollDie() {
    return Math.floor(Math.random() * 6) + 1;
}
function simulateDiceRolls() {
    let diceCount = { 1: 0, 2: 0, 3: 0, 4: 0, 5: 0, 6: 0 };
    let maxRoll = 10; 
    let rollHistory = [];

    while (true) {
        let roll = rollDie();
        rollHistory.push(roll);
        diceCount[roll]++;
        if (diceCount[roll] === maxRoll) break;
    }
    console.log("🎲 Dice Roll Results:", diceCount);
    let maxNum = Object.keys(diceCount).reduce((a, b) => diceCount[a] > diceCount[b] ? a : b);
    let minNum = Object.keys(diceCount).reduce((a, b) => diceCount[a] < diceCount[b] ? a : b);

    console.log(` Number that appeared maximum times: ${maxNum} (${diceCount[maxNum]} times)`);
    console.log(` Number that appeared minimum times: ${minNum} (${diceCount[minNum]} times)`);
}
simulateDiceRolls();
