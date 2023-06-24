using System;
using BoltInternal;
using Il2CppDummyDll;

namespace Bolt
{
	// Token: 0x020002BC RID: 700
	[Token(Token = "0x20002BC")]
	public class EntityEventListener : EntityEventListenerBase, IPlaceConstructionListener, ISetTreeHealthListener, IDestroyPickUpListener, IDropItemListener, ISpawnImpactEffectListener, IPlayerHitByEnemeyListener, IChatEventListener, IPlayerHitEnemyListener, IHitPlayerListener, ISkinnedAnimalListener, IRequestDestroyListener, IPlaneCrashIndexListener, IItemHolderAddItemListener, IItemHolderTakeItemListener, ISendMessageEventListener, ISpawnCutTreeListener, IFauxWeaponHitListener, ISfxHammerListener, ISfxEatListener, ISfxDrinkListener, ISfxHurtListener, ISfxFallLightListener, ISfxFallHeavyListener, IFmodOneShotListener, ITrapResetEventListener, ICancelBluePrintListener, IPlayerHealedListener, IRackAddListener, IRackRemoveListener, ISetCorpsePositionListener, IPlayerAddItemListener, IPlaceFoundationExListener, ISledGrabListener, ISledReleaseListener, ILocalizedHitListener, IItemRemoveFromPlayerListener, ITripWireListener, IStealItemListener, IRaftGrabListener, IRaftReleaseListener, IAddRepairMaterialListener, IPlaceRopeListener, IBurnListener, IKeepAliveListener, IGardenPlotPlantSeedListener, IRemoveWaterListener, IFmodOneShotParameterListener, IAddBodyListener, IDestroyWithTagListener, IDefaultClothPickedUpListener, IClientACKListener, ITakeBodyListener, ITakeBodyApproveListener, IAddItemToDoorListener, IRaftControlListener, IPushRaftListener, IPickupRequestListener, IPickupApprovedListener, IPlaceTrophyListener, ICutTriggerActivatedListener, IAdminCommandListener, IAdminAuthedListener, IragdollActivateListener, IDisablePickupListener, IPlayerRemoveItemListener, IdoReleaseFromTrapListener, IDropBodyEventListener, ISleepListener, ISetGuiTextureColorListener, IPlaceDryingFoodListener, IRequestMecanimSyncListener, IupdateMecanimRemoteStateListener, IEndCrashListener, IRequestAnimationSequenceProxyListener, IBeginAnimationSequenceStageListener, IProgressAnimationSequenceStageListener, ICompleteAnimationSequenceStageListener, IstuckArrowsSyncListener, IdebugCommandListener, IsyncWorkBenchListener, IServerStatusInfoListener, IloadEndGamePrefabsListener, ISetTrappedEnemyListener, ITriggerFishTrapListener, IValidSleepTimeListener, IarrowFireSyncListener, ITakeClothingOutfitListener, IPickupGliderListener, IVailHitEventListener, IVailNoiseEventListener, IPlayerFireWeaponEventListener, IWorldObjectLocatorStateListener, IRobbyOrderEventListener, IStorageContainerOpenedListener, IStructureCraftingNodeCancelListener, IStructureCraftingNodeAddIngredientListener, IStructureCraftingNodeCompleteListener, IFireLightEventListener, IBreakableObjectBrokenListener, IDismemberHitEventListener, IPickupBodyEventListener, ISpawnLootItemEventListener, IRadioActivateListener, IHitEngineEventListener, ICaveBoardBrokenListener, IVailZoneStateEventListener, IDwGateOpenEventListener, IDwGateCloseEventListener, IActivateVailActorListener, IVailThrowBodyEventListener, IJumpTimeEventListener, IGardenPlotIsBusyListener, IVailParriedEventListener, IVailRequestVillageDataListener, IAttachItemToZiplineEventListener, IStructureCraftingNodeCreateListener, ITerrainDigNodeAddedListener, IPlayerGiveActorItemListener, IItemStorageAddItemEventListener, IItemStorageRemoveItemEventListener, IActorInteractEventListener, IChangeIdObjectStateListener, IZiplineCreateEventListener, IZiplineRemoveEventListener, IFireStokeEventListener, IVailReviveEventListener, IDeathMarkerRequestListener, IGardenPlotClearPlotListener, ITrapActivateEventListener, IResin3dPrinterStartPrintEventListener, IResin3dPrinterSetRecipeIdEventListener, IResin3dPrinterSetBusyEventListener, IResin3dPrinterItemRemovedEventListener, IResin3dPrinterRefillEventListener, IPlayerRequestActorItemListener, IRainCatcherIsBusyListener, IRainCatcherRemoveWaterListener, IVailRagdollEventListener, IVailAttachItemEventListener, ICookingSpotIsBusyEventListener, ICookingBeginCookingEventListener, ICookingPotRemovedEventListener, ICookingUpdateVolumeEventListener, ISetPlayerSpawnPointListener, IGolfCartShoveEventListener, IGolfCartConnectSlotEventListener, IItemStorageIsBusyListener, IPlayerInteractionEventListener, IBossCutsceneEventListener
	{
		// Token: 0x06002077 RID: 8311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002077")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public EntityEventListener()
		{
		}

