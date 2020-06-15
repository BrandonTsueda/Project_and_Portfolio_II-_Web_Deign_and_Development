//Brandon Tsueda
//6/14/2020
//Project and Portfolio 2

//beginning of first problem
alert('Grading Scale');

//user prompts and validation
let gradeOne = Number(prompt('What is the value of your first grade?'));
gradeOneValidated = ValidateNumber(gradeOne);

let gradeTwo = Number(prompt('What is the value of your second grade?'));
gradeTwoValidated = ValidateNumber(gradeTwo);

//array
let grades = [gradeOneValidated, gradeTwoValidated];

//conditional
if (grades[0] >= 70 && grades[1] >= 70)
{
    alert('Both grades are passing!');
}
else{
    alert('One or more grades are failing...');
}


//beginning of second problem
alert('Brunch Bunch');

//user prompts and validation
let age = Number(prompt('What is your age?'));
ageValidated = ValidateNumber(age);

//conditionals
if (ageValidated >= 55 || ageValidated <= 10)
{
    alert("Your cost for brunch today is $10.00");
}
else
{
    alert("Your cost for brunch today is $15.00");
}


//beginning of third problem
alert('Add Them Up');

//user prompt and validation
let dvdTotal = Number(prompt('How many dvd\'s do you have?'))
dvdTotalValidated = ValidateNumber(dvdTotal);

//user prompt and validation
let blueRayTotal = Number(prompt('How many blueray\'s do you have?'));
blueRayTotalValidated = ValidateNumber(blueRayTotal);

//user prompt and validation
let ultraVioletTotal = Number(prompt('How many ultra violet\'s do you have?'));
ultraVioletTotalValidated = ValidateNumber(ultraVioletTotal);

//array for movies
let dvdCollection = [dvdTotal, blueRayTotal, ultraVioletTotal];

//add up each value
let totalDvds = dvdCollection[0] + dvdCollection[1] + dvdCollection[2];

//conditional
if(totalDvds >= 100)
            {
                alert('Wow, I am impressed with your collection of ' + totalDvds + ' movies!');
            }
            else if(totalDvds < 100)
            {
                alert('You have a total of ' + totalDvds + ' movies in your collection.');
            }



alert('Cha-Ching');
let giftCardBalance = prompt('How much is on your gift card?');
giftCardBalanceValidated = ValidateNumber(giftCardBalance);

let purchaseNumber = 1;

while(giftCardBalance > 0){
    var purchaseAmount = prompt('Please enter purchase ' + purchaseNumber + ' amount.')
    purchaseNumber++;

    let balanceRemaining = giftCardBalance - purchaseAmount;

if (balanceRemaining > 0)
{
    alert("With your current purchase of  $" + purchaseAmount + ", you can still spend $" + balanceRemaining + ".");
}
else
{
    alert("With your last purchase of $" + purchaseAmount + ",	you have used your gift card up and still owe $" + balanceRemaining + ".");
}

};



//function for validation
function ValidateNumber(number){
    while(isNaN(number || number == '')){
        number = prompt('Please type in a valid number...');
    }
    return number;
}