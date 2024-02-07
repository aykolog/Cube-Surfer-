using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
   
    public static bool finish;
    public static bool gameOver;
    public GameObject gameOverPanel;
    public GameObject finishPanel;
  

    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        Time.timeScale = 1;

        finish = false;
      
    }

    // Update is called once per frame
    void Update()
    {


        if (gameOver)
        {
            gameOverPanel.SetActive(true);
            Time.timeScale = 0;
        }
        if (finish)
        {
            finishPanel.SetActive(true);
            Time.timeScale = 0;
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        

        if(other.gameObject.CompareTag("ObstacleCube"))
        {
            gameOver = true;
        }

        if (other.gameObject.CompareTag("FinishWall"))
        {
            finish = true;
        }

    }
}
