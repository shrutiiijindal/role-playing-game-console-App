// See https://aka.ms/new-console-template for more information
/**In some role playing games, the player's character battles non-player characters, which are usually monsters or the "bad guys".
 Sometimes, a battle consists of each character generating a random value using dice and that value is subtracted 
 from the opponent's health score. Once either character's health reaches zero, they lose the game.

In this challenge, we boil down that interaction to its essence. 
A hero and a monster start with the same health score.
 During the hero's turn, they generate a random value that is subtracted from the monster's health.
  If the monster's health is greater than zero, they take their turn and attack the hero. 
  As long as both the hero and the monster have health greater than zero, the battle resumes.
**/
int hero=10;
int monster= 10;
Random dice = new Random();
do{
    int roll = dice.Next(1,11);
    monster-=roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");
    
    if(monster>=0) continue;
    
    roll=dice.Next(1,11);
    hero-=roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

    
}while(hero>0 && monster>0);
Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");
