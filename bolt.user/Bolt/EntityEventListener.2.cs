using System;
using BoltInternal;
using Il2CppDummyDll;

namespace Bolt
{
	// Token: 0x020002BD RID: 701
	[Token(Token = "0x20002BD")]
	public class EntityEventListener<TState> : EntityEventListenerBase<TState>, IPlaceConstructionListener, ISetTreeHealthListener, IDestroyPickUpListener, IDropItemListener, ISpawnImpactEffectListener, IPlayerHitByEnemeyListener, IChatEventListener, IPlayerHitEnemyListener, IHitPlayerListener, ISkinnedAnimalListener, IRequestDestroyListener, IPlaneCrashIndexListener, IItemHolderAddItemListener, IItemHolderTakeItemListener, ISendMessageEventListener, ISpawnCutTreeListener, IFauxWeaponHitListener, ISfxHammerListener, ISfxEatListener, ISfxDrinkListener, ISfxHurtListener, ISfxFallLightListener, ISfxFallHeavyListener, IFmodOneShotListener, ITrapResetEventListener, ICancelBluePrintListener, IPlayerHealedListener, IRackAddListener, IRackRemoveListener, ISetCorpsePositionListener, IPlayerAddItemListener, IPlaceFoundationExListener, ISledGrabListener, ISledReleaseListener, ILocalizedHitListener, IItemRemoveFromPlayerListener, ITripWireListener, IStealItemListener, IRaftGrabListener, IRaftReleaseListener, IAddRepairMaterialListener, IPlaceRopeListener, IBurnListener, IKeepAliveListener, IGardenPlotPlantSeedListener, IRemoveWaterListener, IFmodOneShotParameterListener, IAddBodyListener, IDestroyWithTagListener, IDefaultClothPickedUpListener, IClientACKListener, ITakeBodyListener, ITakeBodyApproveListener, IAddItemToDoorListener, IRaftControlListener, IPushRaftListener, IPickupRequestListener, IPickupApprovedListener, IPlaceTrophyListener, ICutTriggerActivatedListener, IAdminCommandListener, IAdminAuthedListener, IragdollActivateListener, IDisablePickupListener, IPlayerRemoveItemListener, IdoReleaseFromTrapListener, IDropBodyEventListener, ISleepListener, ISetGuiTextureColorListener, IPlaceDryingFoodListener, IRequestMecanimSyncListener, IupdateMecanimRemoteStateListener, IEndCrashListener, IRequestAnimationSequenceProxyListener, IBeginAnimationSequenceStageListener, IProgressAnimationSequenceStageListener, ICompleteAnimationSequenceStageListener, IstuckArrowsSyncListener, IdebugCommandListener, IsyncWorkBenchListener, IServerStatusInfoListener, IloadEndGamePrefabsListener, ISetTrappedEnemyListener, ITriggerFishTrapListener, IValidSleepTimeListener, IarrowFireSyncListener, ITakeClothingOutfitListener, IPickupGliderListener, IVailHitEventListener, IVailNoiseEventListener, IPlayerFireWeaponEventListener, IWorldObjectLocatorStateListener, IRobbyOrderEventListener, IStorageContainerOpenedListener, IStructureCraftingNodeCancelListener, IStructureCraftingNodeAddIngredientListener, IStructureCraftingNodeCompleteListener, IFireLightEventListener, IBreakableObjectBrokenListener, IDismemberHitEventListener, IPickupBodyEventListener, ISpawnLootItemEventListener, IRadioActivateListener, IHitEngineEventListener, ICaveBoardBrokenListener, IVailZoneStateEventListener, IDwGateOpenEventListener, IDwGateCloseEventListener, IActivateVailActorListener, IVailThrowBodyEventListener, IJumpTimeEventListener, IGardenPlotIsBusyListener, IVailParriedEventListener, IVailRequestVillageDataListener, IAttachItemToZiplineEventListener, IStructureCraftingNodeCreateListener, ITerrainDigNodeAddedListener, IPlayerGiveActorItemListener, IItemStorageAddItemEventListener, IItemStorageRemoveItemEventListener, IActorInteractEventListener, IChangeIdObjectStateListener, IZiplineCreateEventListener, IZiplineRemoveEventListener, IFireStokeEventListener, IVailReviveEventListener, IDeathMarkerRequestListener, IGardenPlotClearPlotListener, ITrapActivateEventListener, IResin3dPrinterStartPrintEventListener, IResin3dPrinterSetRecipeIdEventListener, IResin3dPrinterSetBusyEventListener, IResin3dPrinterItemRemovedEventListener, IResin3dPrinterRefillEventListener, IPlayerRequestActorItemListener, IRainCatcherIsBusyListener, IRainCatcherRemoveWaterListener, IVailRagdollEventListener, IVailAttachItemEventListener, ICookingSpotIsBusyEventListener, ICookingBeginCookingEventListener, ICookingPotRemovedEventListener, ICookingUpdateVolumeEventListener, ISetPlayerSpawnPointListener, IGolfCartShoveEventListener, IGolfCartConnectSlotEventListener, IItemStorageIsBusyListener, IPlayerInteractionEventListener, IBossCutsceneEventListener
	{
		// Token: 0x0600210D RID: 8461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600210D")]
		public EntityEventListener()
		{
		}

