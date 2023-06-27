using Unity.VisualScripting;
using UnityEngine;

public class DeathRespawn : MonoBehaviour
{
    public GameObject Player;
    public float RespawnDelay;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Killing"))
        {
            Player.SetActive(false);
            Player.transform.position = new Vector2(-11.5f, -5f);
            Invoke("Respawn", RespawnDelay);
        }
    }
    private void Respawn()
    {
        Player.SetActive(true);
    }
}
