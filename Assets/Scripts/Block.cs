using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    [System.Serializable] public enum BlockSides { Bottom, Top, Left, Right, Front, Back };
    [SerializeField] private Material atlas;
    private void Start()
    {
        MeshFilter meshFilter = this.gameObject.AddComponent<MeshFilter>();
        MeshRenderer meshRenderer = this.gameObject.AddComponent<MeshRenderer>();
        meshRenderer.material = atlas;

        Quad[] quads = new Quad[6];
        quads[0] = new Quad(BlockSides.Bottom, new Vector3(0,0,0), MeshUtility.BlockType.Dirt);
        quads[1] = new Quad(BlockSides.Top, new Vector3(0, 0, 0), MeshUtility.BlockType.GrassTop);
        quads[2] = new Quad(BlockSides.Left, new Vector3(0, 0, 0), MeshUtility.BlockType.GrassSide);
        quads[3] = new Quad(BlockSides.Right, new Vector3(0, 0, 0), MeshUtility.BlockType.GrassSide);
        quads[4] = new Quad(BlockSides.Front, new Vector3(0, 0, 0), MeshUtility.BlockType.GrassSide);
        quads[5] = new Quad(BlockSides.Back, new Vector3(0, 0, 0), MeshUtility.BlockType.GrassSide);

        Mesh[] sideMeshes = new Mesh[6];
        sideMeshes[0] = quads[0].mesh;
        sideMeshes[1] = quads[1].mesh;
        sideMeshes[2] = quads[2].mesh;
        sideMeshes[3] = quads[3].mesh;
        sideMeshes[4] = quads[4].mesh;
        sideMeshes[5] = quads[5].mesh;

        meshFilter.mesh = MeshUtility.MergeMeshes(sideMeshes);
        meshFilter.mesh.name = "Cube_0_0_0";
    }
}
