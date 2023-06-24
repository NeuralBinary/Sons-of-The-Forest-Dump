using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Animation;
using UnityEngine;

namespace Construction.Anim
{
	// Token: 0x020002C5 RID: 709
	[Token(Token = "0x20002C5")]
	[AddComponentMenu("Sons/Construction/PlayerBuildingModeAction")]
	public class PlayerBuildingModeAction : MonoBehaviour, IPlayerBuildingModeAction, IPostIKUpdater
	{
		// Token: 0x0600156D RID: 5485 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600156D")]
		[Address(RVA = "0x2DFA410", Offset = "0x2DF8A10", VA = "0x182DFA410")]
		public void TargetStateBeginLiveUpdate()
		{
		}

		// Token: 0x0600156E RID: 5486 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600156E")]
		[Address(RVA = "0x2DFA510", Offset = "0x2DF8B10", VA = "0x182DFA510")]
		public void TargetStateLiveUpdate()
		{
		}

		// Token: 0x0600156F RID: 5487 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600156F")]
		[Address(RVA = "0x2DFA630", Offset = "0x2DF8C30", VA = "0x182DFA630")]
		public void TargetStateReachTriggerTime()
		{
		}

		// Token: 0x06001570 RID: 5488 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001570")]
		[Address(RVA = "0x2DFA730", Offset = "0x2DF8D30", VA = "0x182DFA730")]
		public void TargetStateReachExitTime()
		{
		}

		// Token: 0x06001571 RID: 5489 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001571")]
		[Address(RVA = "0x2DFA830", Offset = "0x2DF8E30", VA = "0x182DFA830")]
		public void TargetStateReachBouncePartialExitTime()
		{
		}

		// Token: 0x06001572 RID: 5490 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001572")]
		[Address(RVA = "0x2DFA930", Offset = "0x2DF8F30", VA = "0x182DFA930")]
		public void EnableLeftHandAxe()
		{
		}

		// Token: 0x06001573 RID: 5491 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001573")]
		[Address(RVA = "0x2DFAA10", Offset = "0x2DF9010", VA = "0x182DFAA10")]
		public void DisableLeftHandAxe()
		{
		}

		// Token: 0x06001574 RID: 5492 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001574")]
		[Address(RVA = "0x2DFAAF0", Offset = "0x2DF90F0", VA = "0x182DFAAF0")]
		public void StopLiveUpdate()
		{
		}

		// Token: 0x06001575 RID: 5493 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001575")]
		[Address(RVA = "0x2DFABF0", Offset = "0x2DF91F0", VA = "0x182DFABF0")]
		public void BeginPerfectFinishIk()
		{
		}

		// Token: 0x06001576 RID: 5494 RVA: 0x0000C1AC File Offset: 0x0000A3AC
		[Token(Token = "0x6001576")]
		[Address(RVA = "0x2DFACF0", Offset = "0x2DF92F0", VA = "0x182DFACF0")]
		private bool CheckValidAnimEventSequencer()
		{
			return default(bool);
		}

