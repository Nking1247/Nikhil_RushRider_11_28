using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadSpawner : MonoBehaviour
{
    public List<GameObject> roads;
    public List<GameObject> allRoads;
    private float offset = 16f;
    private float hillOffset = 120f;
    private float keeper;
    private int lastroad;
    int rand;

    void Start()
    {
        if (roads != null && roads.Count > 0)
        {
            //roads = roads.OrderBy(r => r.transform.position.z).ToList();

        }
            
    }

    public void MoveRoad()
    {
        
        if (lastroad == 0)
        {
            rand = Random.Range(1, allRoads.Count);
        }
        else
        {
            rand = Random.Range(0, allRoads.Count);
        }
        GameObject runningRoad = roads[0];
        roads.Remove(runningRoad);
        Destroy(runningRoad, 5.0f);

        float lastRoadPosition = roads[roads.Count - 1].transform.position.z;
        
        
            
        
        Vector3 newRoadPosition = new Vector3(0,0,lastRoadPosition + offset + keeper);
        GameObject newRoad = Instantiate(allRoads[rand], newRoadPosition, Quaternion.identity);
        roads.Add(newRoad);
        if (rand == 0)
        {
            keeper = 8f;
        }
        else
        {
            keeper = 0f;
        }

        lastroad = rand;
        
    }

    public void HillRoad()
    {
        rand = Random.Range(0, allRoads.Count);


        GameObject runningRoad = roads[0];
        roads.Remove(runningRoad);
        Destroy(runningRoad, 5.0f);

        float lastRoadPosition = roads[roads.Count - 1].transform.position.z;

        Vector3 newRoadPosition = new Vector3(0, 0, lastRoadPosition + hillOffset);

        GameObject newRoad = Instantiate(allRoads[rand], newRoadPosition, Quaternion.identity);
        roads.Add(newRoad);

    }
}
