using UnityEngine;


public class CameraController : MonoBehaviour
{
    public Transform playerTransform;
    private Vector3 playerPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(playerTransform!=null){
        playerPosition = playerTransform.position;
        transform.position = new Vector3(playerPosition.x, playerPosition.y, transform.position.z);
        }

    }


    // Update is called once per frame
    void Update()
    {
        if(playerTransform!=null){
        playerPosition = playerTransform.position;
        transform.position = new Vector3(playerPosition.x, playerPosition.y, transform.position.z);
        }
    }
}
