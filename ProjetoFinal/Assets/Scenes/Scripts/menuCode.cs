using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuCode : MonoBehaviour
{
    public void GoToScene(string sceneName)
    {
        Time.timeScale = 0;
        SceneManager.LoadScene(sceneName);
        //lemenu.OnDestroy();
    }

    public void QuitApp()
    {
        Debug.Log("Application has quit.");
        Application.Quit();
    }
}
