using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    [SerializeField] private float _distance;
    [SerializeField] private float _angleDegrees;
    [SerializeField] private Transform _player;
    [SerializeField] private MeshRenderer _meshRenderer;

    private Vector3 _playerPreviousPosition;

    private void Start()
    {
        _playerPreviousPosition = _player.position;
        _meshRenderer.material.color = Color.green;
    }

    private void Update()
    {
        if (_playerPreviousPosition != _player.position)
        {
            _playerPreviousPosition = _player.position;
            _meshRenderer.material.color = OnTriggerPlayer() ? Color.red : Color.green;
        }
    }

    private bool OnTriggerPlayer()
    {
        Vector3 playerPoint = _player.position.normalized;
        Vector3 forwardPoint = (transform.position + transform.forward).normalized;
        float dot = Vector3.Dot(forwardPoint, playerPoint);
        float angleRadians = Mathf.Acos(dot);
        float angleDegrees = angleRadians * Mathf.Rad2Deg;
        float distance = (transform.position - _player.position).magnitude;
        return angleDegrees <= _angleDegrees / 2 && distance <= _distance;
    }

    private void OnDrawGizmos()
    {
        // Player
        Vector3 playerDirection = (_player.position - transform.position).normalized;
        Vector3 playerPoint = transform.position + playerDirection * _distance;
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(transform.position, playerPoint);

        // Forward
        Vector3 forwardPoint = transform.position + transform.forward * _distance;
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, forwardPoint);

        // Review boundaries
        float rad = _angleDegrees / 2 * Mathf.Deg2Rad;
        Vector3 rightDirection = new Vector3(transform.forward.x * Mathf.Cos(rad) + transform.forward.z * Mathf.Sin(rad), 0,
                                        transform.forward.z * Mathf.Cos(rad) - transform.forward.x * Mathf.Sin(rad));
        Vector3 leftDirection = new Vector3(transform.forward.x * Mathf.Cos(rad) - transform.forward.z * Mathf.Sin(rad), 0,
                                        transform.forward.z * Mathf.Cos(rad) + transform.forward.x * Mathf.Sin(rad));
        Vector3 rightPoint = rightDirection * _distance;
        Vector3 leftPoint = leftDirection * _distance;
        Gizmos.DrawLine(transform.position, rightPoint);
        Gizmos.DrawLine(transform.position, leftPoint);
    }
}
