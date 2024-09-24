using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;    
    private Vector3 moviment;
    private Rigidbody rb;
    public Camera mainCamera;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        moviment.x = Input.GetAxisRaw("Horizontal");
        moviment.z = Input.GetAxisRaw("Vertical");

        RotateTowardsMouse();
    }

    void FixedUpdate()
    {
        Vector3 moveDirection = moviment.normalized * moveSpeed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + moveDirection);

    }
    void  RotateTowardsMouse()
    {
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, Mathf.Infinity))         
        {            
            Vector3 direction = hit.point - transform.position; 
            direction.y = 0; 
            Quaternion toRotation = Quaternion.LookRotation(direction); transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, 1000 * Time.deltaTime); 
        }

    }
}
