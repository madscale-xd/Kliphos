using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTracker : MonoBehaviour
{
    public int userLevel;

    void Start()
    {
        // Load the user's progress from PlayerPrefs when the game starts
        userLevel = PlayerPrefs.GetInt("UserProgress", 0);
    }

    public void SaveProgress()
    {
        // Save the user's progress to PlayerPrefs
        PlayerPrefs.SetInt("UserProgress", userLevel);
        PlayerPrefs.Save(); // This line is optional, but ensures data is saved immediately
    }

    public void UpdateLevel(int amount)
    {
        if (amount < userLevel)
        {
            // You can add additional logic here if needed
        }
        else
        {
            userLevel = amount;
        }
        SaveProgress();
    }

    public int ReturnLevel()
    {
        // Return the current level saved in PlayerPrefs
        return PlayerPrefs.GetInt("UserProgress", 0);
    }

    public void ResetLevel()
    {
        // Set the current level saved in PlayerPrefs to 0
        PlayerPrefs.SetInt("UserProgress", 0);
        PlayerPrefs.Save(); // This line is optional, but ensures data is saved immediately
        userLevel = 0; // Also update the in-memory userLevel variable
    }
}
