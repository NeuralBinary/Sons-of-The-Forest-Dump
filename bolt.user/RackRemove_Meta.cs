using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200010C RID: 268
[Token(Token = "0x200010C")]
internal class RackRemove_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06000C5A RID: 3162 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C5A")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public RackRemove_Meta()
	{
	}

	// Token: 0x1700052C RID: 1324
	// (get) Token: 0x06000C5B RID: 3163 RVA: 0x00005C88 File Offset: 0x00003E88
	[Token(Token = "0x1700052C")]
	private TypeId TypeId
	{
		[Token(Token = "0x6000C5B")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x1700052D RID: 1325
	// (get) Token: 0x06000C5C RID: 3164 RVA: 0x00005CA0 File Offset: 0x00003EA0
	[Token(Token = "0x1700052D")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6000C5C")]
		[Address(RVA = "0x85A6A0", Offset = "0x858CA0", VA = "0x18085A6A0", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x1700052E RID: 1326
	// (get) Token: 0x06000C5D RID: 3165 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700052E")]
	private Type TypeObject
	{
		[Token(Token = "0x6000C5D")]
		[Address(RVA = "0x85A6C0", Offset = "0x858CC0", VA = "0x18085A6C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000C5E RID: 3166 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C5E")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06000C5F RID: 3167 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C5F")]
	[Address(RVA = "0x85A760", Offset = "0x858D60", VA = "0x18085A760", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06000C60 RID: 3168 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C60")]
	[Address(RVA = "0x85AA70", Offset = "0x859070", VA = "0x18085AA70", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06000C61 RID: 3169 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C61")]
	[Address(RVA = "0x85AB00", Offset = "0x859100", VA = "0x18085AB00", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x0400027C RID: 636
	[Token(Token = "0x400027C")]
	[FieldOffset(Offset = "0x0")]
	internal static RackRemove_Meta Instance;
}
