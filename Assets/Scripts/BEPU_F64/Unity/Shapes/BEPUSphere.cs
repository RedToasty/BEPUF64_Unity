﻿using FixMath.NET;
using UnityEngine;
using BEPUphysics.Entities.Prefabs;

namespace BEPUUnity
{
    public class BEPUSphere : ShapeBase
    {
        [SerializeField] private Fix64 m_radius;

        private void Awake()
        {
            m_entity = new Sphere(m_startPosition, m_radius, m_mass);
        }

#if UNITY_EDITOR
        private void OnDrawGizmos()
        {
            Gizmos.DrawWireSphere(new Vector3(transform.position.x, transform.position.y, transform.position.z), (float)m_radius);
        }
#endif
    }
}