using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateBreadcrumps : MonoBehaviour
{


    string ItemGrandParent = "Campus HS Ansbach";

    public Button GrandParent;

    public string ItemParent;

    public string ItemChild;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void CreateBreadcrump()
    {
        GrandParent.gameObject.GetComponentInChildren<UnityEngine.UI.Text>().text = ItemGrandParent;
        Debug.Log(GrandParent.GetComponentInChildren<UnityEngine.UI.Text>().text);
        
    }
}
