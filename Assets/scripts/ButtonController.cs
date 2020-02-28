using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    private SpriteRenderer theSR;
    public Sprite defaultImage;
    public Sprite pressedLeftImage;
    public Sprite pressedRightImage;

    public KeyCode keyOne;
    public KeyCode keyTwo;
    // Start is called before the first frame update
    void Start()
    {
        theSR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(keyOne))
        {
            theSR.sprite = pressedLeftImage;
        }
        if (Input.GetKeyDown(keyTwo))
        {
            theSR.sprite = pressedRightImage;
        }
        if (Input.GetKeyUp(keyOne) | Input.GetKeyUp(keyTwo))
        {
            theSR.sprite = defaultImage;
        }
    }
}
