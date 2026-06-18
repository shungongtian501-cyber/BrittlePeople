using UnityEngine;

public class BodyController : MonoBehaviour
{
    void Update()
    {
        transform.rotation =
            Quaternion.Lerp(
                transform.rotation,
                Quaternion.identity,
                2f * Time.deltaTime);
    }
}