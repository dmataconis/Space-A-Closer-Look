using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class SwordColides : MonoBehaviour
{
    public GameObject Audio;
    public TextMeshProUGUI score;

    // Update is called once per frame
    private void OnTriggerEnter(Collider trigger)
    {
        if (trigger.gameObject.tag == "Asteroid")
        {
            Audio.GetComponent<PlayAudio>().PlayAudio1();
            Destroy(trigger.gameObject);

            score.GetComponent<AddScore>().AddScore1();
            Debug.Log("Hit");
        }

    }
    }
