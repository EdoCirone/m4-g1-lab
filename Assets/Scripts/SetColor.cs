using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SetColor : MonoBehaviour
{
    private ColorManager colorManager;
    [SerializeField] Color defaultColor = Color.white;
    private void Start()
    {
        colorManager = FindObjectOfType<ColorManager>();
        Debug.Log("ColorManager found: " + (colorManager != null));
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(1) == true)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hit) && hit.transform == transform)
            {
                Renderer renderer = GetComponent<Renderer>();
                if (renderer != null)   renderer.material.color = defaultColor;

            }
        }

    }


    private void OnMouseDown()
    {
        Renderer renderer = GetComponent<Renderer>();

        if (renderer != null)
        {
            renderer.material.color = colorManager.SelectedColor;
        }

    }



}
