using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New GiveCoffee", menuName = "FSM/Action/Give Coffee")]

public class GiveCoffee : FSMaction
{
    // Start is called before the first frame update
    public override void Act(FSMcontroller controller)
    {
        controller.GetComponent<CoffeeSeller>().GiveCoffee();
    }
}