using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TicketValidator : MonoBehaviour
{
    public GameObject userRightHand;
    public GameObject simulatorUserRightHand;


    public GameObject ticketSpawned;
    public GameObject ticketToBeGiven;

    public FSMcontroller FSMgate;


    public void SpawnTicketInUserHand()
    {
        if (userRightHand.activeInHierarchy)
        {
            ticketSpawned = Instantiate(ticketToBeGiven, userRightHand.transform);
            ticketSpawned.transform.position = userRightHand.transform.position;
        }
        else
        {
            ticketSpawned = Instantiate(ticketToBeGiven, simulatorUserRightHand.transform);
            ticketSpawned.transform.position = simulatorUserRightHand.transform.position;
        }
    }
    public void TicketValidated()
    {
        FSMgate.customFlag = true; // El custom flag indica que  el ticket ha sido validado.
        TaskHandler.instance.flags[3] = true;
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.name.Contains("SimpleTicket"))
        {
            GetComponent<FSMcontroller>().customFlag = true; // El custom flag indica que ha recibido el ticket.
            Destroy(other.gameObject);
        }
    }
}
