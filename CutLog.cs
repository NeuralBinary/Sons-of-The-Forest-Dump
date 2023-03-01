using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001E5 RID: 485
[Token(Token = "0x20001E5")]
[Serializable]
public class CutLog : MonoBehaviour
{
	// Token: 0x06000D74 RID: 3444 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D74")]
	[Address(RVA = "0x2F840C0", Offset = "0x2F830C0", VA = "0x182F840C0", Slot = "4")]
	public virtual void OnTriggerEnter(Collider otherObject)
	{
	}

	// Token: 0x06000D75 RID: 3445 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D75")]
	[Address(RVA = "0x2F84200", Offset = "0x2F83200", VA = "0x182F84200", Slot = "5")]
	public virtual void Update()
	{
	}

	// Token: 0x06000D76 RID: 3446 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D76")]
	[Address(RVA = "0x2F84170", Offset = "0x2F83170", VA = "0x182F84170", Slot = "6")]
	public virtual void OnTriggerExit(Collider otherObject)
	{
	}

	// Token: 0x06000D77 RID: 3447 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D77")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public CutLog()
	{
	}

	// Token: 0x04000C92 RID: 3218
	[Token(Token = "0x4000C92")]
	[FieldOffset(Offset = "0x20")]
	public GameObject MyTree;

	// Token: 0x04000C93 RID: 3219
	[Token(Token = "0x4000C93")]
	[FieldOffset(Offset = "0x28")]
	public GameObject CutTree;

	// Token: 0x04000C94 RID: 3220
	[Token(Token = "0x4000C94")]
	[FieldOffset(Offset = "0x30")]
	private GameObject Player;

	// Token: 0x04000C95 RID: 3221
	[Token(Token = "0x4000C95")]
	[FieldOffset(Offset = "0x38")]
	private bool PlayerHere;
}
