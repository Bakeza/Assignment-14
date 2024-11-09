using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{
    public Enemy(string name, int health) : base(name, health) { }

    public void Attack(Character target, int damage)
    {
        target.Health -= damage;
        if (target.Health < 0) target.Health = 0;
    }
}