		// Token: 0x0600210E RID: 8462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600210E")]
		public virtual void OnEvent(PlaceConstruction evnt)
		{
		}

		// Token: 0x0600210F RID: 8463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600210F")]
		public virtual void OnEvent(SetTreeHealth evnt)
		{
		}

		// Token: 0x06002110 RID: 8464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002110")]
		public virtual void OnEvent(DestroyPickUp evnt)
		{
		}

		// Token: 0x06002111 RID: 8465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002111")]
		public virtual void OnEvent(DropItem evnt)
		{
		}

		// Token: 0x06002112 RID: 8466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002112")]
		public virtual void OnEvent(SpawnImpactEffect evnt)
		{
		}

		// Token: 0x06002113 RID: 8467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002113")]
		public virtual void OnEvent(PlayerHitByEnemey evnt)
		{
		}

		// Token: 0x06002114 RID: 8468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002114")]
		public virtual void OnEvent(ChatEvent evnt)
		{
		}

		// Token: 0x06002115 RID: 8469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002115")]
		public virtual void OnEvent(PlayerHitEnemy evnt)
		{
		}

		// Token: 0x06002116 RID: 8470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002116")]
		public virtual void OnEvent(HitPlayer evnt)
		{
		}

		// Token: 0x06002117 RID: 8471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002117")]
		public virtual void OnEvent(SkinnedAnimal evnt)
		{
		}

		// Token: 0x06002118 RID: 8472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002118")]
		public virtual void OnEvent(RequestDestroy evnt)
		{
		}

		// Token: 0x06002119 RID: 8473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002119")]
		public virtual void OnEvent(PlaneCrashIndex evnt)
		{
		}

		// Token: 0x0600211A RID: 8474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600211A")]
		public virtual void OnEvent(ItemHolderAddItem evnt)
		{
		}

		// Token: 0x0600211B RID: 8475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600211B")]
		public virtual void OnEvent(ItemHolderTakeItem evnt)
		{
		}

		// Token: 0x0600211C RID: 8476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600211C")]
		public virtual void OnEvent(SendMessageEvent evnt)
		{
		}

		// Token: 0x0600211D RID: 8477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600211D")]
		public virtual void OnEvent(SpawnCutTree evnt)
		{
		}

		// Token: 0x0600211E RID: 8478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600211E")]
		public virtual void OnEvent(FauxWeaponHit evnt)
		{
		}

		// Token: 0x0600211F RID: 8479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600211F")]
		public virtual void OnEvent(SfxHammer evnt)
		{
		}

		// Token: 0x06002120 RID: 8480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002120")]
		public virtual void OnEvent(SfxEat evnt)
		{
		}

		// Token: 0x06002121 RID: 8481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002121")]
		public virtual void OnEvent(SfxDrink evnt)
		{
		}

		// Token: 0x06002122 RID: 8482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002122")]
		public virtual void OnEvent(SfxHurt evnt)
		{
		}

		// Token: 0x06002123 RID: 8483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002123")]
		public virtual void OnEvent(SfxFallLight evnt)
		{
		}

		// Token: 0x06002124 RID: 8484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002124")]
		public virtual void OnEvent(SfxFallHeavy evnt)
		{
		}

		// Token: 0x06002125 RID: 8485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002125")]
		public virtual void OnEvent(FmodOneShot evnt)
		{
		}

		// Token: 0x06002126 RID: 8486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002126")]
		public virtual void OnEvent(TrapResetEvent evnt)
		{
		}

		// Token: 0x06002127 RID: 8487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002127")]
		public virtual void OnEvent(CancelBluePrint evnt)
		{
		}

