using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;// for increasing score input ui
using UnityEngine.SceneManagement;// for scene ending or play again type

public class LogicScript : MonoBehaviour
{
    public int scorePlyer;
    public Text textScore;
    public GameObject gameOverScreen;


    [ContextMenu("Increase Score")]//to run in unity
    public void  scoreAdd(int scoreToAdd)// for showcasing number
    {
        scorePlyer = scorePlyer + scoreToAdd;
        textScore.text = scorePlyer.ToString();//

    }
    public void restartGame()//play again after hit
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
