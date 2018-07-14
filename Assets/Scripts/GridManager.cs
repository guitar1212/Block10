using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour {

    public Color[] ColorList;

    private static GridManager _instance = null;

    public GameObject GridPrefab;
    public Transform GridContainer;
    public int Row = 5;
    public int Col = 5;

    public float StartX = 0f;
    public float StartY = 0f;

    public int ColorCount = 4;

    private float GridWidth = 130;
    private float GridHeight = 130;

    private List<GridUnit> GridList = new List<GridUnit>();


    public static GridManager Instance
    {
        get
        {
            return _instance;
        }
    }

    private void Awake()
    {
        _instance = new GridManager();
    }

    private void Start()
    {
        CreateGrids();
    }

    public void CreateGrids()
    {
        GridList.Clear();
        

        float posX = StartX;
        float posY = StartY;
        for (int i = 0; i < Row; i++)
        {
            posX = StartX;
            for (int j = 0; j < Col; j++)
            {
                GameObject grid = GameObject.Instantiate(GridPrefab);
                grid.transform.SetParent(GridContainer);
                grid.transform.localPosition = new Vector3(posX, posY);
                grid.transform.localScale = Vector3.one;

                GridUnit unit = grid.GetComponent<GridUnit>();
                int colorIndex = Random.Range(0, ColorList.Length);
                unit.SetColor(ColorList[colorIndex]);
                unit.SetValue(Random.Range(1, 10));

                GridList.Add(unit);
                posX += GridWidth;
            }

            posY += GridHeight;
        }
    }


    // Update is called once per frame
    void Update () {
		
	}
}
