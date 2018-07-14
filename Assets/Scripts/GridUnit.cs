using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GridUnit : MonoBehaviour {

    [SerializeField]
    Image _image;

    [SerializeField]
    Text _text;

    [SerializeField]
    Color _color;

    public void SetColor(Color c)
    {
        _color = c;
        _image.color = c;
    }

    public void SetValue(int value)
    {
        _text.text = value.ToString();
    }

    private void OnMouseDown()
    {
        
    }

    private void OnMouseUp()
    {
        
    }
}
