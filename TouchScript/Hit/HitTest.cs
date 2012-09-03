﻿/*
 * Copyright (C) 2012 Interactive Lab
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation 
 * The above copyright notice and this permission notice shall be included in all copies or substantial portions of the 
 * 
 */

using UnityEngine;

namespace TouchScript.Hit {
    /// <summary>
    /// Parent class for all hit test handlers.
    /// </summary>
    public abstract class HitTest : MonoBehaviour {
        public virtual bool IsHit(RaycastHit hit) {
            return true;
        }
    }
}