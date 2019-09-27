using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class saveload : MonoBehaviour
{

    public GameObject positionObject;

    const string DLL_NAME = "Ass1_DLL";

    [DllImport(DLL_NAME)]
    private static extern void OutputFile(float x, float y, float z);

    [DllImport(DLL_NAME)]
    private static extern float ImportFileX();

    [DllImport(DLL_NAME)]
    private static extern float ImportFileY();

    [DllImport(DLL_NAME)]
    private static extern float ImportFileZ();

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            OutputFile(positionObject.transform.position.x, positionObject.transform.position.y, positionObject.transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            positionObject.transform.position = new Vector3(ImportFileX(), ImportFileY(), ImportFileZ());
        }
    }
}
