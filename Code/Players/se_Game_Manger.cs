using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class se_Game_Manger : MonoBehaviour
{
    public GameObject pause;
    public GameObject porint;
    public GameObject Pause_Meun;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
}
    public void peues(){
        Time.timeScale = 0;
        porint.SetActive(false);
        pause.SetActive(false);
        Pause_Meun.SetActive(true);
    }
    

    public void RESUME(){
        porint.SetActive(true);
        pause.SetActive(true);
        Pause_Meun.SetActive(false);
        Time.timeScale = 1;
    }
    public void Restart(){
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
    public void exit(){
        Application.Quit();
    }
}
