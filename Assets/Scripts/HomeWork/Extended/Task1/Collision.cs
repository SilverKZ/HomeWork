using UnityEngine;

public class Collision : MonoBehaviour
{
    [SerializeField] private Transform _sphere;
    [SerializeField] private MeshRenderer _meshRenderer;

    private Vector3 _bulletPreviousPosition;

    private void Start()
    {
        _meshRenderer.material.color = Color.green;
        _bulletPreviousPosition = _sphere.position;
    }

    private void Update()
    {
        if (_bulletPreviousPosition != _sphere.position)
        {
            _bulletPreviousPosition = _sphere.position;
            _meshRenderer.material.color = OnCollisionObject(_sphere) ? Color.red : Color.green;
        }
    }

    private bool OnCollisionObject(Transform sphere)
    {
        float enemyRadius = transform.localScale.x / 2;
        float bulletRadius = sphere.localScale.x / 2;
        float magnitude = (transform.position - sphere.position).magnitude;
        float distance = magnitude - enemyRadius - bulletRadius;
        return distance <= 0;
    }
}
