using UnityEngine;

public class change_mesh : MonoBehaviour
{
    private bool isCube = true;
    private MeshFilter meshFilter;

    private void Start()
    {
        meshFilter = GetComponent<MeshFilter>();
    }

    private void OnMouseDown()
    {
        if (isCube)
        {
            GameObject tempSphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            meshFilter.mesh = tempSphere.GetComponent<MeshFilter>().sharedMesh;
            Destroy(tempSphere);
        }
        else
        {
            GameObject tempCube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            meshFilter.mesh = tempCube.GetComponent<MeshFilter>().sharedMesh;
            Destroy(tempCube);
        }

        isCube = !isCube;
    }
}
