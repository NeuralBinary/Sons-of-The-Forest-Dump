using System;
using System.Collections;
using Il2CppDummyDll;
using Sons.Cutscenes;
using Sons.Gameplay;
using UnityEngine;

namespace Sons.Animation.PlayerControl
{
	// Token: 0x0200093A RID: 2362
	[Token(Token = "0x200093A")]
	public class ClimbUpHatchTrigger : Cutscene
	{
		// Token: 0x170008BC RID: 2236
		// (get) Token: 0x060043F8 RID: 17400 RVA: 0x00014BB0 File Offset: 0x00012DB0
		[Token(Token = "0x170008BC")]
		internal virtual int ClimbUpHatchHash
		{
			[Token(Token = "0x60043F8")]
			[Address(RVA = "0x364D7D0", Offset = "0x364BDD0", VA = "0x18364D7D0", Slot = "15")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170008BD RID: 2237
		// (get) Token: 0x060043F9 RID: 17401 RVA: 0x00014BC8 File Offset: 0x00012DC8
		[Token(Token = "0x170008BD")]
		internal virtual int ClimbUpHatchHashB
		{
			[Token(Token = "0x60043F9")]
			[Address(RVA = "0x364D830", Offset = "0x364BE30", VA = "0x18364D830", Slot = "16")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170008BE RID: 2238
		// (get) Token: 0x060043FA RID: 17402 RVA: 0x00014BE0 File Offset: 0x00012DE0
		[Token(Token = "0x170008BE")]
		internal virtual int DismountLadderHash
		{
			[Token(Token = "0x60043FA")]
			[Address(RVA = "0x364D890", Offset = "0x364BE90", VA = "0x18364D890", Slot = "17")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170008BF RID: 2239
		// (get) Token: 0x060043FB RID: 17403 RVA: 0x00014BF8 File Offset: 0x00012DF8
		[Token(Token = "0x170008BF")]
		internal virtual int DismountLadderOutroHash
		{
			[Token(Token = "0x60043FB")]
			[Address(RVA = "0x364D8F0", Offset = "0x364BEF0", VA = "0x18364D8F0", Slot = "18")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170008C0 RID: 2240
		// (get) Token: 0x060043FC RID: 17404 RVA: 0x00014C10 File Offset: 0x00012E10
		[Token(Token = "0x170008C0")]
		internal Vector3 CurrentPlayerPosition
		{
			[Token(Token = "0x60043FC")]
			[Address(RVA = "0x2A29D90", Offset = "0x2A28390", VA = "0x182A29D90")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x060043FD RID: 17405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043FD")]
		[Address(RVA = "0x364D950", Offset = "0x364BF50", VA = "0x18364D950")]
		private void Update()
		{
		}

		// Token: 0x060043FE RID: 17406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043FE")]
		[Address(RVA = "0x364DB00", Offset = "0x364C100", VA = "0x18364DB00")]
		private void OnDisable()
		{
		}

		// Token: 0x060043FF RID: 17407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043FF")]
		[Address(RVA = "0x364DB10", Offset = "0x364C110", VA = "0x18364DB10")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x06004400 RID: 17408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004400")]
		[Address(RVA = "0x364E000", Offset = "0x364C600", VA = "0x18364E000")]
		private void StartCoroutineWrapper(IEnumerator coroutineMethod)
		{
		}

		// Token: 0x06004401 RID: 17409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004401")]
		[Address(RVA = "0x364D950", Offset = "0x364BF50", VA = "0x18364D950")]
		private void CheckRegisterInput()
		{
		}

		// Token: 0x06004402 RID: 17410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004402")]
		[Address(RVA = "0x364E070", Offset = "0x364C670", VA = "0x18364E070")]
		private void RegisterInputAction()
		{
		}

		// Token: 0x06004403 RID: 17411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004403")]
		[Address(RVA = "0x364E200", Offset = "0x364C800", VA = "0x18364E200")]
		private void UnregisterInputAction()
		{
		}

		// Token: 0x06004404 RID: 17412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004404")]
		[Address(RVA = "0x364E390", Offset = "0x364C990", VA = "0x18364E390")]
		private void ClimbInputReceived()
		{
		}

		// Token: 0x06004405 RID: 17413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004405")]
		[Address(RVA = "0x364E440", Offset = "0x364CA40", VA = "0x18364E440")]
		private IEnumerator WaitForEmptyHandsWorker()
		{
			return null;
		}

		// Token: 0x06004406 RID: 17414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004406")]
		[Address(RVA = "0x364E4D0", Offset = "0x364CAD0", VA = "0x18364E4D0")]
		private IEnumerator ClimbLadderWorker()
		{
			return null;
		}

		// Token: 0x06004407 RID: 17415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004407")]
		[Address(RVA = "0x364E560", Offset = "0x364CB60", VA = "0x18364E560")]
		private static void SetPlayerLocked(bool locked)
		{
		}

		// Token: 0x06004408 RID: 17416 RVA: 0x00014C28 File Offset: 0x00012E28
		[Token(Token = "0x6004408")]
		[Address(RVA = "0x364E850", Offset = "0x364CE50", VA = "0x18364E850")]
		private int GetIntroAnimHash()
		{
			return 0;
		}

		// Token: 0x06004409 RID: 17417 RVA: 0x00014C40 File Offset: 0x00012E40
		[Token(Token = "0x6004409")]
		[Address(RVA = "0x364E8E0", Offset = "0x364CEE0", VA = "0x18364E8E0", Slot = "19")]
		internal virtual bool ShouldDismount()
		{
			return default(bool);
		}

		// Token: 0x0600440A RID: 17418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600440A")]
		[Address(RVA = "0x364E980", Offset = "0x364CF80", VA = "0x18364E980")]
		private void UpdatePlayerTransform()
		{
		}

		// Token: 0x0600440B RID: 17419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600440B")]
		[Address(RVA = "0x364E9D0", Offset = "0x364CFD0", VA = "0x18364E9D0")]
		private IEnumerator DismountLadderWorker()
		{
			return null;
		}

		// Token: 0x0600440C RID: 17420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600440C")]
		[Address(RVA = "0x364EA60", Offset = "0x364D060", VA = "0x18364EA60", Slot = "13")]
		protected override void Cleanup()
		{
		}

		// Token: 0x0600440D RID: 17421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600440D")]
		[Address(RVA = "0x364F050", Offset = "0x364D650", VA = "0x18364F050")]
		private void ClearIsInMidAction()
		{
		}

		// Token: 0x0600440E RID: 17422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600440E")]
		[Address(RVA = "0x364F0C0", Offset = "0x364D6C0", VA = "0x18364F0C0", Slot = "14")]
		protected override void ResetCutscene()
		{
		}

		// Token: 0x0600440F RID: 17423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600440F")]
		[Address(RVA = "0x364F160", Offset = "0x364D760", VA = "0x18364F160")]
		private void StopActiveCoroutine()
		{
		}

		// Token: 0x06004410 RID: 17424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004410")]
		[Address(RVA = "0x364F180", Offset = "0x364D780", VA = "0x18364F180")]
		private void InitializePlayerSetup()
		{
		}

		// Token: 0x06004411 RID: 17425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004411")]
		[Address(RVA = "0x364F8D0", Offset = "0x364DED0", VA = "0x18364F8D0", Slot = "20")]
		internal virtual void SetClimbUpAnimBool(bool value)
		{
		}

		// Token: 0x06004412 RID: 17426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004412")]
		[Address(RVA = "0x364F9B0", Offset = "0x364DFB0", VA = "0x18364F9B0")]
		private void OnPlayerAnimatorMove()
		{
		}

		// Token: 0x06004413 RID: 17427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004413")]
		[Address(RVA = "0x364D7B0", Offset = "0x364BDB0", VA = "0x18364D7B0")]
		public ClimbUpHatchTrigger()
		{
		}

		// Token: 0x04004713 RID: 18195
		[Token(Token = "0x4004713")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		internal Transform _dismountPointGuide;

		// Token: 0x04004714 RID: 18196
		[Token(Token = "0x4004714")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Transform _alignTransform;

		// Token: 0x04004715 RID: 18197
		[Token(Token = "0x4004715")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private GameObject _guiGameObject;

		// Token: 0x04004716 RID: 18198
		[Token(Token = "0x4004716")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private GenericInteraction _interaction;

		// Token: 0x04004717 RID: 18199
		[Token(Token = "0x4004717")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private float _climbOutTimer;

		// Token: 0x04004718 RID: 18200
		[Token(Token = "0x4004718")]
		[FieldOffset(Offset = "0xD4")]
		[SerializeField]
		private float _fov;

		// Token: 0x04004719 RID: 18201
		[Token(Token = "0x4004719")]
		[FieldOffset(Offset = "0xD8")]
		private ClimbUpHatchStates _activeState;

		// Token: 0x0400471A RID: 18202
		[Token(Token = "0x400471A")]
		[FieldOffset(Offset = "0xDC")]
		[SerializeField]
		private bool _offsetClimbStart;

		// Token: 0x0400471B RID: 18203
		[Token(Token = "0x400471B")]
		private const float GroundDismountOffset = -2.6f;

		// Token: 0x0400471C RID: 18204
		[Token(Token = "0x400471C")]
		[FieldOffset(Offset = "0xDD")]
		private bool _registeredAction;

		// Token: 0x0400471D RID: 18205
		[Token(Token = "0x400471D")]
		[FieldOffset(Offset = "0xE0")]
		private Vector3 _originalPosition;

		// Token: 0x0400471E RID: 18206
		[Token(Token = "0x400471E")]
		[FieldOffset(Offset = "0xEC")]
		private Vector3 _playerMovementOffset;

		// Token: 0x0400471F RID: 18207
		[Token(Token = "0x400471F")]
		[FieldOffset(Offset = "0xF8")]
		private Quaternion _playerRotationOffset;

		// Token: 0x04004720 RID: 18208
		[Token(Token = "0x4004720")]
		[FieldOffset(Offset = "0x108")]
		private float _originalFov;

		// Token: 0x04004721 RID: 18209
		[Token(Token = "0x4004721")]
		[FieldOffset(Offset = "0x110")]
		private Coroutine _activeCoroutine;

		// Token: 0x04004722 RID: 18210
		[Token(Token = "0x4004722")]
		[FieldOffset(Offset = "0x118")]
		private bool _isInMidActionSet;

		// Token: 0x04004723 RID: 18211
		[Token(Token = "0x4004723")]
		[FieldOffset(Offset = "0x11C")]
		private Vector3 _currentPlayerPosition;

		// Token: 0x04004724 RID: 18212
		[Token(Token = "0x4004724")]
		[FieldOffset(Offset = "0x128")]
		private Quaternion _currentPlayerRotation;
	}
}