		// Token: 0x06002078 RID: 8312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002078")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "173")]
		public virtual void OnEvent(PlaceConstruction evnt)
		{
		}

		// Token: 0x06002079 RID: 8313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002079")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "174")]
		public virtual void OnEvent(SetTreeHealth evnt)
		{
		}

		// Token: 0x0600207A RID: 8314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600207A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "175")]
		public virtual void OnEvent(DestroyPickUp evnt)
		{
		}

		// Token: 0x0600207B RID: 8315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600207B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "176")]
		public virtual void OnEvent(DropItem evnt)
		{
		}

		// Token: 0x0600207C RID: 8316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600207C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "177")]
		public virtual void OnEvent(SpawnImpactEffect evnt)
		{
		}

		// Token: 0x0600207D RID: 8317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600207D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "178")]
		public virtual void OnEvent(PlayerHitByEnemey evnt)
		{
		}

		// Token: 0x0600207E RID: 8318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600207E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "179")]
		public virtual void OnEvent(ChatEvent evnt)
		{
		}

		// Token: 0x0600207F RID: 8319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600207F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "180")]
		public virtual void OnEvent(PlayerHitEnemy evnt)
		{
		}

		// Token: 0x06002080 RID: 8320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002080")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "181")]
		public virtual void OnEvent(HitPlayer evnt)
		{
		}

		// Token: 0x06002081 RID: 8321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002081")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "182")]
		public virtual void OnEvent(SkinnedAnimal evnt)
		{
		}

		// Token: 0x06002082 RID: 8322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002082")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "183")]
		public virtual void OnEvent(RequestDestroy evnt)
		{
		}

		// Token: 0x06002083 RID: 8323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002083")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "184")]
		public virtual void OnEvent(PlaneCrashIndex evnt)
		{
		}

		// Token: 0x06002084 RID: 8324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002084")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "185")]
		public virtual void OnEvent(ItemHolderAddItem evnt)
		{
		}

		// Token: 0x06002085 RID: 8325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002085")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "186")]
		public virtual void OnEvent(ItemHolderTakeItem evnt)
		{
		}

		// Token: 0x06002086 RID: 8326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002086")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "187")]
		public virtual void OnEvent(SendMessageEvent evnt)
		{
		}

		// Token: 0x06002087 RID: 8327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002087")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "188")]
		public virtual void OnEvent(SpawnCutTree evnt)
		{
		}

		// Token: 0x06002088 RID: 8328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002088")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "189")]
		public virtual void OnEvent(FauxWeaponHit evnt)
		{
		}

		// Token: 0x06002089 RID: 8329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002089")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "190")]
		public virtual void OnEvent(SfxHammer evnt)
		{
		}

		// Token: 0x0600208A RID: 8330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600208A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "191")]
		public virtual void OnEvent(SfxEat evnt)
		{
		}

