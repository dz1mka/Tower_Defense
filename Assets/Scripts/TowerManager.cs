using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerManager : MonoBehaviour
{
    public bool isSelected = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnMouseDown()
    {
        isSelected = true;
        Debug.Log(gameObject.name + " is selected");
    }
}
