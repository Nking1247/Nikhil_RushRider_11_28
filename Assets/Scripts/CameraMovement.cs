using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    Transform me;
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        me = gameObject.transform;
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        try
        {


            if (player.GetComponent<PlayerMovement>().notDead)
            {

                Vector3 biek = new Vector3(0, 0, 1) * Time.deltaTime * player.GetComponent<PlayerMovement>().speed;
                me.Translate(biek, Space.World);
                //Debug.Log(Vector3.forward * Time.deltaTime * player.GetComponent<PlayerMovement>().speed);
                Vector3 four = Vector3.MoveTowards(me.position, player.transform.position, .3f);

                me.position = new Vector3(four.x, me.position.y, me.position.z);
                //me.rotation = player.transform.rotation;

            }

        }
        catch
        {

        }
        
        
    }
}
