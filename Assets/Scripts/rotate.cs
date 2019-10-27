using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour {

 
    
        public Vector3 rotation_amount;

        // Update is called once per frame
        void Update()
        {
            transform.Rotate(rotation_amount);
        }
    }

