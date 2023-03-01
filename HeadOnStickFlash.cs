using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000203 RID: 515
[Token(Token = "0x2000203")]
[Serializable]
public class HeadOnStickFlash : MonoBehaviour
{
	// Token: 0x06000DE2 RID: 3554 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DE2")]
	[Address(RVA = "0x2F8D2E0", Offset = "0x2F8C2E0", VA = "0x182F8D2E0", Slot = "4")]
	public virtual void OnTriggerEnter(Collider otherObject)
	{
	}

	// Token: 0x06000DE3 RID: 3555 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DE3")]
	[Address(RVA = "0x2F8D280", Offset = "0x2F8C280", VA = "0x182F8D280", Slot = "5")]
	public virtual void LightOff()
	{
	}

	// Token: 0x06000DE4 RID: 3556 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DE4")]
	[Address(RVA = "0x5F61F0", Offset = "0x5F51F0", VA = "0x1805F61F0", Slot = "6")]
	public virtual void NoDelay()
	{
	}

	// Token: 0x06000DE5 RID: 3557 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DE5")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public HeadOnStickFlash()
	{
	}

	// Token: 0x04000D05 RID: 3333
	[Token(Token = "0x4000D05")]
	[FieldOffset(Offset = "0x20")]
	public GameObject MyLight;

	// Token: 0x04000D06 RID: 3334
	[Token(Token = "0x4000D06")]
	[FieldOffset(Offset = "0x28")]
	private bool Delay;
}
