using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemperatureStatus: MonoBehaviour
{
    bool stop;
    bool weak;
    bool normal;
    bool strong;

    int TemperatureCount = 0;
    float RotationPoint;

    GameObject TextController;
    TemperatureStrength script;

    // Start is called before the first frame update
    void Start()
    {
        stop = true;
        weak = false;
        normal = false;
        strong = false;

        TextController = GameObject.Find("TextController");
        script = TextController.GetComponent<TemperatureStrength>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            if (stop == true)
            {
                stop = false;
                weak = true;
            }

            else if (weak == true)
            {
                weak = false;
                normal = true;
            }

            else if (normal == true)
            {
                normal = false;
                strong = true;
            }

            else if (strong == true)
            {
                strong = false;
                stop = true;
            }
        }

        if (weak == true)
        {
            TemperatureCount++;
            script.is_weak();
        }

        if (normal == true)
        {
            TemperatureCount = TemperatureCount + 2;
            script.is_normal();
        }

        if (strong == true)
        {
            TemperatureCount = TemperatureCount + 3;
            script.is_strong();
        }

        if (stop == true)
        {
            TemperatureCount--;
            script.is_stop();
        }

        if (TemperatureCount <= -1)
        {
            TemperatureCount = 0;
        }

        if (TemperatureCount >= 4001)
        {
            TemperatureCount = 4000;
        }

        RotationPoint = 120f - TemperatureCount * 0.06f;
        this.transform.rotation = Quaternion.Euler(0.0f, 0.0f, RotationPoint);
    }
}
