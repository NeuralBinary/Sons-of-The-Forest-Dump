using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000256 RID: 598
[Token(Token = "0x2000256")]
[Serializable]
public class ShelterWarmth : MonoBehaviour
{
	// Token: 0x060010B5 RID: 4277 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010B5")]
	[Address(RVA = "0x373D820", Offset = "0x373BE20", VA = "0x18373D820", Slot = "4")]
	public virtual void Awake()
	{
	}

	// Token: 0x060010B6 RID: 4278 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010B6")]
	[Address(RVA = "0x373D8F0", Offset = "0x373BEF0", VA = "0x18373D8F0", Slot = "5")]
	public virtual void OnTriggerEnter(Collider otherObject)
	{
	}

	// Token: 0x060010B7 RID: 4279 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010B7")]
	[Address(RVA = "0x373DA50", Offset = "0x373C050", VA = "0x18373DA50", Slot = "6")]
	public virtual void OnTriggerExit(Collider otherObject)
	{
	}

	// Token: 0x060010B8 RID: 4280 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010B8")]
	[Address(RVA = "0x373DBB0", Offset = "0x373C1B0", VA = "0x18373DBB0", Slot = "7")]
	public virtual void Update()
	{
	}

	// Token: 0x060010B9 RID: 4281 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010B9")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public ShelterWarmth()
	{
	}

	// Token: 0x04000F9C RID: 3996
	[Token(Token = "0x4000F9C")]
	[FieldOffset(Offset = "0x20")]
	private GameObject Player;

	// Token: 0x04000F9D RID: 3997
	[Token(Token = "0x4000F9D")]
	[FieldOffset(Offset = "0x28")]
	private bool playerHere;
}
