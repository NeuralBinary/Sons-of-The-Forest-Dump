using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000213 RID: 531
[Token(Token = "0x2000213")]
[Serializable]
public class Light_Flicker : MonoBehaviour
{
	// Token: 0x06000E73 RID: 3699 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E73")]
	[Address(RVA = "0x3718F90", Offset = "0x3717590", VA = "0x183718F90", Slot = "4")]
	public virtual void Start()
	{
	}

	// Token: 0x06000E74 RID: 3700 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E74")]
	[Address(RVA = "0x3719220", Offset = "0x3717820", VA = "0x183719220", Slot = "5")]
	public virtual void OneLightChange()
	{
	}

	// Token: 0x06000E75 RID: 3701 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E75")]
	[Address(RVA = "0x37192A0", Offset = "0x37178A0", VA = "0x1837192A0", Slot = "6")]
	public virtual void Update()
	{
	}

	// Token: 0x06000E76 RID: 3702 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E76")]
	[Address(RVA = "0x3719550", Offset = "0x3717B50", VA = "0x183719550")]
	public Light_Flicker()
	{
	}

	// Token: 0x04000D5E RID: 3422
	[Token(Token = "0x4000D5E")]
	[FieldOffset(Offset = "0x20")]
	public float time;

	// Token: 0x04000D5F RID: 3423
	[Token(Token = "0x4000D5F")]
	[FieldOffset(Offset = "0x24")]
	public float min;

	// Token: 0x04000D60 RID: 3424
	[Token(Token = "0x4000D60")]
	[FieldOffset(Offset = "0x28")]
	public float max;

	// Token: 0x04000D61 RID: 3425
	[Token(Token = "0x4000D61")]
	[FieldOffset(Offset = "0x2C")]
	public bool useSmooth;

	// Token: 0x04000D62 RID: 3426
	[Token(Token = "0x4000D62")]
	[FieldOffset(Offset = "0x30")]
	public float smoothTime;

	// Token: 0x04000D63 RID: 3427
	[Token(Token = "0x4000D63")]
	[FieldOffset(Offset = "0x38")]
	public Light _light;
}
