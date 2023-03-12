using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
  public void GoToScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

  
}
