using System.Collections;
using System.Collections.Generic;
using DTT.MinigameBase.Advertisements;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FinishScene : MonoBehaviour
{
    public void FinishButton()
    {
       SceneManager.UnloadSceneAsync("MiniGame"); //Upload scene with name "MiniGame"
    }
}
