using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float _speed = 0f;

    private void Start()
    {

    }

    private void Update()
    {
        transform.Translate(_speed * Time.deltaTime * Vector3.forward, Space.Self);
    }
}
