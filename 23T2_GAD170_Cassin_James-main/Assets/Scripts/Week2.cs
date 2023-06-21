using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//James Cassin
public class Week2 : MonoBehaviour
{
    [SerializeField] private string FavourtieGame = "Minecraft";
    [SerializeField] private int HoursPlayed = 500;
    [SerializeField] private float Cost = 29.99f;
     
    private void Start()
    {
        Debug.Log("My Favourite game is " + FavourtieGame + ". I have played it for " + HoursPlayed + " hours, and it cost me " + Cost + " Therefore my value of dollars per hour is " + HoursPlayed / Cost);
    }
}