		// Token: 0x06002128 RID: 8488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002128")]
		public virtual void OnEvent(PlayerHealed evnt)
		{
		}

		// Token: 0x06002129 RID: 8489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002129")]
		public virtual void OnEvent(RackAdd evnt)
		{
		}

		// Token: 0x0600212A RID: 8490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600212A")]
		public virtual void OnEvent(RackRemove evnt)
		{
		}

		// Token: 0x0600212B RID: 8491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600212B")]
		public virtual void OnEvent(SetCorpsePosition evnt)
		{
		}

		// Token: 0x0600212C RID: 8492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600212C")]
		public virtual void OnEvent(PlayerAddItem evnt)
		{
		}

		// Token: 0x0600212D RID: 8493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600212D")]
		public virtual void OnEvent(PlaceFoundationEx evnt)
		{
		}

		// Token: 0x0600212E RID: 8494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600212E")]
		public virtual void OnEvent(SledGrab evnt)
		{
		}

		// Token: 0x0600212F RID: 8495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600212F")]
		public virtual void OnEvent(SledRelease evnt)
		{
		}

		// Token: 0x06002130 RID: 8496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002130")]
		public virtual void OnEvent(LocalizedHit evnt)
		{
		}

		// Token: 0x06002131 RID: 8497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002131")]
		public virtual void OnEvent(ItemRemoveFromPlayer evnt)
		{
		}

		// Token: 0x06002132 RID: 8498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002132")]
		public virtual void OnEvent(TripWire evnt)
		{
		}

		// Token: 0x06002133 RID: 8499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002133")]
		public virtual void OnEvent(StealItem evnt)
		{
		}

		// Token: 0x06002134 RID: 8500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002134")]
		public virtual void OnEvent(RaftGrab evnt)
		{
		}

		// Token: 0x06002135 RID: 8501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002135")]
		public virtual void OnEvent(RaftRelease evnt)
		{
		}

		// Token: 0x06002136 RID: 8502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002136")]
		public virtual void OnEvent(AddRepairMaterial evnt)
		{
		}

		// Token: 0x06002137 RID: 8503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002137")]
		public virtual void OnEvent(PlaceRope evnt)
		{
		}

		// Token: 0x06002138 RID: 8504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002138")]
		public virtual void OnEvent(Burn evnt)
		{
		}

		// Token: 0x06002139 RID: 8505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002139")]
		public virtual void OnEvent(KeepAlive evnt)
		{
		}

		// Token: 0x0600213A RID: 8506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600213A")]
		public virtual void OnEvent(GardenPlotPlantSeed evnt)
		{
		}

		// Token: 0x0600213B RID: 8507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600213B")]
		public virtual void OnEvent(RemoveWater evnt)
		{
		}

		// Token: 0x0600213C RID: 8508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600213C")]
		public virtual void OnEvent(FmodOneShotParameter evnt)
		{
		}

		// Token: 0x0600213D RID: 8509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600213D")]
		public virtual void OnEvent(AddBody evnt)
		{
		}

		// Token: 0x0600213E RID: 8510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600213E")]
		public virtual void OnEvent(DestroyWithTag evnt)
		{
		}

		// Token: 0x0600213F RID: 8511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600213F")]
		public virtual void OnEvent(DefaultClothPickedUp evnt)
		{
		}

		// Token: 0x06002140 RID: 8512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002140")]
		public virtual void OnEvent(ClientACK evnt)
		{
		}

		// Token: 0x06002141 RID: 8513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002141")]
		public virtual void OnEvent(TakeBody evnt)
		{
		}

		// Token: 0x06002142 RID: 8514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002142")]
		public virtual void OnEvent(TakeBodyApprove evnt)
		{
		}

		// Token: 0x06002143 RID: 8515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002143")]
		public virtual void OnEvent(AddItemToDoor evnt)
		{
		}

		// Token: 0x06002144 RID: 8516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002144")]
		public virtual void OnEvent(RaftControl evnt)
		{
		}

		// Token: 0x06002145 RID: 8517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002145")]
		public virtual void OnEvent(PushRaft evnt)
		{
		}

		// Token: 0x06002146 RID: 8518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002146")]
		public virtual void OnEvent(PickupRequest evnt)
		{
		}

		// Token: 0x06002147 RID: 8519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002147")]
		public virtual void OnEvent(PickupApproved evnt)
		{
		}

