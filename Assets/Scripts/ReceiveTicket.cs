using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReceiveTicket : MonoBehaviour
{
    public GameObject rightHandler;
    public GameObject ticket;
    // Start is called before the first frame update
    private void Update()
    {
        if(Input.GetMouseButtonDown(1)){
            spawnTicketOnHand();
        }
    }

    void spawnTicketOnHand()
    {
        GameObject newTicket = Instantiate(ticket, rightHandler.transform) as GameObject;
        newTicket.transform.position = rightHandler.transform.position;
        
    }
}
