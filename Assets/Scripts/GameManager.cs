using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //store a reference to each car in game.
    //[] = array
    [SerializeField] private car[] allCars;
    [SerializeField] private List<car> allCarsList = new List<car>();

    private void Start()
    {
        //for the array
        Debug.Log("array" + allCars.Length);
        Debug.Log("array" + allCars[3].name);

        //for the list
        Debug.Log("list" + allCarsList.Count);
        Debug.Log("list" + allCarsList[3].name);
    }

    private void CheckWhichCarIsCrashed()
    {
        //FOR loop
        for (int selectedCarindex = 0; selectedCarindex < allCars.Length; selectedCarindex++)
        {
            if (allCarsList[selectedCarindex].isCrashed == true)
            {
                Debug.Log("CRASHED " + selectedCarindex);
                Debug.Log("A car has crashed: [" + allCarsList[selectedCarindex].name + "]1");
            }
        }
    }


    public void HelloWorldButton()
    {
        Debug.Log("Hello world");
    }
}
