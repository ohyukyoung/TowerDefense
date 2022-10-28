using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public TurretBlueprint standardTurret;
    public TurretBlueprint missileLauncher;

    BuildManager buildManager;
   

    private void Start()
    {
        buildManager = BuildManager.instance;
        DisplayCoin(Variables.Coins);
    }
    void DisplayCoin(int Coin)
    {
        GameObject.Find("CoinValue").GetComponent<Text>().text = Coin.ToString();

    }

    public void AddCoin(int value)
    {
        Variables.Coins += value;
        DisplayCoin(Variables.Coins);
    }

    public void SpendCoin(int value)
    {
        Variables.Coins -= value;
        DisplayCoin(Variables.Coins);
    }

    public int GetCoin()
    {
        return Variables.Coins;
    }
    
    
    
    public void SelectStandardTurret()
    {
        Debug.Log("Tank Purchased");
        buildManager.SelectTurretToBuild(standardTurret);
    }
    public void SelectMissileLauncher()
    {
        Debug.Log("Bomb Purchased");
        buildManager.SelectTurretToBuild(missileLauncher);
    }

   public void BuyPotion()
    {   
        if (Variables.Coins < 150)
        {
            print("not enough coins");
            return;
        }
        SpendCoin(150);
        Debug.Log("Potion Purchased");
        GameObject.Find("HealthBar").GetComponent<EndHealthBar>().TakePotion();
    }
    
}
