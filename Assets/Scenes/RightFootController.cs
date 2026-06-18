using UnityEngine;

public class RightLegController : MonoBehaviour
{
    [SerializeField] private float rotatePower = 0.1f;
    [SerializeField] private float scalePower = 0.01f;
    private void Start()
    {
      
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 0, rotatePower);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, 0, -rotatePower);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 scale = transform.localScale;
            scale.y += scalePower;
            scale.y = Mathf.Clamp(scale.y, 0.1f, 3f);
            transform.localScale = scale;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            Vector3 scale = transform.localScale;
            scale.y -= scalePower;
            scale.y = Mathf.Clamp(scale.y, 0.1f, 3f);
            transform.localScale = scale;
        }
    }

}