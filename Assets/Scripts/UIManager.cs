using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour {

    [SerializeField]
    GameObject MainMenu;

    [SerializeField]
    GameObject GameUI;

    [SerializeField]
    GameObject EndUI;



    private static UIManager _instance = null;

    public static UIManager Instance
    {
        get
        {
            return _instance;
        }
    }

    private void Awake()
    {
        _instance = new UIManager();
    }
}
