using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001D9 RID: 473
[Token(Token = "0x20001D9")]
[Serializable]
public class CastWeb : MonoBehaviour
{
	// Token: 0x06000D91 RID: 3473 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D91")]
	[Address(RVA = "0x2830D10", Offset = "0x282F310", VA = "0x182830D10", Slot = "4")]
	public virtual void Awake()
	{
	}

	// Token: 0x06000D92 RID: 3474 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D92")]
	[Address(RVA = "0x3704B60", Offset = "0x3703160", VA = "0x183704B60", Slot = "5")]
	public virtual void Cast()
	{
	}

	// Token: 0x06000D93 RID: 3475 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D93")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public CastWeb()
	{
	}

	// Token: 0x04000C6D RID: 3181
	[Token(Token = "0x4000C6D")]
	[FieldOffset(Offset = "0x20")]
	public GameObject Web;

	// Token: 0x04000C6E RID: 3182
	[Token(Token = "0x4000C6E")]
	[FieldOffset(Offset = "0x28")]
	private Vector3 distance;

	// Token: 0x04000C6F RID: 3183
	[Token(Token = "0x4000C6F")]
	[FieldOffset(Offset = "0x34")]
	private Vector3 fwd;
}
