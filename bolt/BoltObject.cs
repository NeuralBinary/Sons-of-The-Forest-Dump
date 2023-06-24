using System;
using System.Runtime.CompilerServices;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200002E RID: 46
[Token(Token = "0x200002E")]
public class BoltObject : IBoltListNode
{
	// Token: 0x1700005E RID: 94
	// (get) Token: 0x060001A9 RID: 425 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x060001AA RID: 426 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700005E")]
	private object prev
	{
		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x1700005F RID: 95
	// (get) Token: 0x060001AB RID: 427 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x060001AC RID: 428 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700005F")]
	private object next
	{
		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x17000060 RID: 96
	// (get) Token: 0x060001AD RID: 429 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x060001AE RID: 430 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000060")]
	private object list
	{
		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x060001AF RID: 431 RVA: 0x00002838 File Offset: 0x00000A38
	[Token(Token = "0x60001AF")]
	[Address(RVA = "0x786DC0", Offset = "0x7853C0", VA = "0x180786DC0")]
	[Documentation(Ignore = true)]
	public static implicit operator bool(BoltObject obj)
	{
		return default(bool);
	}

	// Token: 0x060001B0 RID: 432 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001B0")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	public BoltObject()
	{
	}
}
