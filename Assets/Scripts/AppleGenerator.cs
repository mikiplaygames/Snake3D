using UnityEngine;

public class AppleGenerator : MonoBehaviour
{
    public static AppleGenerator Instance { get; private set; }

    [SerializeField] GameObject apple;
    [SerializeField] GameObject ground;

    private GameObject thisApple;

    private float groundSize;

    private void Awake()
    {
        groundSize = ground.transform.localScale.x*5;
        groundSize -= 2;

        if (Instance == null)
            Instance = this;
    }
     // Start is called before the first frame update
    private void Start()
    {
        thisApple = Instantiate(apple, new Vector3(Random.Range(-groundSize, groundSize), 1.5f, Random.Range(-groundSize, groundSize)), Quaternion.identity);
    }

    public void AppleEaten()
    {
        thisApple.transform.position = NewApplePos();
    }

    private Vector3 NewApplePos()
    {
        return new Vector3(Random.Range(-groundSize, groundSize), 1.5f, Random.Range(-groundSize, groundSize));
    }
}
