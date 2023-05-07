using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plamov : MonoBehaviour
{

    public CharacterController controller;
    public float speed = 20f;
    public float gravity = -9.81f;

    public Transform ground;
    public float Distance;
    public LayerMask gmask;

    bool grounded;

    Vector3 velocity;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        grounded = Physics.CheckSphere(ground.position, Distance, gmask);

        if(grounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}
