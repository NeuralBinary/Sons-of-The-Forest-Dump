using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Endnight.Animation;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.Items.Core;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x0200084D RID: 2125
	[Token(Token = "0x200084D")]
	public abstract class HeldControllerBase : MonoBehaviour, IHeldItem
	{
		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x060038C1 RID: 14529 RVA: 0x000109F8 File Offset: 0x0000EBF8
		[Token(Token = "0x17000711")]
		public bool IsUnequipping
		{
			[Token(Token = "0x60038C1")]
			[Address(RVA = "0x1362FD0", Offset = "0x1361FD0", VA = "0x181362FD0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x060038C2 RID: 14530 RVA: 0x00010A10 File Offset: 0x0000EC10
		[Token(Token = "0x17000712")]
		public bool IsStashing
		{
			[Token(Token = "0x60038C2")]
			[Address(RVA = "0x1DD5080", Offset = "0x1DD4080", VA = "0x181DD5080")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060038C3 RID: 14531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038C3")]
		[Address(RVA = "0x2ECF5A0", Offset = "0x2ECE5A0", VA = "0x182ECF5A0")]
		public static void SetFirstLookForce(bool value)
		{
		}

		// Token: 0x060038C4 RID: 14532 RVA: 0x00010A28 File Offset: 0x0000EC28
		[Token(Token = "0x60038C4")]
		[Address(RVA = "0x576330", Offset = "0x575330", VA = "0x180576330")]
		protected int GetItemId()
		{
			return default(int);
		}

		// Token: 0x060038C5 RID: 14533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038C5")]
		[Address(RVA = "0x2ECF1A0", Offset = "0x2ECE1A0", VA = "0x182ECF1A0")]
		private string GetSeenFirstTimeEquipKey()
		{
			return null;
		}

		// Token: 0x060038C6 RID: 14534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038C6")]
		[Address(RVA = "0x2ECF430", Offset = "0x2ECE430", VA = "0x182ECF430")]
		protected ItemData ItemData()
		{
			return null;
		}

		// Token: 0x060038C7 RID: 14535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038C7")]
		[Address(RVA = "0x2ECF300", Offset = "0x2ECE300", VA = "0x182ECF300", Slot = "5")]
		public virtual void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, int itemId)
		{
		}

		// Token: 0x060038C8 RID: 14536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038C8")]
		[Address(RVA = "0x2ECF4C0", Offset = "0x2ECE4C0", VA = "0x182ECF4C0", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x060038C9 RID: 14537 RVA: 0x00010A40 File Offset: 0x0000EC40
		[Token(Token = "0x60038C9")]
		[Address(RVA = "0x2ECF210", Offset = "0x2ECE210", VA = "0x182ECF210")]
		protected bool GetSeenFirstTimeEquip()
		{
			return default(bool);
		}

		// Token: 0x060038CA RID: 14538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038CA")]
		[Address(RVA = "0x2ECF5E0", Offset = "0x2ECE5E0", VA = "0x182ECF5E0")]
		internal void SetupFirstTimeEquip()
		{
		}

		// Token: 0x060038CB RID: 14539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038CB")]
		[Address(RVA = "0x2ECEFA0", Offset = "0x2ECDFA0", VA = "0x182ECEFA0")]
		protected void ClearFirstTimeEquip()
		{
		}

		// Token: 0x060038CC RID: 14540 RVA: 0x00010A58 File Offset: 0x0000EC58
		[Token(Token = "0x60038CC")]
		[Address(RVA = "0x2ECF810", Offset = "0x2ECE810", VA = "0x182ECF810")]
		protected bool TryLinkAnimationSync(Animator driver)
		{
			return default(bool);
		}

		// Token: 0x060038CD RID: 14541
		[Token(Token = "0x60038CD")]
		public abstract bool IsItemIdle();

		// Token: 0x060038CE RID: 14542 RVA: 0x00010A70 File Offset: 0x0000EC70
		[Token(Token = "0x60038CE")]
		[Address(RVA = "0x2ECF3A0", Offset = "0x2ECE3A0", VA = "0x182ECF3A0", Slot = "8")]
		protected virtual bool IsLocalPlayer()
		{
			return default(bool);
		}

		// Token: 0x060038CF RID: 14543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038CF")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "9")]
		protected virtual void UnequipStartedHook()
		{
		}

		// Token: 0x060038D0 RID: 14544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038D0")]
		[Address(RVA = "0x2ECF910", Offset = "0x2ECE910", VA = "0x182ECF910")]
		public void UnequipStarted(EquipmentSlot slot, bool drop, bool stash, bool equipPrevious, bool instantDestroy)
		{
		}

		// Token: 0x060038D1 RID: 14545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038D1")]
		[Address(RVA = "0x2EC61C0", Offset = "0x2EC51C0", VA = "0x182EC61C0")]
		protected HeldControllerBase()
		{
		}

		// Token: 0x060038D2 RID: 14546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038D2")]
		[Address(RVA = "0x2ECF8A0", Offset = "0x2ECE8A0", VA = "0x182ECF8A0")]
		[CompilerGenerated]
		private IEnumerator <SetupFirstTimeEquip>g__WaitUntilIdle|31_0()
		{
			return null;
		}

		// Token: 0x04003072 RID: 12402
		[Token(Token = "0x4003072")]
		[FieldOffset(Offset = "0x0")]
		internal static bool _forceFirstLook;

		// Token: 0x04003073 RID: 12403
		[Token(Token = "0x4003073")]
		[FieldOffset(Offset = "0x20")]
		internal int _itemId;

		// Token: 0x04003074 RID: 12404
		[Token(Token = "0x4003074")]
		[FieldOffset(Offset = "0x28")]
		internal Transform _playerRootTransform;

		// Token: 0x04003075 RID: 12405
		[Token(Token = "0x4003075")]
		[FieldOffset(Offset = "0x30")]
		internal Transform _playerBaseTransform;

		// Token: 0x04003076 RID: 12406
		[Token(Token = "0x4003076")]
		[FieldOffset(Offset = "0x38")]
		protected Animator _playerAnimator;

		// Token: 0x04003077 RID: 12407
		[Token(Token = "0x4003077")]
		[FieldOffset(Offset = "0x40")]
		protected PlayerAnimatorControl _playerAnimatorControl;

		// Token: 0x04003078 RID: 12408
		[Token(Token = "0x4003078")]
		[FieldOffset(Offset = "0x48")]
		protected AnimationEventReceiver _receiver;

		// Token: 0x04003079 RID: 12409
		[Token(Token = "0x4003079")]
		[FieldOffset(Offset = "0x50")]
		private AnimationSync _animationSync;

		// Token: 0x0400307A RID: 12410
		[Token(Token = "0x400307A")]
		[FieldOffset(Offset = "0x58")]
		private ItemData _itemData;

		// Token: 0x0400307B RID: 12411
		[Token(Token = "0x400307B")]
		[FieldOffset(Offset = "0x60")]
		protected bool _isInitialised;

		// Token: 0x0400307C RID: 12412
		[Token(Token = "0x400307C")]
		[FieldOffset(Offset = "0x61")]
		private bool _isUnequipping;

		// Token: 0x0400307D RID: 12413
		[Token(Token = "0x400307D")]
		[FieldOffset(Offset = "0x62")]
		private bool _isStashing;

		// Token: 0x0400307E RID: 12414
		[Token(Token = "0x400307E")]
		[FieldOffset(Offset = "0x63")]
		private bool _isDropping;

		// Token: 0x0400307F RID: 12415
		[Token(Token = "0x400307F")]
		[FieldOffset(Offset = "0x64")]
		private bool _isEquippingPrevious;

		// Token: 0x04003080 RID: 12416
		[Token(Token = "0x4003080")]
		[FieldOffset(Offset = "0x65")]
		private bool _isInstantDestroy;

		// Token: 0x04003081 RID: 12417
		[Token(Token = "0x4003081")]
		[FieldOffset(Offset = "0x66")]
		private bool _firstLookStashedLeftHand;

		// Token: 0x04003082 RID: 12418
		[Token(Token = "0x4003082")]
		[FieldOffset(Offset = "0x67")]
		private bool _firstLookStashedRightHand;

		// Token: 0x04003083 RID: 12419
		[Token(Token = "0x4003083")]
		[FieldOffset(Offset = "0x68")]
		private bool _firstLookIsRunning;

		// Token: 0x04003084 RID: 12420
		[Token(Token = "0x4003084")]
		protected const string DefaultEquipEvent = "event:/SotF Events/player sounds/Player_Inv_Grab";

		// Token: 0x04003085 RID: 12421
		[Token(Token = "0x4003085")]
		protected const string DefaultStashEvent = "event:/SotF Events/player sounds/Player_Inv_Stash";
	}
}
