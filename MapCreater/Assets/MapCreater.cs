using UnityEngine;

public class MapCreater : MonoBehaviour
{
    public Texture2D Map;

    public GameObject Ground, Coin, Prop;

    public Color Brown, Yellow, Green;

    /// <summary>
    /// 實例化地圖
    /// </summary>
    private void InstantiateMap()
    {
        int width = Map.width;
        int height = Map.height;
        Debug.Log("圖片的寬：" + width);
        Debug.Log("圖片的高：" + height);

        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                if (Map.GetPixel(x, y).a == 0)
                {
                    continue;
                }

                Debug.Log("圖片的顏色：" + Map.GetPixel(x, y));

                if (Map.GetPixel(x, y) == Brown)
                {
                    //GameObject temp = Instantiate(Ground, new Vector2(x, y) * 2, Quaternion.identity);
                    //temp.AddComponent<SceneObject>();
                    //temp.GetComponent<SceneObject>().objectType = ObjectType.Ground;
                    CreateObject(Ground, ObjectType.Ground, x, y);
                }
                else if (Map.GetPixel(x, y) == Yellow)
                {
                    //GameObject temp = Instantiate(Coin, new Vector2(x, y) * 2, Quaternion.identity);
                    //temp.AddComponent<SceneObject>();
                    //temp.GetComponent<SceneObject>().objectType = ObjectType.Coin;
                    CreateObject(Coin, ObjectType.Coin, x, y);
                }
                else if (Map.GetPixel(x, y) == Green)
                {
                    //GameObject temp = Instantiate(Prop, new Vector2(x, y) * 2, Quaternion.identity);
                    //temp.AddComponent<SceneObject>();
                    //temp.GetComponent<SceneObject>().objectType = ObjectType.Prop;
                    CreateObject(Prop, ObjectType.Prop, x, y);
                }
            }
        }
    }

    /// <summary>
    /// 建立物件 - 指定物件、物件類型、座標
    /// </summary>
    /// <param name="obj">指定物件</param>
    /// <param name="type">物件類型</param>
    /// <param name="x">左右</param>
    /// <param name="y">上下</param>
    private void CreateObject(GameObject obj, ObjectType type, int x, int y)
    {
        GameObject temp = Instantiate(obj, new Vector2(x, y) * 2, Quaternion.identity);
        temp.AddComponent<SceneObject>();
        temp.GetComponent<SceneObject>().objectType = type;
    }

    private void Start()
    {
        InstantiateMap();
    }
}
