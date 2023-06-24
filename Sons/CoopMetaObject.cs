using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020000C1 RID: 193
[Token(Token = "0x20000C1")]
public class CoopMetaObject : EntityBehaviour, IPriorityCalculator
{
	// Token: 0x170000E6 RID: 230
	// (get) Token: 0x0600062E RID: 1582 RVA: 0x00003E10 File Offset: 0x00002010
	[Token(Token = "0x170000E6")]
	private bool Always
	{
		[Token(Token = "0x600062E")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x0600062F RID: 1583 RVA: 0x00003E28 File Offset: 0x00002028
	[Token(Token = "0x600062F")]
	[Address(RVA = "0x3513AC0", Offset = "0x35120C0", VA = "0x183513AC0", Slot = "25")]
	private float CalculateEventPriority(BoltConnection connection, Event evnt)
	{
		return 0f;
	}

	// Token: 0x06000630 RID: 1584 RVA: 0x00003E40 File Offset: 0x00002040
	[Token(Token = "0x6000630")]
	[Address(RVA = "0x3513AC0", Offset = "0x35120C0", VA = "0x183513AC0", Slot = "24")]
	private float CalculateStatePriority(BoltConnection connection, int skipped)
	{
		return 0f;
	}

	// Token: 0x06000631 RID: 1585 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000631")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public CoopMetaObject()
	{
	}
}
