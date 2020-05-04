using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownArrowMovement : MonoBehaviour
{
    bool is_A = true;
    bool is_B = false;

    int CountA = 0;
    int CountB = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (CountA == 50)
        {
            is_A = false;
            is_B = true;
            CountA = 0;
        }

        if (CountB == 5)
        {
            is_A = true;
            is_B = false;
            CountB = 0;
        }

        if (is_A == true)
        {
            CountA++;
        }

        if (is_B == true)
        {
            CountB++;
        }

        if (CountA >= 1)
        {
            transform.Translate(0.0f, 0.0025f, 0.0f);
        }

        if (CountB >= 1)
        {
            transform.Translate(0.0f, -0.025f, 0.0f);
        }
    }
}
