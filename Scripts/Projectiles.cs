using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour {

    public float speed = 1.5f;
    private Vector3 target;
    public GameObject projectilePrefab;
    private List<GameObject> Projectiles = new List<GameObject>();

    // Use this for initialization
    void Start () {
        target = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0))
        {
            GameObject bullet = (GameObject)Instantiate(projectilePrefab, transform.position, Quaternion.identity);
            Projectiles.Add(bullet);
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            target.z = transform.position.z;
        }
        for(int i = 0; i < Projectiles.Count; i++)
        {
            GameObject goBullet = Projectiles[i];
            if(goBullet != null)
            {
                Vector3 bulletScreenPos = Camera.main.WorldToScreenPoint(goBullet.transform.position);
                goBullet.transform.Translate(new Vector3(target.x, target.y) * Time.deltaTime * speed);
                if(bulletScreenPos.y >= Screen.height || bulletScreenPos.x == Screen.height)
                {
                    DestroyObject(goBullet);
                    Projectiles.Remove(goBullet);
                }
                if(bulletScreenPos.x >= Screen.width || bulletScreenPos.x == Screen.width)
                {
                    DestroyObject(goBullet);
                    Projectiles.Remove(goBullet);
                }
            }
        }
    }
}
