using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float SwimSpeed = 10;
    SpriteRenderer sRenderer;

    // Use this for initialization
    void Start()
    {
        if (sRenderer == null)
        {
            sRenderer = transform.GetComponent<SpriteRenderer>();
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            sRenderer.flipX = true;
        }

        if (!Input.GetKey(KeyCode.LeftArrow))
        {
            sRenderer.flipX = false;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            transform.localPosition += Vector3.down * SwimSpeed * 0.5f;
            transform.localRotation = Quaternion.Euler(0f, 0f, -90f);
        }
        else
        {
            transform.localPosition -= Vector3.down * SwimSpeed * 0.5f;
            transform.localRotation = Quaternion.Euler(0f, 0f, 90f);
        }

        if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.Space))
        {
            transform.localPosition += Vector3.left * SwimSpeed * 0.25f;
            transform.localRotation = Quaternion.Euler(0f, 0f, 90f);
        }


        if (Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.Space))
        {
            transform.localPosition += Vector3.right * SwimSpeed * 0.25f;
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.Space))
        {
            transform.localPosition += Vector3.left * SwimSpeed * 0.25f;
            transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.Space))
        {
            transform.localPosition += Vector3.right * SwimSpeed * 0.25f;
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }

    }

    public void SetSwimSpeed(float _swimSpeed)
    {
        SwimSpeed = SwimSpeed * _swimSpeed;
    }
}
