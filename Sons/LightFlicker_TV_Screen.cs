using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000211 RID: 529
[Token(Token = "0x2000211")]
[Serializable]
public class LightFlicker_TV_Screen : MonoBehaviour
{
	// Token: 0x06000E6D RID: 3693 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E6D")]
	[Address(RVA = "0x3718A20", Offset = "0x3717020", VA = "0x183718A20", Slot = "4")]
	public virtual void Start()
	{
	}

	// Token: 0x06000E6E RID: 3694 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E6E")]
	[Address(RVA = "0x3718A70", Offset = "0x3717070", VA = "0x183718A70", Slot = "5")]
	public virtual void Flicker()
	{
	}

	// Token: 0x06000E6F RID: 3695 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E6F")]
	[Address(RVA = "0x3718D10", Offset = "0x3717310", VA = "0x183718D10")]
	public LightFlicker_TV_Screen()
	{
	}

	// Token: 0x04000D57 RID: 3415
	[Token(Token = "0x4000D57")]
	[FieldOffset(Offset = "0x20")]
	public float FlickerSpeed;

	// Token: 0x04000D58 RID: 3416
	[Token(Token = "0x4000D58")]
	[FieldOffset(Offset = "0x24")]
	public int LightMaxRange;

	// Token: 0x04000D59 RID: 3417
	[Token(Token = "0x4000D59")]
	[FieldOffset(Offset = "0x28")]
	public int LightMinRange;

	// Token: 0x04000D5A RID: 3418
	[Token(Token = "0x4000D5A")]
	[FieldOffset(Offset = "0x2C")]
	private Color MyColor;
}
