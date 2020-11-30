using System;

public class Character
{
	public string name;
	public int health;
	public static Random rnd = new Random();
	int attack = rnd.Next(1,35);
	
	public Character(string name, int health)
	{
		this.name = name;
		this.health = health;
	}
	
	public int charAttack()
	{
		return attack;
	}
}
