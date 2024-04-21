using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tester : MonoBehaviour
{
    public Material synth;

    public bool isTimeBased = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            synth.SetFloat("_Sine_Speed", isTimeBased? 1 : 0);
            isTimeBased = !isTimeBased;
        }
    }
}