		// Token: 0x0600208B RID: 8331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600208B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "192")]
		public virtual void OnEvent(SfxDrink evnt)
		{
		}

		// Token: 0x0600208C RID: 8332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600208C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "193")]
		public virtual void OnEvent(SfxHurt evnt)
		{
		}

		// Token: 0x0600208D RID: 8333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600208D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "194")]
		public virtual void OnEvent(SfxFallLight evnt)
		{
		}

		// Token: 0x0600208E RID: 8334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600208E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "195")]
		public virtual void OnEvent(SfxFallHeavy evnt)
		{
		}

		// Token: 0x0600208F RID: 8335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600208F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "196")]
		public virtual void OnEvent(FmodOneShot evnt)
		{
		}

		// Token: 0x06002090 RID: 8336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002090")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "197")]
		public virtual void OnEvent(TrapResetEvent evnt)
		{
		}

		// Token: 0x06002091 RID: 8337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002091")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "198")]
		public virtual void OnEvent(CancelBluePrint evnt)
		{
		}

		// Token: 0x06002092 RID: 8338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002092")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "199")]
		public virtual void OnEvent(PlayerHealed evnt)
		{
		}

		// Token: 0x06002093 RID: 8339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002093")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "200")]
		public virtual void OnEvent(RackAdd evnt)
		{
		}

		// Token: 0x06002094 RID: 8340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002094")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "201")]
		public virtual void OnEvent(RackRemove evnt)
		{
		}

		// Token: 0x06002095 RID: 8341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002095")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "202")]
		public virtual void OnEvent(SetCorpsePosition evnt)
		{
		}

		// Token: 0x06002096 RID: 8342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002096")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "203")]
		public virtual void OnEvent(PlayerAddItem evnt)
		{
		}

		// Token: 0x06002097 RID: 8343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002097")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "204")]
		public virtual void OnEvent(PlaceFoundationEx evnt)
		{
		}

		// Token: 0x06002098 RID: 8344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002098")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "205")]
		public virtual void OnEvent(SledGrab evnt)
		{
		}

		// Token: 0x06002099 RID: 8345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002099")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "206")]
		public virtual void OnEvent(SledRelease evnt)
		{
		}

		// Token: 0x0600209A RID: 8346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600209A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "207")]
		public virtual void OnEvent(LocalizedHit evnt)
		{
		}

		// Token: 0x0600209B RID: 8347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600209B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "208")]
		public virtual void OnEvent(ItemRemoveFromPlayer evnt)
		{
		}

		// Token: 0x0600209C RID: 8348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600209C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "209")]
		public virtual void OnEvent(TripWire evnt)
		{
		}

		// Token: 0x0600209D RID: 8349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600209D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "210")]
		public virtual void OnEvent(StealItem evnt)
		{
		}

		// Token: 0x0600209E RID: 8350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600209E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "211")]
		public virtual void OnEvent(RaftGrab evnt)
		{
		}

		// Token: 0x0600209F RID: 8351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600209F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "212")]
		public virtual void OnEvent(RaftRelease evnt)
		{
		}

		// Token: 0x060020A0 RID: 8352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020A0")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "213")]
		public virtual void OnEvent(AddRepairMaterial evnt)
		{
		}

		// Token: 0x060020A1 RID: 8353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020A1")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "214")]
		public virtual void OnEvent(PlaceRope evnt)
		{
		}

		// Token: 0x060020A2 RID: 8354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020A2")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "215")]
		public virtual void OnEvent(Burn evnt)
		{
		}

		// Token: 0x060020A3 RID: 8355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020A3")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "216")]
		public virtual void OnEvent(KeepAlive evnt)
		{
		}

		// Token: 0x060020A4 RID: 8356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020A4")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "217")]
		public virtual void OnEvent(GardenPlotPlantSeed evnt)
		{
		}

		// Token: 0x060020A5 RID: 8357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020A5")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "218")]
		public virtual void OnEvent(RemoveWater evnt)
		{
		}

