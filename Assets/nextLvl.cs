using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class nextLvl : MonoBehaviour
{
    public int x;
    public void  OnTriggerEnter2D (Collider2D other){
        SceneManager.LoadScene (x);
    }
}
