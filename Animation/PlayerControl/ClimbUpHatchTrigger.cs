using System;
using System.Collections;
using Il2CppDummyDll;
using Sons.Cutscenes;
using Sons.Gameplay;
using UnityEngine;

namespace Sons.Animation.PlayerControl
{
	// Token: 0x020008C5 RID: 2245
	[Token(Token = "0x20008C5")]
	public class ClimbUpHatchTrigger : Cutscene
	{
		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x06003CA3 RID: 15523 RVA: 0x00011C40 File Offset: 0x0000FE40
		[Token(Token = "0x1700078E")]
		internal virtual int ClimbUpHatchHash
		{
			[Token(Token = "0x6003CA3")]
			[Address(RVA = "0x2F166A0", Offset = "0x2F156A0", VA = "0x182F166A0", Slot = "15")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x06003CA4 RID: 15524 RVA: 0x00011C58 File Offset: 0x0000FE58
		[Token(Token = "0x1700078F")]
		internal virtual int ClimbUpHatchHashB
		{
			[Token(Token = "0x6003CA4")]
			[Address(RVA = "0x2F16640", Offset = "0x2F15640", VA = "0x182F16640", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x06003CA5 RID: 15525 RVA: 0x00011C70 File Offset: 0x0000FE70
		[Token(Token = "0x17000790")]
		internal virtual int DismountLadderHash
		{
			[Token(Token = "0x6003CA5")]
			[Address(RVA = "0x2F16700", Offset = "0x2F15700", VA = "0x182F16700", Slot = "17")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x06003CA6 RID: 15526 RVA: 0x00011C88 File Offset: 0x0000FE88
		[Token(Token = "0x17000791")]
		internal virtual int DismountLadderOutroHash
		{
			[Token(Token = "0x6003CA6")]
			[Address(RVA = "0x2F16760", Offset = "0x2F15760", VA = "0x182F16760", Slot = "18")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x06003CA7 RID: 15527 RVA: 0x00011CA0 File Offset: 0x0000FEA0
		[Token(Token = "0x17000792")]
		internal Vector3 CurrentPlayerPosition
		{
			[Token(Token = "0x6003CA7")]
			[Address(RVA = "0x255EBC0", Offset = "0x255DBC0", VA = "0x18255EBC0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x06003CA8 RID: 15528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CA8")]
		[Address(RVA = "0x2F14A30", Offset = "0x2F13A30", VA = "0x182F14A30")]
		private void Update()
		{
		}

		// Token: 0x06003CA9 RID: 15529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CA9")]
		[Address(RVA = "0x2F15790", Offset = "0x2F14790", VA = "0x182F15790")]
		private void OnDisable()
		{
		}

		// Token: 0x06003CAA RID: 15530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CAA")]
		[Address(RVA = "0x2F157A0", Offset = "0x2F147A0", VA = "0x182F157A0")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x06003CAB RID: 15531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CAB")]
		[Address(RVA = "0x2F16440", Offset = "0x2F15440", VA = "0x182F16440")]
		private void StartCoroutineWrapper(IEnumerator coroutineMethod)
		{
		}

		// Token: 0x06003CAC RID: 15532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CAC")]
		[Address(RVA = "0x2F14A30", Offset = "0x2F13A30", VA = "0x182F14A30")]
		private void CheckRegisterInput()
		{
		}

		// Token: 0x06003CAD RID: 15533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CAD")]
		[Address(RVA = "0x2F15F40", Offset = "0x2F14F40", VA = "0x182F15F40")]
		private void RegisterInputAction()
		{
		}

		// Token: 0x06003CAE RID: 15534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CAE")]
		[Address(RVA = "0x2F16490", Offset = "0x2F15490", VA = "0x182F16490")]
		private void UnregisterInputAction()
		{
		}

		// Token: 0x06003CAF RID: 15535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CAF")]
		[Address(RVA = "0x2F15030", Offset = "0x2F14030", VA = "0x182F15030")]
		private void ClimbInputReceived()
		{
		}

		// Token: 0x06003CB0 RID: 15536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CB0")]
		[Address(RVA = "0x2F165D0", Offset = "0x2F155D0", VA = "0x182F165D0")]
		private IEnumerator WaitForEmptyHandsWorker()
		{
			return null;
		}

		// Token: 0x06003CB1 RID: 15537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CB1")]
		[Address(RVA = "0x2F150C0", Offset = "0x2F140C0", VA = "0x182F150C0")]
		private IEnumerator ClimbLadderWorker()
		{
			return null;
		}

		// Token: 0x06003CB2 RID: 15538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CB2")]
		[Address(RVA = "0x2F161B0", Offset = "0x2F151B0", VA = "0x182F161B0")]
		private static void SetPlayerLocked(bool locked)
		{
		}

		// Token: 0x06003CB3 RID: 15539 RVA: 0x00011CB8 File Offset: 0x0000FEB8
		[Token(Token = "0x6003CB3")]
		[Address(RVA = "0x2F151A0", Offset = "0x2F141A0", VA = "0x182F151A0")]
		private int GetIntroAnimHash()
		{
			return default(int);
		}

		// Token: 0x06003CB4 RID: 15540 RVA: 0x00011CD0 File Offset: 0x0000FED0
		[Token(Token = "0x6003CB4")]
		[Address(RVA = "0x2F163E0", Offset = "0x2F153E0", VA = "0x182F163E0", Slot = "19")]
		internal virtual bool ShouldDismount()
		{
			return default(bool);
		}

		// Token: 0x06003CB5 RID: 15541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CB5")]
		[Address(RVA = "0x2F16580", Offset = "0x2F15580", VA = "0x182F16580")]
		private void UpdatePlayerTransform()
		{
		}

		// Token: 0x06003CB6 RID: 15542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CB6")]
		[Address(RVA = "0x2F15130", Offset = "0x2F14130", VA = "0x182F15130")]
		private IEnumerator DismountLadderWorker()
		{
			return null;
		}

		// Token: 0x06003CB7 RID: 15543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CB7")]
		[Address(RVA = "0x2F14B40", Offset = "0x2F13B40", VA = "0x182F14B40", Slot = "13")]
		protected override void Cleanup()
		{
		}

		// Token: 0x06003CB8 RID: 15544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CB8")]
		[Address(RVA = "0x2F14FC0", Offset = "0x2F13FC0", VA = "0x182F14FC0")]
		private void ClearIsInMidAction()
		{
		}

		// Token: 0x06003CB9 RID: 15545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CB9")]
		[Address(RVA = "0x2F16030", Offset = "0x2F15030", VA = "0x182F16030", Slot = "14")]
		protected override void ResetCutscene()
		{
		}

		// Token: 0x06003CBA RID: 15546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CBA")]
		[Address(RVA = "0x2F16470", Offset = "0x2F15470", VA = "0x182F16470")]
		private void StopActiveCoroutine()
		{
		}

		// Token: 0x06003CBB RID: 15547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CBB")]
		[Address(RVA = "0x2F15230", Offset = "0x2F14230", VA = "0x182F15230")]
		private void InitializePlayerSetup()
		{
		}

		// Token: 0x06003CBC RID: 15548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CBC")]
		[Address(RVA = "0x2F160D0", Offset = "0x2F150D0", VA = "0x182F160D0", Slot = "20")]
		internal virtual void SetClimbUpAnimBool(bool value)
		{
		}

		// Token: 0x06003CBD RID: 15549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CBD")]
		[Address(RVA = "0x2F15A90", Offset = "0x2F14A90", VA = "0x182F15A90")]
		private void OnPlayerAnimatorMove()
		{
		}

		// Token: 0x06003CBE RID: 15550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CBE")]
		[Address(RVA = "0x2F14890", Offset = "0x2F13890", VA = "0x182F14890")]
		public ClimbUpHatchTrigger()
		{
		}

		// Token: 0x040040CD RID: 16589
		[Token(Token = "0x40040CD")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		internal Transform _dismountPointGuide;

		// Token: 0x040040CE RID: 16590
		[Token(Token = "0x40040CE")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Transform _alignTransform;

		// Token: 0x040040CF RID: 16591
		[Token(Token = "0x40040CF")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private GameObject _guiGameObject;

		// Token: 0x040040D0 RID: 16592
		[Token(Token = "0x40040D0")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private GenericInteraction _interaction;

		// Token: 0x040040D1 RID: 16593
		[Token(Token = "0x40040D1")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private float _climbOutTimer;

		// Token: 0x040040D2 RID: 16594
		[Token(Token = "0x40040D2")]
		[FieldOffset(Offset = "0xD4")]
		[SerializeField]
		private float _fov;

		// Token: 0x040040D3 RID: 16595
		[Token(Token = "0x40040D3")]
		[FieldOffset(Offset = "0xD8")]
		private ClimbUpHatchStates _activeState;

		// Token: 0x040040D4 RID: 16596
		[Token(Token = "0x40040D4")]
		[FieldOffset(Offset = "0xDC")]
		[SerializeField]
		private bool _offsetClimbStart;

		// Token: 0x040040D5 RID: 16597
		[Token(Token = "0x40040D5")]
		private const float GroundDismountOffset = -2.6f;

		// Token: 0x040040D6 RID: 16598
		[Token(Token = "0x40040D6")]
		[FieldOffset(Offset = "0xDD")]
		private bool _registeredAction;

		// Token: 0x040040D7 RID: 16599
		[Token(Token = "0x40040D7")]
		[FieldOffset(Offset = "0xE0")]
		private Vector3 _originalPosition;

		// Token: 0x040040D8 RID: 16600
		[Token(Token = "0x40040D8")]
		[FieldOffset(Offset = "0xEC")]
		private Vector3 _playerMovementOffset;

		// Token: 0x040040D9 RID: 16601
		[Token(Token = "0x40040D9")]
		[FieldOffset(Offset = "0xF8")]
		private Quaternion _playerRotationOffset;

		// Token: 0x040040DA RID: 16602
		[Token(Token = "0x40040DA")]
		[FieldOffset(Offset = "0x108")]
		private float _originalFov;

		// Token: 0x040040DB RID: 16603
		[Token(Token = "0x40040DB")]
		[FieldOffset(Offset = "0x110")]
		private Coroutine _activeCoroutine;

		// Token: 0x040040DC RID: 16604
		[Token(Token = "0x40040DC")]
		[FieldOffset(Offset = "0x118")]
		private bool _isInMidActionSet;

		// Token: 0x040040DD RID: 16605
		[Token(Token = "0x40040DD")]
		[FieldOffset(Offset = "0x11C")]
		private Vector3 _currentPlayerPosition;

		// Token: 0x040040DE RID: 16606
		[Token(Token = "0x40040DE")]
		[FieldOffset(Offset = "0x128")]
		private Quaternion _currentPlayerRotation;
	}
}
