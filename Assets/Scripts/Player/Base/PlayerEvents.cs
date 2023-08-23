using System;
using UnityEngine;

public struct PlayerEvents
{
    public Action OnTap;

    public Action OnScoreIncrement;
    public Action<int> OnScoreChange;

    public Action OnDeath;
}