		// Token: 0x06001577 RID: 5495 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001577")]
		[Address(RVA = "0x2DFAD40", Offset = "0x2DF9340", VA = "0x182DFAD40")]
		private void LateUpdate()
		{
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06001578 RID: 5496 RVA: 0x0000C1C4 File Offset: 0x0000A3C4
		// (set) Token: 0x06001579 RID: 5497 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000482")]
		public bool PlaceMode
		{
			[Token(Token = "0x6001578")]
			[Address(RVA = "0x61C530", Offset = "0x61AB30", VA = "0x18061C530")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001579")]
			[Address(RVA = "0x61C540", Offset = "0x61AB40", VA = "0x18061C540")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x0600157A RID: 5498 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000483")]
		public BuildActionAccessories Accessories
		{
			[Token(Token = "0x600157A")]
			[Address(RVA = "0x6710C0", Offset = "0x66F6C0", VA = "0x1806710C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x0600157B RID: 5499 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000484")]
		public GameObject RightHandItemsRootX
		{
			[Token(Token = "0x600157B")]
			[Address(RVA = "0x737410", Offset = "0x735A10", VA = "0x180737410", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x0600157C RID: 5500 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000485")]
		public GameObject HeldLogsVisOverrideX
		{
			[Token(Token = "0x600157C")]
			[Address(RVA = "0x6306D0", Offset = "0x62ECD0", VA = "0x1806306D0", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x0600157D RID: 5501 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x0600157E RID: 5502 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000486")]
		public IConstructionAnimationActor Actor
		{
			[Token(Token = "0x600157D")]
			[Address(RVA = "0x61C550", Offset = "0x61AB50", VA = "0x18061C550", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600157E")]
			[Address(RVA = "0x61C560", Offset = "0x61AB60", VA = "0x18061C560")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x0600157F RID: 5503 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000487")]
		public IConstructionModule RunningSequencerModule
		{
			[Token(Token = "0x600157F")]
			[Address(RVA = "0x784A30", Offset = "0x783030", VA = "0x180784A30", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06001580 RID: 5504 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000488")]
		public StructureElement RunningSequencerPrefab
		{
			[Token(Token = "0x6001580")]
			[Address(RVA = "0x784AA0", Offset = "0x7830A0", VA = "0x180784AA0", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06001581 RID: 5505 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x06001582 RID: 5506 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000489")]
		public Action OnMoveCallback
		{
			[Token(Token = "0x6001581")]
			[Address(RVA = "0x2A3B6D0", Offset = "0x2A39CD0", VA = "0x182A3B6D0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001582")]
			[Address(RVA = "0x2DFAD90", Offset = "0x2DF9390", VA = "0x182DFAD90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06001583 RID: 5507 RVA: 0x0000C1DC File Offset: 0x0000A3DC
		[Token(Token = "0x1700048A")]
		public bool IsRemote
		{
			[Token(Token = "0x6001583")]
			[Address(RVA = "0x2DFADF0", Offset = "0x2DF93F0", VA = "0x182DFADF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06001584 RID: 5508 RVA: 0x0000C1F4 File Offset: 0x0000A3F4
		[Token(Token = "0x1700048B")]
		public bool SyncToRemote
		{
			[Token(Token = "0x6001584")]
			[Address(RVA = "0xA03DD0", Offset = "0xA023D0", VA = "0x180A03DD0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001585 RID: 5509 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001585")]
		[Address(RVA = "0x2DFAEB0", Offset = "0x2DF94B0", VA = "0x182DFAEB0")]
		private void Awake()
		{
		}

		// Token: 0x06001586 RID: 5510 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001586")]
		[Address(RVA = "0x2DFAD90", Offset = "0x2DF9390", VA = "0x182DFAD90")]
		public void RegisterMoveCallback(Action moveCallback)
		{
		}

		// Token: 0x06001587 RID: 5511 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001587")]
		[Address(RVA = "0x2DFBAE0", Offset = "0x2DFA0E0", VA = "0x182DFBAE0")]
		public void BeginPlace(int triggerParameterHash, int triggerParameterValue)
		{
		}

		// Token: 0x06001588 RID: 5512 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001588")]
		[Address(RVA = "0x2DFBBD0", Offset = "0x2DFA1D0", VA = "0x182DFBBD0", Slot = "11")]
		public void TriggerPartialPlace()
		{
		}

		// Token: 0x06001589 RID: 5513 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001589")]
		[Address(RVA = "0x2DFBD20", Offset = "0x2DFA320", VA = "0x182DFBD20", Slot = "12")]
		public void TriggerPlace()
		{
		}

		// Token: 0x0600158A RID: 5514 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600158A")]
		[Address(RVA = "0x2DFBEA0", Offset = "0x2DFA4A0", VA = "0x182DFBEA0")]
		public void Register(IPlaceActionCompletedReceiver placeActionCompletedReceiver)
		{
		}

		// Token: 0x0600158B RID: 5515 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600158B")]
		[Address(RVA = "0x2DFBFB0", Offset = "0x2DFA5B0", VA = "0x182DFBFB0")]
		public void UnRegister(IPlaceActionCompletedReceiver placeActionCompletedReceiver)
		{
		}

		// Token: 0x0600158C RID: 5516 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600158C")]
		[Address(RVA = "0x2DFC010", Offset = "0x2DFA610", VA = "0x182DFC010")]
		private void Run(IAnimationSequencer newSequencer, IConstructionModule newSequencerModule, StructureElement newSequencerPrefab, bool syncToRemote)
		{
		}

		// Token: 0x0600158D RID: 5517 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600158D")]
		[Address(RVA = "0x2DFC330", Offset = "0x2DFA930", VA = "0x182DFC330")]
		private void KillRunningSequencer(bool forceCancel)
		{
		}

		// Token: 0x0600158E RID: 5518 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600158E")]
		[Address(RVA = "0x2DFC4C0", Offset = "0x2DFAAC0", VA = "0x182DFC4C0")]
		private void ClearSequencer()
		{
		}

		// Token: 0x0600158F RID: 5519 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600158F")]
		[Address(RVA = "0x2DFC5D0", Offset = "0x2DFABD0", VA = "0x182DFC5D0")]
		private void ClearNextSequencer()
		{
		}

		// Token: 0x06001590 RID: 5520 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001590")]
		[Address(RVA = "0x2DFC6E0", Offset = "0x2DFACE0", VA = "0x182DFC6E0")]
		public void CrashCancelAnim()
		{
		}

		// Token: 0x06001591 RID: 5521 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001591")]
		[Address(RVA = "0x2DFC800", Offset = "0x2DFAE00", VA = "0x182DFC800")]
		public void TogglePlacementPromptState(bool onOff, IConstructionModule activeModule)
		{
		}

		// Token: 0x06001592 RID: 5522 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001592")]
		[Address(RVA = "0x2DFC820", Offset = "0x2DFAE20", VA = "0x182DFC820")]
		public void EnableBuildMode(object caller)
		{
		}

		// Token: 0x06001593 RID: 5523 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001593")]
		[Address(RVA = "0x2DFC930", Offset = "0x2DFAF30", VA = "0x182DFC930")]
		public void DisableBuildMode(object caller, bool forceCancel = false)
		{
		}

		// Token: 0x06001594 RID: 5524 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001594")]
		[Address(RVA = "0x2DFCB10", Offset = "0x2DFB110", VA = "0x182DFCB10")]
		public void ToggleLeftHandAxe(bool isOn)
		{
		}

		// Token: 0x06001595 RID: 5525 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6001595")]
		[Address(RVA = "0x2DFCE00", Offset = "0x2DFB400", VA = "0x182DFCE00", Slot = "16")]
		public IEnumerator StashLeftHandItem(Action onStashedCallback)
		{
			return null;
		}

		// Token: 0x06001596 RID: 5526 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001596")]
		[Address(RVA = "0x2DFCF00", Offset = "0x2DFB500", VA = "0x182DFCF00", Slot = "17")]
		public void OnPostIkUpdate()
		{
		}

		// Token: 0x06001597 RID: 5527 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001597")]
		[Address(RVA = "0x61C560", Offset = "0x61AB60", VA = "0x18061C560")]
		public void Register(IConstructionAnimationActor actor)
		{
		}

		// Token: 0x06001598 RID: 5528 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001598")]
		[Address(RVA = "0x750FB0", Offset = "0x74F5B0", VA = "0x180750FB0")]
		public void Register(IStoppedPlaceActionReceiver stoppedPlaceActionReceiver)
		{
		}

		// Token: 0x06001599 RID: 5529 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001599")]
		[Address(RVA = "0x2DFCF50", Offset = "0x2DFB550", VA = "0x182DFCF50")]
		public void RegisterLayerActivators(ILayerBehaviourActivator[] activators, ILayerBehaviourActivator[] disablers)
		{
		}

		// Token: 0x0600159A RID: 5530 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600159A")]
		[Address(RVA = "0x2DFD060", Offset = "0x2DFB660", VA = "0x182DFD060", Slot = "13")]
		public void UnregisterLayerActivators(ILayerBehaviourActivator[] activators, ILayerBehaviourActivator[] disablers)
		{
		}

		// Token: 0x0600159B RID: 5531 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600159B")]
		[Address(RVA = "0x2DFD170", Offset = "0x2DFB770", VA = "0x182DFD170")]
		private void Register(PlaceElementTypes animType, IAnimationSequencer sequencer)
		{
		}

		// Token: 0x0600159C RID: 5532 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600159C")]
		[Address(RVA = "0x2DFD1F0", Offset = "0x2DFB7F0", VA = "0x182DFD1F0")]
		public void Play(PlaceElementTypes animType, TargetInfo targetInfo, IConstructionModule module, StructureElement prefab, bool syncToRemote)
		{
		}

		// Token: 0x0600159D RID: 5533 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600159D")]
		[Address(RVA = "0x2DFD2D0", Offset = "0x2DFB8D0", VA = "0x182DFD2D0")]
		public void DelayDisableRemoteBuildMode()
		{
		}

		// Token: 0x0600159E RID: 5534 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600159E")]
		[Address(RVA = "0x728460", Offset = "0x726A60", VA = "0x180728460")]
		public void SetPerfectFinishIK(IPerfectFinishSettings perfectFinish)
		{
		}

		// Token: 0x0600159F RID: 5535 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600159F")]
		[Address(RVA = "0x2DFD370", Offset = "0x2DFB970", VA = "0x182DFD370", Slot = "15")]
		public void MakeRightHeldRendererFinishPerfect(IIkSingleGoalProviderModule goalProvider, TargetInfo targetInfo, StructureElement prefab, float ikDelay, float ikSmoothDuration)
		{
		}

		// Token: 0x060015A0 RID: 5536 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015A0")]
		[Address(RVA = "0x2DFD600", Offset = "0x2DFBC00", VA = "0x182DFD600")]
		private void MakeRightHeldRendererFinishPerfect(TargetInfo targetInfo, float ikDelay, float ikSmoothDuration)
		{
		}

		// Token: 0x060015A1 RID: 5537 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015A1")]
		[Address(RVA = "0x2DFD860", Offset = "0x2DFBE60", VA = "0x182DFD860", Slot = "14")]
		public void CheckPerfectFinish()
		{
		}

		// Token: 0x060015A2 RID: 5538 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015A2")]
		[Address(RVA = "0x8ECC90", Offset = "0x8EB290", VA = "0x1808ECC90")]
		public void SetAnimationSfx(IAnimationSfx animSfx)
		{
		}

		// Token: 0x060015A3 RID: 5539 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015A3")]
		[Address(RVA = "0x2DFDA30", Offset = "0x2DFC030", VA = "0x182DFDA30")]
		public void PlaySfx1RightHand()
		{
		}

		// Token: 0x060015A4 RID: 5540 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015A4")]
		[Address(RVA = "0x2DFDB80", Offset = "0x2DFC180", VA = "0x182DFDB80")]
		public void PlaySfx2RightHand()
		{
		}

		// Token: 0x060015A5 RID: 5541 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015A5")]
		[Address(RVA = "0x2DFDCE0", Offset = "0x2DFC2E0", VA = "0x182DFDCE0")]
		public void PlaySfx1LeftHand()
		{
		}

		// Token: 0x060015A6 RID: 5542 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015A6")]
		[Address(RVA = "0x2DFDE30", Offset = "0x2DFC430", VA = "0x182DFDE30")]
		public void PlaySfx2LeftHand()
		{
		}

		// Token: 0x060015A7 RID: 5543 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015A7")]
		[Address(RVA = "0x2DFDF90", Offset = "0x2DFC590", VA = "0x182DFDF90")]
		public PlayerBuildingModeAction()
		{
		}

		// Token: 0x060015A8 RID: 5544 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015A8")]
		[Address(RVA = "0x2DFE110", Offset = "0x2DFC710", VA = "0x182DFE110")]
		[CompilerGenerated]
		private void <ToggleLeftHandAxe>g__OnStashedCallback|87_0()
		{
		}

		// Token: 0x04000A79 RID: 2681
		[Token(Token = "0x4000A79")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Header("Systems")]
		private ConstructionSettings _constructionSettings;

		// Token: 0x04000A7A RID: 2682
		[Token(Token = "0x4000A7A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ConstructionManager Manager;

		// Token: 0x04000A7B RID: 2683
		[Token(Token = "0x4000A7B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AnimatorLayersController LayersController;

		// Token: 0x04000A7C RID: 2684
		[Token(Token = "0x4000A7C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private IkTargetsController IkTargetsController;

		// Token: 0x04000A7D RID: 2685
		[Token(Token = "0x4000A7D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private LogVisibilityController LogVisibilityController;

		// Token: 0x04000A7E RID: 2686
		[Token(Token = "0x4000A7E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private BuildActionAccessories _accessories;

		// Token: 0x04000A7F RID: 2687
		[Token(Token = "0x4000A7F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Header("Props")]
		private GameObject RepositioningBeamLookAt;

		// Token: 0x04000A80 RID: 2688
		[Token(Token = "0x4000A80")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject RepositioningBeamWithStrutLookAtRight;

		// Token: 0x04000A81 RID: 2689
		[Token(Token = "0x4000A81")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject RepositioningBeamWithStrutLookAtLeft;

		// Token: 0x04000A82 RID: 2690
		[Token(Token = "0x4000A82")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private IkFakeBone AttachTarpLookAt;

		// Token: 0x04000A83 RID: 2691
		[Token(Token = "0x4000A83")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject StickClothCollider;

		// Token: 0x04000A84 RID: 2692
		[Token(Token = "0x4000A84")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject HeldLogsVisOverride;

		// Token: 0x04000A85 RID: 2693
		[Token(Token = "0x4000A85")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject RightHandItemsRoot;

		// Token: 0x04000A86 RID: 2694
		[Token(Token = "0x4000A86")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Header("Debug")]
		private bool _verboseBuildModeState;

		// Token: 0x04000A87 RID: 2695
		[Token(Token = "0x4000A87")]
		[FieldOffset(Offset = "0x89")]
		[SerializeField]
		private bool _verboseSequencerOperations;

		// Token: 0x04000A88 RID: 2696
		[Token(Token = "0x4000A88")]
		[FieldOffset(Offset = "0x8A")]
		[SerializeField]
		private bool _verboseAnimEvents;

		// Token: 0x04000A89 RID: 2697
		[Token(Token = "0x4000A89")]
		[FieldOffset(Offset = "0x90")]
		private readonly Dictionary<PlaceElementTypes, IAnimationSequencer> _sequencers;

		// Token: 0x04000A8A RID: 2698
		[Token(Token = "0x4000A8A")]
		[FieldOffset(Offset = "0x98")]
		private IPlaceActionBeganReceiver _placeActionBeganReceiver;

		// Token: 0x04000A8B RID: 2699
		[Token(Token = "0x4000A8B")]
		[FieldOffset(Offset = "0xA0")]
		private IStoppedPlaceActionReceiver _stoppedPlaceActionReceiver;

		// Token: 0x04000A8C RID: 2700
		[Token(Token = "0x4000A8C")]
		[FieldOffset(Offset = "0xA8")]
		private List<IPlaceActionCompletedReceiver> _placeActionCompletedReceivers;

		// Token: 0x04000A8D RID: 2701
		[Token(Token = "0x4000A8D")]
		[FieldOffset(Offset = "0xB0")]
		private IPlaceActionFinishedReceiver _placeActionFinishedReceiver;

		// Token: 0x04000A8E RID: 2702
		[Token(Token = "0x4000A8E")]
		[FieldOffset(Offset = "0xB8")]
		private IPerfectFinishSettings _perfectFinish;

		// Token: 0x04000A8F RID: 2703
		[Token(Token = "0x4000A8F")]
		[FieldOffset(Offset = "0xC0")]
		private IAnimationSfx _animSFX;

		// Token: 0x04000A90 RID: 2704
		[Token(Token = "0x4000A90")]
		[FieldOffset(Offset = "0xC8")]
		private IAnimationSequencer _runningSequencer;

		// Token: 0x04000A91 RID: 2705
		[Token(Token = "0x4000A91")]
		[FieldOffset(Offset = "0xD0")]
		private IConstructionModule _runningSequencerModule;

		// Token: 0x04000A92 RID: 2706
		[Token(Token = "0x4000A92")]
		[FieldOffset(Offset = "0xD8")]
		private StructureElement _runningSequencerPrefab;

		// Token: 0x04000A93 RID: 2707
		[Token(Token = "0x4000A93")]
		[FieldOffset(Offset = "0xE0")]
		private bool _runningSequencerSyncToRemote;

		// Token: 0x04000A94 RID: 2708
		[Token(Token = "0x4000A94")]
		[FieldOffset(Offset = "0xE8")]
		private IAnimationSequencer _nextSequencerToRun;

		// Token: 0x04000A95 RID: 2709
		[Token(Token = "0x4000A95")]
		[FieldOffset(Offset = "0xF0")]
		private IConstructionModule _nextSequencerToRunModule;

		// Token: 0x04000A96 RID: 2710
		[Token(Token = "0x4000A96")]
		[FieldOffset(Offset = "0xF8")]
		private StructureElement _nextSequencerToRunPrefab;

		// Token: 0x04000A97 RID: 2711
		[Token(Token = "0x4000A97")]
		[FieldOffset(Offset = "0x100")]
		private bool _nextSequencerSyncToRemote;

		// Token: 0x04000A98 RID: 2712
		[Token(Token = "0x4000A98")]
		[FieldOffset(Offset = "0x108")]
		private Coroutine _runningSequencerRoutine;

		// Token: 0x04000A99 RID: 2713
		[Token(Token = "0x4000A99")]
		[FieldOffset(Offset = "0x110")]
		private GameObject _stickClothColliderInstance;

		// Token: 0x04000A9A RID: 2714
		[Token(Token = "0x4000A9A")]
		[FieldOffset(Offset = "0x118")]
		private Coroutine _stashLeftHandRoutine;

		// Token: 0x04000A9E RID: 2718
		[Token(Token = "0x4000A9E")]
		[FieldOffset(Offset = "0x138")]
		private object _lastCaller;
	}
}
