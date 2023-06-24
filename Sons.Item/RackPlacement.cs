using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

// Token: 0x02000010 RID: 16
[Token(Token = "0x2000010")]
[Serializable]
public class RackPlacement
{
	// Token: 0x06000019 RID: 25 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000019")]
	[Address(RVA = "0x30ADBA0", Offset = "0x30AC1A0", VA = "0x1830ADBA0")]
	public void ApplyTo(ref Vector3 itemLocalPos, ref Quaternion itemLocalRot, ref Vector3 itemScale)
	{
	}

	// Token: 0x0600001A RID: 26 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001A")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	public RackPlacement()
	{
	}

	// Token: 0x0400006B RID: 107
	[Token(Token = "0x400006B")]
	[FieldOffset(Offset = "0x10")]
	[FormerlySerializedAs("Type")]
	public RackPlacementTypes PlacementType;

	// Token: 0x0400006C RID: 108
	[Token(Token = "0x400006C")]
	[FieldOffset(Offset = "0x14")]
	public Vector3 Position;

	// Token: 0x0400006D RID: 109
	[Token(Token = "0x400006D")]
	[FieldOffset(Offset = "0x20")]
	public Vector3 Scale;

	// Token: 0x0400006E RID: 110
	[Token(Token = "0x400006E")]
	[FieldOffset(Offset = "0x2C")]
	public Vector3 Rotation;
}
