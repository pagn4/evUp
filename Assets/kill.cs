using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class kill : MonoBehaviour
{
    public int y;
    public void OnTriggerEnter2D(Collider2D player){
        SceneManager.LoadScene (y);
    }

}
