using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    private void Start()
    {
        Cursor.visible = true;
    }
    public void Play()
    {
        SceneManager.LoadScene("ForestLevel");
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void OpenYoutube()
    {
        Application.OpenURL("https://www.youtube.com/channel/UCQZRNVCPNrmQvnDxwXi_pPQ?view_as=subscriber");
    }
}
