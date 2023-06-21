using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class Week1 : MonoBehaviour
{
    [SerializeField] private string Name = "James";
    [SerializeField] private int Age = 21;
    [SerializeField] private int DOB = 30-05-2002;
    [SerializeField] private float Height = 1.86f;
    [SerializeField] private bool WearingWatch = false;
    [SerializeField] private int FavouriteNumber = 99;

    // DOB prints 0 
    private void Start()
    {
        Debug.Log("Hi, my name is " + Name + ". My age in years is " + Age + ", which means my DOB is " + DOB + ". I am " + Height + " tall and the rumors you have heard are " + WearingWatch + ". I am NOT wearing a watch. Finally my favourite number is " + FavouriteNumber + " which if added to my age would give me a number of 120");
    }
}
 
