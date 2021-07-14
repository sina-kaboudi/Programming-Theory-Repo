using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    [SerializeField] private string shapeName;

    public string ShapeName { get; set; }
    public Color ShapeColor { get; set; }

    private void Awake()
    {
        ShapeName = shapeName;
    }

    private void OnMouseDown()
    {
        DisplayText();
    }

    protected virtual void DisplayText()
    {
        Debug.Log("Calling a method from shape");
    }
}