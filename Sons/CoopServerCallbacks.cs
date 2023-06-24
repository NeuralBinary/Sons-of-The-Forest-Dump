using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Bolt;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using Sons.TerrainDetail;
using UnityEngine;

// Token: 0x0200006B RID: 107
[Token(Token = "0x200006B")]
[BoltGlobalBehaviour(BoltNetworkModes.Host)]
public class CoopServerCallbacks : GlobalEventListener
{
	// Token: 0x0600032E RID: 814 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600032E")]
	[Address(RVA = "0x31C1230", Offset = "0x31BF830", VA = "0x1831C1230", Slot = "349")]
	public override void OnEvent(ZiplineCreateEvent boltEvent)
	{
	}

	// Token: 0x0600032F RID: 815 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600032F")]
	[Address(RVA = "0x31C1670", Offset = "0x31BFC70", VA = "0x1831C1670", Slot = "350")]
	public override void OnEvent(ZiplineRemoveEvent boltEvent)
	{
	}

	// Token: 0x06000330 RID: 816 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000330")]
	[Address(RVA = "0x31C1910", Offset = "0x31BFF10", VA = "0x1831C1910", Slot = "274")]
	public override void OnEvent(AdminCommand evnt)
	{
	}

	// Token: 0x06000331 RID: 817 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000331")]
	[Address(RVA = "0x31C1960", Offset = "0x31BFF60", VA = "0x1831C1960", Slot = "248")]
	public override void OnEvent(LocalizedHit evnt)
	{
	}

	// Token: 0x06000332 RID: 818 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000332")]
	[Address(RVA = "0x31C1AE0", Offset = "0x31C00E0", VA = "0x1831C1AE0", Slot = "348")]
	public override void OnEvent(ChangeIdObjectState boltEvent)
	{
	}

	// Token: 0x06000333 RID: 819 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000333")]
	[Address(RVA = "0x31C1CA0", Offset = "0x31C02A0", VA = "0x1831C1CA0", Slot = "341")]
	public override void OnEvent(AttachItemToZiplineEvent boltEvent)
	{
	}

	// Token: 0x06000334 RID: 820 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000334")]
	[Address(RVA = "0x31C1ED0", Offset = "0x31C04D0", VA = "0x1831C1ED0", Slot = "317")]
	public override void OnEvent(StorageContainerOpened boltEvent)
	{
	}

	// Token: 0x06000335 RID: 821 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000335")]
	[Address(RVA = "0x31C2010", Offset = "0x31C0610", VA = "0x1831C2010", Slot = "324")]
	public override void OnEvent(BreakableObjectBroken boltEvent)
	{
	}

	// Token: 0x06000336 RID: 822 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000336")]
	[Address(RVA = "0x31C2210", Offset = "0x31C0810", VA = "0x1831C2210", Slot = "353")]
	public override void OnEvent(DeathMarkerRequest boltEvent)
	{
	}

	// Token: 0x06000337 RID: 823 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000337")]
	[Address(RVA = "0x31C23A0", Offset = "0x31C09A0", VA = "0x1831C23A0", Slot = "380")]
	public override void OnEvent(RequestBannedPlayerList boltEvent)
	{
	}

	// Token: 0x06000338 RID: 824 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000338")]
	[Address(RVA = "0x31C2540", Offset = "0x31C0B40", VA = "0x1831C2540", Slot = "23")]
	public override void Connected(BoltConnection connection)
	{
	}

	// Token: 0x06000339 RID: 825 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000339")]
	[Address(RVA = "0x31C3410", Offset = "0x31C1A10", VA = "0x1831C3410", Slot = "28")]
	public override void Disconnected(BoltConnection connection)
	{
	}

	// Token: 0x0600033A RID: 826 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600033A")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "273")]
	public override void OnEvent(CutTriggerActivated evnt)
	{
	}

	// Token: 0x0600033B RID: 827 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600033B")]
	[Address(RVA = "0x31C3750", Offset = "0x31C1D50", VA = "0x1831C3750", Slot = "299")]
	public override void OnEvent(ValidSleepTime evnt)
	{
	}

	// Token: 0x0600033C RID: 828 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600033C")]
	[Address(RVA = "0x31C3780", Offset = "0x31C1D80", VA = "0x1831C3780", Slot = "216")]
	public override void OnEvent(DropItem boltEvent)
	{
	}

	// Token: 0x0600033D RID: 829 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600033D")]
	[Address(RVA = "0x31C4260", Offset = "0x31C2860", VA = "0x1831C4260", Slot = "246")]
	public override void OnEvent(SledGrab evnt)
	{
	}

