using System;
using FMOD.Studio;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.Inventory;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Weapon
{
	// Token: 0x020008E5 RID: 2277
	[Token(Token = "0x20008E5")]
	[AddComponentMenu("Sons/Weapon/TaserStickWeaponController")]
	public class TaserStickWeaponController : GenericMeleeWeaponController, IItemInstanceModuleConsumer
	{
		// Token: 0x06004116 RID: 16662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004116")]
		[Address(RVA = "0x360A000", Offset = "0x3608600", VA = "0x18360A000", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, ItemInstance itemInstance)
		{
		}

		// Token: 0x06004117 RID: 16663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004117")]
		[Address(RVA = "0x360A120", Offset = "0x3608720", VA = "0x18360A120", Slot = "32")]
		public void ModuleRefreshed(ItemInstanceModule module)
		{
		}

		// Token: 0x06004118 RID: 16664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004118")]
		[Address(RVA = "0x360A210", Offset = "0x3608810", VA = "0x18360A210", Slot = "13")]
		protected override void OnDisable()
		{
		}

		// Token: 0x06004119 RID: 16665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004119")]
		[Address(RVA = "0x360A3B0", Offset = "0x36089B0", VA = "0x18360A3B0", Slot = "17")]
		internal override void Update()
		{
		}

		// Token: 0x0600411A RID: 16666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600411A")]
		[Address(RVA = "0x360A600", Offset = "0x3608C00", VA = "0x18360A600", Slot = "11")]
		protected override void OnDamageSuccess(DamageNode damageNode, IImpactData impactData)
		{
		}

		// Token: 0x0600411B RID: 16667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600411B")]
		[Address(RVA = "0x360A820", Offset = "0x3608E20", VA = "0x18360A820")]
		private void OnItemActivated()
		{
		}

		// Token: 0x0600411C RID: 16668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600411C")]
		[Address(RVA = "0x360A9E0", Offset = "0x3608FE0", VA = "0x18360A9E0")]
		private void OnItemDeactivated()
		{
		}

		// Token: 0x0600411D RID: 16669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600411D")]
		[Address(RVA = "0x360AB20", Offset = "0x3609120", VA = "0x18360AB20", Slot = "30")]
		protected override void SetSwingType(weaponInfo.SwingType swingType)
		{
		}

		// Token: 0x0600411E RID: 16670 RVA: 0x00013E78 File Offset: 0x00012078
		[Token(Token = "0x600411E")]
		[Address(RVA = "0x360ABA0", Offset = "0x36091A0", VA = "0x18360ABA0", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x0600411F RID: 16671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600411F")]
		[Address(RVA = "0x360AC50", Offset = "0x3609250", VA = "0x18360AC50")]
		public TaserStickWeaponController()
		{
		}

		// Token: 0x040035EB RID: 13803
		[Token(Token = "0x40035EB")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		private float _powerDrainPerShock;

		// Token: 0x040035EC RID: 13804
		[Token(Token = "0x40035EC")]
		[FieldOffset(Offset = "0x184")]
		[Range(0f, 1f)]
		private float _remainingPower;

		// Token: 0x040035ED RID: 13805
		[Token(Token = "0x40035ED")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		private BatteryIndicator _batteryIndicator;

		// Token: 0x040035EE RID: 13806
		[Token(Token = "0x40035EE")]
		[FieldOffset(Offset = "0x190")]
		[EventRef]
		[SerializeField]
		private string _replaceBatteryAudioEvent;

		// Token: 0x040035EF RID: 13807
		[Token(Token = "0x40035EF")]
		[FieldOffset(Offset = "0x198")]
		[SerializeField]
		private GameObject _activatedGroup;

		// Token: 0x040035F0 RID: 13808
		[Token(Token = "0x40035F0")]
		[FieldOffset(Offset = "0x1A0")]
		[FormerlySerializedAs("_activatedEffect")]
		[EventRef]
		[SerializeField]
		private string _activatedAudioEvent;

		// Token: 0x040035F1 RID: 13809
		[Token(Token = "0x40035F1")]
		[FieldOffset(Offset = "0x1A8")]
		private EventInstance _activatedEventInstance;

		// Token: 0x040035F2 RID: 13810
		[Token(Token = "0x40035F2")]
		[FieldOffset(Offset = "0x1B0")]
		private VolumeContainerItemInstanceModule _powerCapacity;
	}
}
