using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        Player player1 = new Player();
        Player player2 = new Player();

        player1.InitializePlayer("Alice", 50);
        player2.InitializePlayer("Bob", 75);

        player1.Heal(20);
        player2.Heal(true);

        Player.ShowPlayerCount();
    }


}
