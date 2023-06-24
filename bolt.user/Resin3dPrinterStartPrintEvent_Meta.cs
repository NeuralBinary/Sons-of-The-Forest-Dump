using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000265 RID: 613
[Token(Token = "0x2000265")]
internal class Resin3dPrinterStartPrintEvent_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001C42 RID: 7234 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C42")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public Resin3dPrinterStartPrintEvent_Meta()
	{
	}

	// Token: 0x170007D8 RID: 2008
	// (get) Token: 0x06001C43 RID: 7235 RVA: 0x00008748 File Offset: 0x00006948
	[Token(Token = "0x170007D8")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001C43")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170007D9 RID: 2009
	// (get) Token: 0x06001C44 RID: 7236 RVA: 0x00008760 File Offset: 0x00006960
	[Token(Token = "0x170007D9")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001C44")]
		[Address(RVA = "0x7E6B90", Offset = "0x7E5190", VA = "0x1807E6B90", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170007DA RID: 2010
	// (get) Token: 0x06001C45 RID: 7237 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170007DA")]
	private Type TypeObject
	{
		[Token(Token = "0x6001C45")]
		[Address(RVA = "0x7E6BB0", Offset = "0x7E51B0", VA = "0x1807E6BB0", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001C46 RID: 7238 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C46")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001C47 RID: 7239 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C47")]
	[Address(RVA = "0x7E6C50", Offset = "0x7E5250", VA = "0x1807E6C50", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001C48 RID: 7240 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C48")]
	[Address(RVA = "0x7E6E40", Offset = "0x7E5440", VA = "0x1807E6E40", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001C49 RID: 7241 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C49")]
	[Address(RVA = "0x7E6ED0", Offset = "0x7E54D0", VA = "0x1807E6ED0", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002EF RID: 751
	[Token(Token = "0x40002EF")]
	[FieldOffset(Offset = "0x0")]
	internal static Resin3dPrinterStartPrintEvent_Meta Instance;
}
