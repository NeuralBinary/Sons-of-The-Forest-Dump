using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using PathCreation;
using PathCreation.Examples;
using UnityEngine;

// Token: 0x0200003B RID: 59
[Token(Token = "0x200003B")]
public class ChainsawChain : MonoBehaviour
{
	// Token: 0x0600017E RID: 382 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600017E")]
	[Address(RVA = "0x299DAB0", Offset = "0x299CAB0", VA = "0x18299DAB0")]
	private void Awake()
	{
	}

	// Token: 0x0600017F RID: 383 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600017F")]
	[Address(RVA = "0x299DB30", Offset = "0x299CB30", VA = "0x18299DB30")]
	public void SetSpeed(float speed)
	{
	}

	// Token: 0x06000180 RID: 384 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000180")]
	[Address(RVA = "0x299DC50", Offset = "0x299CC50", VA = "0x18299DC50")]
	private void Update()
	{
	}

	// Token: 0x06000181 RID: 385 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000181")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	private void GenerateTeeth()
	{
	}

	// Token: 0x06000182 RID: 386 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000182")]
	[Address(RVA = "0x299DCF0", Offset = "0x299CCF0", VA = "0x18299DCF0")]
	public ChainsawChain()
	{
	}

	// Token: 0x0400017D RID: 381
	[Token(Token = "0x400017D")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject _chainLeftToothPrefab;

	// Token: 0x0400017E RID: 382
	[Token(Token = "0x400017E")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject _chainRightToothPrefab;

	// Token: 0x0400017F RID: 383
	[Token(Token = "0x400017F")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject _chainLinkPrefab;

	// Token: 0x04000180 RID: 384
	[Token(Token = "0x4000180")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private int _segmentCount;

	// Token: 0x04000181 RID: 385
	[Token(Token = "0x4000181")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private PathCreator _chainPath;

	// Token: 0x04000182 RID: 386
	[Token(Token = "0x4000182")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private float _speed;

	// Token: 0x04000183 RID: 387
	[Token(Token = "0x4000183")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private List<PathFollower> _teeth;

	// Token: 0x04000184 RID: 388
	[Token(Token = "0x4000184")]
	[FieldOffset(Offset = "0x58")]
	private Vector3 _originalChainPosition;

	// Token: 0x04000185 RID: 389
	[Token(Token = "0x4000185")]
	[FieldOffset(Offset = "0x64")]
	private Quaternion _originalChainRotation;

	// Token: 0x04000186 RID: 390
	[Token(Token = "0x4000186")]
	[FieldOffset(Offset = "0x78")]
	private Transform _chainPathTransform;
}
