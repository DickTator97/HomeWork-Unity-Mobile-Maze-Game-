using UnityEngine;

public class ObjectDragger : MonoBehaviour
{
    Vector3 offset;



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
        transform.position = new_position - offset;
    }

    private void OnMouseUp()
    {
        //Debug.Log("on mouse up");
    }

}
