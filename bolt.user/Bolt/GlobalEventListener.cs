using System;
using BoltInternal;
using Il2CppDummyDll;

namespace Bolt
{
	// Token: 0x020002BB RID: 699
	[Token(Token = "0x20002BB")]
	public class GlobalEventListener : GlobalEventListenerBase, IPlaceConstructionListener, ISetTreeHealthListener, IDestroyPickUpListener, IDropItemListener, ISpawnImpactEffectListener, IPlayerHitByEnemeyListener, IChatEventListener, IPlayerHitEnemyListener, IHitPlayerListener, ISkinnedAnimalListener, IRequestDestroyListener, IFireCookEventListener, IPlaneCrashIndexListener, IItemHolderAddItemListener, IItemHolderTakeItemListener, ISendMessageEventListener, ISpawnCutTreeListener, IFauxWeaponHitListener, ISfxHammerListener, ISfxEatListener, ISfxDrinkListener, ISfxHurtListener, ISfxFallLightListener, ISfxFallHeavyListener, IFmodOneShotListener, ITrapResetEventListener, ICancelBluePrintListener, IPlayerHealedListener, IRackAddListener, IRackRemoveListener, ISetCorpsePositionListener, IPlayerAddItemListener, IPlaceFoundationExListener, ISledGrabListener, ISledReleaseListener, ILocalizedHitListener, IItemRemoveFromPlayerListener, ITripWireListener, IStealItemListener, IRaftGrabListener, IRaftReleaseListener, IAddRepairMaterialListener, IPlaceRopeListener, IBurnListener, IKeepAliveListener, IGardenPlotPlantSeedListener, IRemoveWaterListener, IFmodOneShotParameterListener, IAddBodyListener, IDestroyWithTagListener, IDefaultClothPickedUpListener, IClientACKListener, ITakeBodyListener, ITakeBodyApproveListener, IAddItemToDoorListener, IRaftControlListener, IPushRaftListener, IPickupRequestListener, IPickupApprovedListener, IPlaceTrophyListener, ICutTriggerActivatedListener, IAdminCommandListener, IAdminAuthedListener, IragdollActivateListener, IDisablePickupListener, IPlayerRemoveItemListener, IdoReleaseFromTrapListener, IDropBodyEventListener, ISleepListener, ISetGuiTextureColorListener, IPlaceDryingFoodListener, IRequestMecanimSyncListener, IupdateMecanimRemoteStateListener, IEndCrashListener, IRequestAnimationSequenceProxyListener, IBeginAnimationSequenceStageListener, IProgressAnimationSequenceStageListener, ICompleteAnimationSequenceStageListener, IstuckArrowsSyncListener, IdebugCommandListener, IsyncWorkBenchListener, ISetMasterClientListener, IServerStatusInfoListener, IloadEndGamePrefabsListener, ISetTrappedEnemyListener, ITriggerFishTrapListener, IValidSleepTimeListener, IarrowFireSyncListener, ISetJoiningTimeOfDayListener, ITakeClothingOutfitListener, IPickupGliderListener, IFreeFormStructureCreatedListener, IFreeFormStructureDestroyedListener, IFreeFormStructureEditedTransformListener, IFreeFormRequestAllDataListener, IFreeFormStructureCascadeRepositionSupportedListener, IFreeFormStructureEditedElementsListener, IFreeFormStructureEditedLinksListener, IVailHitEventListener, IVailNoiseEventListener, IPlayerFireWeaponEventListener, IWorldObjectLocatorStateListener, IRobbyOrderEventListener, IWorldObjectLocatorRequestAllDataListener, IStorageContainerOpenedListener, IPlayerConnectivityActionListener, IStructureCraftingNodeCancelListener, IStructureCraftingNodeAddIngredientListener, IStructureCraftingNodeCompleteListener, IFreeFormStructureRejectedListener, IFireLightEventListener, IBreakableObjectBrokenListener, IDismemberHitEventListener, IPickupBodyEventListener, IFreeFormPlaceElementListener, ISpawnLootItemEventListener, IRadioActivateListener, IHitEngineEventListener, ICaveBoardBrokenListener, IVailZoneStateEventListener, IDwGateOpenEventListener, IDwGateCloseEventListener, IActivateVailActorListener, IVailThrowBodyEventListener, IJumpTimeEventListener, IGardenPlotIsBusyListener, IVailParriedEventListener, IVailRequestVillageDataListener, IAttachItemToZiplineEventListener, IStructureCraftingNodeCreateListener, ITerrainDigNodeAddedListener, IPlayerGiveActorItemListener, IItemStorageAddItemEventListener, IItemStorageRemoveItemEventListener, IActorInteractEventListener, IChangeIdObjectStateListener, IZiplineCreateEventListener, IZiplineRemoveEventListener, IFireStokeEventListener, IVailReviveEventListener, IDeathMarkerRequestListener, IGardenPlotClearPlotListener, IFreeFormPlayerFinishedAnimListener, ITrapActivateEventListener, IResin3dPrinterStartPrintEventListener, IResin3dPrinterSetRecipeIdEventListener, IResin3dPrinterSetBusyEventListener, IResin3dPrinterItemRemovedEventListener, IResin3dPrinterRefillEventListener, IFreeFormStructureCreationValidatedListener, IPlayerRequestActorItemListener, IStructureCraftingNodeAddIngredientRejectedListener, IFreeFormStructureDamagedStatusListener, IFreeFormSwitchLightStateListener, IDismantleScrewStructureListener, IThrowHeldScrewStructureListener, IRainCatcherIsBusyListener, IRainCatcherRemoveWaterListener, IVailRagdollEventListener, IFreeFormSwitchStateListener, IBlobSyncConnectListener, IVailAttachItemEventListener, ICookingSpotIsBusyEventListener, ICookingBeginCookingEventListener, ICookingPotRemovedEventListener, ICookingUpdateVolumeEventListener, ISetPlayerSpawnPointListener, IRequestBannedPlayerListListener, IItemStorageIsBusyListener, IPlayerInteractionEventListener, IBossCutsceneEventListener
	{
		// Token: 0x06001FCB RID: 8139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FCB")]
		[Address(RVA = "0x802690", Offset = "0x800C90", VA = "0x180802690")]
		public GlobalEventListener()
		{
		}