	// Token: 0x0600033E RID: 830 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600033E")]
	[Address(RVA = "0x31C4430", Offset = "0x31C2A30", VA = "0x1831C4430", Slot = "247")]
	public override void OnEvent(SledRelease evnt)
	{
	}

	// Token: 0x0600033F RID: 831 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600033F")]
	[Address(RVA = "0x31C46E0", Offset = "0x31C2CE0", VA = "0x1831C46E0", Slot = "283")]
	public override void OnEvent(PlaceDryingFood evnt)
	{
	}

	// Token: 0x06000340 RID: 832 RVA: 0x00003090 File Offset: 0x00001290
	[Token(Token = "0x6000340")]
	[Address(RVA = "0x31C4850", Offset = "0x31C2E50", VA = "0x1831C4850")]
	private static bool TryGetVailActor(BoltEntity target, out VailActor actor, string debugName)
	{
		return default(bool);
	}

	// Token: 0x06000341 RID: 833 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000341")]
	[Address(RVA = "0x31C4AA0", Offset = "0x31C30A0", VA = "0x1831C4AA0", Slot = "311")]
	public override void OnEvent(VailHitEvent ev)
	{
	}

	// Token: 0x06000342 RID: 834 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000342")]
	[Address(RVA = "0x31C4B20", Offset = "0x31C3120", VA = "0x1831C4B20", Slot = "339")]
	public override void OnEvent(VailParriedEvent ev)
	{
	}

	// Token: 0x06000343 RID: 835 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000343")]
	[Address(RVA = "0x31C4BD0", Offset = "0x31C31D0", VA = "0x1831C4BD0", Slot = "352")]
	public override void OnEvent(VailReviveEvent ev)
	{
	}

	// Token: 0x06000344 RID: 836 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000344")]
	[Address(RVA = "0x31C4C50", Offset = "0x31C3250", VA = "0x1831C4C50", Slot = "325")]
	public override void OnEvent(DismemberHitEvent ev)
	{
	}

	// Token: 0x06000345 RID: 837 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000345")]
	[Address(RVA = "0x31C4DA0", Offset = "0x31C33A0", VA = "0x1831C4DA0", Slot = "222")]
	public override void OnEvent(SkinnedAnimal ev)
	{
	}

	// Token: 0x06000346 RID: 838 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000346")]
	[Address(RVA = "0x31C4E20", Offset = "0x31C3420", VA = "0x1831C4E20", Slot = "363")]
	public override void OnEvent(PlayerRequestActorItem ev)
	{
	}

	// Token: 0x06000347 RID: 839 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000347")]
	[Address(RVA = "0x31C5330", Offset = "0x31C3930", VA = "0x1831C5330", Slot = "344")]
	public override void OnEvent(PlayerGiveActorItem boltEvent)
	{
	}

	// Token: 0x06000348 RID: 840 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000348")]
	[Address(RVA = "0x31C5920", Offset = "0x31C3F20", VA = "0x1831C5920", Slot = "312")]
	public override void OnEvent(VailNoiseEvent ev)
	{
	}

	// Token: 0x06000349 RID: 841 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000349")]
	[Address(RVA = "0x31C5A60", Offset = "0x31C4060", VA = "0x1831C5A60", Slot = "315")]
	public override void OnEvent(RobbyOrderEvent evnt)
	{
	}

	// Token: 0x0600034A RID: 842 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600034A")]
	[Address(RVA = "0x31C5B10", Offset = "0x31C4110", VA = "0x1831C5B10", Slot = "329")]
	public override void OnEvent(RadioActivate evnt)
	{
	}

	// Token: 0x0600034B RID: 843 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600034B")]
	[Address(RVA = "0x31C5C50", Offset = "0x31C4250", VA = "0x1831C5C50", Slot = "347")]
	public override void OnEvent(ActorInteractEvent evnt)
	{
	}

	// Token: 0x0600034C RID: 844 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600034C")]
	[Address(RVA = "0x31C5EA0", Offset = "0x31C44A0", VA = "0x1831C5EA0", Slot = "331")]
	public override void OnEvent(CaveBoardBroken evnt)
	{
	}

	// Token: 0x0600034D RID: 845 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600034D")]
	[Address(RVA = "0x31C62B0", Offset = "0x31C48B0", VA = "0x1831C62B0", Slot = "383")]
	public override void OnEvent(BossCutsceneEvent evnt)
	{
	}

