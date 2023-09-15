using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidBehavior : MonoBehaviour
{
    public GameObject[] SpaceRocks;
    private int randomIndex;
    private AudioSource Ding;
    // Start is called before the first frame update
    void Start()
    {
        SpaceRocks = GameObject.FindGameObjectsWithTag("Minigame");
        randomIndex = Random.Range(0, SpaceRocks.Length);
        Ding = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveAsteroid();

    }
    public void PlayAudio()
    {
        Ding.Play();
    }

    void MoveAsteroid()
    {
        transform.position = Vector3.MoveTowards(transform.position, SpaceRocks[randomIndex].transform.position, 3.2f * Time.deltaTime);
        
    }
    void OnDestroy()
    {
        Ding.Play();
    }
