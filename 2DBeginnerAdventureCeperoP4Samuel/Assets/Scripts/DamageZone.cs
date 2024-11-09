using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DamageZone : MonoBehaviour
{
    void OnTriggerStay2D(Collider2D other)
    {
        ChubyController controller = other.GetComponent<ChubyController>();
        
        if(controller != null )
        {
            controller.ChangeHealth(-1);
        }
    }
}
