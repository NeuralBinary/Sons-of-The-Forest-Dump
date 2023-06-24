using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Bolt;
using Il2CppDummyDll;
using Sons.Multiplayer;
using UnityEngine;

// Token: 0x02000062 RID: 98
[Token(Token = "0x2000062")]
[BoltGlobalBehaviour(BoltNetworkModes.Client)]
[AddComponentMenu("Sons/Multiplayer/CoopClientCallbacks")]
public class CoopClientCallbacks : GlobalEventListener
{
	// Token: 0x14000001 RID: 1
	// (add) Token: 0x060002B2 RID: 690 RVA: 0x00002053 File Offset: 0x00000253
	// (remove) Token: 0x060002B3 RID: 691 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x14000001")]
	private static event Action<DeathMarkerRequest> _deathMarkerServerCallbackEvents
	{
		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x31B6370", Offset = "0x31B4970", VA = "0x1831B6370")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x31B6500", Offset = "0x31B4B00", VA = "0x1831B6500")]
		[CompilerGenerated]
		remove
		{
		}
	}

	// Token: 0x060002B4 RID: 692 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002B4")]
	[Address(RVA = "0x31B6690", Offset = "0x31B4C90", VA = "0x1831B6690")]
	private void Start()
	{
	}

	// Token: 0x060002B5 RID: 693 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002B5")]
	[Address(RVA = "0x31B66E0", Offset = "0x31B4CE0", VA = "0x1831B66E0")]
	private IEnumerator ServerResponseTest()
	{
		return null;
	}

	// Token: 0x060002B6 RID: 694 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002B6")]
	[Address(RVA = "0x31B6720", Offset = "0x31B4D20", VA = "0x1831B6720", Slot = "23")]
	public override void Connected(BoltConnection connection)
	{
	}

	// Token: 0x060002B7 RID: 695 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002B7")]
	[Address(RVA = "0x31B67F0", Offset = "0x31B4DF0", VA = "0x1831B67F0", Slot = "28")]
	public override void Disconnected(BoltConnection connection)
	{
	}

	// Token: 0x060002B8 RID: 696 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002B8")]
	[Address(RVA = "0x31B6BB0", Offset = "0x31B51B0", VA = "0x1831B6BB0")]
	private void HandleServerShutdown(ServerShutdownToken serverShutdownToken)
	{
	}

	// Token: 0x060002B9 RID: 697 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002B9")]
	[Address(RVA = "0x31B6CE0", Offset = "0x31B52E0", VA = "0x1831B6CE0")]
	public void FinalizeDisconnect()
	{
	}

	// Token: 0x060002BA RID: 698 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002BA")]
	[Address(RVA = "0x31B6DB0", Offset = "0x31B53B0", VA = "0x1831B6DB0")]
	private void HandleOtherDisconnect(BoltConnection connection)
	{
	}

	// Token: 0x060002BB RID: 699 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002BB")]
	[Address(RVA = "0x31B6EA0", Offset = "0x31B54A0", VA = "0x1831B6EA0")]
	private void HandleDsJoinFailed()
	{
	}

	// Token: 0x060002BC RID: 700 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002BC")]
	[Address(RVA = "0x31B7220", Offset = "0x31B5820", VA = "0x1831B7220")]
	private void HandleKickDisconnect(CoopKickToken token)
	{
	}

	// Token: 0x060002BD RID: 701 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002BD")]
	[Address(RVA = "0x31B7770", Offset = "0x31B5D70", VA = "0x1831B7770")]
	private static void ReturnToTitle()
	{
	}

	// Token: 0x060002BE RID: 702 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002BE")]
	[Address(RVA = "0x31B7880", Offset = "0x31B5E80", VA = "0x1831B7880", Slot = "295")]
	public override void OnEvent(ServerStatusInfo evnt)
	{
	}

	// Token: 0x060002BF RID: 703 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002BF")]
	[Address(RVA = "0x31B7A70", Offset = "0x31B6070", VA = "0x1831B7A70", Slot = "353")]
	public override void OnEvent(DeathMarkerRequest evnt)
	{
	}

	// Token: 0x060002C0 RID: 704 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002C0")]
	[Address(RVA = "0x31B7AD0", Offset = "0x31B60D0", VA = "0x1831B7AD0", Slot = "294")]
	public override void OnEvent(SetMasterClient evnt)
	{
	}

	// Token: 0x060002C1 RID: 705 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002C1")]
	[Address(RVA = "0x31B7C50", Offset = "0x31B6250", VA = "0x1831B7C50", Slot = "318")]
	public override void OnEvent(PlayerConnectivityAction boltEvent)
	{
	}

	// Token: 0x060002C2 RID: 706 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002C2")]
	[Address(RVA = "0x31B7E90", Offset = "0x31B6490", VA = "0x1831B7E90", Slot = "381")]
	public override void OnEvent(ItemStorageIsBusy boltEvent)
	{
	}

	// Token: 0x060002C3 RID: 707 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002C3")]
	[Address(RVA = "0x31B80B0", Offset = "0x31B66B0", VA = "0x1831B80B0", Slot = "258")]
	public override void OnEvent(GardenPlotPlantSeed boltEvent)
	{
	}

	// Token: 0x060002C4 RID: 708 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002C4")]
	[Address(RVA = "0x31B82A0", Offset = "0x31B68A0", VA = "0x1831B82A0", Slot = "338")]
	public override void OnEvent(GardenPlotIsBusy boltEvent)
	{
	}

	// Token: 0x060002C5 RID: 709 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002C5")]
	[Address(RVA = "0x31B84D0", Offset = "0x31B6AD0", VA = "0x1831B84D0", Slot = "354")]
	public override void OnEvent(GardenPlotClearPlot boltEvent)
	{
	}

	// Token: 0x060002C6 RID: 710 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002C6")]
	[Address(RVA = "0x31B86C0", Offset = "0x31B6CC0", VA = "0x1831B86C0", Slot = "370")]
	public override void OnEvent(RainCatcherRemoveWater boltEvent)
	{
	}

	// Token: 0x060002C7 RID: 711 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002C7")]
	[Address(RVA = "0x31B88F0", Offset = "0x31B6EF0", VA = "0x1831B88F0", Slot = "369")]
	public override void OnEvent(RainCatcherIsBusy boltEvent)
	{
	}

	// Token: 0x060002C8 RID: 712 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002C8")]
	[Address(RVA = "0x31B8B20", Offset = "0x31B7120", VA = "0x1831B8B20", Slot = "356")]
	public override void OnEvent(TrapActivateEvent boltEvent)
	{
	}

	// Token: 0x060002C9 RID: 713 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002C9")]
	[Address(RVA = "0x31B8D10", Offset = "0x31B7310", VA = "0x1831B8D10", Slot = "238")]
	public override void OnEvent(TrapResetEvent boltEvent)
	{
	}

	// Token: 0x060002CA RID: 714 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002CA")]
	[Address(RVA = "0x31B8FA0", Offset = "0x31B75A0", VA = "0x1831B8FA0", Slot = "357")]
	public override void OnEvent(Resin3dPrinterStartPrintEvent boltEvent)
	{
	}

	// Token: 0x060002CB RID: 715 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002CB")]
	[Address(RVA = "0x31B9180", Offset = "0x31B7780", VA = "0x1831B9180", Slot = "360")]
	public override void OnEvent(Resin3dPrinterItemRemovedEvent boltEvent)
	{
	}

	// Token: 0x060002CC RID: 716 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002CC")]
	[Address(RVA = "0x31B9480", Offset = "0x31B7A80", VA = "0x1831B9480", Slot = "276")]
	public override void OnEvent(ragdollActivate evnt)
	{
	}

	// Token: 0x060002CD RID: 717 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002CD")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "273")]
	public override void OnEvent(CutTriggerActivated evnt)
	{
	}

	// Token: 0x060002CE RID: 718 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002CE")]
	[Address(RVA = "0x31B9590", Offset = "0x31B7B90", VA = "0x1831B9590", Slot = "299")]
	public override void OnEvent(ValidSleepTime evnt)
	{
	}

	// Token: 0x060002CF RID: 719 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002CF")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "298")]
	public override void OnEvent(TriggerFishTrap evnt)
	{
	}

	// Token: 0x060002D0 RID: 720 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002D0")]
	[Address(RVA = "0x31B95E0", Offset = "0x31B7BE0", VA = "0x1831B95E0", Slot = "313")]
	public override void OnEvent(PlayerFireWeaponEvent ev)
	{
	}

	// Token: 0x060002D1 RID: 721 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002D1")]
	[Address(RVA = "0x31B9750", Offset = "0x31B7D50", VA = "0x1831B9750", Slot = "284")]
	public override void OnEvent(RequestMecanimSync evnt)
	{
	}

	// Token: 0x060002D2 RID: 722 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002D2")]
	[Address(RVA = "0x31B9920", Offset = "0x31B7F20", VA = "0x1831B9920", Slot = "379")]
	public override void OnEvent(SetPlayerSpawnPoint evnt)
	{
	}

	// Token: 0x060002D3 RID: 723 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002D3")]
	[Address(RVA = "0x31B9970", Offset = "0x31B7F70", VA = "0x1831B9970", Slot = "285")]
	public override void OnEvent(updateMecanimRemoteState evnt)
	{
	}

	// Token: 0x060002D4 RID: 724 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002D4")]
	[Address(RVA = "0x31B9C90", Offset = "0x31B8290", VA = "0x1831B9C90", Slot = "315")]
	public override void OnEvent(RobbyOrderEvent evnt)
	{
	}

	// Token: 0x060002D5 RID: 725 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002D5")]
	[Address(RVA = "0x31B9DA0", Offset = "0x31B83A0", VA = "0x1831B9DA0", Slot = "330")]
	public override void OnEvent(HitEngineEvent evnt)
	{
	}

	// Token: 0x060002D6 RID: 726 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002D6")]
	[Address(RVA = "0x31B9F40", Offset = "0x31B8540", VA = "0x1831B9F40", Slot = "256")]
	public override void OnEvent(Burn evnt)
	{
	}

	// Token: 0x060002D7 RID: 727 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002D7")]
	[Address(RVA = "0x31BA270", Offset = "0x31B8870", VA = "0x1831BA270", Slot = "217")]
	public override void OnEvent(SpawnImpactEffect evnt)
	{
	}

	// Token: 0x060002D8 RID: 728 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002D8")]
	[Address(RVA = "0x31BA280", Offset = "0x31B8880", VA = "0x1831BA280", Slot = "332")]
	public override void OnEvent(VailZoneStateEvent evnt)
	{
	}

	// Token: 0x060002D9 RID: 729 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002D9")]
	[Address(RVA = "0x31BA300", Offset = "0x31B8900", VA = "0x1831BA300", Slot = "335")]
	public override void OnEvent(ActivateVailActor evnt)
	{
	}

	// Token: 0x060002DA RID: 730 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002DA")]
	[Address(RVA = "0x31BA510", Offset = "0x31B8B10", VA = "0x1831BA510", Slot = "336")]
	public override void OnEvent(VailThrowBodyEvent evnt)
	{
	}

	// Token: 0x060002DB RID: 731 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002DB")]
	[Address(RVA = "0x31BA5C0", Offset = "0x31B8BC0", VA = "0x1831BA5C0", Slot = "371")]
	public override void OnEvent(VailRagdollEvent evnt)
	{
	}

	// Token: 0x060002DC RID: 732 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002DC")]
	[Address(RVA = "0x31BA650", Offset = "0x31B8C50", VA = "0x1831BA650", Slot = "374")]
	public override void OnEvent(VailAttachItemEvent evnt)
	{
	}

	// Token: 0x060002DD RID: 733 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002DD")]
	[Address(RVA = "0x31BA710", Offset = "0x31B8D10", VA = "0x1831BA710", Slot = "326")]
	public override void OnEvent(PickupBodyEvent evnt)
	{
	}

	// Token: 0x060002DE RID: 734 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002DE")]
	[Address(RVA = "0x31BA7C0", Offset = "0x31B8DC0", VA = "0x1831BA7C0", Slot = "229")]
	public override void OnEvent(SpawnCutTree evnt)
	{
	}

	// Token: 0x060002DF RID: 735 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002DF")]
	[Address(RVA = "0x31BA820", Offset = "0x31B8E20", VA = "0x1831BA820", Slot = "280")]
	public override void OnEvent(DropBodyEvent evnt)
	{
	}

	// Token: 0x060002E0 RID: 736 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002E0")]
	[Address(RVA = "0x31BA8D0", Offset = "0x31B8ED0", VA = "0x1831BA8D0", Slot = "328")]
	public override void OnEvent(SpawnLootItemEvent evnt)
	{
	}

	// Token: 0x060002E1 RID: 737 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002E1")]
	[Address(RVA = "0x31BA8E0", Offset = "0x31B8EE0", VA = "0x1831BA8E0", Slot = "343")]
	public override void OnEvent(TerrainDigNodeAdded boltEvent)
	{
	}

	// Token: 0x060002E2 RID: 738 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002E2")]
	[Address(RVA = "0x31BA9F0", Offset = "0x31B8FF0", VA = "0x1831BA9F0", Slot = "364")]
	public override void OnEvent(StructureCraftingNodeAddIngredientRejected boltEvent)
	{
	}

	// Token: 0x060002E3 RID: 739 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002E3")]
	[Address(RVA = "0x31BAAE0", Offset = "0x31B90E0", VA = "0x1831BAAE0", Slot = "320")]
	public override void OnEvent(StructureCraftingNodeAddIngredient boltEvent)
	{
	}

	// Token: 0x060002E4 RID: 740 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002E4")]
	[Address(RVA = "0x31BACD0", Offset = "0x31B92D0", VA = "0x1831BACD0", Slot = "319")]
	public override void OnEvent(StructureCraftingNodeCancel boltEvent)
	{
	}

	// Token: 0x060002E5 RID: 741 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002E5")]
	[Address(RVA = "0x31BAE50", Offset = "0x31B9450", VA = "0x1831BAE50", Slot = "321")]
	public override void OnEvent(StructureCraftingNodeComplete boltEvent)
	{
	}

	// Token: 0x060002E6 RID: 742 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002E6")]
	[Address(RVA = "0x31BAFE0", Offset = "0x31B95E0", VA = "0x1831BAFE0", Slot = "1")]
	protected override void Finalize()
	{
	}

	// Token: 0x060002E7 RID: 743 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002E7")]
	[Address(RVA = "0x31BB100", Offset = "0x31B9700", VA = "0x1831BB100")]
	public static void UnregisterDeathMarkerServerCallbackEvent(Action<DeathMarkerRequest> eventResponse)
	{
	}

	// Token: 0x060002E8 RID: 744 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002E8")]
	[Address(RVA = "0x31BB110", Offset = "0x31B9710", VA = "0x1831BB110")]
	public static void RegisterDeathMarkerServerCallbackEvent(Action<DeathMarkerRequest> eventResponse)
	{
	}

	// Token: 0x060002E9 RID: 745 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002E9")]
	[Address(RVA = "0x144EB80", Offset = "0x144D180", VA = "0x18144EB80")]
	public CoopClientCallbacks()
	{
	}

	// Token: 0x040002AD RID: 685
	[Token(Token = "0x40002AD")]
	[FieldOffset(Offset = "0x0")]
	private static bool invokedServerNotResponding;

	// Token: 0x040002AE RID: 686
	[Token(Token = "0x40002AE")]
	private const string MultiplayerTableReferenceKey = "Multiplayer";

	// Token: 0x040002AF RID: 687
	[Token(Token = "0x40002AF")]
	[FieldOffset(Offset = "0x8")]
	public static Action OnDisconnected;

	// Token: 0x040002B0 RID: 688
	[Token(Token = "0x40002B0")]
	[FieldOffset(Offset = "0x10")]
	public static Action<string> OnServerShutdown;

	// Token: 0x040002B1 RID: 689
	[Token(Token = "0x40002B1")]
	[FieldOffset(Offset = "0x18")]
	public static Action ServerNotResponding;

	// Token: 0x040002B2 RID: 690
	[Token(Token = "0x40002B2")]
	[FieldOffset(Offset = "0x20")]
	public static Action ServerIsResponding;
}
