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
	// Token: 0x06000187 RID: 391 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000187")]
	[Address(RVA = "0x2F7FB80", Offset = "0x2F7E180", VA = "0x182F7FB80")]
	private void Awake()
	{
	}

	// Token: 0x06000188 RID: 392 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000188")]
	[Address(RVA = "0x2F7FD20", Offset = "0x2F7E320", VA = "0x182F7FD20")]
	public void SetSpeed(float speed)
	{
	}

	// Token: 0x06000189 RID: 393 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000189")]
	[Address(RVA = "0x2F7FE70", Offset = "0x2F7E470", VA = "0x182F7FE70")]
	private void Update()
	{
	}

	// Token: 0x0600018A RID: 394 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600018A")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	private void GenerateTeeth()
	{
	}

	// Token: 0x0600018B RID: 395 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600018B")]
	[Address(RVA = "0x2F7FFD0", Offset = "0x2F7E5D0", VA = "0x182F7FFD0")]
	public ChainsawChain()
	{
	}

	// Token: 0x04000181 RID: 385
	[Token(Token = "0x4000181")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject _chainLeftToothPrefab;

	// Token: 0x04000182 RID: 386
	[Token(Token = "0x4000182")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject _chainRightToothPrefab;

	// Token: 0x04000183 RID: 387
	[Token(Token = "0x4000183")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject _chainLinkPrefab;

	// Token: 0x04000184 RID: 388
	[Token(Token = "0x4000184")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private int _segmentCount;

	// Token: 0x04000185 RID: 389
	[Token(Token = "0x4000185")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private PathCreator _chainPath;

	// Token: 0x04000186 RID: 390
	[Token(Token = "0x4000186")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private float _speed;

	// Token: 0x04000187 RID: 391
	[Token(Token = "0x4000187")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private List<PathFollower> _teeth;

	// Token: 0x04000188 RID: 392
	[Token(Token = "0x4000188")]
	[FieldOffset(Offset = "0x58")]
	private Vector3 _originalChainPosition;

	// Token: 0x04000189 RID: 393
	[Token(Token = "0x4000189")]
	[FieldOffset(Offset = "0x64")]
	private Quaternion _originalChainRotation;

	// Token: 0x0400018A RID: 394
	[Token(Token = "0x400018A")]
	[FieldOffset(Offset = "0x78")]
	private Transform _chainPathTransform;
}
