using UnityEngine;

public class Scale : MonoBehaviour
{
    [SerializeField] private float _speed = 0f;
    private float _offset;

    private void Start()
    {
        _offset = _speed * Time.deltaTime;
    }

    private void Update()
    {

        transform.localScale += transform.localScale * _offset;
    }
}
