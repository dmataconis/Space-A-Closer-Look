using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StartGameScript : MonoBehaviour
{
    public GameObject Spawner;
    public GameObject Score;
    public GameObject Pluto;
    public GameObject Moon;
    public GameObject asteroid;
    public GameObject FinalScore;
    public TextMeshProUGUI Score1;
    public GameObject Playtxt;

    
    private int num = 0;
    // Start is called before the first frame update
    void Start()
    {
        Spawner.SetActive(false);
        Score.SetActive(false);
        asteroid.SetActive(false);
        
    }

    // Update is called once per frame
    public void StartGame()
    {
        Spawner.SetActive(true);
        Score.SetActive(true);
        Pluto.SetActive(true);
        Moon.SetActive(true);
        asteroid.SetActive(true);
        FinalScore.SetActive(false);
        Playtxt.SetActive(false);
        Score1.GetComponent<AddScore>().Reset();
        

    }
}
