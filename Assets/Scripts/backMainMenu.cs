using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backMainMenu : MonoBehaviour
{
    public void backMain()
    {
        SceneManager.LoadSceneAsync(0);
    }
}
