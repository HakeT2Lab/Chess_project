using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NGameButton : MonoBehaviour
{
  public void ButtonMoveScene(string scene){
    SceneManager.LoadScene(scene);
  }
}
