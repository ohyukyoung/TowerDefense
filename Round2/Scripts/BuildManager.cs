using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;
    GameObject Shop;
    void Awake(){
        if(instance != null){
            return;
        }
        instance = this;

    }

    public GameObject standardTurretPrefab;
    public GameObject missileLauncherPrefab;

    private TurretBlueprint turretToBuild;
    private Node selectedNode;

    public NodeUI nodeUI;
    
    public bool CanBuild { get { return turretToBuild != null; } } 
    //public bool HasMoney{get {return PlayerStat.Money >= turretToBuild.cost;}}

    

    public void SelectNode(Node node){

        if(selectedNode == node){
            DeselectNode();
            return;
        }

        selectedNode=node;
        turretToBuild=null;

        nodeUI.SetTarget(node);
    }
    public void DeselectNode(){
        selectedNode = null;
        nodeUI.Hide();
    }
    public void SelectTurretToBuild(TurretBlueprint turret)
    {
        turretToBuild = turret;
        DeselectNode();
    }

    public TurretBlueprint GetTurretToBuild(){
        return turretToBuild;
    }

}
