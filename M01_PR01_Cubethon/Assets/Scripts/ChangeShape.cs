using UnityEngine;

public class ChangeShape : MonoBehaviour
{
    private Transform player;

    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Transform>();
    }

    public void sizeChange()
    {
        player.localScale = new Vector3(3f, .1f, 1f);
    }
}
