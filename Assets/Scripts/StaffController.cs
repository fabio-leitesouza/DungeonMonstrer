using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaffController : MonoBehaviour
{
    //criando a variável Magic do tipo GameObject
    public GameObject Magic;
    public GameObject StaffTip;

    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Instantiate(Magic, StaffTip.transform.position, StaffTip.transform.rotation);
            
        }
    }
}
