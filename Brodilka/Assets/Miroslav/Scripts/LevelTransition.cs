using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTransition : MonoBehaviour
{

    private GameObject FinishObj;

    private void Start()
    {
        FinishObj = GameObject.FindGameObjectWithTag("Finish");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("Player"))
        {
            if (FinishObj.layer == LayerMask.NameToLayer("FinishLevel1"))
            {
                SceneManager.LoadScene("Level2");
            }
            else if (FinishObj.layer == LayerMask.NameToLayer("FinishLevel2"))
            {
                SceneManager.LoadScene("Level3");
            }
            else if (FinishObj.layer == LayerMask.NameToLayer("FinishLevel3"))
            {
                SceneManager.LoadScene("Level4");
            }



        }
    }
}
