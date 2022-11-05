using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStartMAnger : MonoBehaviour
{
    public static int PlayerNumber;
    public static int MapsNumber;
    public GameObject MapSelectMenu;
    public GameObject PlayerSelectMenu;
    public GameObject AllSelect;
    public GameObject settings;

    void Start()
    {
        PlayerNumber = 1;
        MapsNumber = 1;
    }

    void Update()
    {
        
    }
//  Game Setting and Play
    public void player(){
        AllSelect.SetActive(false);
        PlayerSelectMenu.SetActive(true);
    }
    public void play(){
        SceneManager.LoadScene(0);
    }
    public void Setting(){
        AllSelect.SetActive(false);
        PlayerSelectMenu.SetActive(false);
        // settings.SetActive(true);
        Time.timeScale = 0;
    }
// END CODE 

// PlayerSelect Code
    public void bts_palyer1(){
        PlayerNumber = 1;
        AllSelect.SetActive(true);
        PlayerSelectMenu.SetActive(false);
    }
    public void bts_palyer2(){
        PlayerNumber = 2;
        AllSelect.SetActive(true);
        PlayerSelectMenu.SetActive(false);
    }
    public void bts_palyer3(){
        PlayerNumber = 3;
        AllSelect.SetActive(true);
        PlayerSelectMenu.SetActive(false);
    }
    public void bts_palyer4(){        
        PlayerNumber = 4;
        AllSelect.SetActive(true);
        PlayerSelectMenu.SetActive(false);
    }
    public void bts_palyer5(){
        PlayerNumber = 5;
        AllSelect.SetActive(true);
        PlayerSelectMenu.SetActive(false);
    }
// END CODE

// MAPS SELECTING
    public void btsMap1(){
        MapsNumber = 1;
        AllSelect.SetActive(false);
        MapSelectMenu.SetActive(true);
    }
    public void btsMap2(){
        MapsNumber = 2;
        AllSelect.SetActive(false);
        MapSelectMenu.SetActive(true);
    }
    public void btsMap3(){
        MapsNumber = 3;
        AllSelect.SetActive(false);
        MapSelectMenu.SetActive(true);
    }
    public void btsMap4(){
        MapsNumber = 4;
        AllSelect.SetActive(false);
        MapSelectMenu.SetActive(true);
    }
    public void btsMap5(){
        MapsNumber = 5;
        AllSelect.SetActive(false);
        MapSelectMenu.SetActive(true);
    }
    public void btsMap6(){
        MapsNumber = 6;
        AllSelect.SetActive(false);
        MapSelectMenu.SetActive(true);
    }
}
