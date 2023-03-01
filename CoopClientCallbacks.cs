using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Bolt;
using Il2CppDummyDll;
using Sons.Multiplayer;
using UnityEngine;

// Token: 0x02000065 RID: 101
[Token(Token = "0x2000065")]
[AddComponentMenu("Sons/Multiplayer/CoopClientCallbacks")]
[BoltGlobalBehaviour(2)]
public class CoopClientCallbacks : GlobalEventListener
{
	// Token: 0x14000001 RID: 1
	// (add) Token: 0x060002B4 RID: 692 RVA: 0x00002053 File Offset: 0x00000253
	// (remove) Token: 0x060002B5 RID: 693 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x14000001")]
	private static event Action<DeathMarkerRequest> _deathMarkerServerCallbackEvents
	{
		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x2B63470", Offset = "0x2B62470", VA = "0x182B63470")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x2B63390", Offset = "0x2B62390", VA = "0x182B63390")]
		[CompilerGenerated]
		remove
		{
		}
	}

	// Token: 0x060002B6 RID: 694 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002B6")]
	[Address(RVA = "0x2B63320", Offset = "0x2B62320", VA = "0x182B63320")]
	private void Start()
	{
	}

	// Token: 0x060002B7 RID: 695 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002B7")]
	[Address(RVA = "0x2B632D0", Offset = "0x2B622D0", VA = "0x182B632D0")]
	private IEnumerator ServerResponseTest()
	{
		return null;
	}

	// Token: 0x060002B8 RID: 696 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002B8")]
	[Address(RVA = "0x2B603E0", Offset = "0x2B5F3E0", VA = "0x182B603E0", Slot = "23")]
	public override void Connected(BoltConnection connection)
	{
	}

	// Token: 0x060002B9 RID: 697 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002B9")]
	[Address(RVA = "0x2B60470", Offset = "0x2B5F470", VA = "0x182B60470", Slot = "28")]
	public override void Disconnected(BoltConnection connection)
	{
	}

	// Token: 0x060002BA RID: 698 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002BA")]
	[Address(RVA = "0x2B61380", Offset = "0x2B60380", VA = "0x182B61380")]
	private void HandleServerShutdown(ServerShutdownToken serverShutdownToken)
	{
	}

	// Token: 0x060002BB RID: 699 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002BB")]
	[Address(RVA = "0x2B60A20", Offset = "0x2B5FA20", VA = "0x182B60A20")]
	public void FinalizeDisconnect()
	{
	}

	// Token: 0x060002BC RID: 700 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002BC")]
	[Address(RVA = "0x2B610E0", Offset = "0x2B600E0", VA = "0x182B610E0")]
	private void HandleOtherDisconnect(BoltConnection connection)
	{
	}

	// Token: 0x060002BD RID: 701 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002BD")]
	[Address(RVA = "0x2B60BB0", Offset = "0x2B5FBB0", VA = "0x182B60BB0")]
	private void HandleDsJoinFailed()
	{
	}

	// Token: 0x060002BE RID: 702 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002BE")]
	[Address(RVA = "0x2B60D80", Offset = "0x2B5FD80", VA = "0x182B60D80")]
	private void HandleKickDisconnect(CoopKickToken token)
	{
	}

	// Token: 0x060002BF RID: 703 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002BF")]
	[Address(RVA = "0x2B63240", Offset = "0x2B62240", VA = "0x182B63240")]
	private static void ReturnToTitle()
	{
	}

	// Token: 0x060002C0 RID: 704 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002C0")]
	[Address(RVA = "0x2B62810", Offset = "0x2B61810", VA = "0x182B62810", Slot = "277")]
	public override void OnEvent(ServerStatusInfo evnt)
	{
	}

	// Token: 0x060002C1 RID: 705 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002C1")]
	[Address(RVA = "0x2B62350", Offset = "0x2B61350", VA = "0x182B62350", Slot = "335")]
	public override void OnEvent(DeathMarkerRequest evnt)
	{
	}

	// Token: 0x060002C2 RID: 706 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002C2")]
	[Address(RVA = "0x2B618B0", Offset = "0x2B608B0", VA = "0x182B618B0", Slot = "276")]
	public override void OnEvent(SetMasterClient evnt)
	{
	}

	// Token: 0x060002C3 RID: 707 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002C3")]
	[Address(RVA = "0x2B61EF0", Offset = "0x2B60EF0", VA = "0x182B61EF0", Slot = "300")]
	public override void OnEvent(PlayerConnectivityAction boltEvent)
	{
	}

	// Token: 0x060002C4 RID: 708 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002C4")]
	[Address(RVA = "0x2B615D0", Offset = "0x2B605D0", VA = "0x182B615D0", Slot = "240")]
	public override void OnEvent(GardenPlotPlantSeed boltEvent)
	{
	}

	// Token: 0x060002C5 RID: 709 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002C5")]
	[Address(RVA = "0x2B61990", Offset = "0x2B60990", VA = "0x182B61990", Slot = "320")]
	public override void OnEvent(GardenPlotIsBusy boltEvent)
	{
	}

	// Token: 0x060002C6 RID: 710 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002C6")]
	[Address(RVA = "0x2B626F0", Offset = "0x2B616F0", VA = "0x182B626F0", Slot = "336")]
	public override void OnEvent(GardenPlotClearPlot boltEvent)
	{
	}

	// Token: 0x060002C7 RID: 711 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002C7")]
	[Address(RVA = "0x2B62B40", Offset = "0x2B61B40", VA = "0x182B62B40", Slot = "338")]
	public override void OnEvent(TrapActivateEvent boltEvent)
	{
	}

	// Token: 0x060002C8 RID: 712 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002C8")]
	[Address(RVA = "0x2B62E00", Offset = "0x2B61E00", VA = "0x182B62E00", Slot = "220")]
	public override void OnEvent(TrapResetEvent boltEvent)
	{
	}

	// Token: 0x060002C9 RID: 713 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002C9")]
	[Address(RVA = "0x2B617A0", Offset = "0x2B607A0", VA = "0x182B617A0", Slot = "339")]
	public override void OnEvent(Resin3dPrinterStartPrintEvent boltEvent)
	{
	}

	// Token: 0x060002CA RID: 714 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002CA")]
	[Address(RVA = "0x2B62060", Offset = "0x2B61060", VA = "0x182B62060", Slot = "342")]
	public override void OnEvent(Resin3dPrinterItemRemovedEvent boltEvent)
	{
	}

	// Token: 0x060002CB RID: 715 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002CB")]
	[Address(RVA = "0x2B61520", Offset = "0x2B60520", VA = "0x182B61520", Slot = "258")]
	public override void OnEvent(ragdollActivate evnt)
	{
	}

	// Token: 0x060002CC RID: 716 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002CC")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "255")]
	public override void OnEvent(CutTriggerActivated evnt)
	{
	}

	// Token: 0x060002CD RID: 717 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002CD")]
	[Address(RVA = "0x2B62510", Offset = "0x2B61510", VA = "0x182B62510", Slot = "281")]
	public override void OnEvent(ValidSleepTime evnt)
	{
	}

	// Token: 0x060002CE RID: 718 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002CE")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "280")]
	public override void OnEvent(TriggerFishTrap evnt)
	{
	}

	// Token: 0x060002CF RID: 719 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002CF")]
	[Address(RVA = "0x2B623B0", Offset = "0x2B613B0", VA = "0x182B623B0", Slot = "295")]
	public override void OnEvent(PlayerFireWeaponEvent ev)
	{
	}

	// Token: 0x060002D0 RID: 720 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002D0")]
	[Address(RVA = "0x2B62180", Offset = "0x2B61180", VA = "0x182B62180", Slot = "266")]
	public override void OnEvent(RequestMecanimSync evnt)
	{
	}

	// Token: 0x060002D1 RID: 721 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002D1")]
	[Address(RVA = "0x2B61CB0", Offset = "0x2B60CB0", VA = "0x182B61CB0", Slot = "267")]
	public override void OnEvent(updateMecanimRemoteState evnt)
	{
	}

	// Token: 0x060002D2 RID: 722 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002D2")]
	[Address(RVA = "0x2B62A60", Offset = "0x2B61A60", VA = "0x182B62A60", Slot = "297")]
	public override void OnEvent(RobbyOrderEvent evnt)
	{
	}

	// Token: 0x060002D3 RID: 723 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002D3")]
	[Address(RVA = "0x2B61BF0", Offset = "0x2B60BF0", VA = "0x182B61BF0", Slot = "312")]
	public override void OnEvent(HitEngineEvent evnt)
	{
	}

	// Token: 0x060002D4 RID: 724 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002D4")]
	[Address(RVA = "0x2B62F10", Offset = "0x2B61F10", VA = "0x182B62F10", Slot = "238")]
	public override void OnEvent(Burn evnt)
	{
	}

	// Token: 0x060002D5 RID: 725 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002D5")]
	[Address(RVA = "0x2B61CA0", Offset = "0x2B60CA0", VA = "0x182B61CA0", Slot = "199")]
	public override void OnEvent(SpawnImpactEffect evnt)
	{
	}

	// Token: 0x060002D6 RID: 726 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002D6")]
	[Address(RVA = "0x2B61710", Offset = "0x2B60710", VA = "0x182B61710", Slot = "314")]
	public override void OnEvent(VailZoneStateEvent evnt)
	{
	}

	// Token: 0x060002D7 RID: 727 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002D7")]
	[Address(RVA = "0x2B62290", Offset = "0x2B61290", VA = "0x182B62290", Slot = "317")]
	public override void OnEvent(ActivateVailActor evnt)
	{
	}

	// Token: 0x060002D8 RID: 728 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002D8")]
	[Address(RVA = "0x2B61B30", Offset = "0x2B60B30", VA = "0x182B61B30", Slot = "318")]
	public override void OnEvent(VailThrowBodyEvent evnt)
	{
	}

	// Token: 0x060002D9 RID: 729 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002D9")]
	[Address(RVA = "0x2B61470", Offset = "0x2B60470", VA = "0x182B61470", Slot = "308")]
	public override void OnEvent(PickupBodyEvent evnt)
	{
	}

	// Token: 0x060002DA RID: 730 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002DA")]
	[Address(RVA = "0x2B61AD0", Offset = "0x2B60AD0", VA = "0x182B61AD0", Slot = "211")]
	public override void OnEvent(SpawnCutTree evnt)
	{
	}

	// Token: 0x060002DB RID: 731 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002DB")]
	[Address(RVA = "0x2B62C50", Offset = "0x2B61C50", VA = "0x182B62C50", Slot = "262")]
	public override void OnEvent(DropBodyEvent evnt)
	{
	}

	// Token: 0x060002DC RID: 732 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002DC")]
	[Address(RVA = "0x2B61790", Offset = "0x2B60790", VA = "0x182B61790", Slot = "310")]
	public override void OnEvent(SpawnLootItemEvent evnt)
	{
	}

	// Token: 0x060002DD RID: 733 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002DD")]
	[Address(RVA = "0x2B61BE0", Offset = "0x2B60BE0", VA = "0x182B61BE0", Slot = "325")]
	public override void OnEvent(TerrainDigNodeAdded boltEvent)
	{
	}

	// Token: 0x060002DE RID: 734 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002DE")]
	[Address(RVA = "0x2B62530", Offset = "0x2B61530", VA = "0x182B62530", Slot = "324")]
	public override void OnEvent(StructureCrafringNodeCreate boltEvent)
	{
	}

	// Token: 0x060002DF RID: 735 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002DF")]
	[Address(RVA = "0x2B62920", Offset = "0x2B61920", VA = "0x182B62920", Slot = "346")]
	public override void OnEvent(StructureCraftingNodeAddIngredientRejected boltEvent)
	{
	}

	// Token: 0x060002E0 RID: 736 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002E0")]
	[Address(RVA = "0x2B62D00", Offset = "0x2B61D00", VA = "0x182B62D00", Slot = "302")]
	public override void OnEvent(StructureCraftingNodeAddIngredient boltEvent)
	{
	}

	// Token: 0x060002E1 RID: 737 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002E1")]
	[Address(RVA = "0x2B629A0", Offset = "0x2B619A0", VA = "0x182B629A0", Slot = "301")]
	public override void OnEvent(StructureCraftingNodeCancel boltEvent)
	{
	}

	// Token: 0x060002E2 RID: 738 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002E2")]
	[Address(RVA = "0x2B62450", Offset = "0x2B61450", VA = "0x182B62450", Slot = "303")]
	public override void OnEvent(StructureCraftingNodeComplete boltEvent)
	{
	}

	// Token: 0x060002E3 RID: 739 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002E3")]
	[Address(RVA = "0x2B60AB0", Offset = "0x2B5FAB0", VA = "0x182B60AB0", Slot = "1")]
	protected override void Finalize()
	{
	}

	// Token: 0x060002E4 RID: 740 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002E4")]
	[Address(RVA = "0x2B63390", Offset = "0x2B62390", VA = "0x182B63390")]
	public static void UnregisterDeathMarkerServerCallbackEvent(Action<DeathMarkerRequest> eventResponse)
	{
	}

	// Token: 0x060002E5 RID: 741 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002E5")]
	[Address(RVA = "0x2B63160", Offset = "0x2B62160", VA = "0x182B63160")]
	public static void RegisterDeathMarkerServerCallbackEvent(Action<DeathMarkerRequest> eventResponse)
	{
	}

	// Token: 0x060002E6 RID: 742 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002E6")]
	[Address(RVA = "0x122BAB0", Offset = "0x122AAB0", VA = "0x18122BAB0")]
	public CoopClientCallbacks()
	{
	}

	// Token: 0x040002AB RID: 683
	[Token(Token = "0x40002AB")]
	[FieldOffset(Offset = "0x0")]
	private static bool invokedServerNotResponding;

	// Token: 0x040002AC RID: 684
	[Token(Token = "0x40002AC")]
	private const string MultiplayerTableReferenceKey = "Multiplayer";

	// Token: 0x040002AD RID: 685
	[Token(Token = "0x40002AD")]
	[FieldOffset(Offset = "0x8")]
	public static Action OnDisconnected;

	// Token: 0x040002AE RID: 686
	[Token(Token = "0x40002AE")]
	[FieldOffset(Offset = "0x10")]
	public static Action<string> OnServerShutdown;

	// Token: 0x040002AF RID: 687
	[Token(Token = "0x40002AF")]
	[FieldOffset(Offset = "0x18")]
	public static Action ServerNotResponding;

	// Token: 0x040002B0 RID: 688
	[Token(Token = "0x40002B0")]
	[FieldOffset(Offset = "0x20")]
	public static Action ServerIsResponding;
}
