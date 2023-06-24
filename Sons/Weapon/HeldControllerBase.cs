using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Endnight.Animation;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.Inventory;
using Sons.Items.Core;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x020008BD RID: 2237
	[Token(Token = "0x20008BD")]
	public abstract class HeldControllerBase : MonoBehaviour, IHeldItem
	{
		// Token: 0x17000833 RID: 2099
		// (get) Token: 0x06003FD9 RID: 16345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000833")]
		internal ItemInstance ItemInstance
		{
			[Token(Token = "0x6003FD9")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000834 RID: 2100
		// (get) Token: 0x06003FDA RID: 16346 RVA: 0x000137B8 File Offset: 0x000119B8
		[Token(Token = "0x17000834")]
		internal int ItemId
		{
			[Token(Token = "0x6003FDA")]
			[Address(RVA = "0x35EFED0", Offset = "0x35EE4D0", VA = "0x1835EFED0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06003FDB RID: 16347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FDB")]
		[Address(RVA = "0x35F0010", Offset = "0x35EE610", VA = "0x1835F0010")]
		protected ItemData GetItemData()
		{
			return null;
		}

		// Token: 0x17000835 RID: 2101
		// (get) Token: 0x06003FDC RID: 16348 RVA: 0x000137D0 File Offset: 0x000119D0
		[Token(Token = "0x17000835")]
		public bool IsUnequipping
		{
			[Token(Token = "0x6003FDC")]
			[Address(RVA = "0x998F20", Offset = "0x997520", VA = "0x180998F20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000836 RID: 2102
		// (get) Token: 0x06003FDD RID: 16349 RVA: 0x000137E8 File Offset: 0x000119E8
		[Token(Token = "0x17000836")]
		public bool IsStashing
		{
			[Token(Token = "0x6003FDD")]
			[Address(RVA = "0x998F40", Offset = "0x997540", VA = "0x180998F40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003FDE RID: 16350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FDE")]
		[Address(RVA = "0x35F0140", Offset = "0x35EE740", VA = "0x1835F0140")]
		public static void SetFirstLookForce(bool value)
		{
		}

		// Token: 0x06003FDF RID: 16351 RVA: 0x00013800 File Offset: 0x00011A00
		[Token(Token = "0x6003FDF")]
		[Address(RVA = "0x35F0180", Offset = "0x35EE780", VA = "0x1835F0180")]
		protected int GetItemId()
		{
			return 0;
		}

		// Token: 0x06003FE0 RID: 16352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FE0")]
		[Address(RVA = "0x35F0190", Offset = "0x35EE790", VA = "0x1835F0190")]
		private string GetSeenFirstTimeEquipKey()
		{
			return null;
		}

		// Token: 0x06003FE1 RID: 16353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FE1")]
		[Address(RVA = "0x35F0200", Offset = "0x35EE800", VA = "0x1835F0200", Slot = "5")]
		public virtual void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, ItemInstance itemInstance)
		{
		}

		// Token: 0x06003FE2 RID: 16354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FE2")]
		[Address(RVA = "0x35F0490", Offset = "0x35EEA90", VA = "0x1835F0490", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x06003FE3 RID: 16355 RVA: 0x00013818 File Offset: 0x00011A18
		[Token(Token = "0x6003FE3")]
		[Address(RVA = "0x35F0560", Offset = "0x35EEB60", VA = "0x1835F0560")]
		protected bool GetSeenFirstTimeEquip()
		{
			return default(bool);
		}

		// Token: 0x06003FE4 RID: 16356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FE4")]
		[Address(RVA = "0x35F06D0", Offset = "0x35EECD0", VA = "0x1835F06D0")]
		internal void SetupFirstTimeEquip()
		{
		}

		// Token: 0x06003FE5 RID: 16357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FE5")]
		[Address(RVA = "0x35F09A0", Offset = "0x35EEFA0", VA = "0x1835F09A0")]
		protected void ClearFirstTimeEquip()
		{
		}

		// Token: 0x06003FE6 RID: 16358 RVA: 0x00013830 File Offset: 0x00011A30
		[Token(Token = "0x6003FE6")]
		[Address(RVA = "0x35F0D00", Offset = "0x35EF300", VA = "0x1835F0D00")]
		protected bool TryLinkAnimationSync(Animator driver)
		{
			return default(bool);
		}

		// Token: 0x06003FE7 RID: 16359
		[Token(Token = "0x6003FE7")]
		public abstract bool IsItemIdle();

		// Token: 0x06003FE8 RID: 16360 RVA: 0x00013848 File Offset: 0x00011A48
		[Token(Token = "0x6003FE8")]
		[Address(RVA = "0x35F0DF0", Offset = "0x35EF3F0", VA = "0x1835F0DF0", Slot = "8")]
		protected virtual bool IsLocalPlayer()
		{
			return default(bool);
		}

		// Token: 0x06003FE9 RID: 16361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FE9")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "9")]
		protected virtual void UnequipStartedHook()
		{
		}

		// Token: 0x06003FEA RID: 16362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FEA")]
		[Address(RVA = "0x35F0F50", Offset = "0x35EF550", VA = "0x1835F0F50")]
		public void UnequipStarted(EquipmentSlot slot, bool drop, bool stash, bool equipPrevious, bool instantDestroy)
		{
		}

		// Token: 0x06003FEB RID: 16363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FEB")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		protected HeldControllerBase()
		{
		}

		// Token: 0x06003FEC RID: 16364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FEC")]
		[Address(RVA = "0x35F0F80", Offset = "0x35EF580", VA = "0x1835F0F80")]
		[CompilerGenerated]
		private IEnumerator <SetupFirstTimeEquip>g__WaitUntilIdle|34_0()
		{
			return null;
		}

		// Token: 0x04003539 RID: 13625
		[Token(Token = "0x4003539")]
		[FieldOffset(Offset = "0x0")]
		internal static bool _forceFirstLook;

		// Token: 0x0400353A RID: 13626
		[Token(Token = "0x400353A")]
		[FieldOffset(Offset = "0x20")]
		internal ItemInstance _itemInstance;

		// Token: 0x0400353B RID: 13627
		[Token(Token = "0x400353B")]
		[FieldOffset(Offset = "0x28")]
		internal Transform _playerRootTransform;

		// Token: 0x0400353C RID: 13628
		[Token(Token = "0x400353C")]
		[FieldOffset(Offset = "0x30")]
		internal Transform _playerBaseTransform;

		// Token: 0x0400353D RID: 13629
		[Token(Token = "0x400353D")]
		[FieldOffset(Offset = "0x38")]
		protected Animator _playerAnimator;

		// Token: 0x0400353E RID: 13630
		[Token(Token = "0x400353E")]
		[FieldOffset(Offset = "0x40")]
		protected PlayerAnimatorControl _playerAnimatorControl;

		// Token: 0x0400353F RID: 13631
		[Token(Token = "0x400353F")]
		[FieldOffset(Offset = "0x48")]
		protected AnimationEventReceiver _receiver;

		// Token: 0x04003540 RID: 13632
		[Token(Token = "0x4003540")]
		[FieldOffset(Offset = "0x50")]
		private AnimationSync _animationSync;

		// Token: 0x04003541 RID: 13633
		[Token(Token = "0x4003541")]
		[FieldOffset(Offset = "0x58")]
		protected bool _isInitialised;

		// Token: 0x04003542 RID: 13634
		[Token(Token = "0x4003542")]
		[FieldOffset(Offset = "0x59")]
		private bool _isUnequipping;

		// Token: 0x04003543 RID: 13635
		[Token(Token = "0x4003543")]
		[FieldOffset(Offset = "0x5A")]
		private bool _isStashing;

		// Token: 0x04003544 RID: 13636
		[Token(Token = "0x4003544")]
		[FieldOffset(Offset = "0x5B")]
		private bool _isDropping;

		// Token: 0x04003545 RID: 13637
		[Token(Token = "0x4003545")]
		[FieldOffset(Offset = "0x5C")]
		private bool _isEquippingPrevious;

		// Token: 0x04003546 RID: 13638
		[Token(Token = "0x4003546")]
		[FieldOffset(Offset = "0x5D")]
		private bool _isInstantDestroy;

		// Token: 0x04003547 RID: 13639
		[Token(Token = "0x4003547")]
		[FieldOffset(Offset = "0x5E")]
		private bool _firstLookStashedLeftHand;

		// Token: 0x04003548 RID: 13640
		[Token(Token = "0x4003548")]
		[FieldOffset(Offset = "0x5F")]
		private bool _firstLookStashedRightHand;

		// Token: 0x04003549 RID: 13641
		[Token(Token = "0x4003549")]
		[FieldOffset(Offset = "0x60")]
		private bool _firstLookIsRunning;

		// Token: 0x0400354A RID: 13642
		[Token(Token = "0x400354A")]
		protected const string DefaultEquipEvent = "event:/SotF Events/player sounds/Player_Inv_Grab";

		// Token: 0x0400354B RID: 13643
		[Token(Token = "0x400354B")]
		protected const string DefaultStashEvent = "event:/SotF Events/player sounds/Player_Inv_Stash";
	}
}
