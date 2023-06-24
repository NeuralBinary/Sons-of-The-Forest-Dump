using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000054 RID: 84
[Token(Token = "0x2000054")]
public class TentModule : MonoBehaviour
{
	// Token: 0x0600027B RID: 635 RVA: 0x00002EE0 File Offset: 0x000010E0
	[Token(Token = "0x600027B")]
	[Address(RVA = "0x31B0320", Offset = "0x31AE920", VA = "0x1831B0320")]
	public int FindClosestTriggerSnapPointTo(Vector3 position, bool mustBeAvailable)
	{
		return 0;
	}

	// Token: 0x0600027C RID: 636 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600027C")]
	[Address(RVA = "0x31B04F0", Offset = "0x31AEAF0", VA = "0x1831B04F0")]
	public void UseSnapPoint(int index)
	{
	}

	// Token: 0x0600027D RID: 637 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600027D")]
	[Address(RVA = "0x31B06A0", Offset = "0x31AECA0", VA = "0x1831B06A0")]
	public Transform GetObjectSnapPointTransform(int index)
	{
		return null;
	}

	// Token: 0x0600027E RID: 638 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600027E")]
	[Address(RVA = "0x31B06B0", Offset = "0x31AECB0", VA = "0x1831B06B0")]
	public Transform GetTriggerSnapPointTransform(int index)
	{
		return null;
	}

	// Token: 0x0600027F RID: 639 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600027F")]
	[Address(RVA = "0x31B06C0", Offset = "0x31AECC0", VA = "0x1831B06C0")]
	private Transform GetSnapPoint(int index, bool isTrigger)
	{
		return null;
	}

	// Token: 0x06000280 RID: 640 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000280")]
	[Address(RVA = "0x31B0870", Offset = "0x31AEE70", VA = "0x1831B0870")]
	public TentModule()
	{
	}

	// Token: 0x04000260 RID: 608
	[Token(Token = "0x4000260")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<TentModule.SnapPoint> _snapPoints;

	// Token: 0x02000055 RID: 85
	[Token(Token = "0x2000055")]
	[Serializable]
	public class SnapPoint
	{
		// Token: 0x06000281 RID: 641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000281")]
		[Address(RVA = "0x1EA3300", Offset = "0x1EA1900", VA = "0x181EA3300")]
		public SnapPoint()
		{
		}

		// Token: 0x04000261 RID: 609
		[Token(Token = "0x4000261")]
		[FieldOffset(Offset = "0x10")]
		public Transform _triggerSnapTransform;

		// Token: 0x04000262 RID: 610
		[Token(Token = "0x4000262")]
		[FieldOffset(Offset = "0x18")]
		public Transform _objectSpawnTransform;

		// Token: 0x04000263 RID: 611
		[Token(Token = "0x4000263")]
		[FieldOffset(Offset = "0x20")]
		public bool _isAvailable;
	}
}
