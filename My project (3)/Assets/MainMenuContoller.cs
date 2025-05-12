using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuController : MonoBehaviour
{
    [Header("Levels To Load")]
    public string Game1;
    public string Game2;
    public string Game3;
    private string levelToLoad;
    [SerializeField] private GameObject noSavedGameDialog = null;

    public void NewGameENGYes()
    {
        SceneManager.LoadScene("Game1");
    }

    public void NewGameSciYes()
    {
        SceneManager.LoadScene("Game2");
    }

    public void NewGameMathYes()
    {
        SceneManager.LoadScene("Game3");
    }

    public void LoadGameSciYes()
    {
        if (PlayerPrefs.HasKey("SavedLevelSci"))
        {
            levelToLoad = PlayerPrefs.GetString("SavedLevelSci");
            SceneManager.LoadScene(levelToLoad);
        }
        else
        {
            noSavedGameDialog.SetActive(true);
        }
    }
    public void LoadGameMathYes()
    {
        if (PlayerPrefs.HasKey("SavedLevelMath"))
        {
            levelToLoad = PlayerPrefs.GetString("SavedLevelMath");
            SceneManager.LoadScene(levelToLoad);
        }
        else
        {
            noSavedGameDialog.SetActive(true);
        }
    }
    public void LoadGameENGYes()
    {
        if (PlayerPrefs.HasKey("SavedLevelENG"))
        {
            levelToLoad = PlayerPrefs.GetString("SavedLevelENG");
            SceneManager.LoadScene(levelToLoad);
        }
        else
        {
            noSavedGameDialog.SetActive(true);
        }
    }
    public void OnSettingsClick()
    {
        SceneManager.LoadScene("Settings Scene");
    }
    public void OnExitClick()
    {
        Application.Quit();
    }

    public Slider masterVol, musicVol, sfxVol;
    public AudioMixer mainAudioMixer;

    public void ChangeMasterVolume()
    {
        mainAudioMixer.SetFloat("MainVol", masterVol.value);
    }
    public void ChangeMusicVolume()
    {
        mainAudioMixer.SetFloat("MusicVol", musicVol.value);
    }
    public void ChangeSFXVolume()
    {
        mainAudioMixer.SetFloat("SFXVol", sfxVol.value);
    }
}