		// Token: 0x06001FCC RID: 8140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FCC")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "213")]
		public virtual void OnEvent(PlaceConstruction evnt)
		{
		}

		// Token: 0x06001FCD RID: 8141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FCD")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "214")]
		public virtual void OnEvent(SetTreeHealth evnt)
		{
		}

		// Token: 0x06001FCE RID: 8142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FCE")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "215")]
		public virtual void OnEvent(DestroyPickUp evnt)
		{
		}

		// Token: 0x06001FCF RID: 8143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FCF")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "216")]
		public virtual void OnEvent(DropItem evnt)
		{
		}

		// Token: 0x06001FD0 RID: 8144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FD0")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "217")]
		public virtual void OnEvent(SpawnImpactEffect evnt)
		{
		}

		// Token: 0x06001FD1 RID: 8145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FD1")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "218")]
		public virtual void OnEvent(PlayerHitByEnemey evnt)
		{
		}

		// Token: 0x06001FD2 RID: 8146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FD2")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "219")]
		public virtual void OnEvent(ChatEvent evnt)
		{
		}

		// Token: 0x06001FD3 RID: 8147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FD3")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "220")]
		public virtual void OnEvent(PlayerHitEnemy evnt)
		{
		}

		// Token: 0x06001FD4 RID: 8148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FD4")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "221")]
		public virtual void OnEvent(HitPlayer evnt)
		{
		}

		// Token: 0x06001FD5 RID: 8149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FD5")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "222")]
		public virtual void OnEvent(SkinnedAnimal evnt)
		{
		}

		// Token: 0x06001FD6 RID: 8150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FD6")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "223")]
		public virtual void OnEvent(RequestDestroy evnt)
		{
		}

		// Token: 0x06001FD7 RID: 8151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FD7")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "224")]
		public virtual void OnEvent(FireCookEvent evnt)
		{
		}

