using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000221 RID: 545
[Token(Token = "0x2000221")]
[Serializable]
public class PickUpAuto : MonoBehaviour
{
	// Token: 0x06000EA8 RID: 3752 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EA8")]
	[Address(RVA = "0x371BA90", Offset = "0x371A090", VA = "0x18371BA90", Slot = "4")]
	public virtual void OnTriggerEnter(Collider otherObject)
	{
	}

	// Token: 0x06000EA9 RID: 3753 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EA9")]
	[Address(RVA = "0x371BD30", Offset = "0x371A330", VA = "0x18371BD30")]
	public PickUpAuto()
	{
	}

	// Token: 0x04000D8D RID: 3469
	[Token(Token = "0x4000D8D")]
	[FieldOffset(Offset = "0x20")]
	public bool Tooth;

	// Token: 0x04000D8E RID: 3470
	[Token(Token = "0x4000D8E")]
	[FieldOffset(Offset = "0x21")]
	public bool Leaf;

	// Token: 0x04000D8F RID: 3471
	[Token(Token = "0x4000D8F")]
	[FieldOffset(Offset = "0x22")]
	public bool PlaneAxe;
}
