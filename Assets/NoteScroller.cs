using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteScroller : MonoBehaviour
{

    public float beatTempo;

    public bool gameStarted;

    public BPMToggle BPMT;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (BPMT.eightyBPM == true)
        {
            beatTempo = 80 / 60f;
        }
        else if (BPMT.hunderedBPM == true)
        {
            beatTempo = 100 / 60f;
        }
        else if (BPMT.hunderedTwentyBPM == true)
        {
            beatTempo = 120 / 60f;
        }
        else if (BPMT.hunderedFourtyBPM == true)
        {
            beatTempo = 140 / 60f;
        }

        transform.position -= new Vector3(0f, beatTempo * Time.deltaTime, 0f);
        
        //if (Input.GetKeyDown(KeyCode.Space))
        {
            //gameStarted = true; 
        }    

        //if (gameStarted == true)
        {
            //transform.position -= new Vector3(0f, beatTempo * Time.deltaTime, 0f);
        }
    }
}
