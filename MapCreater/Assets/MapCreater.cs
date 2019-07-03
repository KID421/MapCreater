using UnityEngine;

public class MapCreater : MonoBehaviour
{
    public Texture2D Map;

    public GameObject Ground, Coin, Prop;

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
            }
        }
    }

    private void Start()
    {
        InstantiateMap();
    }
}
