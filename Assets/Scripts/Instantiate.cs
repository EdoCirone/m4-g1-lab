using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour
{

    [SerializeField] private int numbersOfColumn;
    [SerializeField] private int numbersOfRow;
    [SerializeField] private float offsetX;
    [SerializeField] private float offsetZ;
    [SerializeField] GameObject quad;

    void Start()
    {

        InstantiateGrid();

    }

    private void InstantiateGrid()
    {
        int numberOfQuad = numbersOfColumn * numbersOfRow;
        
        Vector3 quadScale = quad.GetComponent<Transform>().localScale;

        if (offsetX <= 0 && offsetZ <= 0)
        {
            offsetX = quadScale.x; // Default offset if not set
            offsetZ = quadScale.z; // Default offset if not set
        }

        for (int i = 0; i < numberOfQuad; i++)
        {

            int column = i % numbersOfColumn;
            int row = i / numbersOfColumn;
            Vector3 position = new Vector3(column * offsetX, 0, row * offsetZ);
            Instantiate(quad, position, Quaternion.identity);

        }
    }
}
