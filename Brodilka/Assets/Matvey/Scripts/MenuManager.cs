using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject TunnelSound;
    private Animator camAnim;
    public GameObject Effect;
    private void Start()
    {
        camAnim = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Animator>();
    }
    public void StartGame()
    {
        Instantiate(Effect);
        Invoke("SceneTransition", 3f);
        camAnim.SetTrigger("GameStarted");
    }
    private void SceneTransition()
    {
        SceneManager.LoadScene("Level1");
    }
}
