﻿using UnityEngine;

public class DynamicBoneColliderBase : MonoBehaviour
{
    public enum Direction { X, Y, Z }

#if UNITY_5
    [Tooltip("The axis of the capsule's height.")]
#endif
    public Direction m_Direction = Direction.Y;

#if UNITY_5
    [Tooltip("The center of the sphere or capsule, in the object's local space.")]
#endif
    public Vector3 m_Center = Vector3.zero;

    public enum Bound { Outside, Inside }

#if UNITY_5
    [Tooltip("Constrain bones to outside bound or inside bound.")]
#endif
    public Bound m_Bound = Bound.Outside;

    public virtual void Collide(ref Vector3 particlePosition, float particleRadius)
    {
    }
}