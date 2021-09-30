using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public GameObject CursorObject;

    public void Awake()
    {
        CursorObject = GameObject.Find("Cursor");
    }


    public void OnButtonClick(Button button)
    {
        //button.gameObject.transform.GetChild(0).name;
        ClearCursor();

        GameObject o = GameObject.Instantiate(button.gameObject.transform.GetChild(0).gameObject);
        o.transform.SetParent(CursorObject.transform);
        o.transform.localPosition = Vector3.zero;
        o.transform.localScale = new Vector3(1,1,1);
        //Debug.Log(button.gameObject.transform.GetChild(0).name);
    }



    public void ClearCursor()
    {
        foreach (Transform child in CursorObject.transform)
        {
            GameObject.Destroy(child.gameObject);
        }
    }
}
