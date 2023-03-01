using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Bolt;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using Sons.TerrainDetail;
using UnityEngine;

// Token: 0x0200006E RID: 110
[Token(Token = "0x200006E")]
[BoltGlobalBehaviour(1)]
public class CoopServerCallbacks : GlobalEventListener
{
	// Token: 0x0600032B RID: 811 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600032B")]
	[Address(RVA = "0x2B6A550", Offset = "0x2B69550", VA = "0x182B6A550", Slot = "331")]
	public override void OnEvent(ZiplineCreateEvent boltEvent)
	{
	}

	// Token: 0x0600032C RID: 812 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600032C")]
	[Address(RVA = "0x2B69D40", Offset = "0x2B68D40", VA = "0x182B69D40", Slot = "332")]
	public override void OnEvent(ZiplineRemoveEvent boltEvent)
	{
	}

	// Token: 0x0600032D RID: 813 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600032D")]
	[Address(RVA = "0x2B6A3E0", Offset = "0x2B693E0", VA = "0x182B6A3E0", Slot = "256")]
	public override void OnEvent(AdminCommand evnt)
	{
	}

	// Token: 0x0600032E RID: 814 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600032E")]
	[Address(RVA = "0x2B6B040", Offset = "0x2B6A040", VA = "0x182B6B040", Slot = "230")]
	public override void OnEvent(LocalizedHit evnt)
	{
	}

	// Token: 0x0600032F RID: 815 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600032F")]
	[Address(RVA = "0x2B6BA40", Offset = "0x2B6AA40", VA = "0x182B6BA40", Slot = "330")]
	public override void OnEvent(ChangeIdObjectState boltEvent)
	{
	}

	// Token: 0x06000330 RID: 816 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000330")]
	[Address(RVA = "0x2B6A430", Offset = "0x2B69430", VA = "0x182B6A430", Slot = "323")]
	public override void OnEvent(AttachItemToZiplineEvent boltEvent)
	{
	}

	// Token: 0x06000331 RID: 817 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000331")]
	[Address(RVA = "0x2B6AFA0", Offset = "0x2B69FA0", VA = "0x182B6AFA0", Slot = "299")]
	public override void OnEvent(StorageContainerOpened boltEvent)
	{
	}

	// Token: 0x06000332 RID: 818 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000332")]
	[Address(RVA = "0x2B6A120", Offset = "0x2B69120", VA = "0x182B6A120", Slot = "306")]
	public override void OnEvent(BreakableObjectBroken boltEvent)
	{
	}

	// Token: 0x06000333 RID: 819 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000333")]
	[Address(RVA = "0x2B69500", Offset = "0x2B68500", VA = "0x182B69500", Slot = "335")]
	public override void OnEvent(DeathMarkerRequest boltEvent)
	{
	}

	// Token: 0x06000334 RID: 820 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000334")]
	[Address(RVA = "0x2B683B0", Offset = "0x2B673B0", VA = "0x182B683B0", Slot = "23")]
	public override void Connected(BoltConnection connection)
	{
	}

	// Token: 0x06000335 RID: 821 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000335")]
	[Address(RVA = "0x2B68AE0", Offset = "0x2B67AE0", VA = "0x182B68AE0", Slot = "28")]
	public override void Disconnected(BoltConnection connection)
	{
	}

	// Token: 0x06000336 RID: 822 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000336")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "255")]
	public override void OnEvent(CutTriggerActivated evnt)
	{
	}

	// Token: 0x06000337 RID: 823 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000337")]
	[Address(RVA = "0x2B6A040", Offset = "0x2B69040", VA = "0x182B6A040", Slot = "281")]
	public override void OnEvent(ValidSleepTime evnt)
	{
	}

	// Token: 0x06000338 RID: 824 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000338")]
	[Address(RVA = "0x2B69570", Offset = "0x2B68570", VA = "0x182B69570", Slot = "198")]
	public override void OnEvent(DropItem boltEvent)
	{
	}

	// Token: 0x06000339 RID: 825 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000339")]
	[Address(RVA = "0x2B6C170", Offset = "0x2B6B170", VA = "0x182B6C170", Slot = "265")]
	public override void OnEvent(PlaceDryingFood evnt)
	{
	}

