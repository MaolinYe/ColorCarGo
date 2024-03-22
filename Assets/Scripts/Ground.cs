using UnityEngine;
public class Ground : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject obstaclePrefab;
    public int obstacleNumber = 100;
    private void Start()
    {
        var random = new System.Random();
        var groundScale = transform.localScale;
        for (var i = 0; i < obstacleNumber; i++)
        {
            var x = random.Next(-(int)(groundScale.x / 2), (int)(groundScale.x / 2));
            var z = random.Next(30, (int)(groundScale.z));
            var obstacle = Instantiate(obstaclePrefab, new Vector3(x, transform.localPosition.y+1, z), Quaternion.identity);
            obstacle.transform.localScale= new Vector3(random.Next(1, 5),random.Next(1, 5),random.Next(1, 5));
            obstacle.tag = obstaclePrefab.tag;
        }
    }
}
