/*   
    In the COMMENTS section of this assignment, explain how each OOP principle was used. Try to use at least Inheritance, and Polymorphism. Encapsulation is a bonus! (try using and underscore (_) in front of var name to designate it as a private variable - SEE GRAPHIC BELOW!)*/

    //Create a parent class (you choose! animals, birds, cars, etc)
class Games{
    //Add at least one property to the parent class and constructor
    constructor(genre, rating){
        this.genre = genre;
        this.rating = rating;
    }
    //Add one method to the parent class
    //Run/Call a method (function) from your parent class (super class)
    gameInfo(){
        console.log(`The game is a part of the ${this.genre} genre, and is rated ${this.rating}`);
    }

}

    //Create at least one class extended (child class) from the parent class
    class DoomEternal extends Games{
    constructor(){
        super("Science-Fiction FPS", "MA")  
    }
}

    //Instantiate at least one object from the parent class (super class)
    let newGame = new Games("genre place holdler", "rating place holder");
    newGame.gameInfo();

    //Instantiate at least one object from the child class
    let newDoomEternal = new DoomEternal();
    newDoomEternal.gameInfo();

