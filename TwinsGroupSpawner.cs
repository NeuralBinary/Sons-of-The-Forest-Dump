using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using UnityEngine;

// Token: 0x02000004 RID: 4
[Token(Token = "0x2000004")]
public class TwinsGroupSpawner : MonoBehaviour
{
	// Token: 0x17000003 RID: 3
	// (get) Token: 0x06000009 RID: 9 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000003")]
	public GameObject TargetStructure
	{
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x5E9610", Offset = "0x5E8610", VA = "0x1805E9610")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600000A RID: 10 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000A")]
	[Address(RVA = "0x29B2100", Offset = "0x29B1100", VA = "0x1829B2100")]
	private IEnumerator Start()
	{
		return null;
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600000B")]
	[Address(RVA = "0x29B1F20", Offset = "0x29B0F20", VA = "0x1829B1F20")]
	private void GenerateCollisionFromTriggers(List<Collider> pushColliders, Transform instance)
	{
	}

	// Token: 0x0600000C RID: 12 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600000C")]
	[Address(RVA = "0x29B2000", Offset = "0x29B1000", VA = "0x1829B2000")]
	private void RevertCollisionToTriggers(List<Collider> pushColliders)
	{
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600000D")]
	[Address(RVA = "0x29B2170", Offset = "0x29B1170", VA = "0x1829B2170")]
	public TwinsGroupSpawner()
	{
	}

	// Token: 0x04000009 RID: 9
	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private bool _spawnStatic;

	// Token: 0x0400000A RID: 10
	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private VailActor _prefab;

	// Token: 0x0400000B RID: 11
	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private string[] _animatorBeginTriggerNames;

	// Token: 0x0400000C RID: 12
	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private string _animatorFinishTriggerName;

	// Token: 0x0400000D RID: 13
	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private float _moveUpDuration;

	// Token: 0x0400000E RID: 14
	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	private float _controllerOverrideDuration;

	// Token: 0x0400000F RID: 15
	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private VailControllerOverride _vailControllerOverride;

	// Token: 0x04000010 RID: 16
	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private GameObject _targetStructure;
}
