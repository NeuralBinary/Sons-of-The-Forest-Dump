using System;
using System.Collections.Generic;
using Endnight.Types;
using Il2CppDummyDll;
using Sons.Gui.Input;
using Sons.Input;
using UnityEngine;

namespace Construction
{
	// Token: 0x020001C5 RID: 453
	[Token(Token = "0x20001C5")]
	[AddComponentMenu("Sons/Construction/ClimbLadderAction")]
	public class ClimbLadderAction : SingletonBehaviour<ClimbLadderAction>
	{
		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06000D52 RID: 3410 RVA: 0x0000842C File Offset: 0x0000662C
		[Token(Token = "0x1700032C")]
		private bool IsGrounded
		{
			[Token(Token = "0x6000D52")]
			[Address(RVA = "0x2ECDA80", Offset = "0x2ECC080", VA = "0x182ECDA80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06000D53 RID: 3411 RVA: 0x00008444 File Offset: 0x00006644
		// (set) Token: 0x06000D54 RID: 3412 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700032D")]
		private bool IsJumping
		{
			[Token(Token = "0x6000D53")]
			[Address(RVA = "0x2ECDB20", Offset = "0x2ECC120", VA = "0x182ECDB20")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000D54")]
			[Address(RVA = "0x2ECDB70", Offset = "0x2ECC170", VA = "0x182ECDB70")]
			set
			{
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06000D55 RID: 3413 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x1700032E")]
		private Transform MainCamTr
		{
			[Token(Token = "0x6000D55")]
			[Address(RVA = "0x2D806F0", Offset = "0x2D7ECF0", VA = "0x182D806F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06000D56 RID: 3414 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x1700032F")]
		private Transform MainBodyTr
		{
			[Token(Token = "0x6000D56")]
			[Address(RVA = "0x2D80530", Offset = "0x2D7EB30", VA = "0x182D80530")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06000D57 RID: 3415 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000330")]
		private Rigidbody Rigidbody
		{
			[Token(Token = "0x6000D57")]
			[Address(RVA = "0x2E30C80", Offset = "0x2E2F280", VA = "0x182E30C80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06000D58 RID: 3416 RVA: 0x0000845C File Offset: 0x0000665C
		[Token(Token = "0x17000331")]
		private Bounds PrimaryBounds
		{
			[Token(Token = "0x6000D58")]
			[Address(RVA = "0x2ECDBD0", Offset = "0x2ECC1D0", VA = "0x182ECDBD0")]
			get
			{
				return default(Bounds);
			}
		}

		// Token: 0x06000D59 RID: 3417 RVA: 0x00008474 File Offset: 0x00006674
		[Token(Token = "0x6000D59")]
		[Address(RVA = "0x2ECDCA0", Offset = "0x2ECC2A0", VA = "0x182ECDCA0")]
		private static bool JumpDown()
		{
			return default(bool);
		}

		// Token: 0x06000D5A RID: 3418 RVA: 0x0000848C File Offset: 0x0000668C
		[Token(Token = "0x6000D5A")]
		[Address(RVA = "0x2ECDD30", Offset = "0x2ECC330", VA = "0x182ECDD30")]
		private static bool UseDown()
		{
			return default(bool);
		}

		// Token: 0x06000D5B RID: 3419 RVA: 0x000084A4 File Offset: 0x000066A4
		[Token(Token = "0x6000D5B")]
		[Address(RVA = "0x2ECDDC0", Offset = "0x2ECC3C0", VA = "0x182ECDDC0")]
		private static bool MoveForwardButtonUp()
		{
			return default(bool);
		}

		// Token: 0x06000D5C RID: 3420 RVA: 0x000084BC File Offset: 0x000066BC
		[Token(Token = "0x6000D5C")]
		[Address(RVA = "0x2ECDE50", Offset = "0x2ECC450", VA = "0x182ECDE50")]
		private static float MoveForwardAxis()
		{
			return 0f;
		}

		// Token: 0x06000D5D RID: 3421 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D5D")]
		[Address(RVA = "0x2ECDEE0", Offset = "0x2ECC4E0", VA = "0x182ECDEE0", Slot = "7")]
		protected override void PostAwake()
		{
		}

		// Token: 0x06000D5E RID: 3422 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D5E")]
		[Address(RVA = "0x2ECE510", Offset = "0x2ECCB10", VA = "0x182ECE510")]
		private void Update()
		{
		}

		// Token: 0x06000D5F RID: 3423 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D5F")]
		[Address(RVA = "0x2ECE750", Offset = "0x2ECCD50", VA = "0x182ECE750")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06000D60 RID: 3424 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D60")]
		[Address(RVA = "0x2ECE920", Offset = "0x2ECCF20", VA = "0x182ECE920")]
		private void OnDisable()
		{
		}

		// Token: 0x06000D61 RID: 3425 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D61")]
		[Address(RVA = "0x2ECE950", Offset = "0x2ECCF50", VA = "0x182ECE950")]
		public static void RegisterLadder(ClimbableLadder ladder)
		{
		}

		// Token: 0x06000D62 RID: 3426 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D62")]
		[Address(RVA = "0x2ECEAA0", Offset = "0x2ECD0A0", VA = "0x182ECEAA0")]
		public static void UnregisterLadder(ClimbableLadder ladder)
		{
		}

		// Token: 0x06000D63 RID: 3427 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D63")]
		[Address(RVA = "0x2ECEB40", Offset = "0x2ECD140", VA = "0x182ECEB40")]
		private void CheckEnabled()
		{
		}

		// Token: 0x06000D64 RID: 3428 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D64")]
		[Address(RVA = "0x2ECEC70", Offset = "0x2ECD270", VA = "0x182ECEC70")]
		private void ToggleInteractionIcon(ClimbableLadder ladder)
		{
		}

		// Token: 0x06000D65 RID: 3429 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D65")]
		[Address(RVA = "0x2ECEF90", Offset = "0x2ECD590", VA = "0x182ECEF90")]
		private void UpdateIdle(out bool shouldExit)
		{
		}

		// Token: 0x06000D66 RID: 3430 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D66")]
		[Address(RVA = "0x2ECF310", Offset = "0x2ECD910", VA = "0x182ECF310")]
		private void UpdateIdleOnLadder(out bool shouldExit)
		{
		}

		// Token: 0x06000D67 RID: 3431 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D67")]
		[Address(RVA = "0x2ECF480", Offset = "0x2ECDA80", VA = "0x182ECF480")]
		private void UpdateGoingUpOrDownLadder(out bool shouldExit)
		{
		}

		// Token: 0x06000D68 RID: 3432 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D68")]
		[Address(RVA = "0x2ECF7F0", Offset = "0x2ECDDF0", VA = "0x182ECF7F0")]
		private void UpdateExitAtTopOfLadder(out bool shouldExit)
		{
		}

		// Token: 0x06000D69 RID: 3433 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D69")]
		[Address(RVA = "0x2ECF960", Offset = "0x2ECDF60", VA = "0x182ECF960")]
		private void SetState(ClimbLadderAction.ClimbStates state)
		{
		}

		// Token: 0x06000D6A RID: 3434 RVA: 0x000084D4 File Offset: 0x000066D4
		[Token(Token = "0x6000D6A")]
		[Address(RVA = "0x2ECFB00", Offset = "0x2ECE100", VA = "0x182ECFB00")]
		private bool IsAgainstAnyLadder(out ClimbableLadder ladder)
		{
			return default(bool);
		}

		// Token: 0x06000D6B RID: 3435 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D6B")]
		[Address(RVA = "0x2ECFE10", Offset = "0x2ECE410", VA = "0x182ECFE10")]
		private void CheckInActiveLadderRange()
		{
		}

		// Token: 0x06000D6C RID: 3436 RVA: 0x000084EC File Offset: 0x000066EC
		[Token(Token = "0x6000D6C")]
		[Address(RVA = "0x2ED0040", Offset = "0x2ECE640", VA = "0x182ED0040")]
		private bool CheckExitAtTopOfLadder()
		{
			return default(bool);
		}

		// Token: 0x06000D6D RID: 3437 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D6D")]
		[Address(RVA = "0x2ED0190", Offset = "0x2ECE790", VA = "0x182ED0190")]
		private void ResetInput()
		{
		}

		// Token: 0x06000D6E RID: 3438 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D6E")]
		[Address(RVA = "0x2ED01A0", Offset = "0x2ECE7A0", VA = "0x182ED01A0")]
		private void StopFallingVelocity()
		{
		}

		// Token: 0x06000D6F RID: 3439 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D6F")]
		[Address(RVA = "0x2ED0300", Offset = "0x2ECE900", VA = "0x182ED0300")]
		private void GrabPlayerPosition()
		{
		}

		// Token: 0x06000D70 RID: 3440 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D70")]
		[Address(RVA = "0x2ED04A0", Offset = "0x2ECEAA0", VA = "0x182ED04A0")]
		private void EnforcePlayerPositionOnLadder()
		{
		}

		// Token: 0x06000D71 RID: 3441 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D71")]
		[Address(RVA = "0x2ED0560", Offset = "0x2ECEB60", VA = "0x182ED0560")]
		private void ApplyClimbMovement()
		{
		}

		// Token: 0x06000D72 RID: 3442 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D72")]
		[Address(RVA = "0x2ED0800", Offset = "0x2ECEE00", VA = "0x182ED0800")]
		private void ExitAtTopOfLadderRefresh()
		{
		}

		// Token: 0x06000D73 RID: 3443 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D73")]
		[Address(RVA = "0x2ED0A50", Offset = "0x2ECF050", VA = "0x182ED0A50")]
		public ClimbLadderAction()
		{
		}

		// Token: 0x0400077A RID: 1914
		[Token(Token = "0x400077A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _climbGravityRatio;

		// Token: 0x0400077B RID: 1915
		[Token(Token = "0x400077B")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _distanceToLadder;

		// Token: 0x0400077C RID: 1916
		[Token(Token = "0x400077C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _exitAtTopDuration;

		// Token: 0x0400077D RID: 1917
		[Token(Token = "0x400077D")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _exitAtTopPlayerHeightAlpha;

		// Token: 0x0400077E RID: 1918
		[Token(Token = "0x400077E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _rightHandIkTarget;

		// Token: 0x0400077F RID: 1919
		[Token(Token = "0x400077F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform _leftHandIkTarget;

		// Token: 0x04000780 RID: 1920
		[Token(Token = "0x4000780")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private LinkUiElement _interactIcon;

		// Token: 0x04000781 RID: 1921
		[Token(Token = "0x4000781")]
		[FieldOffset(Offset = "0x50")]
		private ClimbLadderAction.ClimbStates _state;

		// Token: 0x04000782 RID: 1922
		[Token(Token = "0x4000782")]
		[FieldOffset(Offset = "0x54")]
		private ClimbLadderAction.HandsStates _handsState;

		// Token: 0x04000783 RID: 1923
		[Token(Token = "0x4000783")]
		[FieldOffset(Offset = "0x58")]
		private bool _jumpButtonDown;

		// Token: 0x04000784 RID: 1924
		[Token(Token = "0x4000784")]
		[FieldOffset(Offset = "0x59")]
		private bool _useButtonDown;

		// Token: 0x04000785 RID: 1925
		[Token(Token = "0x4000785")]
		[FieldOffset(Offset = "0x5A")]
		private bool _moveButtonUp;

		// Token: 0x04000786 RID: 1926
		[Token(Token = "0x4000786")]
		[FieldOffset(Offset = "0x5C")]
		private float _moveAxisVal;

		// Token: 0x04000787 RID: 1927
		[Token(Token = "0x4000787")]
		[FieldOffset(Offset = "0x60")]
		private float _lastAttachedLadderStepHeight;

		// Token: 0x04000788 RID: 1928
		[Token(Token = "0x4000788")]
		[FieldOffset(Offset = "0x64")]
		private float _stateStartTime;

		// Token: 0x04000789 RID: 1929
		[Token(Token = "0x4000789")]
		[FieldOffset(Offset = "0x68")]
		private bool _lastHandAttachedIsRight;

		// Token: 0x0400078A RID: 1930
		[Token(Token = "0x400078A")]
		[FieldOffset(Offset = "0x6C")]
		private Vector3 _playerPosOnLadder;

		// Token: 0x0400078B RID: 1931
		[Token(Token = "0x400078B")]
		[FieldOffset(Offset = "0x78")]
		private bool _lastActiveLadderRequiredAnimation;

		// Token: 0x0400078C RID: 1932
		[Token(Token = "0x400078C")]
		[FieldOffset(Offset = "0x80")]
		private ClimbableLadder _activeLadder;

		// Token: 0x0400078D RID: 1933
		[Token(Token = "0x400078D")]
		[FieldOffset(Offset = "0x88")]
		private List<ClimbableLadder> _activeLadders;

		// Token: 0x0400078E RID: 1934
		[Token(Token = "0x400078E")]
		[FieldOffset(Offset = "0x90")]
		private Action[] _stateChangeCallbacks;

		// Token: 0x0400078F RID: 1935
		[Token(Token = "0x400078F")]
		[FieldOffset(Offset = "0x98")]
		private Dictionary<ClimbLadderAction.ClimbStateTransitions, Action> _stateChangeTransitionsCallbacks;

		// Token: 0x04000790 RID: 1936
		[Token(Token = "0x4000790")]
		[FieldOffset(Offset = "0x0")]
		private static InputSystem.Action Jump;

		// Token: 0x04000791 RID: 1937
		[Token(Token = "0x4000791")]
		[FieldOffset(Offset = "0x10")]
		private static InputSystem.Action Use;

		// Token: 0x04000792 RID: 1938
		[Token(Token = "0x4000792")]
		[FieldOffset(Offset = "0x20")]
		private static InputSystem.Action MoveForward;

		// Token: 0x020001C6 RID: 454
		[Token(Token = "0x20001C6")]
		public enum ClimbStates
		{
			// Token: 0x04000794 RID: 1940
			[Token(Token = "0x4000794")]
			Idle,
			// Token: 0x04000795 RID: 1941
			[Token(Token = "0x4000795")]
			IdleOnLadder,
			// Token: 0x04000796 RID: 1942
			[Token(Token = "0x4000796")]
			GoingUpLadder,
			// Token: 0x04000797 RID: 1943
			[Token(Token = "0x4000797")]
			GoingDownLadder,
			// Token: 0x04000798 RID: 1944
			[Token(Token = "0x4000798")]
			ExitAtTopOfLadder
		}

		// Token: 0x020001C7 RID: 455
		[Token(Token = "0x20001C7")]
		public enum ClimbStateTransitions
		{
			// Token: 0x0400079A RID: 1946
			[Token(Token = "0x400079A")]
			IdleToIdleOnLadder = 1
		}

		// Token: 0x020001C8 RID: 456
		[Token(Token = "0x20001C8")]
		public enum HandsStates
		{
			// Token: 0x0400079C RID: 1948
			[Token(Token = "0x400079C")]
			BothFree,
			// Token: 0x0400079D RID: 1949
			[Token(Token = "0x400079D")]
			RightAttached = 2,
			// Token: 0x0400079E RID: 1950
			[Token(Token = "0x400079E")]
			LeftAttached = 4,
			// Token: 0x0400079F RID: 1951
			[Token(Token = "0x400079F")]
			BothAttached = 6
		}
	}
}
