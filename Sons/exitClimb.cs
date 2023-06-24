using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000119 RID: 281
[Token(Token = "0x2000119")]
public class exitClimb : MonoBehaviour
{
	// Token: 0x0600089A RID: 2202 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600089A")]
	[Address(RVA = "0x3689FD0", Offset = "0x36885D0", VA = "0x183689FD0")]
	private void Start()
	{
	}

	// Token: 0x0600089B RID: 2203 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600089B")]
	[Address(RVA = "0x368A110", Offset = "0x3688710", VA = "0x18368A110")]
	private void OnTriggerStay(Collider other)
	{
	}

	// Token: 0x0600089C RID: 2204 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600089C")]
	[Address(RVA = "0x737F70", Offset = "0x736570", VA = "0x180737F70")]
	private void resetCoolDown()
	{
	}

	// Token: 0x0600089D RID: 2205 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600089D")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public exitClimb()
	{
	}

	// Token: 0x040006DA RID: 1754
	[Token(Token = "0x40006DA")]
	[FieldOffset(Offset = "0x20")]
	public exitClimb.Types climbType;

	// Token: 0x040006DB RID: 1755
	[Token(Token = "0x40006DB")]
	[FieldOffset(Offset = "0x28")]
	private BoxCollider _collider;

	// Token: 0x040006DC RID: 1756
	[Token(Token = "0x40006DC")]
	[FieldOffset(Offset = "0x30")]
	private bool _triggerCoolDown;

	// Token: 0x0200011A RID: 282
	[Token(Token = "0x200011A")]
	public enum Types
	{
		// Token: 0x040006DE RID: 1758
		[Token(Token = "0x40006DE")]
		ropeClimb,
		// Token: 0x040006DF RID: 1759
		[Token(Token = "0x40006DF")]
		wallClimb
	}
}
