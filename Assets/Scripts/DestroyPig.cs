using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPig : MonoBehaviour
{

	private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "mimiBird(Clone)")
        {
            Destroy(gameObject);
        }
    }

}
