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
	// Token: 0x0200092D RID: 2349
	[Token(Token = "0x200092D")]
	public class BuriedEnterHatchTrigger : DoorTriggerCutsceneBase
	{
		// Token: 0x17000895 RID: 2197
		// (get) Token: 0x0600437A RID: 17274 RVA: 0x000147A8 File Offset: 0x000129A8
		[Token(Token = "0x17000895")]
		protected override int IdleOpenAnimHash
		{
			[Token(Token = "0x600437A")]
			[Address(RVA = "0x3645EA0", Offset = "0x36444A0", VA = "0x183645EA0", Slot = "18")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000896 RID: 2198
		// (get) Token: 0x0600437B RID: 17275 RVA: 0x000147C0 File Offset: 0x000129C0
		[Token(Token = "0x17000896")]
		protected override int IdleClosedAnimHash
		{
			[Token(Token = "0x600437B")]
			[Address(RVA = "0x3645F00", Offset = "0x3644500", VA = "0x183645F00", Slot = "19")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000897 RID: 2199
		// (get) Token: 0x0600437C RID: 17276 RVA: 0x000147D8 File Offset: 0x000129D8
		[Token(Token = "0x17000897")]
		protected override int EnterAnimHash
		{
			[Token(Token = "0x600437C")]
			[Address(RVA = "0x3645F60", Offset = "0x3644560", VA = "0x183645F60", Slot = "20")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000898 RID: 2200
		// (get) Token: 0x0600437D RID: 17277 RVA: 0x000147F0 File Offset: 0x000129F0
		[Token(Token = "0x17000898")]
		protected override int EnterAnimBoolHash
		{
			[Token(Token = "0x600437D")]
			[Address(RVA = "0x3645FC0", Offset = "0x36445C0", VA = "0x183645FC0", Slot = "21")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000899 RID: 2201
		// (get) Token: 0x0600437E RID: 17278 RVA: 0x00014808 File Offset: 0x00012A08
		[Token(Token = "0x17000899")]
		protected override int DenyEntryAnimHash
		{
			[Token(Token = "0x600437E")]
			[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "22")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700089A RID: 2202
		// (get) Token: 0x0600437F RID: 17279 RVA: 0x00014820 File Offset: 0x00012A20
		[Token(Token = "0x1700089A")]
		protected override int DenyEntryBoolHash
		{
			[Token(Token = "0x600437F")]
			[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "23")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700089B RID: 2203
		// (get) Token: 0x06004380 RID: 17280 RVA: 0x00014838 File Offset: 0x00012A38
		[Token(Token = "0x1700089B")]
		protected override float AnimationStateWaitTimeout
		{
			[Token(Token = "0x6004380")]
			[Address(RVA = "0x3646020", Offset = "0x3644620", VA = "0x183646020", Slot = "25")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06004381 RID: 17281 RVA: 0x00014850 File Offset: 0x00012A50
		[Token(Token = "0x6004381")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "24")]
		protected override bool CheckCanOpen()
		{
			return default(bool);
		}

		// Token: 0x06004382 RID: 17282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004382")]
		[Address(RVA = "0x3646030", Offset = "0x3644630", VA = "0x183646030", Slot = "7")]
		protected override void PostStartHook()
		{
		}

		// Token: 0x06004383 RID: 17283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004383")]
		[Address(RVA = "0x3646170", Offset = "0x3644770", VA = "0x183646170")]
		private void SetMudEnabled(bool mudEnabled)
		{
		}

		// Token: 0x06004384 RID: 17284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004384")]
		[Address(RVA = "0x3646290", Offset = "0x3644890", VA = "0x183646290")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x06004385 RID: 17285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004385")]
		[Address(RVA = "0x3646780", Offset = "0x3644D80", VA = "0x183646780")]
		private void CheckDismountLadderTrigger()
		{
		}

		// Token: 0x06004386 RID: 17286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004386")]
		[Address(RVA = "0x36469F0", Offset = "0x3644FF0", VA = "0x1836469F0", Slot = "14")]
		protected override void ResetCutscene()
		{
		}

		// Token: 0x06004387 RID: 17287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004387")]
		[Address(RVA = "0x3646AC0", Offset = "0x36450C0", VA = "0x183646AC0")]
		private void ResetHatch()
		{
		}

		// Token: 0x06004388 RID: 17288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004388")]
		[Address(RVA = "0x3646AE0", Offset = "0x36450E0", VA = "0x183646AE0", Slot = "27")]
		protected override void OnDoorSateChanged(DoorState doorState)
		{
		}

		// Token: 0x06004389 RID: 17289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004389")]
		[Address(RVA = "0x3646AC0", Offset = "0x36450C0", VA = "0x183646AC0", Slot = "33")]
		internal override void CloseHook()
		{
		}

		// Token: 0x0600438A RID: 17290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600438A")]
		[Address(RVA = "0x3646B10", Offset = "0x3645110", VA = "0x183646B10", Slot = "32")]
		internal override void OpenHook()
		{
		}

		// Token: 0x0600438B RID: 17291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600438B")]
		[Address(RVA = "0x3646C80", Offset = "0x3645280", VA = "0x183646C80", Slot = "35")]
		protected override void DoorAnimating()
		{
		}

		// Token: 0x0600438C RID: 17292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600438C")]
		[Address(RVA = "0x3646DC0", Offset = "0x36453C0", VA = "0x183646DC0")]
		private void CheckMudStart(float normalizedTime)
		{
		}

		// Token: 0x0600438D RID: 17293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600438D")]
		[Address(RVA = "0x3646DF0", Offset = "0x36453F0", VA = "0x183646DF0")]
		private void TriggerDigActivators()
		{
		}

		// Token: 0x0600438E RID: 17294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600438E")]
		[Address(RVA = "0x3646FC0", Offset = "0x36455C0", VA = "0x183646FC0")]
		private void SetMudOff()
		{
		}

		// Token: 0x0600438F RID: 17295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600438F")]
		[Address(RVA = "0x3647110", Offset = "0x3645710", VA = "0x183647110", Slot = "36")]
		protected override IEnumerator PostOpenPlayerSequence()
		{
			return null;
		}

		// Token: 0x06004390 RID: 17296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004390")]
		[Address(RVA = "0x36471A0", Offset = "0x36457A0", VA = "0x1836471A0")]
		private void FinalizeOpeningHatchPlayer()
		{
		}

		// Token: 0x06004391 RID: 17297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004391")]
		[Address(RVA = "0x3647620", Offset = "0x3645C20", VA = "0x183647620")]
		private void SetClimbOutAndInCutscenesActive(bool value)
		{
		}

		// Token: 0x06004392 RID: 17298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004392")]
		[Address(RVA = "0x3647830", Offset = "0x3645E30", VA = "0x183647830")]
		public BuriedEnterHatchTrigger()
		{
		}

		// Token: 0x040046A2 RID: 18082
		[Token(Token = "0x40046A2")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private BFX_ManualAnimationUpdate[] _hatchMud;

		// Token: 0x040046A3 RID: 18083
		[Token(Token = "0x40046A3")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private List<ActivateOnDigCount> _openHatchOnDigActivators;

		// Token: 0x040046A4 RID: 18084
		[Token(Token = "0x40046A4")]
		[FieldOffset(Offset = "0x138")]
		[FormerlySerializedAs("_delay")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _mudDelay;

		// Token: 0x040046A5 RID: 18085
		[Token(Token = "0x40046A5")]
		[FieldOffset(Offset = "0x140")]
		[FormerlySerializedAs("_hatchOpenBlocker")]
		[SerializeField]
		private DetectCollisionBlocked _detectCollisionBlocked;

		// Token: 0x040046A6 RID: 18086
		[Token(Token = "0x40046A6")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		private TransformConstraint _handCollisionConstraint;

		// Token: 0x040046A7 RID: 18087
		[Token(Token = "0x40046A7")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		private string _handLocatorName;

		// Token: 0x040046A8 RID: 18088
		[Token(Token = "0x40046A8")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		private GameObject _hatchDebris;

		// Token: 0x040046A9 RID: 18089
		[Token(Token = "0x40046A9")]
		[FieldOffset(Offset = "0x160")]
		[SerializeField]
		private GameObject _guiGameObject;

		// Token: 0x040046AA RID: 18090
		[Token(Token = "0x40046AA")]
		[FieldOffset(Offset = "0x168")]
		[FormerlySerializedAs("_climbUpCutsceneGroup")]
		[SerializeField]
		private GameObject _climbOutCutsceneGroup;

		// Token: 0x040046AB RID: 18091
		[Token(Token = "0x40046AB")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		private GameObject _climbInCutsceneGroup;

		// Token: 0x040046AC RID: 18092
		[Token(Token = "0x40046AC")]
		[FieldOffset(Offset = "0x178")]
		[SerializeField]
		private Transform _dismountPointGuide;

		// Token: 0x040046AD RID: 18093
		[Token(Token = "0x40046AD")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		private float _dismountLadderTimer;

		// Token: 0x040046AE RID: 18094
		[Token(Token = "0x40046AE")]
		[FieldOffset(Offset = "0x184")]
		[SerializeField]
		private float _ladderClimbTimer;

		// Token: 0x040046AF RID: 18095
		[Token(Token = "0x40046AF")]
		[FieldOffset(Offset = "0x188")]
		private bool _deactivated;

		// Token: 0x040046B0 RID: 18096
		[Token(Token = "0x40046B0")]
		[FieldOffset(Offset = "0x189")]
		private bool _constrained;

		// Token: 0x040046B1 RID: 18097
		[Token(Token = "0x40046B1")]
		[FieldOffset(Offset = "0x190")]
		private GameObject _debrisInstance;

		// Token: 0x040046B2 RID: 18098
		[Token(Token = "0x40046B2")]
		[FieldOffset(Offset = "0x198")]
		private bool _debrisInstanced;

		// Token: 0x040046B3 RID: 18099
		[Token(Token = "0x40046B3")]
		[FieldOffset(Offset = "0x1A0")]
		[SerializeField]
		private AnimationCurve _fovCurve;

		// Token: 0x040046B4 RID: 18100
		[Token(Token = "0x40046B4")]
		[FieldOffset(Offset = "0x1A8")]
		private bool _hasStartedOpeningTheHatch;

		// Token: 0x040046B5 RID: 18101
		[Token(Token = "0x40046B5")]
		[FieldOffset(Offset = "0x1A9")]
		private bool _sequenceIsRunning;

		// Token: 0x040046B6 RID: 18102
		[Token(Token = "0x40046B6")]
		[FieldOffset(Offset = "0x1AC")]
		private Vector3 _originalPosition;

		// Token: 0x040046B7 RID: 18103
		[Token(Token = "0x40046B7")]
		[FieldOffset(Offset = "0x1B8")]
		private bool _hasRefreshedGui;

		// Token: 0x040046B8 RID: 18104
		[Token(Token = "0x40046B8")]
		[FieldOffset(Offset = "0x1BC")]
		private float _hatchOpenStateLength;

		// Token: 0x040046B9 RID: 18105
		[Token(Token = "0x40046B9")]
		[FieldOffset(Offset = "0x1C0")]
		private bool _hasCompletedAlign;

		// Token: 0x040046BA RID: 18106
		[Token(Token = "0x40046BA")]
		[FieldOffset(Offset = "0x1C4")]
		private readonly int ClimbLadderDownOutroHash;

		// Token: 0x040046BB RID: 18107
		[Token(Token = "0x40046BB")]
		[FieldOffset(Offset = "0x1C8")]
		private readonly int ClimbLadderDownLoopHash;

		// Token: 0x040046BC RID: 18108
		[Token(Token = "0x40046BC")]
		[FieldOffset(Offset = "0x1CC")]
		private readonly int DismountLadderHash;

		// Token: 0x040046BD RID: 18109
		[Token(Token = "0x40046BD")]
		[FieldOffset(Offset = "0x1D0")]
		private bool _registeredAction;

		// Token: 0x040046BE RID: 18110
		[Token(Token = "0x40046BE")]
		[FieldOffset(Offset = "0x1D4")]
		private float _enterHatchStartTime;

		// Token: 0x040046BF RID: 18111
		[Token(Token = "0x40046BF")]
		[FieldOffset(Offset = "0x1D8")]
		private bool _dismountLadderTriggered;

		// Token: 0x040046C0 RID: 18112
		[Token(Token = "0x40046C0")]
		[FieldOffset(Offset = "0x1D9")]
		private bool _isWaitingForPlayerHandsEmpty;

		// Token: 0x040046C1 RID: 18113
		[Token(Token = "0x40046C1")]
		[FieldOffset(Offset = "0x1DC")]
		private Vector3 _currentPlayerPosition;

		// Token: 0x040046C2 RID: 18114
		[Token(Token = "0x40046C2")]
		[FieldOffset(Offset = "0x1E8")]
		private Quaternion _currentPlayerRotation;

		// Token: 0x040046C3 RID: 18115
		[Token(Token = "0x40046C3")]
		[FieldOffset(Offset = "0x1F8")]
		private FovManager _cameraFovManager;

		// Token: 0x040046C4 RID: 18116
		[Token(Token = "0x40046C4")]
		private const float FloorDismountOffset = 1.348f;

		// Token: 0x040046C5 RID: 18117
		[Token(Token = "0x40046C5")]
		[FieldOffset(Offset = "0x0")]
		private static float _fovReturnSpeed;

		// Token: 0x040046C6 RID: 18118
		[Token(Token = "0x40046C6")]
		[FieldOffset(Offset = "0x200")]
		private bool _activatedMud;
	}
}
