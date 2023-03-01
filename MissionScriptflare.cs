using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200021A RID: 538
[Token(Token = "0x200021A")]
[Serializable]
public class MissionScriptflare : MonoBehaviour
{
	// Token: 0x06000E2F RID: 3631 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E2F")]
	[Address(RVA = "0x2F9B250", Offset = "0x2F9A250", VA = "0x182F9B250", Slot = "4")]
	public virtual void OnTriggerEnter(Collider otherObject)
	{
	}

	// Token: 0x06000E30 RID: 3632 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E30")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public MissionScriptflare()
	{
	}

	// Token: 0x04000D47 RID: 3399
	[Token(Token = "0x4000D47")]
	[FieldOffset(Offset = "0x20")]
	public bool FlareTrigger;

	// Token: 0x04000D48 RID: 3400
	[Token(Token = "0x4000D48")]
	[FieldOffset(Offset = "0x21")]
	public bool IslandTrigger;

	// Token: 0x04000D49 RID: 3401
	[Token(Token = "0x4000D49")]
	[FieldOffset(Offset = "0x22")]
	public bool HallTrigger;

	// Token: 0x04000D4A RID: 3402
	[Token(Token = "0x4000D4A")]
	[FieldOffset(Offset = "0x28")]
	public GameObject MyObject;
}
