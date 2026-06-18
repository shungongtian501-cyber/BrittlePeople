using UnityEngine;

public class LeftLegController : MonoBehaviour
{
    [SerializeField] private float rotatePower = 0.1f;
    [SerializeField] private float scalePower = 0.01f;

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 0, rotatePower);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, 0, -rotatePower);
        }
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 scale = transform.localScale;
            scale.y += scalePower;
            scale.y = Mathf.Clamp(scale.y, 0.1f, 3f);
            transform.localScale = scale;
        }

        if (Input.GetKey(KeyCode.S))
        {
            Vector3 scale = transform.localScale;
            scale.y -= scalePower;
            scale.y = Mathf.Clamp(scale.y, 0.1f, 3f);
            transform.localScale = scale;
        }
    }
}