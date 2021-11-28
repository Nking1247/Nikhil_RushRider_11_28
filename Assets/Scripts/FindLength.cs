using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindLength : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 size = GetComponent<Collider>().bounds.size;
        Debug.Log(size.x + ", " + size.z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
