﻿using UnityEngine;

namespace ProjectBlue.LightBeamPerformance
{

    public class Tilt : MonoBehaviour
    {

        [SerializeField]
        Quaternion defaultRotation;

        public Range movableRange = new Range(-70, 70);

        [SerializeField] float lowPassWeight = 0.05f;
        QuaternionLowPassFilter lowPassFilter;

        private void Awake()
        {
            lowPassFilter = new QuaternionLowPassFilter(lowPassWeight, transform.localRotation);
        }

        public void RegisterDefaultRotation()
        {
            defaultRotation = transform.localRotation;
        }

        public void SetDefault()
        {

            if (Application.isPlaying)
            {
                transform.localRotation = lowPassFilter.Append(defaultRotation);
            }
            else
            {
                transform.localRotation = defaultRotation;
            }
            
        }

        public void SetRotation(float degree)
        {
            if (Application.isPlaying)
            {
                transform.localRotation = lowPassFilter.Append(Quaternion.Euler(degree, 0, 0));
            }
            else
            {
                transform.localRotation = Quaternion.Euler(degree, 0, 0);
            }
            

        }

    }
}