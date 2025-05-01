using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_Play : MonoBehaviour
{
    
    public string sceneToLoad;

    
    public void PlayButton()
    {
       SceneManager.LoadScene(sceneToLoad);
    }
}