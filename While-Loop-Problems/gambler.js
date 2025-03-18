function gamblerGame() {
    let money = 100; 
    let goal = 200;  
    let bets = 0;     
    let wins = 0;     

    while (money > 0 && money < goal) {
        bets++;
        let betResult = Math.random() < 0.5; 

        if (betResult) {
            money++; 
            wins++;
        } else {
            money--; 
        }
        console.log(`Bet ${bets}: ${betResult ? "Win" : "Lose"} | Money: Rs.${money}`);
    }
    console.log(`Total Bets: ${bets}, Wins: ${wins}`);
    console.log(money === 200 ? "🎉 Reached the goal of Rs. 200!" : "💸 Went broke!");
}
gamblerGame();
