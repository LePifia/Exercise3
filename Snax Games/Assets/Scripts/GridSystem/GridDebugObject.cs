using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GridDebugObject : MonoBehaviour
{
    [SerializeField] private TextMeshPro cellText;
    private GridObject gridObject;

    // Setting the grid object for this debug object
    public void SetGridObjectText(GridObject gridObject)
    {
        this.gridObject = gridObject;
        SetTextInformation();
    }
    // Setting the text information of the grid object
    private void SetTextInformation()
    {
        cellText.text = gridObject.ToString();
    }
}
