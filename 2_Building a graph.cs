using UnityEngine;

public class Graph : MonoBehaviour 
{

    public Transform pointPrefab;
  
    void Awake () 
    {
        [Range (10, 100)]
        public int resolution = 10;
        
        float step = 2f / resolution;
        Vector3 scale = Vector3.one / 5f;
        Vector3 position;
        position.x = 0;
    
        for(int i = 0; i < resolution; i++)
        {
            Transform point = Instantiate (pointPrefab);
            position.x = ((i + 0.5f) * step - 1f);
            position.y = position.x;
            point.localPosition = position;
            point.localScale = scale;
            point.SetParent(transform, false);     // transform faire référence au component "Transform" de l'objet qui tient le script, en l'occurrence "Graph" 
        }
    }
}
