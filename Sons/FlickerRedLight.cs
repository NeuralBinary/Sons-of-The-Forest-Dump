using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001F7 RID: 503
[Token(Token = "0x20001F7")]
[Serializable]
public class FlickerRedLight : MonoBehaviour
{
	// Token: 0x06000E1D RID: 3613 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E1D")]
	[Address(RVA = "0x3712280", Offset = "0x3710880", VA = "0x183712280", Slot = "4")]
	public virtual void Start()
	{
	}

	// Token: 0x06000E1E RID: 3614 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E1E")]
	[Address(RVA = "0x37122D0", Offset = "0x37108D0", VA = "0x1837122D0", Slot = "5")]
	public virtual void Flicker()
	{
	}

	// Token: 0x06000E1F RID: 3615 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E1F")]
	[Address(RVA = "0x3712390", Offset = "0x3710990", VA = "0x183712390")]
	public FlickerRedLight()
	{
	}

	// Token: 0x04000D0B RID: 3339
	[Token(Token = "0x4000D0B")]
	[FieldOffset(Offset = "0x20")]
	public float FlickerSpeed;

	// Token: 0x04000D0C RID: 3340
	[Token(Token = "0x4000D0C")]
	[FieldOffset(Offset = "0x24")]
	public float LightMaxRange;

	// Token: 0x04000D0D RID: 3341
	[Token(Token = "0x4000D0D")]
	[FieldOffset(Offset = "0x28")]
	public float LightMinRange;
}
