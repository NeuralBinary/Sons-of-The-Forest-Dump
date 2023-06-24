using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020002B2 RID: 690
[Token(Token = "0x20002B2")]
public class ItemStorageIsBusy : Event
{
	// Token: 0x06001F65 RID: 8037 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F65")]
	[Address(RVA = "0x7FF440", Offset = "0x7FDA40", VA = "0x1807FF440")]
	public ItemStorageIsBusy()
	{
	}

	// Token: 0x1700085C RID: 2140
	// (get) Token: 0x06001F66 RID: 8038 RVA: 0x00008FA0 File Offset: 0x000071A0
	// (set) Token: 0x06001F67 RID: 8039 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700085C")]
	public bool IsBusy
	{
		[Token(Token = "0x6001F66")]
		[Address(RVA = "0x7B4A10", Offset = "0x7B3010", VA = "0x1807B4A10")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001F67")]
		[Address(RVA = "0x7DB320", Offset = "0x7D9920", VA = "0x1807DB320")]
		set
		{
		}
	}

	// Token: 0x1700085D RID: 2141
	// (get) Token: 0x06001F68 RID: 8040 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001F69 RID: 8041 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700085D")]
	public BoltEntity Target
	{
		[Token(Token = "0x6001F68")]
		[Address(RVA = "0x7DB3B0", Offset = "0x7D99B0", VA = "0x1807DB3B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001F69")]
		[Address(RVA = "0x7FF4A0", Offset = "0x7FDAA0", VA = "0x1807FF4A0")]
		set
		{
		}
	}

	// Token: 0x06001F6A RID: 8042 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001F6A")]
	[Address(RVA = "0x7FF6B0", Offset = "0x7FDCB0", VA = "0x1807FF6B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06001F6B RID: 8043 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001F6B")]
	[Address(RVA = "0x7FF770", Offset = "0x7FDD70", VA = "0x1807FF770")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ItemStorageIsBusy Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001F6C RID: 8044 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001F6C")]
	[Address(RVA = "0x7FF780", Offset = "0x7FDD80", VA = "0x1807FF780")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ItemStorageIsBusy Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001F6D RID: 8045 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001F6D")]
	[Address(RVA = "0x7FF980", Offset = "0x7FDF80", VA = "0x1807FF980")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static ItemStorageIsBusy Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001F6E RID: 8046 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001F6E")]
	[Address(RVA = "0x7FFAA0", Offset = "0x7FE0A0", VA = "0x1807FFAA0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ItemStorageIsBusy Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001F6F RID: 8047 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001F6F")]
	[Address(RVA = "0x7FFAB0", Offset = "0x7FE0B0", VA = "0x1807FFAB0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ItemStorageIsBusy Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001F70 RID: 8048 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001F70")]
	[Address(RVA = "0x7FFAC0", Offset = "0x7FE0C0", VA = "0x1807FFAC0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ItemStorageIsBusy Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001F71 RID: 8049 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001F71")]
	[Address(RVA = "0x7FFAD0", Offset = "0x7FE0D0", VA = "0x1807FFAD0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ItemStorageIsBusy Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001F72 RID: 8050 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001F72")]
	[Address(RVA = "0x7FFAF0", Offset = "0x7FE0F0", VA = "0x1807FFAF0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ItemStorageIsBusy Raise()
	{
		return null;
	}

	// Token: 0x06001F73 RID: 8051 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001F73")]
	[Address(RVA = "0x7FFB10", Offset = "0x7FE110", VA = "0x1807FFB10")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ItemStorageIsBusy Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001F74 RID: 8052 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001F74")]
	[Address(RVA = "0x7FF770", Offset = "0x7FDD70", VA = "0x1807FF770")]
	public static ItemStorageIsBusy Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001F75 RID: 8053 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001F75")]
	[Address(RVA = "0x7FFB20", Offset = "0x7FE120", VA = "0x1807FFB20")]
	public static ItemStorageIsBusy Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001F76 RID: 8054 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001F76")]
	[Address(RVA = "0x7FFD20", Offset = "0x7FE320", VA = "0x1807FFD20")]
	private static ItemStorageIsBusy Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001F77 RID: 8055 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001F77")]
	[Address(RVA = "0x7FFAA0", Offset = "0x7FE0A0", VA = "0x1807FFAA0")]
	public static ItemStorageIsBusy Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001F78 RID: 8056 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001F78")]
	[Address(RVA = "0x7FFAB0", Offset = "0x7FE0B0", VA = "0x1807FFAB0")]
	public static ItemStorageIsBusy Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001F79 RID: 8057 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001F79")]
	[Address(RVA = "0x7FFAC0", Offset = "0x7FE0C0", VA = "0x1807FFAC0")]
	public static ItemStorageIsBusy Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001F7A RID: 8058 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001F7A")]
	[Address(RVA = "0x7FFAD0", Offset = "0x7FE0D0", VA = "0x1807FFAD0")]
	public static ItemStorageIsBusy Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001F7B RID: 8059 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001F7B")]
	[Address(RVA = "0x7FFAF0", Offset = "0x7FE0F0", VA = "0x1807FFAF0")]
	public static ItemStorageIsBusy Create()
	{
		return null;
	}

	// Token: 0x06001F7C RID: 8060 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001F7C")]
	[Address(RVA = "0x7FFB10", Offset = "0x7FE110", VA = "0x1807FFB10")]
	public static ItemStorageIsBusy Create(ReliabilityModes reliability)
	{
		return null;
	}
}
