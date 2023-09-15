using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AddScore : MonoBehaviour
{
    public TextMeshProUGUI Score;
    private int num;
    // Start is called before the first frame update
    void Start()
    {
        num = 0;
        Score.text = num.ToString();
    }

    void Update()
    {
        Score.text = num.ToString();
    }

    public void AddScore1()
    {
        num += 10;
    }
    public void Reset()
    {
        num = 0;
    }
}
