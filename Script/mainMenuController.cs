using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mainMenuController : MonoBehaviour
{

    public GameObject main_menu;
    public GameObject joystick;
    public GameObject score_area;
    public InputField player_name;


    public GameObject player_obj;
    public Text playername_label;


    void Start()
    {
        if (PlayerPrefs.GetString("player_name")!=null)
        {
            player_name.text = PlayerPrefs.GetString("player_name");
        }
        else
        {
            player_name.text = "player name";
        }
        
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

        playername_label.gameObject.SetActive(true);
        playername_label.text = player_name.text;

        PlayerPrefs.SetString("player_name", player_name.text);
        PlayerPrefs.Save();
    }
}
