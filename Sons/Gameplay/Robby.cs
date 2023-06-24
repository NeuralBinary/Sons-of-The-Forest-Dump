using System;
using System.Collections;
using System.Collections.Generic;
using Bolt;
using FMODUnity;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Sirenix.OdinInspector;
using Sons.Ai.Vail;
using Sons.Ai.Vail.StimuliTypes;
using Sons.Animation;
using Sons.Gameplay.GrabBag;
using Sons.Gui;
using Sons.TerrainDetail;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x020007CF RID: 1999
	[Token(Token = "0x20007CF")]
	public class Robby : EntityEventListener<IRobbyActorState>, IRobbyCallbacks
	{
		// Token: 0x060035F5 RID: 13813 RVA: 0x00010200 File Offset: 0x0000E400
		[Token(Token = "0x60035F5")]
		[Address(RVA = "0x34ED5F0", Offset = "0x34EBBF0", VA = "0x1834ED5F0", Slot = "331")]
		private bool IsCurrentBuildStimuli(BuildActionStimuli stimuli)
		{
			return default(bool);
		}

		// Token: 0x060035F6 RID: 13814 RVA: 0x00010218 File Offset: 0x0000E418
		[Token(Token = "0x60035F6")]
		[Address(RVA = "0x34ED720", Offset = "0x34EBD20", VA = "0x1834ED720", Slot = "329")]
		public int GetItemNeededCount(string itemType)
		{
			return 0;
		}

		// Token: 0x060035F7 RID: 13815 RVA: 0x00010230 File Offset: 0x0000E430
		[Token(Token = "0x60035F7")]
		[Address(RVA = "0x34ED830", Offset = "0x34EBE30", VA = "0x1834ED830", Slot = "330")]
		private bool ShouldPlaceCarriedItems()
		{
			return default(bool);
		}

		// Token: 0x060035F8 RID: 13816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035F8")]
		[Address(RVA = "0x34EDD70", Offset = "0x34EC370", VA = "0x1834EDD70")]
		private BuildActionStimuli FindExistingBuildStimuli(Robby.RobbyBuildOrder buildOrder)
		{
			return null;
		}

		// Token: 0x060035F9 RID: 13817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035F9")]
		[Address(RVA = "0x34EE290", Offset = "0x34EC890", VA = "0x1834EE290")]
		private void StartBuildOrder(Robby.RobbyBuildOrder buildOrder, Transform fromPlayer)
		{
		}

		// Token: 0x060035FA RID: 13818 RVA: 0x00010248 File Offset: 0x0000E448
		[Token(Token = "0x60035FA")]
		[Address(RVA = "0x34EEB40", Offset = "0x34ED140", VA = "0x1834EEB40")]
		private static bool FindBuildPosition(Vector3 centerPosition, Vector3 offsetVec, float checkRadius, out Vector3 buildPos)
		{
			return default(bool);
		}

		// Token: 0x060035FB RID: 13819 RVA: 0x00010260 File Offset: 0x0000E460
		[Token(Token = "0x60035FB")]
		[Address(RVA = "0x34EED70", Offset = "0x34ED370", VA = "0x1834EED70")]
		private static bool ValidateBuildLocation(Vector3 testPos, float checkRadius, out Vector3 groundPos)
		{
			return default(bool);
		}

		// Token: 0x060035FC RID: 13820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035FC")]
		[Address(RVA = "0x34EF120", Offset = "0x34ED720", VA = "0x1834EF120")]
		private void UpdateBuildOrder(Robby.RunningRobbyOrder runningOrder)
		{
		}

		// Token: 0x060035FD RID: 13821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035FD")]
		[Address(RVA = "0x34EF3A0", Offset = "0x34ED9A0", VA = "0x1834EF3A0")]
		private static void OrientBuiltObject(BuildActionStimuli stimuli, Vector3 centerPosition)
		{
		}

		// Token: 0x060035FE RID: 13822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035FE")]
		[Address(RVA = "0x34EF790", Offset = "0x34EDD90", VA = "0x1834EF790")]
		private void DrawBuildGizmos()
		{
		}

		// Token: 0x060035FF RID: 13823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035FF")]
		[Address(RVA = "0x34EFC50", Offset = "0x34EE250", VA = "0x1834EFC50")]
		private void OnValidate()
		{
		}

		// Token: 0x06003600 RID: 13824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003600")]
		[Address(RVA = "0x34EFE90", Offset = "0x34EE490", VA = "0x1834EFE90")]
		private void Awake()
		{
		}

		// Token: 0x06003601 RID: 13825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003601")]
		[Address(RVA = "0x34F0590", Offset = "0x34EEB90", VA = "0x1834F0590")]
		private void Start()
		{
		}

		// Token: 0x06003602 RID: 13826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003602")]
		[Address(RVA = "0x34F08F0", Offset = "0x34EEEF0", VA = "0x1834F08F0")]
		private void Update()
		{
		}

		// Token: 0x06003603 RID: 13827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003603")]
		[Address(RVA = "0x34F0AE0", Offset = "0x34EF0E0", VA = "0x1834F0AE0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06003604 RID: 13828 RVA: 0x00010278 File Offset: 0x0000E478
		[Token(Token = "0x6003604")]
		[Address(RVA = "0x34F0CB0", Offset = "0x34EF2B0", VA = "0x1834F0CB0")]
		private int GetItemCount(int itemId)
		{
			return 0;
		}

		// Token: 0x06003605 RID: 13829 RVA: 0x00010290 File Offset: 0x0000E490
		[Token(Token = "0x6003605")]
		[Address(RVA = "0x34F0CE0", Offset = "0x34EF2E0", VA = "0x1834F0CE0")]
		private bool HasItem(int itemId)
		{
			return default(bool);
		}

		// Token: 0x06003606 RID: 13830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003606")]
		[Address(RVA = "0x34F0D20", Offset = "0x34EF320", VA = "0x1834F0D20", Slot = "332")]
		public void AdjustItemCount(int itemId, int delta)
		{
		}

		// Token: 0x06003607 RID: 13831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003607")]
		[Address(RVA = "0x34F0DA0", Offset = "0x34EF3A0", VA = "0x1834F0DA0")]
		[ContextMenu("Log Tarp Count")]
		private void LogTarpCount()
		{
		}

		// Token: 0x06003608 RID: 13832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003608")]
		[Address(RVA = "0x34F0E70", Offset = "0x34EF470", VA = "0x1834F0E70")]
		private void SetInjuredState(Robby.InjuredState newState)
		{
		}

		// Token: 0x06003609 RID: 13833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003609")]
		[Address(RVA = "0x34F1200", Offset = "0x34EF800", VA = "0x1834F1200")]
		public void SetPlayerRaceAndClothing(int race, List<int> clothingIds)
		{
		}

		// Token: 0x0600360A RID: 13834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600360A")]
		[Address(RVA = "0x34F14E0", Offset = "0x34EFAE0", VA = "0x1834F14E0")]
		private void OnRace()
		{
		}

		// Token: 0x0600360B RID: 13835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600360B")]
		[Address(RVA = "0x34F1640", Offset = "0x34EFC40", VA = "0x1834F1640")]
		private void OnClothingIds()
		{
		}

		// Token: 0x0600360C RID: 13836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600360C")]
		[Address(RVA = "0x34F17A0", Offset = "0x34EFDA0", VA = "0x1834F17A0")]
		private void OnGrabEnter()
		{
		}

		// Token: 0x0600360D RID: 13837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600360D")]
		[Address(RVA = "0x34F17B0", Offset = "0x34EFDB0", VA = "0x1834F17B0")]
		private void OnGrabExit()
		{
		}

		// Token: 0x0600360E RID: 13838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600360E")]
		[Address(RVA = "0x34F17C0", Offset = "0x34EFDC0", VA = "0x1834F17C0")]
		private void UpdateAnimationVars()
		{
		}

		// Token: 0x0600360F RID: 13839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600360F")]
		[Address(RVA = "0x34F1C00", Offset = "0x34F0200", VA = "0x1834F1C00")]
		private void SetItemParent(Transform child, Transform newParent, Quaternion rotation)
		{
		}

		// Token: 0x06003610 RID: 13840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003610")]
		[Address(RVA = "0x34F1DE0", Offset = "0x34F03E0", VA = "0x1834F1DE0")]
		private void ServerCheckAxeVisibility()
		{
		}

		// Token: 0x06003611 RID: 13841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003611")]
		[Address(RVA = "0x34F2080", Offset = "0x34F0680", VA = "0x1834F2080")]
		private void OnShowAxeChanged()
		{
		}

		// Token: 0x06003612 RID: 13842 RVA: 0x000102A8 File Offset: 0x0000E4A8
		[Token(Token = "0x6003612")]
		[Address(RVA = "0x34F2170", Offset = "0x34F0770", VA = "0x1834F2170")]
		private bool CheckInteractConditions()
		{
			return default(bool);
		}

		// Token: 0x06003613 RID: 13843 RVA: 0x000102C0 File Offset: 0x0000E4C0
		[Token(Token = "0x6003613")]
		[Address(RVA = "0x34F24F0", Offset = "0x34F0AF0", VA = "0x1834F24F0")]
		private bool IsAlive()
		{
			return default(bool);
		}

		// Token: 0x06003614 RID: 13844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003614")]
		[Address(RVA = "0x34F2530", Offset = "0x34F0B30", VA = "0x1834F2530")]
		private void CheckInjuredInteraction()
		{
		}

		// Token: 0x06003615 RID: 13845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003615")]
		[Address(RVA = "0x34F2660", Offset = "0x34F0C60", VA = "0x1834F2660")]
		private void ServerUpdate()
		{
		}

		// Token: 0x06003616 RID: 13846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003616")]
		[Address(RVA = "0x34F26A0", Offset = "0x34F0CA0", VA = "0x1834F26A0")]
		private void EnableActorCollisionAndLook(bool value)
		{
		}

		// Token: 0x06003617 RID: 13847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003617")]
		[Address(RVA = "0x34F27F0", Offset = "0x34F0DF0", VA = "0x1834F27F0", Slot = "16")]
		public override void Attached()
		{
		}

		// Token: 0x06003618 RID: 13848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003618")]
		[Address(RVA = "0x34F2AB0", Offset = "0x34F10B0", VA = "0x1834F2AB0")]
		private void OnInjuredStateChanged()
		{
		}

		// Token: 0x06003619 RID: 13849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003619")]
		[Address(RVA = "0x34F2B50", Offset = "0x34F1150", VA = "0x1834F2B50")]
		private void SetActiveOverride(VailControllerOverride newOverride)
		{
		}

		// Token: 0x0600361A RID: 13850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600361A")]
		[Address(RVA = "0x34F2E00", Offset = "0x34F1400", VA = "0x1834F2E00")]
		private void UpdateShoulderTap()
		{
		}

		// Token: 0x0600361B RID: 13851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600361B")]
		[Address(RVA = "0x34F2F00", Offset = "0x34F1500", VA = "0x1834F2F00")]
		private void ServerCheckHelpUpFinished()
		{
		}

		// Token: 0x0600361C RID: 13852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600361C")]
		[Address(RVA = "0x34F3180", Offset = "0x34F1780", VA = "0x1834F3180")]
		private void ClearRobbyOrderHashes()
		{
		}

		// Token: 0x0600361D RID: 13853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600361D")]
		[Address(RVA = "0x34F34A0", Offset = "0x34F1AA0", VA = "0x1834F34A0")]
		private void DoRobbyAnimatorPadRaiseTransition()
		{
		}

		// Token: 0x0600361E RID: 13854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600361E")]
		[Address(RVA = "0x34F35C0", Offset = "0x34F1BC0", VA = "0x1834F35C0")]
		private void DoRobbyAnimatorPadLowerTransition()
		{
		}

		// Token: 0x0600361F RID: 13855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600361F")]
		[Address(RVA = "0x34F36E0", Offset = "0x34F1CE0", VA = "0x1834F36E0")]
		private void DoRobbyAnimatorFinishOrdersTransition(bool giveNote, bool longNote)
		{
		}

		// Token: 0x06003620 RID: 13856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003620")]
		[Address(RVA = "0x34F38E0", Offset = "0x34F1EE0", VA = "0x1834F38E0")]
		private void DropNow()
		{
		}

		// Token: 0x06003621 RID: 13857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003621")]
		[Address(RVA = "0x34F3940", Offset = "0x34F1F40", VA = "0x1834F3940")]
		private void ServerStartTakingOrders(PlayerStimuli playerStimuli)
		{
		}

		// Token: 0x06003622 RID: 13858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003622")]
		[Address(RVA = "0x34F3BF0", Offset = "0x34F21F0", VA = "0x1834F3BF0")]
		private void ServerStopTakingOrders()
		{
		}

		// Token: 0x06003623 RID: 13859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003623")]
		[Address(RVA = "0x34F3D20", Offset = "0x34F2320", VA = "0x1834F3D20")]
		private void SetControllerOverride(VailControllerOverride newOverride)
		{
		}

		// Token: 0x06003624 RID: 13860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003624")]
		[Address(RVA = "0x34F3E10", Offset = "0x34F2410", VA = "0x1834F3E10")]
		private static string Localized(string localizedKey)
		{
			return null;
		}

		// Token: 0x06003625 RID: 13861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003625")]
		private void AddOrderListUI<T>(Robby.CarouselName carouselId, List<T> orderList, Robby.CarouselName nextCarouselId = Robby.CarouselName.None) where T : Robby.RobbyOrder
		{
		}

		// Token: 0x06003626 RID: 13862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003626")]
		[Address(RVA = "0x34F4000", Offset = "0x34F2600", VA = "0x1834F4000")]
		private void AddMenuItem(Robby.CarouselName carouselId, int optionId, string text, Robby.CarouselName nextCarouselId = Robby.CarouselName.None)
		{
		}

		// Token: 0x06003627 RID: 13863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003627")]
		[Address(RVA = "0x34F40A0", Offset = "0x34F26A0", VA = "0x1834F40A0")]
		private void BuildTactipadUI()
		{
		}

		// Token: 0x06003628 RID: 13864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003628")]
		[Address(RVA = "0x34F44B0", Offset = "0x34F2AB0", VA = "0x1834F44B0")]
		private void PreShowCarousel(int carouselId)
		{
		}

		// Token: 0x06003629 RID: 13865 RVA: 0x000102D8 File Offset: 0x0000E4D8
		[Token(Token = "0x6003629")]
		[Address(RVA = "0x34F48A0", Offset = "0x34F2EA0", VA = "0x1834F48A0")]
		private bool IsStimuliInRange(string stimuliTypeStr, float maxRange)
		{
			return default(bool);
		}

		// Token: 0x0600362A RID: 13866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600362A")]
		[Address(RVA = "0x34F49F0", Offset = "0x34F2FF0", VA = "0x1834F49F0")]
		private void InitializeOrderStimuli()
		{
		}

		// Token: 0x0600362B RID: 13867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600362B")]
		private void InitRobbyStimuli<T>(out T stimuli, string objName) where T : RobbyOrderStimuliBase
		{
		}

		// Token: 0x0600362C RID: 13868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600362C")]
		[Address(RVA = "0x34F4C10", Offset = "0x34F3210", VA = "0x1834F4C10")]
		private void DestroyOrderStimuli()
		{
		}

		// Token: 0x0600362D RID: 13869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600362D")]
		[Address(RVA = "0x34F4C80", Offset = "0x34F3280", VA = "0x1834F4C80")]
		private void ClearOrderStimuli()
		{
		}

		// Token: 0x0600362E RID: 13870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600362E")]
		[Address(RVA = "0x34F4F10", Offset = "0x34F3510", VA = "0x1834F4F10")]
		private void DestroyInstance(Component instance)
		{
		}

		// Token: 0x0600362F RID: 13871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600362F")]
		[Address(RVA = "0x34F5030", Offset = "0x34F3630", VA = "0x1834F5030")]
		private void RunOrder(Robby.RobbyOrder order, Transform fromPlayer, int subOrderType2 = 0)
		{
		}

		// Token: 0x06003630 RID: 13872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003630")]
		[Address(RVA = "0x34F5810", Offset = "0x34F3E10", VA = "0x1834F5810")]
		public void ServerReceiveOrderFromClient(RobbyOrderEvent evt)
		{
		}

		// Token: 0x06003631 RID: 13873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003631")]
		[Address(RVA = "0x34F5C20", Offset = "0x34F4220", VA = "0x1834F5C20")]
		public void ClientReceivedOrderEvent(RobbyOrderEvent evt)
		{
		}

		// Token: 0x06003632 RID: 13874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003632")]
		[Address(RVA = "0x34F5E80", Offset = "0x34F4480", VA = "0x1834F5E80")]
		private void ClientSendOrders(Robby.OrderType orderType, int subOrderType, int subOrderType2)
		{
		}

		// Token: 0x06003633 RID: 13875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003633")]
		[Address(RVA = "0x34F61D0", Offset = "0x34F47D0", VA = "0x1834F61D0")]
		private void SendOrderEvent(Robby.OrderEventType orderEventType, GlobalTargets targets)
		{
		}

		// Token: 0x06003634 RID: 13876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003634")]
		[Address(RVA = "0x34F6370", Offset = "0x34F4970", VA = "0x1834F6370")]
		public void ServerGiveOrders(Robby.OrderType orderType, int subOrderType, int subOrderType2, Transform fromPlayer)
		{
		}

		// Token: 0x06003635 RID: 13877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003635")]
		[Address(RVA = "0x34F6680", Offset = "0x34F4C80", VA = "0x1834F6680")]
		private void OnGiveOrderServer(Robby.OrderType orderType, int subOrderType, int subOrderType2, Transform fromPlayer)
		{
		}

		// Token: 0x06003636 RID: 13878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003636")]
		[Address(RVA = "0x34F6AB0", Offset = "0x34F50B0", VA = "0x1834F6AB0")]
		private void OnOrderCompleted(bool restartAfterRest = false)
		{
		}

		// Token: 0x06003637 RID: 13879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003637")]
		[Address(RVA = "0x34F6D00", Offset = "0x34F5300", VA = "0x1834F6D00")]
		private void OnOrderRefused(Transform fromPlayer)
		{
		}

		// Token: 0x06003638 RID: 13880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003638")]
		[Address(RVA = "0x34F6E70", Offset = "0x34F5470", VA = "0x1834F6E70", Slot = "327")]
		private void OnCompletedReaction()
		{
		}

		// Token: 0x06003639 RID: 13881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003639")]
		[Address(RVA = "0x34F6F80", Offset = "0x34F5580", VA = "0x1834F6F80", Slot = "328")]
		public void OnCompletedOrder()
		{
		}

		// Token: 0x0600363A RID: 13882 RVA: 0x000102F0 File Offset: 0x0000E4F0
		[Token(Token = "0x600363A")]
		[Address(RVA = "0x34F7150", Offset = "0x34F5750", VA = "0x1834F7150")]
		private Vector3 GetActivePlayerPos()
		{
			return default(Vector3);
		}

		// Token: 0x0600363B RID: 13883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600363B")]
		[Address(RVA = "0x34F73D0", Offset = "0x34F59D0", VA = "0x1834F73D0")]
		private void ServerUpdateWaitingForOrders()
		{
		}

		// Token: 0x0600363C RID: 13884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600363C")]
		[Address(RVA = "0x34F76F0", Offset = "0x34F5CF0", VA = "0x1834F76F0")]
		private void ServerUpdateOrders()
		{
		}

		// Token: 0x0600363D RID: 13885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600363D")]
		[Address(RVA = "0x34F7E60", Offset = "0x34F6460", VA = "0x1834F7E60")]
		private void StartEquipOrderServer(Transform fromPlayer)
		{
		}

		// Token: 0x0600363E RID: 13886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600363E")]
		[Address(RVA = "0x34F7FC0", Offset = "0x34F65C0", VA = "0x1834F7FC0")]
		private void LocalPlayerOpenGrabBag()
		{
		}

		// Token: 0x0600363F RID: 13887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600363F")]
		[Address(RVA = "0x34F8080", Offset = "0x34F6680", VA = "0x1834F8080")]
		private void StartGetItemOrder(Robby.RobbyGetOrder getOrder, Transform fromPlayer, Robby.DropLocationType orderDropLocation)
		{
		}

		// Token: 0x06003640 RID: 13888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003640")]
		[Address(RVA = "0x34F8430", Offset = "0x34F6A30", VA = "0x1834F8430", Slot = "325")]
		private void OnAddedItemsToHolder(bool holderMissing)
		{
		}

		// Token: 0x06003641 RID: 13889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003641")]
		[Address(RVA = "0x34F84F0", Offset = "0x34F6AF0", VA = "0x1834F84F0", Slot = "326")]
		private void OnDroppedItems()
		{
		}

		// Token: 0x06003642 RID: 13890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003642")]
		[Address(RVA = "0x34F85A0", Offset = "0x34F6BA0", VA = "0x1834F85A0")]
		private void UpdateClearTreeStimuli(Robby.RunningRobbyOrder activeOrder)
		{
		}

		// Token: 0x06003643 RID: 13891 RVA: 0x00010308 File Offset: 0x0000E508
		[Token(Token = "0x6003643")]
		[Address(RVA = "0x34F8A30", Offset = "0x34F7030", VA = "0x1834F8A30")]
		private bool CanChopTree(WorldObjectLocator treeWo)
		{
			return default(bool);
		}

		// Token: 0x06003644 RID: 13892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003644")]
		[Address(RVA = "0x34F8D00", Offset = "0x34F7300", VA = "0x1834F8D00")]
		private void StartClearOrder(Robby.RobbyClearOrder clearOrder, Transform fromPlayer)
		{
		}

		// Token: 0x06003645 RID: 13893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003645")]
		[Address(RVA = "0x34F8E50", Offset = "0x34F7450", VA = "0x1834F8E50")]
		private void SetCurrentClearStimuli(Vector3 position, RobbyOrderStimuliBase stimuli, WorldObjectLocator newTreeTarget)
		{
		}

		// Token: 0x06003646 RID: 13894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003646")]
		[Address(RVA = "0x34F90E0", Offset = "0x34F76E0", VA = "0x1834F90E0")]
		private void UpdateClearOrder()
		{
		}

		// Token: 0x06003647 RID: 13895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003647")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "324")]
		private void OnTreeHit(Vector3 location)
		{
		}

		// Token: 0x06003648 RID: 13896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003648")]
		[Address(RVA = "0x34F9440", Offset = "0x34F7A40", VA = "0x1834F9440", Slot = "323")]
		private void OnFellTree(Vector3 location)
		{
		}

		// Token: 0x06003649 RID: 13897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003649")]
		[Address(RVA = "0x34F95C0", Offset = "0x34F7BC0", VA = "0x1834F95C0", Slot = "322")]
		private void OnBushCleared(Vector3 location, bool force)
		{
		}

		// Token: 0x0600364A RID: 13898 RVA: 0x00010320 File Offset: 0x0000E520
		[Token(Token = "0x600364A")]
		[Address(RVA = "0x34F9840", Offset = "0x34F7E40", VA = "0x1834F9840")]
		private bool FindChopTreeStimuli(Vector3 checkPos, float checkRadius, bool updateStimuli = true)
		{
			return default(bool);
		}

		// Token: 0x0600364B RID: 13899 RVA: 0x00010338 File Offset: 0x0000E538
		[Token(Token = "0x600364B")]
		[Address(RVA = "0x34F9BE0", Offset = "0x34F81E0", VA = "0x1834F9BE0")]
		private bool FindClearStumpStimuli(Vector3 checkPos, float checkRadius, bool updateStimuli = true)
		{
			return default(bool);
		}

		// Token: 0x0600364C RID: 13900 RVA: 0x00010350 File Offset: 0x0000E550
		[Token(Token = "0x600364C")]
		[Address(RVA = "0x34F9F70", Offset = "0x34F8570", VA = "0x1834F9F70")]
		private bool FindBushClearStimuli(Vector3 checkPos, float checkRadius, bool updateStimuli = true)
		{
			return default(bool);
		}

		// Token: 0x0600364D RID: 13901 RVA: 0x00010368 File Offset: 0x0000E568
		[Token(Token = "0x600364D")]
		[Address(RVA = "0x34FA480", Offset = "0x34F8A80", VA = "0x1834FA480")]
		private bool FindValidHolders(string vailItemType, bool setDropLocation, bool logSled = false)
		{
			return default(bool);
		}

		// Token: 0x0600364E RID: 13902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600364E")]
		[Address(RVA = "0x34FABE0", Offset = "0x34F91E0", VA = "0x1834FABE0")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x0600364F RID: 13903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600364F")]
		[Address(RVA = "0x34FAC00", Offset = "0x34F9200", VA = "0x1834FAC00")]
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x06003650 RID: 13904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003650")]
		[Address(RVA = "0x34FACF0", Offset = "0x34F92F0", VA = "0x1834FACF0")]
		private void SetPadState(Robby.PadState newState)
		{
		}

		// Token: 0x06003651 RID: 13905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003651")]
		[Address(RVA = "0x34FAD50", Offset = "0x34F9350", VA = "0x1834FAD50")]
		private void UpdateLocalPlayerInteraction()
		{
		}

		// Token: 0x06003652 RID: 13906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003652")]
		[Address(RVA = "0x34FAF90", Offset = "0x34F9590", VA = "0x1834FAF90")]
		private void LocalPlayerHelpUp()
		{
		}

		// Token: 0x06003653 RID: 13907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003653")]
		[Address(RVA = "0x34FB700", Offset = "0x34F9D00", VA = "0x1834FB700")]
		private void LocalPlayerCheckHelpUpFinished()
		{
		}

		// Token: 0x06003654 RID: 13908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003654")]
		[Address(RVA = "0x34FBBB0", Offset = "0x34FA1B0", VA = "0x1834FBBB0")]
		private void LocalPlayerOnHelpUpFinished()
		{
		}

		// Token: 0x06003655 RID: 13909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003655")]
		[Address(RVA = "0x34FBCA0", Offset = "0x34FA2A0", VA = "0x1834FBCA0")]
		private void ServerHelpUp(Transform helpingPlayer)
		{
		}

		// Token: 0x06003656 RID: 13910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003656")]
		[Address(RVA = "0x34FBEF0", Offset = "0x34FA4F0", VA = "0x1834FBEF0")]
		[UsedImplicitly]
		public void LocalPlayerStartGivingOrders()
		{
		}

		// Token: 0x06003657 RID: 13911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003657")]
		[Address(RVA = "0x34FBF20", Offset = "0x34FA520", VA = "0x1834FBF20")]
		private void InitPadIfNeeded()
		{
		}

		// Token: 0x06003658 RID: 13912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003658")]
		[Address(RVA = "0x34FC130", Offset = "0x34FA730", VA = "0x1834FC130")]
		public void OnLocalPlayerGiveOrderFinished()
		{
		}

		// Token: 0x06003659 RID: 13913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003659")]
		[Address(RVA = "0x34FC1A0", Offset = "0x34FA7A0", VA = "0x1834FC1A0")]
		public void OnLocalPlayerGiveOrderCancelled()
		{
		}

		// Token: 0x0600365A RID: 13914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600365A")]
		[Address(RVA = "0x34FC1B0", Offset = "0x34FA7B0", VA = "0x1834FC1B0")]
		private void LocalPlayerOpenTactipad()
		{
		}

		// Token: 0x0600365B RID: 13915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600365B")]
		[Address(RVA = "0x34FC650", Offset = "0x34FAC50", VA = "0x1834FC650")]
		private void LocalPlayerCloseTactipad(Robby.PadState newPadState)
		{
		}

		// Token: 0x0600365C RID: 13916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600365C")]
		[Address(RVA = "0x34FCAF0", Offset = "0x34FB0F0", VA = "0x1834FCAF0")]
		private void LocalPlayerCancelGiveOrders()
		{
		}

		// Token: 0x0600365D RID: 13917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600365D")]
		[Address(RVA = "0x34FCB90", Offset = "0x34FB190", VA = "0x1834FCB90")]
		private void LocalPlayerGiveOrdersFromTactipad()
		{
		}

		// Token: 0x0600365E RID: 13918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600365E")]
		[Address(RVA = "0x34FCE30", Offset = "0x34FB430", VA = "0x1834FCE30")]
		private void LocalPlayerPadClosed(bool forceCancel = false, bool openingGrabBag = false)
		{
		}

		// Token: 0x0600365F RID: 13919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600365F")]
		[Address(RVA = "0x34FD060", Offset = "0x34FB660", VA = "0x1834FD060")]
		private void LocalPlayerStartFaceRobby()
		{
		}

		// Token: 0x06003660 RID: 13920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003660")]
		[Address(RVA = "0x34FD3D0", Offset = "0x34FB9D0", VA = "0x1834FD3D0")]
		private void LocalPlayerUpdateFaceRobby()
		{
		}

		// Token: 0x06003661 RID: 13921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003661")]
		[Address(RVA = "0x34FD8A0", Offset = "0x34FBEA0", VA = "0x1834FD8A0")]
		private void LockPlayer(bool locked, bool openingGrabBag = false)
		{
		}

		// Token: 0x06003662 RID: 13922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003662")]
		[Address(RVA = "0x34FE200", Offset = "0x34FC800", VA = "0x1834FE200")]
		private void ForceFOV(float newFOV)
		{
		}

		// Token: 0x06003663 RID: 13923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003663")]
		[Address(RVA = "0x34FE330", Offset = "0x34FC930", VA = "0x1834FE330")]
		private static IEnumerator ResetFov(float targetVal, float resetFovTime)
		{
			return null;
		}

		// Token: 0x06003664 RID: 13924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003664")]
		[Address(RVA = "0x34FE390", Offset = "0x34FC990", VA = "0x1834FE390")]
		public Robby()
		{
		}

		// Token: 0x04002E9A RID: 11930
		[Token(Token = "0x4002E9A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private VailActor _actor;

		// Token: 0x04002E9B RID: 11931
		[Token(Token = "0x4002E9B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _isPlayerActor;

		// Token: 0x04002E9C RID: 11932
		[Token(Token = "0x4002E9C")]
		[FieldOffset(Offset = "0x31")]
		[SerializeField]
		private bool _startInjured;

		// Token: 0x04002E9D RID: 11933
		[Token(Token = "0x4002E9D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _axePrefab;

		// Token: 0x04002E9E RID: 11934
		[Token(Token = "0x4002E9E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _axeScale;

		// Token: 0x04002E9F RID: 11935
		[Token(Token = "0x4002E9F")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private Vector3 _axeOffset;

		// Token: 0x04002EA0 RID: 11936
		[Token(Token = "0x4002EA0")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GrabNode _grabNode;

		// Token: 0x04002EA1 RID: 11937
		[Token(Token = "0x4002EA1")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _injuredObject;

		// Token: 0x04002EA2 RID: 11938
		[Token(Token = "0x4002EA2")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private ShoulderTapActor _shoulderTap;

		// Token: 0x04002EA3 RID: 11939
		[Token(Token = "0x4002EA3")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private bool _forcePlayerFaceRobby;

		// Token: 0x04002EA4 RID: 11940
		[Token(Token = "0x4002EA4")]
		[FieldOffset(Offset = "0x6C")]
		private float _faceLerpTime;

		// Token: 0x04002EA5 RID: 11941
		[Token(Token = "0x4002EA5")]
		[FieldOffset(Offset = "0x70")]
		private Quaternion _startPlayerRotation;

		// Token: 0x04002EA6 RID: 11942
		[Token(Token = "0x4002EA6")]
		[FieldOffset(Offset = "0x80")]
		private Quaternion _targetPlayerRotation;

		// Token: 0x04002EA7 RID: 11943
		[Token(Token = "0x4002EA7")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Transform _robbyRightHand;

		// Token: 0x04002EA8 RID: 11944
		[Token(Token = "0x4002EA8")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private RobbyDropStimuli _dropLocationPrefab;

		// Token: 0x04002EA9 RID: 11945
		[Token(Token = "0x4002EA9")]
		[FieldOffset(Offset = "0xA0")]
		private bool _grabEnabled;

		// Token: 0x04002EAA RID: 11946
		[Token(Token = "0x4002EAA")]
		[FieldOffset(Offset = "0xA4")]
		private Robby.DropLocationType _dropLocationType;

		// Token: 0x04002EAB RID: 11947
		[Token(Token = "0x4002EAB")]
		[FieldOffset(Offset = "0xA8")]
		private Robby.InjuredState _injuredState;

		// Token: 0x04002EAC RID: 11948
		[Token(Token = "0x4002EAC")]
		[FieldOffset(Offset = "0xAC")]
		private Robby.PadState _localPadState;

		// Token: 0x04002EAD RID: 11949
		[Token(Token = "0x4002EAD")]
		[FieldOffset(Offset = "0xB0")]
		private int _injuredStateStartFrame;

		// Token: 0x04002EAE RID: 11950
		[Token(Token = "0x4002EAE")]
		[FieldOffset(Offset = "0xB4")]
		private float _originalFov;

		// Token: 0x04002EAF RID: 11951
		[Token(Token = "0x4002EAF")]
		[FieldOffset(Offset = "0xB8")]
		private bool _isFirstInteraction;

		// Token: 0x04002EB0 RID: 11952
		[Token(Token = "0x4002EB0")]
		[FieldOffset(Offset = "0xB9")]
		private bool _waitingForOrders;

		// Token: 0x04002EB1 RID: 11953
		[Token(Token = "0x4002EB1")]
		[FieldOffset(Offset = "0xBC")]
		private float _waitingForOrdersStartTime;

		// Token: 0x04002EB2 RID: 11954
		[Token(Token = "0x4002EB2")]
		[FieldOffset(Offset = "0xC0")]
		private PlayerStimuli _interactingPlayer;

		// Token: 0x04002EB3 RID: 11955
		[Token(Token = "0x4002EB3")]
		[FieldOffset(Offset = "0xC8")]
		private Transform _helpingPlayer;

		// Token: 0x04002EB4 RID: 11956
		[Token(Token = "0x4002EB4")]
		[FieldOffset(Offset = "0xD0")]
		private GameObject _axeHeld;

		// Token: 0x04002EB5 RID: 11957
		[Token(Token = "0x4002EB5")]
		[FieldOffset(Offset = "0xD8")]
		private Animator _robbyAnimator;

		// Token: 0x04002EB6 RID: 11958
		[Token(Token = "0x4002EB6")]
		[FieldOffset(Offset = "0xE0")]
		private readonly List<Robby.LayerBlend> _layerBlends;

		// Token: 0x04002EB7 RID: 11959
		[Token(Token = "0x4002EB7")]
		private const string RobbyTableReference = "Robby";

		// Token: 0x04002EB8 RID: 11960
		[Token(Token = "0x4002EB8")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<WorldObjectLocator, VailActor> _treeClearTargets;

		// Token: 0x04002EB9 RID: 11961
		[Token(Token = "0x4002EB9")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private VailControllerOverride _followPlayerOverride;

		// Token: 0x04002EBA RID: 11962
		[Token(Token = "0x4002EBA")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private RobbyOrderData _orderData;

		// Token: 0x04002EBB RID: 11963
		[Token(Token = "0x4002EBB")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private ReceiveItemsInteractionTrigger _receiveItems;

		// Token: 0x04002EBC RID: 11964
		[Token(Token = "0x4002EBC")]
		[FieldOffset(Offset = "0x100")]
		private bool _drawBuildGizmos;

		// Token: 0x04002EBD RID: 11965
		[Token(Token = "0x4002EBD")]
		[FieldOffset(Offset = "0x104")]
		private float _debugBuildCheckRadius;

		// Token: 0x04002EBE RID: 11966
		[Token(Token = "0x4002EBE")]
		[FieldOffset(Offset = "0x108")]
		private Robby.RunningRobbyOrder _activeOrder;

		// Token: 0x04002EBF RID: 11967
		[Token(Token = "0x4002EBF")]
		[FieldOffset(Offset = "0x110")]
		private Robby.ClearArea _currentClearArea;

		// Token: 0x04002EC0 RID: 11968
		[Token(Token = "0x4002EC0")]
		[FieldOffset(Offset = "0x118")]
		private RobbyDropStimuli _dropStimuliInstance;

		// Token: 0x04002EC1 RID: 11969
		[Token(Token = "0x4002EC1")]
		[FieldOffset(Offset = "0x120")]
		private RobbyClearStimuli _clearStimuliInstance;

		// Token: 0x04002EC2 RID: 11970
		[Token(Token = "0x4002EC2")]
		[FieldOffset(Offset = "0x128")]
		private RobbyClearTreeStimuli _clearTreeStimuliInstance;

		// Token: 0x04002EC3 RID: 11971
		[Token(Token = "0x4002EC3")]
		[FieldOffset(Offset = "0x130")]
		private RobbyFollowStimuli _followStimuliInstance;

		// Token: 0x04002EC4 RID: 11972
		[Token(Token = "0x4002EC4")]
		[FieldOffset(Offset = "0x138")]
		private OrderCompleteStimuli _orderCompleteStimuliInstance;

		// Token: 0x04002EC5 RID: 11973
		[Token(Token = "0x4002EC5")]
		[FieldOffset(Offset = "0x140")]
		private Transform _followTransform;

		// Token: 0x04002EC6 RID: 11974
		[Token(Token = "0x4002EC6")]
		[FieldOffset(Offset = "0x148")]
		private WorldObjectLocator _treeTarget;

		// Token: 0x04002EC7 RID: 11975
		[Token(Token = "0x4002EC7")]
		[FieldOffset(Offset = "0x150")]
		private BuildActionStimuli _currentBuildStimuli;

		// Token: 0x04002EC8 RID: 11976
		[Token(Token = "0x4002EC8")]
		[FieldOffset(Offset = "0x158")]
		private VailControllerOverride _activeOverride;

		// Token: 0x04002EC9 RID: 11977
		[Token(Token = "0x4002EC9")]
		[FieldOffset(Offset = "0x160")]
		private VailControllerOverride _currentOrderOverride;

		// Token: 0x04002ECA RID: 11978
		[Token(Token = "0x4002ECA")]
		[FieldOffset(Offset = "0x168")]
		private readonly List<WorldObjectLocator> _treePositions;

		// Token: 0x04002ECB RID: 11979
		[Token(Token = "0x4002ECB")]
		[FieldOffset(Offset = "0x170")]
		private readonly List<Vector3> _bushPositions;

		// Token: 0x04002ECC RID: 11980
		[Token(Token = "0x4002ECC")]
		[FieldOffset(Offset = "0x178")]
		[SerializeField]
		private Transform _helpUpPlayerMarker;

		// Token: 0x04002ECD RID: 11981
		[Token(Token = "0x4002ECD")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		[EventRef]
		private string _firstNoteEvent;

		// Token: 0x04002ECE RID: 11982
		[Token(Token = "0x4002ECE")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		private bool _forceIntroFOV;

		// Token: 0x04002ECF RID: 11983
		[Token(Token = "0x4002ECF")]
		[FieldOffset(Offset = "0x18C")]
		[SerializeField]
		private float _introFOV;

		// Token: 0x04002ED0 RID: 11984
		[Token(Token = "0x4002ED0")]
		[FieldOffset(Offset = "0x190")]
		[SerializeField]
		private float _resetFovTime;

		// Token: 0x04002ED1 RID: 11985
		[Token(Token = "0x4002ED1")]
		[FieldOffset(Offset = "0x198")]
		private RobbyWorldUi _tactiPad;

		// Token: 0x04002ED2 RID: 11986
		[Token(Token = "0x4002ED2")]
		[FieldOffset(Offset = "0x1A0")]
		private readonly ILayerBehaviourActivator[] _fullBodyDisableSpineActivators;

		// Token: 0x04002ED3 RID: 11987
		[Token(Token = "0x4002ED3")]
		[FieldOffset(Offset = "0x1A8")]
		private int _padStateChangeFrame;

		// Token: 0x020007D0 RID: 2000
		[Token(Token = "0x20007D0")]
		internal enum RobbyBuildType
		{
			// Token: 0x04002ED5 RID: 11989
			[Token(Token = "0x4002ED5")]
			Build,
			// Token: 0x04002ED6 RID: 11990
			[Token(Token = "0x4002ED6")]
			Dismantle,
			// Token: 0x04002ED7 RID: 11991
			[Token(Token = "0x4002ED7")]
			Repair,
			// Token: 0x04002ED8 RID: 11992
			[Token(Token = "0x4002ED8")]
			None
		}

		// Token: 0x020007D1 RID: 2001
		[Token(Token = "0x20007D1")]
		[Serializable]
		internal class RobbyBuildOrder : Robby.RobbyOrder
		{
			// Token: 0x06003666 RID: 13926 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003666")]
			[Address(RVA = "0x34FE8E0", Offset = "0x34FCEE0", VA = "0x1834FE8E0")]
			private static ValueDropdownList<string> GetStimuliTypes()
			{
				return null;
			}

			// Token: 0x06003667 RID: 13927 RVA: 0x00010380 File Offset: 0x0000E580
			[Token(Token = "0x6003667")]
			[Address(RVA = "0x34FE930", Offset = "0x34FCF30", VA = "0x1834FE930", Slot = "4")]
			public override bool IsAllowed(VailActor robbyActor, Robby robby)
			{
				return default(bool);
			}

			// Token: 0x06003668 RID: 13928 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003668")]
			[Address(RVA = "0x34FEB00", Offset = "0x34FD100", VA = "0x1834FEB00")]
			public RobbyBuildOrder()
			{
			}

			// Token: 0x04002ED9 RID: 11993
			[Token(Token = "0x4002ED9")]
			[FieldOffset(Offset = "0x40")]
			public Robby.RobbyBuildType _buildType;

			// Token: 0x04002EDA RID: 11994
			[Token(Token = "0x4002EDA")]
			[FieldOffset(Offset = "0x48")]
			public BuildActionStimuli _buildPrefab;

			// Token: 0x04002EDB RID: 11995
			[Token(Token = "0x4002EDB")]
			[FieldOffset(Offset = "0x50")]
			public string _buildStimuli;

			// Token: 0x04002EDC RID: 11996
			[Token(Token = "0x4002EDC")]
			[FieldOffset(Offset = "0x58")]
			public bool _needTarp;

			// Token: 0x04002EDD RID: 11997
			[Token(Token = "0x4002EDD")]
			[FieldOffset(Offset = "0x5C")]
			public float _checkPhysicsRadius;
		}

		// Token: 0x020007D2 RID: 2002
		[Token(Token = "0x20007D2")]
		private static class AnimLayers
		{
			// Token: 0x04002EDE RID: 11998
			[Token(Token = "0x4002EDE")]
			public const int Base = 0;

			// Token: 0x04002EDF RID: 11999
			[Token(Token = "0x4002EDF")]
			public const int UpperBody = 1;

			// Token: 0x04002EE0 RID: 12000
			[Token(Token = "0x4002EE0")]
			public const int FullBody = 2;
		}

		// Token: 0x020007D3 RID: 2003
		[Token(Token = "0x20007D3")]
		private enum InjuredState
		{
			// Token: 0x04002EE2 RID: 12002
			[Token(Token = "0x4002EE2")]
			None,
			// Token: 0x04002EE3 RID: 12003
			[Token(Token = "0x4002EE3")]
			Injured,
			// Token: 0x04002EE4 RID: 12004
			[Token(Token = "0x4002EE4")]
			GettingUp
		}

		// Token: 0x020007D4 RID: 2004
		[Token(Token = "0x20007D4")]
		private enum PadState
		{
			// Token: 0x04002EE6 RID: 12006
			[Token(Token = "0x4002EE6")]
			Closed,
			// Token: 0x04002EE7 RID: 12007
			[Token(Token = "0x4002EE7")]
			Open,
			// Token: 0x04002EE8 RID: 12008
			[Token(Token = "0x4002EE8")]
			GivingNote,
			// Token: 0x04002EE9 RID: 12009
			[Token(Token = "0x4002EE9")]
			LowerToGiveItem,
			// Token: 0x04002EEA RID: 12010
			[Token(Token = "0x4002EEA")]
			Cancelling
		}

		// Token: 0x020007D5 RID: 2005
		[Token(Token = "0x20007D5")]
		private class LayerBlend
		{
			// Token: 0x06003669 RID: 13929 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003669")]
			[Address(RVA = "0x34FEB80", Offset = "0x34FD180", VA = "0x1834FEB80")]
			public LayerBlend(float defaultWeight)
			{
			}

			// Token: 0x04002EEB RID: 12011
			[Token(Token = "0x4002EEB")]
			[FieldOffset(Offset = "0x10")]
			public float weight;

			// Token: 0x04002EEC RID: 12012
			[Token(Token = "0x4002EEC")]
			[FieldOffset(Offset = "0x14")]
			public float targetWeight;
		}

		// Token: 0x020007D6 RID: 2006
		[Token(Token = "0x20007D6")]
		[Serializable]
		internal class RobbyOrder
		{
			// Token: 0x0600366A RID: 13930 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600366A")]
			[Address(RVA = "0x34FEB90", Offset = "0x34FD190", VA = "0x1834FEB90")]
			private static ValueDropdownList<string> GetStimuliTypes()
			{
				return null;
			}

			// Token: 0x0600366B RID: 13931 RVA: 0x00010398 File Offset: 0x0000E598
			[Token(Token = "0x600366B")]
			[Address(RVA = "0x34FEBE0", Offset = "0x34FD1E0", VA = "0x1834FEBE0")]
			public bool NeedsStimuli()
			{
				return default(bool);
			}

			// Token: 0x0600366C RID: 13932 RVA: 0x000103B0 File Offset: 0x0000E5B0
			[Token(Token = "0x600366C")]
			[Address(RVA = "0x34FEC60", Offset = "0x34FD260", VA = "0x1834FEC60", Slot = "4")]
			public virtual bool IsAllowed(VailActor robbyActor, Robby robby)
			{
				return default(bool);
			}

			// Token: 0x0600366D RID: 13933 RVA: 0x000103C8 File Offset: 0x0000E5C8
			[Token(Token = "0x600366D")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "5")]
			public virtual bool ShouldRefuse(VailActor robbyActor, Robby robby, Transform fromPlayer)
			{
				return default(bool);
			}

			// Token: 0x0600366E RID: 13934 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600366E")]
			[Address(RVA = "0x34FEDF0", Offset = "0x34FD3F0", VA = "0x1834FEDF0")]
			private void RunOrderNow()
			{
			}

			// Token: 0x170006C7 RID: 1735
			// (get) Token: 0x0600366F RID: 13935 RVA: 0x000103E0 File Offset: 0x0000E5E0
			[Token(Token = "0x170006C7")]
			private bool IsPlaying
			{
				[Token(Token = "0x600366F")]
				[Address(RVA = "0x34FEED0", Offset = "0x34FD4D0", VA = "0x1834FEED0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06003670 RID: 13936 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003670")]
			[Address(RVA = "0x34FEF50", Offset = "0x34FD550", VA = "0x1834FEF50")]
			public RobbyOrder()
			{
			}

			// Token: 0x04002EED RID: 12013
			[Token(Token = "0x4002EED")]
			[FieldOffset(Offset = "0x10")]
			public string _itemName;

			// Token: 0x04002EEE RID: 12014
			[Token(Token = "0x4002EEE")]
			[FieldOffset(Offset = "0x18")]
			public VailControllerOverride _controllerOverride;

			// Token: 0x04002EEF RID: 12015
			[Token(Token = "0x4002EEF")]
			[FieldOffset(Offset = "0x20")]
			public bool _enabled;

			// Token: 0x04002EF0 RID: 12016
			[Token(Token = "0x4002EF0")]
			[FieldOffset(Offset = "0x28")]
			public string _needsStimuli;

			// Token: 0x04002EF1 RID: 12017
			[Token(Token = "0x4002EF1")]
			[FieldOffset(Offset = "0x30")]
			public float _maxStimuliRange;

			// Token: 0x04002EF2 RID: 12018
			[Token(Token = "0x4002EF2")]
			[FieldOffset(Offset = "0x38")]
			private Type _needsStimuliType;
		}

		// Token: 0x020007D7 RID: 2007
		[Token(Token = "0x20007D7")]
		[Serializable]
		internal class RobbyClearOrder : Robby.RobbyOrder
		{
			// Token: 0x06003671 RID: 13937 RVA: 0x000103F8 File Offset: 0x0000E5F8
			[Token(Token = "0x6003671")]
			[Address(RVA = "0x352DFB0", Offset = "0x352C5B0", VA = "0x18352DFB0", Slot = "5")]
			public override bool ShouldRefuse(VailActor robbyActor, Robby robby, Transform fromPlayer)
			{
				return default(bool);
			}

			// Token: 0x06003672 RID: 13938 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003672")]
			[Address(RVA = "0x352E0D0", Offset = "0x352C6D0", VA = "0x18352E0D0")]
			public RobbyClearOrder()
			{
			}

			// Token: 0x04002EF3 RID: 12019
			[Token(Token = "0x4002EF3")]
			[FieldOffset(Offset = "0x40")]
			public float _clearRadius;
		}

		// Token: 0x020007D8 RID: 2008
		[Token(Token = "0x20007D8")]
		[Serializable]
		internal class RobbyGetOrder : Robby.RobbyOrder
		{
			// Token: 0x06003673 RID: 13939 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003673")]
			[Address(RVA = "0x352E0E0", Offset = "0x352C6E0", VA = "0x18352E0E0")]
			private static ValueDropdownList<string> GetItemTypes()
			{
				return null;
			}

			// Token: 0x06003674 RID: 13940 RVA: 0x00010410 File Offset: 0x0000E610
			[Token(Token = "0x6003674")]
			[Address(RVA = "0x352E120", Offset = "0x352C720", VA = "0x18352E120")]
			public bool IsItem(string item)
			{
				return default(bool);
			}

			// Token: 0x06003675 RID: 13941 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003675")]
			[Address(RVA = "0x352E1E0", Offset = "0x352C7E0", VA = "0x18352E1E0")]
			public RobbyGetOrder()
			{
			}

			// Token: 0x04002EF4 RID: 12020
			[Token(Token = "0x4002EF4")]
			[FieldOffset(Offset = "0x40")]
			public string _itemType;

			// Token: 0x04002EF5 RID: 12021
			[Token(Token = "0x4002EF5")]
			[FieldOffset(Offset = "0x48")]
			public float _expireTimeMinutes;

			// Token: 0x04002EF6 RID: 12022
			[Token(Token = "0x4002EF6")]
			[FieldOffset(Offset = "0x4C")]
			public bool _restartAfterExpire;

			// Token: 0x04002EF7 RID: 12023
			[Token(Token = "0x4002EF7")]
			[FieldOffset(Offset = "0x4D")]
			public bool _checkCompleteOnDrop;
		}

		// Token: 0x020007D9 RID: 2009
		[Token(Token = "0x20007D9")]
		[Serializable]
		internal class RobbyMaintainOrder : Robby.RobbyOrder
		{
			// Token: 0x06003676 RID: 13942 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003676")]
			[Address(RVA = "0x352E0D0", Offset = "0x352C6D0", VA = "0x18352E0D0")]
			public RobbyMaintainOrder()
			{
			}
		}

		// Token: 0x020007DA RID: 2010
		[Token(Token = "0x20007DA")]
		[Serializable]
		internal class RobbyStayOrder : Robby.RobbyOrder
		{
			// Token: 0x06003677 RID: 13943 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003677")]
			[Address(RVA = "0x352E0D0", Offset = "0x352C6D0", VA = "0x18352E0D0")]
			public RobbyStayOrder()
			{
			}
		}

		// Token: 0x020007DB RID: 2011
		[Token(Token = "0x20007DB")]
		private class RunningRobbyOrder
		{
			// Token: 0x06003678 RID: 13944 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003678")]
			[Address(RVA = "0x352E200", Offset = "0x352C800", VA = "0x18352E200")]
			public RunningRobbyOrder(Robby.RobbyOrder order)
			{
			}

			// Token: 0x170006C8 RID: 1736
			// (get) Token: 0x06003679 RID: 13945 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006C8")]
			public Robby.RobbyOrder OrderData
			{
				[Token(Token = "0x6003679")]
				[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600367A RID: 13946 RVA: 0x00010428 File Offset: 0x0000E628
			[Token(Token = "0x600367A")]
			[Address(RVA = "0x352E2A0", Offset = "0x352C8A0", VA = "0x18352E2A0")]
			public bool IsCompleteByTime(VailActor actor, Robby.DropLocationType dropLocationType)
			{
				return default(bool);
			}

			// Token: 0x0600367B RID: 13947 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600367B")]
			[Address(RVA = "0x1B65000", Offset = "0x1B63600", VA = "0x181B65000")]
			public void SetCompleted()
			{
			}

			// Token: 0x170006C9 RID: 1737
			// (get) Token: 0x0600367C RID: 13948 RVA: 0x00010440 File Offset: 0x0000E640
			[Token(Token = "0x170006C9")]
			public bool IsCompleteByCallback
			{
				[Token(Token = "0x600367C")]
				[Address(RVA = "0x5FD560", Offset = "0x5FBB60", VA = "0x1805FD560")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0600367D RID: 13949 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600367D")]
			[Address(RVA = "0x352E4F0", Offset = "0x352CAF0", VA = "0x18352E4F0")]
			public void ResetStartTime(float offset = 0f)
			{
			}

			// Token: 0x0600367E RID: 13950 RVA: 0x00010458 File Offset: 0x0000E658
			[Token(Token = "0x600367E")]
			[Address(RVA = "0x352E560", Offset = "0x352CB60", VA = "0x18352E560")]
			public bool ShowAxe()
			{
				return default(bool);
			}

			// Token: 0x0600367F RID: 13951 RVA: 0x00010470 File Offset: 0x0000E670
			[Token(Token = "0x600367F")]
			[Address(RVA = "0x352E5E0", Offset = "0x352CBE0", VA = "0x18352E5E0")]
			public bool NeedsTreeStimuli()
			{
				return default(bool);
			}

			// Token: 0x06003680 RID: 13952 RVA: 0x00010488 File Offset: 0x0000E688
			[Token(Token = "0x6003680")]
			[Address(RVA = "0x352E690", Offset = "0x352CC90", VA = "0x18352E690")]
			public bool IsType(Type orderType)
			{
				return default(bool);
			}

			// Token: 0x06003681 RID: 13953 RVA: 0x000104A0 File Offset: 0x0000E6A0
			[Token(Token = "0x6003681")]
			[Address(RVA = "0x352E700", Offset = "0x352CD00", VA = "0x18352E700")]
			public Robby.RobbyBuildType BuildType()
			{
				return Robby.RobbyBuildType.Build;
			}

			// Token: 0x06003682 RID: 13954 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003682")]
			[Address(RVA = "0x5FD590", Offset = "0x5FBB90", VA = "0x1805FD590")]
			public void SetDropLocationType(Robby.DropLocationType value)
			{
			}

			// Token: 0x06003683 RID: 13955 RVA: 0x000104B8 File Offset: 0x0000E6B8
			[Token(Token = "0x6003683")]
			[Address(RVA = "0x30EF1B0", Offset = "0x30ED7B0", VA = "0x1830EF1B0")]
			public bool DropAtSled()
			{
				return default(bool);
			}

			// Token: 0x170006CA RID: 1738
			// (get) Token: 0x06003684 RID: 13956 RVA: 0x000104D0 File Offset: 0x0000E6D0
			[Token(Token = "0x170006CA")]
			public Robby.DropLocationType DropLocationType
			{
				[Token(Token = "0x6003684")]
				[Address(RVA = "0x5FD580", Offset = "0x5FBB80", VA = "0x1805FD580")]
				get
				{
					return Robby.DropLocationType.DropHere;
				}
			}

			// Token: 0x04002EF8 RID: 12024
			[Token(Token = "0x4002EF8")]
			[FieldOffset(Offset = "0x10")]
			private float _startTime;

			// Token: 0x04002EF9 RID: 12025
			[Token(Token = "0x4002EF9")]
			[FieldOffset(Offset = "0x14")]
			private bool _receivedCompleted;

			// Token: 0x04002EFA RID: 12026
			[Token(Token = "0x4002EFA")]
			[FieldOffset(Offset = "0x18")]
			private readonly Robby.RobbyOrder _order;

			// Token: 0x04002EFB RID: 12027
			[Token(Token = "0x4002EFB")]
			[FieldOffset(Offset = "0x20")]
			private Robby.DropLocationType _dropLocationType;
		}

		// Token: 0x020007DC RID: 2012
		[Token(Token = "0x20007DC")]
		public enum OrderType
		{
			// Token: 0x04002EFD RID: 12029
			[Token(Token = "0x4002EFD")]
			Follow,
			// Token: 0x04002EFE RID: 12030
			[Token(Token = "0x4002EFE")]
			Get,
			// Token: 0x04002EFF RID: 12031
			[Token(Token = "0x4002EFF")]
			Build,
			// Token: 0x04002F00 RID: 12032
			[Token(Token = "0x4002F00")]
			StayHere,
			// Token: 0x04002F01 RID: 12033
			[Token(Token = "0x4002F01")]
			TakeBreak,
			// Token: 0x04002F02 RID: 12034
			[Token(Token = "0x4002F02")]
			Equip,
			// Token: 0x04002F03 RID: 12035
			[Token(Token = "0x4002F03")]
			ClearArea,
			// Token: 0x04002F04 RID: 12036
			[Token(Token = "0x4002F04")]
			MaintainBase
		}

		// Token: 0x020007DD RID: 2013
		[Token(Token = "0x20007DD")]
		private enum CarouselName
		{
			// Token: 0x04002F06 RID: 12038
			[Token(Token = "0x4002F06")]
			Action,
			// Token: 0x04002F07 RID: 12039
			[Token(Token = "0x4002F07")]
			GetItem,
			// Token: 0x04002F08 RID: 12040
			[Token(Token = "0x4002F08")]
			BuildItem,
			// Token: 0x04002F09 RID: 12041
			[Token(Token = "0x4002F09")]
			Equip,
			// Token: 0x04002F0A RID: 12042
			[Token(Token = "0x4002F0A")]
			Area,
			// Token: 0x04002F0B RID: 12043
			[Token(Token = "0x4002F0B")]
			DropLocation,
			// Token: 0x04002F0C RID: 12044
			[Token(Token = "0x4002F0C")]
			StayType,
			// Token: 0x04002F0D RID: 12045
			[Token(Token = "0x4002F0D")]
			MaintainBase,
			// Token: 0x04002F0E RID: 12046
			[Token(Token = "0x4002F0E")]
			None = -1
		}

		// Token: 0x020007DE RID: 2014
		[Token(Token = "0x20007DE")]
		private enum DropLocationType
		{
			// Token: 0x04002F10 RID: 12048
			[Token(Token = "0x4002F10")]
			DropHere,
			// Token: 0x04002F11 RID: 12049
			[Token(Token = "0x4002F11")]
			GiveToMe,
			// Token: 0x04002F12 RID: 12050
			[Token(Token = "0x4002F12")]
			FollowMe,
			// Token: 0x04002F13 RID: 12051
			[Token(Token = "0x4002F13")]
			FillHolder,
			// Token: 0x04002F14 RID: 12052
			[Token(Token = "0x4002F14")]
			FillLogSled
		}

		// Token: 0x020007DF RID: 2015
		[Token(Token = "0x20007DF")]
		private enum OrderEventType
		{
			// Token: 0x04002F16 RID: 12054
			[Token(Token = "0x4002F16")]
			WaitForOrders,
			// Token: 0x04002F17 RID: 12055
			[Token(Token = "0x4002F17")]
			FinishOrderGiveNote,
			// Token: 0x04002F18 RID: 12056
			[Token(Token = "0x4002F18")]
			GiveOrders,
			// Token: 0x04002F19 RID: 12057
			[Token(Token = "0x4002F19")]
			CancelWaitForOrder,
			// Token: 0x04002F1A RID: 12058
			[Token(Token = "0x4002F1A")]
			CancelAnyOrders,
			// Token: 0x04002F1B RID: 12059
			[Token(Token = "0x4002F1B")]
			HelpUp,
			// Token: 0x04002F1C RID: 12060
			[Token(Token = "0x4002F1C")]
			HelpUpFinished,
			// Token: 0x04002F1D RID: 12061
			[Token(Token = "0x4002F1D")]
			FinishOrderNoNote
		}

		// Token: 0x020007E0 RID: 2016
		[Token(Token = "0x20007E0")]
		private class ClearArea
		{
			// Token: 0x06003685 RID: 13957 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003685")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public ClearArea()
			{
			}

			// Token: 0x04002F1E RID: 12062
			[Token(Token = "0x4002F1E")]
			[FieldOffset(Offset = "0x10")]
			public Vector3 Position;

			// Token: 0x04002F1F RID: 12063
			[Token(Token = "0x4002F1F")]
			[FieldOffset(Offset = "0x1C")]
			public float Radius;
		}
	}
}
