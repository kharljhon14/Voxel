using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quad 
{
    public Mesh mesh;


    public Quad (Block.BlockSides side, Vector3 offset)
    {
        mesh = new Mesh();
        mesh.name = "Scripted_Quad";

        Vector3[] vertices = new Vector3[4];
        Vector3[] normals = new Vector3[4];
        Vector2[] uvs = new Vector2[4];
        int[] triangles = new int[6];

        Vector2 uv00 = new Vector2(0, 0);
        Vector2 uv10 = new Vector2(1, 0);
        Vector2 uv01 = new Vector2(0, 1);
        Vector2 uv11 = new Vector2(1, 1);

        Vector3 p0 = new Vector3(-.5f, -.5f, .5f) + offset;
        Vector3 p1 = new Vector3(.5f, -.5f, .5f) + offset;
        Vector3 p2 = new Vector3(.5f, -.5f, -.5f) + offset;
        Vector3 p3 = new Vector3(-.5f, -.5f, -.5f) + offset;
        Vector3 p4 = new Vector3(-.5f, .5f, .5f) + offset;
        Vector3 p5 = new Vector3(.5f, .5f, .5f) + offset;
        Vector3 p6 = new Vector3(.5f, .5f, -.5f) + offset;
        Vector3 p7 = new Vector3(-.5f, .5f, -.5f) + offset;

        switch (side)
        {
            case Block.BlockSides.Front:
                vertices = new Vector3[] { p4, p5, p1, p0 }; //Front of the cube
                normals = new Vector3[] { Vector3.forward, Vector3.forward, Vector3.forward, Vector3.forward };
                uvs = new Vector2[] { uv11, uv01, uv00, uv10 };
                triangles = new int[] { 3, 1, 0, 3, 2, 1 };
            break;

            case Block.BlockSides.Back:
                vertices = new Vector3[] { p6, p7, p3, p2 }; //Back of the cube
                normals = new Vector3[] { Vector3.back, Vector3.back, Vector3.back, Vector3.back };
                uvs = new Vector2[] { uv11, uv01, uv00, uv10 };
                triangles = new int[] { 3, 1, 0, 3, 2, 1 };
            break;

            case Block.BlockSides.Top:
                vertices = new Vector3[] { p7, p6, p5, p4 }; //Top of the cube
                normals = new Vector3[] { Vector3.up, Vector3.up, Vector3.up, Vector3.up };
                uvs = new Vector2[] { uv11, uv01, uv00, uv10 };
                triangles = new int[] { 3, 1, 0, 3, 2, 1 };
            break;

            case Block.BlockSides.Bottom:
                vertices = new Vector3[] { p0, p1, p2, p3 }; //Bottom of the cube
                normals = new Vector3[] { Vector3.down, Vector3.down, Vector3.down, Vector3.down };
                uvs = new Vector2[] { uv11, uv01, uv00, uv10 };
                triangles = new int[] { 3, 1, 0, 3, 2, 1 };
            break;

            case Block.BlockSides.Right:
                vertices = new Vector3[] { p6, p5, p1, p2 }; //Right of the cube
                normals = new Vector3[] { Vector3.right, Vector3.right, Vector3.right, Vector3.right };
                uvs = new Vector2[] { uv11, uv01, uv00, uv10 };
                triangles = new int[] { 0, 1, 3, 1, 2, 3 };
            break;

            case Block.BlockSides.Left:
                vertices = new Vector3[] { p4, p7, p3, p0 }; //Left of the cube
                normals = new Vector3[] { Vector3.left, Vector3.left, Vector3.left, Vector3.left };
                uvs = new Vector2[] { uv11, uv01, uv00, uv10 };
                triangles = new int[] { 0, 1, 3, 1, 2, 3 };
                break;
        }
   

        mesh.vertices = vertices;
        mesh.normals = normals;
        mesh.uv = uvs;
        mesh.triangles = triangles;

        mesh.RecalculateBounds();
    }
}
