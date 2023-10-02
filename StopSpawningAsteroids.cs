using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StopSpawningAsteroids : MonoBehaviour
{
    public GameObject pluto;
    public GameObject moon;
    public GameObject asteroid;
    public GameObject Spawner;
    public GameObject FinalScore;

    // Start is called before the first frame update
    void Start()
    {
        asteroid.SetActive(true);
        FinalScore.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (!pluto.activeSelf && !moon.activeSelf)
        {
            asteroid.SetActive(false);
            Spawner.SetActive(false);
            FinalScore.SetActive(true);
        }
    }
}
