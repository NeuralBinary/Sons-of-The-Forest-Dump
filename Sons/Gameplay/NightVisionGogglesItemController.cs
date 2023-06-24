using System;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.Inventory;
using Sons.Weapon;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x02000747 RID: 1863
	[Token(Token = "0x2000747")]
	[AddComponentMenu("Sons/Gameplay/NightVisionGogglesItemController")]
	public class NightVisionGogglesItemController : HeldControllerBase, IItemInstanceModuleConsumer
	{
		// Token: 0x06003223 RID: 12835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003223")]
		[Address(RVA = "0x3498730", Offset = "0x3496D30", VA = "0x183498730", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, ItemInstance itemInstance)
		{
		}

		// Token: 0x06003224 RID: 12836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003224")]
		[Address(RVA = "0x3498870", Offset = "0x3496E70", VA = "0x183498870")]
		private NightVisionGoggles Goggles()
		{
			return null;
		}

		// Token: 0x06003225 RID: 12837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003225")]
		[Address(RVA = "0x34989C0", Offset = "0x3496FC0", VA = "0x1834989C0", Slot = "10")]
		public void ModuleRefreshed(ItemInstanceModule module)
		{
		}

		// Token: 0x06003226 RID: 12838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003226")]
		[Address(RVA = "0x3498AC0", Offset = "0x34970C0", VA = "0x183498AC0")]
		private void Update()
		{
		}

		// Token: 0x06003227 RID: 12839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003227")]
		[Address(RVA = "0x3498DC0", Offset = "0x34973C0", VA = "0x183498DC0")]
		private void OnDisable()
		{
		}

		// Token: 0x06003228 RID: 12840 RVA: 0x0000F300 File Offset: 0x0000D500
		[Token(Token = "0x6003228")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x06003229 RID: 12841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003229")]
		[Address(RVA = "0x3498EC0", Offset = "0x34974C0", VA = "0x183498EC0")]
		private void ActivateLookThroughMode(bool activate)
		{
		}

		// Token: 0x0600322A RID: 12842 RVA: 0x0000F318 File Offset: 0x0000D518
		[Token(Token = "0x600322A")]
		[Address(RVA = "0x3499110", Offset = "0x3497710", VA = "0x183499110")]
		private bool TryReplaceBattery()
		{
			return default(bool);
		}

		// Token: 0x0600322B RID: 12843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600322B")]
		[Address(RVA = "0x34993A0", Offset = "0x34979A0", VA = "0x1834993A0")]
		private void DisableRendererVisibility(bool onOff)
		{
		}

		// Token: 0x0600322C RID: 12844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600322C")]
		[Address(RVA = "0x34994A0", Offset = "0x3497AA0", VA = "0x1834994A0")]
		public NightVisionGogglesItemController()
		{
		}

		// Token: 0x04002B3B RID: 11067
		[Token(Token = "0x4002B3B")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _fullChargeDurationMinutes;

		// Token: 0x04002B3C RID: 11068
		[Token(Token = "0x4002B3C")]
		[FieldOffset(Offset = "0x6C")]
		[Range(0f, 1f)]
		private float _remainingPower;

		// Token: 0x04002B3D RID: 11069
		[Token(Token = "0x4002B3D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float _autoRefillThreshold;

		// Token: 0x04002B3E RID: 11070
		[Token(Token = "0x4002B3E")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[EventRef]
		private string _replaceBatteryAudioEvent;

		// Token: 0x04002B3F RID: 11071
		[Token(Token = "0x4002B3F")]
		[FieldOffset(Offset = "0x80")]
		private float _powerDrainRate;

		// Token: 0x04002B40 RID: 11072
		[Token(Token = "0x4002B40")]
		[FieldOffset(Offset = "0x88")]
		private VolumeContainerItemInstanceModule _powerCapacity;

		// Token: 0x04002B41 RID: 11073
		[Token(Token = "0x4002B41")]
		[FieldOffset(Offset = "0x90")]
		private NightVisionGoggles _nightVisionGogglesHookup;
	}
}
