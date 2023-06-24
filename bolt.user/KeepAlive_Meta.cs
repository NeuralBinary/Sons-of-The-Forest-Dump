using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000139 RID: 313
[Token(Token = "0x2000139")]
internal class KeepAlive_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06000E72 RID: 3698 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E72")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public KeepAlive_Meta()
	{
	}

	// Token: 0x17000584 RID: 1412
	// (get) Token: 0x06000E73 RID: 3699 RVA: 0x00006180 File Offset: 0x00004380
	[Token(Token = "0x17000584")]
	private TypeId TypeId
	{
		[Token(Token = "0x6000E73")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000585 RID: 1413
	// (get) Token: 0x06000E74 RID: 3700 RVA: 0x00006198 File Offset: 0x00004398
	[Token(Token = "0x17000585")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6000E74")]
		[Address(RVA = "0x86D230", Offset = "0x86B830", VA = "0x18086D230", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000586 RID: 1414
	// (get) Token: 0x06000E75 RID: 3701 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000586")]
	private Type TypeObject
	{
		[Token(Token = "0x6000E75")]
		[Address(RVA = "0x86D250", Offset = "0x86B850", VA = "0x18086D250", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000E76 RID: 3702 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E76")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06000E77 RID: 3703 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E77")]
	[Address(RVA = "0x86D2F0", Offset = "0x86B8F0", VA = "0x18086D2F0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06000E78 RID: 3704 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E78")]
	[Address(RVA = "0x86D3A0", Offset = "0x86B9A0", VA = "0x18086D3A0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06000E79 RID: 3705 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E79")]
	[Address(RVA = "0x86D430", Offset = "0x86BA30", VA = "0x18086D430", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x0400028B RID: 651
	[Token(Token = "0x400028B")]
	[FieldOffset(Offset = "0x0")]
	internal static KeepAlive_Meta Instance;
}