		// Token: 0x06002148 RID: 8520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002148")]
		public virtual void OnEvent(PlaceTrophy evnt)
		{
		}

		// Token: 0x06002149 RID: 8521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002149")]
		public virtual void OnEvent(CutTriggerActivated evnt)
		{
		}

		// Token: 0x0600214A RID: 8522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600214A")]
		public virtual void OnEvent(AdminCommand evnt)
		{
		}

		// Token: 0x0600214B RID: 8523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600214B")]
		public virtual void OnEvent(AdminAuthed evnt)
		{
		}

		// Token: 0x0600214C RID: 8524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600214C")]
		public virtual void OnEvent(ragdollActivate evnt)
		{
		}

		// Token: 0x0600214D RID: 8525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600214D")]
		public virtual void OnEvent(DisablePickup evnt)
		{
		}

		// Token: 0x0600214E RID: 8526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600214E")]
		public virtual void OnEvent(PlayerRemoveItem evnt)
		{
		}

		// Token: 0x0600214F RID: 8527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600214F")]
		public virtual void OnEvent(doReleaseFromTrap evnt)
		{
		}

		// Token: 0x06002150 RID: 8528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002150")]
		public virtual void OnEvent(DropBodyEvent evnt)
		{
		}

		// Token: 0x06002151 RID: 8529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002151")]
		public virtual void OnEvent(Sleep evnt)
		{
		}

		// Token: 0x06002152 RID: 8530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002152")]
		public virtual void OnEvent(SetGuiTextureColor evnt)
		{
		}

		// Token: 0x06002153 RID: 8531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002153")]
		public virtual void OnEvent(PlaceDryingFood evnt)
		{
		}

		// Token: 0x06002154 RID: 8532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002154")]
		public virtual void OnEvent(RequestMecanimSync evnt)
		{
		}

		// Token: 0x06002155 RID: 8533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002155")]
		public virtual void OnEvent(updateMecanimRemoteState evnt)
		{
		}

		// Token: 0x06002156 RID: 8534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002156")]
		public virtual void OnEvent(EndCrash evnt)
		{
		}

		// Token: 0x06002157 RID: 8535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002157")]
		public virtual void OnEvent(RequestAnimationSequenceProxy evnt)
		{
		}

		// Token: 0x06002158 RID: 8536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002158")]
		public virtual void OnEvent(BeginAnimationSequenceStage evnt)
		{
		}

		// Token: 0x06002159 RID: 8537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002159")]
		public virtual void OnEvent(ProgressAnimationSequenceStage evnt)
		{
		}

		// Token: 0x0600215A RID: 8538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600215A")]
		public virtual void OnEvent(CompleteAnimationSequenceStage evnt)
		{
		}

		// Token: 0x0600215B RID: 8539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600215B")]
		public virtual void OnEvent(stuckArrowsSync evnt)
		{
		}

		// Token: 0x0600215C RID: 8540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600215C")]
		public virtual void OnEvent(debugCommand evnt)
		{
		}

		// Token: 0x0600215D RID: 8541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600215D")]
		public virtual void OnEvent(syncWorkBench evnt)
		{
		}

		// Token: 0x0600215E RID: 8542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600215E")]
		public virtual void OnEvent(ServerStatusInfo evnt)
		{
		}

		// Token: 0x0600215F RID: 8543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600215F")]
		public virtual void OnEvent(loadEndGamePrefabs evnt)
		{
		}

		// Token: 0x06002160 RID: 8544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002160")]
		public virtual void OnEvent(SetTrappedEnemy evnt)
		{
		}

		// Token: 0x06002161 RID: 8545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002161")]
		public virtual void OnEvent(TriggerFishTrap evnt)
		{
		}

		// Token: 0x06002162 RID: 8546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002162")]
		public virtual void OnEvent(ValidSleepTime evnt)
		{
		}

		// Token: 0x06002163 RID: 8547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002163")]
		public virtual void OnEvent(arrowFireSync evnt)
		{
		}

		// Token: 0x06002164 RID: 8548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002164")]
		public virtual void OnEvent(TakeClothingOutfit evnt)
		{
		}

		// Token: 0x06002165 RID: 8549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002165")]
		public virtual void OnEvent(PickupGlider evnt)
		{
		}

		// Token: 0x06002166 RID: 8550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002166")]
		public virtual void OnEvent(VailHitEvent evnt)
		{
		}

