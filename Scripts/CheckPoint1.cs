using UnityEngine;

public class CheckPoint1 : MonoBehaviour, GlobalData
{
    [SerializeField] ParticleSystem _flags;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GlobalData.SpawnPoint = gameObject.transform.position;
            _flags.Play();
        }
        
    }
}
