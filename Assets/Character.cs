using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    private string name;
    private int health;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Health
    {
        get { return health; }
        set
        {
            health = value > 100 ? 100 : value < 0 ? 0 : value;
        }
    }

    public Character(string name, int health)
    {
        this.Name = name;
        this.Health = health;
    }
}

