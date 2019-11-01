using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    public GameObject kamikaze;
    public float kamikazeLocation;
    public GameObject alienShip;
    public float alienShipLocation;
    public bool whenPlaying= true;

    void Start()
    {
        StartCoroutine(Spawn());
    }

    void Update()
    {
        
    }

    IEnumerator Spawn()
    {
        while (true)
        {
            int enemyNumber = Random.Range(1, 4);
            for (int i = 0; i < enemyNumber; i++)
            {
                int enemy = Random.Range(0, 2);
                switch (enemy)
                {
                    case 0:
                        kamikazeLocation = Random.Range(11, -11);
                        Vector3 kposition = new Vector3(kamikazeLocation, 4.74f, -0.11f);
                        GameObject kamik = Instantiate(kamikaze, kposition, Quaternion.Euler(new Vector3(90, 0, 180)));
                        kamik.AddComponent<Kamikaze>();
                        break;
                    case 1:
                        alienShipLocation = Random.Range(11, -11);
                        Vector3 asposition = new Vector3(alienShipLocation, 4.74f, -0.11f);
                        GameObject ship = Instantiate(alienShip, asposition, Quaternion.Euler(new Vector3(90, 0, 180)));
                        break;

                }
            }
             yield return new WaitForSeconds(5f);
        }
    }
}