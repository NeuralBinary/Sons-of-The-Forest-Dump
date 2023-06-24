using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000271 RID: 625
[Token(Token = "0x2000271")]
internal class Resin3dPrinterRefillEvent_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001CCA RID: 7370 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CCA")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public Resin3dPrinterRefillEvent_Meta()
	{
	}

	// Token: 0x170007EC RID: 2028
	// (get) Token: 0x06001CCB RID: 7371 RVA: 0x00008868 File Offset: 0x00006A68
	[Token(Token = "0x170007EC")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001CCB")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170007ED RID: 2029
	// (get) Token: 0x06001CCC RID: 7372 RVA: 0x00008880 File Offset: 0x00006A80
	[Token(Token = "0x170007ED")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001CCC")]
		[Address(RVA = "0x7EAEA0", Offset = "0x7E94A0", VA = "0x1807EAEA0", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170007EE RID: 2030
	// (get) Token: 0x06001CCD RID: 7373 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170007EE")]
	private Type TypeObject
	{
		[Token(Token = "0x6001CCD")]
		[Address(RVA = "0x7EAEC0", Offset = "0x7E94C0", VA = "0x1807EAEC0", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001CCE RID: 7374 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CCE")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001CCF RID: 7375 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CCF")]
	[Address(RVA = "0x7EAF60", Offset = "0x7E9560", VA = "0x1807EAF60", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001CD0 RID: 7376 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001CD0")]
	[Address(RVA = "0x7EB260", Offset = "0x7E9860", VA = "0x1807EB260", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001CD1 RID: 7377 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CD1")]
	[Address(RVA = "0x7EB2F0", Offset = "0x7E98F0", VA = "0x1807EB2F0", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002F3 RID: 755
	[Token(Token = "0x40002F3")]
	[FieldOffset(Offset = "0x0")]
	internal static Resin3dPrinterRefillEvent_Meta Instance;
}
