using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public int KeyCounter;
    public bool WantToTake = false;

    void Start()
    {

    }
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Key1"))
        {
            if (WantToTake)
            {
                Destroy(collision.gameObject);
                KeyCounter += 1;
                Debug.Log("Keys U Have: " + KeyCounter);
            }
        }
    }
}
