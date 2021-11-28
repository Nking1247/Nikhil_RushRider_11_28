using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnCoin : MonoBehaviour
{
    public GameObject coin;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 pos = new Vector3(transform.position.x, transform.position.y , transform.position.z);

        Instantiate(coin, pos, Quaternion.Euler(new Vector3(0, 0, 0)));

    }

    
}
