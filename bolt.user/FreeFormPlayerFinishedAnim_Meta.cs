using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200025F RID: 607
[Token(Token = "0x200025F")]
internal class FreeFormPlayerFinishedAnim_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001C02 RID: 7170 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C02")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public FreeFormPlayerFinishedAnim_Meta()
	{
	}

	// Token: 0x170007D0 RID: 2000
	// (get) Token: 0x06001C03 RID: 7171 RVA: 0x000086E8 File Offset: 0x000068E8
	[Token(Token = "0x170007D0")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001C03")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170007D1 RID: 2001
	// (get) Token: 0x06001C04 RID: 7172 RVA: 0x00008700 File Offset: 0x00006900
	[Token(Token = "0x170007D1")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001C04")]
		[Address(RVA = "0x7E4C80", Offset = "0x7E3280", VA = "0x1807E4C80", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170007D2 RID: 2002
	// (get) Token: 0x06001C05 RID: 7173 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170007D2")]
	private Type TypeObject
	{
		[Token(Token = "0x6001C05")]
		[Address(RVA = "0x7E4CA0", Offset = "0x7E32A0", VA = "0x1807E4CA0", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001C06 RID: 7174 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C06")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001C07 RID: 7175 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C07")]
	[Address(RVA = "0x7E4D40", Offset = "0x7E3340", VA = "0x1807E4D40", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001C08 RID: 7176 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C08")]
	[Address(RVA = "0x7E5040", Offset = "0x7E3640", VA = "0x1807E5040", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001C09 RID: 7177 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C09")]
	[Address(RVA = "0x7E50D0", Offset = "0x7E36D0", VA = "0x1807E50D0", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002ED RID: 749
	[Token(Token = "0x40002ED")]
	[FieldOffset(Offset = "0x0")]
	internal static FreeFormPlayerFinishedAnim_Meta Instance;
}
