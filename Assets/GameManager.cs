using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        // Creating Player and Enemy objects
        Player player = new Player("Subhi", 80);
        Enemy enemy = new Enemy("Zarifeh", 100);

        // Print initial Name and Health
        Debug.Log($"Player: {player.Name}, Health: {player.Health}");
        Debug.Log($"Enemy: {enemy.Name}, Health: {enemy.Health}");

        // Test the Heal method
        player.Heal(15);
        Debug.Log($"Player after healing: {player.Name}, Health: {player.Health}");

        // Test the Attack method
        enemy.Attack(player, 20);
        Debug.Log($"Player after attack: {player.Name}, Health: {player.Health}");
    }
}
