using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIHandler : MonoBehaviour
{
    private string userName;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
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
