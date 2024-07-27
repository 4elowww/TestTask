using System.Collections;
using UnityEngine;

public class RotateRoad : MonoBehaviour
{
    [SerializeField] private Transform _player;
    [SerializeField] private bool _isRight;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Rotate();
        }
    }
    private IEnumerator Rotate()
    {
        if(_isRight)
        {
            float rotateTo = _player.rotation.z - 90;
            while(_player.rotation.z < rotateTo)
            {
                _player.rotation = Quaternion.Euler(90, 0, Mathf.Lerp(_player.rotation.z, rotateTo, Time.deltaTime*30));
                yield return null;
                Debug.Log("rotate");
            }
        }
    }
}
