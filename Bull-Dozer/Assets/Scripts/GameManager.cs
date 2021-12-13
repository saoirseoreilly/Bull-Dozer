using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public float pointIncreasedPerSecond;
    public float score;

    
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    // Start is called before the first frame update
    void Start()
    {
    
        score = 1f;
        pointIncreasedPerSecond = 1f;


        
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + (int)score;
        score += pointIncreasedPerSecond * Time.deltaTime;


    }

    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);

    }
  
}
