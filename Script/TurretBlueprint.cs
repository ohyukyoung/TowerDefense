using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]   // inspector���� �� �� �ֵ���

public class TurretBlueprint    // ���� ������Ʈ�� attach ����-->monobehavior x
{
    public GameObject prefab;
    public int cost;

    public GameObject upgradedPrefab;
    public int upgradeCost;
}
