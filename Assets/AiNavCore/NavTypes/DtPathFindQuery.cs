﻿using System;
using Unity.Mathematics;

namespace AiNav
{
    [Serializable]
    public struct DtPathFindQuery
    {
        public float3 Source;
        public float3 Target;
        public float3 FindNearestPolyExtent;
        public int MaxPathPoints;
    }
}
