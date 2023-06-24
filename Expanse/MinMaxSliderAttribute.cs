using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000002 RID: 2
[Token(Token = "0x2000002")]
[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
public class MinMaxSliderAttribute : PropertyAttribute
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000001")]
	[Address(RVA = "0xAB20B0", Offset = "0xAB06B0", VA = "0x180AB20B0")]
	public MinMaxSliderAttribute()
	{
	}

	// Token: 0x06000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000002")]
	[Address(RVA = "0xAB20C0", Offset = "0xAB06C0", VA = "0x180AB20C0")]
	public MinMaxSliderAttribute(float min, float max)
	{
	}

	// Token: 0x04000001 RID: 1
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x18")]
	public readonly float min;

	// Token: 0x04000002 RID: 2
	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x1C")]
	public readonly float max;
}
