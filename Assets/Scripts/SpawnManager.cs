using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    RoadSpawner r;
    // Start is called before the first frame update
    void Start()
    {
        //r = gameObject.GetComponent<RoadSpawner>();

        if (r != null)
        {
            Destroy(r);
            
        }
        r = gameObject.GetComponent<RoadSpawner>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SpawnCollider"))
        {
            spawnTriggerEntered();
        }
        if (other.CompareTag("HillSpawn"))
        {
            r.HillRoad();
        }
    }

    private void spawnTriggerEntered()
    {
        
        
        r.MoveRoad();
    }
 
}
