using UnityEngine;

public class DoorTigger : MonoBehaviour
{

    public Transform door;

    public Vector3 closedD = new Vector3(0.264f, 1.63f, 6.66f);
    public Vector3 openedD = new Vector3(0.264f, 4.63f, 6.66f);

    public float openSpeed = 5;

    private bool open = false;

    void Update()
    {
        if(open)
        {
            door.position = Vector3.Lerp(door.position, openedD, Time.deltaTime * openSpeed);
        }
        else
        {
            door.position = Vector3.Lerp(door.position, closedD, Time.deltaTime * openSpeed);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            openDoor();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            closeDoor();
        }
    }
    public void closeDoor()
    {
        open = false;
    }
    public void openDoor()
    {
        open = true;
    }
}
