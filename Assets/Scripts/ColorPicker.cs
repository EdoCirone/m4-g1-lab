using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPicker : MonoBehaviour
{
    ColorManager colorManager;
    void Start()
    {
        colorManager = FindObjectOfType<ColorManager>();

    }
    private void OnMouseDown()
    {
        Renderer renderer = GetComponent<Renderer>();
        if (renderer != null)
        {

            colorManager.SelectedColor = renderer.material.color;
            Debug.Log("Color selected: " + colorManager.SelectedColor);
        }

    }
}
