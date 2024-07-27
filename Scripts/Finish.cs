using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    [Header("CS")]
    [SerializeField] private GameStates _csGameStates;
    [SerializeField] private PlayerMovement _csPlayerMovement;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("finish");
            StartCoroutine(Wait()); 
        }
    }
    private IEnumerator Wait()
    {
        _csPlayerMovement.PlayerStop();
        yield return new WaitForSeconds(3);
        _csGameStates.Win(SceneManager.GetActiveScene().buildIndex);
    }
}
