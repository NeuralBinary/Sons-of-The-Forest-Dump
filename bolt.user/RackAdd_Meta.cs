using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000109 RID: 265
[Token(Token = "0x2000109")]
internal class RackAdd_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06000C38 RID: 3128 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C38")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public RackAdd_Meta()
	{
	}

	// Token: 0x17000527 RID: 1319
	// (get) Token: 0x06000C39 RID: 3129 RVA: 0x00005C40 File Offset: 0x00003E40
	[Token(Token = "0x17000527")]
	private TypeId TypeId
	{
		[Token(Token = "0x6000C39")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000528 RID: 1320
	// (get) Token: 0x06000C3A RID: 3130 RVA: 0x00005C58 File Offset: 0x00003E58
	[Token(Token = "0x17000528")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6000C3A")]
		[Address(RVA = "0x859470", Offset = "0x857A70", VA = "0x180859470", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000529 RID: 1321
	// (get) Token: 0x06000C3B RID: 3131 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000529")]
	private Type TypeObject
	{
		[Token(Token = "0x6000C3B")]
		[Address(RVA = "0x859490", Offset = "0x857A90", VA = "0x180859490", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000C3C RID: 3132 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C3C")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06000C3D RID: 3133 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C3D")]
	[Address(RVA = "0x859530", Offset = "0x857B30", VA = "0x180859530", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06000C3E RID: 3134 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C3E")]
	[Address(RVA = "0x859960", Offset = "0x857F60", VA = "0x180859960", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06000C3F RID: 3135 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C3F")]
	[Address(RVA = "0x8599F0", Offset = "0x857FF0", VA = "0x1808599F0", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x0400027B RID: 635
	[Token(Token = "0x400027B")]
	[FieldOffset(Offset = "0x0")]
	internal static RackAdd_Meta Instance;
}
