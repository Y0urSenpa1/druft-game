using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuOnOff : MonoBehaviour
{
    public GameObject Menu1;
    public GameObject Menu2;
    public GameObject CanvasMenu1;
    public GameObject CanvasMenu2;
    
    public void MenuOnandOff()
    {
        Menu1.SetActive(false);
        Menu2.SetActive(true);
        CanvasMenu1.SetActive(false);
        CanvasMenu2.SetActive(true);
    }
}