	// Token: 0x0600033A RID: 826 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600033A")]
	[Address(RVA = "0x2B6B8C0", Offset = "0x2B6A8C0", VA = "0x182B6B8C0", Slot = "227")]
	public override void OnEvent(PlaceFoundationEx evnt)
	{
	}

	// Token: 0x0600033B RID: 827 RVA: 0x00002FE8 File Offset: 0x000011E8
	[Token(Token = "0x600033B")]
	[Address(RVA = "0x2B6C9E0", Offset = "0x2B6B9E0", VA = "0x182B6C9E0")]
	private static bool TryGetVailActor(BoltEntity target, out VailActor actor, string debugName)
	{
		return default(bool);
	}

	// Token: 0x0600033C RID: 828 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600033C")]
	[Address(RVA = "0x2B6C300", Offset = "0x2B6B300", VA = "0x182B6C300", Slot = "293")]
	public override void OnEvent(VailHitEvent ev)
	{
	}

	// Token: 0x0600033D RID: 829 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600033D")]
	[Address(RVA = "0x2B69F00", Offset = "0x2B68F00", VA = "0x182B69F00", Slot = "321")]
	public override void OnEvent(VailParriedEvent ev)
	{
	}

	// Token: 0x0600033E RID: 830 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600033E")]
	[Address(RVA = "0x2B6AAE0", Offset = "0x2B69AE0", VA = "0x182B6AAE0", Slot = "334")]
	public override void OnEvent(VailReviveEvent ev)
	{
	}

	// Token: 0x0600033F RID: 831 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600033F")]
	[Address(RVA = "0x2B6BAA0", Offset = "0x2B6AAA0", VA = "0x182B6BAA0", Slot = "307")]
	public override void OnEvent(DismemberHitEvent ev)
	{
	}

	// Token: 0x06000340 RID: 832 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000340")]
	[Address(RVA = "0x2B6C0E0", Offset = "0x2B6B0E0", VA = "0x182B6C0E0", Slot = "204")]
	public override void OnEvent(SkinnedAnimal ev)
	{
	}

	// Token: 0x06000341 RID: 833 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000341")]
	[Address(RVA = "0x2B6BF60", Offset = "0x2B6AF60", VA = "0x182B6BF60", Slot = "345")]
	public override void OnEvent(PlayerRequestActorItem ev)
	{
	}

	// Token: 0x06000342 RID: 834 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000342")]
	[Address(RVA = "0x2B6AB60", Offset = "0x2B69B60", VA = "0x182B6AB60", Slot = "326")]
	public override void OnEvent(PlayerGiveActorItem boltEvent)
	{
	}

	// Token: 0x06000343 RID: 835 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000343")]
	[Address(RVA = "0x2B6C160", Offset = "0x2B6B160", VA = "0x182B6C160", Slot = "294")]
	public override void OnEvent(VailNoiseEvent ev)
	{
	}

	// Token: 0x06000344 RID: 836 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000344")]
	[Address(RVA = "0x2B6C250", Offset = "0x2B6B250", VA = "0x182B6C250", Slot = "297")]
	public override void OnEvent(RobbyOrderEvent evnt)
	{
	}

	// Token: 0x06000345 RID: 837 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000345")]
	[Address(RVA = "0x2B6A070", Offset = "0x2B69070", VA = "0x182B6A070", Slot = "311")]
	public override void OnEvent(RadioActivate evnt)
	{
	}

	// Token: 0x06000346 RID: 838 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000346")]
	[Address(RVA = "0x2B6A7A0", Offset = "0x2B697A0", VA = "0x182B6A7A0", Slot = "329")]
	public override void OnEvent(ActorInteractEvent evnt)
	{
	}

	// Token: 0x06000347 RID: 839 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000347")]
	[Address(RVA = "0x2B6B2A0", Offset = "0x2B6A2A0", VA = "0x182B6B2A0", Slot = "313")]
	public override void OnEvent(CaveBoardBroken evnt)
	{
	}

	// Token: 0x06000348 RID: 840 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000348")]
	[Address(RVA = "0x2B6C380", Offset = "0x2B6B380", VA = "0x182B6C380", Slot = "210")]
	public override void OnEvent(SendMessageEvent evnt)
	{
	}

