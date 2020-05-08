using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemperatureStrength : MonoBehaviour
{
    SpriteRenderer MainSpriteRenderer;

    public GameObject Textstop;
    public GameObject Textweak;
    public GameObject Textnormal;
    public GameObject Textstrong;

    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void is_stop()
    {
        Textstop.SetActive(true);
        Textweak.SetActive(false);
        Textnormal.SetActive(false);
        Textstrong.SetActive(false);
    }

    public void is_weak()
    {
        Textstop.SetActive(false);
        Textweak.SetActive(true);
        Textnormal.SetActive(false);
        Textstrong.SetActive(false);
    }

    public void is_normal()
    {
        Textstop.SetActive(false);
        Textweak.SetActive(false);
        Textnormal.SetActive(true);
        Textstrong.SetActive(false);
    }

    public void is_strong()
    {
        Textstop.SetActive(false);
        Textweak.SetActive(false);
        Textnormal.SetActive(false);
        Textstrong.SetActive(true);
    }
}
