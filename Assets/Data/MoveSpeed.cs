using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Level_n", menuName = "ScriptableObjects/LevelSettings" +
"", order = 1)]
public class LevelInfo: ScriptableObject
{
	public float moveSpeed = 20f;
}
