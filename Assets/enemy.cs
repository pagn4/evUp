using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class enemy : MonoBehaviour
{
    //public int y;
    public float speed;
	public bool MoveRight;
	void Update () {
		
		if(MoveRight) {
			transform.Translate(2* Time.deltaTime * speed, 0,0);
			transform.localScale= new Vector2 (1,1);
 		}
		else{
			transform.Translate(-2* Time.deltaTime * speed, 0,0);
			transform.localScale= new Vector2 (-1,1);
		}
	}
	void OnTriggerEnter2D(Collider2D trig){
            if (MoveRight){
				MoveRight = false;
			}
			else{
				MoveRight = true;
			}	
         
	}
}
