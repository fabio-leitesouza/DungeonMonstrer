using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magic : MonoBehaviour
{
    // Start is called before the first frame update
    public float Speed = 20;

    // Update is called once per frame
    void FixedUpdate()
    {
        GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + transform.forward * Speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider objectCollision)
    {
        if(objectCollision.tag == "Enemy")
        {
            Destroy(objectCollision.gameObject);            
        }
        Destroy(gameObject);
    }
}
