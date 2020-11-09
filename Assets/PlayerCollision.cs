using UnityEngine;

public class PlayerCollision : MonoBehaviour
{   
    public CreateNewTarget createNewTargetScript;

    private Transform player;
    

    void Start()
    {
        createNewTargetScript = GetComponent<CreateNewTarget>();
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Player Hits Target!");
            createNewTargetScript.createPreFab();

            Destroy(gameObject, 0.1f);
        }
    }
    
}
