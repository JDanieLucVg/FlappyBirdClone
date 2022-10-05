using UnityEngine;

public class backgraundRepeat : MonoBehaviour
{
    private float spriteWhit;

    void Start()
    {
        BoxCollider2D groundCollider = GetComponent<BoxCollider2D>();
        spriteWhit = groundCollider.size.x;
    }

    void Update()
    {
        if (transform.position.x < -spriteWhit)
        {
            ResetPosition();
        }
    }

    private void ResetPosition()
    {
        transform.Translate(new Vector3( 2 * spriteWhit, 0f, 0f));
    }

}
