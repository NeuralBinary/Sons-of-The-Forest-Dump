using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000190 RID: 400
[Token(Token = "0x2000190")]
[ExecuteInEditMode]
[Serializable]
public class CreateFirePoints : MonoBehaviour
{
	// Token: 0x06000C10 RID: 3088 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C10")]
	[Address(RVA = "0x36DEC60", Offset = "0x36DD260", VA = "0x1836DEC60", Slot = "4")]
	public virtual void Create()
	{
	}

	// Token: 0x06000C11 RID: 3089 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C11")]
	[Address(RVA = "0x36DF610", Offset = "0x36DDC10", VA = "0x1836DF610", Slot = "5")]
	public virtual void DestroyP()
	{
	}

	// Token: 0x06000C12 RID: 3090 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C12")]
	[Address(RVA = "0x36DF990", Offset = "0x36DDF90", VA = "0x1836DF990")]
	public CreateFirePoints()
	{
	}

	// Token: 0x04000A9A RID: 2714
	[Token(Token = "0x4000A9A")]
	[FieldOffset(Offset = "0x20")]
	public Transform FireDot;

	// Token: 0x04000A9B RID: 2715
	[Token(Token = "0x4000A9B")]
	[FieldOffset(Offset = "0x28")]
	private int count;

	// Token: 0x04000A9C RID: 2716
	[Token(Token = "0x4000A9C")]
	[FieldOffset(Offset = "0x2C")]
	private bool warning;

	// Token: 0x04000A9D RID: 2717
	[Token(Token = "0x4000A9D")]
	[FieldOffset(Offset = "0x30")]
	public string TString;

	// Token: 0x04000A9E RID: 2718
	[Token(Token = "0x4000A9E")]
	[FieldOffset(Offset = "0x38")]
	private int createRatio;

	// Token: 0x04000A9F RID: 2719
	[Token(Token = "0x4000A9F")]
	[FieldOffset(Offset = "0x3C")]
	private int looper;
}
