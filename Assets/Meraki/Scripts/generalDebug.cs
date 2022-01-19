using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class generalDebug : MonoBehaviour
{
    Scene m_Scene;
    string sceneName;
    private void Start()
    {
        m_Scene = SceneManager.GetActiveScene();
        sceneName = m_Scene.name;
        AC.GlobalVariables.SetStringValue(1, sceneName);
        Debug.Log(sceneName);
    }
}
