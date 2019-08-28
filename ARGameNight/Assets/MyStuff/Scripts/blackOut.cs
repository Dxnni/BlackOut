using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class blackOut : MonoBehaviour {

    public static Color[] colors = { Color.green, Color.red, Color.blue, Color.yellow };
    public static string[] shapes = { "square", "circle", "triangle", "waves", "crown" };
    public static bool shuffled = false;
    public static int randomNum;

    // Use this for initialization
    void Start () {
        shuffled = false;
        shuffleShapes();
        randomNum = Random.Range(0, 4);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public static void shuffleShapes()
    {
        for (int t = 0; t < shapes.Length; t++)
        {
            string tmp = shapes[t];
            int r = Random.Range(t, shapes.Length);
            shapes[t] = shapes[r];
            shapes[r] = tmp;
        }
        Debug.Log("Shuffled Shapes Complete:\n" + shapes);
        shuffled = true;
    }

}
