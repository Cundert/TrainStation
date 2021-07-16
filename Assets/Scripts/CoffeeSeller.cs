using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeeSeller : MonoBehaviour
{
    public GameObject spawnableObject;

    public void GiveCoffee()
    {
        spawnableObject.SetActive(true);
    }
}
