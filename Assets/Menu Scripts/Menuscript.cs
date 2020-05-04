using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menuscript : MonoBehaviour
{

    public GameObject BoutonsNiveau;
    public GameObject BoutonsOption;
    public GameObject BoutonsPrincipaux;

    public void SceneLoader(int SceneIndex) {
        SceneManager.LoadScene(SceneIndex);
    }

    public void CacherNiveau() {
        BoutonsNiveau.SetActive(false);
    }

    public void CacherOptions() {
        BoutonsOption.SetActive(false);
    }

    public void CacherPrincipaux() {
        BoutonsPrincipaux.SetActive(false);
    }

    public void AfficherPrincipaux() {
        BoutonsPrincipaux.SetActive(true);
    }

    public void AfficherNiveau() {
        BoutonsNiveau.SetActive(true);
    }

    public void AfficherOptions() {
        BoutonsOption.SetActive(true);
    }
}
