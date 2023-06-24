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
	// Token: 0x020008B0 RID: 2224
	[Token(Token = "0x20008B0")]
	[AddComponentMenu("Sons/Items/FlashlightController")]
	public class FlashlightController : HeldControllerBase, IItemInstanceModuleConsumer
	{
		// Token: 0x06003F69 RID: 16233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F69")]
		[Address(RVA = "0x35E4520", Offset = "0x35E2B20", VA = "0x1835E4520", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, ItemInstance itemInstance)
		{
		}

		// Token: 0x06003F6A RID: 16234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F6A")]
		[Address(RVA = "0x35E4AC0", Offset = "0x35E30C0", VA = "0x1835E4AC0", Slot = "10")]
		public void ModuleRefreshed(ItemInstanceModule module)
		{
		}

		// Token: 0x06003F6B RID: 16235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F6B")]
		[Address(RVA = "0x35E4BC0", Offset = "0x35E31C0", VA = "0x1835E4BC0", Slot = "11")]
		protected virtual void OnDisable()
		{
		}

		// Token: 0x06003F6C RID: 16236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F6C")]
		[Address(RVA = "0x35E4BF0", Offset = "0x35E31F0", VA = "0x1835E4BF0", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06003F6D RID: 16237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F6D")]
		[Address(RVA = "0x35E4CE0", Offset = "0x35E32E0", VA = "0x1835E4CE0")]
		private void StartHandIK()
		{
		}

		// Token: 0x06003F6E RID: 16238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F6E")]
		[Address(RVA = "0x35E4CF0", Offset = "0x35E32F0", VA = "0x1835E4CF0")]
		private void StopHandIk()
		{
		}

		// Token: 0x06003F6F RID: 16239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F6F")]
		[Address(RVA = "0x35E4D00", Offset = "0x35E3300", VA = "0x1835E4D00")]
		private void SetLeftHandIkActive(bool active)
		{
		}

		// Token: 0x06003F70 RID: 16240 RVA: 0x00013560 File Offset: 0x00011760
		[Token(Token = "0x6003F70")]
		[Address(RVA = "0x35E5040", Offset = "0x35E3640", VA = "0x1835E5040")]
		private bool ShouldUseIK()
		{
			return default(bool);
		}

		// Token: 0x06003F71 RID: 16241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F71")]
		[Address(RVA = "0x35E51D0", Offset = "0x35E37D0", VA = "0x1835E51D0")]
		private void Update()
		{
		}

		// Token: 0x06003F72 RID: 16242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F72")]
		[Address(RVA = "0x35E5740", Offset = "0x35E3D40", VA = "0x1835E5740")]
		private void UpdateLightStimuli(bool lightActive, float lightStrength)
		{
		}

		// Token: 0x06003F73 RID: 16243 RVA: 0x00013578 File Offset: 0x00011778
		[Token(Token = "0x6003F73")]
		[Address(RVA = "0x35E5840", Offset = "0x35E3E40", VA = "0x1835E5840", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x06003F74 RID: 16244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F74")]
		[Address(RVA = "0x35E59F0", Offset = "0x35E3FF0", VA = "0x1835E59F0")]
		public FlashlightController()
		{
		}

		// Token: 0x040034DC RID: 13532
		[Token(Token = "0x40034DC")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _fullChargeDurationMinutes;

		// Token: 0x040034DD RID: 13533
		[Token(Token = "0x40034DD")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float _remainingChargeDimmingThreshold;

		// Token: 0x040034DE RID: 13534
		[Token(Token = "0x40034DE")]
		[FieldOffset(Offset = "0x70")]
		[Range(0f, 1f)]
		private float _remainingPower;

		// Token: 0x040034DF RID: 13535
		[Token(Token = "0x40034DF")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private BatteryIndicator _batteryIndicator;

		// Token: 0x040034E0 RID: 13536
		[Token(Token = "0x40034E0")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private float _autoRefilThreshold;

		// Token: 0x040034E1 RID: 13537
		[Token(Token = "0x40034E1")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[EventRef]
		private string _replaceBatteryAudioEvent;

		// Token: 0x040034E2 RID: 13538
		[Token(Token = "0x40034E2")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _stimuliIllumination;

		// Token: 0x040034E3 RID: 13539
		[Token(Token = "0x40034E3")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private LightStimuli _lightStimuli;

		// Token: 0x040034E4 RID: 13540
		[Token(Token = "0x40034E4")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private float _handIkSmoothDuration;

		// Token: 0x040034E5 RID: 13541
		[Token(Token = "0x40034E5")]
		[FieldOffset(Offset = "0xA4")]
		[SerializeField]
		private Vector3 _handIkPos;

		// Token: 0x040034E6 RID: 13542
		[Token(Token = "0x40034E6")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Vector3 _handIKPos2;

		// Token: 0x040034E7 RID: 13543
		[Token(Token = "0x40034E7")]
		[FieldOffset(Offset = "0xBC")]
		[SerializeField]
		private Quaternion _handIkRot;

		// Token: 0x040034E8 RID: 13544
		[Token(Token = "0x40034E8")]
		[FieldOffset(Offset = "0xCC")]
		[SerializeField]
		private float _handIkWeight;

		// Token: 0x040034E9 RID: 13545
		[Token(Token = "0x40034E9")]
		[FieldOffset(Offset = "0xD0")]
		private VolumeContainerItemInstanceModule _powerCapacity;

		// Token: 0x040034EA RID: 13546
		[Token(Token = "0x40034EA")]
		[FieldOffset(Offset = "0xD8")]
		private HDAdditionalLightData _light;

		// Token: 0x040034EB RID: 13547
		[Token(Token = "0x40034EB")]
		[FieldOffset(Offset = "0xE0")]
		private float _powerDrainRate;

		// Token: 0x040034EC RID: 13548
		[Token(Token = "0x40034EC")]
		[FieldOffset(Offset = "0xE4")]
		private float _maxLightIntensity;

		// Token: 0x040034ED RID: 13549
		[Token(Token = "0x40034ED")]
		[FieldOffset(Offset = "0xE8")]
		private AnimatorLayersController _layersController;

		// Token: 0x040034EE RID: 13550
		[Token(Token = "0x40034EE")]
		[FieldOffset(Offset = "0xF0")]
		private LayerBehaviourActivator _leftArmLayerBehaviourActivator;

		// Token: 0x040034EF RID: 13551
		[Token(Token = "0x40034EF")]
		[FieldOffset(Offset = "0xF8")]
		private bool _ikActive;
	}
}
