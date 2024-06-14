using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class woodWallDestroy : MonoBehaviour
{
    int woodWallHealth = 20;
	private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "mimiBird(Clone)")
        {
            woodWallHealth -= 10;
            if(woodWallHealth <= 0){
            Destroy(gameObject);
            }
        }

    }
    void OnCollisionStay2D(Collision2D collision)
    {
        woodWallHealth-=0;
    }
}
