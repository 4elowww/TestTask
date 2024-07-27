using System.Collections;
using UnityEngine;

public class Doors: MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("OpenDoor");
            gameObject.GetComponent<Animator>().SetBool("Open", true);
            StartCoroutine(CloseDoor());
        }
    }
    IEnumerator CloseDoor()
    {
        yield return new WaitForSeconds(3);
        gameObject.GetComponent<Animator>().SetBool("Open", false);
    }
}
