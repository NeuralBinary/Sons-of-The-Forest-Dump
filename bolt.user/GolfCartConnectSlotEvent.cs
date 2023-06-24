using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020002AC RID: 684
[Token(Token = "0x20002AC")]
public class GolfCartConnectSlotEvent : Event
{
	// Token: 0x06001F35 RID: 7989 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F35")]
	[Address(RVA = "0x7FDBC0", Offset = "0x7FC1C0", VA = "0x1807FDBC0")]
	public GolfCartConnectSlotEvent()
	{
	}

	// Token: 0x17000853 RID: 2131
	// (get) Token: 0x06001F36 RID: 7990 RVA: 0x00008F10 File Offset: 0x00007110
	// (set) Token: 0x06001F37 RID: 7991 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000853")]
	public int SlotIndex
	{
		[Token(Token = "0x6001F36")]
		[Address(RVA = "0x7B5360", Offset = "0x7B3960", VA = "0x1807B5360")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001F37")]
		[Address(RVA = "0x7FDC20", Offset = "0x7FC220", VA = "0x1807FDC20")]
		set
		{
		}
	}

	// Token: 0x17000854 RID: 2132
	// (get) Token: 0x06001F38 RID: 7992 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001F39 RID: 7993 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000854")]
	public BoltEntity OccupiedEntity
	{
		[Token(Token = "0x6001F38")]
		[Address(RVA = "0x7DB3B0", Offset = "0x7D99B0", VA = "0x1807DB3B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001F39")]
		[Address(RVA = "0x7FDCC0", Offset = "0x7FC2C0", VA = "0x1807FDCC0")]
		set
		{
		}
	}

	// Token: 0x17000855 RID: 2133
	// (get) Token: 0x06001F3A RID: 7994 RVA: 0x00008F28 File Offset: 0x00007128
	// (set) Token: 0x06001F3B RID: 7995 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000855")]
	public bool Disconnect
	{
		[Token(Token = "0x6001F3A")]
		[Address(RVA = "0x7B8B00", Offset = "0x7B7100", VA = "0x1807B8B00")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001F3B")]
		[Address(RVA = "0x7DD620", Offset = "0x7DBC20", VA = "0x1807DD620")]
		set
		{
		}
	}

	// Token: 0x06001F3C RID: 7996 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001F3C")]
	[Address(RVA = "0x7FDED0", Offset = "0x7FC4D0", VA = "0x1807FDED0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06001F3D RID: 7997 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001F3D")]
	[Address(RVA = "0x7FE010", Offset = "0x7FC610", VA = "0x1807FE010")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static GolfCartConnectSlotEvent Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001F3E RID: 7998 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001F3E")]
	[Address(RVA = "0x7FE020", Offset = "0x7FC620", VA = "0x1807FE020")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static GolfCartConnectSlotEvent Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001F3F RID: 7999 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001F3F")]
	[Address(RVA = "0x7FE010", Offset = "0x7FC610", VA = "0x1807FE010")]
	public static GolfCartConnectSlotEvent Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001F40 RID: 8000 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001F40")]
	[Address(RVA = "0x7FE220", Offset = "0x7FC820", VA = "0x1807FE220")]
	public static GolfCartConnectSlotEvent Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}
}
