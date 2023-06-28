using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTransition : MonoBehaviour
{
    private string sceneName;
    private int levelToLoad;
    

    private void Start()
    {
        sceneName = SceneManager.GetActiveScene().name;
        var level = ((sceneName)[5]);
        levelToLoad = (int)level - 47;
        Debug.Log(level);
        Debug.Log(levelToLoad);
    }
    private void _LevelTransition()
    {
        SceneManager.LoadScene("level" + levelToLoad);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Finish"))
        {
            Debug.Log(levelToLoad);
            _LevelTransition();
        }
    }
}
