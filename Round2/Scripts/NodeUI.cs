using UnityEngine;

public class NodeUI : MonoBehaviour
{
    public GameObject ui;
    private Node target;

    public void SetTarget(Node _target){
        this.target = _target;

        transform.position = target.GetBuildPosition();

        ui.SetActive(true);
    }   

    public void Hide(){
        ui.SetActive(false);
    }

    public void Upgrade(){
        target.UpgradeTurret();
        BuildManager.instance.DeselectNode();
    }


}
