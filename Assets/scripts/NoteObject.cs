using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject : MonoBehaviour
{

    public bool canPress;
    public KeyCode keyOne;
    public KeyCode keyTwo;
    public double k1D = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(keyOne))
        {
            if (k1D < 2.0)
            {
                k1D += 1.0;
            }
            
        }
        if (Input.GetKeyUp(keyOne))
        {
            if (k1D > 1.0)
            {
                k1D -= 1.5;
            }
            
        }
        if (Input.GetKeyDown(keyTwo))
        {
            if(k1D == 0.5)
            {
                k1D += 0.5;
            }
            
               
            if (canPress & k1D == 1)
            {
                gameObject.SetActive(false);
            }
            
        }
        if (Input.GetKeyUp(keyTwo))
        {
            if (k1D > 0)
            {
                k1D = 0;
            }

        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Activator")
        {
            canPress = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Activator")
        {
            canPress = false;
        }
    }
}
