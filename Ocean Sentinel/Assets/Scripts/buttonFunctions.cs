﻿using UnityEngine;
using UnityEngine.SceneManagement;

//this script will give buttons things to do when clicked.;

public class buttonFunctions : MonoBehaviour {

	public void startGame() //this function is used to load the game scene.
    {                       //this function will also be used for the restart button.
        SceneManager.LoadScene("Game");
    }

    public void viewBoard() //this function is used to load the leaderboard scene.
    {
        SceneManager.LoadScene("Leaderboard");
    }

    public void returnTitle()
    {
        SceneManager.LoadScene("Main");
    }

    public void viewControls()
    {
        SceneManager.LoadScene("Controls");
    }

    public void exitGame() //this function is used to exit the game.
    {
        Application.Quit();
    }
}