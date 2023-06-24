using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200020C RID: 524
[Token(Token = "0x200020C")]
[Serializable]
public class KillAftertime : MonoBehaviour
{
	// Token: 0x06000E5A RID: 3674 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E5A")]
	[Address(RVA = "0x3717D70", Offset = "0x3716370", VA = "0x183717D70", Slot = "4")]
	public virtual void Awake()
	{
	}

	// Token: 0x06000E5B RID: 3675 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E5B")]
	[Address(RVA = "0x3717DF0", Offset = "0x37163F0", VA = "0x183717DF0", Slot = "5")]
	public virtual IEnumerator Kill()
	{
		return null;
	}

	// Token: 0x06000E5C RID: 3676 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E5C")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public KillAftertime()
	{
	}

	// Token: 0x04000D4F RID: 3407
	[Token(Token = "0x4000D4F")]
	[FieldOffset(Offset = "0x20")]
	public float Amount;
}
