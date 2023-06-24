using System;
using Endnight.Types;
using Il2CppDummyDll;
using UnityEngine.SceneManagement;

// Token: 0x020000C3 RID: 195
[Token(Token = "0x20000C3")]
[BoltGlobalBehaviour]
public class CoopPlayerCallbacks : SingletonBoltListenerBehaviour<CoopPlayerCallbacks>
{
	// Token: 0x06000634 RID: 1588 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000634")]
	[Address(RVA = "0x3513AD0", Offset = "0x35120D0", VA = "0x183513AD0")]
	public static void Prewarm()
	{
	}

	// Token: 0x06000635 RID: 1589 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000635")]
	[Address(RVA = "0x3513B00", Offset = "0x3512100", VA = "0x183513B00", Slot = "337")]
	public override void OnEvent(JumpTimeEvent jumpTimeEvent)
	{
	}

	// Token: 0x06000636 RID: 1590 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000636")]
	[Address(RVA = "0x3514270", Offset = "0x3512870", VA = "0x183514270", Slot = "266")]
	public override void OnEvent(TakeBodyApprove evnt)
	{
	}

	// Token: 0x06000637 RID: 1591 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000637")]
	[Address(RVA = "0x35143C0", Offset = "0x35129C0", VA = "0x1835143C0", Slot = "249")]
	public override void OnEvent(ItemRemoveFromPlayer evnt)
	{
	}

	// Token: 0x06000638 RID: 1592 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000638")]
	[Address(RVA = "0x3514580", Offset = "0x3512B80", VA = "0x183514580", Slot = "277")]
	public override void OnEvent(DisablePickup evnt)
	{
	}

	// Token: 0x06000639 RID: 1593 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000639")]
	[Address(RVA = "0x3514710", Offset = "0x3512D10", VA = "0x183514710", Slot = "302")]
	public override void OnEvent(TakeClothingOutfit evnt)
	{
	}

	// Token: 0x0600063A RID: 1594 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600063A")]
	[Address(RVA = "0x3514800", Offset = "0x3512E00", VA = "0x183514800", Slot = "215")]
	public override void OnEvent(DestroyPickUp evnt)
	{
	}

	// Token: 0x0600063B RID: 1595 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600063B")]
	[Address(RVA = "0x3514CC0", Offset = "0x35132C0", VA = "0x183514CC0", Slot = "237")]
	public override void OnEvent(FmodOneShot evnt)
	{
	}

	// Token: 0x0600063C RID: 1596 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600063C")]
	[Address(RVA = "0x3514EA0", Offset = "0x35134A0", VA = "0x183514EA0", Slot = "260")]
	public override void OnEvent(FmodOneShotParameter evnt)
	{
	}

	// Token: 0x0600063D RID: 1597 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600063D")]
	[Address(RVA = "0x3515100", Offset = "0x3513700", VA = "0x183515100", Slot = "275")]
	public override void OnEvent(AdminAuthed evnt)
	{
	}

	// Token: 0x0600063E RID: 1598 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600063E")]
	[Address(RVA = "0x35151A0", Offset = "0x35137A0", VA = "0x1835151A0", Slot = "219")]
	public override void OnEvent(ChatEvent evnt)
	{
	}

	// Token: 0x0600063F RID: 1599 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600063F")]
	[Address(RVA = "0x3515440", Offset = "0x3513A40", VA = "0x183515440", Slot = "31")]
	public override void EntityAttached(BoltEntity arg)
	{
	}

	// Token: 0x06000640 RID: 1600 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000640")]
	[Address(RVA = "0x3515A70", Offset = "0x3514070", VA = "0x183515A70", Slot = "223")]
	public override void OnEvent(RequestDestroy evnt)
	{
	}

	// Token: 0x06000641 RID: 1601 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000641")]
	[Address(RVA = "0x3516090", Offset = "0x3514690", VA = "0x183516090", Slot = "32")]
	public override void EntityDetached(BoltEntity arg)
	{
	}

	// Token: 0x06000642 RID: 1602 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000642")]
	[Address(RVA = "0x35162C0", Offset = "0x35148C0", VA = "0x1835162C0", Slot = "23")]
	public override void Connected(BoltConnection connection)
	{
	}

	// Token: 0x06000643 RID: 1603 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000643")]
	[Address(RVA = "0x3516440", Offset = "0x3514A40", VA = "0x183516440", Slot = "28")]
	public override void Disconnected(BoltConnection connection)
	{
	}

	// Token: 0x06000644 RID: 1604 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000644")]
	[Address(RVA = "0x3516820", Offset = "0x3514E20", VA = "0x183516820")]
	private void ShowKickModal(Scene scene, LoadSceneMode mode)
	{
	}

	// Token: 0x06000645 RID: 1605 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000645")]
	[Address(RVA = "0x3516900", Offset = "0x3514F00", VA = "0x183516900")]
	private void ShowBanModal(Scene scene, LoadSceneMode mode)
	{
	}

	// Token: 0x06000646 RID: 1606 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000646")]
	[Address(RVA = "0x35169E0", Offset = "0x3514FE0", VA = "0x1835169E0", Slot = "240")]
	public override void OnEvent(PlayerHealed evnt)
	{
	}

	// Token: 0x06000647 RID: 1607 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000647")]
	[Address(RVA = "0x3516B70", Offset = "0x3515170", VA = "0x183516B70", Slot = "251")]
	public override void OnEvent(StealItem evnt)
	{
	}

	// Token: 0x06000648 RID: 1608 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000648")]
	[Address(RVA = "0x3516F60", Offset = "0x3515560", VA = "0x183516F60", Slot = "244")]
	public override void OnEvent(PlayerAddItem boltEvent)
	{
	}

	// Token: 0x06000649 RID: 1609 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000649")]
	[Address(RVA = "0x3517330", Offset = "0x3515930", VA = "0x183517330", Slot = "281")]
	public override void OnEvent(Sleep evnt)
	{
	}

	// Token: 0x0600064A RID: 1610 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600064A")]
	[Address(RVA = "0x3517400", Offset = "0x3515A00", VA = "0x183517400")]
	public CoopPlayerCallbacks()
	{
	}

	// Token: 0x04000554 RID: 1364
	[Token(Token = "0x4000554")]
	[FieldOffset(Offset = "0x0")]
	public static bool WasDisconnectedFromServer;

	// Token: 0x04000555 RID: 1365
	[Token(Token = "0x4000555")]
	private const string ChannelVoice = "Voice";
}
