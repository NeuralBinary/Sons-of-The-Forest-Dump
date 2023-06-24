using System;
using Il2CppDummyDll;
using Sons.Gameplay.ZipLines;
using Sons.Player;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Sons.Gameplay
{
	// Token: 0x0200081B RID: 2075
	[Token(Token = "0x200081B")]
	[AddComponentMenu("Sons/Gameplay/PlayerKnightVAction")]
	public class PlayerKnightVAction : MonoBehaviour, IKnockDownReceiver
	{
		// Token: 0x060039A8 RID: 14760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039A8")]
		[Address(RVA = "0x355CF20", Offset = "0x355B520", VA = "0x18355CF20")]
		private void OnValidate()
		{
		}

		// Token: 0x060039A9 RID: 14761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039A9")]
		[Address(RVA = "0x355D050", Offset = "0x355B650", VA = "0x18355D050")]
		private void Update()
		{
		}

		// Token: 0x060039AA RID: 14762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039AA")]
		[Address(RVA = "0x355D420", Offset = "0x355BA20", VA = "0x18355D420")]
		private void SetPendingReactivate()
		{
		}

		// Token: 0x060039AB RID: 14763 RVA: 0x00011808 File Offset: 0x0000FA08
		[Token(Token = "0x60039AB")]
		[Address(RVA = "0x355D480", Offset = "0x355BA80", VA = "0x18355D480")]
		private bool LocalPlayerRidingPaused()
		{
			return default(bool);
		}

		// Token: 0x060039AC RID: 14764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039AC")]
		[Address(RVA = "0x355D6C0", Offset = "0x355BCC0", VA = "0x18355D6C0")]
		private void UpdatePowerUsage()
		{
		}

		// Token: 0x060039AD RID: 14765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039AD")]
		[Address(RVA = "0x355D960", Offset = "0x355BF60", VA = "0x18355D960")]
		private void UpdateNotGroundedTimer()
		{
		}

		// Token: 0x060039AE RID: 14766 RVA: 0x00011820 File Offset: 0x0000FA20
		[Token(Token = "0x60039AE")]
		[Address(RVA = "0x355DAF0", Offset = "0x355C0F0", VA = "0x18355DAF0")]
		private static Vector2 GetMovementInput()
		{
			return default(Vector2);
		}

		// Token: 0x060039AF RID: 14767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039AF")]
		[Address(RVA = "0x355DB00", Offset = "0x355C100", VA = "0x18355DB00")]
		private void UpdateInput()
		{
		}

		// Token: 0x060039B0 RID: 14768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039B0")]
		[Address(RVA = "0x355E110", Offset = "0x355C710", VA = "0x18355E110")]
		private void FixedUpdate()
		{
		}

		// Token: 0x060039B1 RID: 14769 RVA: 0x00011838 File Offset: 0x0000FA38
		[Token(Token = "0x60039B1")]
		[Address(RVA = "0x355E5A0", Offset = "0x355CBA0", VA = "0x18355E5A0")]
		private bool CheckDeathDismount()
		{
			return default(bool);
		}

		// Token: 0x060039B2 RID: 14770 RVA: 0x00011850 File Offset: 0x0000FA50
		[Token(Token = "0x60039B2")]
		[Address(RVA = "0x355E6F0", Offset = "0x355CCF0", VA = "0x18355E6F0")]
		private static bool TimeStopped()
		{
			return default(bool);
		}

		// Token: 0x060039B3 RID: 14771 RVA: 0x00011868 File Offset: 0x0000FA68
		[Token(Token = "0x60039B3")]
		[Address(RVA = "0x355E740", Offset = "0x355CD40", VA = "0x18355E740")]
		private bool CheckWaterLevelDismount()
		{
			return default(bool);
		}

		// Token: 0x060039B4 RID: 14772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039B4")]
		[Address(RVA = "0x355E7D0", Offset = "0x355CDD0", VA = "0x18355E7D0")]
		private void UpdateCameraShake()
		{
		}

		// Token: 0x060039B5 RID: 14773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039B5")]
		[Address(RVA = "0x355E9D0", Offset = "0x355CFD0", VA = "0x18355E9D0")]
		private void SetCameraShakeFactor(float value)
		{
		}

		// Token: 0x060039B6 RID: 14774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039B6")]
		[Address(RVA = "0x355EBF0", Offset = "0x355D1F0", VA = "0x18355EBF0")]
		private void ClearCameraShake()
		{
		}

		// Token: 0x060039B7 RID: 14775 RVA: 0x00011880 File Offset: 0x0000FA80
		[Token(Token = "0x60039B7")]
		[Address(RVA = "0x355EC00", Offset = "0x355D200", VA = "0x18355EC00")]
		private float GetLastShakeFactor()
		{
			return 0f;
		}

		// Token: 0x060039B8 RID: 14776 RVA: 0x00011898 File Offset: 0x0000FA98
		[Token(Token = "0x60039B8")]
		[Address(RVA = "0x355ECA0", Offset = "0x355D2A0", VA = "0x18355ECA0")]
		private bool CheckWipeout()
		{
			return default(bool);
		}

		// Token: 0x060039B9 RID: 14777 RVA: 0x000118B0 File Offset: 0x0000FAB0
		[Token(Token = "0x60039B9")]
		[Address(RVA = "0x355EF50", Offset = "0x355D550", VA = "0x18355EF50")]
		private bool CollisionVelocityChangedWipeout(Vector3 changeInVelocityShaped, Vector3 newVelocity)
		{
			return default(bool);
		}

		// Token: 0x060039BA RID: 14778 RVA: 0x000118C8 File Offset: 0x0000FAC8
		[Token(Token = "0x60039BA")]
		[Address(RVA = "0x355F020", Offset = "0x355D620", VA = "0x18355F020")]
		private bool FallVelocityChangedWipeout(float changeInVelocityMagnitude, Vector3 newVelocity)
		{
			return default(bool);
		}

		// Token: 0x060039BB RID: 14779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039BB")]
		[Address(RVA = "0x355F0B0", Offset = "0x355D6B0", VA = "0x18355F0B0")]
		private void TriggerWipeout(Vector3 previousVelocity, Vector3 newVelocity, bool fromKnockDownEvent = false)
		{
		}

		// Token: 0x060039BC RID: 14780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039BC")]
		[Address(RVA = "0x355F420", Offset = "0x355DA20", VA = "0x18355F420")]
		private void DebugVelocity(bool value, Vector3 velocity)
		{
		}

		// Token: 0x060039BD RID: 14781 RVA: 0x000118E0 File Offset: 0x0000FAE0
		[Token(Token = "0x60039BD")]
		[Address(RVA = "0x355F5A0", Offset = "0x355DBA0", VA = "0x18355F5A0")]
		private bool CheckDismount()
		{
			return default(bool);
		}

		// Token: 0x060039BE RID: 14782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039BE")]
		[Address(RVA = "0x355F610", Offset = "0x355DC10", VA = "0x18355F610")]
		private void LateUpdate()
		{
		}

		// Token: 0x060039BF RID: 14783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039BF")]
		[Address(RVA = "0x355FBF0", Offset = "0x355E1F0", VA = "0x18355FBF0")]
		private void UpdateImpactEffects()
		{
		}

		// Token: 0x060039C0 RID: 14784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039C0")]
		[Address(RVA = "0x355FD20", Offset = "0x355E320", VA = "0x18355FD20")]
		private void UpdateBackup()
		{
		}

		// Token: 0x060039C1 RID: 14785 RVA: 0x000118F8 File Offset: 0x0000FAF8
		[Token(Token = "0x60039C1")]
		[Address(RVA = "0x355FF60", Offset = "0x355E560", VA = "0x18355FF60")]
		private bool IsStoppedOrBreaking()
		{
			return default(bool);
		}

		// Token: 0x060039C2 RID: 14786 RVA: 0x00011910 File Offset: 0x0000FB10
		[Token(Token = "0x60039C2")]
		[Address(RVA = "0x355FFB0", Offset = "0x355E5B0", VA = "0x18355FFB0")]
		private bool IsReversing()
		{
			return default(bool);
		}

		// Token: 0x060039C3 RID: 14787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039C3")]
		[Address(RVA = "0x355FFE0", Offset = "0x355E5E0", VA = "0x18355FFE0")]
		private void UpdateAudio()
		{
		}

		// Token: 0x060039C4 RID: 14788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039C4")]
		[Address(RVA = "0x3560690", Offset = "0x355EC90", VA = "0x183560690")]
		private void FadeVelocity()
		{
		}

		// Token: 0x060039C5 RID: 14789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039C5")]
		[Address(RVA = "0x3560AB0", Offset = "0x355F0B0", VA = "0x183560AB0")]
		private void UpdateAnimatorParams()
		{
		}

		// Token: 0x060039C6 RID: 14790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039C6")]
		[Address(RVA = "0x3560C30", Offset = "0x355F230", VA = "0x183560C30")]
		private void InitializeCamLookRotator()
		{
		}

		// Token: 0x060039C7 RID: 14791 RVA: 0x00011928 File Offset: 0x0000FB28
		[Token(Token = "0x60039C7")]
		[Address(RVA = "0x3560D60", Offset = "0x355F360", VA = "0x183560D60")]
		private Quaternion CalculateMoveRotation(float lean)
		{
			return default(Quaternion);
		}

		// Token: 0x060039C8 RID: 14792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039C8")]
		[Address(RVA = "0x3561020", Offset = "0x355F620", VA = "0x183561020")]
		private void UpdateRiding()
		{
		}

		// Token: 0x060039C9 RID: 14793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039C9")]
		[Address(RVA = "0x3561E10", Offset = "0x3560410", VA = "0x183561E10")]
		private void UpdateMoveRotation()
		{
		}

		// Token: 0x060039CA RID: 14794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039CA")]
		[Address(RVA = "0x3561EB0", Offset = "0x35604B0", VA = "0x183561EB0")]
		private void UpdateBushBreaker()
		{
		}

		// Token: 0x060039CB RID: 14795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039CB")]
		[Address(RVA = "0x3561F10", Offset = "0x3560510", VA = "0x183561F10")]
		private void UpdateNoiseStimuli()
		{
		}

		// Token: 0x060039CC RID: 14796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039CC")]
		[Address(RVA = "0x3562080", Offset = "0x3560680", VA = "0x183562080")]
		private void UpdateInMidAirAnimation()
		{
		}

		// Token: 0x060039CD RID: 14797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039CD")]
		[Address(RVA = "0x3562360", Offset = "0x3560960", VA = "0x183562360")]
		private void ClearIsInMidAirBool()
		{
		}

		// Token: 0x060039CE RID: 14798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039CE")]
		[Address(RVA = "0x35624B0", Offset = "0x3560AB0", VA = "0x1835624B0")]
		private void SetIsInMidAirBool()
		{
		}

		// Token: 0x060039CF RID: 14799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039CF")]
		[Address(RVA = "0x3562600", Offset = "0x3560C00", VA = "0x183562600")]
		private void UpdateJumpAnimation()
		{
		}

		// Token: 0x060039D0 RID: 14800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039D0")]
		[Address(RVA = "0x3562810", Offset = "0x3560E10", VA = "0x183562810")]
		private void UpdateWheelRotation()
		{
		}

		// Token: 0x060039D1 RID: 14801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039D1")]
		[Address(RVA = "0x3562940", Offset = "0x3560F40", VA = "0x183562940")]
		private void TriggerDismount(bool applyForce, bool playImpactEvent = false)
		{
		}

		// Token: 0x060039D2 RID: 14802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039D2")]
		[Address(RVA = "0x3562B00", Offset = "0x3561100", VA = "0x183562B00")]
		private void ApplyJumpForce()
		{
		}

		// Token: 0x060039D3 RID: 14803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039D3")]
		[Address(RVA = "0x3562C20", Offset = "0x3561220", VA = "0x183562C20")]
		private void ApplyJumpForceToRigidbody(float jumpForce)
		{
		}

		// Token: 0x060039D4 RID: 14804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039D4")]
		[Address(RVA = "0x3562D80", Offset = "0x3561380", VA = "0x183562D80")]
		public void SetActive(bool activeValue, KnightVItemController controller)
		{
		}

		// Token: 0x060039D5 RID: 14805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039D5")]
		[Address(RVA = "0x3562FF0", Offset = "0x35615F0", VA = "0x183562FF0")]
		public void Reactivate()
		{
		}

		// Token: 0x060039D6 RID: 14806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039D6")]
		[Address(RVA = "0x3563060", Offset = "0x3561660", VA = "0x183563060")]
		private void StartRiding()
		{
		}

		// Token: 0x060039D7 RID: 14807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039D7")]
		[Address(RVA = "0x3563A80", Offset = "0x3562080", VA = "0x183563A80")]
		private void OnJumpTriggered(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x060039D8 RID: 14808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039D8")]
		[Address(RVA = "0x3563BA0", Offset = "0x35621A0", VA = "0x183563BA0")]
		private void StopRiding()
		{
		}

		// Token: 0x060039D9 RID: 14809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039D9")]
		[Address(RVA = "0x3564790", Offset = "0x3562D90", VA = "0x183564790")]
		private void CheckExistingJumpBool()
		{
		}

		// Token: 0x060039DA RID: 14810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039DA")]
		[Address(RVA = "0x3564900", Offset = "0x3562F00", VA = "0x183564900")]
		private void SetJumpBool()
		{
		}

		// Token: 0x060039DB RID: 14811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039DB")]
		[Address(RVA = "0x3564A20", Offset = "0x3563020", VA = "0x183564A20")]
		private void SetBlockFullBodyInteraction()
		{
		}

		// Token: 0x060039DC RID: 14812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039DC")]
		[Address(RVA = "0x3564AA0", Offset = "0x35630A0", VA = "0x183564AA0")]
		private void ClearJumpBool()
		{
		}

		// Token: 0x060039DD RID: 14813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039DD")]
		[Address(RVA = "0x3564BC0", Offset = "0x35631C0", VA = "0x183564BC0")]
		private void ClearBlockFullBodyInteraction()
		{
		}

		// Token: 0x060039DE RID: 14814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039DE")]
		[Address(RVA = "0x3564C40", Offset = "0x3563240", VA = "0x183564C40")]
		private void ClearTemporaryValues()
		{
		}

		// Token: 0x060039DF RID: 14815 RVA: 0x00011940 File Offset: 0x0000FB40
		[Token(Token = "0x60039DF")]
		[Address(RVA = "0x3564CE0", Offset = "0x35632E0", VA = "0x183564CE0")]
		public bool IsActive()
		{
			return default(bool);
		}

		// Token: 0x060039E0 RID: 14816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039E0")]
		[Address(RVA = "0x3564D50", Offset = "0x3563350", VA = "0x183564D50", Slot = "4")]
		public void OnKnockDownStarted()
		{
		}

		// Token: 0x060039E1 RID: 14817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039E1")]
		[Address(RVA = "0x3564E10", Offset = "0x3563410", VA = "0x183564E10")]
		public PlayerKnightVAction()
		{
		}

		// Token: 0x04003174 RID: 12660
		[Token(Token = "0x4003174")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Rigidbody _rigidbody;

		// Token: 0x04003175 RID: 12661
		[Token(Token = "0x4003175")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CameraShakeController _cameraShakeController;

		// Token: 0x04003176 RID: 12662
		[Token(Token = "0x4003176")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private KnightVControlDefinition _controlDefinition;

		// Token: 0x04003177 RID: 12663
		[Token(Token = "0x4003177")]
		[FieldOffset(Offset = "0x38")]
		private PlayerKnightVState _state;

		// Token: 0x04003178 RID: 12664
		[Token(Token = "0x4003178")]
		[FieldOffset(Offset = "0x40")]
		private readonly string KnightVDismountStateKey;

		// Token: 0x04003179 RID: 12665
		[Token(Token = "0x4003179")]
		[FieldOffset(Offset = "0x48")]
		private readonly int ForwardLeanHash;

		// Token: 0x0400317A RID: 12666
		[Token(Token = "0x400317A")]
		[FieldOffset(Offset = "0x4C")]
		private readonly int BackwardLeanHash;

		// Token: 0x0400317B RID: 12667
		[Token(Token = "0x400317B")]
		[FieldOffset(Offset = "0x50")]
		private readonly int LeftLeanHash;

		// Token: 0x0400317C RID: 12668
		[Token(Token = "0x400317C")]
		[FieldOffset(Offset = "0x54")]
		private readonly int RightLeanHash;

		// Token: 0x0400317D RID: 12669
		[Token(Token = "0x400317D")]
		[FieldOffset(Offset = "0x58")]
		private SimpleMouseRotator _camLookRotator;

		// Token: 0x0400317E RID: 12670
		[Token(Token = "0x400317E")]
		[FieldOffset(Offset = "0x60")]
		private GroundedDetector _groundedDetector;

		// Token: 0x0400317F RID: 12671
		[Token(Token = "0x400317F")]
		[FieldOffset(Offset = "0x68")]
		private PlayerZipLineAction _playerZipLineAction;

		// Token: 0x04003180 RID: 12672
		[Token(Token = "0x4003180")]
		[FieldOffset(Offset = "0x70")]
		private readonly WaitForFixedUpdate _waitForFixedUpdate;
	}
}
