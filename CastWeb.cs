using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001DA RID: 474
[Token(Token = "0x20001DA")]
[Serializable]
public class CastWeb : MonoBehaviour
{
	// Token: 0x06000D36 RID: 3382 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D36")]
	[Address(RVA = "0x23B3DD0", Offset = "0x23B2DD0", VA = "0x1823B3DD0", Slot = "4")]
	public virtual void Awake()
	{
	}

	// Token: 0x06000D37 RID: 3383 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D37")]
	[Address(RVA = "0x2F7FFF0", Offset = "0x2F7EFF0", VA = "0x182F7FFF0", Slot = "5")]
	public virtual void Cast()
	{
	}

	// Token: 0x06000D38 RID: 3384 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D38")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public CastWeb()
	{
	}

	// Token: 0x04000C3E RID: 3134
	[Token(Token = "0x4000C3E")]
	[FieldOffset(Offset = "0x20")]
	public GameObject Web;

	// Token: 0x04000C3F RID: 3135
	[Token(Token = "0x4000C3F")]
	[FieldOffset(Offset = "0x28")]
	private Vector3 distance;

	// Token: 0x04000C40 RID: 3136
	[Token(Token = "0x4000C40")]
	[FieldOffset(Offset = "0x34")]
	private Vector3 fwd;
}
