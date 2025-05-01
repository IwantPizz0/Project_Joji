using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public LayerMask playerLayer; 
    public string sceneToLoad = "lvl2"; 

    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        if (((1 << collision.gameObject.layer) & playerLayer) != 0)
        {
           
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
