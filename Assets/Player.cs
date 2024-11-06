using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player 
{
    public string playerName;
    public int health;

    static int playerCount = 0;

    public void InitializePlayer(string name, int initialHealth){
        playerName = name;
        health = initialHealth;
        playerCount++;
    }

    public void Heal(int amount){
        health += amount;
        if (health >= 100){
            health = 100;
        }
        Debug.Log("Health = " + health);
    }

    public void Heal(bool fullRestore){
        if (fullRestore == true){
            health = 100;
            Debug.Log("The Health Is Full :) = " + health);
        }
        else Debug.Log("Health = " + health);
        
    }

    public static void ShowPlayerCount(){
        Debug.Log("The Total Number Of Player = " + playerCount);
    }



}
