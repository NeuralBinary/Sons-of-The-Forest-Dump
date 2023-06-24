using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200026E RID: 622
[Token(Token = "0x200026E")]
internal class Resin3dPrinterItemRemovedEvent_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001CA8 RID: 7336 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CA8")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public Resin3dPrinterItemRemovedEvent_Meta()
	{
	}

	// Token: 0x170007E7 RID: 2023
	// (get) Token: 0x06001CA9 RID: 7337 RVA: 0x00008820 File Offset: 0x00006A20
	[Token(Token = "0x170007E7")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001CA9")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170007E8 RID: 2024
	// (get) Token: 0x06001CAA RID: 7338 RVA: 0x00008838 File Offset: 0x00006A38
	[Token(Token = "0x170007E8")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001CAA")]
		[Address(RVA = "0x7E9D40", Offset = "0x7E8340", VA = "0x1807E9D40", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170007E9 RID: 2025
	// (get) Token: 0x06001CAB RID: 7339 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170007E9")]
	private Type TypeObject
	{
		[Token(Token = "0x6001CAB")]
		[Address(RVA = "0x7E9D60", Offset = "0x7E8360", VA = "0x1807E9D60", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001CAC RID: 7340 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CAC")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001CAD RID: 7341 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CAD")]
	[Address(RVA = "0x7E9E00", Offset = "0x7E8400", VA = "0x1807E9E00", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001CAE RID: 7342 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001CAE")]
	[Address(RVA = "0x7EA100", Offset = "0x7E8700", VA = "0x1807EA100", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001CAF RID: 7343 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CAF")]
	[Address(RVA = "0x7EA190", Offset = "0x7E8790", VA = "0x1807EA190", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002F2 RID: 754
	[Token(Token = "0x40002F2")]
	[FieldOffset(Offset = "0x0")]
	internal static Resin3dPrinterItemRemovedEvent_Meta Instance;
}
