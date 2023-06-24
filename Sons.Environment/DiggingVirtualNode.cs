using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000002 RID: 2
[Token(Token = "0x2000002")]
public class DiggingVirtualNode
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x674880", Offset = "0x672E80", VA = "0x180674880")]
	public bool GetBlockMerge()
	{
		return default(bool);
	}

	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000002 RID: 2 RVA: 0x00002068 File Offset: 0x00000268
	[Token(Token = "0x17000001")]
	public bool IsMergeResult
	{
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x2F8D240", Offset = "0x2F8B840", VA = "0x182F8D240")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000003 RID: 3 RVA: 0x00002080 File Offset: 0x00000280
	[Token(Token = "0x6000003")]
	[Address(RVA = "0x2F8D290", Offset = "0x2F8B890", VA = "0x182F8D290")]
	public static float GetSize(Transform eachNode)
	{
		return 0f;
	}

	// Token: 0x06000004 RID: 4 RVA: 0x00002096 File Offset: 0x00000296
	[Token(Token = "0x6000004")]
	[Address(RVA = "0x2F8D300", Offset = "0x2F8B900", VA = "0x182F8D300")]
	public DiggingVirtualNode(Transform eachNode)
	{
	}

	// Token: 0x06000005 RID: 5 RVA: 0x00002096 File Offset: 0x00000296
	[Token(Token = "0x6000005")]
	[Address(RVA = "0x2F8D550", Offset = "0x2F8BB50", VA = "0x182F8D550")]
	public DiggingVirtualNode(Vector3 inPosition, Quaternion inRotation, float inSize)
	{
	}

	// Token: 0x06000006 RID: 6 RVA: 0x00002096 File Offset: 0x00000296
	[Token(Token = "0x6000006")]
	[Address(RVA = "0x2F8D6B0", Offset = "0x2F8BCB0", VA = "0x182F8D6B0")]
	public DiggingVirtualNode()
	{
	}

	// Token: 0x06000007 RID: 7 RVA: 0x00002096 File Offset: 0x00000296
	[Token(Token = "0x6000007")]
	[Address(RVA = "0x2F8D7D0", Offset = "0x2F8BDD0", VA = "0x182F8D7D0")]
	public DiggingVirtualNode(Vector3 position, float size, Quaternion rotation)
	{
	}

	// Token: 0x06000008 RID: 8 RVA: 0x00002098 File Offset: 0x00000298
	[Token(Token = "0x6000008")]
	[Address(RVA = "0x2F8D930", Offset = "0x2F8BF30", VA = "0x182F8D930")]
	public DiggingVirtualNode Clone()
	{
		return null;
	}

	// Token: 0x06000009 RID: 9 RVA: 0x00002096 File Offset: 0x00000296
	[Token(Token = "0x6000009")]
	[Address(RVA = "0x2F8DAA0", Offset = "0x2F8C0A0", VA = "0x182F8DAA0")]
	public void OnDrawGizmos(bool drawMerged)
	{
	}

	// Token: 0x0600000A RID: 10 RVA: 0x00002096 File Offset: 0x00000296
	[Token(Token = "0x600000A")]
	[Address(RVA = "0x2F8E0C0", Offset = "0x2F8C6C0", VA = "0x182F8E0C0")]
	private void OnDrawGizmosMerged(Color color)
	{
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00002096 File Offset: 0x00000296
	[Token(Token = "0x600000B")]
	[Address(RVA = "0x674890", Offset = "0x672E90", VA = "0x180674890")]
	public void SetBlockMerge(bool value)
	{
	}

	// Token: 0x04000001 RID: 1
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x10")]
	public Vector3 position;

	// Token: 0x04000002 RID: 2
	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x1C")]
	public Quaternion rotation;

	// Token: 0x04000003 RID: 3
	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x2C")]
	public float size;

	// Token: 0x04000004 RID: 4
	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x30")]
	public bool Merged;

	// Token: 0x04000005 RID: 5
	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x31")]
	public bool Enclosed;

	// Token: 0x04000006 RID: 6
	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x32")]
	public bool Source;

	// Token: 0x04000007 RID: 7
	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x38")]
	public List<DiggingVirtualNode> mergedFrom;

	// Token: 0x04000008 RID: 8
	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x40")]
	private bool _blockMerge;
}
