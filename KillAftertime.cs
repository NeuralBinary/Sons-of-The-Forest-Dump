using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200020D RID: 525
[Token(Token = "0x200020D")]
[Serializable]
public class KillAftertime : MonoBehaviour
{
	// Token: 0x06000DFF RID: 3583 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DFF")]
	[Address(RVA = "0x2F8ED10", Offset = "0x2F8DD10", VA = "0x182F8ED10", Slot = "4")]
	public virtual void Awake()
	{
	}

	// Token: 0x06000E00 RID: 3584 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E00")]
	[Address(RVA = "0x2F8ED90", Offset = "0x2F8DD90", VA = "0x182F8ED90", Slot = "5")]
	public virtual IEnumerator Kill()
	{
		return null;
	}

	// Token: 0x06000E01 RID: 3585 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E01")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public KillAftertime()
	{
	}

	// Token: 0x04000D20 RID: 3360
	[Token(Token = "0x4000D20")]
	[FieldOffset(Offset = "0x20")]
	public float Amount;
}
