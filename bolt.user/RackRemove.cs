using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200010B RID: 267
[Token(Token = "0x200010B")]
public class RackRemove : Event
{
	// Token: 0x06000C41 RID: 3137 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C41")]
	[Address(RVA = "0x859B10", Offset = "0x858110", VA = "0x180859B10")]
	public RackRemove()
	{
	}

	// Token: 0x1700052A RID: 1322
	// (get) Token: 0x06000C42 RID: 3138 RVA: 0x00005C70 File Offset: 0x00003E70
	// (set) Token: 0x06000C43 RID: 3139 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700052A")]
	public int Slot
	{
		[Token(Token = "0x6000C42")]
		[Address(RVA = "0x7B5360", Offset = "0x7B3960", VA = "0x1807B5360")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000C43")]
		[Address(RVA = "0x7EB470", Offset = "0x7E9A70", VA = "0x1807EB470")]
		set
		{
		}
	}

	// Token: 0x1700052B RID: 1323
	// (get) Token: 0x06000C44 RID: 3140 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06000C45 RID: 3141 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700052B")]
	public BoltEntity Rack
	{
		[Token(Token = "0x6000C44")]
		[Address(RVA = "0x7DB3B0", Offset = "0x7D99B0", VA = "0x1807DB3B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000C45")]
		[Address(RVA = "0x859B70", Offset = "0x858170", VA = "0x180859B70")]
		set
		{
		}
	}

	// Token: 0x06000C46 RID: 3142 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C46")]
	[Address(RVA = "0x859D80", Offset = "0x858380", VA = "0x180859D80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06000C47 RID: 3143 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C47")]
	[Address(RVA = "0x859EC0", Offset = "0x8584C0", VA = "0x180859EC0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RackRemove Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06000C48 RID: 3144 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C48")]
	[Address(RVA = "0x859ED0", Offset = "0x8584D0", VA = "0x180859ED0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RackRemove Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06000C49 RID: 3145 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C49")]
	[Address(RVA = "0x85A0D0", Offset = "0x8586D0", VA = "0x18085A0D0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static RackRemove Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000C4A RID: 3146 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C4A")]
	[Address(RVA = "0x85A1F0", Offset = "0x8587F0", VA = "0x18085A1F0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RackRemove Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06000C4B RID: 3147 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C4B")]
	[Address(RVA = "0x85A200", Offset = "0x858800", VA = "0x18085A200")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RackRemove Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000C4C RID: 3148 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C4C")]
	[Address(RVA = "0x85A210", Offset = "0x858810", VA = "0x18085A210")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RackRemove Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06000C4D RID: 3149 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C4D")]
	[Address(RVA = "0x85A220", Offset = "0x858820", VA = "0x18085A220")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RackRemove Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000C4E RID: 3150 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C4E")]
	[Address(RVA = "0x85A240", Offset = "0x858840", VA = "0x18085A240")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RackRemove Raise()
	{
		return null;
	}

	// Token: 0x06000C4F RID: 3151 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C4F")]
	[Address(RVA = "0x85A260", Offset = "0x858860", VA = "0x18085A260")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RackRemove Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000C50 RID: 3152 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C50")]
	[Address(RVA = "0x859EC0", Offset = "0x8584C0", VA = "0x180859EC0")]
	public static RackRemove Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06000C51 RID: 3153 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C51")]
	[Address(RVA = "0x85A270", Offset = "0x858870", VA = "0x18085A270")]
	public static RackRemove Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06000C52 RID: 3154 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C52")]
	[Address(RVA = "0x85A470", Offset = "0x858A70", VA = "0x18085A470")]
	private static RackRemove Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000C53 RID: 3155 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C53")]
	[Address(RVA = "0x85A1F0", Offset = "0x8587F0", VA = "0x18085A1F0")]
	public static RackRemove Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06000C54 RID: 3156 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C54")]
	[Address(RVA = "0x85A200", Offset = "0x858800", VA = "0x18085A200")]
	public static RackRemove Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000C55 RID: 3157 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C55")]
	[Address(RVA = "0x85A210", Offset = "0x858810", VA = "0x18085A210")]
	public static RackRemove Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06000C56 RID: 3158 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C56")]
	[Address(RVA = "0x85A220", Offset = "0x858820", VA = "0x18085A220")]
	public static RackRemove Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000C57 RID: 3159 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C57")]
	[Address(RVA = "0x85A240", Offset = "0x858840", VA = "0x18085A240")]
	public static RackRemove Create()
	{
		return null;
	}

	// Token: 0x06000C58 RID: 3160 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C58")]
	[Address(RVA = "0x85A260", Offset = "0x858860", VA = "0x18085A260")]
	public static RackRemove Create(ReliabilityModes reliability)
	{
		return null;
	}
}