		// Token: 0x060020A6 RID: 8358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020A6")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "219")]
		public virtual void OnEvent(FmodOneShotParameter evnt)
		{
		}

		// Token: 0x060020A7 RID: 8359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020A7")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "220")]
		public virtual void OnEvent(AddBody evnt)
		{
		}

		// Token: 0x060020A8 RID: 8360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020A8")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "221")]
		public virtual void OnEvent(DestroyWithTag evnt)
		{
		}

		// Token: 0x060020A9 RID: 8361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020A9")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "222")]
		public virtual void OnEvent(DefaultClothPickedUp evnt)
		{
		}

		// Token: 0x060020AA RID: 8362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020AA")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "223")]
		public virtual void OnEvent(ClientACK evnt)
		{
		}

		// Token: 0x060020AB RID: 8363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020AB")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "224")]
		public virtual void OnEvent(TakeBody evnt)
		{
		}

		// Token: 0x060020AC RID: 8364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020AC")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "225")]
		public virtual void OnEvent(TakeBodyApprove evnt)
		{
		}

		// Token: 0x060020AD RID: 8365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020AD")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "226")]
		public virtual void OnEvent(AddItemToDoor evnt)
		{
		}

		// Token: 0x060020AE RID: 8366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020AE")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "227")]
		public virtual void OnEvent(RaftControl evnt)
		{
		}

		// Token: 0x060020AF RID: 8367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020AF")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "228")]
		public virtual void OnEvent(PushRaft evnt)
		{
		}

		// Token: 0x060020B0 RID: 8368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020B0")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "229")]
		public virtual void OnEvent(PickupRequest evnt)
		{
		}

		// Token: 0x060020B1 RID: 8369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020B1")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "230")]
		public virtual void OnEvent(PickupApproved evnt)
		{
		}

		// Token: 0x060020B2 RID: 8370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020B2")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "231")]
		public virtual void OnEvent(PlaceTrophy evnt)
		{
		}

		// Token: 0x060020B3 RID: 8371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020B3")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "232")]
		public virtual void OnEvent(CutTriggerActivated evnt)
		{
		}

		// Token: 0x060020B4 RID: 8372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020B4")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "233")]
		public virtual void OnEvent(AdminCommand evnt)
		{
		}

		// Token: 0x060020B5 RID: 8373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020B5")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "234")]
		public virtual void OnEvent(AdminAuthed evnt)
		{
		}

		// Token: 0x060020B6 RID: 8374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020B6")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "235")]
		public virtual void OnEvent(ragdollActivate evnt)
		{
		}

		// Token: 0x060020B7 RID: 8375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020B7")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "236")]
		public virtual void OnEvent(DisablePickup evnt)
		{
		}

		// Token: 0x060020B8 RID: 8376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020B8")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "237")]
		public virtual void OnEvent(PlayerRemoveItem evnt)
		{
		}

		// Token: 0x060020B9 RID: 8377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020B9")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "238")]
		public virtual void OnEvent(doReleaseFromTrap evnt)
		{
		}

		// Token: 0x060020BA RID: 8378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020BA")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "239")]
		public virtual void OnEvent(DropBodyEvent evnt)
		{
		}

		// Token: 0x060020BB RID: 8379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020BB")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "240")]
		public virtual void OnEvent(Sleep evnt)
		{
		}

		// Token: 0x060020BC RID: 8380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020BC")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "241")]
		public virtual void OnEvent(SetGuiTextureColor evnt)
		{
		}

		// Token: 0x060020BD RID: 8381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020BD")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "242")]
		public virtual void OnEvent(PlaceDryingFood evnt)
		{
		}

		// Token: 0x060020BE RID: 8382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020BE")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "243")]
		public virtual void OnEvent(RequestMecanimSync evnt)
		{
		}

		// Token: 0x060020BF RID: 8383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020BF")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "244")]
		public virtual void OnEvent(updateMecanimRemoteState evnt)
		{
		}

		// Token: 0x060020C0 RID: 8384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020C0")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "245")]
		public virtual void OnEvent(EndCrash evnt)
		{
		}

