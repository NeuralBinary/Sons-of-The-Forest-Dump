using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200011C RID: 284
[Token(Token = "0x200011C")]
public class exitClimb : MonoBehaviour
{
	// Token: 0x06000853 RID: 2131 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000853")]
	[Address(RVA = "0x2F47F10", Offset = "0x2F46F10", VA = "0x182F47F10")]
	private void Start()
	{
	}

	// Token: 0x06000854 RID: 2132 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000854")]
	[Address(RVA = "0x2F47D60", Offset = "0x2F46D60", VA = "0x182F47D60")]
	private void OnTriggerStay(Collider other)
	{
	}

	// Token: 0x06000855 RID: 2133 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000855")]
	[Address(RVA = "0x6890E0", Offset = "0x6880E0", VA = "0x1806890E0")]
	private void resetCoolDown()
	{
	}

	// Token: 0x06000856 RID: 2134 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000856")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public exitClimb()
	{
	}

	// Token: 0x040006BE RID: 1726
	[Token(Token = "0x40006BE")]
	[FieldOffset(Offset = "0x20")]
	public exitClimb.Types climbType;

	// Token: 0x040006BF RID: 1727
	[Token(Token = "0x40006BF")]
	[FieldOffset(Offset = "0x28")]
	private BoxCollider _collider;

	// Token: 0x040006C0 RID: 1728
	[Token(Token = "0x40006C0")]
	[FieldOffset(Offset = "0x30")]
	private bool _triggerCoolDown;

	// Token: 0x0200011D RID: 285
	[Token(Token = "0x200011D")]
	public enum Types
	{
		// Token: 0x040006C2 RID: 1730
		[Token(Token = "0x40006C2")]
		ropeClimb,
		// Token: 0x040006C3 RID: 1731
		[Token(Token = "0x40006C3")]
		wallClimb
	}
}
