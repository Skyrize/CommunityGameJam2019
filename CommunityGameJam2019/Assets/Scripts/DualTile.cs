using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

[CreateAssetMenu(fileName = "New Dual Tile", menuName = "Tiles/Dual Tile")]
public class DualTile : Tile
{
    public Sprite spriteDream;
    public Sprite spriteReal;
    public GameObject player;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    public override void GetTileData(Vector3Int location, ITilemap tileMap, ref TileData tileData)
    {
        bool isSane = player.GetComponent<SanityComponent>().isSane;
        base.GetTileData(location, tileMap, ref tileData);
        tileData.sprite = isSane ? spriteDream : spriteReal;
    }
}
