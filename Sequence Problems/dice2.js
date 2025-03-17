function rollDice() {
    return Math.floor(Math.random() * 6) + 1;
}
let dice1 = rollDice();
let dice2 = rollDice();
let sum = dice1 + dice2;
console.log(sum);
