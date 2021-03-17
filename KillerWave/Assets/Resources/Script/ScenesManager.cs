using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ScenesManager : MonoBehaviour
{
    Scenes scenes;
    public enum Scenes
    {
        bootUp,
        title,
        shop,
        level1,
        level2,
        level3,
        gameOver,
    }

    //Reset Scene - when the player loses a life but has another remaining
    public void ResetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    //Game Over Method - when player has no more lives and game ends
    public void GameOver()
    {
        SceneManager.LoadScene("gameOver");
    }

    //Begin Game - needed when we start playing our game
    public void BeginGame()
    {
        SceneManager.LoadScene("testLevel");
    }

}
