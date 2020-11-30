public class Monster
{
	public string name;
	public int health;
	public static Random rnd = new Random();
	int attack = rnd.Next(1,25);
	
	public Monster(string name, int health)
	{
		this.name = name;
		this.health = health;
	}
	
	public int monstAttack()
	{
		return attack;
	}
}
