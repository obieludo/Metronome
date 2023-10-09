using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject eightyBPMAudio;
    public GameObject hunderedBPMAudio;
    public GameObject hunderedTwentyBPMAudio;
    public GameObject hunderedFourtyBPMAudio;

    public BPMToggle BPMT;

    public NoteScroller notescroll;

    public static GameManager instance;

    public int currentBPM; 
    

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {

        //having the audio as audio sources and doing .play() was making it shit the bed for some reason so, off/on gameobjects for now
        if (BPMT.eightyBPM == true)
        {
            Debug.Log("80 BPM");
            eightyBPMAudio.SetActive(true);
            hunderedBPMAudio.SetActive(false);
            hunderedTwentyBPMAudio.SetActive(false);
            hunderedFourtyBPMAudio.SetActive(false);
        }

        else if (BPMT.hunderedBPM == true)
        {
            Debug.Log("100 BPM");
            eightyBPMAudio.SetActive(false);
            hunderedBPMAudio.SetActive(true);
            hunderedTwentyBPMAudio.SetActive(false);
            hunderedFourtyBPMAudio.SetActive(false);
        }

        else if (BPMT.hunderedTwentyBPM == true)
        {
            Debug.Log("120 BPM");
            eightyBPMAudio.SetActive(false);
            hunderedBPMAudio.SetActive(false);
            hunderedTwentyBPMAudio.SetActive(true);
            hunderedFourtyBPMAudio.SetActive(false);
        }

        else if (BPMT.hunderedFourtyBPM == true)
        {
            Debug.Log("140 BPM");
            eightyBPMAudio.SetActive(false);
            hunderedBPMAudio.SetActive(false);
            hunderedTwentyBPMAudio.SetActive(false);
            hunderedFourtyBPMAudio.SetActive(true);
        }
    }

    public void NoteHit()
    {
        Debug.Log("Note Hit");
    }

    public void NoteMissed()
    {
        Debug.Log("Note Missed");
    }
}