	// Token: 0x0600034E RID: 846 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600034E")]
	[Address(RVA = "0x31C6310", Offset = "0x31C4910", VA = "0x1831C6310", Slot = "345")]
	public override void OnEvent(ItemStorageAddItemEvent boltEvent)
	{
	}

	// Token: 0x0600034F RID: 847 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600034F")]
	[Address(RVA = "0x31C6560", Offset = "0x31C4B60", VA = "0x1831C6560", Slot = "346")]
	public override void OnEvent(ItemStorageRemoveItemEvent boltEvent)
	{
	}

	// Token: 0x06000350 RID: 848 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000350")]
	[Address(RVA = "0x31C67B0", Offset = "0x31C4DB0", VA = "0x1831C67B0", Slot = "359")]
	public override void OnEvent(Resin3dPrinterSetBusyEvent boltEvent)
	{
	}

	// Token: 0x06000351 RID: 849 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000351")]
	[Address(RVA = "0x31C69A0", Offset = "0x31C4FA0", VA = "0x1831C69A0", Slot = "358")]
	public override void OnEvent(Resin3dPrinterSetRecipeIdEvent boltEvent)
	{
	}

	// Token: 0x06000352 RID: 850 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000352")]
	[Address(RVA = "0x31C6BA0", Offset = "0x31C51A0", VA = "0x1831C6BA0", Slot = "361")]
	public override void OnEvent(Resin3dPrinterRefillEvent boltEvent)
	{
	}

	// Token: 0x06000353 RID: 851 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000353")]
	[Address(RVA = "0x31C6DA0", Offset = "0x31C53A0", VA = "0x1831C6DA0", Slot = "219")]
	public override void OnEvent(ChatEvent evnt)
	{
	}

	// Token: 0x06000354 RID: 852 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000354")]
	[Address(RVA = "0x31C7000", Offset = "0x31C5600", VA = "0x1831C7000", Slot = "32")]
	public override void EntityDetached(BoltEntity entity)
	{
	}

	// Token: 0x06000355 RID: 853 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000355")]
	[Address(RVA = "0x31C7590", Offset = "0x31C5B90", VA = "0x1831C7590")]
	private void SendMasterClientEvent()
	{
	}

	// Token: 0x06000356 RID: 854 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000356")]
	[Address(RVA = "0x31C7840", Offset = "0x31C5E40", VA = "0x1831C7840", Slot = "33")]
	public override void EntityReceived(BoltEntity entity)
	{
	}

	// Token: 0x06000357 RID: 855 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000357")]
	[Address(RVA = "0x31C7A70", Offset = "0x31C6070", VA = "0x1831C7A70")]
	private static void RegisterPlayerConnection(BoltEntity entity)
	{
	}

	// Token: 0x06000358 RID: 856 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000358")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "281")]
	public override void OnEvent(Sleep evnt)
	{
	}

	// Token: 0x06000359 RID: 857 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000359")]
	[Address(RVA = "0x31C8060", Offset = "0x31C6660", VA = "0x1831C8060", Slot = "303")]
	public override void OnEvent(PickupGlider evnt)
	{
	}

	// Token: 0x0600035A RID: 858 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600035A")]
	[Address(RVA = "0x31C8550", Offset = "0x31C6B50", VA = "0x1831C8550")]
	private IEnumerator forceHighDragOnSpawn(Rigidbody rb)
	{
		return null;
	}

	// Token: 0x0600035B RID: 859 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600035B")]
	[Address(RVA = "0x31C85E0", Offset = "0x31C6BE0", VA = "0x1831C85E0", Slot = "296")]
	public override void OnEvent(loadEndGamePrefabs evnt)
	{
	}

	// Token: 0x0600035C RID: 860 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600035C")]
	[Address(RVA = "0x31C8740", Offset = "0x31C6D40", VA = "0x1831C8740", Slot = "292")]
	public override void OnEvent(debugCommand evnt)
	{
	}

	// Token: 0x0600035D RID: 861 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600035D")]
	[Address(RVA = "0x31C8A80", Offset = "0x31C7080", VA = "0x1831C8A80")]
	private void Update()
	{
	}

	// Token: 0x0600035E RID: 862 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600035E")]
	[Address(RVA = "0x31C8CE0", Offset = "0x31C72E0", VA = "0x1831C8CE0")]
	private void UpdateClientIds()
	{
	}

	// Token: 0x0600035F RID: 863 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600035F")]
	[Address(RVA = "0x31C93C0", Offset = "0x31C79C0", VA = "0x1831C93C0")]
	private void UpdatePlayerRoles()
	{
	}

