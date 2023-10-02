using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    

    public GameObject[] spawnZones;
    public GameObject asteroid;


    
    void Start()
    {
         
        InvokeRepeating("RandomlyInstantiateSpawnPoint", 5, 5);
    }


   
    void RandomlyInstantiateSpawnPoint()
    {

        int randomIndex = Random.Range(0, spawnZones.Length);

        
        Instantiate(asteroid, spawnZones[randomIndex].transform.position, Quaternion.identity);

    }


}
