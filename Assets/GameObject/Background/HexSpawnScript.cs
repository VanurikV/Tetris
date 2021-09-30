using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tetris
{
    public class HexSpawnScript : MonoBehaviour
    {

        [SerializeField] private GameObject[] HexPrefab;
        public float MinTime;
        public float MaxTime;

        public float SpeedMax;
        public float SpeedMin;
        
        private float _elapseTime=0;
        
        
        
       
        void Update()
        {
            _elapseTime -= Time.deltaTime;
            if(_elapseTime>0) return;

            _elapseTime = Random.Range(MinTime, MaxTime);
            int hex = Random.Range(0, HexPrefab.Length);

            GameObject o = Instantiate(HexPrefab[hex], gameObject.transform);
            o.transform.localPosition =
                new Vector3(Random.Range(-gameObject.transform.position.x, gameObject.transform.position.x), 1000, 0);
            o.GetComponent<HexScript>().Speed = Random.Range(SpeedMin, SpeedMax);

        }
    }
}