	// Token: 0x06000360 RID: 864 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000360")]
	[Address(RVA = "0x31C9670", Offset = "0x31C7C70", VA = "0x1831C9670")]
	private void ClearPlayerRoles(int start, NetworkArray_Integer clientsArray)
	{
	}

	// Token: 0x06000361 RID: 865 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000361")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	private void UpdatePlayerNames_DEPRECATED()
	{
	}

	// Token: 0x06000362 RID: 866 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000362")]
	[Address(RVA = "0x31C9770", Offset = "0x31C7D70", VA = "0x1831C9770", Slot = "1")]
	protected override void Finalize()
	{
	}

	// Token: 0x06000363 RID: 867 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000363")]
	[Address(RVA = "0x31C97E0", Offset = "0x31C7DE0", VA = "0x1831C97E0")]
	private void Awake()
	{
	}

	// Token: 0x06000364 RID: 868 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000364")]
	[Address(RVA = "0x31C9AB0", Offset = "0x31C80B0", VA = "0x1831C9AB0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000365 RID: 869 RVA: 0x000030A8 File Offset: 0x000012A8
	[Token(Token = "0x6000365")]
	[Address(RVA = "0x31C9C40", Offset = "0x31C8240", VA = "0x1831C9C40")]
	public static bool HasInstance()
	{
		return default(bool);
	}

	// Token: 0x06000366 RID: 870 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000366")]
	[Address(RVA = "0x31C9D20", Offset = "0x31C8320", VA = "0x1831C9D20", Slot = "229")]
	public override void OnEvent(SpawnCutTree evnt)
	{
	}

	// Token: 0x06000367 RID: 871 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000367")]
	[Address(RVA = "0x31CA4F0", Offset = "0x31C8AF0", VA = "0x1831CA4F0")]
	private static void UpdateLocalStateToFellState(WorldLocatorId worldId)
	{
	}

	// Token: 0x06000368 RID: 872 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000368")]
	[Address(RVA = "0x31CA5B0", Offset = "0x31C8BB0", VA = "0x1831CA5B0")]
	private void CleanOldTreeCutEvents()
	{
	}

	// Token: 0x06000369 RID: 873 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000369")]
	[Address(RVA = "0x31CA980", Offset = "0x31C8F80", VA = "0x1831CA980")]
	public CoopServerCallbacks()
	{
	}

	// Token: 0x0600036A RID: 874 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600036A")]
	[Address(RVA = "0x31CAB50", Offset = "0x31C9150", VA = "0x1831CAB50")]
	[CompilerGenerated]
	internal static void <OnEvent>g__ReturnOriginalItem|25_0(ref CoopServerCallbacks.<>c__DisplayClass25_0 A_0)
	{
	}

	// Token: 0x0600036B RID: 875 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600036B")]
	[Address(RVA = "0x31CAC80", Offset = "0x31C9280", VA = "0x1831CAC80")]
	[CompilerGenerated]
	private void <UpdateClientIds>g__SetSteamId|51_0(int i, ulong id, ref CoopServerCallbacks.<>c__DisplayClass51_0 A_3)
	{
	}

	// Token: 0x0600036C RID: 876 RVA: 0x000030C0 File Offset: 0x000012C0
	[Token(Token = "0x600036C")]
	[Address(RVA = "0x31CAD70", Offset = "0x31C9370", VA = "0x1831CAD70")]
	[CompilerGenerated]
	private int <UpdateClientIds>g__FindFirstAvailableColorIndex|51_1(ref CoopServerCallbacks.<>c__DisplayClass51_0 A_1)
	{
		return 0;
	}

	// Token: 0x040002F2 RID: 754
	[Token(Token = "0x40002F2")]
	[FieldOffset(Offset = "0x38")]
	private CachedGlobal<PlayerTracker> tracker;

	// Token: 0x040002F3 RID: 755
	[Token(Token = "0x40002F3")]
	[FieldOffset(Offset = "0x48")]
	private Dictionary<int, int> _clientToColorMap;

	// Token: 0x040002F4 RID: 756
	[Token(Token = "0x40002F4")]
	[FieldOffset(Offset = "0x50")]
	private HashSet<int> _usedColors;

	// Token: 0x040002F5 RID: 757
	[Token(Token = "0x40002F5")]
	[FieldOffset(Offset = "0x0")]
	private static CoopServerCallbacks _instance;

	// Token: 0x040002F6 RID: 758
	[Token(Token = "0x40002F6")]
	[FieldOffset(Offset = "0x58")]
	private Dictionary<WorldLocatorId, float> _handledTreeCutEvents;
}
