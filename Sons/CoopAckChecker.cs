using System;
using System.Runtime.CompilerServices;
using Bolt;
using Il2CppDummyDll;
using Sons.BlobNetworking;
using Sons.Multiplayer;
using UdpKit;

// Token: 0x020000A3 RID: 163
[Token(Token = "0x20000A3")]
public class CoopAckChecker : GlobalEventListener
{
	// Token: 0x170000D4 RID: 212
	// (get) Token: 0x0600058E RID: 1422 RVA: 0x00003BA0 File Offset: 0x00001DA0
	// (set) Token: 0x0600058F RID: 1423 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170000D4")]
	public static bool ACKED
	{
		[Token(Token = "0x600058E")]
		[Address(RVA = "0x3509C60", Offset = "0x3508260", VA = "0x183509C60")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600058F")]
		[Address(RVA = "0x3509CA0", Offset = "0x35082A0", VA = "0x183509CA0")]
		set
		{
		}
	}

	// Token: 0x14000002 RID: 2
	// (add) Token: 0x06000590 RID: 1424 RVA: 0x00002053 File Offset: 0x00000253
	// (remove) Token: 0x06000591 RID: 1425 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x14000002")]
	public static event Action<CoopKickToken> OnKickedOrBanned
	{
		[Token(Token = "0x6000590")]
		[Address(RVA = "0x3509D80", Offset = "0x3508380", VA = "0x183509D80")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000591")]
		[Address(RVA = "0x3509F10", Offset = "0x3508510", VA = "0x183509F10")]
		[CompilerGenerated]
		remove
		{
		}
	}

	// Token: 0x14000003 RID: 3
	// (add) Token: 0x06000592 RID: 1426 RVA: 0x00002053 File Offset: 0x00000253
	// (remove) Token: 0x06000593 RID: 1427 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x14000003")]
	public static event Action<ServerShutdownToken> OnServerShutdown
	{
		[Token(Token = "0x6000592")]
		[Address(RVA = "0x350A0A0", Offset = "0x35086A0", VA = "0x18350A0A0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000593")]
		[Address(RVA = "0x350A230", Offset = "0x3508830", VA = "0x18350A230")]
		[CompilerGenerated]
		remove
		{
		}
	}

	// Token: 0x14000004 RID: 4
	// (add) Token: 0x06000594 RID: 1428 RVA: 0x00002053 File Offset: 0x00000253
	// (remove) Token: 0x06000595 RID: 1429 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x14000004")]
	public static event Action<IProtocolToken> OnUndefinedDisconnected
	{
		[Token(Token = "0x6000594")]
		[Address(RVA = "0x350A3C0", Offset = "0x35089C0", VA = "0x18350A3C0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000595")]
		[Address(RVA = "0x350A550", Offset = "0x3508B50", VA = "0x18350A550")]
		[CompilerGenerated]
		remove
		{
		}
	}

	// Token: 0x14000005 RID: 5
	// (add) Token: 0x06000596 RID: 1430 RVA: 0x00002053 File Offset: 0x00000253
	// (remove) Token: 0x06000597 RID: 1431 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x14000005")]
	public static event Action<CoopJoinDedicatedServerFailed> OnWrongPassword
	{
		[Token(Token = "0x6000596")]
		[Address(RVA = "0x350A6E0", Offset = "0x3508CE0", VA = "0x18350A6E0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000597")]
		[Address(RVA = "0x350A870", Offset = "0x3508E70", VA = "0x18350A870")]
		[CompilerGenerated]
		remove
		{
		}
	}

	// Token: 0x14000006 RID: 6
	// (add) Token: 0x06000598 RID: 1432 RVA: 0x00002053 File Offset: 0x00000253
	// (remove) Token: 0x06000599 RID: 1433 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x14000006")]
	public static event Action<BoltConnection> OnConnected
	{
		[Token(Token = "0x6000598")]
		[Address(RVA = "0x350AA00", Offset = "0x3509000", VA = "0x18350AA00")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000599")]
		[Address(RVA = "0x350AB90", Offset = "0x3509190", VA = "0x18350AB90")]
		[CompilerGenerated]
		remove
		{
		}
	}

	// Token: 0x0600059A RID: 1434 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600059A")]
	[Address(RVA = "0x350AD20", Offset = "0x3509320", VA = "0x18350AD20")]
	private void Awake()
	{
	}

	// Token: 0x0600059B RID: 1435 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600059B")]
	[Address(RVA = "0x350B1B0", Offset = "0x35097B0", VA = "0x18350B1B0", Slot = "13")]
	public override void BoltStartDone()
	{
	}

	// Token: 0x0600059C RID: 1436 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600059C")]
	[Address(RVA = "0x350B470", Offset = "0x3509A70", VA = "0x18350B470")]
	private void OnRemoteConnectedToBlobTransport(BlobTransportRemote remote)
	{
	}

	// Token: 0x0600059D RID: 1437 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600059D")]
	[Address(RVA = "0x350B5D0", Offset = "0x3509BD0", VA = "0x18350B5D0")]
	private void Update()
	{
	}

	// Token: 0x0600059E RID: 1438 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600059E")]
	[Address(RVA = "0x350B670", Offset = "0x3509C70", VA = "0x18350B670")]
	private void OnDestroy()
	{
	}

	// Token: 0x0600059F RID: 1439 RVA: 0x00003BB8 File Offset: 0x00001DB8
	[Token(Token = "0x600059F")]
	[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "10")]
	public override bool PersistBetweenStartupAndShutdown()
	{
		return default(bool);
	}

	// Token: 0x060005A0 RID: 1440 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005A0")]
	[Address(RVA = "0x350B6B0", Offset = "0x3509CB0", VA = "0x18350B6B0", Slot = "23")]
	public override void Connected(BoltConnection connection)
	{
	}

	// Token: 0x060005A1 RID: 1441 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005A1")]
	[Address(RVA = "0x350BA70", Offset = "0x350A070", VA = "0x18350BA70", Slot = "26")]
	public override void ConnectRefused(UdpEndPoint endpoint, IProtocolToken token)
	{
	}

	// Token: 0x060005A2 RID: 1442 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005A2")]
	[Address(RVA = "0x350BAF0", Offset = "0x350A0F0", VA = "0x18350BAF0", Slot = "25")]
	public override void ConnectRequest(UdpEndPoint endpoint, IProtocolToken token)
	{
	}

	// Token: 0x060005A3 RID: 1443 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005A3")]
	[Address(RVA = "0x350BB70", Offset = "0x350A170", VA = "0x18350BB70", Slot = "264")]
	public override void OnEvent(ClientACK evnt)
	{
	}

	// Token: 0x060005A4 RID: 1444 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005A4")]
	[Address(RVA = "0x350BCE0", Offset = "0x350A2E0", VA = "0x18350BCE0", Slot = "373")]
	public override void OnEvent(BlobSyncConnect evnt)
	{
	}

	// Token: 0x060005A5 RID: 1445 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005A5")]
	[Address(RVA = "0x350BEA0", Offset = "0x350A4A0", VA = "0x18350BEA0")]
	public static void CreateIfNotExists()
	{
	}

	// Token: 0x060005A6 RID: 1446 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005A6")]
	[Address(RVA = "0x350BFC0", Offset = "0x350A5C0", VA = "0x18350BFC0", Slot = "28")]
	public override void Disconnected(BoltConnection connection)
	{
	}

	// Token: 0x060005A7 RID: 1447 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005A7")]
	[Address(RVA = "0x144EB80", Offset = "0x144D180", VA = "0x18144EB80")]
	public CoopAckChecker()
	{
	}

	// Token: 0x0400050B RID: 1291
	[Token(Token = "0x400050B")]
	[FieldOffset(Offset = "0x0")]
	public static bool _acked;

	// Token: 0x0400050C RID: 1292
	[Token(Token = "0x400050C")]
	[FieldOffset(Offset = "0x8")]
	public static CoopAckChecker Instance;

	// Token: 0x0400050D RID: 1293
	[Token(Token = "0x400050D")]
	[FieldOffset(Offset = "0x38")]
	private bool _queuedDestroyed;
}
