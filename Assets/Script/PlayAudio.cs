using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{

    public GameObject audio;

    public void DropAudio()
    {
        Instantiate(audio, transform.position, transform.rotation);
    }
}
