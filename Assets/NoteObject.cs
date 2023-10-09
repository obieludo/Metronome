using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject : MonoBehaviour
{
    public bool canBePressed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(canBePressed == true)
            {
                gameObject.SetActive(false);

                GameManager.instance.NoteHit();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "HitSquare")
        {
            canBePressed = true;
        }
    }


    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "HitSquare")
        {
            canBePressed = false;
            GameManager.instance.NoteMissed();
        }
    }
}
