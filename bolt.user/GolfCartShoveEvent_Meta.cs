using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020002AA RID: 682
[Token(Token = "0x20002AA")]
internal class GolfCartShoveEvent_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001F2C RID: 7980 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F2C")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public GolfCartShoveEvent_Meta()
	{
	}

	// Token: 0x17000850 RID: 2128
	// (get) Token: 0x06001F2D RID: 7981 RVA: 0x00008EE0 File Offset: 0x000070E0
	[Token(Token = "0x17000850")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001F2D")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000851 RID: 2129
	// (get) Token: 0x06001F2E RID: 7982 RVA: 0x00008EF8 File Offset: 0x000070F8
	[Token(Token = "0x17000851")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001F2E")]
		[Address(RVA = "0x7FD6B0", Offset = "0x7FBCB0", VA = "0x1807FD6B0", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000852 RID: 2130
	// (get) Token: 0x06001F2F RID: 7983 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000852")]
	private Type TypeObject
	{
		[Token(Token = "0x6001F2F")]
		[Address(RVA = "0x7FD6D0", Offset = "0x7FBCD0", VA = "0x1807FD6D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001F30 RID: 7984 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F30")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001F31 RID: 7985 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F31")]
	[Address(RVA = "0x7FD770", Offset = "0x7FBD70", VA = "0x1807FD770", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001F32 RID: 7986 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001F32")]
	[Address(RVA = "0x7FDA10", Offset = "0x7FC010", VA = "0x1807FDA10", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001F33 RID: 7987 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F33")]
	[Address(RVA = "0x7FDAA0", Offset = "0x7FC0A0", VA = "0x1807FDAA0", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x04000306 RID: 774
	[Token(Token = "0x4000306")]
	[FieldOffset(Offset = "0x0")]
	internal static GolfCartShoveEvent_Meta Instance;
}
