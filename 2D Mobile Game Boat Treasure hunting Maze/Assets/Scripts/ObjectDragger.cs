using UnityEngine;

public class ObjectDragger : MonoBehaviour
{
    Vector3 offset;
    [SerializeField]
    PlayerAttributes playerAttributes;
    Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }
    private void OnMouseDown()
    {
        //calculate the offset between mouse click and transform
        Vector3 mousedown_position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousedown_position.z = transform.position.z;

        offset = mousedown_position - transform.position;
    }

    private void OnMouseDrag()
    {
        Vector3 new_position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        new_position.z = transform.position.z;
        //transform.position = new_position - offset;
        rb.AddForce(( new_position-transform.position).normalized*0.01f);
    
    }

    private void OnMouseUp()
    {
        //Debug.Log("on mouse up");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Treasures"))
        {
            Destroy(collision.gameObject);
          
            playerAttributes.GemAdd(collision.gameObject.GetComponent<Treasures>());
          
        }
    }
}
