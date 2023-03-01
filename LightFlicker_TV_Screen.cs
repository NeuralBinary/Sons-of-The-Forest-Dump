using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000212 RID: 530
[Token(Token = "0x2000212")]
[Serializable]
public class LightFlicker_TV_Screen : MonoBehaviour
{
	// Token: 0x06000E12 RID: 3602 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E12")]
	[Address(RVA = "0x2F9AA10", Offset = "0x2F99A10", VA = "0x182F9AA10", Slot = "4")]
	public virtual void Start()
	{
	}

	// Token: 0x06000E13 RID: 3603 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E13")]
	[Address(RVA = "0x2F9A8E0", Offset = "0x2F998E0", VA = "0x182F9A8E0", Slot = "5")]
	public virtual void Flicker()
	{
	}

	// Token: 0x06000E14 RID: 3604 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E14")]
	[Address(RVA = "0x2F9AA60", Offset = "0x2F99A60", VA = "0x182F9AA60")]
	public LightFlicker_TV_Screen()
	{
	}

	// Token: 0x04000D28 RID: 3368
	[Token(Token = "0x4000D28")]
	[FieldOffset(Offset = "0x20")]
	public float FlickerSpeed;

	// Token: 0x04000D29 RID: 3369
	[Token(Token = "0x4000D29")]
	[FieldOffset(Offset = "0x24")]
	public int LightMaxRange;

	// Token: 0x04000D2A RID: 3370
	[Token(Token = "0x4000D2A")]
	[FieldOffset(Offset = "0x28")]
	public int LightMinRange;

	// Token: 0x04000D2B RID: 3371
	[Token(Token = "0x4000D2B")]
	[FieldOffset(Offset = "0x2C")]
	private Color MyColor;
}
