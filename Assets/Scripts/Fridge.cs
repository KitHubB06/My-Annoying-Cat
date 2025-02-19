using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fridge : MonoBehaviour
{
    public GameObject PanelFridge;
    private bool isActivePanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OpenFridge()
    {
        isActivePanel = !isActivePanel;
        PanelFridge.SetActive(isActivePanel);
    }
}
