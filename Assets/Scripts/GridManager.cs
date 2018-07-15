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

    private float GridWidth = 150;
    private float GridHeight = 150;

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
        DeleteGrids();
        GridList.Clear();

        float widthOffset = (Col - 1) * GridWidth / 2f;
        float heightOffset = Row * GridHeight / 2f;

        float posX = StartX - widthOffset;
        float posY = StartY - heightOffset;
        for (int i = 0; i < Row; i++)
        {
            posX = StartX - widthOffset;
            for (int j = 0; j < Col; j++)
            {
                GameObject grid = GameObject.Instantiate(GridPrefab);
                grid.transform.SetParent(GridContainer);
                grid.transform.localPosition = new Vector3(posX, posY);
                grid.transform.localScale = Vector3.one;
                grid.name = "Grid_" + i + "_" + j; 

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



    public void DeleteGrids()
    {
        foreach (GridUnit unit in GridList)
        {
            GameObject.DestroyObject(unit.gameObject);

        }

        GridList.Clear();
    }

    // Update is called once per frame
    void Update () {
		
	}
}
