using System;
using System.Collections;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020000A7 RID: 167
[Token(Token = "0x20000A7")]
public class CoopAutoParent : EntityBehaviour<IHierarchyObjectState>, IEntityReplicationFilter
{
	// Token: 0x170000D0 RID: 208
	// (get) Token: 0x06000588 RID: 1416 RVA: 0x00003A68 File Offset: 0x00001C68
	[Token(Token = "0x170000D0")]
	public bool Ready
	{
		[Token(Token = "0x6000588")]
		[Address(RVA = "0x5BA880", Offset = "0x5B9880", VA = "0x1805BA880")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000589 RID: 1417 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000589")]
	[Address(RVA = "0x2E71130", Offset = "0x2E70130", VA = "0x182E71130", Slot = "16")]
	public override void Attached()
	{
	}

	// Token: 0x0600058A RID: 1418 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600058A")]
	[Address(RVA = "0x2E712A0", Offset = "0x2E702A0", VA = "0x182E712A0")]
	private IEnumerator DelayedAttached()
	{
		return null;
	}

	// Token: 0x0600058B RID: 1419 RVA: 0x00003A80 File Offset: 0x00001C80
	[Token(Token = "0x600058B")]
	[Address(RVA = "0x2E711A0", Offset = "0x2E701A0", VA = "0x182E711A0", Slot = "24")]
	private bool AllowReplicationTo(BoltConnection connection)
	{
		return default(bool);
	}

	// Token: 0x0600058C RID: 1420 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600058C")]
	[Address(RVA = "0x2E71310", Offset = "0x2E70310", VA = "0x182E71310")]
	public CoopAutoParent()
	{
	}

	// Token: 0x040004FA RID: 1274
	[Token(Token = "0x40004FA")]
	[FieldOffset(Offset = "0x28")]
	private bool _ready;
}
