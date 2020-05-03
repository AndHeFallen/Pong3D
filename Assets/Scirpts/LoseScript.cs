using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseScript : MonoBehaviour
{
    public void SceneLoader(int SceneIndex) {
        SceneManager.LoadScene(SceneIndex);
    }
}