		// Token: 0x06002167 RID: 8551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002167")]
		public virtual void OnEvent(VailNoiseEvent evnt)
		{
		}

		// Token: 0x06002168 RID: 8552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002168")]
		public virtual void OnEvent(PlayerFireWeaponEvent evnt)
		{
		}

		// Token: 0x06002169 RID: 8553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002169")]
		public virtual void OnEvent(WorldObjectLocatorState evnt)
		{
		}

		// Token: 0x0600216A RID: 8554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600216A")]
		public virtual void OnEvent(RobbyOrderEvent evnt)
		{
		}

		// Token: 0x0600216B RID: 8555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600216B")]
		public virtual void OnEvent(StorageContainerOpened evnt)
		{
		}

		// Token: 0x0600216C RID: 8556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600216C")]
		public virtual void OnEvent(StructureCraftingNodeCancel evnt)
		{
		}

		// Token: 0x0600216D RID: 8557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600216D")]
		public virtual void OnEvent(StructureCraftingNodeAddIngredient evnt)
		{
		}

		// Token: 0x0600216E RID: 8558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600216E")]
		public virtual void OnEvent(StructureCraftingNodeComplete evnt)
		{
		}

		// Token: 0x0600216F RID: 8559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600216F")]
		public virtual void OnEvent(FireLightEvent evnt)
		{
		}

		// Token: 0x06002170 RID: 8560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002170")]
		public virtual void OnEvent(BreakableObjectBroken evnt)
		{
		}

		// Token: 0x06002171 RID: 8561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002171")]
		public virtual void OnEvent(DismemberHitEvent evnt)
		{
		}

		// Token: 0x06002172 RID: 8562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002172")]
		public virtual void OnEvent(PickupBodyEvent evnt)
		{
		}

		// Token: 0x06002173 RID: 8563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002173")]
		public virtual void OnEvent(SpawnLootItemEvent evnt)
		{
		}

		// Token: 0x06002174 RID: 8564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002174")]
		public virtual void OnEvent(RadioActivate evnt)
		{
		}

		// Token: 0x06002175 RID: 8565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002175")]
		public virtual void OnEvent(HitEngineEvent evnt)
		{
		}

		// Token: 0x06002176 RID: 8566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002176")]
		public virtual void OnEvent(CaveBoardBroken evnt)
		{
		}

		// Token: 0x06002177 RID: 8567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002177")]
		public virtual void OnEvent(VailZoneStateEvent evnt)
		{
		}

		// Token: 0x06002178 RID: 8568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002178")]
		public virtual void OnEvent(DwGateOpenEvent evnt)
		{
		}

		// Token: 0x06002179 RID: 8569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002179")]
		public virtual void OnEvent(DwGateCloseEvent evnt)
		{
		}

		// Token: 0x0600217A RID: 8570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600217A")]
		public virtual void OnEvent(ActivateVailActor evnt)
		{
		}

		// Token: 0x0600217B RID: 8571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600217B")]
		public virtual void OnEvent(VailThrowBodyEvent evnt)
		{
		}

		// Token: 0x0600217C RID: 8572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600217C")]
		public virtual void OnEvent(JumpTimeEvent evnt)
		{
		}

		// Token: 0x0600217D RID: 8573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600217D")]
		public virtual void OnEvent(GardenPlotIsBusy evnt)
		{
		}

		// Token: 0x0600217E RID: 8574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600217E")]
		public virtual void OnEvent(VailParriedEvent evnt)
		{
		}

		// Token: 0x0600217F RID: 8575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600217F")]
		public virtual void OnEvent(VailRequestVillageData evnt)
		{
		}

		// Token: 0x06002180 RID: 8576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002180")]
		public virtual void OnEvent(AttachItemToZiplineEvent evnt)
		{
		}

		// Token: 0x06002181 RID: 8577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002181")]
		public virtual void OnEvent(StructureCraftingNodeCreate evnt)
		{
		}

		// Token: 0x06002182 RID: 8578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002182")]
		public virtual void OnEvent(TerrainDigNodeAdded evnt)
		{
		}

		// Token: 0x06002183 RID: 8579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002183")]
		public virtual void OnEvent(PlayerGiveActorItem evnt)
		{
		}

		// Token: 0x06002184 RID: 8580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002184")]
		public virtual void OnEvent(ItemStorageAddItemEvent evnt)
		{
		}

		// Token: 0x06002185 RID: 8581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002185")]
		public virtual void OnEvent(ItemStorageRemoveItemEvent evnt)
		{
		}

