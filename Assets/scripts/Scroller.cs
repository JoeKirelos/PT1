using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroller : MonoBehaviour
{

    public float tempo;
    public bool started;

    // Start is called before the first frame update
    void Start()
    {
        tempo = tempo / 60f;
    }

    // Update is called once per frame
    void Update()
    {
        if(!started)
        {
            if (Input.anyKeyDown)
            {
                started = true;
            }
        }
        else
        {
            transform.position -= new Vector3(0f, tempo * Time.deltaTime, 0f);
        }
    }
}