	// Token: 0x06000349 RID: 841 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000349")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "236")]
	public override void OnEvent(AddRepairMaterial evnt)
	{
	}

	// Token: 0x0600034A RID: 842 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600034A")]
	[Address(RVA = "0x2B6AE10", Offset = "0x2B69E10", VA = "0x182B6AE10", Slot = "327")]
	public override void OnEvent(ItemStorageAddItemEvent boltEvent)
	{
	}

	// Token: 0x0600034B RID: 843 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600034B")]
	[Address(RVA = "0x2B6B110", Offset = "0x2B6A110", VA = "0x182B6B110", Slot = "328")]
	public override void OnEvent(ItemStorageRemoveItemEvent boltEvent)
	{
	}

	// Token: 0x0600034C RID: 844 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600034C")]
	[Address(RVA = "0x2B6A1A0", Offset = "0x2B691A0", VA = "0x182B6A1A0", Slot = "341")]
	public override void OnEvent(Resin3dPrinterSetBusyEvent boltEvent)
	{
	}

	// Token: 0x0600034D RID: 845 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600034D")]
	[Address(RVA = "0x2B6A2C0", Offset = "0x2B692C0", VA = "0x182B6A2C0", Slot = "340")]
	public override void OnEvent(Resin3dPrinterSetRecipeIdEvent boltEvent)
	{
	}

	// Token: 0x0600034E RID: 846 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600034E")]
	[Address(RVA = "0x2B6BB20", Offset = "0x2B6AB20", VA = "0x182B6BB20", Slot = "343")]
	public override void OnEvent(Resin3dPrinterRefillEvent boltEvent)
	{
	}

	// Token: 0x0600034F RID: 847 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600034F")]
	[Address(RVA = "0x2B69B40", Offset = "0x2B68B40", VA = "0x182B69B40", Slot = "201")]
	public override void OnEvent(ChatEvent evnt)
	{
	}

	// Token: 0x06000350 RID: 848 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000350")]
	[Address(RVA = "0x2B68C50", Offset = "0x2B67C50", VA = "0x182B68C50", Slot = "32")]
	public override void EntityDetached(BoltEntity entity)
	{
	}

	// Token: 0x06000351 RID: 849 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000351")]
	[Address(RVA = "0x2B6C830", Offset = "0x2B6B830", VA = "0x182B6C830")]
	private void SendMasterClientEvent()
	{
	}

	// Token: 0x06000352 RID: 850 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000352")]
	[Address(RVA = "0x2B69140", Offset = "0x2B68140", VA = "0x182B69140", Slot = "33")]
	public override void EntityReceived(BoltEntity entity)
	{
	}

	// Token: 0x06000353 RID: 851 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000353")]
	[Address(RVA = "0x2B6C420", Offset = "0x2B6B420", VA = "0x182B6C420")]
	private static void RegisterPlayerConnection(BoltEntity entity)
	{
	}

	// Token: 0x06000354 RID: 852 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000354")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "263")]
	public override void OnEvent(Sleep evnt)
	{
	}

	// Token: 0x06000355 RID: 853 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000355")]
	[Address(RVA = "0x2B6BC40", Offset = "0x2B6AC40", VA = "0x182B6BC40", Slot = "285")]
	public override void OnEvent(PickupGlider evnt)
	{
	}

	// Token: 0x06000356 RID: 854 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000356")]
	[Address(RVA = "0x2B6D7F0", Offset = "0x2B6C7F0", VA = "0x182B6D7F0")]
	private IEnumerator forceHighDragOnSpawn(Rigidbody rb)
	{
		return null;
	}

	// Token: 0x06000357 RID: 855 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000357")]
	[Address(RVA = "0x2B69F80", Offset = "0x2B68F80", VA = "0x182B69F80", Slot = "278")]
	public override void OnEvent(loadEndGamePrefabs evnt)
	{
	}

	// Token: 0x06000358 RID: 856 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000358")]
	[Address(RVA = "0x2B6A900", Offset = "0x2B69900", VA = "0x182B6A900", Slot = "274")]
	public override void OnEvent(debugCommand evnt)
	{
	}

