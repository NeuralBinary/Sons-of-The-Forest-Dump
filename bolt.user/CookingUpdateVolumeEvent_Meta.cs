using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020002A4 RID: 676
[Token(Token = "0x20002A4")]
internal class CookingUpdateVolumeEvent_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001EF6 RID: 7926 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001EF6")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public CookingUpdateVolumeEvent_Meta()
	{
	}

	// Token: 0x17000846 RID: 2118
	// (get) Token: 0x06001EF7 RID: 7927 RVA: 0x00008E20 File Offset: 0x00007020
	[Token(Token = "0x17000846")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001EF7")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000847 RID: 2119
	// (get) Token: 0x06001EF8 RID: 7928 RVA: 0x00008E38 File Offset: 0x00007038
	[Token(Token = "0x17000847")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001EF8")]
		[Address(RVA = "0x7FB760", Offset = "0x7F9D60", VA = "0x1807FB760", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000848 RID: 2120
	// (get) Token: 0x06001EF9 RID: 7929 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000848")]
	private Type TypeObject
	{
		[Token(Token = "0x6001EF9")]
		[Address(RVA = "0x7FB780", Offset = "0x7F9D80", VA = "0x1807FB780", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001EFA RID: 7930 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001EFA")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001EFB RID: 7931 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001EFB")]
	[Address(RVA = "0x7FB820", Offset = "0x7F9E20", VA = "0x1807FB820", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001EFC RID: 7932 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001EFC")]
	[Address(RVA = "0x7FBB50", Offset = "0x7FA150", VA = "0x1807FBB50", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001EFD RID: 7933 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001EFD")]
	[Address(RVA = "0x7FBBE0", Offset = "0x7FA1E0", VA = "0x1807FBBE0", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x04000304 RID: 772
	[Token(Token = "0x4000304")]
	[FieldOffset(Offset = "0x0")]
	internal static CookingUpdateVolumeEvent_Meta Instance;
}
