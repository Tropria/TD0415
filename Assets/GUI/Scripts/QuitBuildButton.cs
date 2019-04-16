using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Settings;

public class QuitBuildButton : MonoBehaviour
{

    private Text text;
    //private GameObject _turretPrefab;
    //private int _turretPrice;
    private string turretName;


    private void Awake()
    {
        text = this.gameObject.GetComponentInChildren<Text>();

        if (!text)
        {
            Debug.LogError("Object with TurretButton script should have a Text component on one of the children");
        }
    }

    public void Init()
    {
        
        this.turretName = "quit";
        

        text.text = turretName ;
    }

    private void SetEnabled(bool enabled)
    {
        this.enabled = enabled;
        text.color = enabled ? Color.black : Color.gray;
    }
}
