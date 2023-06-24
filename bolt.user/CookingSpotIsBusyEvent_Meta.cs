using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200029B RID: 667
[Token(Token = "0x200029B")]
internal class CookingSpotIsBusyEvent_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001E92 RID: 7826 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E92")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public CookingSpotIsBusyEvent_Meta()
	{
	}

	// Token: 0x17000838 RID: 2104
	// (get) Token: 0x06001E93 RID: 7827 RVA: 0x00008D60 File Offset: 0x00006F60
	[Token(Token = "0x17000838")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001E93")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000839 RID: 2105
	// (get) Token: 0x06001E94 RID: 7828 RVA: 0x00008D78 File Offset: 0x00006F78
	[Token(Token = "0x17000839")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001E94")]
		[Address(RVA = "0x7F8690", Offset = "0x7F6C90", VA = "0x1807F8690", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x1700083A RID: 2106
	// (get) Token: 0x06001E95 RID: 7829 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700083A")]
	private Type TypeObject
	{
		[Token(Token = "0x6001E95")]
		[Address(RVA = "0x7F86B0", Offset = "0x7F6CB0", VA = "0x1807F86B0", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001E96 RID: 7830 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E96")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001E97 RID: 7831 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E97")]
	[Address(RVA = "0x7F8750", Offset = "0x7F6D50", VA = "0x1807F8750", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001E98 RID: 7832 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E98")]
	[Address(RVA = "0x7F8A40", Offset = "0x7F7040", VA = "0x1807F8A40", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001E99 RID: 7833 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E99")]
	[Address(RVA = "0x7F8AD0", Offset = "0x7F70D0", VA = "0x1807F8AD0", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x04000301 RID: 769
	[Token(Token = "0x4000301")]
	[FieldOffset(Offset = "0x0")]
	internal static CookingSpotIsBusyEvent_Meta Instance;
}