		// Token: 0x06001FD8 RID: 8152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FD8")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "225")]
		public virtual void OnEvent(PlaneCrashIndex evnt)
		{
		}

		// Token: 0x06001FD9 RID: 8153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FD9")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "226")]
		public virtual void OnEvent(ItemHolderAddItem evnt)
		{
		}

		// Token: 0x06001FDA RID: 8154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FDA")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "227")]
		public virtual void OnEvent(ItemHolderTakeItem evnt)
		{
		}

		// Token: 0x06001FDB RID: 8155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FDB")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "228")]
		public virtual void OnEvent(SendMessageEvent evnt)
		{
		}

		// Token: 0x06001FDC RID: 8156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FDC")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "229")]
		public virtual void OnEvent(SpawnCutTree evnt)
		{
		}

		// Token: 0x06001FDD RID: 8157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FDD")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "230")]
		public virtual void OnEvent(FauxWeaponHit evnt)
		{
		}

		// Token: 0x06001FDE RID: 8158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FDE")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "231")]
		public virtual void OnEvent(SfxHammer evnt)
		{
		}

		// Token: 0x06001FDF RID: 8159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FDF")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "232")]
		public virtual void OnEvent(SfxEat evnt)
		{
		}

		// Token: 0x06001FE0 RID: 8160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FE0")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "233")]
		public virtual void OnEvent(SfxDrink evnt)
		{
		}

		// Token: 0x06001FE1 RID: 8161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FE1")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "234")]
		public virtual void OnEvent(SfxHurt evnt)
		{
		}

		// Token: 0x06001FE2 RID: 8162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FE2")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "235")]
		public virtual void OnEvent(SfxFallLight evnt)
		{
		}

		// Token: 0x06001FE3 RID: 8163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FE3")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "236")]
		public virtual void OnEvent(SfxFallHeavy evnt)
		{
		}

		// Token: 0x06001FE4 RID: 8164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FE4")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "237")]
		public virtual void OnEvent(FmodOneShot evnt)
		{
		}

		// Token: 0x06001FE5 RID: 8165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FE5")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "238")]
		public virtual void OnEvent(TrapResetEvent evnt)
		{
		}

		// Token: 0x06001FE6 RID: 8166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FE6")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "239")]
		public virtual void OnEvent(CancelBluePrint evnt)
		{
		}

		// Token: 0x06001FE7 RID: 8167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FE7")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "240")]
		public virtual void OnEvent(PlayerHealed evnt)
		{
		}

		// Token: 0x06001FE8 RID: 8168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FE8")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "241")]
		public virtual void OnEvent(RackAdd evnt)
		{
		}

		// Token: 0x06001FE9 RID: 8169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FE9")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "242")]
		public virtual void OnEvent(RackRemove evnt)
		{
		}

		// Token: 0x06001FEA RID: 8170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FEA")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "243")]
		public virtual void OnEvent(SetCorpsePosition evnt)
		{
		}

		// Token: 0x06001FEB RID: 8171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FEB")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "244")]
		public virtual void OnEvent(PlayerAddItem evnt)
		{
		}

		// Token: 0x06001FEC RID: 8172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FEC")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "245")]
		public virtual void OnEvent(PlaceFoundationEx evnt)
		{
		}

		// Token: 0x06001FED RID: 8173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FED")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "246")]
		public virtual void OnEvent(SledGrab evnt)
		{
		}

		// Token: 0x06001FEE RID: 8174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FEE")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "247")]
		public virtual void OnEvent(SledRelease evnt)
		{
		}

		// Token: 0x06001FEF RID: 8175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FEF")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "248")]
		public virtual void OnEvent(LocalizedHit evnt)
		{
		}

		// Token: 0x06001FF0 RID: 8176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FF0")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "249")]
		public virtual void OnEvent(ItemRemoveFromPlayer evnt)
		{
		}

		// Token: 0x06001FF1 RID: 8177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FF1")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "250")]
		public virtual void OnEvent(TripWire evnt)
		{
		}

		// Token: 0x06001FF2 RID: 8178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FF2")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "251")]
		public virtual void OnEvent(StealItem evnt)
		{
		}

