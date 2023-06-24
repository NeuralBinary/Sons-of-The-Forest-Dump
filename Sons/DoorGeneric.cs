using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001EC RID: 492
[Token(Token = "0x20001EC")]
[Serializable]
public class DoorGeneric : MonoBehaviour
{
	// Token: 0x06000DF6 RID: 3574 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DF6")]
	[Address(RVA = "0x370FD70", Offset = "0x370E370", VA = "0x18370FD70", Slot = "4")]
	public virtual void OpenDoor()
	{
	}

	// Token: 0x06000DF7 RID: 3575 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DF7")]
	[Address(RVA = "0x370FDB0", Offset = "0x370E3B0", VA = "0x18370FDB0", Slot = "5")]
	public virtual void Update()
	{
	}

	// Token: 0x06000DF8 RID: 3576 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DF8")]
	[Address(RVA = "0x370FFF0", Offset = "0x370E5F0", VA = "0x18370FFF0", Slot = "6")]
	public virtual IEnumerator Stop()
	{
		return null;
	}

	// Token: 0x06000DF9 RID: 3577 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DF9")]
	[Address(RVA = "0x3710080", Offset = "0x370E680", VA = "0x183710080")]
	public DoorGeneric()
	{
	}

	// Token: 0x04000CF0 RID: 3312
	[Token(Token = "0x4000CF0")]
	[FieldOffset(Offset = "0x20")]
	public Transform Left;

	// Token: 0x04000CF1 RID: 3313
	[Token(Token = "0x4000CF1")]
	[FieldOffset(Offset = "0x28")]
	public Transform Right;

	// Token: 0x04000CF2 RID: 3314
	[Token(Token = "0x4000CF2")]
	[FieldOffset(Offset = "0x30")]
	public bool ShouldOpen;

	// Token: 0x04000CF3 RID: 3315
	[Token(Token = "0x4000CF3")]
	[FieldOffset(Offset = "0x34")]
	public int Speed;
}
