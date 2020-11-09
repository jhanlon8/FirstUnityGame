using UnityEngine;

public class CreateNewTarget : MonoBehaviour
{
      
       public Rigidbody bCube;
       public float value = 1f;

    public GameObject player;

    private Transform tplayer;
    private void Start()
    {
        tplayer = player.GetComponent<Transform>();
    }
    // Start is called before the first frame update
    public void createPreFab()
       {
           //value = transform.position.x;

          // int f = 15;
        /*
           for (int j = 0; j < 20; j++)
           {
               int i = 0;
               f = i + 15;
           }
        */


               Rigidbody CubeInstance;

               //CubeInstance = Instantiate(bCube, new Vector3(transform.position.x, transform.position.y, transform.position.z + value)
               //, transform.rotation) as Rigidbody;

               CubeInstance = Instantiate(bCube, new Vector3(-9, 1, 30 + tplayer.position.z), Quaternion.identity);

       }


      /*
    public GameObject preFabCube;

    private Vector3 position;
    private float newPosition = 21f;
    //player rigidbody abd transform
    private Transform player;
    private Rigidbody playerRB;
    //prefab rigidbody and transform
    private Rigidbody preFabRB;
    private Transform preFabTransform;

    private void Start()
    {
        preFabRB = preFabCube.GetComponent<Rigidbody>();
        preFabTransform = preFabRB.GetComponent<Transform>();

        player = GameObject.FindWithTag("Player").GetComponent<Transform>();
        playerRB = GameObject.FindWithTag("Player").GetComponent<Rigidbody>();

        //Instantiate(preFabRB);
    }

    public void CreateNewTargettt()
    {
       // preFabRB = preFabCube.GetComponent<Rigidbody>();
        newPosition = player.position.z + 150f;

        Instantiate(preFabRB, new Vector3(-9f, 1f, newPosition), Quaternion.identity);

    }
    */
    
}
