using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000191 RID: 401
[Token(Token = "0x2000191")]
[ExecuteInEditMode]
[Serializable]
public class CreateFirePoints : MonoBehaviour
{
	// Token: 0x06000BB6 RID: 2998 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BB6")]
	[Address(RVA = "0x2F62810", Offset = "0x2F61810", VA = "0x182F62810", Slot = "4")]
	public virtual void Create()
	{
	}

	// Token: 0x06000BB7 RID: 2999 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BB7")]
	[Address(RVA = "0x2F62E30", Offset = "0x2F61E30", VA = "0x182F62E30", Slot = "5")]
	public virtual void DestroyP()
	{
	}

	// Token: 0x06000BB8 RID: 3000 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BB8")]
	[Address(RVA = "0x2F62F60", Offset = "0x2F61F60", VA = "0x182F62F60")]
	public CreateFirePoints()
	{
	}

	// Token: 0x04000A6F RID: 2671
	[Token(Token = "0x4000A6F")]
	[FieldOffset(Offset = "0x20")]
	public Transform FireDot;

	// Token: 0x04000A70 RID: 2672
	[Token(Token = "0x4000A70")]
	[FieldOffset(Offset = "0x28")]
	private int count;

	// Token: 0x04000A71 RID: 2673
	[Token(Token = "0x4000A71")]
	[FieldOffset(Offset = "0x2C")]
	private bool warning;

	// Token: 0x04000A72 RID: 2674
	[Token(Token = "0x4000A72")]
	[FieldOffset(Offset = "0x30")]
	public string TString;

	// Token: 0x04000A73 RID: 2675
	[Token(Token = "0x4000A73")]
	[FieldOffset(Offset = "0x38")]
	private int createRatio;

	// Token: 0x04000A74 RID: 2676
	[Token(Token = "0x4000A74")]
	[FieldOffset(Offset = "0x3C")]
	private int looper;
}
