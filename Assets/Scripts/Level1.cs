using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1 : MonoBehaviour
{
    public void loadLevel1()
    {
        SceneManager.LoadSceneAsync(2);
    }
}
