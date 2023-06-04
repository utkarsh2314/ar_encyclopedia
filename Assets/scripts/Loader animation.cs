using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loaderanimation : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;

    public void main_page ()
    {
        StartCoroutine(LoadLevel(0));
    }
    public void animal_page ()
    {
        StartCoroutine(LoadLevel(1));
    }
    public void galaxy_page ()
    {
        StartCoroutine(LoadLevel(2));
    }
    public void about_page ()
    {
        StartCoroutine(LoadLevel(3));
    }
    public void ar_cam ()
    {
        StartCoroutine(LoadLevel(4));
    }

    IEnumerator LoadLevel(int LevelIndex)
    {
        transition.SetTrigger("start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(LevelIndex);
        
    }
}
