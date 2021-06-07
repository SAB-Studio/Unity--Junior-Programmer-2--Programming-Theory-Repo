using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif


public class GameManager : MonoBehaviour
{
    private int m_SceneNumber = 1;// ENCAPSULATION
    public int sceneNumber//
    { //
        get { return m_SceneNumber; }//
        set //
        {//
            if (value < 0.0f)//
            {//
                Debug.LogError("You can't set a negative scene number!");//
            }//
            else//
            {//
                m_SceneNumber = value; // original setter now in if/else statement
            }//
        }//
    }//

    public void StartGame()// ABSTRACTION
    {
        SceneManager.LoadScene(m_SceneNumber);
    }

    public void QuitGame()// ABSTRACTION
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }
}