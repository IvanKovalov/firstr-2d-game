﻿using System;
using Core.StatSystem.Enums;
using UnityEngine;

namespace Core.StatSystem
{
    [Serializable]
    public class Stat
    {
        [field: SerializeField] public  StatType Type { get; private set; }
        [field: SerializeField] public float  Value { get; private set; }

        public Stat(StatType statType, float value)
        {
            Type = statType;
            Value = value;
        }

        public void SetStatValue(float value) => Value = value;

        public static implicit operator float(Stat stat)
        {
            return stat?.Value ?? 0;
        }

        public Stat GetCopy() => new Stat(Type, Value);
    }
}