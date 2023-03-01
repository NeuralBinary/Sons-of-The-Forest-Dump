using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200025B RID: 603
[Token(Token = "0x200025B")]
[Serializable]
public class ShelterWarmth : MonoBehaviour
{
	// Token: 0x06001067 RID: 4199 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001067")]
	[Address(RVA = "0x2FBA0D0", Offset = "0x2FB90D0", VA = "0x182FBA0D0", Slot = "4")]
	public virtual void Awake()
	{
	}

	// Token: 0x06001068 RID: 4200 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001068")]
	[Address(RVA = "0x2FBA120", Offset = "0x2FB9120", VA = "0x182FBA120", Slot = "5")]
	public virtual void OnTriggerEnter(Collider otherObject)
	{
	}

	// Token: 0x06001069 RID: 4201 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001069")]
	[Address(RVA = "0x2FBA1D0", Offset = "0x2FB91D0", VA = "0x182FBA1D0", Slot = "6")]
	public virtual void OnTriggerExit(Collider otherObject)
	{
	}

	// Token: 0x0600106A RID: 4202 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600106A")]
	[Address(RVA = "0x2FBA290", Offset = "0x2FB9290", VA = "0x182FBA290", Slot = "7")]
	public virtual void Update()
	{
	}

	// Token: 0x0600106B RID: 4203 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600106B")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public ShelterWarmth()
	{
	}

	// Token: 0x04000F76 RID: 3958
	[Token(Token = "0x4000F76")]
	[FieldOffset(Offset = "0x20")]
	private GameObject Player;

	// Token: 0x04000F77 RID: 3959
	[Token(Token = "0x4000F77")]
	[FieldOffset(Offset = "0x28")]
	private bool playerHere;
}
