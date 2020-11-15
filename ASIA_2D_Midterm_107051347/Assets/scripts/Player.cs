
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject final;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "傳送門")
        {
            final.SetActive(true);
        }
        if (collision.name == "鳳梨")
        {
            Destroy(collision.gameObject);
        }
    }
    

}
