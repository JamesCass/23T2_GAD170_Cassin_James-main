using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PowerLevel : MonoBehaviour
{
    [SerializeField] private int Player1Strength = 30;
    [SerializeField] private int Player1Agility = 25;
    [SerializeField] private int Player1Intelligence = 10;

    [SerializeField] private int Player2Strenght = 10;
    [SerializeField] private int Player2Agility = 35;
    [SerializeField] private int Player2Intelligence = 30;
    private void Start()
    {
        PowerTotal();
        PowerCompare();
    }
    //-------------------------------------------------- Auto Fix?
    private void PowerCompare()
    {
        throw new NotImplementedException();
    }
    //--------------------------------------------------
    private void PowerTotal()
    {
        int Player1Power = (int)(Player1Strength * 2 + Player1Agility * 1.5 + Player1Intelligence);

        int Player2Power = (int)(Player2Strenght * 2 + Player2Agility * 1.5 + Player2Intelligence);
    }


    public void PowerCompare(int Player1Power, int Player2Power)
    {
        float percentDifference = Mathf.Abs(Player1Power - Player2Power) / (float)Player1Power * 100f;
        if (Player1Power > Player2Power)
            Debug.Log("Player 1 is stronger!");
            Debug.Log("Player 1's power level is: " + Player1Power);
            Debug.Log("Player 2's power level is: " + Player2Power);
            Debug.Log("Player 1 wins by " + percentDifference + "%");
    


        if (Player1Power < Player2Power)
            Debug.Log("Player 2 is stronger!");
            Debug.Log("Player 1's power level is: " + Player1Power);
            Debug.Log("Player 2's power level is: " + Player2Power);
            Debug.Log("Player 2 wins by " + percentDifference + "%");


        
    }


}