		// Token: 0x06001FF3 RID: 8179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FF3")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "252")]
		public virtual void OnEvent(RaftGrab evnt)
		{
		}

		// Token: 0x06001FF4 RID: 8180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FF4")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "253")]
		public virtual void OnEvent(RaftRelease evnt)
		{
		}

		// Token: 0x06001FF5 RID: 8181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FF5")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "254")]
		public virtual void OnEvent(AddRepairMaterial evnt)
		{
		}

		// Token: 0x06001FF6 RID: 8182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FF6")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "255")]
		public virtual void OnEvent(PlaceRope evnt)
		{
		}

		// Token: 0x06001FF7 RID: 8183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FF7")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "256")]
		public virtual void OnEvent(Burn evnt)
		{
		}

		// Token: 0x06001FF8 RID: 8184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FF8")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "257")]
		public virtual void OnEvent(KeepAlive evnt)
		{
		}

		// Token: 0x06001FF9 RID: 8185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FF9")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "258")]
		public virtual void OnEvent(GardenPlotPlantSeed evnt)
		{
		}

		// Token: 0x06001FFA RID: 8186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FFA")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "259")]
		public virtual void OnEvent(RemoveWater evnt)
		{
		}

		// Token: 0x06001FFB RID: 8187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FFB")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "260")]
		public virtual void OnEvent(FmodOneShotParameter evnt)
		{
		}

		// Token: 0x06001FFC RID: 8188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FFC")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "261")]
		public virtual void OnEvent(AddBody evnt)
		{
		}

		// Token: 0x06001FFD RID: 8189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FFD")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "262")]
		public virtual void OnEvent(DestroyWithTag evnt)
		{
		}

		// Token: 0x06001FFE RID: 8190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FFE")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "263")]
		public virtual void OnEvent(DefaultClothPickedUp evnt)
		{
		}

		// Token: 0x06001FFF RID: 8191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FFF")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "264")]
		public virtual void OnEvent(ClientACK evnt)
		{
		}

		// Token: 0x06002000 RID: 8192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002000")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "265")]
		public virtual void OnEvent(TakeBody evnt)
		{
		}

		// Token: 0x06002001 RID: 8193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002001")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "266")]
		public virtual void OnEvent(TakeBodyApprove evnt)
		{
		}

		// Token: 0x06002002 RID: 8194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002002")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "267")]
		public virtual void OnEvent(AddItemToDoor evnt)
		{
		}

		// Token: 0x06002003 RID: 8195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002003")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "268")]
		public virtual void OnEvent(RaftControl evnt)
		{
		}

		// Token: 0x06002004 RID: 8196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002004")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "269")]
		public virtual void OnEvent(PushRaft evnt)
		{
		}

		// Token: 0x06002005 RID: 8197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002005")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "270")]
		public virtual void OnEvent(PickupRequest evnt)
		{
		}

		// Token: 0x06002006 RID: 8198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002006")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "271")]
		public virtual void OnEvent(PickupApproved evnt)
		{
		}

		// Token: 0x06002007 RID: 8199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002007")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "272")]
		public virtual void OnEvent(PlaceTrophy evnt)
		{
		}

		// Token: 0x06002008 RID: 8200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002008")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "273")]
		public virtual void OnEvent(CutTriggerActivated evnt)
		{
		}

		// Token: 0x06002009 RID: 8201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002009")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "274")]
		public virtual void OnEvent(AdminCommand evnt)
		{
		}

		// Token: 0x0600200A RID: 8202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600200A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "275")]
		public virtual void OnEvent(AdminAuthed evnt)
		{
		}

		// Token: 0x0600200B RID: 8203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600200B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "276")]
		public virtual void OnEvent(ragdollActivate evnt)
		{
		}

		// Token: 0x0600200C RID: 8204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600200C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "277")]
		public virtual void OnEvent(DisablePickup evnt)
		{
		}

		// Token: 0x0600200D RID: 8205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600200D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "278")]
		public virtual void OnEvent(PlayerRemoveItem evnt)
		{
		}

