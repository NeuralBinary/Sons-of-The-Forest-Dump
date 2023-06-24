using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000183 RID: 387
[Token(Token = "0x2000183")]
public class SetGuiTextureColor : Event
{
	// Token: 0x060011A7 RID: 4519 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011A7")]
	[Address(RVA = "0x886CE0", Offset = "0x8852E0", VA = "0x180886CE0")]
	public SetGuiTextureColor()
	{
	}

	// Token: 0x170005FD RID: 1533
	// (get) Token: 0x060011A8 RID: 4520 RVA: 0x00006840 File Offset: 0x00004A40
	// (set) Token: 0x060011A9 RID: 4521 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170005FD")]
	public Color Color
	{
		[Token(Token = "0x60011A8")]
		[Address(RVA = "0x886D40", Offset = "0x885340", VA = "0x180886D40")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x60011A9")]
		[Address(RVA = "0x886DB0", Offset = "0x8853B0", VA = "0x180886DB0")]
		set
		{
		}
	}

	// Token: 0x170005FE RID: 1534
	// (get) Token: 0x060011AA RID: 4522 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x060011AB RID: 4523 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170005FE")]
	public BoltEntity Target
	{
		[Token(Token = "0x60011AA")]
		[Address(RVA = "0x7DB3B0", Offset = "0x7D99B0", VA = "0x1807DB3B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60011AB")]
		[Address(RVA = "0x886E40", Offset = "0x885440", VA = "0x180886E40")]
		set
		{
		}
	}

	// Token: 0x060011AC RID: 4524 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011AC")]
	[Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x060011AD RID: 4525 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011AD")]
	[Address(RVA = "0x887190", Offset = "0x885790", VA = "0x180887190")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SetGuiTextureColor Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x060011AE RID: 4526 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011AE")]
	[Address(RVA = "0x8871A0", Offset = "0x8857A0", VA = "0x1808871A0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SetGuiTextureColor Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x060011AF RID: 4527 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011AF")]
	[Address(RVA = "0x8873A0", Offset = "0x8859A0", VA = "0x1808873A0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static SetGuiTextureColor Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060011B0 RID: 4528 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011B0")]
	[Address(RVA = "0x8874C0", Offset = "0x885AC0", VA = "0x1808874C0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SetGuiTextureColor Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x060011B1 RID: 4529 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011B1")]
	[Address(RVA = "0x8874D0", Offset = "0x885AD0", VA = "0x1808874D0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SetGuiTextureColor Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060011B2 RID: 4530 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011B2")]
	[Address(RVA = "0x8874E0", Offset = "0x885AE0", VA = "0x1808874E0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SetGuiTextureColor Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x060011B3 RID: 4531 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011B3")]
	[Address(RVA = "0x8874F0", Offset = "0x885AF0", VA = "0x1808874F0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SetGuiTextureColor Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060011B4 RID: 4532 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011B4")]
	[Address(RVA = "0x887510", Offset = "0x885B10", VA = "0x180887510")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SetGuiTextureColor Raise()
	{
		return null;
	}

	// Token: 0x060011B5 RID: 4533 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011B5")]
	[Address(RVA = "0x887530", Offset = "0x885B30", VA = "0x180887530")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SetGuiTextureColor Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060011B6 RID: 4534 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011B6")]
	[Address(RVA = "0x887190", Offset = "0x885790", VA = "0x180887190")]
	public static SetGuiTextureColor Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x060011B7 RID: 4535 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011B7")]
	[Address(RVA = "0x887540", Offset = "0x885B40", VA = "0x180887540")]
	public static SetGuiTextureColor Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x060011B8 RID: 4536 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011B8")]
	[Address(RVA = "0x887740", Offset = "0x885D40", VA = "0x180887740")]
	private static SetGuiTextureColor Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060011B9 RID: 4537 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011B9")]
	[Address(RVA = "0x8874C0", Offset = "0x885AC0", VA = "0x1808874C0")]
	public static SetGuiTextureColor Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x060011BA RID: 4538 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011BA")]
	[Address(RVA = "0x8874D0", Offset = "0x885AD0", VA = "0x1808874D0")]
	public static SetGuiTextureColor Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060011BB RID: 4539 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011BB")]
	[Address(RVA = "0x8874E0", Offset = "0x885AE0", VA = "0x1808874E0")]
	public static SetGuiTextureColor Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x060011BC RID: 4540 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011BC")]
	[Address(RVA = "0x8874F0", Offset = "0x885AF0", VA = "0x1808874F0")]
	public static SetGuiTextureColor Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060011BD RID: 4541 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011BD")]
	[Address(RVA = "0x887510", Offset = "0x885B10", VA = "0x180887510")]
	public static SetGuiTextureColor Create()
	{
		return null;
	}

	// Token: 0x060011BE RID: 4542 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011BE")]
	[Address(RVA = "0x887530", Offset = "0x885B30", VA = "0x180887530")]
	public static SetGuiTextureColor Create(ReliabilityModes reliability)
	{
		return null;
	}
}
