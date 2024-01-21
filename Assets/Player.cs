using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D ball;
    public Vector2 force;
    public int speed;
    public Transform platform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame Block
    void Update()
    {
        platform.Translate(Input.GetAxis("Horizontal") * new Vector3(0, speed) * Time.deltaTime);
        if(Input.GetKeyDown(KeyCode.Space))
        {   
            ball.AddForce(force);
        }
    }
}
