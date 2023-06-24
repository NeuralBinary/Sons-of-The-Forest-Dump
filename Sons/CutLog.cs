using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001E4 RID: 484
[Token(Token = "0x20001E4")]
[Serializable]
public class CutLog : MonoBehaviour
{
	// Token: 0x06000DCF RID: 3535 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DCF")]
	[Address(RVA = "0x370B060", Offset = "0x3709660", VA = "0x18370B060", Slot = "4")]
	public virtual void OnTriggerEnter(Collider otherObject)
	{
	}

	// Token: 0x06000DD0 RID: 3536 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DD0")]
	[Address(RVA = "0x370B220", Offset = "0x3709820", VA = "0x18370B220", Slot = "5")]
	public virtual void Update()
	{
	}

	// Token: 0x06000DD1 RID: 3537 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DD1")]
	[Address(RVA = "0x370B3A0", Offset = "0x37099A0", VA = "0x18370B3A0", Slot = "6")]
	public virtual void OnTriggerExit(Collider otherObject)
	{
	}

	// Token: 0x06000DD2 RID: 3538 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DD2")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public CutLog()
	{
	}

	// Token: 0x04000CC1 RID: 3265
	[Token(Token = "0x4000CC1")]
	[FieldOffset(Offset = "0x20")]
	public GameObject MyTree;

	// Token: 0x04000CC2 RID: 3266
	[Token(Token = "0x4000CC2")]
	[FieldOffset(Offset = "0x28")]
	public GameObject CutTree;

	// Token: 0x04000CC3 RID: 3267
	[Token(Token = "0x4000CC3")]
	[FieldOffset(Offset = "0x30")]
	private GameObject Player;

	// Token: 0x04000CC4 RID: 3268
	[Token(Token = "0x4000CC4")]
	[FieldOffset(Offset = "0x38")]
	private bool PlayerHere;
}