		// Token: 0x060020C1 RID: 8385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020C1")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "246")]
		public virtual void OnEvent(RequestAnimationSequenceProxy evnt)
		{
		}

		// Token: 0x060020C2 RID: 8386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020C2")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "247")]
		public virtual void OnEvent(BeginAnimationSequenceStage evnt)
		{
		}

		// Token: 0x060020C3 RID: 8387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020C3")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "248")]
		public virtual void OnEvent(ProgressAnimationSequenceStage evnt)
		{
		}

		// Token: 0x060020C4 RID: 8388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020C4")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "249")]
		public virtual void OnEvent(CompleteAnimationSequenceStage evnt)
		{
		}

		// Token: 0x060020C5 RID: 8389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020C5")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "250")]
		public virtual void OnEvent(stuckArrowsSync evnt)
		{
		}

		// Token: 0x060020C6 RID: 8390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020C6")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "251")]
		public virtual void OnEvent(debugCommand evnt)
		{
		}

		// Token: 0x060020C7 RID: 8391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020C7")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "252")]
		public virtual void OnEvent(syncWorkBench evnt)
		{
		}

		// Token: 0x060020C8 RID: 8392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020C8")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "253")]
		public virtual void OnEvent(ServerStatusInfo evnt)
		{
		}

		// Token: 0x060020C9 RID: 8393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020C9")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "254")]
		public virtual void OnEvent(loadEndGamePrefabs evnt)
		{
		}

		// Token: 0x060020CA RID: 8394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020CA")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "255")]
		public virtual void OnEvent(SetTrappedEnemy evnt)
		{
		}

		// Token: 0x060020CB RID: 8395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020CB")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "256")]
		public virtual void OnEvent(TriggerFishTrap evnt)
		{
		}

		// Token: 0x060020CC RID: 8396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020CC")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "257")]
		public virtual void OnEvent(ValidSleepTime evnt)
		{
		}

		// Token: 0x060020CD RID: 8397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020CD")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "258")]
		public virtual void OnEvent(arrowFireSync evnt)
		{
		}

		// Token: 0x060020CE RID: 8398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020CE")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "259")]
		public virtual void OnEvent(TakeClothingOutfit evnt)
		{
		}

		// Token: 0x060020CF RID: 8399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020CF")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "260")]
		public virtual void OnEvent(PickupGlider evnt)
		{
		}

		// Token: 0x060020D0 RID: 8400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020D0")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "261")]
		public virtual void OnEvent(VailHitEvent evnt)
		{
		}

		// Token: 0x060020D1 RID: 8401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020D1")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "262")]
		public virtual void OnEvent(VailNoiseEvent evnt)
		{
		}

		// Token: 0x060020D2 RID: 8402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020D2")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "263")]
		public virtual void OnEvent(PlayerFireWeaponEvent evnt)
		{
		}

		// Token: 0x060020D3 RID: 8403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020D3")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "264")]
		public virtual void OnEvent(WorldObjectLocatorState evnt)
		{
		}

		// Token: 0x060020D4 RID: 8404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020D4")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "265")]
		public virtual void OnEvent(RobbyOrderEvent evnt)
		{
		}

		// Token: 0x060020D5 RID: 8405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020D5")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "266")]
		public virtual void OnEvent(StorageContainerOpened evnt)
		{
		}

		// Token: 0x060020D6 RID: 8406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020D6")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "267")]
		public virtual void OnEvent(StructureCraftingNodeCancel evnt)
		{
		}

		// Token: 0x060020D7 RID: 8407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020D7")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "268")]
		public virtual void OnEvent(StructureCraftingNodeAddIngredient evnt)
		{
		}

		// Token: 0x060020D8 RID: 8408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020D8")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "269")]
		public virtual void OnEvent(StructureCraftingNodeComplete evnt)
		{
		}

		// Token: 0x060020D9 RID: 8409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020D9")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "270")]
		public virtual void OnEvent(FireLightEvent evnt)
		{
		}

		// Token: 0x060020DA RID: 8410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020DA")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "271")]
		public virtual void OnEvent(BreakableObjectBroken evnt)
		{
		}

