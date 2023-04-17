using System.Collections.Generic;
using UnityEngine;

public class EatControl : MonoBehaviour
{
    [SerializeField] GameObject bodySegment;
    [SerializeField] private List<GameObject> segments;
    [SerializeField] private GameObject lastBody;

    private GameObject snakeBody;

    private void Awake()
    {
        segments = new List<GameObject>();
        snakeBody = lastBody;
    }

    public void Addbody()
    {
        var spawnedPart = Instantiate(bodySegment, lastBody.transform.position - (lastBody.transform.forward * 2), lastBody.transform.rotation);
        //spawnedPart.transform.parent = this.transform;

        spawnedPart.GetComponent<HingeJoint>().connectedBody = lastBody.GetComponentInParent<Rigidbody>();

        segments.Add(spawnedPart);

        lastBody = spawnedPart;
    }

    public void Reset()
    {
        foreach (var item in segments)
        {
            Destroy(item);
        }
        segments.Clear();
        lastBody = snakeBody;
    }
}