		// Token: 0x06002186 RID: 8582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002186")]
		public virtual void OnEvent(ActorInteractEvent evnt)
		{
		}

		// Token: 0x06002187 RID: 8583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002187")]
		public virtual void OnEvent(ChangeIdObjectState evnt)
		{
		}

		// Token: 0x06002188 RID: 8584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002188")]
		public virtual void OnEvent(ZiplineCreateEvent evnt)
		{
		}

		// Token: 0x06002189 RID: 8585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002189")]
		public virtual void OnEvent(ZiplineRemoveEvent evnt)
		{
		}

		// Token: 0x0600218A RID: 8586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600218A")]
		public virtual void OnEvent(FireStokeEvent evnt)
		{
		}

		// Token: 0x0600218B RID: 8587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600218B")]
		public virtual void OnEvent(VailReviveEvent evnt)
		{
		}

		// Token: 0x0600218C RID: 8588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600218C")]
		public virtual void OnEvent(DeathMarkerRequest evnt)
		{
		}

		// Token: 0x0600218D RID: 8589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600218D")]
		public virtual void OnEvent(GardenPlotClearPlot evnt)
		{
		}

		// Token: 0x0600218E RID: 8590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600218E")]
		public virtual void OnEvent(TrapActivateEvent evnt)
		{
		}

		// Token: 0x0600218F RID: 8591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600218F")]
		public virtual void OnEvent(Resin3dPrinterStartPrintEvent evnt)
		{
		}

		// Token: 0x06002190 RID: 8592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002190")]
		public virtual void OnEvent(Resin3dPrinterSetRecipeIdEvent evnt)
		{
		}

		// Token: 0x06002191 RID: 8593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002191")]
		public virtual void OnEvent(Resin3dPrinterSetBusyEvent evnt)
		{
		}

		// Token: 0x06002192 RID: 8594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002192")]
		public virtual void OnEvent(Resin3dPrinterItemRemovedEvent evnt)
		{
		}

		// Token: 0x06002193 RID: 8595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002193")]
		public virtual void OnEvent(Resin3dPrinterRefillEvent evnt)
		{
		}

		// Token: 0x06002194 RID: 8596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002194")]
		public virtual void OnEvent(PlayerRequestActorItem evnt)
		{
		}

		// Token: 0x06002195 RID: 8597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002195")]
		public virtual void OnEvent(RainCatcherIsBusy evnt)
		{
		}

		// Token: 0x06002196 RID: 8598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002196")]
		public virtual void OnEvent(RainCatcherRemoveWater evnt)
		{
		}

		// Token: 0x06002197 RID: 8599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002197")]
		public virtual void OnEvent(VailRagdollEvent evnt)
		{
		}

		// Token: 0x06002198 RID: 8600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002198")]
		public virtual void OnEvent(VailAttachItemEvent evnt)
		{
		}

		// Token: 0x06002199 RID: 8601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002199")]
		public virtual void OnEvent(CookingSpotIsBusyEvent evnt)
		{
		}

		// Token: 0x0600219A RID: 8602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600219A")]
		public virtual void OnEvent(CookingBeginCookingEvent evnt)
		{
		}

		// Token: 0x0600219B RID: 8603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600219B")]
		public virtual void OnEvent(CookingPotRemovedEvent evnt)
		{
		}

		// Token: 0x0600219C RID: 8604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600219C")]
		public virtual void OnEvent(CookingUpdateVolumeEvent evnt)
		{
		}

		// Token: 0x0600219D RID: 8605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600219D")]
		public virtual void OnEvent(SetPlayerSpawnPoint evnt)
		{
		}

		// Token: 0x0600219E RID: 8606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600219E")]
		public virtual void OnEvent(GolfCartShoveEvent evnt)
		{
		}

		// Token: 0x0600219F RID: 8607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600219F")]
		public virtual void OnEvent(GolfCartConnectSlotEvent evnt)
		{
		}

		// Token: 0x060021A0 RID: 8608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021A0")]
		public virtual void OnEvent(ItemStorageIsBusy evnt)
		{
		}

		// Token: 0x060021A1 RID: 8609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021A1")]
		public virtual void OnEvent(PlayerInteractionEvent evnt)
		{
		}

		// Token: 0x060021A2 RID: 8610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021A2")]
		public virtual void OnEvent(BossCutsceneEvent evnt)
		{
		}
	}
}
