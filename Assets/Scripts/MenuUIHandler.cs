using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIHandler : MonoBehaviour
{
    private string userName;
    public TextMeshProUGUI bestScoreText;

    private void Start()
    {
        bestScoreText.text = "Best Score: " + DataManager.Instance.bestScoreUserName + "   -   " + DataManager.Instance.bestScore;
    }

    public void GetUserName(string s)
    {
        userName = s;
        Debug.Log(userName);
        DataManager.Instance.userName = userName;
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void OpenLeaderBoard()
    {
        SceneManager.LoadScene(2);
    }

    public void BackToMenu()
    { SceneManager.LoadScene(0);}

    public void Exit()
    {
#if (UNITY_EDITOR)
        {
            EditorApplication.ExitPlaymode();
        }

#else
        {
                Application.Quit();

        }

#endif
    }

}