		// Token: 0x0600200E RID: 8206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600200E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "279")]
		public virtual void OnEvent(doReleaseFromTrap evnt)
		{
		}

		// Token: 0x0600200F RID: 8207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600200F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "280")]
		public virtual void OnEvent(DropBodyEvent evnt)
		{
		}

		// Token: 0x06002010 RID: 8208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002010")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "281")]
		public virtual void OnEvent(Sleep evnt)
		{
		}

		// Token: 0x06002011 RID: 8209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002011")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "282")]
		public virtual void OnEvent(SetGuiTextureColor evnt)
		{
		}

		// Token: 0x06002012 RID: 8210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002012")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "283")]
		public virtual void OnEvent(PlaceDryingFood evnt)
		{
		}

		// Token: 0x06002013 RID: 8211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002013")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "284")]
		public virtual void OnEvent(RequestMecanimSync evnt)
		{
		}

		// Token: 0x06002014 RID: 8212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002014")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "285")]
		public virtual void OnEvent(updateMecanimRemoteState evnt)
		{
		}

		// Token: 0x06002015 RID: 8213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002015")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "286")]
		public virtual void OnEvent(EndCrash evnt)
		{
		}

		// Token: 0x06002016 RID: 8214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002016")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "287")]
		public virtual void OnEvent(RequestAnimationSequenceProxy evnt)
		{
		}

		// Token: 0x06002017 RID: 8215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002017")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "288")]
		public virtual void OnEvent(BeginAnimationSequenceStage evnt)
		{
		}

		// Token: 0x06002018 RID: 8216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002018")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "289")]
		public virtual void OnEvent(ProgressAnimationSequenceStage evnt)
		{
		}

		// Token: 0x06002019 RID: 8217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002019")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "290")]
		public virtual void OnEvent(CompleteAnimationSequenceStage evnt)
		{
		}

		// Token: 0x0600201A RID: 8218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600201A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "291")]
		public virtual void OnEvent(stuckArrowsSync evnt)
		{
		}

		// Token: 0x0600201B RID: 8219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600201B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "292")]
		public virtual void OnEvent(debugCommand evnt)
		{
		}

		// Token: 0x0600201C RID: 8220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600201C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "293")]
		public virtual void OnEvent(syncWorkBench evnt)
		{
		}

		// Token: 0x0600201D RID: 8221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600201D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "294")]
		public virtual void OnEvent(SetMasterClient evnt)
		{
		}

		// Token: 0x0600201E RID: 8222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600201E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "295")]
		public virtual void OnEvent(ServerStatusInfo evnt)
		{
		}

		// Token: 0x0600201F RID: 8223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600201F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "296")]
		public virtual void OnEvent(loadEndGamePrefabs evnt)
		{
		}

		// Token: 0x06002020 RID: 8224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002020")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "297")]
		public virtual void OnEvent(SetTrappedEnemy evnt)
		{
		}

		// Token: 0x06002021 RID: 8225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002021")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "298")]
		public virtual void OnEvent(TriggerFishTrap evnt)
		{
		}

		// Token: 0x06002022 RID: 8226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002022")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "299")]
		public virtual void OnEvent(ValidSleepTime evnt)
		{
		}

		// Token: 0x06002023 RID: 8227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002023")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "300")]
		public virtual void OnEvent(arrowFireSync evnt)
		{
		}

		// Token: 0x06002024 RID: 8228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002024")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "301")]
		public virtual void OnEvent(SetJoiningTimeOfDay evnt)
		{
		}

		// Token: 0x06002025 RID: 8229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002025")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "302")]
		public virtual void OnEvent(TakeClothingOutfit evnt)
		{
		}

		// Token: 0x06002026 RID: 8230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002026")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "303")]
		public virtual void OnEvent(PickupGlider evnt)
		{
		}

		// Token: 0x06002027 RID: 8231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002027")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "304")]
		public virtual void OnEvent(FreeFormStructureCreated evnt)
		{
		}

		// Token: 0x06002028 RID: 8232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002028")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "305")]
		public virtual void OnEvent(FreeFormStructureDestroyed evnt)
		{
		}

