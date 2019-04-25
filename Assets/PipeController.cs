using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeController : MonoBehaviour {

    public float speed;
    public float upDownSpeed;
    Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        MovePipe();
        InvokeRepeating("SwitchUpDown", .1f, 1f);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void SwitchUpDown()
    {
        upDownSpeed = -upDownSpeed;
        rb.velocity = new Vector2(speed, upDownSpeed);
    }

    void MovePipe()
    {
        rb.velocity = new Vector2(-speed, 0);
    }


    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "PipeRemover")
        {
            Destroy(gameObject);
        }
    }


}
