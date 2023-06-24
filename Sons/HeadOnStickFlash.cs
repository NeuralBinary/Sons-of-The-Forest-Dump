using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000202 RID: 514
[Token(Token = "0x2000202")]
[Serializable]
public class HeadOnStickFlash : MonoBehaviour
{
	// Token: 0x06000E3D RID: 3645 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E3D")]
	[Address(RVA = "0x3715B30", Offset = "0x3714130", VA = "0x183715B30", Slot = "4")]
	public virtual void OnTriggerEnter(Collider otherObject)
	{
	}

	// Token: 0x06000E3E RID: 3646 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E3E")]
	[Address(RVA = "0x3715CE0", Offset = "0x37142E0", VA = "0x183715CE0", Slot = "5")]
	public virtual void LightOff()
	{
	}

	// Token: 0x06000E3F RID: 3647 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E3F")]
	[Address(RVA = "0x66EAE0", Offset = "0x66D0E0", VA = "0x18066EAE0", Slot = "6")]
	public virtual void NoDelay()
	{
	}

	// Token: 0x06000E40 RID: 3648 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E40")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public HeadOnStickFlash()
	{
	}

	// Token: 0x04000D34 RID: 3380
	[Token(Token = "0x4000D34")]
	[FieldOffset(Offset = "0x20")]
	public GameObject MyLight;

	// Token: 0x04000D35 RID: 3381
	[Token(Token = "0x4000D35")]
	[FieldOffset(Offset = "0x28")]
	private bool Delay;
}