	// Token: 0x06000359 RID: 857 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000359")]
	[Address(RVA = "0x2B6D6E0", Offset = "0x2B6C6E0", VA = "0x182B6D6E0")]
	private void Update()
	{
	}

	// Token: 0x0600035A RID: 858 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600035A")]
	[Address(RVA = "0x2B6CC60", Offset = "0x2B6BC60", VA = "0x182B6CC60")]
	private void UpdateClientIds()
	{
	}

	// Token: 0x0600035B RID: 859 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600035B")]
	[Address(RVA = "0x2B6D410", Offset = "0x2B6C410", VA = "0x182B6D410")]
	private void UpdatePlayerRoles()
	{
	}

	// Token: 0x0600035C RID: 860 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600035C")]
	[Address(RVA = "0x2B68330", Offset = "0x2B67330", VA = "0x182B68330")]
	private void ClearPlayerRoles(int start, NetworkArray_Integer clientsArray)
	{
	}

	// Token: 0x0600035D RID: 861 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600035D")]
	[Address(RVA = "0x2B6CFB0", Offset = "0x2B6BFB0", VA = "0x182B6CFB0")]
	private void UpdatePlayerNames()
	{
	}

	// Token: 0x0600035E RID: 862 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600035E")]
	[Address(RVA = "0x2B69300", Offset = "0x2B68300", VA = "0x182B69300", Slot = "1")]
	protected override void Finalize()
	{
	}

	// Token: 0x0600035F RID: 863 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600035F")]
	[Address(RVA = "0x2B67E80", Offset = "0x2B66E80", VA = "0x182B67E80")]
	private void Awake()
	{
	}

	// Token: 0x06000360 RID: 864 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000360")]
	[Address(RVA = "0x2B69450", Offset = "0x2B68450", VA = "0x182B69450")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000361 RID: 865 RVA: 0x00003000 File Offset: 0x00001200
	[Token(Token = "0x6000361")]
	[Address(RVA = "0x2B693E0", Offset = "0x2B683E0", VA = "0x182B693E0")]
	public static bool HasInstance()
	{
		return default(bool);
	}

	// Token: 0x06000362 RID: 866 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000362")]
	[Address(RVA = "0x2B6B350", Offset = "0x2B6A350", VA = "0x182B6B350", Slot = "211")]
	public override void OnEvent(SpawnCutTree evnt)
	{
	}

	// Token: 0x06000363 RID: 867 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000363")]
	[Address(RVA = "0x2B6CEF0", Offset = "0x2B6BEF0", VA = "0x182B6CEF0")]
	private static void UpdateLocalStateToFellState(WorldLocatorId worldId)
	{
	}

	// Token: 0x06000364 RID: 868 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000364")]
	[Address(RVA = "0x2B68010", Offset = "0x2B67010", VA = "0x182B68010")]
	private void CleanOldTreeCutEvents()
	{
	}

	// Token: 0x06000365 RID: 869 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000365")]
	[Address(RVA = "0x2B6D770", Offset = "0x2B6C770", VA = "0x182B6D770")]
	public CoopServerCallbacks()
	{
	}

	// Token: 0x06000366 RID: 870 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000366")]
	[Address(RVA = "0x2B6CB70", Offset = "0x2B6BB70", VA = "0x182B6CB70")]
	[CompilerGenerated]
	internal static void <OnEvent>g__ReturnOriginalItem|23_0(ref CoopServerCallbacks.<>c__DisplayClass23_0 A_0)
	{
	}

	// Token: 0x040002F0 RID: 752
	[Token(Token = "0x40002F0")]
	[FieldOffset(Offset = "0x38")]
	private CachedGlobal<PlayerTracker> tracker;

	// Token: 0x040002F1 RID: 753
	[Token(Token = "0x40002F1")]
	[FieldOffset(Offset = "0x0")]
	private static CoopServerCallbacks _instance;

	// Token: 0x040002F2 RID: 754
	[Token(Token = "0x40002F2")]
	[FieldOffset(Offset = "0x48")]
	private Dictionary<WorldLocatorId, float> _handledTreeCutEvents;
}
