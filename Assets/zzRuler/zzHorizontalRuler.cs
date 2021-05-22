using UnityEngine;
using System.Collections;


[ExecuteInEditMode]
public class zzHorizontalRuler:MonoBehaviour
{
    Mesh planeMesh;
    const float imageLength = 10.0f;

    float preRulerRange;

    // The vertices of mesh
    // 3--2
    // |  |
    // 0--1
    readonly static Vector3[] vertices = new Vector3[]{
                //前
                new Vector3(0,0,0),
                new Vector3(1,0,0),
                new Vector3(1,1,0),
                new Vector3(0,1,0),
                
                //后
                new Vector3(0,0,1),
                new Vector3(1,0,1),
                new Vector3(1,1,1),
                new Vector3(0,1,1),
                
                //上
                new Vector3(0,1,0),
                new Vector3(1,1,0),
                new Vector3(1,1,1),
                new Vector3(0,1,1),
                
                //下
                new Vector3(0,0,1),
                new Vector3(1,0,1),
                new Vector3(1,0,0),
                new Vector3(0,0,0),

        };
    readonly static int[] triIndices = new int[] {
        0, 2, 1, 3, 2, 0 ,
        4, 5, 6, 7, 4, 6,
        8, 10, 9, 11, 10, 8 ,
        12, 14, 13, 15, 14, 12 ,
    };

    readonly static Vector3[] normals = new Vector3[]{
            new Vector3(0,0,-1),
            new Vector3(0,0,-1),
            new Vector3(0,0,-1),
            new Vector3(0,0,-1),

            new Vector3(0,0,1),
            new Vector3(0,0,1),
            new Vector3(0,0,1),
            new Vector3(0,0,1),

            new Vector3(0,1,0),
            new Vector3(0,1,0),
            new Vector3(0,1,0),
            new Vector3(0,1,0),

            new Vector3(0,-1,0),
            new Vector3(0,-1,0),
            new Vector3(0,-1,0),
            new Vector3(0,-1,0),

        };


    Vector2[] UVs = new Vector2[]{ 
        new Vector2(0, 0f), 
        new Vector2(1, 0),
        new Vector2(1, 0.5f), 
        new Vector2(0, 0.5f),

        new Vector2(1, 0.5f), 
        new Vector2(0, 0.5f),
        new Vector2(0, 1f), 
        new Vector2(1, 1f),

        new Vector2(0, 0f), 
        new Vector2(1, 0),
        new Vector2(1, 0.5f), 
        new Vector2(0, 0.5f),

        new Vector2(0, 0f), 
        new Vector2(1, 0),
        new Vector2(1, 0.5f), 
        new Vector2(0, 0.5f),
        
    };


    float rulerRange
    {
        get
        {
            return transform.lossyScale.x;
        }
    }

    void OnDestroy()
    {
        DestroyImmediate(planeMesh);
    }

    void Start()
    {

        MeshFilter lMeshFilter = gameObject.GetComponent<MeshFilter>();

        if (!lMeshFilter)
        {
            lMeshFilter = gameObject.AddComponent<MeshFilter>();
        }
        else if (lMeshFilter.sharedMesh)
        {
            //防止因duplicate而共享Mesh
            Object.DestroyImmediate(lMeshFilter.sharedMesh);
        }

        planeMesh = new Mesh();

        lMeshFilter.sharedMesh = planeMesh;

        planeMesh.vertices = vertices;
        planeMesh.triangles = triIndices;
        planeMesh.normals = normals;

        changeRange();
        preRulerRange = rulerRange;
    }

    void Update()
    {
        if (!gameObject.GetComponent<MeshFilter>() || !planeMesh)
            Start();

        float lNowRulerRange = rulerRange;
        if (preRulerRange != lNowRulerRange)
        {
            changeRange();
            preRulerRange = lNowRulerRange;
        }
    }

    private void changeRange()
    {
        UVs[1] = new Vector2(rulerRange / imageLength, 0.0f);
        UVs[2] = new Vector2(rulerRange / imageLength, 0.5f);


        UVs[5] = new Vector2(1f - rulerRange / imageLength, 0.5f);
        UVs[6] = new Vector2(1f - rulerRange / imageLength, 1.0f);

        UVs[9] = new Vector2(rulerRange / imageLength, 0.0f);
        UVs[10] = new Vector2(rulerRange / imageLength, 0.5f);

        UVs[13] = new Vector2(rulerRange / imageLength, 0.0f);
        UVs[14] = new Vector2(rulerRange / imageLength, 0.5f);

        planeMesh.uv = UVs;
    }


}