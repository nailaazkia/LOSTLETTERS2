using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public RectTransform spawnArea;
    public RectTransform[] bars;

    void Start()
    {
        foreach (RectTransform bar in bars)
        {
            // pindahkan ke SpawnArea
            bar.SetParent(spawnArea);

            // posisi acak 
            float x = Random.Range(-250f, 250f);
            float y = Random.Range(-100f, 100f);

            bar.anchoredPosition = new Vector2(x, y);
        }
    }
}