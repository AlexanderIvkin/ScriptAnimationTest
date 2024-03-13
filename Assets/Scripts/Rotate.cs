using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] private float _speed = 0f;

    private void Start()
    {

    }

    private void Update()
    {
        transform.Rotate(Vector3.up, _speed * Time.deltaTime);
    }
}
