using System;
public class weapon
{
    public int minDamage;
    
    public int MaxDamage;
    public string name;

    private Random generator = new Random();

    public int Attack()
    {
        return generator.Next(minDamage, MaxDamage);
    }
    

}
