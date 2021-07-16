using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TicketSeller : MonoBehaviour
{
    public static int flagForTicket;
    public GameObject spawnableObject;

    void Start()
    {
        flagForTicket = 0;
    }

    public void GiveTicket()
    {
        spawnableObject.SetActive(true);
        spawnableObject.GetComponent<Collectable>().flagID = flagForTicket;
        flagForTicket++;
    }
}
