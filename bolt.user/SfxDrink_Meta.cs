using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020000F1 RID: 241
[Token(Token = "0x20000F1")]
internal class SfxDrink_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06000B36 RID: 2870 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B36")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public SfxDrink_Meta()
	{
	}

	// Token: 0x17000506 RID: 1286
	// (get) Token: 0x06000B37 RID: 2871 RVA: 0x00005A48 File Offset: 0x00003C48
	[Token(Token = "0x17000506")]
	private TypeId TypeId
	{
		[Token(Token = "0x6000B37")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000507 RID: 1287
	// (get) Token: 0x06000B38 RID: 2872 RVA: 0x00005A60 File Offset: 0x00003C60
	[Token(Token = "0x17000507")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6000B38")]
		[Address(RVA = "0x852370", Offset = "0x850970", VA = "0x180852370", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000508 RID: 1288
	// (get) Token: 0x06000B39 RID: 2873 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000508")]
	private Type TypeObject
	{
		[Token(Token = "0x6000B39")]
		[Address(RVA = "0x852390", Offset = "0x850990", VA = "0x180852390", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000B3A RID: 2874 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B3A")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06000B3B RID: 2875 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B3B")]
	[Address(RVA = "0x852430", Offset = "0x850A30", VA = "0x180852430", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06000B3C RID: 2876 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000B3C")]
	[Address(RVA = "0x8524E0", Offset = "0x850AE0", VA = "0x1808524E0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06000B3D RID: 2877 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B3D")]
	[Address(RVA = "0x852570", Offset = "0x850B70", VA = "0x180852570", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x04000273 RID: 627
	[Token(Token = "0x4000273")]
	[FieldOffset(Offset = "0x0")]
	internal static SfxDrink_Meta Instance;
}
