using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000274 RID: 628
[Token(Token = "0x2000274")]
internal class FreeFormStructureCreationValidated_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001CEA RID: 7402 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CEA")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public FreeFormStructureCreationValidated_Meta()
	{
	}

	// Token: 0x170007F2 RID: 2034
	// (get) Token: 0x06001CEB RID: 7403 RVA: 0x000088E0 File Offset: 0x00006AE0
	[Token(Token = "0x170007F2")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001CEB")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170007F3 RID: 2035
	// (get) Token: 0x06001CEC RID: 7404 RVA: 0x000088F8 File Offset: 0x00006AF8
	[Token(Token = "0x170007F3")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001CEC")]
		[Address(RVA = "0x7EBBF0", Offset = "0x7EA1F0", VA = "0x1807EBBF0", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170007F4 RID: 2036
	// (get) Token: 0x06001CED RID: 7405 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170007F4")]
	private Type TypeObject
	{
		[Token(Token = "0x6001CED")]
		[Address(RVA = "0x7EBC10", Offset = "0x7EA210", VA = "0x1807EBC10", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001CEE RID: 7406 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CEE")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001CEF RID: 7407 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CEF")]
	[Address(RVA = "0x7EBCB0", Offset = "0x7EA2B0", VA = "0x1807EBCB0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001CF0 RID: 7408 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001CF0")]
	[Address(RVA = "0x7EC0F0", Offset = "0x7EA6F0", VA = "0x1807EC0F0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001CF1 RID: 7409 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CF1")]
	[Address(RVA = "0x7EC180", Offset = "0x7EA780", VA = "0x1807EC180", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002F4 RID: 756
	[Token(Token = "0x40002F4")]
	[FieldOffset(Offset = "0x0")]
	internal static FreeFormStructureCreationValidated_Meta Instance;
}
