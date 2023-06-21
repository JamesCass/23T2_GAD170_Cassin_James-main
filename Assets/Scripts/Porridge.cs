using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Porridge : MonoBehaviour
{
    [SerializeField] private float Temperature;

    private void Start()
    {
        Temperature = 100;
    }

    private void Update()
    {
        Temperature = Temperature - Time.deltaTime;

        if (Temperature > 50)
        {
            Debug.Log("The temperature is too hot!" + (int)Temperature);
        }

        else if (Temperature < 50)
        {
            Debug.Log("The porridge is safe to eat!" + (int)Temperature);
        }

        else if (Temperature < 30)
         {
            Debug.Log("The porridge is too cold!" + (int)Temperature);
         }
    }
}
