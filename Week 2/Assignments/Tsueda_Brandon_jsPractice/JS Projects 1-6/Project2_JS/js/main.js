
//Alerts the user start of application
alert('Welcome to my MadLibs game');

//user prompts
const animal = prompt('Type in the name of an animal');
const name = prompt('Enter a name.');
const adj = prompt('Enter an adjective.');
const food = prompt('Enter a type of food.');
const year = prompt('Enter a year.');
const price = prompt('Enter a price.');
const num = prompt('Enter a number.');

//arrays to store values for later use
const wordArray = [animal, name, adj, food];
const numberArray = [year, price, num];

alert(
    "There was once a small " + wordArray[0] + " who was very shy.  This " + wordArray[0] + "'s name was " + wordArray[1] + ". Now, " + wordArray[1] + " was very fond of this honey badger that would show off her " + wordArray[2] + " nature to anything coming near her. One day, " + wordArray[1] + " decided to let those feelings be known, despite his being shy. The honey badger was aggressively tearing into " + numberArray[2] + " " + wordArray[3]   +", while " + wordArray[1] + " watched from a safe distance.  " + wordArray[1] + " was thinking to himself those " + wordArray[3]  + "'s look really good. As he pondered between the " + wordArray[3] + " and the honey badger, he had an epifany. He decided that the best way into her heart would be to have more " + wordArray[3]  + "! Now back in " + numberArray[0] + ", this sort of thing was not very common. So, " + wordArray[1] + " went to count his change, he counted " + numberArray[1] + ". Well that isnt going to go very far! So, " + wordArray[1] + ", decided the only thing left to do is to steal the " + wordArray[3]  + ". " + wordArray[1] + " eyed the honey badgers " + wordArray[3]  + ", as the honey badger tried to hide it for later. As " + wordArray[1] + " got in close, he began to feel anxious. He grabbed the " + wordArray[3]  + " and ran as fast as he could. The honey badger cought him and attacked! It took all his strength to get away, beacuse thee honey badger don't give a crap!"

)
