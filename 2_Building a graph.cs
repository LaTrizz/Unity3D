using UnityEngine;

public class Graph : MonoBehaviour 
{

    public Transform pointPrefab;
  
    void Awake () 
    {
        Vector3 scale = Vector3.one / 5f;
        Vector3 position;
        position.x = 0;
        position.y = 0;
    
        for(int i = 0; i < 10; i++)
        {
            Transform point = Instantiate (pointPrefab);
            position.x = ((i + 0.5f) / 5f - 1f);
            point.localPosition = position;
            point.localScale = scale;
        }
    }
}
