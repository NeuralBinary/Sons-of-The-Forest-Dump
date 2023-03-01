using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000053 RID: 83
[Token(Token = "0x2000053")]
public class TentModule : MonoBehaviour
{
	// Token: 0x0600025E RID: 606 RVA: 0x00002E08 File Offset: 0x00001008
	[Token(Token = "0x600025E")]
	[Address(RVA = "0x2B80B20", Offset = "0x2B7FB20", VA = "0x182B80B20")]
	public int FindClosestTriggerSnapPointTo(Vector3 position, bool mustBeAvailable)
	{
		return default(int);
	}

	// Token: 0x0600025F RID: 607 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600025F")]
	[Address(RVA = "0x2B80E10", Offset = "0x2B7FE10", VA = "0x182B80E10")]
	public void UseSnapPoint(int index)
	{
	}

	// Token: 0x06000260 RID: 608 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000260")]
	[Address(RVA = "0x2B80C90", Offset = "0x2B7FC90", VA = "0x182B80C90")]
	public Transform GetObjectSnapPointTransform(int index)
	{
		return null;
	}

	// Token: 0x06000261 RID: 609 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000261")]
	[Address(RVA = "0x2B80E00", Offset = "0x2B7FE00", VA = "0x182B80E00")]
	public Transform GetTriggerSnapPointTransform(int index)
	{
		return null;
	}

	// Token: 0x06000262 RID: 610 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000262")]
	[Address(RVA = "0x2B80CA0", Offset = "0x2B7FCA0", VA = "0x182B80CA0")]
	private Transform GetSnapPoint(int index, bool isTrigger)
	{
		return null;
	}

	// Token: 0x06000263 RID: 611 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000263")]
	[Address(RVA = "0x2B80FA0", Offset = "0x2B7FFA0", VA = "0x182B80FA0")]
	public TentModule()
	{
	}

	// Token: 0x04000234 RID: 564
	[Token(Token = "0x4000234")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<TentModule.SnapPoint> _snapPoints;

	// Token: 0x02000054 RID: 84
	[Token(Token = "0x2000054")]
	[Serializable]
	public class SnapPoint
	{
		// Token: 0x06000264 RID: 612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000264")]
		[Address(RVA = "0x1BA6920", Offset = "0x1BA5920", VA = "0x181BA6920")]
		public SnapPoint()
		{
		}

		// Token: 0x04000235 RID: 565
		[Token(Token = "0x4000235")]
		[FieldOffset(Offset = "0x10")]
		public Transform _triggerSnapTransform;

		// Token: 0x04000236 RID: 566
		[Token(Token = "0x4000236")]
		[FieldOffset(Offset = "0x18")]
		public Transform _objectSpawnTransform;

		// Token: 0x04000237 RID: 567
		[Token(Token = "0x4000237")]
		[FieldOffset(Offset = "0x20")]
		public bool _isAvailable;
	}
}
