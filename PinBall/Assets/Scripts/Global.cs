using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Global : MonoBehaviour
{
    public static int GameScore = 0;
    public static int BallCount = 5;

    [SerializeField] private Text gameScoreTXT;
    [SerializeField] private Text ballCountTXT;
    [SerializeField] private GameObject gameOverBG;
    [SerializeField] private Text resultTXT;

    private void FixedUpdate()
    {
        gameScoreTXT.text = $"{GameScore}";
        ballCountTXT.text = $"{BallCount}";
    }
    public void GameOver()
    {
        gameOverBG.SetActive(true);
        resultTXT.text = $"RESULT: {GameScore} POINTS";
    }

    public void Restart()
    {
       GameScore = 0;
       BallCount = 5;
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void CloseGame()
    {
        Application.Quit();
    }
}



