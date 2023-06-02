using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class navigate : MonoBehaviour
{
    public void main_page ()
    {
        SceneManager.LoadScene(0);
    }
    public void animal_page ()
    {
        SceneManager.LoadScene(1);
    }
    public void galaxy_page ()
    {
        SceneManager.LoadScene(2);
    }
    public void about_page ()
    {
        SceneManager.LoadScene(3);
    }
    public void ar_cam ()
    {
        SceneManager.LoadScene(4);
    }
    public void quit_it ()
    {
        Debug.Log("QUIT");
        Application.Quit(0);
    }
}
