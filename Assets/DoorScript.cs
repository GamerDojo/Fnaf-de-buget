using UnityEngine;

public class DoorScript : MonoBehaviour
{
    void Start()
    {
        Open();
    }
    bool open;
    public void Open()
    {
        open = true;
        var euler = transform.localEulerAngles;
        LeanTween.rotate(gameObject, euler + new Vector3(0, 90, 0), 1f)   
        .setOnComplete(() =>
        {

        });
    }

    public void Close()
    {
        open = false;
        var euler = transform.localEulerAngles;
        LeanTween.rotate(gameObject, euler + new Vector3(0, -90, 0), 1f);
    }

    FirstPersonMovement playerInArea;

    private void OnTriggerEnter(Collider other)
    {
        var playerComponent = other.GetComponent<FirstPersonMovement>();
        if (playerComponent != null)
        {
            playerInArea = playerComponent;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        var playerComponent = other.GetComponent<FirstPersonMovement>();
        if (playerComponent != null)
        {
            playerInArea = null;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (open)
            {
                Close();
            }
            else
            {
                Open();
            }
        }
    }
}
