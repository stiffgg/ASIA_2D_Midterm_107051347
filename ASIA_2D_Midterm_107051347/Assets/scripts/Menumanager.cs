using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menumanager : MonoBehaviour
{
    public void Startgame()
    {
        print("開始遊戲");
        SceneManager.LoadScene("關卡");
    }
    public void Quitgame()
    {
        print("離開遊戲");
        Application.Quit();
    }

}
