using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stoneWallDestroy : MonoBehaviour
{
    int stoneWallHealth = 30;
	private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "mimiBird(Clone)")
        {
            stoneWallHealth -= 10;
            if(stoneWallHealth <= 0){
            Destroy(gameObject);
            }
        }

    }
    void OnCollisionStay2D(Collision2D collision)
    {
        stoneWallHealth-=0;
    }
}
