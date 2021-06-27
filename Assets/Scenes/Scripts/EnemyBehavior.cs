using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;

public class EnemyBehavior : MonoBehaviour
{
    public GameObject Enemy;
    public GameObject main_spawn;
    public GameObject spawn1;
    public GameObject spawn2;
    public GameObject spawn3;
    public GameObject spawn4;

    public GameObject s1;
    public GameObject s2;
    public GameObject s3;

    private GameObject[] SpawnObjects;
    private Vector3[][] MovingPoints;

    int c = 0;
    void Start()
    {
        SpawnObjects = new GameObject[] { spawn1, spawn2, spawn3, spawn4 };

        /*MovingPoints = new Vector3[][]
        {
                    new Vector3[]
                    {
                        // Start Position
                        spawn1.transform.position,
                        spawn1.transform.position,

                        // Left 
                        new Vector3(spawn1.transform.position.x - 16, spawn1.transform.position.y, spawn1.transform.position.z),

                        // Right
                        new Vector3(spawn1.transform.position.x + 16, spawn1.transform.position.y, spawn2.transform.position.z),

                        // Rotate (Follow next)
                        new Vector3(spawn2.transform.position.x - 16, spawn2.transform.position.y, spawn2.transform.position.z),
                        new Vector3(spawn3.transform.position.x - 4, spawn3.transform.position.y, spawn3.transform.position.z),
                    },
                    new Vector3[]
                    {
                        // Start
                        spawn2.transform.position,
                        spawn2.transform.position,

                        // Move Left
                        new Vector3(spawn2.transform.position.x - 8, spawn2.transform.position.y, spawn2.transform.position.z),

                        // Right
                        new Vector3(spawn2.transform.position.x - 16, spawn2.transform.position.y, spawn2.transform.position.z),


                        // Follow
                        new Vector3(spawn3.transform.position.x - 4, spawn3.transform.position.y, spawn3.transform.position.z),
                        new Vector3(spawn4.transform.position.x - 4, spawn4.transform.position.y, spawn4.transform.position.z),
                    },
                    new Vector3[]
                    {
                        // Start
                        spawn3.transform.position,
                        spawn2.transform.position,

                        // Top
                        new Vector3(spawn3.transform.position.x + 8, spawn3.transform.position.y, spawn3.transform.position.z),
                        new Vector3(spawn3.transform.position.x - 4, spawn3.transform.position.y, spawn3.transform.position.z),

                        // Follow next
                        new Vector3(spawn4.transform.position.x - 4, spawn4.transform.position.y, spawn4.transform.position.z), // Reset Following
                        new Vector3(spawn1.transform.position.x + 8, spawn1.transform.position.y, spawn2.transform.position.z),
                    },
                    new Vector3[]
                    {
                        // Start Pos
                        spawn4.transform.position,
                        spawn2.transform.position,

                        // Top
                        new Vector3(spawn4.transform.position.x + 8, spawn4.transform.position.y, spawn4.transform.position.z),
                        new Vector3(spawn4.transform.position.x - 4, spawn4.transform.position.y, spawn4.transform.position.z),

                        // Follow next
                        new Vector3(spawn1.transform.position.x + 8, spawn1.transform.position.y, spawn2.transform.position.z),
                        new Vector3(spawn2.transform.position.x - 16, spawn2.transform.position.y, spawn2.transform.position.z),
                    },

        };*/


        MovingPoints = new Vector3[][]
{
                    new Vector3[]
                    {
                        // Start Position
                        s1.transform.position,
                        s2.transform.position,
                        s3.transform.position


                    },
                    new Vector3[]
                    {
                        new Vector3(s1.transform.position.x, s1.transform.position.y, s1.transform.position.z + 16),
                        new Vector3(s2.transform.position.x - 16, s2.transform.position.y, s2.transform.position.z),
                        new Vector3(s3.transform.position.x - 14, s3.transform.position.y, s3.transform.position.z),
                    },
                    new Vector3[]
                    {
                        new Vector3(s1.transform.position.x, s1.transform.position.y, s1.transform.position.z + 32),
                        new Vector3(s2.transform.position.x - 32, s2.transform.position.y, s2.transform.position.z),
                        new Vector3(s3.transform.position.x - 28, s3.transform.position.y, s3.transform.position.z),
                    },
                    new Vector3[]
                    {
                        new Vector3(s1.transform.position.x, s1.transform.position.y, s1.transform.position.z + 48),
                        new Vector3(s2.transform.position.x - 48, s2.transform.position.y, s2.transform.position.z),
                        new Vector3(s3.transform.position.x - 42, s3.transform.position.y, s3.transform.position.z ),
                    },

};


        InvokeRepeating("FirstMovement", 1, 10);
        //FirstMovement();
    }


    void Update()
    {
        
    }

    void FirstMovement()
    {
/*        if (c < MovingPoints.Length)
        {
            GameObject o = Instantiate(Enemy, main_spawn.transform.position, Quaternion.identity);
            o.SendMessage("InitTargets", MovingPoints[c]);
            c++;
        }*/
        for (int i = 0; i < MovingPoints.Length; ++i)
        {
            try
            {
                GameObject o = Instantiate(Enemy, new Vector3(main_spawn.transform.position.x, main_spawn.transform.position.y, main_spawn.transform.position.z + (6 * i)), Quaternion.identity);
                o.SendMessage("InitTargets", MovingPoints[i]);
            }
            catch (System.Exception e)
            {

            }
        }
    }
}
