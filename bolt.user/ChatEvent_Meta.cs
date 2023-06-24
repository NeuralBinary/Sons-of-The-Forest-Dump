using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020000C7 RID: 199
[Token(Token = "0x20000C7")]
internal class ChatEvent_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x0600093C RID: 2364 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600093C")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public ChatEvent_Meta()
	{
	}

	// Token: 0x170004AF RID: 1199
	// (get) Token: 0x0600093D RID: 2365 RVA: 0x000054A8 File Offset: 0x000036A8
	[Token(Token = "0x170004AF")]
	private TypeId TypeId
	{
		[Token(Token = "0x600093D")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170004B0 RID: 1200
	// (get) Token: 0x0600093E RID: 2366 RVA: 0x000054C0 File Offset: 0x000036C0
	[Token(Token = "0x170004B0")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x600093E")]
		[Address(RVA = "0x840690", Offset = "0x83EC90", VA = "0x180840690", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170004B1 RID: 1201
	// (get) Token: 0x0600093F RID: 2367 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170004B1")]
	private Type TypeObject
	{
		[Token(Token = "0x600093F")]
		[Address(RVA = "0x8406B0", Offset = "0x83ECB0", VA = "0x1808406B0", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000940 RID: 2368 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000940")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06000941 RID: 2369 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000941")]
	[Address(RVA = "0x840750", Offset = "0x83ED50", VA = "0x180840750", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06000942 RID: 2370 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000942")]
	[Address(RVA = "0x840A50", Offset = "0x83F050", VA = "0x180840A50", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06000943 RID: 2371 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000943")]
	[Address(RVA = "0x840AE0", Offset = "0x83F0E0", VA = "0x180840AE0", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x04000265 RID: 613
	[Token(Token = "0x4000265")]
	[FieldOffset(Offset = "0x0")]
	internal static ChatEvent_Meta Instance;
}
