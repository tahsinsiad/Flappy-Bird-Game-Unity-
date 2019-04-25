using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour {

    public float maxYpos;
    public float spawntime;
    public GameObject pipe;


    // Use this for initialization
    void Start () {
        SpawningStart();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SpawningStop()
    {
        CancelInvoke("SpawningPipe");
    }

    public void SpawningStart()
    {
        InvokeRepeating("SpawningPipe", .2f, spawntime);
    }

    void SpawningPipe()
    {
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(-maxYpos, maxYpos), 0), Quaternion.identity);
    }

}
