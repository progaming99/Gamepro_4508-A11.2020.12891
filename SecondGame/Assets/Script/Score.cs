using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public GameOverScreen GameOverScreen;
    int maxPlatform = 0;

    public void GameOver() {
        GameOverScreen.Setup(maxPlatform);
    }
    
    public Text MyScoreText;
    private int ScoreNumb;
    // Start is called before the first frame update
    void Start()
    {
        ScoreNumb = 0;
        MyScoreText.text = "Score : " + ScoreNumb;
    }
    
    private void OnTriggerEnter2D(Collider2D Coin)
    {
        if(Coin.tag == "MyCoin")
        {
            ScoreNumb += 1;
            Destroy(Coin.gameObject);
            MyScoreText.text = "Score : " + ScoreNumb;
        }
    }
}
