using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using PathologicalGames;
using Sons.Cutscenes;
using Sons.Environment.Digging.TerrainDig;
using Sons.FieldOfView;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Animation.PlayerControl
{
	// Token: 0x020008B8 RID: 2232
	[Token(Token = "0x20008B8")]
	public class BuriedEnterHatchTrigger : DoorTriggerCutsceneBase
	{
		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x06003C25 RID: 15397 RVA: 0x00011838 File Offset: 0x0000FA38
		[Token(Token = "0x17000767")]
		protected override int IdleOpenAnimHash
		{
			[Token(Token = "0x6003C25")]
			[Address(RVA = "0x2F0F820", Offset = "0x2F0E820", VA = "0x182F0F820", Slot = "18")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x06003C26 RID: 15398 RVA: 0x00011850 File Offset: 0x0000FA50
		[Token(Token = "0x17000768")]
		protected override int IdleClosedAnimHash
		{
			[Token(Token = "0x6003C26")]
			[Address(RVA = "0x2F0F7C0", Offset = "0x2F0E7C0", VA = "0x182F0F7C0", Slot = "19")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x06003C27 RID: 15399 RVA: 0x00011868 File Offset: 0x0000FA68
		[Token(Token = "0x17000769")]
		protected override int EnterAnimHash
		{
			[Token(Token = "0x6003C27")]
			[Address(RVA = "0x2F0F760", Offset = "0x2F0E760", VA = "0x182F0F760", Slot = "20")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x06003C28 RID: 15400 RVA: 0x00011880 File Offset: 0x0000FA80
		[Token(Token = "0x1700076A")]
		protected override int EnterAnimBoolHash
		{
			[Token(Token = "0x6003C28")]
			[Address(RVA = "0x2F0F700", Offset = "0x2F0E700", VA = "0x182F0F700", Slot = "21")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x06003C29 RID: 15401 RVA: 0x00011898 File Offset: 0x0000FA98
		[Token(Token = "0x1700076B")]
		protected override int DenyEntryAnimHash
		{
			[Token(Token = "0x6003C29")]
			[Address(RVA = "0x580AF0", Offset = "0x57FAF0", VA = "0x180580AF0", Slot = "22")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x06003C2A RID: 15402 RVA: 0x000118B0 File Offset: 0x0000FAB0
		[Token(Token = "0x1700076C")]
		protected override int DenyEntryBoolHash
		{
			[Token(Token = "0x6003C2A")]
			[Address(RVA = "0x580AF0", Offset = "0x57FAF0", VA = "0x180580AF0", Slot = "23")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x06003C2B RID: 15403 RVA: 0x000118C8 File Offset: 0x0000FAC8
		[Token(Token = "0x1700076D")]
		protected override float AnimationStateWaitTimeout
		{
			[Token(Token = "0x6003C2B")]
			[Address(RVA = "0x2F0F6F0", Offset = "0x2F0E6F0", VA = "0x182F0F6F0", Slot = "25")]
			get
			{
				return default(float);
			}
		}

		// Token: 0x06003C2C RID: 15404 RVA: 0x000118E0 File Offset: 0x0000FAE0
		[Token(Token = "0x6003C2C")]
		[Address(RVA = "0x582970", Offset = "0x581970", VA = "0x180582970", Slot = "24")]
		protected override bool CheckCanOpen()
		{
			return default(bool);
		}

		// Token: 0x06003C2D RID: 15405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C2D")]
		[Address(RVA = "0x2F0EF00", Offset = "0x2F0DF00", VA = "0x182F0EF00", Slot = "7")]
		protected override void PostStartHook()
		{
		}

		// Token: 0x06003C2E RID: 15406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C2E")]
		[Address(RVA = "0x2F0F1E0", Offset = "0x2F0E1E0", VA = "0x182F0F1E0")]
		private void SetMudEnabled(bool mudEnabled)
		{
		}

		// Token: 0x06003C2F RID: 15407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C2F")]
		[Address(RVA = "0x2F0EAA0", Offset = "0x2F0DAA0", VA = "0x182F0EAA0")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x06003C30 RID: 15408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C30")]
		[Address(RVA = "0x2F0E440", Offset = "0x2F0D440", VA = "0x182F0E440")]
		private void CheckDismountLadderTrigger()
		{
		}

		// Token: 0x06003C31 RID: 15409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C31")]
		[Address(RVA = "0x2F0F080", Offset = "0x2F0E080", VA = "0x182F0F080", Slot = "14")]
		protected override void ResetCutscene()
		{
		}

		// Token: 0x06003C32 RID: 15410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C32")]
		[Address(RVA = "0x2F0E5D0", Offset = "0x2F0D5D0", VA = "0x182F0E5D0")]
		private void ResetHatch()
		{
		}

		// Token: 0x06003C33 RID: 15411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C33")]
		[Address(RVA = "0x2F0EA70", Offset = "0x2F0DA70", VA = "0x182F0EA70", Slot = "27")]
		protected override void OnDoorSateChanged(DoorState doorState)
		{
		}

		// Token: 0x06003C34 RID: 15412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C34")]
		[Address(RVA = "0x2F0E5D0", Offset = "0x2F0D5D0", VA = "0x182F0E5D0", Slot = "33")]
		internal override void CloseHook()
		{
		}

		// Token: 0x06003C35 RID: 15413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C35")]
		[Address(RVA = "0x2F0ED90", Offset = "0x2F0DD90", VA = "0x182F0ED90", Slot = "32")]
		internal override void OpenHook()
		{
		}

		// Token: 0x06003C36 RID: 15414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C36")]
		[Address(RVA = "0x2F0E5F0", Offset = "0x2F0D5F0", VA = "0x182F0E5F0", Slot = "34")]
		protected override void DoorAnimating()
		{
		}

		// Token: 0x06003C37 RID: 15415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C37")]
		[Address(RVA = "0x2F0E5A0", Offset = "0x2F0D5A0", VA = "0x182F0E5A0")]
		private void CheckMudStart(float normalizedTime)
		{
		}

		// Token: 0x06003C38 RID: 15416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C38")]
		[Address(RVA = "0x2F0F380", Offset = "0x2F0E380", VA = "0x182F0F380")]
		private void TriggerDigActivators()
		{
		}

		// Token: 0x06003C39 RID: 15417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C39")]
		[Address(RVA = "0x2F0F2A0", Offset = "0x2F0E2A0", VA = "0x182F0F2A0")]
		private void SetMudOff()
		{
		}

		// Token: 0x06003C3A RID: 15418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C3A")]
		[Address(RVA = "0x2F0EE90", Offset = "0x2F0DE90", VA = "0x182F0EE90", Slot = "35")]
		protected override IEnumerator PostOpenPlayerSequence()
		{
			return null;
		}

		// Token: 0x06003C3B RID: 15419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C3B")]
		[Address(RVA = "0x2F0E710", Offset = "0x2F0D710", VA = "0x182F0E710")]
		private void FinalizeOpeningHatchPlayer()
		{
		}

		// Token: 0x06003C3C RID: 15420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C3C")]
		[Address(RVA = "0x2F0F100", Offset = "0x2F0E100", VA = "0x182F0F100")]
		private void SetClimbOutAndInCutscenesActive(bool value)
		{
		}

		// Token: 0x06003C3D RID: 15421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C3D")]
		[Address(RVA = "0x2F0F500", Offset = "0x2F0E500", VA = "0x182F0F500")]
		public BuriedEnterHatchTrigger()
		{
		}

		// Token: 0x0400405D RID: 16477
		[Token(Token = "0x400405D")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private BFX_ManualAnimationUpdate[] _hatchMud;

		// Token: 0x0400405E RID: 16478
		[Token(Token = "0x400405E")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private List<ActivateOnDigCount> _openHatchOnDigActivators;

		// Token: 0x0400405F RID: 16479
		[Token(Token = "0x400405F")]
		[FieldOffset(Offset = "0x138")]
		[FormerlySerializedAs("_delay")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _mudDelay;

		// Token: 0x04004060 RID: 16480
		[Token(Token = "0x4004060")]
		[FieldOffset(Offset = "0x140")]
		[FormerlySerializedAs("_hatchOpenBlocker")]
		[SerializeField]
		private DetectCollisionBlocked _detectCollisionBlocked;

		// Token: 0x04004061 RID: 16481
		[Token(Token = "0x4004061")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		private TransformConstraint _handCollisionConstraint;

		// Token: 0x04004062 RID: 16482
		[Token(Token = "0x4004062")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		private string _handLocatorName;

		// Token: 0x04004063 RID: 16483
		[Token(Token = "0x4004063")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		private GameObject _hatchDebris;

		// Token: 0x04004064 RID: 16484
		[Token(Token = "0x4004064")]
		[FieldOffset(Offset = "0x160")]
		[SerializeField]
		private GameObject _guiGameObject;

		// Token: 0x04004065 RID: 16485
		[Token(Token = "0x4004065")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		[FormerlySerializedAs("_climbUpCutsceneGroup")]
		private GameObject _climbOutCutsceneGroup;

		// Token: 0x04004066 RID: 16486
		[Token(Token = "0x4004066")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		private GameObject _climbInCutsceneGroup;

		// Token: 0x04004067 RID: 16487
		[Token(Token = "0x4004067")]
		[FieldOffset(Offset = "0x178")]
		[SerializeField]
		private Transform _dismountPointGuide;

		// Token: 0x04004068 RID: 16488
		[Token(Token = "0x4004068")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		private float _dismountLadderTimer;

		// Token: 0x04004069 RID: 16489
		[Token(Token = "0x4004069")]
		[FieldOffset(Offset = "0x184")]
		[SerializeField]
		private float _ladderClimbTimer;

		// Token: 0x0400406A RID: 16490
		[Token(Token = "0x400406A")]
		[FieldOffset(Offset = "0x188")]
		private bool _deactivated;

		// Token: 0x0400406B RID: 16491
		[Token(Token = "0x400406B")]
		[FieldOffset(Offset = "0x189")]
		private bool _constrained;

		// Token: 0x0400406C RID: 16492
		[Token(Token = "0x400406C")]
		[FieldOffset(Offset = "0x190")]
		private GameObject _debrisInstance;

		// Token: 0x0400406D RID: 16493
		[Token(Token = "0x400406D")]
		[FieldOffset(Offset = "0x198")]
		private bool _debrisInstanced;

		// Token: 0x0400406E RID: 16494
		[Token(Token = "0x400406E")]
		[FieldOffset(Offset = "0x1A0")]
		[SerializeField]
		private AnimationCurve _fovCurve;

		// Token: 0x0400406F RID: 16495
		[Token(Token = "0x400406F")]
		[FieldOffset(Offset = "0x1A8")]
		private bool _hasStartedOpeningTheHatch;

		// Token: 0x04004070 RID: 16496
		[Token(Token = "0x4004070")]
		[FieldOffset(Offset = "0x1A9")]
		private bool _sequenceIsRunning;

		// Token: 0x04004071 RID: 16497
		[Token(Token = "0x4004071")]
		[FieldOffset(Offset = "0x1AC")]
		private Vector3 _originalPosition;

		// Token: 0x04004072 RID: 16498
		[Token(Token = "0x4004072")]
		[FieldOffset(Offset = "0x1B8")]
		private bool _hasRefreshedGui;

		// Token: 0x04004073 RID: 16499
		[Token(Token = "0x4004073")]
		[FieldOffset(Offset = "0x1BC")]
		private float _hatchOpenStateLength;

		// Token: 0x04004074 RID: 16500
		[Token(Token = "0x4004074")]
		[FieldOffset(Offset = "0x1C0")]
		private bool _hasCompletedAlign;

		// Token: 0x04004075 RID: 16501
		[Token(Token = "0x4004075")]
		[FieldOffset(Offset = "0x1C4")]
		private readonly int ClimbLadderDownOutroHash;

		// Token: 0x04004076 RID: 16502
		[Token(Token = "0x4004076")]
		[FieldOffset(Offset = "0x1C8")]
		private readonly int ClimbLadderDownLoopHash;

		// Token: 0x04004077 RID: 16503
		[Token(Token = "0x4004077")]
		[FieldOffset(Offset = "0x1CC")]
		private readonly int DismountLadderHash;

		// Token: 0x04004078 RID: 16504
		[Token(Token = "0x4004078")]
		[FieldOffset(Offset = "0x1D0")]
		private bool _registeredAction;

		// Token: 0x04004079 RID: 16505
		[Token(Token = "0x4004079")]
		[FieldOffset(Offset = "0x1D4")]
		private float _enterHatchStartTime;

		// Token: 0x0400407A RID: 16506
		[Token(Token = "0x400407A")]
		[FieldOffset(Offset = "0x1D8")]
		private bool _dismountLadderTriggered;

		// Token: 0x0400407B RID: 16507
		[Token(Token = "0x400407B")]
		[FieldOffset(Offset = "0x1D9")]
		private bool _isWaitingForPlayerHandsEmpty;

		// Token: 0x0400407C RID: 16508
		[Token(Token = "0x400407C")]
		[FieldOffset(Offset = "0x1DC")]
		private Vector3 _currentPlayerPosition;

		// Token: 0x0400407D RID: 16509
		[Token(Token = "0x400407D")]
		[FieldOffset(Offset = "0x1E8")]
		private Quaternion _currentPlayerRotation;

		// Token: 0x0400407E RID: 16510
		[Token(Token = "0x400407E")]
		[FieldOffset(Offset = "0x1F8")]
		private FovManager _cameraFovManager;

		// Token: 0x0400407F RID: 16511
		[Token(Token = "0x400407F")]
		private const float FloorDismountOffset = 1.348f;

		// Token: 0x04004080 RID: 16512
		[Token(Token = "0x4004080")]
		[FieldOffset(Offset = "0x0")]
		private static float _fovReturnSpeed;

		// Token: 0x04004081 RID: 16513
		[Token(Token = "0x4004081")]
		[FieldOffset(Offset = "0x200")]
		private bool _activatedMud;
	}
}
