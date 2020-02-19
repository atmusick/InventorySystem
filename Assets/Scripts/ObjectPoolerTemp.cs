using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ObjectPoolerCD
{
    public class ObjectPoolerTemp : MonoBehaviour
    {
        public GameObject[] bulletsRevolver = new GameObject[8];
        public GameObject[] bulletsRevolverS = new GameObject[8];

        public GameObject player;
        public GameObject bullet;

        public GameObject bulletRevolver;
      



        // Start is called before the first frame update
        void Start()
        {

            GameObject bulletR0 = bulletsRevolver[0];
            GameObject bulletR1 = bulletsRevolver[1];
            GameObject bulletR2 = bulletsRevolver[2];
            GameObject bulletR3 = bulletsRevolver[3];
            GameObject bulletR4 = bulletsRevolver[4];
            GameObject bulletR5 = bulletsRevolver[5];
            GameObject bulletR6 = bulletsRevolver[6];
            GameObject bulletR7 = bulletsRevolver[7];

            GameObject bulletRS0 = bulletsRevolverS[0];
            GameObject bulletRS1 = bulletsRevolverS[1];
            GameObject bulletRS2 = bulletsRevolverS[2];
            GameObject bulletRS3 = bulletsRevolverS[3];
            GameObject bulletRS4 = bulletsRevolverS[4];
            GameObject bulletRS5 = bulletsRevolverS[5];
            GameObject bulletRS6 = bulletsRevolverS[6];
            GameObject bulletRS7 = bulletsRevolverS[7];


        }

        // Update is called once per frame
        void Update()
        {

        }





        public void ShootBullet()
        {

            //moves bullet to players position and rotation
            int shootBullet = BulletGet();
            Debug.Log(shootBullet);
            if (shootBullet == -1)
            {
                shootBullet = 7;
                for (int i = 0; i < 8; i++) { bulletsRevolver[i] = bulletsRevolverS[i]; }
                return;
            }
            bullet = bulletsRevolver[shootBullet];
            bullet.transform.position = player.transform.position;
            bullet.transform.rotation = player.transform.rotation;
            bullet.SetActive(true);
            // any other stuff you need to do with the bullet goes here
            bulletsRevolver[shootBullet] = null;
            if (shootBullet == 0)
            {
                shootBullet = 7;
                for (int i = 0; i < 8; i++) { bulletsRevolver[i] = bulletsRevolverS[i]; }
            }
        }

        public int BulletGet()
        {
            int currentBullet = -1;
            for (int i = 0; i < 8; i++)
            {
                if (bulletsRevolver[i] != null)
                {
                    currentBullet = i;

                }
            }
            return currentBullet;
        }






    }
}
