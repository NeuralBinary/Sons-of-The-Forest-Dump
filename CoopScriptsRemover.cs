using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000D0 RID: 208
[Token(Token = "0x20000D0")]
public class CoopScriptsRemover : EntityBehaviour
{
	// Token: 0x0600062A RID: 1578 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600062A")]
	[Address(RVA = "0x2E7B700", Offset = "0x2E7A700", VA = "0x182E7B700", Slot = "16")]
	public override void Attached()
	{
	}

	// Token: 0x0600062B RID: 1579 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600062B")]
	[Address(RVA = "0x59FF50", Offset = "0x59EF50", VA = "0x18059FF50")]
	public CoopScriptsRemover()
	{
	}

	// Token: 0x04000559 RID: 1369
	[Token(Token = "0x4000559")]
	[FieldOffset(Offset = "0x28")]
	public Component[] RemoveInCoop;
}
