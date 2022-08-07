using UnityEngine;

public class  BombCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ship-Player"));
        {

            Destroy(gameObject);
            Destroy(collision.gameObject);

            Debug.Log("Bomb Went Off ,Ship Sank");
           //Add Explosion Sprite
           //Add Explosion SFX
          //Add Physical Blast?
        }

    }
}
