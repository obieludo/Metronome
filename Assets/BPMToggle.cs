using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BPMToggle : MonoBehaviour
{
    public bool eightyBPM;
    public bool hunderedBPM;
    public bool hunderedTwentyBPM;
    public bool hunderedFourtyBPM;

    public TextMeshProUGUI toggleTxt;

    // Start is called before the first frame update
    void Start()
    {
        eightyBPM = false;
        hunderedBPM = true;
        hunderedTwentyBPM = false;
        hunderedFourtyBPM = false;
}

    // Update is called once per frame
    void Update()
    {

        if ((Input.GetKeyDown(KeyCode.UpArrow)) && eightyBPM == true)
        {
            eightyBPM = false;
            hunderedBPM = true;
            toggleTxt.text = "100";
            transform.Translate(0, 70, 0);
        }
        
        else if ((Input.GetKeyDown(KeyCode.UpArrow)) && hunderedBPM == true)
        {
            hunderedBPM = false;
            hunderedTwentyBPM = true;
            toggleTxt.text = "120";
            transform.Translate(0, 70, 0);
        }

        else if ((Input.GetKeyDown(KeyCode.UpArrow)) && hunderedTwentyBPM == true)
        {
            hunderedTwentyBPM = false;
            hunderedFourtyBPM = true;
            toggleTxt.text = "140";
            transform.Translate(0, 70, 0);
        }

        if ((Input.GetKeyDown(KeyCode.DownArrow)) && hunderedFourtyBPM == true)
        {
            hunderedFourtyBPM = false;
            hunderedTwentyBPM = true;
            toggleTxt.text = "120";
            transform.Translate(0, -70, 0);
        }

        else if ((Input.GetKeyDown(KeyCode.DownArrow)) && hunderedTwentyBPM == true)
        {
            hunderedTwentyBPM = false;
            hunderedBPM = true;
            toggleTxt.text = "100";
            transform.Translate(0, -70, 0);
        }

        else if ((Input.GetKeyDown(KeyCode.DownArrow)) && hunderedBPM == true)
        {
            hunderedBPM = false;
            eightyBPM = true;
            toggleTxt.text = "80";
            transform.Translate(0, -70, 0);
        }
    }
}