		// Token: 0x060020DB RID: 8411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020DB")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "272")]
		public virtual void OnEvent(DismemberHitEvent evnt)
		{
		}

		// Token: 0x060020DC RID: 8412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020DC")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "273")]
		public virtual void OnEvent(PickupBodyEvent evnt)
		{
		}

		// Token: 0x060020DD RID: 8413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020DD")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "274")]
		public virtual void OnEvent(SpawnLootItemEvent evnt)
		{
		}

		// Token: 0x060020DE RID: 8414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020DE")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "275")]
		public virtual void OnEvent(RadioActivate evnt)
		{
		}

		// Token: 0x060020DF RID: 8415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020DF")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "276")]
		public virtual void OnEvent(HitEngineEvent evnt)
		{
		}

		// Token: 0x060020E0 RID: 8416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020E0")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "277")]
		public virtual void OnEvent(CaveBoardBroken evnt)
		{
		}

		// Token: 0x060020E1 RID: 8417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020E1")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "278")]
		public virtual void OnEvent(VailZoneStateEvent evnt)
		{
		}

		// Token: 0x060020E2 RID: 8418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020E2")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "279")]
		public virtual void OnEvent(DwGateOpenEvent evnt)
		{
		}

		// Token: 0x060020E3 RID: 8419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020E3")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "280")]
		public virtual void OnEvent(DwGateCloseEvent evnt)
		{
		}

		// Token: 0x060020E4 RID: 8420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020E4")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "281")]
		public virtual void OnEvent(ActivateVailActor evnt)
		{
		}

		// Token: 0x060020E5 RID: 8421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020E5")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "282")]
		public virtual void OnEvent(VailThrowBodyEvent evnt)
		{
		}

		// Token: 0x060020E6 RID: 8422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020E6")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "283")]
		public virtual void OnEvent(JumpTimeEvent evnt)
		{
		}

		// Token: 0x060020E7 RID: 8423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020E7")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "284")]
		public virtual void OnEvent(GardenPlotIsBusy evnt)
		{
		}

		// Token: 0x060020E8 RID: 8424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020E8")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "285")]
		public virtual void OnEvent(VailParriedEvent evnt)
		{
		}

		// Token: 0x060020E9 RID: 8425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020E9")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "286")]
		public virtual void OnEvent(VailRequestVillageData evnt)
		{
		}

		// Token: 0x060020EA RID: 8426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020EA")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "287")]
		public virtual void OnEvent(AttachItemToZiplineEvent evnt)
		{
		}

		// Token: 0x060020EB RID: 8427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020EB")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "288")]
		public virtual void OnEvent(StructureCraftingNodeCreate evnt)
		{
		}

		// Token: 0x060020EC RID: 8428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020EC")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "289")]
		public virtual void OnEvent(TerrainDigNodeAdded evnt)
		{
		}

		// Token: 0x060020ED RID: 8429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020ED")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "290")]
		public virtual void OnEvent(PlayerGiveActorItem evnt)
		{
		}

		// Token: 0x060020EE RID: 8430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020EE")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "291")]
		public virtual void OnEvent(ItemStorageAddItemEvent evnt)
		{
		}

		// Token: 0x060020EF RID: 8431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020EF")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "292")]
		public virtual void OnEvent(ItemStorageRemoveItemEvent evnt)
		{
		}

		// Token: 0x060020F0 RID: 8432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020F0")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "293")]
		public virtual void OnEvent(ActorInteractEvent evnt)
		{
		}

		// Token: 0x060020F1 RID: 8433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020F1")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "294")]
		public virtual void OnEvent(ChangeIdObjectState evnt)
		{
		}

		// Token: 0x060020F2 RID: 8434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020F2")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "295")]
		public virtual void OnEvent(ZiplineCreateEvent evnt)
		{
		}

		// Token: 0x060020F3 RID: 8435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020F3")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "296")]
		public virtual void OnEvent(ZiplineRemoveEvent evnt)
		{
		}