		// Token: 0x06002029 RID: 8233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002029")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "306")]
		public virtual void OnEvent(FreeFormStructureEditedTransform evnt)
		{
		}

		// Token: 0x0600202A RID: 8234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600202A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "307")]
		public virtual void OnEvent(FreeFormRequestAllData evnt)
		{
		}

		// Token: 0x0600202B RID: 8235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600202B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "308")]
		public virtual void OnEvent(FreeFormStructureCascadeRepositionSupported evnt)
		{
		}

		// Token: 0x0600202C RID: 8236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600202C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "309")]
		public virtual void OnEvent(FreeFormStructureEditedElements evnt)
		{
		}

		// Token: 0x0600202D RID: 8237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600202D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "310")]
		public virtual void OnEvent(FreeFormStructureEditedLinks evnt)
		{
		}

		// Token: 0x0600202E RID: 8238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600202E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "311")]
		public virtual void OnEvent(VailHitEvent evnt)
		{
		}

		// Token: 0x0600202F RID: 8239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600202F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "312")]
		public virtual void OnEvent(VailNoiseEvent evnt)
		{
		}

		// Token: 0x06002030 RID: 8240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002030")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "313")]
		public virtual void OnEvent(PlayerFireWeaponEvent evnt)
		{
		}

		// Token: 0x06002031 RID: 8241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002031")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "314")]
		public virtual void OnEvent(WorldObjectLocatorState evnt)
		{
		}

		// Token: 0x06002032 RID: 8242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002032")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "315")]
		public virtual void OnEvent(RobbyOrderEvent evnt)
		{
		}

		// Token: 0x06002033 RID: 8243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002033")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "316")]
		public virtual void OnEvent(WorldObjectLocatorRequestAllData evnt)
		{
		}

		// Token: 0x06002034 RID: 8244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002034")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "317")]
		public virtual void OnEvent(StorageContainerOpened evnt)
		{
		}

		// Token: 0x06002035 RID: 8245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002035")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "318")]
		public virtual void OnEvent(PlayerConnectivityAction evnt)
		{
		}

		// Token: 0x06002036 RID: 8246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002036")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "319")]
		public virtual void OnEvent(StructureCraftingNodeCancel evnt)
		{
		}

		// Token: 0x06002037 RID: 8247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002037")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "320")]
		public virtual void OnEvent(StructureCraftingNodeAddIngredient evnt)
		{
		}

		// Token: 0x06002038 RID: 8248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002038")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "321")]
		public virtual void OnEvent(StructureCraftingNodeComplete evnt)
		{
		}

		// Token: 0x06002039 RID: 8249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002039")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "322")]
		public virtual void OnEvent(FreeFormStructureRejected evnt)
		{
		}

		// Token: 0x0600203A RID: 8250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600203A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "323")]
		public virtual void OnEvent(FireLightEvent evnt)
		{
		}

		// Token: 0x0600203B RID: 8251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600203B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "324")]
		public virtual void OnEvent(BreakableObjectBroken evnt)
		{
		}

		// Token: 0x0600203C RID: 8252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600203C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "325")]
		public virtual void OnEvent(DismemberHitEvent evnt)
		{
		}

		// Token: 0x0600203D RID: 8253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600203D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "326")]
		public virtual void OnEvent(PickupBodyEvent evnt)
		{
		}

		// Token: 0x0600203E RID: 8254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600203E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "327")]
		public virtual void OnEvent(FreeFormPlaceElement evnt)
		{
		}

		// Token: 0x0600203F RID: 8255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600203F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "328")]
		public virtual void OnEvent(SpawnLootItemEvent evnt)
		{
		}

		// Token: 0x06002040 RID: 8256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002040")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "329")]
		public virtual void OnEvent(RadioActivate evnt)
		{
		}

		// Token: 0x06002041 RID: 8257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002041")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "330")]
		public virtual void OnEvent(HitEngineEvent evnt)
		{
		}

		// Token: 0x06002042 RID: 8258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002042")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "331")]
		public virtual void OnEvent(CaveBoardBroken evnt)
		{
		}

