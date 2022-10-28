using UnityEngine;
using UnityEngine.EventSystems;

public class Node : MonoBehaviour
{
    int Coin;
    public Color hoverColor;
    //public Color notEnoughMoneyColor;
    public Vector3 positionOffset;
    [HideInInspector]
    public GameObject turret;
    [HideInInspector]

    public TurretBlueprint turretBlueprint;
    [HideInInspector]

    public bool isUpgraded = false;

    private Renderer rend;
    private Color startColor;

    BuildManager buildManager;
    void Start(){
        rend=GetComponent<Renderer>();
        startColor=rend.material.color;

        buildManager = BuildManager.instance;
        isUpgraded = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&&!isUpgraded){
            UpgradeTurret();
        }
    }
    public Vector3 GetBuildPosition()
    {
        return transform.position + positionOffset;
    }

    void OnMouseDown(){

        //ī�޶� ������ �� ��ũ�� ��� ��ġ�� ��� ���� �ȵǵ���
        if (EventSystem.current.IsPointerOverGameObject())
            return;

        
        if(turret != null){

            buildManager.SelectNode(this);
            return;
        }
        if (!buildManager.CanBuild)
            return;

        BuildTurret(buildManager.GetTurretToBuild());
    }

    void BuildTurret(TurretBlueprint blueprint){
        
        if (Variables.Coins < blueprint.cost)
        {
            print("not enough coins");
            return;
        }

        GameObject.Find("Shop").GetComponent<Shop>().SpendCoin(blueprint.cost);
        GameObject _turret = (GameObject)Instantiate(blueprint.prefab, GetBuildPosition(), Quaternion.identity);
        turret = _turret;

        turretBlueprint=blueprint;
        
        /*if(PlayerStat.Money < blueprint.cost){
            return;
        }
        PlayerStat.Money -= blueprint.cost;

        GameObject _turret = (GameObject)Instantiate(blueprint.prefab, GetBuildPosition(), Quaternion.identity);
        turret = _turret;

        turretBlueprint = blueprint;
        */
    }

    public void UpgradeTurret(){
      
        if (Variables.Coins < turretBlueprint.upgradeCost)
        {
            print("not enough coins");
            return;
        }

        GameObject.Find("Shop").GetComponent<Shop>().SpendCoin(turretBlueprint.upgradeCost);

        //get rid of old turret
        Destroy(turret);


        //Build a new one
        GameObject _turret = (GameObject) Instantiate(turretBlueprint.upgradedPrefab, GetBuildPosition(), Quaternion.identity);
        turret=_turret;

        isUpgraded=true;
        
        /*if (PlayerStat.Money < turretBlueprint.upgradeCost)
		{
			Debug.Log("Not enough money to upgrade that!");
			return;
		}

		PlayerStat.Money -= turretBlueprint.upgradeCost;

		//Get rid of the old turret
		Destroy(turret);

		//Build a new one
		GameObject _turret = (GameObject)Instantiate(turretBlueprint.upgradedPrefab, GetBuildPosition(), Quaternion.identity);
		turret = _turret;
         
        isUpgraded=true;
        */
    }
    

    void OnMouseEnter(){

        //ī�޶� ������ �� ��ũ�� ��� ��ġ�� ��� ���� �ȵǵ���
        if (EventSystem.current.IsPointerOverGameObject())
            return;

       //������ �ͷ��� ���� ���� ��� ���̶���Ʈ
        if (!buildManager.CanBuild)
            return;
        if(Variables.Coins >= turretBlueprint.cost){
            rend.material.color = hoverColor;
        }
        
    }

    void OnMouseExit(){

        rend.material.color = startColor;
    }
}
