using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Grids : MonoBehaviour
{

    //private Grid grid;

    [SerializeField] Tilemap tilemap;
    // Start is called before the first frame update
    void Start()
    {
        //grid = GetComponent<Grid>();   
    }

    private void OnMouseDown()
    {
        Debug.Log("fda");
        //得到由屏幕指向地图的射线
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //由正确的方向得到屏幕中tile所在的位置
        Vector3Int vector = tilemap.WorldToCell(ray.GetPoint(-ray.origin.z / ray.direction.z));
        Debug.Log(vector);
        //对该位置进行点击测试
        if (tilemap.HasTile(vector))
            tilemap.SetColor(vector, Color.red);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
