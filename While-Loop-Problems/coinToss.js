function flipCoinUntilWin11() {
    let heads = 0;
    let tails = 0;

    while (heads < 11 && tails < 11) {
        let flip = Math.random() < 0.5 ? "Heads" : "Tails";

        if (flip === "Heads") {
            heads++;
        } else {
            tails++;
        }

        console.log(`Flip: ${flip} | Score -> Heads: ${heads}, Tails: ${tails}`);
    }
    console.log(`🎉 ${heads === 11 ? "Heads" : "Tails"} wins 11 times!`);
}
flipCoinUntilWin11();
