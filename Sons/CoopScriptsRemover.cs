using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000CE RID: 206
[Token(Token = "0x20000CE")]
public class CoopScriptsRemover : EntityBehaviour
{
	// Token: 0x06000662 RID: 1634 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000662")]
	[Address(RVA = "0x3518ED0", Offset = "0x35174D0", VA = "0x183518ED0", Slot = "16")]
	public override void Attached()
	{
	}

	// Token: 0x06000663 RID: 1635 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000663")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public CoopScriptsRemover()
	{
	}

	// Token: 0x04000573 RID: 1395
	[Token(Token = "0x4000573")]
	[FieldOffset(Offset = "0x28")]
	public Component[] RemoveInCoop;
}
