using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D ball;
    public Vector2 force;
    public int speed;
    public Transform platform;

    private bool canAcitve = true;
    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame Block
    void Update()
    {
        if (platform.transform.position.x >= -8 && platform.transform.position.x <= 8)
        {
            platform.Translate(Input.GetAxis("Horizontal") * new Vector3(0, speed) * Time.deltaTime);
        }
        else
        {
            platform.transform.position = new Vector2(Mathf.Clamp(platform.transform.position.x, -8, 8),
                platform.transform.position.y);
        }
        if (Input.GetKeyDown(KeyCode.Space) && canAcitve)
        {
            canAcitve = false;
            ball.bodyType = RigidbodyType2D.Dynamic;
            ball.transform.SetParent(null);
            ball.AddForce(force);
        }
    }

    public void AddScore(int value)
    {
        score += value;
    }
}
