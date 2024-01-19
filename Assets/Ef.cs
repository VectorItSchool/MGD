using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ef : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("St", 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void St()
    {
        Destroy(this.gameObject);
    }
}
