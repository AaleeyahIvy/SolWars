public class Attack
{
	public void Attacking()
	{
		//Create Characters/Mobs
		Character c1 = new Character("Lolia", 150);
		Monster m1 = new Monster("Gargantua", 150);

		for( int i = 0; i < 10; i++)
		{
		Console.WriteLine(m1.name + " Has attacked, dealing " + m1.monstAttack() + " damage!");
		Console.WriteLine("You have:"); 
		Console.WriteLine(c1.health -= m1.monstAttack()); 
		Console.WriteLine("HP!");
		Console.WriteLine(c1.name + " attacked, dealing " + c1.charAttack() + " damage!");
		m1.health -= c1.charAttack();
		Console.WriteLine(m1.name + " has " + m1.health + " HP");
			if(m1.health < 0)
			{
				Console.WriteLine(m1.name + " is dead!");
				break;
			}
			if(c1.health < 0)
			{
				Console.WriteLine("You have died!");
				break;
			}
		}
	}
}
