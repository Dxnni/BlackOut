using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shape : MonoBehaviour {

    Color color;

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

        if (blackOut.shuffled)
        {
            for (int i = 0; i < blackOut.shapes.Length; i++)
            {
                if (blackOut.shapes[i] == this.tag)
                {
                    if (i > 3)
                    {
                        color = blackOut.colors[blackOut.randomNum];
                        GetComponent<Renderer>().material.color = color;
                        Debug.Log("Set " + blackOut.shapes[i] + " to " + color);
                        break;
                    }

                    color = blackOut.colors[i];
                    GetComponent<Renderer>().material.color = color;
                    Debug.Log("Set " + blackOut.shapes[i] + " to " + color);
                    break;
                }
            }
        }
    }
}
