using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ColorManager : MonoBehaviour
{

    public Color SelectedColor; // The color selected by the user

    private void Update()
    {
        GetComponent<Renderer>().material.color = SelectedColor;
    }

}
