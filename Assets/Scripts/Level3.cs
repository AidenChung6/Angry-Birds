using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level3 : MonoBehaviour
{
    public void loadLevel3()
    {
        SceneManager.LoadSceneAsync(4);
    }
}
