using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSc : MonoBehaviour
{
    public void Play(){
        SceneManager.LoadScene("level");
    }
    public void Exit(){
        Application.Quit();
    }
}
