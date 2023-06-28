using UnityEngine;

public class DeathRespawn : MonoBehaviour
{
    public GameObject Player;

    public GameObject EffectDie;
    public GameObject EffectAlive;
    public GameObject GrobRip;
    private Animator camAnim;

    public float RespawnDelay;
    private void Start()
    {
        camAnim = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Animator>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Killing"))
        {
            Instantiate(EffectDie, transform.position, Quaternion.identity);
            camAnim.SetTrigger("Shake");
            Player.SetActive(false);
            Instantiate(GrobRip, transform.position, Quaternion.Euler(0, 0, Random.Range(0f, 360f)));
            Player.transform.position = new Vector2(-11.5f, -5f);
            Invoke("Respawn", RespawnDelay);
        }
    }
    private void Respawn()
    {
        Player.SetActive(true);
        camAnim.SetTrigger("Shake");
        Instantiate(EffectAlive, transform.position, Quaternion.identity);
    }
}
