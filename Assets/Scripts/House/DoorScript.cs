using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public bool open = false;
    public float DoorOpenAngle = 0f;
    public float DoorCoseAngle = 0f;
    public void ChangeDoorState ()
    {
        open = !open;
       
    }

    private void Update()
    {
        if (open)
        {
            Quaternion targetRotation = Quaternion.Euler(0, DoorOpenAngle, 0);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation, Time.deltaTime);
        }
        else
        {
            Quaternion targetRotation2 = Quaternion.Euler(0, DoorCoseAngle, 0);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation2, Time.deltaTime);
        }
    }

}
