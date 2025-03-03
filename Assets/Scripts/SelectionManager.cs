using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionManager : MonoBehaviour
{
    public static SelectionManager instance;
    TowerManager selectedTower;

    private void Awake()
    {
        instance = this;
    }

    public void SelectTower(TowerManager tower)
    {

        if (selectedTower != null && selectedTower != tower)
        {
            DeselectCurrentTower();
        }

        selectedTower = tower;
        selectedTower.SelectTower();
    }

    void DeselectCurrentTower()
    {
        if(selectedTower != null)
        {
            selectedTower.DeselectTower();
            selectedTower = null;
        }
    }
}
