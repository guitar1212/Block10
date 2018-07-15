using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {

    private static InputManager _instance = null;

    public static InputManager Instance
    {
        get
        {
            return _instance;
        }
    }

    private void Awake()
    {
        _instance = new InputManager();
    }

    // Update is called once per frame
    void Update () {
        /*
        if (Input.touchCount > 0)
        {
            Debug.Log("Touch Count :" + Input.touchCount);
        }
        */
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouse Button Down 0");
        }
	}
}
