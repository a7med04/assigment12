using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        Player p1 = new Player();
        Player p2 = new Player();

        p1.InitializePlayer("Ahmed", 40);
        p2.InitializePlayer("Ali", 60);
       

        p1.Heal(30);
        p2.Heal(false);

        Player.ShowPlayerCount();
    }

    
}
