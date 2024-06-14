using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class glassWallDestroy : MonoBehaviour
{
    int glassWallHealth = 10;
	private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "mimiBird(Clone)")
        {
            glassWallHealth -= 10;
            if(glassWallHealth <= 0){
            Destroy(gameObject);
            }
        }

    }
    void OnCollisionStay2D(Collision2D collision)
    {
        glassWallHealth-=0;
    }
}
