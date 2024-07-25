using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMenu : MonoBehaviour
{
   public void PlayGame()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
        Type t = null;
        foreach (Assembly a in AppDomain.CurrentDomain.GetAssemblies())
        {
            t = a.GetType("UnityEditor.EditorApplication");
            if (t != null)
            {
                t.GetProperty("isPlaying").SetValue(null, false, null);
                break;
            }
        }
    }
}

