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
	// Token: 0x0200069A RID: 1690
	[Token(Token = "0x200069A")]
	public class Robby : EntityEventListener<IRobbyActorState>, IRobbyCallbacks
	{
		// Token: 0x06002B44 RID: 11076 RVA: 0x0000C738 File Offset: 0x0000A938
		[Token(Token = "0x6002B44")]
		[Address(RVA = "0x2DEF8F0", Offset = "0x2DEE8F0", VA = "0x182DEF8F0", Slot = "305")]
		private bool IsCurrentBuildStimuli(BuildActionStimuli stimuli)
		{
			return default(bool);
		}

		// Token: 0x06002B45 RID: 11077 RVA: 0x0000C750 File Offset: 0x0000A950
		[Token(Token = "0x6002B45")]
		[Address(RVA = "0x2DE99B0", Offset = "0x2DE89B0", VA = "0x182DE99B0", Slot = "303")]
		public int GetItemNeededCount(string itemType)
		{
			return default(int);
		}

		// Token: 0x06002B46 RID: 11078 RVA: 0x0000C768 File Offset: 0x0000A968
		[Token(Token = "0x6002B46")]
		[Address(RVA = "0x2DEFD80", Offset = "0x2DEED80", VA = "0x182DEFD80", Slot = "304")]
		private bool ShouldPlaceCarriedItems()
		{
			return default(bool);
		}

		// Token: 0x06002B47 RID: 11079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B47")]
		[Address(RVA = "0x2DE8CD0", Offset = "0x2DE7CD0", VA = "0x182DE8CD0")]
		private BuildActionStimuli FindExistingBuildStimuli(Robby.RobbyBuildOrder buildOrder)
		{
			return null;
		}

		// Token: 0x06002B48 RID: 11080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B48")]
		[Address(RVA = "0x2DEFE80", Offset = "0x2DEEE80", VA = "0x182DEFE80")]
		private void StartBuildOrder(Robby.RobbyBuildOrder buildOrder, Transform fromPlayer)
		{
		}

		// Token: 0x06002B49 RID: 11081 RVA: 0x0000C780 File Offset: 0x0000A980
		[Token(Token = "0x6002B49")]
		[Address(RVA = "0x2DE8030", Offset = "0x2DE7030", VA = "0x182DE8030")]
		private static bool FindBuildPosition(Vector3 centerPosition, Vector3 offsetVec, float checkRadius, out Vector3 buildPos)
		{
			return default(bool);
		}

		// Token: 0x06002B4A RID: 11082 RVA: 0x0000C798 File Offset: 0x0000A998
		[Token(Token = "0x6002B4A")]
		[Address(RVA = "0x2DF1910", Offset = "0x2DF0910", VA = "0x182DF1910")]
		private static bool ValidateBuildLocation(Vector3 testPos, float checkRadius, out Vector3 groundPos)
		{
			return default(bool);
		}

		// Token: 0x06002B4B RID: 11083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B4B")]
		[Address(RVA = "0x2DF0E10", Offset = "0x2DEFE10", VA = "0x182DF0E10")]
		private void UpdateBuildOrder(Robby.RunningRobbyOrder runningOrder)
		{
		}

		// Token: 0x06002B4C RID: 11084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B4C")]
		[Address(RVA = "0x2DECCD0", Offset = "0x2DEBCD0", VA = "0x182DECCD0")]
		private static void OrientBuiltObject(BuildActionStimuli stimuli, Vector3 centerPosition)
		{
		}

		// Token: 0x06002B4D RID: 11085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B4D")]
		[Address(RVA = "0x2DE7BF0", Offset = "0x2DE6BF0", VA = "0x182DE7BF0")]
		private void DrawBuildGizmos()
		{
		}

		// Token: 0x06002B4E RID: 11086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B4E")]
		[Address(RVA = "0x2DECBE0", Offset = "0x2DEBBE0", VA = "0x182DECBE0")]
		private void OnValidate()
		{
		}

		// Token: 0x06002B4F RID: 11087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B4F")]
		[Address(RVA = "0x2DE6580", Offset = "0x2DE5580", VA = "0x182DE6580")]
		private void Awake()
		{
		}

		// Token: 0x06002B50 RID: 11088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B50")]
		[Address(RVA = "0x2DF07C0", Offset = "0x2DEF7C0", VA = "0x182DF07C0")]
		private void Start()
		{
		}

		// Token: 0x06002B51 RID: 11089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B51")]
		[Address(RVA = "0x2DF15F0", Offset = "0x2DF05F0", VA = "0x182DF15F0")]
		private void Update()
		{
		}

		// Token: 0x06002B52 RID: 11090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B52")]
		[Address(RVA = "0x2DEC2E0", Offset = "0x2DEB2E0", VA = "0x182DEC2E0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002B53 RID: 11091 RVA: 0x0000C7B0 File Offset: 0x0000A9B0
		[Token(Token = "0x6002B53")]
		[Address(RVA = "0x2DE9980", Offset = "0x2DE8980", VA = "0x182DE9980")]
		private int GetItemCount(int itemId)
		{
			return default(int);
		}

		// Token: 0x06002B54 RID: 11092 RVA: 0x0000C7C8 File Offset: 0x0000A9C8
		[Token(Token = "0x6002B54")]
		[Address(RVA = "0x2DE9A70", Offset = "0x2DE8A70", VA = "0x182DE9A70")]
		private bool HasItem(int itemId)
		{
			return default(bool);
		}

		// Token: 0x06002B55 RID: 11093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B55")]
		[Address(RVA = "0x2DE6380", Offset = "0x2DE5380", VA = "0x182DE6380", Slot = "306")]
		public void AdjustItemCount(int itemId, int delta)
		{
		}

		// Token: 0x06002B56 RID: 11094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B56")]
		[Address(RVA = "0x2DEC0E0", Offset = "0x2DEB0E0", VA = "0x182DEC0E0")]
		[ContextMenu("Log Tarp Count")]
		private void LogTarpCount()
		{
		}

		// Token: 0x06002B57 RID: 11095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B57")]
		[Address(RVA = "0x2DEF640", Offset = "0x2DEE640", VA = "0x182DEF640")]
		private void SetInjuredState(Robby.InjuredState newState)
		{
		}

		// Token: 0x06002B58 RID: 11096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B58")]
		[Address(RVA = "0x2CFE200", Offset = "0x2CFD200", VA = "0x182CFE200")]
		private void OnGrabEnter()
		{
		}

		// Token: 0x06002B59 RID: 11097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B59")]
		[Address(RVA = "0x2DEC7C0", Offset = "0x2DEB7C0", VA = "0x182DEC7C0")]
		private void OnGrabExit()
		{
		}

		// Token: 0x06002B5A RID: 11098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B5A")]
		[Address(RVA = "0x2DF0AA0", Offset = "0x2DEFAA0", VA = "0x182DF0AA0")]
		private void UpdateAnimationVars()
		{
		}

		// Token: 0x06002B5B RID: 11099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B5B")]
		[Address(RVA = "0x2DE2370", Offset = "0x2DE1370", VA = "0x182DE2370")]
		private void SetItemParent(Transform child, Transform newParent, Quaternion rotation)
		{
		}

		// Token: 0x06002B5C RID: 11100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B5C")]
		[Address(RVA = "0x2DEDCA0", Offset = "0x2DECCA0", VA = "0x182DEDCA0")]
		private void ServerCheckAxeVisibility()
		{
		}

		// Token: 0x06002B5D RID: 11101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B5D")]
		[Address(RVA = "0x2DECB50", Offset = "0x2DEBB50", VA = "0x182DECB50")]
		private void OnShowAxeChanged()
		{
		}

		// Token: 0x06002B5E RID: 11102 RVA: 0x0000C7E0 File Offset: 0x0000A9E0
		[Token(Token = "0x6002B5E")]
		[Address(RVA = "0x2DE6FA0", Offset = "0x2DE5FA0", VA = "0x182DE6FA0")]
		private bool CheckInteractConditions()
		{
			return default(bool);
		}

		// Token: 0x06002B5F RID: 11103 RVA: 0x0000C7F8 File Offset: 0x0000A9F8
		[Token(Token = "0x6002B5F")]
		[Address(RVA = "0x2DE9D70", Offset = "0x2DE8D70", VA = "0x182DE9D70")]
		private bool IsAlive()
		{
			return default(bool);
		}

		// Token: 0x06002B60 RID: 11104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B60")]
		[Address(RVA = "0x2DE6EC0", Offset = "0x2DE5EC0", VA = "0x182DE6EC0")]
		private void CheckInjuredInteraction()
		{
		}

		// Token: 0x06002B61 RID: 11105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B61")]
		[Address(RVA = "0x2DEF0E0", Offset = "0x2DEE0E0", VA = "0x182DEF0E0")]
		private void ServerUpdate()
		{
		}

		// Token: 0x06002B62 RID: 11106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B62")]
		[Address(RVA = "0x2DE7F70", Offset = "0x2DE6F70", VA = "0x182DE7F70")]
		private void EnableActorCollisionAndLook(bool value)
		{
		}

		// Token: 0x06002B63 RID: 11107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B63")]
		[Address(RVA = "0x2DE6400", Offset = "0x2DE5400", VA = "0x182DE6400", Slot = "16")]
		public override void Attached()
		{
		}

		// Token: 0x06002B64 RID: 11108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B64")]
		[Address(RVA = "0x2DEC7D0", Offset = "0x2DEB7D0", VA = "0x182DEC7D0")]
		private void OnInjuredStateChanged()
		{
		}

		// Token: 0x06002B65 RID: 11109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B65")]
		[Address(RVA = "0x2DEF2C0", Offset = "0x2DEE2C0", VA = "0x182DEF2C0")]
		private void SetActiveOverride(VailControllerOverride newOverride)
		{
		}

		// Token: 0x06002B66 RID: 11110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B66")]
		[Address(RVA = "0x2DF1520", Offset = "0x2DF0520", VA = "0x182DF1520")]
		private void UpdateShoulderTap()
		{
		}

		// Token: 0x06002B67 RID: 11111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B67")]
		[Address(RVA = "0x2DEDE60", Offset = "0x2DECE60", VA = "0x182DEDE60")]
		private void ServerCheckHelpUpFinished()
		{
		}

		// Token: 0x06002B68 RID: 11112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B68")]
		[Address(RVA = "0x2DE7260", Offset = "0x2DE6260", VA = "0x182DE7260")]
		private void ClearRobbyOrderHashes()
		{
		}

		// Token: 0x06002B69 RID: 11113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B69")]
		[Address(RVA = "0x2DE7B30", Offset = "0x2DE6B30", VA = "0x182DE7B30")]
		private void DoRobbyAnimatorPadRaiseTransition()
		{
		}

		// Token: 0x06002B6A RID: 11114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B6A")]
		[Address(RVA = "0x2DE7A70", Offset = "0x2DE6A70", VA = "0x182DE7A70")]
		private void DoRobbyAnimatorPadLowerTransition()
		{
		}

		// Token: 0x06002B6B RID: 11115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B6B")]
		[Address(RVA = "0x2DE7950", Offset = "0x2DE6950", VA = "0x182DE7950")]
		private void DoRobbyAnimatorFinishOrdersTransition(bool giveNote, bool longNote)
		{
		}

		// Token: 0x06002B6C RID: 11116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B6C")]
		[Address(RVA = "0x2DE7EF0", Offset = "0x2DE6EF0", VA = "0x182DE7EF0")]
		private void DropNow()
		{
		}

		// Token: 0x06002B6D RID: 11117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B6D")]
		[Address(RVA = "0x2DEE760", Offset = "0x2DED760", VA = "0x182DEE760")]
		private void ServerStartTakingOrders(PlayerStimuli playerStimuli)
		{
		}

		// Token: 0x06002B6E RID: 11118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B6E")]
		[Address(RVA = "0x2DEE8A0", Offset = "0x2DED8A0", VA = "0x182DEE8A0")]
		private void ServerStopTakingOrders()
		{
		}

		// Token: 0x06002B6F RID: 11119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B6F")]
		[Address(RVA = "0x2DEF400", Offset = "0x2DEE400", VA = "0x182DEF400")]
		private void SetControllerOverride(VailControllerOverride newOverride)
		{
		}

		// Token: 0x06002B70 RID: 11120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B70")]
		[Address(RVA = "0x2DEB890", Offset = "0x2DEA890", VA = "0x182DEB890")]
		private static string Localized(string localizedKey)
		{
			return null;
		}

		// Token: 0x06002B71 RID: 11121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B71")]
		private void AddOrderListUI<T>(Robby.CarouselName carouselId, List<T> orderList, Robby.CarouselName nextCarouselId = Robby.CarouselName.None) where T : Robby.RobbyOrder
		{
		}

		// Token: 0x06002B72 RID: 11122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B72")]
		[Address(RVA = "0x2DE6320", Offset = "0x2DE5320", VA = "0x182DE6320")]
		private void AddMenuItem(Robby.CarouselName carouselId, int optionId, string text, Robby.CarouselName nextCarouselId = Robby.CarouselName.None)
		{
		}

		// Token: 0x06002B73 RID: 11123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B73")]
		[Address(RVA = "0x2DE6A70", Offset = "0x2DE5A70", VA = "0x182DE6A70")]
		private void BuildTactipadUI()
		{
		}

		// Token: 0x06002B74 RID: 11124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B74")]
		[Address(RVA = "0x2DECF40", Offset = "0x2DEBF40", VA = "0x182DECF40")]
		private void PreShowCarousel(int carouselId)
		{
		}

		// Token: 0x06002B75 RID: 11125 RVA: 0x0000C810 File Offset: 0x0000AA10
		[Token(Token = "0x6002B75")]
		[Address(RVA = "0x2DE9DB0", Offset = "0x2DE8DB0", VA = "0x182DE9DB0")]
		private bool IsStimuliInRange(string stimuliTypeStr, float maxRange)
		{
			return default(bool);
		}

		// Token: 0x06002B76 RID: 11126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B76")]
		[Address(RVA = "0x2DE9BF0", Offset = "0x2DE8BF0", VA = "0x182DE9BF0")]
		private void InitializeOrderStimuli()
		{
		}

		// Token: 0x06002B77 RID: 11127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B77")]
		private void InitRobbyStimuli<T>(out T stimuli, string objName) where T : RobbyOrderStimuliBase
		{
		}

		// Token: 0x06002B78 RID: 11128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B78")]
		[Address(RVA = "0x2DE76C0", Offset = "0x2DE66C0", VA = "0x182DE76C0")]
		private void DestroyOrderStimuli()
		{
		}

		// Token: 0x06002B79 RID: 11129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B79")]
		[Address(RVA = "0x2DE7630", Offset = "0x2DE6630", VA = "0x182DE7630")]
		private void DestroyInstance(Component instance)
		{
		}

		// Token: 0x06002B7A RID: 11130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B7A")]
		[Address(RVA = "0x2DED1A0", Offset = "0x2DEC1A0", VA = "0x182DED1A0")]
		private void RunOrder(Robby.RobbyOrder order, Transform fromPlayer, int subOrderType2 = 0)
		{
		}

		// Token: 0x06002B7B RID: 11131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B7B")]
		[Address(RVA = "0x2DEE430", Offset = "0x2DED430", VA = "0x182DEE430")]
		public void ServerReceiveOrderFromClient(RobbyOrderEvent evt)
		{
		}

		// Token: 0x06002B7C RID: 11132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B7C")]
		[Address(RVA = "0x2DE73A0", Offset = "0x2DE63A0", VA = "0x182DE73A0")]
		public void ClientReceivedOrderEvent(RobbyOrderEvent evt)
		{
		}

		// Token: 0x06002B7D RID: 11133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B7D")]
		[Address(RVA = "0x2DE74F0", Offset = "0x2DE64F0", VA = "0x182DE74F0")]
		private void ClientSendOrders(Robby.OrderType orderType, int subOrderType, int subOrderType2)
		{
		}

		// Token: 0x06002B7E RID: 11134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B7E")]
		[Address(RVA = "0x2DEDB60", Offset = "0x2DECB60", VA = "0x182DEDB60")]
		private void SendOrderEvent(Robby.OrderEventType orderEventType, GlobalTargets targets)
		{
		}

		// Token: 0x06002B7F RID: 11135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B7F")]
		[Address(RVA = "0x2DEE020", Offset = "0x2DED020", VA = "0x182DEE020")]
		public void ServerGiveOrders(Robby.OrderType orderType, int subOrderType, int subOrderType2, Transform fromPlayer)
		{
		}

		// Token: 0x06002B80 RID: 11136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B80")]
		[Address(RVA = "0x2DEC360", Offset = "0x2DEB360", VA = "0x182DEC360")]
		private void OnGiveOrderServer(Robby.OrderType orderType, int subOrderType, int subOrderType2, Transform fromPlayer)
		{
		}

		// Token: 0x06002B81 RID: 11137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B81")]
		[Address(RVA = "0x2DEC930", Offset = "0x2DEB930", VA = "0x182DEC930")]
		private void OnOrderCompleted(bool gotTired = false)
		{
		}

		// Token: 0x06002B82 RID: 11138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B82")]
		[Address(RVA = "0x2DECA70", Offset = "0x2DEBA70", VA = "0x182DECA70")]
		private void OnOrderRefused(Transform fromPlayer)
		{
		}

		// Token: 0x06002B83 RID: 11139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B83")]
		[Address(RVA = "0x2DEFC30", Offset = "0x2DEEC30", VA = "0x182DEFC30", Slot = "301")]
		private void OnCompletedReaction()
		{
		}

		// Token: 0x06002B84 RID: 11140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B84")]
		[Address(RVA = "0x2DEC1B0", Offset = "0x2DEB1B0", VA = "0x182DEC1B0", Slot = "302")]
		public void OnCompletedOrder()
		{
		}

		// Token: 0x06002B85 RID: 11141 RVA: 0x0000C828 File Offset: 0x0000AA28
		[Token(Token = "0x6002B85")]
		[Address(RVA = "0x2DE9870", Offset = "0x2DE8870", VA = "0x182DE9870")]
		private Vector3 GetActivePlayerPos()
		{
			return default(Vector3);
		}

		// Token: 0x06002B86 RID: 11142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B86")]
		[Address(RVA = "0x2DEEEC0", Offset = "0x2DEDEC0", VA = "0x182DEEEC0")]
		private void ServerUpdateWaitingForOrders()
		{
		}

		// Token: 0x06002B87 RID: 11143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B87")]
		[Address(RVA = "0x2DEE950", Offset = "0x2DED950", VA = "0x182DEE950")]
		private void ServerUpdateOrders()
		{
		}

		// Token: 0x06002B88 RID: 11144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B88")]
		[Address(RVA = "0x2DF0510", Offset = "0x2DEF510", VA = "0x182DF0510")]
		private void StartEquipOrderServer(Transform fromPlayer)
		{
		}

		// Token: 0x06002B89 RID: 11145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B89")]
		[Address(RVA = "0x2DEADC0", Offset = "0x2DE9DC0", VA = "0x182DEADC0")]
		private void LocalPlayerOpenGrabBag()
		{
		}

		// Token: 0x06002B8A RID: 11146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B8A")]
		[Address(RVA = "0x2DF05F0", Offset = "0x2DEF5F0", VA = "0x182DF05F0")]
		private void StartGetItemOrder(Robby.RobbyGetOrder getOrder, Transform fromPlayer, Robby.DropLocationType orderDropLocation)
		{
		}

		// Token: 0x06002B8B RID: 11147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B8B")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		private void UpdateGetItemOrder(Robby.RunningRobbyOrder activeOrder)
		{
		}

		// Token: 0x06002B8C RID: 11148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B8C")]
		[Address(RVA = "0x2DEF950", Offset = "0x2DEE950", VA = "0x182DEF950", Slot = "300")]
		private void OnAddedItemsToHolder()
		{
		}

		// Token: 0x06002B8D RID: 11149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B8D")]
		[Address(RVA = "0x2DF1120", Offset = "0x2DF0120", VA = "0x182DF1120")]
		private void UpdateClearTreeStimuli(Robby.RunningRobbyOrder activeOrder)
		{
		}

		// Token: 0x06002B8E RID: 11150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B8E")]
		[Address(RVA = "0x2DF0440", Offset = "0x2DEF440", VA = "0x182DF0440")]
		private void StartClearOrder(Robby.RobbyClearOrder clearOrder, Transform fromPlayer)
		{
		}

		// Token: 0x06002B8F RID: 11151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B8F")]
		[Address(RVA = "0x2DEF590", Offset = "0x2DEE590", VA = "0x182DEF590")]
		private void SetCurrentClearStimuli(Vector3 position, RobbyOrderStimuliBase stimuli, WorldObjectLocator target)
		{
		}

		// Token: 0x06002B90 RID: 11152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B90")]
		[Address(RVA = "0x2DF0F80", Offset = "0x2DEFF80", VA = "0x182DF0F80")]
		private void UpdateClearOrder()
		{
		}

		// Token: 0x06002B91 RID: 11153 RVA: 0x0000C840 File Offset: 0x0000AA40
		[Token(Token = "0x6002B91")]
		[Address(RVA = "0x2DE9E90", Offset = "0x2DE8E90", VA = "0x182DE9E90", Slot = "299")]
		public bool IsTreeIntact()
		{
			return default(bool);
		}

		// Token: 0x06002B92 RID: 11154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B92")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "298")]
		private void OnTreeHit(Vector3 location)
		{
		}

		// Token: 0x06002B93 RID: 11155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B93")]
		[Address(RVA = "0x2DEFCC0", Offset = "0x2DEECC0", VA = "0x182DEFCC0", Slot = "297")]
		private void OnFellTree(Vector3 location)
		{
		}

		// Token: 0x06002B94 RID: 11156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B94")]
		[Address(RVA = "0x2DEF9F0", Offset = "0x2DEE9F0", VA = "0x182DEF9F0", Slot = "296")]
		private void OnBushCleared(Vector3 location, bool force)
		{
		}

		// Token: 0x06002B95 RID: 11157 RVA: 0x0000C858 File Offset: 0x0000AA58
		[Token(Token = "0x6002B95")]
		[Address(RVA = "0x2DE8590", Offset = "0x2DE7590", VA = "0x182DE8590")]
		private bool FindChopTreeStimuli(Vector3 checkPos, float checkRadius, bool updateStimuli = true)
		{
			return default(bool);
		}

		// Token: 0x06002B96 RID: 11158 RVA: 0x0000C870 File Offset: 0x0000AA70
		[Token(Token = "0x6002B96")]
		[Address(RVA = "0x2DE8930", Offset = "0x2DE7930", VA = "0x182DE8930")]
		private bool FindClearStumpStimuli(Vector3 checkPos, float checkRadius, bool updateStimuli = true)
		{
			return default(bool);
		}

		// Token: 0x06002B97 RID: 11159 RVA: 0x0000C888 File Offset: 0x0000AA88
		[Token(Token = "0x6002B97")]
		[Address(RVA = "0x2DE8210", Offset = "0x2DE7210", VA = "0x182DE8210")]
		private bool FindBushClearStimuli(Vector3 checkPos, float checkRadius, bool updateStimuli = true)
		{
			return default(bool);
		}

		// Token: 0x06002B98 RID: 11160 RVA: 0x0000C8A0 File Offset: 0x0000AAA0
		[Token(Token = "0x6002B98")]
		[Address(RVA = "0x2DE9110", Offset = "0x2DE8110", VA = "0x182DE9110")]
		private bool FindValidHolders(string vailItemType, bool setDropLocation)
		{
			return default(bool);
		}

		// Token: 0x06002B99 RID: 11161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B99")]
		[Address(RVA = "0x2DEC340", Offset = "0x2DEB340", VA = "0x182DEC340")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x06002B9A RID: 11162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B9A")]
		[Address(RVA = "0x2DEF8C0", Offset = "0x2DEE8C0", VA = "0x182DEF8C0")]
		private void SetPadState(Robby.PadState newState)
		{
		}

		// Token: 0x06002B9B RID: 11163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B9B")]
		[Address(RVA = "0x2DF1310", Offset = "0x2DF0310", VA = "0x182DF1310")]
		private void UpdateLocalPlayerInteraction()
		{
		}

		// Token: 0x06002B9C RID: 11164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B9C")]
		[Address(RVA = "0x2DEA890", Offset = "0x2DE9890", VA = "0x182DEA890")]
		private void LocalPlayerHelpUp()
		{
		}

		// Token: 0x06002B9D RID: 11165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B9D")]
		[Address(RVA = "0x2DE9F30", Offset = "0x2DE8F30", VA = "0x182DE9F30")]
		private void LocalPlayerCheckHelpUpFinished()
		{
		}

		// Token: 0x06002B9E RID: 11166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B9E")]
		[Address(RVA = "0x2DEAD10", Offset = "0x2DE9D10", VA = "0x182DEAD10")]
		private void LocalPlayerOnHelpUpFinished()
		{
		}

		// Token: 0x06002B9F RID: 11167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B9F")]
		[Address(RVA = "0x2DEE300", Offset = "0x2DED300", VA = "0x182DEE300")]
		private void ServerHelpUp(Transform helpingPlayer)
		{
		}

		// Token: 0x06002BA0 RID: 11168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BA0")]
		[Address(RVA = "0x2DEB540", Offset = "0x2DEA540", VA = "0x182DEB540")]
		[UsedImplicitly]
		public void LocalPlayerStartGivingOrders()
		{
		}

		// Token: 0x06002BA1 RID: 11169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BA1")]
		[Address(RVA = "0x2DE9AB0", Offset = "0x2DE8AB0", VA = "0x182DE9AB0")]
		private void InitPadIfNeeded()
		{
		}

		// Token: 0x06002BA2 RID: 11170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BA2")]
		[Address(RVA = "0x2DEC8C0", Offset = "0x2DEB8C0", VA = "0x182DEC8C0")]
		public void OnLocalPlayerGiveOrderFinished()
		{
		}

		// Token: 0x06002BA3 RID: 11171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BA3")]
		[Address(RVA = "0x2DEC8B0", Offset = "0x2DEB8B0", VA = "0x182DEC8B0")]
		public void OnLocalPlayerGiveOrderCancelled()
		{
		}

		// Token: 0x06002BA4 RID: 11172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BA4")]
		[Address(RVA = "0x2DEAE00", Offset = "0x2DE9E00", VA = "0x182DEAE00")]
		private void LocalPlayerOpenTactipad()
		{
		}

		// Token: 0x06002BA5 RID: 11173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BA5")]
		[Address(RVA = "0x2DEA220", Offset = "0x2DE9220", VA = "0x182DEA220")]
		private void LocalPlayerCloseTactipad(Robby.PadState newPadState)
		{
		}

		// Token: 0x06002BA6 RID: 11174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BA6")]
		[Address(RVA = "0x2DE9EC0", Offset = "0x2DE8EC0", VA = "0x182DE9EC0")]
		private void LocalPlayerCancelGiveOrders()
		{
		}

		// Token: 0x06002BA7 RID: 11175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BA7")]
		[Address(RVA = "0x2DEA5B0", Offset = "0x2DE95B0", VA = "0x182DEA5B0")]
		private void LocalPlayerGiveOrdersFromTactipad()
		{
		}

		// Token: 0x06002BA8 RID: 11176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BA8")]
		[Address(RVA = "0x2DEB200", Offset = "0x2DEA200", VA = "0x182DEB200")]
		private void LocalPlayerPadClosed(bool forceCancel = false)
		{
		}

		// Token: 0x06002BA9 RID: 11177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BA9")]
		[Address(RVA = "0x2DEB3B0", Offset = "0x2DEA3B0", VA = "0x182DEB3B0")]
		private void LocalPlayerStartFaceRobby()
		{
		}

		// Token: 0x06002BAA RID: 11178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BAA")]
		[Address(RVA = "0x2DEB610", Offset = "0x2DEA610", VA = "0x182DEB610")]
		private void LocalPlayerUpdateFaceRobby()
		{
		}

		// Token: 0x06002BAB RID: 11179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BAB")]
		[Address(RVA = "0x2DEB9E0", Offset = "0x2DEA9E0", VA = "0x182DEB9E0")]
		private void LockPlayer(bool locked)
		{
		}

		// Token: 0x06002BAC RID: 11180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BAC")]
		[Address(RVA = "0x2DE97C0", Offset = "0x2DE87C0", VA = "0x182DE97C0")]
		private void ForceFOV(float newFOV)
		{
		}

		// Token: 0x06002BAD RID: 11181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BAD")]
		[Address(RVA = "0x2DED130", Offset = "0x2DEC130", VA = "0x182DED130")]
		private static IEnumerator ResetFov(float targetVal, float resetFovTime)
		{
			return null;
		}

		// Token: 0x06002BAE RID: 11182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BAE")]
		[Address(RVA = "0x2DF1B10", Offset = "0x2DF0B10", VA = "0x182DF1B10")]
		public Robby()
		{
		}

		// Token: 0x040026D1 RID: 9937
		[Token(Token = "0x40026D1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private VailActor _actor;

		// Token: 0x040026D2 RID: 9938
		[Token(Token = "0x40026D2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _startInjured;

		// Token: 0x040026D3 RID: 9939
		[Token(Token = "0x40026D3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _axePrefab;

		// Token: 0x040026D4 RID: 9940
		[Token(Token = "0x40026D4")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GrabNode _grabNode;

		// Token: 0x040026D5 RID: 9941
		[Token(Token = "0x40026D5")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _injuredObject;

		// Token: 0x040026D6 RID: 9942
		[Token(Token = "0x40026D6")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ShoulderTapActor _shoulderTap;

		// Token: 0x040026D7 RID: 9943
		[Token(Token = "0x40026D7")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private bool _forcePlayerFaceRobby;

		// Token: 0x040026D8 RID: 9944
		[Token(Token = "0x40026D8")]
		[FieldOffset(Offset = "0x5C")]
		private float _faceLerpTime;

		// Token: 0x040026D9 RID: 9945
		[Token(Token = "0x40026D9")]
		[FieldOffset(Offset = "0x60")]
		private Quaternion _startPlayerRotation;

		// Token: 0x040026DA RID: 9946
		[Token(Token = "0x40026DA")]
		[FieldOffset(Offset = "0x70")]
		private Quaternion _targetPlayerRotation;

		// Token: 0x040026DB RID: 9947
		[Token(Token = "0x40026DB")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Transform _robbyRightHand;

		// Token: 0x040026DC RID: 9948
		[Token(Token = "0x40026DC")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private RobbyDropStimuli _dropLocationPrefab;

		// Token: 0x040026DD RID: 9949
		[Token(Token = "0x40026DD")]
		[FieldOffset(Offset = "0x90")]
		private bool _grabEnabled;

		// Token: 0x040026DE RID: 9950
		[Token(Token = "0x40026DE")]
		[FieldOffset(Offset = "0x94")]
		private Robby.DropLocationType _dropLocationType;

		// Token: 0x040026DF RID: 9951
		[Token(Token = "0x40026DF")]
		[FieldOffset(Offset = "0x98")]
		private Robby.InjuredState _injuredState;

		// Token: 0x040026E0 RID: 9952
		[Token(Token = "0x40026E0")]
		[FieldOffset(Offset = "0x9C")]
		private Robby.PadState _localPadState;

		// Token: 0x040026E1 RID: 9953
		[Token(Token = "0x40026E1")]
		[FieldOffset(Offset = "0xA0")]
		private int _injuredStateStartFrame;

		// Token: 0x040026E2 RID: 9954
		[Token(Token = "0x40026E2")]
		[FieldOffset(Offset = "0xA4")]
		private float _originalFov;

		// Token: 0x040026E3 RID: 9955
		[Token(Token = "0x40026E3")]
		[FieldOffset(Offset = "0xA8")]
		private bool _isFirstInteraction;

		// Token: 0x040026E4 RID: 9956
		[Token(Token = "0x40026E4")]
		[FieldOffset(Offset = "0xA9")]
		private bool _waitingForOrders;

		// Token: 0x040026E5 RID: 9957
		[Token(Token = "0x40026E5")]
		[FieldOffset(Offset = "0xAC")]
		private float _waitingForOrdersStartTime;

		// Token: 0x040026E6 RID: 9958
		[Token(Token = "0x40026E6")]
		[FieldOffset(Offset = "0xB0")]
		private PlayerStimuli _interactingPlayer;

		// Token: 0x040026E7 RID: 9959
		[Token(Token = "0x40026E7")]
		[FieldOffset(Offset = "0xB8")]
		private Transform _helpingPlayer;

		// Token: 0x040026E8 RID: 9960
		[Token(Token = "0x40026E8")]
		[FieldOffset(Offset = "0xC0")]
		private GameObject _axeHeld;

		// Token: 0x040026E9 RID: 9961
		[Token(Token = "0x40026E9")]
		[FieldOffset(Offset = "0xC8")]
		private Animator _robbyAnimator;

		// Token: 0x040026EA RID: 9962
		[Token(Token = "0x40026EA")]
		[FieldOffset(Offset = "0xD0")]
		private readonly List<Robby.LayerBlend> _layerBlends;

		// Token: 0x040026EB RID: 9963
		[Token(Token = "0x40026EB")]
		private const string RobbyTableReference = "Robby";

		// Token: 0x040026EC RID: 9964
		[Token(Token = "0x40026EC")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private VailControllerOverride _followPlayerOverride;

		// Token: 0x040026ED RID: 9965
		[Token(Token = "0x40026ED")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private RobbyOrderData _orderData;

		// Token: 0x040026EE RID: 9966
		[Token(Token = "0x40026EE")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private ReceiveItemsInteractionTrigger _receiveItems;

		// Token: 0x040026EF RID: 9967
		[Token(Token = "0x40026EF")]
		[FieldOffset(Offset = "0xF0")]
		private bool _drawBuildGizmos;

		// Token: 0x040026F0 RID: 9968
		[Token(Token = "0x40026F0")]
		[FieldOffset(Offset = "0xF4")]
		private float _debugBuildCheckRadius;

		// Token: 0x040026F1 RID: 9969
		[Token(Token = "0x40026F1")]
		[FieldOffset(Offset = "0xF8")]
		private Robby.RunningRobbyOrder _activeOrder;

		// Token: 0x040026F2 RID: 9970
		[Token(Token = "0x40026F2")]
		[FieldOffset(Offset = "0x100")]
		private Robby.ClearArea _currentClearArea;

		// Token: 0x040026F3 RID: 9971
		[Token(Token = "0x40026F3")]
		[FieldOffset(Offset = "0x108")]
		private RobbyDropStimuli _dropStimuliInstance;

		// Token: 0x040026F4 RID: 9972
		[Token(Token = "0x40026F4")]
		[FieldOffset(Offset = "0x110")]
		private RobbyClearStimuli _clearStimuliInstance;

		// Token: 0x040026F5 RID: 9973
		[Token(Token = "0x40026F5")]
		[FieldOffset(Offset = "0x118")]
		private RobbyClearTreeStimuli _clearTreeStimuliInstance;

		// Token: 0x040026F6 RID: 9974
		[Token(Token = "0x40026F6")]
		[FieldOffset(Offset = "0x120")]
		private RobbyFollowStimuli _followStimuliInstance;

		// Token: 0x040026F7 RID: 9975
		[Token(Token = "0x40026F7")]
		[FieldOffset(Offset = "0x128")]
		private OrderCompleteStimuli _orderCompleteStimuliInstance;

		// Token: 0x040026F8 RID: 9976
		[Token(Token = "0x40026F8")]
		[FieldOffset(Offset = "0x130")]
		private Transform _followTransform;

		// Token: 0x040026F9 RID: 9977
		[Token(Token = "0x40026F9")]
		[FieldOffset(Offset = "0x138")]
		private WorldObjectLocator _treeTarget;

		// Token: 0x040026FA RID: 9978
		[Token(Token = "0x40026FA")]
		[FieldOffset(Offset = "0x140")]
		private BuildActionStimuli _currentBuildStimuli;

		// Token: 0x040026FB RID: 9979
		[Token(Token = "0x40026FB")]
		[FieldOffset(Offset = "0x148")]
		private VailControllerOverride _activeOverride;

		// Token: 0x040026FC RID: 9980
		[Token(Token = "0x40026FC")]
		[FieldOffset(Offset = "0x150")]
		private VailControllerOverride _currentOrderOverride;

		// Token: 0x040026FD RID: 9981
		[Token(Token = "0x40026FD")]
		[FieldOffset(Offset = "0x158")]
		private readonly List<WorldObjectLocator> _treePositions;

		// Token: 0x040026FE RID: 9982
		[Token(Token = "0x40026FE")]
		[FieldOffset(Offset = "0x160")]
		private readonly List<Vector3> _bushPositions;

		// Token: 0x040026FF RID: 9983
		[Token(Token = "0x40026FF")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		private Transform _helpUpPlayerMarker;

		// Token: 0x04002700 RID: 9984
		[Token(Token = "0x4002700")]
		[FieldOffset(Offset = "0x170")]
		[EventRef]
		[SerializeField]
		private string _firstNoteEvent;

		// Token: 0x04002701 RID: 9985
		[Token(Token = "0x4002701")]
		[FieldOffset(Offset = "0x178")]
		[SerializeField]
		private bool _forceIntroFOV;

		// Token: 0x04002702 RID: 9986
		[Token(Token = "0x4002702")]
		[FieldOffset(Offset = "0x17C")]
		[SerializeField]
		private float _introFOV;

		// Token: 0x04002703 RID: 9987
		[Token(Token = "0x4002703")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		private float _resetFovTime;

		// Token: 0x04002704 RID: 9988
		[Token(Token = "0x4002704")]
		[FieldOffset(Offset = "0x188")]
		private RobbyWorldUi _tactiPad;

		// Token: 0x04002705 RID: 9989
		[Token(Token = "0x4002705")]
		[FieldOffset(Offset = "0x190")]
		private readonly ILayerBehaviourActivator[] _fullBodyDisableSpineActivators;

		// Token: 0x04002706 RID: 9990
		[Token(Token = "0x4002706")]
		[FieldOffset(Offset = "0x198")]
		private int _padStateChangeFrame;

		// Token: 0x0200069B RID: 1691
		[Token(Token = "0x200069B")]
		[Serializable]
		internal class RobbyBuildOrder : Robby.RobbyOrder
		{
			// Token: 0x06002BAF RID: 11183 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002BAF")]
			[Address(RVA = "0x2DE5C40", Offset = "0x2DE4C40", VA = "0x182DE5C40")]
			private static ValueDropdownList<string> GetStimuliTypes()
			{
				return null;
			}

			// Token: 0x06002BB0 RID: 11184 RVA: 0x0000C8B8 File Offset: 0x0000AAB8
			[Token(Token = "0x6002BB0")]
			[Address(RVA = "0x2DE5C90", Offset = "0x2DE4C90", VA = "0x182DE5C90", Slot = "4")]
			public override bool IsAllowed(VailActor robbyActor, Robby robby)
			{
				return default(bool);
			}

			// Token: 0x06002BB1 RID: 11185 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002BB1")]
			[Address(RVA = "0x2DE5E10", Offset = "0x2DE4E10", VA = "0x182DE5E10")]
			public RobbyBuildOrder()
			{
			}

			// Token: 0x04002707 RID: 9991
			[Token(Token = "0x4002707")]
			[FieldOffset(Offset = "0x40")]
			public BuildActionStimuli _buildPrefab;

			// Token: 0x04002708 RID: 9992
			[Token(Token = "0x4002708")]
			[FieldOffset(Offset = "0x48")]
			public string _buildStimuli;

			// Token: 0x04002709 RID: 9993
			[Token(Token = "0x4002709")]
			[FieldOffset(Offset = "0x50")]
			public bool _needTarp;

			// Token: 0x0400270A RID: 9994
			[Token(Token = "0x400270A")]
			[FieldOffset(Offset = "0x51")]
			public bool _clearStructure;

			// Token: 0x0400270B RID: 9995
			[Token(Token = "0x400270B")]
			[FieldOffset(Offset = "0x54")]
			public float _checkPhysicsRadius;
		}

		// Token: 0x0200069C RID: 1692
		[Token(Token = "0x200069C")]
		private static class AnimLayers
		{
			// Token: 0x0400270C RID: 9996
			[Token(Token = "0x400270C")]
			[FieldOffset(Offset = "0x0")]
			public static int Base;

			// Token: 0x0400270D RID: 9997
			[Token(Token = "0x400270D")]
			[FieldOffset(Offset = "0x4")]
			public static int UpperBody;

			// Token: 0x0400270E RID: 9998
			[Token(Token = "0x400270E")]
			[FieldOffset(Offset = "0x8")]
			public static int FullBody;
		}

		// Token: 0x0200069D RID: 1693
		[Token(Token = "0x200069D")]
		private enum InjuredState
		{
			// Token: 0x04002710 RID: 10000
			[Token(Token = "0x4002710")]
			None,
			// Token: 0x04002711 RID: 10001
			[Token(Token = "0x4002711")]
			Injured,
			// Token: 0x04002712 RID: 10002
			[Token(Token = "0x4002712")]
			GettingUp
		}

		// Token: 0x0200069E RID: 1694
		[Token(Token = "0x200069E")]
		private enum PadState
		{
			// Token: 0x04002714 RID: 10004
			[Token(Token = "0x4002714")]
			Closed,
			// Token: 0x04002715 RID: 10005
			[Token(Token = "0x4002715")]
			Open,
			// Token: 0x04002716 RID: 10006
			[Token(Token = "0x4002716")]
			GivingNote,
			// Token: 0x04002717 RID: 10007
			[Token(Token = "0x4002717")]
			LowerToGiveItem,
			// Token: 0x04002718 RID: 10008
			[Token(Token = "0x4002718")]
			Cancelling
		}

		// Token: 0x0200069F RID: 1695
		[Token(Token = "0x200069F")]
		private class LayerBlend
		{
			// Token: 0x06002BB3 RID: 11187 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002BB3")]
			[Address(RVA = "0x2DE1880", Offset = "0x2DE0880", VA = "0x182DE1880")]
			public LayerBlend(float defaultWeight)
			{
			}

			// Token: 0x04002719 RID: 10009
			[Token(Token = "0x4002719")]
			[FieldOffset(Offset = "0x10")]
			public float weight;

			// Token: 0x0400271A RID: 10010
			[Token(Token = "0x400271A")]
			[FieldOffset(Offset = "0x14")]
			public float targetWeight;
		}

		// Token: 0x020006A0 RID: 1696
		[Token(Token = "0x20006A0")]
		[Serializable]
		internal class RobbyOrder
		{
			// Token: 0x06002BB4 RID: 11188 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002BB4")]
			[Address(RVA = "0x2DE6040", Offset = "0x2DE5040", VA = "0x182DE6040")]
			private static ValueDropdownList<string> GetStimuliTypes()
			{
				return null;
			}

			// Token: 0x06002BB5 RID: 11189 RVA: 0x0000C8D0 File Offset: 0x0000AAD0
			[Token(Token = "0x6002BB5")]
			[Address(RVA = "0x2DE61D0", Offset = "0x2DE51D0", VA = "0x182DE61D0")]
			public bool NeedsStimuli()
			{
				return default(bool);
			}

			// Token: 0x06002BB6 RID: 11190 RVA: 0x0000C8E8 File Offset: 0x0000AAE8
			[Token(Token = "0x6002BB6")]
			[Address(RVA = "0x2DE6090", Offset = "0x2DE5090", VA = "0x182DE6090", Slot = "4")]
			public virtual bool IsAllowed(VailActor robbyActor, Robby robby)
			{
				return default(bool);
			}

			// Token: 0x06002BB7 RID: 11191 RVA: 0x0000C900 File Offset: 0x0000AB00
			[Token(Token = "0x6002BB7")]
			[Address(RVA = "0x53ABD0", Offset = "0x539BD0", VA = "0x18053ABD0", Slot = "5")]
			public virtual bool ShouldRefuse(VailActor robbyActor, Robby robby, Transform fromPlayer)
			{
				return default(bool);
			}

			// Token: 0x06002BB8 RID: 11192 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002BB8")]
			[Address(RVA = "0x2DE6200", Offset = "0x2DE5200", VA = "0x182DE6200")]
			private void RunOrderNow()
			{
			}

			// Token: 0x1700058B RID: 1419
			// (get) Token: 0x06002BB9 RID: 11193 RVA: 0x0000C918 File Offset: 0x0000AB18
			[Token(Token = "0x1700058B")]
			private bool IsPlaying
			{
				[Token(Token = "0x6002BB9")]
				[Address(RVA = "0x2DE62E0", Offset = "0x2DE52E0", VA = "0x182DE62E0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06002BBA RID: 11194 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002BBA")]
			[Address(RVA = "0x2DE5F80", Offset = "0x2DE4F80", VA = "0x182DE5F80")]
			public RobbyOrder()
			{
			}

			// Token: 0x0400271B RID: 10011
			[Token(Token = "0x400271B")]
			[FieldOffset(Offset = "0x10")]
			public string _itemName;

			// Token: 0x0400271C RID: 10012
			[Token(Token = "0x400271C")]
			[FieldOffset(Offset = "0x18")]
			public VailControllerOverride _controllerOverride;

			// Token: 0x0400271D RID: 10013
			[Token(Token = "0x400271D")]
			[FieldOffset(Offset = "0x20")]
			public bool _enabled;

			// Token: 0x0400271E RID: 10014
			[Token(Token = "0x400271E")]
			[FieldOffset(Offset = "0x28")]
			public string _needsStimuli;

			// Token: 0x0400271F RID: 10015
			[Token(Token = "0x400271F")]
			[FieldOffset(Offset = "0x30")]
			public float _maxStimuliRange;

			// Token: 0x04002720 RID: 10016
			[Token(Token = "0x4002720")]
			[FieldOffset(Offset = "0x38")]
			private Type _needsStimuliType;
		}

		// Token: 0x020006A1 RID: 1697
		[Token(Token = "0x20006A1")]
		[Serializable]
		internal class RobbyClearOrder : Robby.RobbyOrder
		{
			// Token: 0x06002BBB RID: 11195 RVA: 0x0000C930 File Offset: 0x0000AB30
			[Token(Token = "0x6002BBB")]
			[Address(RVA = "0x2DE5E60", Offset = "0x2DE4E60", VA = "0x182DE5E60", Slot = "5")]
			public override bool ShouldRefuse(VailActor robbyActor, Robby robby, Transform fromPlayer)
			{
				return default(bool);
			}

			// Token: 0x06002BBC RID: 11196 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002BBC")]
			[Address(RVA = "0x2DE5F80", Offset = "0x2DE4F80", VA = "0x182DE5F80")]
			public RobbyClearOrder()
			{
			}

			// Token: 0x04002721 RID: 10017
			[Token(Token = "0x4002721")]
			[FieldOffset(Offset = "0x40")]
			public float _clearRadius;
		}

		// Token: 0x020006A2 RID: 1698
		[Token(Token = "0x20006A2")]
		[Serializable]
		internal class RobbyGetOrder : Robby.RobbyOrder
		{
			// Token: 0x06002BBD RID: 11197 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002BBD")]
			[Address(RVA = "0x2DE5FC0", Offset = "0x2DE4FC0", VA = "0x182DE5FC0")]
			private static ValueDropdownList<string> GetItemTypes()
			{
				return null;
			}

			// Token: 0x06002BBE RID: 11198 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002BBE")]
			[Address(RVA = "0x2DE6000", Offset = "0x2DE5000", VA = "0x182DE6000")]
			public RobbyGetOrder()
			{
			}

			// Token: 0x04002722 RID: 10018
			[Token(Token = "0x4002722")]
			[FieldOffset(Offset = "0x40")]
			public string _itemType;

			// Token: 0x04002723 RID: 10019
			[Token(Token = "0x4002723")]
			[FieldOffset(Offset = "0x48")]
			public float _expireTimeMinutes;
		}

		// Token: 0x020006A3 RID: 1699
		[Token(Token = "0x20006A3")]
		[Serializable]
		internal class RobbyMaintainOrder : Robby.RobbyOrder
		{
			// Token: 0x06002BBF RID: 11199 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002BBF")]
			[Address(RVA = "0x2DE5F80", Offset = "0x2DE4F80", VA = "0x182DE5F80")]
			public RobbyMaintainOrder()
			{
			}
		}

		// Token: 0x020006A4 RID: 1700
		[Token(Token = "0x20006A4")]
		[Serializable]
		internal class RobbyStayOrder : Robby.RobbyOrder
		{
			// Token: 0x06002BC0 RID: 11200 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002BC0")]
			[Address(RVA = "0x2DE5F80", Offset = "0x2DE4F80", VA = "0x182DE5F80")]
			public RobbyStayOrder()
			{
			}
		}

		// Token: 0x020006A5 RID: 1701
		[Token(Token = "0x20006A5")]
		private class RunningRobbyOrder
		{
			// Token: 0x06002BC1 RID: 11201 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002BC1")]
			[Address(RVA = "0x2DF20B0", Offset = "0x2DF10B0", VA = "0x182DF20B0")]
			public RunningRobbyOrder(Robby.RobbyOrder order)
			{
			}

			// Token: 0x1700058C RID: 1420
			// (get) Token: 0x06002BC2 RID: 11202 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700058C")]
			public Robby.RobbyOrder OrderData
			{
				[Token(Token = "0x6002BC2")]
				[Address(RVA = "0x57B1D0", Offset = "0x57A1D0", VA = "0x18057B1D0")]
				get
				{
					return null;
				}
			}

			// Token: 0x06002BC3 RID: 11203 RVA: 0x0000C948 File Offset: 0x0000AB48
			[Token(Token = "0x6002BC3")]
			[Address(RVA = "0x2DF1DC0", Offset = "0x2DF0DC0", VA = "0x182DF1DC0")]
			public bool IsCompleteByTime(VailActor actor)
			{
				return default(bool);
			}

			// Token: 0x06002BC4 RID: 11204 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002BC4")]
			[Address(RVA = "0x1869CA0", Offset = "0x1868CA0", VA = "0x181869CA0")]
			public void SetCompleted()
			{
			}

			// Token: 0x1700058D RID: 1421
			// (get) Token: 0x06002BC5 RID: 11205 RVA: 0x0000C960 File Offset: 0x0000AB60
			[Token(Token = "0x1700058D")]
			public bool IsCompleteByCallback
			{
				[Token(Token = "0x6002BC5")]
				[Address(RVA = "0x576320", Offset = "0x575320", VA = "0x180576320")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06002BC6 RID: 11206 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002BC6")]
			[Address(RVA = "0x2DF2000", Offset = "0x2DF1000", VA = "0x182DF2000")]
			public void ResetStartTime(float offset = 0f)
			{
			}

			// Token: 0x06002BC7 RID: 11207 RVA: 0x0000C978 File Offset: 0x0000AB78
			[Token(Token = "0x6002BC7")]
			[Address(RVA = "0x2DF2030", Offset = "0x2DF1030", VA = "0x182DF2030")]
			public bool ShowAxe()
			{
				return default(bool);
			}

			// Token: 0x06002BC8 RID: 11208 RVA: 0x0000C990 File Offset: 0x0000AB90
			[Token(Token = "0x6002BC8")]
			[Address(RVA = "0x2DF1F70", Offset = "0x2DF0F70", VA = "0x182DF1F70")]
			public bool NeedsTreeStimuli()
			{
				return default(bool);
			}

			// Token: 0x06002BC9 RID: 11209 RVA: 0x0000C9A8 File Offset: 0x0000ABA8
			[Token(Token = "0x6002BC9")]
			[Address(RVA = "0x2DF1EF0", Offset = "0x2DF0EF0", VA = "0x182DF1EF0")]
			public bool IsType(Type orderType)
			{
				return default(bool);
			}

			// Token: 0x06002BCA RID: 11210 RVA: 0x0000C9C0 File Offset: 0x0000ABC0
			[Token(Token = "0x6002BCA")]
			[Address(RVA = "0x2DF1E80", Offset = "0x2DF0E80", VA = "0x182DF1E80")]
			public bool IsDismantle()
			{
				return default(bool);
			}

			// Token: 0x04002724 RID: 10020
			[Token(Token = "0x4002724")]
			[FieldOffset(Offset = "0x10")]
			private float _startTime;

			// Token: 0x04002725 RID: 10021
			[Token(Token = "0x4002725")]
			[FieldOffset(Offset = "0x14")]
			private bool _receivedCompleted;

			// Token: 0x04002726 RID: 10022
			[Token(Token = "0x4002726")]
			[FieldOffset(Offset = "0x18")]
			private readonly Robby.RobbyOrder _order;
		}

		// Token: 0x020006A6 RID: 1702
		[Token(Token = "0x20006A6")]
		public enum OrderType
		{
			// Token: 0x04002728 RID: 10024
			[Token(Token = "0x4002728")]
			Follow,
			// Token: 0x04002729 RID: 10025
			[Token(Token = "0x4002729")]
			Get,
			// Token: 0x0400272A RID: 10026
			[Token(Token = "0x400272A")]
			Build,
			// Token: 0x0400272B RID: 10027
			[Token(Token = "0x400272B")]
			StayHere,
			// Token: 0x0400272C RID: 10028
			[Token(Token = "0x400272C")]
			TakeBreak,
			// Token: 0x0400272D RID: 10029
			[Token(Token = "0x400272D")]
			Equip,
			// Token: 0x0400272E RID: 10030
			[Token(Token = "0x400272E")]
			ClearArea,
			// Token: 0x0400272F RID: 10031
			[Token(Token = "0x400272F")]
			MaintainBase
		}

		// Token: 0x020006A7 RID: 1703
		[Token(Token = "0x20006A7")]
		private enum CarouselName
		{
			// Token: 0x04002731 RID: 10033
			[Token(Token = "0x4002731")]
			Action,
			// Token: 0x04002732 RID: 10034
			[Token(Token = "0x4002732")]
			GetItem,
			// Token: 0x04002733 RID: 10035
			[Token(Token = "0x4002733")]
			BuildItem,
			// Token: 0x04002734 RID: 10036
			[Token(Token = "0x4002734")]
			Equip,
			// Token: 0x04002735 RID: 10037
			[Token(Token = "0x4002735")]
			Area,
			// Token: 0x04002736 RID: 10038
			[Token(Token = "0x4002736")]
			DropLocation,
			// Token: 0x04002737 RID: 10039
			[Token(Token = "0x4002737")]
			StayType,
			// Token: 0x04002738 RID: 10040
			[Token(Token = "0x4002738")]
			MaintainBase,
			// Token: 0x04002739 RID: 10041
			[Token(Token = "0x4002739")]
			None = -1
		}

		// Token: 0x020006A8 RID: 1704
		[Token(Token = "0x20006A8")]
		private enum DropLocationType
		{
			// Token: 0x0400273B RID: 10043
			[Token(Token = "0x400273B")]
			DropHere,
			// Token: 0x0400273C RID: 10044
			[Token(Token = "0x400273C")]
			GiveToMe,
			// Token: 0x0400273D RID: 10045
			[Token(Token = "0x400273D")]
			FollowMe,
			// Token: 0x0400273E RID: 10046
			[Token(Token = "0x400273E")]
			FillHolder
		}

		// Token: 0x020006A9 RID: 1705
		[Token(Token = "0x20006A9")]
		private enum OrderEventType
		{
			// Token: 0x04002740 RID: 10048
			[Token(Token = "0x4002740")]
			WaitForOrders,
			// Token: 0x04002741 RID: 10049
			[Token(Token = "0x4002741")]
			FinishOrderGiveNote,
			// Token: 0x04002742 RID: 10050
			[Token(Token = "0x4002742")]
			GiveOrders,
			// Token: 0x04002743 RID: 10051
			[Token(Token = "0x4002743")]
			CancelWaitForOrder,
			// Token: 0x04002744 RID: 10052
			[Token(Token = "0x4002744")]
			CancelAnyOrders,
			// Token: 0x04002745 RID: 10053
			[Token(Token = "0x4002745")]
			HelpUp,
			// Token: 0x04002746 RID: 10054
			[Token(Token = "0x4002746")]
			HelpUpFinished,
			// Token: 0x04002747 RID: 10055
			[Token(Token = "0x4002747")]
			FinishOrderNoNote
		}

		// Token: 0x020006AA RID: 1706
		[Token(Token = "0x20006AA")]
		private class ClearArea
		{
			// Token: 0x06002BCB RID: 11211 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002BCB")]
			[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
			public ClearArea()
			{
			}

			// Token: 0x04002748 RID: 10056
			[Token(Token = "0x4002748")]
			[FieldOffset(Offset = "0x10")]
			public Vector3 Position;

			// Token: 0x04002749 RID: 10057
			[Token(Token = "0x4002749")]
			[FieldOffset(Offset = "0x1C")]
			public float Radius;
		}
	}
}
