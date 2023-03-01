using System;
using System.Runtime.CompilerServices;
using Bolt;
using Il2CppDummyDll;
using Sons.Multiplayer;
using UdpKit;

// Token: 0x020000A4 RID: 164
[Token(Token = "0x20000A4")]
public class CoopAckChecker : GlobalEventListener
{
	// Token: 0x14000002 RID: 2
	// (add) Token: 0x06000566 RID: 1382 RVA: 0x00002053 File Offset: 0x00000253
	// (remove) Token: 0x06000567 RID: 1383 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x14000002")]
	public static event Action<CoopKickToken> OnKickedOrBanned
	{
		[Token(Token = "0x6000566")]
		[Address(RVA = "0x2D4ECD0", Offset = "0x2D4DCD0", VA = "0x182D4ECD0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000567")]
		[Address(RVA = "0x2D4F050", Offset = "0x2D4E050", VA = "0x182D4F050")]
		[CompilerGenerated]
		remove
		{
		}
	}

	// Token: 0x14000003 RID: 3
	// (add) Token: 0x06000568 RID: 1384 RVA: 0x00002053 File Offset: 0x00000253
	// (remove) Token: 0x06000569 RID: 1385 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x14000003")]
	public static event Action<ServerShutdownToken> OnServerShutdown
	{
		[Token(Token = "0x6000568")]
		[Address(RVA = "0x2D4EDB0", Offset = "0x2D4DDB0", VA = "0x182D4EDB0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000569")]
		[Address(RVA = "0x2D4F130", Offset = "0x2D4E130", VA = "0x182D4F130")]
		[CompilerGenerated]
		remove
		{
		}
	}

	// Token: 0x14000004 RID: 4
	// (add) Token: 0x0600056A RID: 1386 RVA: 0x00002053 File Offset: 0x00000253
	// (remove) Token: 0x0600056B RID: 1387 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x14000004")]
	public static event Action<IProtocolToken> OnUndefinedDisconnected
	{
		[Token(Token = "0x600056A")]
		[Address(RVA = "0x2D4EE90", Offset = "0x2D4DE90", VA = "0x182D4EE90")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600056B")]
		[Address(RVA = "0x2D4F210", Offset = "0x2D4E210", VA = "0x182D4F210")]
		[CompilerGenerated]
		remove
		{
		}
	}

	// Token: 0x14000005 RID: 5
	// (add) Token: 0x0600056C RID: 1388 RVA: 0x00002053 File Offset: 0x00000253
	// (remove) Token: 0x0600056D RID: 1389 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x14000005")]
	public static event Action<BoltConnection> OnConnected
	{
		[Token(Token = "0x600056C")]
		[Address(RVA = "0x2D4EBF0", Offset = "0x2D4DBF0", VA = "0x182D4EBF0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600056D")]
		[Address(RVA = "0x2D4EF70", Offset = "0x2D4DF70", VA = "0x182D4EF70")]
		[CompilerGenerated]
		remove
		{
		}
	}

	// Token: 0x0600056E RID: 1390 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600056E")]
	[Address(RVA = "0x2D4E400", Offset = "0x2D4D400", VA = "0x182D4E400")]
	private void Awake()
	{
	}

	// Token: 0x0600056F RID: 1391 RVA: 0x00003A38 File Offset: 0x00001C38
	[Token(Token = "0x600056F")]
	[Address(RVA = "0x582970", Offset = "0x581970", VA = "0x180582970", Slot = "10")]
	public override bool PersistBetweenStartupAndShutdown()
	{
		return default(bool);
	}

	// Token: 0x06000570 RID: 1392 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000570")]
	[Address(RVA = "0x2D4E730", Offset = "0x2D4D730", VA = "0x182D4E730", Slot = "23")]
	public override void Connected(BoltConnection connection)
	{
	}

	// Token: 0x06000571 RID: 1393 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000571")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	private void OnConnectedToServer()
	{
	}

	// Token: 0x06000572 RID: 1394 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000572")]
	[Address(RVA = "0x2D4E5D0", Offset = "0x2D4D5D0", VA = "0x182D4E5D0", Slot = "26")]
	public override void ConnectRefused(UdpEndPoint endpoint, IProtocolToken token)
	{
	}

	// Token: 0x06000573 RID: 1395 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000573")]
	[Address(RVA = "0x2D4E680", Offset = "0x2D4D680", VA = "0x182D4E680", Slot = "25")]
	public override void ConnectRequest(UdpEndPoint endpoint, IProtocolToken token)
	{
	}

	// Token: 0x06000574 RID: 1396 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000574")]
	[Address(RVA = "0x2D4EB10", Offset = "0x2D4DB10", VA = "0x182D4EB10", Slot = "246")]
	public override void OnEvent(ClientACK evnt)
	{
	}

	// Token: 0x06000575 RID: 1397 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000575")]
	[Address(RVA = "0x2D4E8A0", Offset = "0x2D4D8A0", VA = "0x182D4E8A0")]
	public static void CreateIfNotExists()
	{
	}

	// Token: 0x06000576 RID: 1398 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000576")]
	[Address(RVA = "0x2D4E960", Offset = "0x2D4D960", VA = "0x182D4E960", Slot = "28")]
	public override void Disconnected(BoltConnection connection)
	{
	}

	// Token: 0x06000577 RID: 1399 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000577")]
	[Address(RVA = "0x122BAB0", Offset = "0x122AAB0", VA = "0x18122BAB0")]
	public CoopAckChecker()
	{
	}

	// Token: 0x040004EE RID: 1262
	[Token(Token = "0x40004EE")]
	[FieldOffset(Offset = "0x0")]
	public static bool ACKED;

	// Token: 0x040004EF RID: 1263
	[Token(Token = "0x40004EF")]
	[FieldOffset(Offset = "0x8")]
	public static CoopAckChecker Instance;

	// Token: 0x040004F0 RID: 1264
	[Token(Token = "0x40004F0")]
	[FieldOffset(Offset = "0x38")]
	private bool _queuedDestroyed;
}
