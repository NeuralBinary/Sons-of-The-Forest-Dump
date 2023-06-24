using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000268 RID: 616
[Token(Token = "0x2000268")]
internal class Resin3dPrinterSetRecipeIdEvent_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001C64 RID: 7268 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C64")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public Resin3dPrinterSetRecipeIdEvent_Meta()
	{
	}

	// Token: 0x170007DD RID: 2013
	// (get) Token: 0x06001C65 RID: 7269 RVA: 0x00008790 File Offset: 0x00006990
	[Token(Token = "0x170007DD")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001C65")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170007DE RID: 2014
	// (get) Token: 0x06001C66 RID: 7270 RVA: 0x000087A8 File Offset: 0x000069A8
	[Token(Token = "0x170007DE")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001C66")]
		[Address(RVA = "0x7E7B00", Offset = "0x7E6100", VA = "0x1807E7B00", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170007DF RID: 2015
	// (get) Token: 0x06001C67 RID: 7271 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170007DF")]
	private Type TypeObject
	{
		[Token(Token = "0x6001C67")]
		[Address(RVA = "0x7E7B20", Offset = "0x7E6120", VA = "0x1807E7B20", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001C68 RID: 7272 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C68")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001C69 RID: 7273 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C69")]
	[Address(RVA = "0x7E7BC0", Offset = "0x7E61C0", VA = "0x1807E7BC0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001C6A RID: 7274 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C6A")]
	[Address(RVA = "0x7E7EC0", Offset = "0x7E64C0", VA = "0x1807E7EC0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001C6B RID: 7275 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C6B")]
	[Address(RVA = "0x7E7F50", Offset = "0x7E6550", VA = "0x1807E7F50", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002F0 RID: 752
	[Token(Token = "0x40002F0")]
	[FieldOffset(Offset = "0x0")]
	internal static Resin3dPrinterSetRecipeIdEvent_Meta Instance;
}
