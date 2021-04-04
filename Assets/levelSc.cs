using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelSc : MonoBehaviour
{
    public void back(){
        SceneManager.LoadScene("title");
    }
    public void level1(){
        SceneManager.LoadScene("level1");
    }
}
