using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001F8 RID: 504
[Token(Token = "0x20001F8")]
[Serializable]
public class FlickerRedLight : MonoBehaviour
{
	// Token: 0x06000DC2 RID: 3522 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DC2")]
	[Address(RVA = "0x2F88960", Offset = "0x2F87960", VA = "0x182F88960", Slot = "4")]
	public virtual void Start()
	{
	}

	// Token: 0x06000DC3 RID: 3523 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DC3")]
	[Address(RVA = "0x2F888F0", Offset = "0x2F878F0", VA = "0x182F888F0", Slot = "5")]
	public virtual void Flicker()
	{
	}

	// Token: 0x06000DC4 RID: 3524 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DC4")]
	[Address(RVA = "0x2F889B0", Offset = "0x2F879B0", VA = "0x182F889B0")]
	public FlickerRedLight()
	{
	}

	// Token: 0x04000CDC RID: 3292
	[Token(Token = "0x4000CDC")]
	[FieldOffset(Offset = "0x20")]
	public float FlickerSpeed;

	// Token: 0x04000CDD RID: 3293
	[Token(Token = "0x4000CDD")]
	[FieldOffset(Offset = "0x24")]
	public float LightMaxRange;

	// Token: 0x04000CDE RID: 3294
	[Token(Token = "0x4000CDE")]
	[FieldOffset(Offset = "0x28")]
	public float LightMinRange;
}
