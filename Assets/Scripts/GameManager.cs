using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject completeLevelUI;
    public Text scoreText;

    // Start is called before the first frame update
    public void EndGame()
    {
        float restartDelay = 2f;
        bool isGameOver = false;

        if (isGameOver == false)
        {
            Debug.Log("Game Over");
            isGameOver = true;
            Invoke("Restart", restartDelay);
        }
    }

    public void CompleteLevel()
    {
        scoreText.text = FindObjectOfType<Score>().scoreText.text;
        completeLevelUI.SetActive(true);
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
