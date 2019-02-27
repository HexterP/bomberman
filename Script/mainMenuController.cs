using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mainMenuController : MonoBehaviour
{

    public GameObject main_menu;
    public GameObject joystick;
    public GameObject score_area;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playgame()
    {
        main_menu.SetActive(false);
        joystick.SetActive(true);
        score_area.SetActive(true);
    }
}
