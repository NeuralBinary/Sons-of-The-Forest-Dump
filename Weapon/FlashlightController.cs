using System;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Ai.Vail.StimuliTypes;
using Sons.Animation;
using Sons.Inventory;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

namespace Sons.Weapon
{
	// Token: 0x02000840 RID: 2112
	[Token(Token = "0x2000840")]
	[AddComponentMenu("Sons/Items/FlashlightController")]
	public class FlashlightController : HeldControllerBase, IItemInstanceModuleConsumer
	{
		// Token: 0x06003854 RID: 14420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003854")]
		[Address(RVA = "0x2EC7A80", Offset = "0x2EC6A80", VA = "0x182EC7A80", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, int itemId)
		{
		}

		// Token: 0x06003855 RID: 14421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003855")]
		[Address(RVA = "0x2EC7EA0", Offset = "0x2EC6EA0", VA = "0x182EC7EA0", Slot = "10")]
		public void ModuleRefreshed(ItemInstanceModule module)
		{
		}

		// Token: 0x06003856 RID: 14422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003856")]
		[Address(RVA = "0x2EC8000", Offset = "0x2EC7000", VA = "0x182EC8000", Slot = "11")]
		protected virtual void OnDisable()
		{
		}

		// Token: 0x06003857 RID: 14423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003857")]
		[Address(RVA = "0x2EC7F70", Offset = "0x2EC6F70", VA = "0x182EC7F70", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06003858 RID: 14424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003858")]
		[Address(RVA = "0x2EC8520", Offset = "0x2EC7520", VA = "0x182EC8520")]
		private void StartHandIK()
		{
		}

		// Token: 0x06003859 RID: 14425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003859")]
		[Address(RVA = "0x2EC8530", Offset = "0x2EC7530", VA = "0x182EC8530")]
		private void StopHandIk()
		{
		}

		// Token: 0x0600385A RID: 14426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600385A")]
		[Address(RVA = "0x2EC8090", Offset = "0x2EC7090", VA = "0x182EC8090")]
		private void SetLeftHandIkActive(bool active)
		{
		}

		// Token: 0x0600385B RID: 14427 RVA: 0x000107B8 File Offset: 0x0000E9B8
		[Token(Token = "0x600385B")]
		[Address(RVA = "0x2EC83D0", Offset = "0x2EC73D0", VA = "0x182EC83D0")]
		private bool ShouldUseIK()
		{
			return default(bool);
		}

		// Token: 0x0600385C RID: 14428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600385C")]
		[Address(RVA = "0x2EC85F0", Offset = "0x2EC75F0", VA = "0x182EC85F0")]
		private void Update()
		{
		}

		// Token: 0x0600385D RID: 14429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600385D")]
		[Address(RVA = "0x2EC8540", Offset = "0x2EC7540", VA = "0x182EC8540")]
		private void UpdateLightStimuli(bool lightActive, float lightStrength)
		{
		}

		// Token: 0x0600385E RID: 14430 RVA: 0x000107D0 File Offset: 0x0000E9D0
		[Token(Token = "0x600385E")]
		[Address(RVA = "0x2EC7D20", Offset = "0x2EC6D20", VA = "0x182EC7D20", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x0600385F RID: 14431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600385F")]
		[Address(RVA = "0x2EC8AD0", Offset = "0x2EC7AD0", VA = "0x182EC8AD0")]
		public FlashlightController()
		{
		}

		// Token: 0x04003016 RID: 12310
		[Token(Token = "0x4003016")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float _fullChargeDurationMinutes;

		// Token: 0x04003017 RID: 12311
		[Token(Token = "0x4003017")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private float _remainingChargeDimmingThreshold;

		// Token: 0x04003018 RID: 12312
		[Token(Token = "0x4003018")]
		[FieldOffset(Offset = "0x78")]
		[Range(0f, 1f)]
		private float _remainingPower;

		// Token: 0x04003019 RID: 12313
		[Token(Token = "0x4003019")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private BatteryIndicator _batteryIndicator;

		// Token: 0x0400301A RID: 12314
		[Token(Token = "0x400301A")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private float _autoRefilThreshold;

		// Token: 0x0400301B RID: 12315
		[Token(Token = "0x400301B")]
		[FieldOffset(Offset = "0x90")]
		[EventRef]
		[SerializeField]
		private string _replaceBatteryAudioEvent;

		// Token: 0x0400301C RID: 12316
		[Token(Token = "0x400301C")]
		[FieldOffset(Offset = "0x98")]
		[Range(0f, 1f)]
		[SerializeField]
		private float _stimuliIllumination;

		// Token: 0x0400301D RID: 12317
		[Token(Token = "0x400301D")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private LightStimuli _lightStimuli;

		// Token: 0x0400301E RID: 12318
		[Token(Token = "0x400301E")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private float _handIkSmoothDuration;

		// Token: 0x0400301F RID: 12319
		[Token(Token = "0x400301F")]
		[FieldOffset(Offset = "0xAC")]
		[SerializeField]
		private Vector3 _handIkPos;

		// Token: 0x04003020 RID: 12320
		[Token(Token = "0x4003020")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Vector3 _handIKPos2;

		// Token: 0x04003021 RID: 12321
		[Token(Token = "0x4003021")]
		[FieldOffset(Offset = "0xC4")]
		[SerializeField]
		private Quaternion _handIkRot;

		// Token: 0x04003022 RID: 12322
		[Token(Token = "0x4003022")]
		[FieldOffset(Offset = "0xD4")]
		[SerializeField]
		private float _handIkWeight;

		// Token: 0x04003023 RID: 12323
		[Token(Token = "0x4003023")]
		[FieldOffset(Offset = "0xD8")]
		private VolumeContainerItemInstanceModule _powerCapacity;

		// Token: 0x04003024 RID: 12324
		[Token(Token = "0x4003024")]
		[FieldOffset(Offset = "0xE0")]
		private HDAdditionalLightData _light;

		// Token: 0x04003025 RID: 12325
		[Token(Token = "0x4003025")]
		[FieldOffset(Offset = "0xE8")]
		private float _powerDrainRate;

		// Token: 0x04003026 RID: 12326
		[Token(Token = "0x4003026")]
		[FieldOffset(Offset = "0xEC")]
		private float _maxLightIntensity;

		// Token: 0x04003027 RID: 12327
		[Token(Token = "0x4003027")]
		[FieldOffset(Offset = "0xF0")]
		private AnimatorLayersController _layersController;

		// Token: 0x04003028 RID: 12328
		[Token(Token = "0x4003028")]
		[FieldOffset(Offset = "0xF8")]
		private LayerBehaviourActivator _leftArmLayerBehaviourActivator;

		// Token: 0x04003029 RID: 12329
		[Token(Token = "0x4003029")]
		[FieldOffset(Offset = "0x100")]
		private bool _ikActive;
	}
}