		// Token: 0x06002043 RID: 8259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002043")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "332")]
		public virtual void OnEvent(VailZoneStateEvent evnt)
		{
		}

		// Token: 0x06002044 RID: 8260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002044")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "333")]
		public virtual void OnEvent(DwGateOpenEvent evnt)
		{
		}

		// Token: 0x06002045 RID: 8261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002045")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "334")]
		public virtual void OnEvent(DwGateCloseEvent evnt)
		{
		}

		// Token: 0x06002046 RID: 8262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002046")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "335")]
		public virtual void OnEvent(ActivateVailActor evnt)
		{
		}

		// Token: 0x06002047 RID: 8263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002047")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "336")]
		public virtual void OnEvent(VailThrowBodyEvent evnt)
		{
		}

		// Token: 0x06002048 RID: 8264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002048")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "337")]
		public virtual void OnEvent(JumpTimeEvent evnt)
		{
		}

		// Token: 0x06002049 RID: 8265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002049")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "338")]
		public virtual void OnEvent(GardenPlotIsBusy evnt)
		{
		}

		// Token: 0x0600204A RID: 8266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600204A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "339")]
		public virtual void OnEvent(VailParriedEvent evnt)
		{
		}

		// Token: 0x0600204B RID: 8267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600204B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "340")]
		public virtual void OnEvent(VailRequestVillageData evnt)
		{
		}

		// Token: 0x0600204C RID: 8268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600204C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "341")]
		public virtual void OnEvent(AttachItemToZiplineEvent evnt)
		{
		}

		// Token: 0x0600204D RID: 8269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600204D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "342")]
		public virtual void OnEvent(StructureCraftingNodeCreate evnt)
		{
		}

		// Token: 0x0600204E RID: 8270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600204E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "343")]
		public virtual void OnEvent(TerrainDigNodeAdded evnt)
		{
		}

		// Token: 0x0600204F RID: 8271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600204F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "344")]
		public virtual void OnEvent(PlayerGiveActorItem evnt)
		{
		}

		// Token: 0x06002050 RID: 8272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002050")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "345")]
		public virtual void OnEvent(ItemStorageAddItemEvent evnt)
		{
		}

		// Token: 0x06002051 RID: 8273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002051")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "346")]
		public virtual void OnEvent(ItemStorageRemoveItemEvent evnt)
		{
		}

		// Token: 0x06002052 RID: 8274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002052")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "347")]
		public virtual void OnEvent(ActorInteractEvent evnt)
		{
		}

		// Token: 0x06002053 RID: 8275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002053")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "348")]
		public virtual void OnEvent(ChangeIdObjectState evnt)
		{
		}

		// Token: 0x06002054 RID: 8276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002054")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "349")]
		public virtual void OnEvent(ZiplineCreateEvent evnt)
		{
		}

		// Token: 0x06002055 RID: 8277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002055")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "350")]
		public virtual void OnEvent(ZiplineRemoveEvent evnt)
		{
		}

		// Token: 0x06002056 RID: 8278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002056")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "351")]
		public virtual void OnEvent(FireStokeEvent evnt)
		{
		}

		// Token: 0x06002057 RID: 8279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002057")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "352")]
		public virtual void OnEvent(VailReviveEvent evnt)
		{
		}

		// Token: 0x06002058 RID: 8280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002058")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "353")]
		public virtual void OnEvent(DeathMarkerRequest evnt)
		{
		}

		// Token: 0x06002059 RID: 8281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002059")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "354")]
		public virtual void OnEvent(GardenPlotClearPlot evnt)
		{
		}

		// Token: 0x0600205A RID: 8282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600205A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "355")]
		public virtual void OnEvent(FreeFormPlayerFinishedAnim evnt)
		{
		}

		// Token: 0x0600205B RID: 8283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600205B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "356")]
		public virtual void OnEvent(TrapActivateEvent evnt)
		{
		}

		// Token: 0x0600205C RID: 8284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600205C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "357")]
		public virtual void OnEvent(Resin3dPrinterStartPrintEvent evnt)
		{
		}

		// Token: 0x0600205D RID: 8285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600205D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "358")]
		public virtual void OnEvent(Resin3dPrinterSetRecipeIdEvent evnt)
		{
		}

