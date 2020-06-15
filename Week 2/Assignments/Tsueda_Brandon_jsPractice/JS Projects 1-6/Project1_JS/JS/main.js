//Brandon Tsueda
//6/14/2020
//Project and Portfolio 2

//beginning of calulator
alert('This is the grocery calculater');
//user prompts
const apples = prompt('Enter the price of the apples...');
const appleQuantity = prompt('How many apples...');
const steak = prompt('Enter the price of the steaks...');
const steakQuantity = prompt('How many steaks...');
const iceCream = prompt('Enter the price of the ice cream...');
const iceCreamQuantity = prompt('How many containers of ice cream...');
const salesTax = prompt('Enter the sales tax for your area...');

//calulate values
let tax = salesTax * 0.01;

let appleTax = (apples * appleQuantity) * tax;
let steakTax = (steak * steakQuantity) * tax;
let iceCreamTax = (iceCream * iceCreamQuantity) * tax;

let applePrice = (apples * appleQuantity) + appleTax;
let steakPrice = (steak * steakQuantity) + steakTax;
let iceCreamPrice = (iceCream * iceCreamQuantity) + iceCreamTax;

let total = applePrice + steakPrice + iceCreamPrice;

alert('The total for all items is ' + total + '');


