using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000219 RID: 537
[Token(Token = "0x2000219")]
[Serializable]
public class MissionScriptflare : MonoBehaviour
{
	// Token: 0x06000E8A RID: 3722 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E8A")]
	[Address(RVA = "0x3719C70", Offset = "0x3718270", VA = "0x183719C70", Slot = "4")]
	public virtual void OnTriggerEnter(Collider otherObject)
	{
	}

	// Token: 0x06000E8B RID: 3723 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E8B")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public MissionScriptflare()
	{
	}

	// Token: 0x04000D76 RID: 3446
	[Token(Token = "0x4000D76")]
	[FieldOffset(Offset = "0x20")]
	public bool FlareTrigger;

	// Token: 0x04000D77 RID: 3447
	[Token(Token = "0x4000D77")]
	[FieldOffset(Offset = "0x21")]
	public bool IslandTrigger;

	// Token: 0x04000D78 RID: 3448
	[Token(Token = "0x4000D78")]
	[FieldOffset(Offset = "0x22")]
	public bool HallTrigger;

	// Token: 0x04000D79 RID: 3449
	[Token(Token = "0x4000D79")]
	[FieldOffset(Offset = "0x28")]
	public GameObject MyObject;
}
