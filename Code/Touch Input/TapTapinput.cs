using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TapTapinput : MonoBehaviour
{
    private GameObject gameover_menu;
    private Text scores;
    private float velocity = 2.4f;
    private int score;
    private Rigidbody2D rigidbody2d;

    // Start is called before the first frame update
    void Start()
    {
        scores =  GameObject.Find("score").GetComponent<Text>();
        (gameover_menu) = GameObject.Find("GameOver");
        score = 0;
        rigidbody2d = GetComponent<Rigidbody2D>();
        gameover_menu.SetActive(false);
        rigidbody2d.rotation = 45f;
    }


    void Update()
    {
        // rigidbody2d.rotation = 
        if(Input.GetMouseButtonDown(0))
        {
            rigidbody2d.velocity = Vector2.up * velocity;
        }
        
    }
    void FixedUpdate()
    {
        rigidbody2d.rotation -= 3.0f;
    }
    void OnTriggerEnter2D(Collider2D col)    
    {
        if (col.tag=="blue")
        {
            score++;
            scores.text = score.ToString();
            Destroy(col.gameObject);
            // gameover_menu.SetActive(true);


            // gameover_menu.SetActive(true);
            // Time.timeScale = 0;
        }
        else if(col.gameObject.tag=="Red")
        {
            gameover_menu.SetActive(true);
            Time.timeScale = 0;
             Handheld.Vibrate();
             
        }
    }
}