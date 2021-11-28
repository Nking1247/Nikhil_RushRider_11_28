using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotate : MonoBehaviour
{
    public bool grabbed = false;
    

    // Update is called once per frame
    GameObject player;
    //Rigidbody rb;
    public GameObject ding;
    private void Start()
    {
        //rb = gameObject.GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player");
    }
    void FixedUpdate()
    {
        if (!grabbed && player.transform.position.z > transform.position.z - 100f)
        {
            transform.Rotate(new Vector3(0, -1, 0), 3f);

            Destroy(gameObject, 30);
            
        }
        else if(grabbed)
        {



            GameObject aud = Instantiate(ding, gameObject.transform.position, Quaternion.identity);
            Destroy(aud, 2f);
            
            Destroy(gameObject);
            

           
           
            
            
        }
        
        
    }

    

}
