using System;
using System.Collections;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020000A6 RID: 166
[Token(Token = "0x20000A6")]
public class CoopAutoParent : EntityBehaviour<IHierarchyObjectState>, IEntityReplicationFilter
{
	// Token: 0x170000D7 RID: 215
	// (get) Token: 0x060005C2 RID: 1474 RVA: 0x00003C30 File Offset: 0x00001E30
	[Token(Token = "0x170000D7")]
	public bool Ready
	{
		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x6599C0", Offset = "0x657FC0", VA = "0x1806599C0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060005C3 RID: 1475 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005C3")]
	[Address(RVA = "0x350EA20", Offset = "0x350D020", VA = "0x18350EA20", Slot = "16")]
	public override void Attached()
	{
	}

	// Token: 0x060005C4 RID: 1476 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005C4")]
	[Address(RVA = "0x350EAC0", Offset = "0x350D0C0", VA = "0x18350EAC0")]
	private IEnumerator DelayedAttached()
	{
		return null;
	}

	// Token: 0x060005C5 RID: 1477 RVA: 0x00003C48 File Offset: 0x00001E48
	[Token(Token = "0x60005C5")]
	[Address(RVA = "0x350EB50", Offset = "0x350D150", VA = "0x18350EB50", Slot = "24")]
	private bool AllowReplicationTo(BoltConnection connection)
	{
		return default(bool);
	}

	// Token: 0x060005C6 RID: 1478 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005C6")]
	[Address(RVA = "0x350EE20", Offset = "0x350D420", VA = "0x18350EE20")]
	public CoopAutoParent()
	{
	}

	// Token: 0x0400051B RID: 1307
	[Token(Token = "0x400051B")]
	[FieldOffset(Offset = "0x28")]
	private bool _ready;
}
