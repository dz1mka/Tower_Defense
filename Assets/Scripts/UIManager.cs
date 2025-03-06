using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject buyUI;
    [SerializeField] GameObject buyButtonPrefab;

    [SerializeField] float buttonRadius = 50f;

    TowerManager currentSelectedTower;

    // Start is called before the first frame update
    void Start()
    {
        buyUI.SetActive(false);
    }

    public void ShowBuyUI(TowerData[] awailableTowers, TowerManager towerManager)
    {
        currentSelectedTower = towerManager;

        foreach(Transform child in buyUI.transform)
        {
            Destroy(child.gameObject);
        }

        int numTowers = awailableTowers.Length;

        for(int i = 0; i < numTowers; i++)
        {
            GameObject newButton = Instantiate(buyButtonPrefab, buyUI.transform);

            Vector2 buttonPosition = new Vector2(0, 0);
        }
    }
   
}
