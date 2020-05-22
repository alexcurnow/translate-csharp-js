function main() {
  console.log("Let's roll some dice, baby!")
  console.log("---------------------------")

  const roll = () => {
    function getRandomInt(min, max) {
      min = Math.ceil(min);
      max = Math.floor(max);
      return Math.floor(Math.random() * (max - min + 1)) + min;
    }
    let dieValue = getRandomInt(1, 6)
    return dieValue
  }

  for (let i = 0; i < 10; i++) {
    die1 = roll()
    die2 = roll()

    let message = `${die1} + ${die2} == ${die1 + die2} `

    if (die1 === die2) {
      message += "DOUBLES!"
    }
    console.log(message)
  }

}

main();