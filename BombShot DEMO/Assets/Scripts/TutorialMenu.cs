using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialMenu : MonoBehaviour
{
    public void StarGame()
    {
        SceneManager.LoadScene("Scenes/Tutorial");
    }
}
