using UnityEngine;
using TMPro;

public class SnakeControl : MonoBehaviour
{
    public int points = 0;
    [SerializeField][Range(0.01f, 5)] float speed = 0.1f;
    [SerializeField] TextMeshProUGUI pointsText;
    private Control control;
    private EatControl eatControl;

    bool isAlive = true;

    private void Awake()
    {
        control = new Control();
        eatControl = GetComponent<EatControl>();
    }

    private void OnEnable()
    {
        control.Enable();
    }

    private void OnDisable()
    {
        control.Disable();
    }

    void FixedUpdate()
    {
        if (!isAlive)
            return;

        transform.position += transform.forward * speed;
        transform.Rotate(0, control.Snake.Move.ReadValue<float>() * 100 * Time.deltaTime, 0);
    }

    private void Die()
    {
        isAlive = false;
        eatControl.Reset();
        transform.position = new Vector3(0, 2, 0);
        speed = 0.12f;
        pointsText.text = "U ded, 0p";
        isAlive = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Apple"))
        {
            points += 1;
            speed += 0.02f;
            pointsText.text = "Points: " + points;
            eatControl.Addbody();
            AppleGenerator.Instance.AppleEaten();
        }
        else if (other.CompareTag("Dead"))
            Die();
    }
}
