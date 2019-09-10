using UnityEngine;

public class GazeManager : MonoBehaviour
{

    public Transform cursor;
    public Transform cam;
    public float distance = 2f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //Raycast from the camera's position forward.
        RaycastHit hit;

        //If the raycast hit...
        if (Physics.Raycast(cam.position, cam.forward, out hit, distance))
        {
            //Place the cursor at the hit location.
            cursor.position = hit.point;
            //Orient the cursor to the normal of the hit object.
            cursor.forward = hit.normal;
        }
        else
        {
            //Place the cursor at the furthest range along your gaze.
            cursor.position = cam.position + cam.forward * distance;
        }
    }

}

