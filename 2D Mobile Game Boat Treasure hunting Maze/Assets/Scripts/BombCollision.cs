using UnityEngine;

public class  BombCollision : MonoBehaviour
{
    [SerializeField] GameObject Explosion;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ship-Player"));
        {

            Destroy(gameObject);
            Destroy(collision.gameObject);

            Debug.Log("Bomb Went Off ,Ship Sank");
            Explosion.SetActive(true);
           
            //Add Explosion prefab
            //Add Physical Blast?    
        }
    }

}
