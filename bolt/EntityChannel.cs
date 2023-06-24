using System;
using System.Collections.Generic;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000032 RID: 50
[Token(Token = "0x2000032")]
internal class EntityChannel : BoltChannel
{
	// Token: 0x060001C1 RID: 449 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001C1")]
	[Address(RVA = "0x795470", Offset = "0x793A70", VA = "0x180795470")]
	public EntityChannel()
	{
	}

	// Token: 0x060001C2 RID: 450 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001C2")]
	[Address(RVA = "0x7958F0", Offset = "0x793EF0", VA = "0x1807958F0")]
	public void ForceSync(Entity en)
	{
	}

	// Token: 0x060001C3 RID: 451 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001C3")]
	[Address(RVA = "0x7959D0", Offset = "0x793FD0", VA = "0x1807959D0")]
	public void ForceSync(Entity en, out EntityProxy proxy)
	{
	}

	// Token: 0x060001C4 RID: 452 RVA: 0x00002850 File Offset: 0x00000A50
	[Token(Token = "0x60001C4")]
	[Address(RVA = "0x795AB0", Offset = "0x7940B0", VA = "0x180795AB0")]
	public bool TryFindProxy(Entity en, out EntityProxy proxy)
	{
		return default(bool);
	}

	// Token: 0x060001C5 RID: 453 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001C5")]
	[Address(RVA = "0x795B40", Offset = "0x794140", VA = "0x180795B40")]
	public void SetIdle(Entity entity, bool idle)
	{
	}

	// Token: 0x060001C6 RID: 454 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001C6")]
	[Address(RVA = "0x795C60", Offset = "0x794260", VA = "0x180795C60")]
	public void SetScope(Entity entity, bool inScope)
	{
	}

	// Token: 0x060001C7 RID: 455 RVA: 0x00002868 File Offset: 0x00000A68
	[Token(Token = "0x60001C7")]
	[Address(RVA = "0x795F20", Offset = "0x794520", VA = "0x180795F20")]
	public bool ExistsOnRemote(Entity entity)
	{
		return default(bool);
	}

	// Token: 0x060001C8 RID: 456 RVA: 0x00002880 File Offset: 0x00000A80
	[Token(Token = "0x60001C8")]
	[Address(RVA = "0x796070", Offset = "0x794670", VA = "0x180796070")]
	public ExistsResult ExistsOnRemote(Entity entity, bool allowMaybe)
	{
		return ExistsResult.No;
	}

	// Token: 0x060001C9 RID: 457 RVA: 0x00002898 File Offset: 0x00000A98
	[Token(Token = "0x60001C9")]
	[Address(RVA = "0x7961E0", Offset = "0x7947E0", VA = "0x1807961E0")]
	public bool MightExistOnRemote(Entity entity)
	{
		return default(bool);
	}

	// Token: 0x060001CA RID: 458 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001CA")]
	[Address(RVA = "0x796290", Offset = "0x794890", VA = "0x180796290")]
	public void DestroyOnRemote(Entity entity)
	{
	}

	// Token: 0x060001CB RID: 459 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001CB")]
	[Address(RVA = "0x796530", Offset = "0x794B30", VA = "0x180796530")]
	public void CreateOnRemote(Entity entity)
	{
	}

	// Token: 0x060001CC RID: 460 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001CC")]
	[Address(RVA = "0x796550", Offset = "0x794B50", VA = "0x180796550")]
	public void CreateOnRemote(Entity entity, out EntityProxy proxy)
	{
	}

	// Token: 0x060001CD RID: 461 RVA: 0x000028B0 File Offset: 0x00000AB0
	[Token(Token = "0x60001CD")]
	[Address(RVA = "0x796780", Offset = "0x794D80", VA = "0x180796780")]
	public float GetPriority(Entity entity)
	{
		return 0f;
	}

	// Token: 0x060001CE RID: 462 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001CE")]
	[Address(RVA = "0x796810", Offset = "0x794E10", VA = "0x180796810", Slot = "4")]
	public override void Pack(Packet packet)
	{
	}

	// Token: 0x060001CF RID: 463 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001CF")]
	[Address(RVA = "0x797360", Offset = "0x795960", VA = "0x180797360", Slot = "5")]
	public override void Read(Packet packet)
	{
	}

	// Token: 0x060001D0 RID: 464 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001D0")]
	[Address(RVA = "0x7973D0", Offset = "0x7959D0", VA = "0x1807973D0", Slot = "6")]
	public override void Lost(Packet packet)
	{
	}

	// Token: 0x060001D1 RID: 465 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001D1")]
	[Address(RVA = "0x797670", Offset = "0x795C70", VA = "0x180797670", Slot = "7")]
	public override void Delivered(Packet packet)
	{
	}

	// Token: 0x060001D2 RID: 466 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001D2")]
	[Address(RVA = "0x797860", Offset = "0x795E60", VA = "0x180797860", Slot = "8")]
	public override void Disconnected()
	{
	}

