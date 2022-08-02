using UnityEngine;

public class ShipCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Bomb")) ;
        {

            Destroy(collision.gameObject);
            Destroy(gameObject);

            Debug.Log("Hit");
        }

    }


}
