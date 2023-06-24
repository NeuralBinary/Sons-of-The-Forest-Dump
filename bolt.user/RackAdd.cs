using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000108 RID: 264
[Token(Token = "0x2000108")]
public class RackAdd : Event
{
	// Token: 0x06000C1D RID: 3101 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C1D")]
	[Address(RVA = "0x858850", Offset = "0x856E50", VA = "0x180858850")]
	public RackAdd()
	{
	}

	// Token: 0x17000524 RID: 1316
	// (get) Token: 0x06000C1E RID: 3102 RVA: 0x00005C10 File Offset: 0x00003E10
	// (set) Token: 0x06000C1F RID: 3103 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000524")]
	public int Slot
	{
		[Token(Token = "0x6000C1E")]
		[Address(RVA = "0x7B5360", Offset = "0x7B3960", VA = "0x1807B5360")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000C1F")]
		[Address(RVA = "0x7EB470", Offset = "0x7E9A70", VA = "0x1807EB470")]
		set
		{
		}
	}

	// Token: 0x17000525 RID: 1317
	// (get) Token: 0x06000C20 RID: 3104 RVA: 0x00005C28 File Offset: 0x00003E28
	// (set) Token: 0x06000C21 RID: 3105 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000525")]
	public int ItemId
	{
		[Token(Token = "0x6000C20")]
		[Address(RVA = "0x7B4B50", Offset = "0x7B3150", VA = "0x1807B4B50")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000C21")]
		[Address(RVA = "0x7D6DC0", Offset = "0x7D53C0", VA = "0x1807D6DC0")]
		set
		{
		}
	}

	// Token: 0x17000526 RID: 1318
	// (get) Token: 0x06000C22 RID: 3106 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06000C23 RID: 3107 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000526")]
	public BoltEntity Rack
	{
		[Token(Token = "0x6000C22")]
		[Address(RVA = "0x80A6A0", Offset = "0x808CA0", VA = "0x18080A6A0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000C23")]
		[Address(RVA = "0x8588B0", Offset = "0x856EB0", VA = "0x1808588B0")]
		set
		{
		}
	}

	// Token: 0x06000C24 RID: 3108 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C24")]
	[Address(RVA = "0x858AD0", Offset = "0x8570D0", VA = "0x180858AD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06000C25 RID: 3109 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C25")]
	[Address(RVA = "0x858C90", Offset = "0x857290", VA = "0x180858C90")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RackAdd Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06000C26 RID: 3110 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C26")]
	[Address(RVA = "0x858CA0", Offset = "0x8572A0", VA = "0x180858CA0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RackAdd Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06000C27 RID: 3111 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C27")]
	[Address(RVA = "0x858EA0", Offset = "0x8574A0", VA = "0x180858EA0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static RackAdd Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000C28 RID: 3112 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C28")]
	[Address(RVA = "0x858FC0", Offset = "0x8575C0", VA = "0x180858FC0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RackAdd Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06000C29 RID: 3113 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C29")]
	[Address(RVA = "0x858FD0", Offset = "0x8575D0", VA = "0x180858FD0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RackAdd Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000C2A RID: 3114 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C2A")]
	[Address(RVA = "0x858FE0", Offset = "0x8575E0", VA = "0x180858FE0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RackAdd Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06000C2B RID: 3115 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C2B")]
	[Address(RVA = "0x858FF0", Offset = "0x8575F0", VA = "0x180858FF0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RackAdd Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000C2C RID: 3116 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C2C")]
	[Address(RVA = "0x859010", Offset = "0x857610", VA = "0x180859010")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RackAdd Raise()
	{
		return null;
	}

	// Token: 0x06000C2D RID: 3117 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C2D")]
	[Address(RVA = "0x859030", Offset = "0x857630", VA = "0x180859030")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RackAdd Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000C2E RID: 3118 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C2E")]
	[Address(RVA = "0x858C90", Offset = "0x857290", VA = "0x180858C90")]
	public static RackAdd Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06000C2F RID: 3119 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C2F")]
	[Address(RVA = "0x859040", Offset = "0x857640", VA = "0x180859040")]
	public static RackAdd Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06000C30 RID: 3120 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C30")]
	[Address(RVA = "0x859240", Offset = "0x857840", VA = "0x180859240")]
	private static RackAdd Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000C31 RID: 3121 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C31")]
	[Address(RVA = "0x858FC0", Offset = "0x8575C0", VA = "0x180858FC0")]
	public static RackAdd Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06000C32 RID: 3122 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C32")]
	[Address(RVA = "0x858FD0", Offset = "0x8575D0", VA = "0x180858FD0")]
	public static RackAdd Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000C33 RID: 3123 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C33")]
	[Address(RVA = "0x858FE0", Offset = "0x8575E0", VA = "0x180858FE0")]
	public static RackAdd Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06000C34 RID: 3124 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C34")]
	[Address(RVA = "0x858FF0", Offset = "0x8575F0", VA = "0x180858FF0")]
	public static RackAdd Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000C35 RID: 3125 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C35")]
	[Address(RVA = "0x859010", Offset = "0x857610", VA = "0x180859010")]
	public static RackAdd Create()
	{
		return null;
	}

	// Token: 0x06000C36 RID: 3126 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C36")]
	[Address(RVA = "0x859030", Offset = "0x857630", VA = "0x180859030")]
	public static RackAdd Create(ReliabilityModes reliability)
	{
		return null;
	}
}