		// Token: 0x0600205E RID: 8286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600205E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "359")]
		public virtual void OnEvent(Resin3dPrinterSetBusyEvent evnt)
		{
		}

		// Token: 0x0600205F RID: 8287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600205F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "360")]
		public virtual void OnEvent(Resin3dPrinterItemRemovedEvent evnt)
		{
		}

		// Token: 0x06002060 RID: 8288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002060")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "361")]
		public virtual void OnEvent(Resin3dPrinterRefillEvent evnt)
		{
		}

		// Token: 0x06002061 RID: 8289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002061")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "362")]
		public virtual void OnEvent(FreeFormStructureCreationValidated evnt)
		{
		}

		// Token: 0x06002062 RID: 8290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002062")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "363")]
		public virtual void OnEvent(PlayerRequestActorItem evnt)
		{
		}

		// Token: 0x06002063 RID: 8291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002063")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "364")]
		public virtual void OnEvent(StructureCraftingNodeAddIngredientRejected evnt)
		{
		}

		// Token: 0x06002064 RID: 8292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002064")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "365")]
		public virtual void OnEvent(FreeFormStructureDamagedStatus evnt)
		{
		}

		// Token: 0x06002065 RID: 8293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002065")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "366")]
		public virtual void OnEvent(FreeFormSwitchLightState evnt)
		{
		}

		// Token: 0x06002066 RID: 8294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002066")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "367")]
		public virtual void OnEvent(DismantleScrewStructure evnt)
		{
		}

		// Token: 0x06002067 RID: 8295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002067")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "368")]
		public virtual void OnEvent(ThrowHeldScrewStructure evnt)
		{
		}

		// Token: 0x06002068 RID: 8296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002068")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "369")]
		public virtual void OnEvent(RainCatcherIsBusy evnt)
		{
		}

		// Token: 0x06002069 RID: 8297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002069")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "370")]
		public virtual void OnEvent(RainCatcherRemoveWater evnt)
		{
		}

		// Token: 0x0600206A RID: 8298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600206A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "371")]
		public virtual void OnEvent(VailRagdollEvent evnt)
		{
		}

		// Token: 0x0600206B RID: 8299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600206B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "372")]
		public virtual void OnEvent(FreeFormSwitchState evnt)
		{
		}

		// Token: 0x0600206C RID: 8300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600206C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "373")]
		public virtual void OnEvent(BlobSyncConnect evnt)
		{
		}

		// Token: 0x0600206D RID: 8301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600206D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "374")]
		public virtual void OnEvent(VailAttachItemEvent evnt)
		{
		}

		// Token: 0x0600206E RID: 8302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600206E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "375")]
		public virtual void OnEvent(CookingSpotIsBusyEvent evnt)
		{
		}

		// Token: 0x0600206F RID: 8303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600206F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "376")]
		public virtual void OnEvent(CookingBeginCookingEvent evnt)
		{
		}

		// Token: 0x06002070 RID: 8304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002070")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "377")]
		public virtual void OnEvent(CookingPotRemovedEvent evnt)
		{
		}

		// Token: 0x06002071 RID: 8305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002071")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "378")]
		public virtual void OnEvent(CookingUpdateVolumeEvent evnt)
		{
		}

		// Token: 0x06002072 RID: 8306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002072")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "379")]
		public virtual void OnEvent(SetPlayerSpawnPoint evnt)
		{
		}

		// Token: 0x06002073 RID: 8307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002073")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "380")]
		public virtual void OnEvent(RequestBannedPlayerList evnt)
		{
		}

		// Token: 0x06002074 RID: 8308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002074")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "381")]
		public virtual void OnEvent(ItemStorageIsBusy evnt)
		{
		}

		// Token: 0x06002075 RID: 8309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002075")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "382")]
		public virtual void OnEvent(PlayerInteractionEvent evnt)
		{
		}

		// Token: 0x06002076 RID: 8310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002076")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "383")]
		public virtual void OnEvent(BossCutsceneEvent evnt)
		{
		}
	}
}
