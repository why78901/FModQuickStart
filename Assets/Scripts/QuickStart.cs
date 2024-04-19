using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuickStart : MonoBehaviour
{
    void Start()
    {
        AudioManager.GetInstance().LoadBanks(CreateCube);
    }

    private void CreateCube()
    {
        var cube = ResourceLoader.Load<GameObject>("Prefabs/Cube.prefab");
        if (cube)
        {
            Instantiate(cube, transform);
        }
    }

}
