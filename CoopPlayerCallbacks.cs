using System;
using Endnight.Types;
using Il2CppDummyDll;

// Token: 0x020000C5 RID: 197
[Token(Token = "0x20000C5")]
[BoltGlobalBehaviour]
public class CoopPlayerCallbacks : SingletonBoltListenerBehaviour<CoopPlayerCallbacks>
{
	// Token: 0x060005FE RID: 1534 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005FE")]
	[Address(RVA = "0x2E7A970", Offset = "0x2E79970", VA = "0x182E7A970")]
	public static void Prewarm()
	{
	}

	// Token: 0x060005FF RID: 1535 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005FF")]
	[Address(RVA = "0x2E79110", Offset = "0x2E78110", VA = "0x182E79110", Slot = "319")]
	public override void OnEvent(JumpTimeEvent jumpTimeEvent)
	{
	}

	// Token: 0x06000600 RID: 1536 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000600")]
	[Address(RVA = "0x2E7A6E0", Offset = "0x2E796E0", VA = "0x182E7A6E0", Slot = "248")]
	public override void OnEvent(TakeBodyApprove evnt)
	{
	}

	// Token: 0x06000601 RID: 1537 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000601")]
	[Address(RVA = "0x2E7A760", Offset = "0x2E79760", VA = "0x182E7A760", Slot = "231")]
	public override void OnEvent(ItemRemoveFromPlayer evnt)
	{
	}

	// Token: 0x06000602 RID: 1538 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000602")]
	[Address(RVA = "0x2E79A90", Offset = "0x2E78A90", VA = "0x182E79A90", Slot = "259")]
	public override void OnEvent(DisablePickup evnt)
	{
	}

	// Token: 0x06000603 RID: 1539 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000603")]
	[Address(RVA = "0x2E7A380", Offset = "0x2E79380", VA = "0x182E7A380", Slot = "284")]
	public override void OnEvent(TakeClothingOutfit evnt)
	{
	}

	// Token: 0x06000604 RID: 1540 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000604")]
	[Address(RVA = "0x2E79BC0", Offset = "0x2E78BC0", VA = "0x182E79BC0", Slot = "197")]
	public override void OnEvent(DestroyPickUp evnt)
	{
	}

	// Token: 0x06000605 RID: 1541 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000605")]
	[Address(RVA = "0x2E7A880", Offset = "0x2E79880", VA = "0x182E7A880", Slot = "219")]
	public override void OnEvent(FmodOneShot evnt)
	{
	}

	// Token: 0x06000606 RID: 1542 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000606")]
	[Address(RVA = "0x2E7A1D0", Offset = "0x2E791D0", VA = "0x182E7A1D0", Slot = "242")]
	public override void OnEvent(FmodOneShotParameter evnt)
	{
	}

	// Token: 0x06000607 RID: 1543 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000607")]
	[Address(RVA = "0x2E79590", Offset = "0x2E78590", VA = "0x182E79590", Slot = "257")]
	public override void OnEvent(AdminAuthed evnt)
	{
	}

	// Token: 0x06000608 RID: 1544 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000608")]
	[Address(RVA = "0x2E78E70", Offset = "0x2E77E70", VA = "0x182E78E70", Slot = "201")]
	public override void OnEvent(ChatEvent evnt)
	{
	}

	// Token: 0x06000609 RID: 1545 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000609")]
	[Address(RVA = "0x2E78780", Offset = "0x2E77780", VA = "0x182E78780", Slot = "31")]
	public override void EntityAttached(BoltEntity arg)
	{
	}

	// Token: 0x0600060A RID: 1546 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600060A")]
	[Address(RVA = "0x2E795F0", Offset = "0x2E785F0", VA = "0x182E795F0", Slot = "205")]
	public override void OnEvent(RequestDestroy evnt)
	{
	}

	// Token: 0x0600060B RID: 1547 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600060B")]
	[Address(RVA = "0x2E78B80", Offset = "0x2E77B80", VA = "0x182E78B80", Slot = "32")]
	public override void EntityDetached(BoltEntity arg)
	{
	}

	// Token: 0x0600060C RID: 1548 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600060C")]
	[Address(RVA = "0x2E78580", Offset = "0x2E77580", VA = "0x182E78580", Slot = "23")]
	public override void Connected(BoltConnection connection)
	{
	}

	// Token: 0x0600060D RID: 1549 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600060D")]
	[Address(RVA = "0x2E785B0", Offset = "0x2E775B0", VA = "0x182E785B0", Slot = "28")]
	public override void Disconnected(BoltConnection connection)
	{
	}

	// Token: 0x0600060E RID: 1550 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600060E")]
	[Address(RVA = "0x2E78D80", Offset = "0x2E77D80", VA = "0x182E78D80", Slot = "222")]
	public override void OnEvent(PlayerHealed evnt)
	{
	}

	// Token: 0x0600060F RID: 1551 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600060F")]
	[Address(RVA = "0x2E79F60", Offset = "0x2E78F60", VA = "0x182E79F60", Slot = "233")]
	public override void OnEvent(StealItem evnt)
	{
	}

	// Token: 0x06000610 RID: 1552 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000610")]
	[Address(RVA = "0x2E7A420", Offset = "0x2E79420", VA = "0x182E7A420", Slot = "226")]
	public override void OnEvent(PlayerAddItem boltEvent)
	{
	}

	// Token: 0x06000611 RID: 1553 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000611")]
	[Address(RVA = "0x2E78D00", Offset = "0x2E77D00", VA = "0x182E78D00", Slot = "263")]
	public override void OnEvent(Sleep evnt)
	{
	}

	// Token: 0x06000612 RID: 1554 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000612")]
	[Address(RVA = "0x2E7A9A0", Offset = "0x2E799A0", VA = "0x182E7A9A0")]
	public CoopPlayerCallbacks()
	{
	}

	// Token: 0x0400053A RID: 1338
	[Token(Token = "0x400053A")]
	[FieldOffset(Offset = "0x0")]
	public static bool WasDisconnectedFromServer;

	// Token: 0x0400053B RID: 1339
	[Token(Token = "0x400053B")]
	private const string ChannelVoice = "Voice";
}
