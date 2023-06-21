using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Week3 : MonoBehaviour
{
    [SerializeField] private string firstName = "James";
    [SerializeField] private string lastName = "Cassin";


    private void Start()
    {
        PrintName();
    }

    private void PrintName()
    {
        string fullName = firstName + " " + lastName;
        Debug.Log("Full name: " + fullName);
    }
}
