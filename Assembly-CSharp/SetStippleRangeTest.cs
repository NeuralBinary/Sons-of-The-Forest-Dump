using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Lodding;
using UnityEngine;

// Token: 0x02000008 RID: 8
[Token(Token = "0x2000008")]
[ExecuteInEditMode]
public class SetStippleRangeTest : MonoBehaviour
{
	// Token: 0x06000014 RID: 20 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000014")]
	[Address(RVA = "0x5C8FE0", Offset = "0x5C75E0", VA = "0x1805C8FE0")]
	private void Update()
	{
	}

	// Token: 0x06000015 RID: 21 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000015")]
	[Address(RVA = "0x5C9470", Offset = "0x5C7A70", VA = "0x1805C9470")]
	public SetStippleRangeTest()
	{
	}

	// Token: 0x04000032 RID: 50
	[Token(Token = "0x4000032")]
	[FieldOffset(Offset = "0x20")]
	public List<CustomBillboard> _billboards;

	// Token: 0x04000033 RID: 51
	[Token(Token = "0x4000033")]
	[FieldOffset(Offset = "0x28")]
	public float stippleNear;

	// Token: 0x04000034 RID: 52
	[Token(Token = "0x4000034")]
	[FieldOffset(Offset = "0x2C")]
	public float stippleFar;

	// Token: 0x04000035 RID: 53
	[Token(Token = "0x4000035")]
	[FieldOffset(Offset = "0x30")]
	public float billboardShadowDist;
}
