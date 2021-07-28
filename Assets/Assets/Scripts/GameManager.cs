using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public static int currentScore;
    public static int highScore;
    public static int currentLevel = 0;
    public static int unlockedLevel;


    public static void CompleteLevel()
    {

        //Application.LoadLevel(currentLevel);
        currentLevel += 1;
        SceneManager.LoadScene(currentLevel); //increment by 1 after loading a level 
                                              //currentLevel += 1;

        Debug.Log(currentLevel);

        if (currentLevel >= 2)
        {
            Debug.Log("Levels complete");
            currentLevel = 0;
        }

    }

    public void playGame()
    {
        SceneManager.LoadScene(currentLevel);
        SceneManager.UnloadScene(2);
        Debug.Log(currentLevel);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    
}
