//First problem 
alert('You won the lottery!');

//user prompts
let cashValue = prompt('How much did you win?(do not add any \',\'s)');
alert('Would you like to recieve the money in one lump some or in annual payments?');
let userCashChoice = prompt('Please type l for the lump some, or a for the annual payments...');

//conditionals
if (userCashChoice === 'l' || userChoice === 'L'){
    let lumpSome = cashValue * .85;
    alert('Your winnings of $' + lumpSome + ' will be paid out in a one time payment.');
}

else if (userCashChoice === 'a' || userChoice === 'A'){
    let annualPayments = cashValue * 20;
    alert('You will recieve annual payment of $' + annualPayments + ' each year.');
}

else{
    userCashChoice = prompt('Please type either l or a...');
}

//---------------------------------------
//begining of next proble
alert('Let\'s Make a Deal!');

//user prompts
let itemQuantity = prompt('How many items are in the bulk pack?');
let bulkItemPrice = prompt('How much does the bulk pack cost?');
let itemPrice = prompt('How does a single item cost?');
let coupon = prompt('How much does the coupon take off?');

//calulate values
let singleDiscount = itemPrice - coupon;
let bulkSingles = bulkItemPrice / itemQuantity;

//conditional
if (bulkSingles < singleDiscount){
    alert('The cost of 1 item in the bulk pack is $' + bulkSingles + ', which is cheaper than the cost of the individual item with coupon, which is $' + singleDiscount + '. Buy the bulk pack!')
}

else{
    alert('The cost of 1 item using a coupon is $' + singleDiscount + ', which is cheaper than the cost of the individual item from the bulk pack, which is $' + bulkSingles + '. Buy the individual item and use the coupon!');
}

//---------------------------------------
//beginning of next problem
alert('Pumpkin Patch Pickers');

//userprompt
let pumpkinWeight = prompt('How much does your pumpkin weigh?');

//conditionals
if (pumpkinWeight <= 5.5)
{
    let weightOne = pumpkinWeight * 1.00;
    alert('Your	pumpkin	of ' + pumpkinWeight + 'lbs. costs	$' + weightOne + '.');
}
else if (pumpkinWeight <= 10.75)
{
    let weightTwo = pumpkinWeight * 0.90;
    alert('Your	pumpkin	of ' + pumpkinWeight + 'lbs. costs	$' + weightTwo + '.');
}
else if (pumpkinWeight <= 25)
{
    let weightThree = pumpkinWeight * .80;
    alert('Your	pumpkin	of	' + pumpkinWeight + ' lbs. costs $' + weightThree + '.');
}
else if (pumpkinWeight <= 50)
{
    let weightFour = (pumpkinWeight * .70);
    alert('Your	pumpkin	of	' + pumpkinWeight + ' lbs. costs $' + weightFour + '.');
}
else if (pumpkinWeight <= 100)
{
    let weightFive = (pumpkinWeight * .60);
    alert('Your	pumpkin	of ' + pumpkinWeight + ' lbs. costs $' + weightFive + '.');
}
else if (pumpkinWeight > 100)
{
    let weightSix = (pumpkinWeight * .50);
    alert('Your	pumpkin	of ' + pumpkinWeight + ' lbs. costs $' + weightSix + '.');
}

//---------------------------------------
//beginning of last problem
alert('Loyalty Card')

//user prompts and validation
let firstItemPrice = Number(prompt('What is the cost of the first item?'));
firstItemValidated = ValidateDecimal(firstItemPrice);

let secondItemPrice = Number(prompt('What is the cost of the second item?'));
secondItemValidated = ValidateDecimal(secondItemPrice);

//calculate values
let itemTotal = secondItemValidated + firstItemValidated;

//user prompt
let loyaltyMember = prompt('Are you a loyalty member? Type yes or no...');

//conditional
if(loyaltyMember === 'yes' || loyaltyMember === 'YES'){
    let discount = itemTotal - (itemTotal * .15);
    alert('Your total purchase is $' + discount + ', which includes your 15% discount!')
}

else{
    alert('Your total cost is $' + itemTotal + '.');
}

//validation function
function ValidateDecimal(number){
    while(isNaN(number || number == '')){
        number = prompt('Please type in a valid number...');
    }

    return number;
}