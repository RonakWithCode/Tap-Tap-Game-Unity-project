using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Palyer_manger : MonoBehaviour
{
    int PlayerNumber;
    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public GameObject player4;
    public GameObject player5;
    // Start is called before the first frame update
    void Start()
    {
        PlayerNumber = GameStartMAnger.PlayerNumber;
        if (PlayerNumber==1)
        {
            GameObject player = Instantiate(player1);
        }else if (PlayerNumber==2)
        {
            GameObject player = Instantiate(player2);
        }
        else if (PlayerNumber==3)
        {
            GameObject player = Instantiate(player3);
        }
        else if (PlayerNumber==4)
        {
            GameObject player = Instantiate(player4);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
