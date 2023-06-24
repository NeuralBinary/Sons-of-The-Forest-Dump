using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020001A8 RID: 424
[Token(Token = "0x20001A8")]
internal class SetMasterClient_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x0600136A RID: 4970 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600136A")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public SetMasterClient_Meta()
	{
	}

	// Token: 0x17000646 RID: 1606
	// (get) Token: 0x0600136B RID: 4971 RVA: 0x00006CA8 File Offset: 0x00004EA8
	[Token(Token = "0x17000646")]
	private TypeId TypeId
	{
		[Token(Token = "0x600136B")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000647 RID: 1607
	// (get) Token: 0x0600136C RID: 4972 RVA: 0x00006CC0 File Offset: 0x00004EC0
	[Token(Token = "0x17000647")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x600136C")]
		[Address(RVA = "0x895CA0", Offset = "0x8942A0", VA = "0x180895CA0", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000648 RID: 1608
	// (get) Token: 0x0600136D RID: 4973 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000648")]
	private Type TypeObject
	{
		[Token(Token = "0x600136D")]
		[Address(RVA = "0x895CC0", Offset = "0x8942C0", VA = "0x180895CC0", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600136E RID: 4974 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600136E")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x0600136F RID: 4975 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600136F")]
	[Address(RVA = "0x895D60", Offset = "0x894360", VA = "0x180895D60", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001370 RID: 4976 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001370")]
	[Address(RVA = "0x895F50", Offset = "0x894550", VA = "0x180895F50", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001371 RID: 4977 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001371")]
	[Address(RVA = "0x895FE0", Offset = "0x8945E0", VA = "0x180895FE0", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002B0 RID: 688
	[Token(Token = "0x40002B0")]
	[FieldOffset(Offset = "0x0")]
	internal static SetMasterClient_Meta Instance;
}
