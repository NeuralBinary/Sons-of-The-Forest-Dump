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
	// Token: 0x02000874 RID: 2164
	[Token(Token = "0x2000874")]
	[AddComponentMenu("Sons/Weapon/TaserStickWeaponController")]
	public class TaserStickWeaponController : GenericMeleeWeaponController, IItemInstanceModuleConsumer
	{
		// Token: 0x060039EF RID: 14831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039EF")]
		[Address(RVA = "0x2F07A20", Offset = "0x2F06A20", VA = "0x182F07A20", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, int itemId)
		{
		}

		// Token: 0x060039F0 RID: 14832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039F0")]
		[Address(RVA = "0x2F07C70", Offset = "0x2F06C70", VA = "0x182F07C70", Slot = "32")]
		public void ModuleRefreshed(ItemInstanceModule module)
		{
		}

		// Token: 0x060039F1 RID: 14833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039F1")]
		[Address(RVA = "0x2F07F50", Offset = "0x2F06F50", VA = "0x182F07F50", Slot = "13")]
		protected override void OnDisable()
		{
		}

		// Token: 0x060039F2 RID: 14834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039F2")]
		[Address(RVA = "0x2F08350", Offset = "0x2F07350", VA = "0x182F08350", Slot = "17")]
		internal override void Update()
		{
		}

		// Token: 0x060039F3 RID: 14835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039F3")]
		[Address(RVA = "0x2F07D30", Offset = "0x2F06D30", VA = "0x182F07D30", Slot = "11")]
		protected override void OnDamageSuccess(DamageNode damageNode, IImpactData impactData)
		{
		}

		// Token: 0x060039F4 RID: 14836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039F4")]
		[Address(RVA = "0x2F08120", Offset = "0x2F07120", VA = "0x182F08120")]
		private void OnItemActivated()
		{
		}

		// Token: 0x060039F5 RID: 14837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039F5")]
		[Address(RVA = "0x2F08230", Offset = "0x2F07230", VA = "0x182F08230")]
		private void OnItemDeactivated()
		{
		}

		// Token: 0x060039F6 RID: 14838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039F6")]
		[Address(RVA = "0x2F082E0", Offset = "0x2F072E0", VA = "0x182F082E0", Slot = "30")]
		protected override void SetSwingType(weaponInfo.SwingType swingType)
		{
		}

		// Token: 0x060039F7 RID: 14839 RVA: 0x00010FE0 File Offset: 0x0000F1E0
		[Token(Token = "0x60039F7")]
		[Address(RVA = "0x2F07BB0", Offset = "0x2F06BB0", VA = "0x182F07BB0", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x060039F8 RID: 14840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039F8")]
		[Address(RVA = "0x2F08590", Offset = "0x2F07590", VA = "0x182F08590")]
		public TaserStickWeaponController()
		{
		}

		// Token: 0x04003122 RID: 12578
		[Token(Token = "0x4003122")]
		[FieldOffset(Offset = "0x178")]
		[SerializeField]
		private float _powerDrainPerShock;

		// Token: 0x04003123 RID: 12579
		[Token(Token = "0x4003123")]
		[FieldOffset(Offset = "0x17C")]
		[Range(0f, 1f)]
		private float _remainingPower;

		// Token: 0x04003124 RID: 12580
		[Token(Token = "0x4003124")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		private BatteryIndicator _batteryIndicator;

		// Token: 0x04003125 RID: 12581
		[Token(Token = "0x4003125")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		[EventRef]
		private string _replaceBatteryAudioEvent;

		// Token: 0x04003126 RID: 12582
		[Token(Token = "0x4003126")]
		[FieldOffset(Offset = "0x190")]
		[SerializeField]
		private GameObject _activatedGroup;

		// Token: 0x04003127 RID: 12583
		[Token(Token = "0x4003127")]
		[FieldOffset(Offset = "0x198")]
		[EventRef]
		[FormerlySerializedAs("_activatedEffect")]
		[SerializeField]
		private string _activatedAudioEvent;

		// Token: 0x04003128 RID: 12584
		[Token(Token = "0x4003128")]
		[FieldOffset(Offset = "0x1A0")]
		private EventInstance _activatedEventInstance;

		// Token: 0x04003129 RID: 12585
		[Token(Token = "0x4003129")]
		[FieldOffset(Offset = "0x1A8")]
		private VolumeContainerItemInstanceModule _powerCapacity;
	}
}