	// Token: 0x060001D3 RID: 467 RVA: 0x000028C8 File Offset: 0x00000AC8
	[Token(Token = "0x60001D3")]
	[Address(RVA = "0x797A70", Offset = "0x796070", VA = "0x180797A70")]
	public int GetSkippedUpdates(Entity en)
	{
		return 0;
	}

	// Token: 0x060001D4 RID: 468 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001D4")]
	[Address(RVA = "0x797B00", Offset = "0x796100", VA = "0x180797B00")]
	private void ApplyPropertyPriorities(EntityProxyEnvelope env)
	{
	}

	// Token: 0x060001D5 RID: 469 RVA: 0x000028E0 File Offset: 0x00000AE0
	[Token(Token = "0x60001D5")]
	[Address(RVA = "0x797C10", Offset = "0x796210", VA = "0x180797C10")]
	private int PackUpdate(Packet packet, EntityProxy proxy)
	{
		return 0;
	}

	// Token: 0x060001D6 RID: 470 RVA: 0x000028F8 File Offset: 0x00000AF8
	[Token(Token = "0x60001D6")]
	[Address(RVA = "0x7989B0", Offset = "0x796FB0", VA = "0x1807989B0")]
	private bool ReadUpdate(Packet packet)
	{
		return default(bool);
	}

	// Token: 0x060001D7 RID: 471 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001D7")]
	[Address(RVA = "0x799780", Offset = "0x797D80", VA = "0x180799780")]
	private void DestroyOutgoingProxy(EntityProxy proxy)
	{
	}

	// Token: 0x060001D8 RID: 472 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001D8")]
	[Address(RVA = "0x7998E0", Offset = "0x797EE0", VA = "0x1807998E0")]
	private void DestroyIncommingProxy(EntityProxy proxy, IProtocolToken token)
	{
	}

	// Token: 0x04000101 RID: 257
	[Token(Token = "0x4000101")]
	[FieldOffset(Offset = "0x18")]
	internal EntityLookup _outgoingLookup;

	// Token: 0x04000102 RID: 258
	[Token(Token = "0x4000102")]
	[FieldOffset(Offset = "0x20")]
	internal EntityLookup _incommingLookup;

	// Token: 0x04000103 RID: 259
	[Token(Token = "0x4000103")]
	[FieldOffset(Offset = "0x28")]
	internal Dictionary<NetworkId, EntityProxy> _outgoingDict;

	// Token: 0x04000104 RID: 260
	[Token(Token = "0x4000104")]
	[FieldOffset(Offset = "0x30")]
	internal Dictionary<NetworkId, EntityProxy> _incommingDict;

	// Token: 0x04000105 RID: 261
	[Token(Token = "0x4000105")]
	[FieldOffset(Offset = "0x38")]
	private List<EntityProxy> _prioritized;

	// Token: 0x02000033 RID: 51
	[Token(Token = "0x2000033")]
	internal class CommandChannel : BoltChannel
	{
		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x00002910 File Offset: 0x00000B10
		[Token(Token = "0x17000064")]
		private int pingFrames
		{
			[Token(Token = "0x60001D9")]
			[Address(RVA = "0x7999E0", Offset = "0x797FE0", VA = "0x1807999E0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060001DA RID: 474 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000065")]
		private Dictionary<NetworkId, EntityProxy> incommingProxiesByNetworkId
		{
			[Token(Token = "0x60001DA")]
			[Address(RVA = "0x799AD0", Offset = "0x7980D0", VA = "0x180799AD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060001DB RID: 475 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000066")]
		private Dictionary<NetworkId, EntityProxy> outgoingProxiesByNetworkId
		{
			[Token(Token = "0x60001DB")]
			[Address(RVA = "0x799B00", Offset = "0x798100", VA = "0x180799B00")]
			get
			{
				return null;
			}
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public CommandChannel()
		{
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x799B30", Offset = "0x798130", VA = "0x180799B30", Slot = "4")]
		public override void Pack(Packet packet)
		{
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x799BA0", Offset = "0x7981A0", VA = "0x180799BA0", Slot = "5")]
		public override void Read(Packet packet)
		{
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00002928 File Offset: 0x00000B28
		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x799C10", Offset = "0x798210", VA = "0x180799C10")]
		private bool EntityHasUnsentState(Entity entity)
		{
			return default(bool);
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x799D80", Offset = "0x798380", VA = "0x180799D80")]
		private void PackResult(Packet packet)
		{
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x79A740", Offset = "0x798D40", VA = "0x18079A740")]
		private void ReadResult(Packet packet)
		{
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x79AC70", Offset = "0x799270", VA = "0x18079AC70")]
		private void PackInput(Packet packet)
		{
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x79B480", Offset = "0x799A80", VA = "0x18079B480")]
		private void ReadInput(Packet packet)
		{
		}
	}
}
