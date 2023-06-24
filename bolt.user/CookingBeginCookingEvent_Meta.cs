using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200029E RID: 670
[Token(Token = "0x200029E")]
internal class CookingBeginCookingEvent_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001EB4 RID: 7860 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001EB4")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public CookingBeginCookingEvent_Meta()
	{
	}

	// Token: 0x1700083D RID: 2109
	// (get) Token: 0x06001EB5 RID: 7861 RVA: 0x00008DA8 File Offset: 0x00006FA8
	[Token(Token = "0x1700083D")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001EB5")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x1700083E RID: 2110
	// (get) Token: 0x06001EB6 RID: 7862 RVA: 0x00008DC0 File Offset: 0x00006FC0
	[Token(Token = "0x1700083E")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001EB6")]
		[Address(RVA = "0x7F9700", Offset = "0x7F7D00", VA = "0x1807F9700", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x1700083F RID: 2111
	// (get) Token: 0x06001EB7 RID: 7863 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700083F")]
	private Type TypeObject
	{
		[Token(Token = "0x6001EB7")]
		[Address(RVA = "0x7F9720", Offset = "0x7F7D20", VA = "0x1807F9720", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001EB8 RID: 7864 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001EB8")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001EB9 RID: 7865 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001EB9")]
	[Address(RVA = "0x7F97C0", Offset = "0x7F7DC0", VA = "0x1807F97C0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001EBA RID: 7866 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001EBA")]
	[Address(RVA = "0x7F9AD0", Offset = "0x7F80D0", VA = "0x1807F9AD0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001EBB RID: 7867 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001EBB")]
	[Address(RVA = "0x7F9B60", Offset = "0x7F8160", VA = "0x1807F9B60", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x04000302 RID: 770
	[Token(Token = "0x4000302")]
	[FieldOffset(Offset = "0x0")]
	internal static CookingBeginCookingEvent_Meta Instance;
}
