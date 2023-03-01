using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001ED RID: 493
[Token(Token = "0x20001ED")]
[Serializable]
public class DoorGeneric : MonoBehaviour
{
	// Token: 0x06000D9B RID: 3483 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D9B")]
	[Address(RVA = "0x2F875D0", Offset = "0x2F865D0", VA = "0x182F875D0", Slot = "4")]
	public virtual void OpenDoor()
	{
	}

	// Token: 0x06000D9C RID: 3484 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D9C")]
	[Address(RVA = "0x2F87680", Offset = "0x2F86680", VA = "0x182F87680", Slot = "5")]
	public virtual void Update()
	{
	}

	// Token: 0x06000D9D RID: 3485 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D9D")]
	[Address(RVA = "0x2F87610", Offset = "0x2F86610", VA = "0x182F87610", Slot = "6")]
	public virtual IEnumerator Stop()
	{
		return null;
	}

	// Token: 0x06000D9E RID: 3486 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D9E")]
	[Address(RVA = "0x2F87840", Offset = "0x2F86840", VA = "0x182F87840")]
	public DoorGeneric()
	{
	}

	// Token: 0x04000CC1 RID: 3265
	[Token(Token = "0x4000CC1")]
	[FieldOffset(Offset = "0x20")]
	public Transform Left;

	// Token: 0x04000CC2 RID: 3266
	[Token(Token = "0x4000CC2")]
	[FieldOffset(Offset = "0x28")]
	public Transform Right;

	// Token: 0x04000CC3 RID: 3267
	[Token(Token = "0x4000CC3")]
	[FieldOffset(Offset = "0x30")]
	public bool ShouldOpen;

	// Token: 0x04000CC4 RID: 3268
	[Token(Token = "0x4000CC4")]
	[FieldOffset(Offset = "0x34")]
	public int Speed;
}
