using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class car : MonoBehaviour
{
    [SerializeField] private string brand = "Holden";
    [SerializeField] private int speedLimit = 220;
    public bool isCrashed = false;
}
