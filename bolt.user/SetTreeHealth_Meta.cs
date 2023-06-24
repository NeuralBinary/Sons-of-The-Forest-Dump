using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020000B8 RID: 184
[Token(Token = "0x20000B8")]
internal class SetTreeHealth_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06000872 RID: 2162 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000872")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public SetTreeHealth_Meta()
	{
	}

	// Token: 0x17000486 RID: 1158
	// (get) Token: 0x06000873 RID: 2163 RVA: 0x000051D8 File Offset: 0x000033D8
	[Token(Token = "0x17000486")]
	private TypeId TypeId
	{
		[Token(Token = "0x6000873")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000487 RID: 1159
	// (get) Token: 0x06000874 RID: 2164 RVA: 0x000051F0 File Offset: 0x000033F0
	[Token(Token = "0x17000487")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6000874")]
		[Address(RVA = "0x838340", Offset = "0x836940", VA = "0x180838340", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000488 RID: 1160
	// (get) Token: 0x06000875 RID: 2165 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000488")]
	private Type TypeObject
	{
		[Token(Token = "0x6000875")]
		[Address(RVA = "0x838360", Offset = "0x836960", VA = "0x180838360", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000876 RID: 2166 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000876")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06000877 RID: 2167 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000877")]
	[Address(RVA = "0x838400", Offset = "0x836A00", VA = "0x180838400", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06000878 RID: 2168 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000878")]
	[Address(RVA = "0x838710", Offset = "0x836D10", VA = "0x180838710", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06000879 RID: 2169 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000879")]
	[Address(RVA = "0x8387A0", Offset = "0x836DA0", VA = "0x1808387A0", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x04000260 RID: 608
	[Token(Token = "0x4000260")]
	[FieldOffset(Offset = "0x0")]
	internal static SetTreeHealth_Meta Instance;
}
