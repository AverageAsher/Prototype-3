using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        // Move the object to the left by translating it based on the speed variable and time
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}
