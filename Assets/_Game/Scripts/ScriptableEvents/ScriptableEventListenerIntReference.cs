﻿using System;
using UnityEngine;
using UnityEngine.Events;
using Variables;

namespace DefaultNamespace.ScriptableEvents
{
    public class ScriptableEventListenerIntReference : ScriptableEventListener<IntReference, ScriptableEventIntReference, UnityEvent<IntReference>>
    {
       
    }

    [Serializable]
    public class UnityEventInt : UnityEvent<int>
    {
        
    }
    
    [Serializable]
    public class UnityEventVector3 : UnityEvent<Vector3>
    {
        
    }
    
    [Serializable]
    public class UnityEventGuid : UnityEvent<Guid>
    {
        
    }
}
