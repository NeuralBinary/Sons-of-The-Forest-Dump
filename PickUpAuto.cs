using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000222 RID: 546
[Token(Token = "0x2000222")]
[Serializable]
public class PickUpAuto : MonoBehaviour
{
	// Token: 0x06000E4D RID: 3661 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E4D")]
	[Address(RVA = "0x2F9C350", Offset = "0x2F9B350", VA = "0x182F9C350", Slot = "4")]
	public virtual void OnTriggerEnter(Collider otherObject)
	{
	}

	// Token: 0x06000E4E RID: 3662 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E4E")]
	[Address(RVA = "0x2F9C490", Offset = "0x2F9B490", VA = "0x182F9C490")]
	public PickUpAuto()
	{
	}

	// Token: 0x04000D5E RID: 3422
	[Token(Token = "0x4000D5E")]
	[FieldOffset(Offset = "0x20")]
	public bool Tooth;

	// Token: 0x04000D5F RID: 3423
	[Token(Token = "0x4000D5F")]
	[FieldOffset(Offset = "0x21")]
	public bool Leaf;

	// Token: 0x04000D60 RID: 3424
	[Token(Token = "0x4000D60")]
	[FieldOffset(Offset = "0x22")]
	public bool PlaneAxe;
}
