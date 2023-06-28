using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTransition : MonoBehaviour
{
    private string sceneName;
    private int levelToLoad;
    private GameObject FinishObj;
    // private int levelToLoad;


    private void Start()
    {
        FinishObj = GameObject.FindGameObjectWithTag("Finish");
    }

    private void _LevelTransition(int levelToLoad)
    {
        SceneManager.LoadScene("level" + levelToLoad);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("Player"))
        {
            if (FinishObj.layer == LayerMask.NameToLayer("FinishLevel1"))
            {
                SceneManager.LoadScene("Level2");
            }
            if (FinishObj.layer == LayerMask.NameToLayer("FinishLevel2"))
            {
                SceneManager.LoadScene("Level3");
            }

        }
        //private void OnTriggerStay2D(Collider2D collision)
        //{
        //sceneName = SceneManager.GetActiveScene().name;
        //var level = ((sceneName)[5]);
        // Debug.Log(level);


        //}
        // }
    }
}
