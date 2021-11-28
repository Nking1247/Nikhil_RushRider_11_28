using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{

    GameObject carPrefab;
    int randomLane;
     int randomPos;
     int randomPosTwo;
    [SerializeField] GameObject[] cars;

    // Start is called before the first frame update
    void Start()
    {
        randomLane = Random.Range(0,3);

        float sped = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>().speed;
        float d = 8 * 16;
        float t = d / sped;



        randomPos = (int) sped * 10 * -1;
        randomPosTwo = (int) t * 10;


        if (randomLane == 0)
        {
            SpawnLeftCar();

        }
        else if (randomLane == 1)
        {
            SpawnRightCar();
        }
        else
        {
            SpawnLeftCar();
            SpawnRightCar();
        }

        
    }

    void SpawnLeftCar()
    {
        carPrefab = cars[Random.Range(0, cars.Length)];
        float zPos = gameObject.transform.position.z;
        float xPos = Random.Range(randomPos - 6, randomPos + 6);
        GameObject car = Instantiate(carPrefab, new Vector3(xPos, 0.5f, zPos), Quaternion.identity);
        Destroy(car, 60f);
        
    }   
    void SpawnRightCar()
    {
        carPrefab = cars[Random.Range(0, cars.Length)];
        float zPos = gameObject.transform.position.z + 8;
        float xPos = Random.Range(randomPosTwo - 6, randomPosTwo + 6);
        GameObject car = Instantiate(carPrefab, new Vector3(xPos, 0.5f, zPos), Quaternion.identity);
        car.transform.Rotate(new Vector3(0, 180, 0), Space.Self);
        Destroy(car, 60f);
    }

    
}
