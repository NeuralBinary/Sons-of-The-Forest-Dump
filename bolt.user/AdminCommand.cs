using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200016B RID: 363
[Token(Token = "0x200016B")]
public class AdminCommand : Event
{
	// Token: 0x06001099 RID: 4249 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001099")]
	[Address(RVA = "0x87EB30", Offset = "0x87D130", VA = "0x18087EB30")]
	public AdminCommand()
	{
	}

	// Token: 0x170005D6 RID: 1494
	// (get) Token: 0x0600109A RID: 4250 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x0600109B RID: 4251 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170005D6")]
	public string Command
	{
		[Token(Token = "0x600109A")]
		[Address(RVA = "0x7D27A0", Offset = "0x7D0DA0", VA = "0x1807D27A0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600109B")]
		[Address(RVA = "0x84C060", Offset = "0x84A660", VA = "0x18084C060")]
		set
		{
		}
	}

	// Token: 0x170005D7 RID: 1495
	// (get) Token: 0x0600109C RID: 4252 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x0600109D RID: 4253 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170005D7")]
	public string Data
	{
		[Token(Token = "0x600109C")]
		[Address(RVA = "0x83FC10", Offset = "0x83E210", VA = "0x18083FC10")]
		get
		{
			return null;
		}
		[Token(Token = "0x600109D")]
		[Address(RVA = "0x83FCB0", Offset = "0x83E2B0", VA = "0x18083FCB0")]
		set
		{
		}
	}

	// Token: 0x0600109E RID: 4254 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600109E")]
	[Address(RVA = "0x87EB90", Offset = "0x87D190", VA = "0x18087EB90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x0600109F RID: 4255 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600109F")]
	[Address(RVA = "0x87EBF0", Offset = "0x87D1F0", VA = "0x18087EBF0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static AdminCommand Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x060010A0 RID: 4256 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60010A0")]
	[Address(RVA = "0x87EC00", Offset = "0x87D200", VA = "0x18087EC00")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static AdminCommand Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x060010A1 RID: 4257 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60010A1")]
	[Address(RVA = "0x87EE00", Offset = "0x87D400", VA = "0x18087EE00")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static AdminCommand Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060010A2 RID: 4258 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60010A2")]
	[Address(RVA = "0x87EF20", Offset = "0x87D520", VA = "0x18087EF20")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static AdminCommand Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x060010A3 RID: 4259 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60010A3")]
	[Address(RVA = "0x87EF30", Offset = "0x87D530", VA = "0x18087EF30")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static AdminCommand Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060010A4 RID: 4260 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60010A4")]
	[Address(RVA = "0x87EF40", Offset = "0x87D540", VA = "0x18087EF40")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static AdminCommand Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x060010A5 RID: 4261 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60010A5")]
	[Address(RVA = "0x87EF50", Offset = "0x87D550", VA = "0x18087EF50")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static AdminCommand Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060010A6 RID: 4262 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60010A6")]
	[Address(RVA = "0x87EF70", Offset = "0x87D570", VA = "0x18087EF70")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static AdminCommand Raise()
	{
		return null;
	}

	// Token: 0x060010A7 RID: 4263 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60010A7")]
	[Address(RVA = "0x87EF90", Offset = "0x87D590", VA = "0x18087EF90")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static AdminCommand Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060010A8 RID: 4264 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60010A8")]
	[Address(RVA = "0x87EBF0", Offset = "0x87D1F0", VA = "0x18087EBF0")]
	public static AdminCommand Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x060010A9 RID: 4265 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60010A9")]
	[Address(RVA = "0x87EFA0", Offset = "0x87D5A0", VA = "0x18087EFA0")]
	public static AdminCommand Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x060010AA RID: 4266 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60010AA")]
	[Address(RVA = "0x87F1A0", Offset = "0x87D7A0", VA = "0x18087F1A0")]
	private static AdminCommand Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060010AB RID: 4267 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60010AB")]
	[Address(RVA = "0x87EF20", Offset = "0x87D520", VA = "0x18087EF20")]
	public static AdminCommand Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x060010AC RID: 4268 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60010AC")]
	[Address(RVA = "0x87EF30", Offset = "0x87D530", VA = "0x18087EF30")]
	public static AdminCommand Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060010AD RID: 4269 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60010AD")]
	[Address(RVA = "0x87EF40", Offset = "0x87D540", VA = "0x18087EF40")]
	public static AdminCommand Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x060010AE RID: 4270 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60010AE")]
	[Address(RVA = "0x87EF50", Offset = "0x87D550", VA = "0x18087EF50")]
	public static AdminCommand Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060010AF RID: 4271 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60010AF")]
	[Address(RVA = "0x87EF70", Offset = "0x87D570", VA = "0x18087EF70")]
	public static AdminCommand Create()
	{
		return null;
	}

	// Token: 0x060010B0 RID: 4272 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60010B0")]
	[Address(RVA = "0x87EF90", Offset = "0x87D590", VA = "0x18087EF90")]
	public static AdminCommand Create(ReliabilityModes reliability)
	{
		return null;
	}
}
