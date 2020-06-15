//Brandon Tsueda
//6/14/2020
//Project and Portfolio 2

alert('Coffee Run');

let drinks = ['coffee', 'cappuccino', 'latte', 'decaf', 'decaf', 'cappuccino', 'cappuccino', 'coffee', 'decaf'];

 //Declare variables for each drink
let coffee = 0;
let cappuccino = 0;
let latte = 0;
let decaf = 0;

//Create loop to cycle through each drink and add them up
for (var i = 0; i < drinks.length; i++)
    {
        if (drinks[i] === 'coffee')
        {
            coffee++;
         }
        else if (drinks[i] === 'cappuccino')
         {
            cappuccino++;
        }
         else if (drinks[i] === 'latte')
         {
              latte++;
          } 
         else if (drinks[i] === 'decaf')
        {
              decaf++;
          }
    }

//Output results
alert('Order ' + coffee + ' number of coffee, ' + 
cappuccino + ' number of cappuccino, ' +
 latte + ' number of the latte ' + 
 decaf + ' number of decaf.');