using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// era pra ser uma forma de mudar de cena, mas só serviu pra mudar de cena no menu
public class ChangeScene : MonoBehaviour
{
    public void ChangeToScene(int sceneToChangeTo)
    {
        SceneManager.LoadScene(sceneToChangeTo);
    }
}
