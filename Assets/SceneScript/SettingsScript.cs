using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsScript : MonoBehaviour
{
    public GameObject panel;
    public void Settings()
    {
        SceneManager.LoadScene(4);
    }
}
