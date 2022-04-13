using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

#pragma warning disable

public interface IPather
{
  public abstract void Path(Vector3 location);
  public abstract void PathTick(int t);
}
