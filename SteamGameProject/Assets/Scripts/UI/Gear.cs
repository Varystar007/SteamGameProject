using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gear : MonoBehaviour
{
    bool TurnRight = false;
    bool TurnLeft = false;

    int TurnRightCount = 0;
    int TurnLeftCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) == true)
        {
            TurnRight = true;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow) == true)
        {
            TurnLeft = true;
        }

        if (TurnRight == true)
        {
            TurnRightCount++;
        }

        if (TurnLeft == true)
        {
            TurnLeftCount++;
        }

        if (TurnRightCount >= 1)
        {
            transform.Rotate(0.0f, 0.0f, -1.0f);
            if (TurnRightCount == 30)
            {
                TurnRight = false;
                TurnRightCount = 0;
            }
        }

        if (TurnLeftCount >= 1)
        {
            transform.Rotate(0.0f, 0.0f, 1.0f);
            if (TurnLeftCount == 30)
            {
                TurnLeft = false;
                TurnLeftCount = 0;
            }
        }
    }
}