		// Token: 0x060020F4 RID: 8436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020F4")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "297")]
		public virtual void OnEvent(FireStokeEvent evnt)
		{
		}

		// Token: 0x060020F5 RID: 8437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020F5")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "298")]
		public virtual void OnEvent(VailReviveEvent evnt)
		{
		}

		// Token: 0x060020F6 RID: 8438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020F6")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "299")]
		public virtual void OnEvent(DeathMarkerRequest evnt)
		{
		}

		// Token: 0x060020F7 RID: 8439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020F7")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "300")]
		public virtual void OnEvent(GardenPlotClearPlot evnt)
		{
		}

		// Token: 0x060020F8 RID: 8440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020F8")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "301")]
		public virtual void OnEvent(TrapActivateEvent evnt)
		{
		}

		// Token: 0x060020F9 RID: 8441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020F9")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "302")]
		public virtual void OnEvent(Resin3dPrinterStartPrintEvent evnt)
		{
		}

		// Token: 0x060020FA RID: 8442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020FA")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "303")]
		public virtual void OnEvent(Resin3dPrinterSetRecipeIdEvent evnt)
		{
		}

		// Token: 0x060020FB RID: 8443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020FB")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "304")]
		public virtual void OnEvent(Resin3dPrinterSetBusyEvent evnt)
		{
		}

		// Token: 0x060020FC RID: 8444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020FC")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "305")]
		public virtual void OnEvent(Resin3dPrinterItemRemovedEvent evnt)
		{
		}

		// Token: 0x060020FD RID: 8445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020FD")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "306")]
		public virtual void OnEvent(Resin3dPrinterRefillEvent evnt)
		{
		}

		// Token: 0x060020FE RID: 8446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020FE")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "307")]
		public virtual void OnEvent(PlayerRequestActorItem evnt)
		{
		}

		// Token: 0x060020FF RID: 8447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020FF")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "308")]
		public virtual void OnEvent(RainCatcherIsBusy evnt)
		{
		}

		// Token: 0x06002100 RID: 8448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002100")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "309")]
		public virtual void OnEvent(RainCatcherRemoveWater evnt)
		{
		}

		// Token: 0x06002101 RID: 8449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002101")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "310")]
		public virtual void OnEvent(VailRagdollEvent evnt)
		{
		}

		// Token: 0x06002102 RID: 8450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002102")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "311")]
		public virtual void OnEvent(VailAttachItemEvent evnt)
		{
		}

		// Token: 0x06002103 RID: 8451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002103")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "312")]
		public virtual void OnEvent(CookingSpotIsBusyEvent evnt)
		{
		}

		// Token: 0x06002104 RID: 8452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002104")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "313")]
		public virtual void OnEvent(CookingBeginCookingEvent evnt)
		{
		}

		// Token: 0x06002105 RID: 8453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002105")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "314")]
		public virtual void OnEvent(CookingPotRemovedEvent evnt)
		{
		}

		// Token: 0x06002106 RID: 8454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002106")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "315")]
		public virtual void OnEvent(CookingUpdateVolumeEvent evnt)
		{
		}

		// Token: 0x06002107 RID: 8455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002107")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "316")]
		public virtual void OnEvent(SetPlayerSpawnPoint evnt)
		{
		}

		// Token: 0x06002108 RID: 8456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002108")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "317")]
		public virtual void OnEvent(GolfCartShoveEvent evnt)
		{
		}

		// Token: 0x06002109 RID: 8457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002109")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "318")]
		public virtual void OnEvent(GolfCartConnectSlotEvent evnt)
		{
		}

		// Token: 0x0600210A RID: 8458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600210A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "319")]
		public virtual void OnEvent(ItemStorageIsBusy evnt)
		{
		}

		// Token: 0x0600210B RID: 8459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600210B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "320")]
		public virtual void OnEvent(PlayerInteractionEvent evnt)
		{
		}

		// Token: 0x0600210C RID: 8460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600210C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "321")]
		public virtual void OnEvent(BossCutsceneEvent evnt)
		{
		}
	}
}
