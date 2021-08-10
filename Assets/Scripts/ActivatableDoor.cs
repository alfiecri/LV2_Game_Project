using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ActivatableDoor : MonoBehaviour {
    [Tooltip("Number of buttons triggered")]
    public int buttonsTriggered;

    [Tooltip("To remove door by a doorTrigger")]
    public DoorTrigger doorTrigger;

    [Header("Game Audio Clips")]
    public AudioClip doorSound;

    public GameObject buttons;

    private AudioSource audioSource;
    private MeshRenderer meshRenderer;

    // Use this for initialization
    void Start ()
    {
        buttonsTriggered = 0;

        audioSource = GetComponent<AudioSource>();
        meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update ()
    {
        if (meshRenderer.enabled) {
            // Check if this door has a DoorTrigger object //
            if (doorTrigger != null)
            {
                // All 4 buttons found //
                if (buttonsTriggered == 4)
                {
                    StartCoroutine(RemoveDoor(2));
                }
            }
        }
    }

    IEnumerator RemoveDoor(float _timeBeforeRemoval)
    {
        audioSource.PlayOneShot(doorSound);
        meshRenderer.enabled = false;
        GetComponent<Collider>().enabled = false;
        GetComponent<UnityEngine.AI.NavMeshObstacle>().enabled = false;

        yield return new WaitForSeconds(_timeBeforeRemoval);
        gameObject.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Button"))
            {
                Destroy(gameObject);
            }
    }
}
