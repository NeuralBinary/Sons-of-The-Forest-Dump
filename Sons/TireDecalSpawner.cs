using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000041 RID: 65
[Token(Token = "0x2000041")]
public class TireDecalSpawner : MonoBehaviour
{
	// Token: 0x060001C5 RID: 453 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001C5")]
	[Address(RVA = "0x2F829D0", Offset = "0x2F80FD0", VA = "0x182F829D0")]
	private void Awake()
	{
	}

	// Token: 0x060001C6 RID: 454 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001C6")]
	[Address(RVA = "0x2F82AD0", Offset = "0x2F810D0", VA = "0x182F82AD0")]
	private void OnEnable()
	{
	}

	// Token: 0x060001C7 RID: 455 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001C7")]
	[Address(RVA = "0x2F82C00", Offset = "0x2F81200", VA = "0x182F82C00")]
	private void OnDisable()
	{
	}

	// Token: 0x060001C8 RID: 456 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001C8")]
	[Address(RVA = "0x2F82DB0", Offset = "0x2F813B0", VA = "0x182F82DB0")]
	private void Update()
	{
	}

	// Token: 0x060001C9 RID: 457 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001C9")]
	[Address(RVA = "0x2F83A30", Offset = "0x2F82030", VA = "0x182F83A30")]
	private void InitializeObjectPool()
	{
	}

	// Token: 0x060001CA RID: 458 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001CA")]
	[Address(RVA = "0x2F84060", Offset = "0x2F82660", VA = "0x182F84060")]
	public TireDecalSpawner()
	{
	}

	// Token: 0x040001B4 RID: 436
	[Token(Token = "0x40001B4")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject _tireDecalPrefab;

	// Token: 0x040001B5 RID: 437
	[Token(Token = "0x40001B5")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float _tireDecalInterval;

	// Token: 0x040001B6 RID: 438
	[Token(Token = "0x40001B6")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float _maxDecalEmissionHeight;

	// Token: 0x040001B7 RID: 439
	[Token(Token = "0x40001B7")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject _tireDecalLocator;

	// Token: 0x040001B8 RID: 440
	[Token(Token = "0x40001B8")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float _decalPlacementHeightOffset;

	// Token: 0x040001B9 RID: 441
	[Token(Token = "0x40001B9")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private float _fadeTimer;

	// Token: 0x040001BA RID: 442
	[Token(Token = "0x40001BA")]
	private const float MaxActiveDistance = 100f;

	// Token: 0x040001BB RID: 443
	[Token(Token = "0x40001BB")]
	[FieldOffset(Offset = "0x40")]
	private Vector3 _previousDecalPosition;

	// Token: 0x040001BC RID: 444
	[Token(Token = "0x40001BC")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private int _objectPoolCount;

	// Token: 0x040001BD RID: 445
	[Token(Token = "0x40001BD")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private int _objectPoolFadeCount;

	// Token: 0x040001BE RID: 446
	[Token(Token = "0x40001BE")]
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	private Quaternion _decalRotationOffset;

	// Token: 0x040001BF RID: 447
	[Token(Token = "0x40001BF")]
	[FieldOffset(Offset = "0x68")]
	private List<GameObject> _objectPool;

	// Token: 0x040001C0 RID: 448
	[Token(Token = "0x40001C0")]
	[FieldOffset(Offset = "0x70")]
	private bool _initializedPool;

	// Token: 0x040001C1 RID: 449
	[Token(Token = "0x40001C1")]
	[FieldOffset(Offset = "0x78")]
	private List<Vector3> _objectPositionsQueue;

	// Token: 0x040001C2 RID: 450
	[Token(Token = "0x40001C2")]
	[FieldOffset(Offset = "0x80")]
	private List<Quaternion> _objectRotationsQueue;

	// Token: 0x040001C3 RID: 451
	[Token(Token = "0x40001C3")]
	[FieldOffset(Offset = "0x88")]
	private List<bool> _objectActivePool;

	// Token: 0x040001C4 RID: 452
	[Token(Token = "0x40001C4")]
	[FieldOffset(Offset = "0x90")]
	private Quaternion _previousDecalRotation;

	// Token: 0x040001C5 RID: 453
	[Token(Token = "0x40001C5")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private int _maxDistance;

	// Token: 0x040001C6 RID: 454
	[Token(Token = "0x40001C6")]
	[FieldOffset(Offset = "0xA4")]
	private float _previousDecalUpdateTime;
}
