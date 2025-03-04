using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New TowerData", menuName = "Tower Defense/Tower Data")]
public class TowerData : ScriptableObject
{
    public string towerName;
    public Sprite towerIcon;
    
    [Header("Prefabs")]
    public GameObject level1Prefab;
    public GameObject level2Prefab;
    public GameObject level3Prefab;

    [Header("Cost")]
    public int buyCost;
    public int upgradeCost1;
    public int upgradeCost2;

    [Header("Stats")]
    public float level1Range;
    public float level2Range;
    public float level3Range;

    [Header("Add Stats")]
    public float damage;
    public float fireRate;
}
