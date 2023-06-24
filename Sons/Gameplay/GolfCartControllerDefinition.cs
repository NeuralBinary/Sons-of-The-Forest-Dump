using System;
using FMODUnity;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Gameplay
{
	// Token: 0x0200080D RID: 2061
	[Token(Token = "0x200080D")]
	[CreateAssetMenu(fileName = "GolfCartControllerDefinition", menuName = "Sons/GolfCartControllerDefinition")]
	public class GolfCartControllerDefinition : ScriptableObject
	{
		// Token: 0x06003822 RID: 14370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003822")]
		[Address(RVA = "0x354FAF0", Offset = "0x354E0F0", VA = "0x18354FAF0")]
		public void ApplyWheelLerp(WheelCollider targetCollider, WheelCollider baseProfile, WheelCollider highSpeedProfile, float factor)
		{
		}

		// Token: 0x06003823 RID: 14371 RVA: 0x00010BD8 File Offset: 0x0000EDD8
		[Token(Token = "0x6003823")]
		[Address(RVA = "0x3550900", Offset = "0x354EF00", VA = "0x183550900")]
		private WheelFrictionCurve Lerp(WheelFrictionCurve baseProfileForwardFriction, WheelFrictionCurve forwardFriction, float factor)
		{
			return default(WheelFrictionCurve);
		}

		// Token: 0x06003824 RID: 14372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003824")]
		[Address(RVA = "0x3550A20", Offset = "0x354F020", VA = "0x183550A20")]
		public GolfCartControllerDefinition()
		{
		}

		// Token: 0x0400305B RID: 12379
		[Token(Token = "0x400305B")]
		public const int SteeringWheelNetworkArrayIndex = 0;

		// Token: 0x0400305C RID: 12380
		[Token(Token = "0x400305C")]
		public const int FrontLeftWheelArrayIndex = 1;

		// Token: 0x0400305D RID: 12381
		[Token(Token = "0x400305D")]
		public const int FrontRightWheelArrayIndex = 2;

		// Token: 0x0400305E RID: 12382
		[Token(Token = "0x400305E")]
		public const int RearLeftWheelArrayIndex = 3;

		// Token: 0x0400305F RID: 12383
		[Token(Token = "0x400305F")]
		public const int RearRightWheelArrayIndex = 4;

		// Token: 0x04003060 RID: 12384
		[Token(Token = "0x4003060")]
		[FieldOffset(Offset = "0x18")]
		[FormerlySerializedAs("TorqueCurveMultiplierX")]
		public float TorqueCurveMultiplier;

		// Token: 0x04003061 RID: 12385
		[Token(Token = "0x4003061")]
		[FieldOffset(Offset = "0x1C")]
		public float TorqueCurveBoostMultiplier;

		// Token: 0x04003062 RID: 12386
		[Token(Token = "0x4003062")]
		[FieldOffset(Offset = "0x20")]
		[FormerlySerializedAs("MaxBreakTorque")]
		[FormerlySerializedAs("MaxStoppingForce")]
		public float MaxBrakeTorque;

		// Token: 0x04003063 RID: 12387
		[Token(Token = "0x4003063")]
		[FieldOffset(Offset = "0x24")]
		public float HandBrakeTorque;

		// Token: 0x04003064 RID: 12388
		[Token(Token = "0x4003064")]
		[FieldOffset(Offset = "0x28")]
		public float AccelerationBrakeTorque;

		// Token: 0x04003065 RID: 12389
		[Token(Token = "0x4003065")]
		[FieldOffset(Offset = "0x2C")]
		public float IdleBrakeTorqueFactor;

		// Token: 0x04003066 RID: 12390
		[Token(Token = "0x4003066")]
		[FieldOffset(Offset = "0x30")]
		public float IdleBrakeSpeed;

		// Token: 0x04003067 RID: 12391
		[Token(Token = "0x4003067")]
		[FieldOffset(Offset = "0x34")]
		[FormerlySerializedAs("SteeringWheelRotationMultiplier")]
		public float SteeringWheelRotationMax;

		// Token: 0x04003068 RID: 12392
		[Token(Token = "0x4003068")]
		[FieldOffset(Offset = "0x38")]
		public float SteeringSmoothTime;

		// Token: 0x04003069 RID: 12393
		[Token(Token = "0x4003069")]
		[FieldOffset(Offset = "0x3C")]
		public float CenterSteeringSmoothTime;

		// Token: 0x0400306A RID: 12394
		[Token(Token = "0x400306A")]
		[FieldOffset(Offset = "0x40")]
		public float SteeringMaxSpeed;

		// Token: 0x0400306B RID: 12395
		[Token(Token = "0x400306B")]
		[FieldOffset(Offset = "0x44")]
		public float SteeringMaxAngle;

		// Token: 0x0400306C RID: 12396
		[Token(Token = "0x400306C")]
		[FieldOffset(Offset = "0x48")]
		public float AccelerationSmoothTime;

		// Token: 0x0400306D RID: 12397
		[Token(Token = "0x400306D")]
		[FieldOffset(Offset = "0x4C")]
		[FormerlySerializedAs("BreakingSmoothTime")]
		[FormerlySerializedAs("StopAccelerationSmoothTime")]
		public float BrakingSmoothTime;

		// Token: 0x0400306E RID: 12398
		[Token(Token = "0x400306E")]
		[FieldOffset(Offset = "0x50")]
		[FormerlySerializedAs("IdleBakeDelayTime")]
		public float IdleBrakeDelayTime;

		// Token: 0x0400306F RID: 12399
		[Token(Token = "0x400306F")]
		[FieldOffset(Offset = "0x54")]
		[FormerlySerializedAs("IdleBrakingSmoothTime")]
		public float IdleAccelerationSmoothTime;

		// Token: 0x04003070 RID: 12400
		[Token(Token = "0x4003070")]
		[FieldOffset(Offset = "0x58")]
		public float AccelerationMaxSpeed;

		// Token: 0x04003071 RID: 12401
		[Token(Token = "0x4003071")]
		[FieldOffset(Offset = "0x5C")]
		public float DriverIkSmoothDuration;

		// Token: 0x04003072 RID: 12402
		[Token(Token = "0x4003072")]
		[FieldOffset(Offset = "0x60")]
		public float DriverIkConnectDelay;

		// Token: 0x04003073 RID: 12403
		[Token(Token = "0x4003073")]
		[FieldOffset(Offset = "0x64")]
		public float GravityForce;

		// Token: 0x04003074 RID: 12404
		[Token(Token = "0x4003074")]
		[FieldOffset(Offset = "0x68")]
		public AnimationCurve TorqueCurve;

		// Token: 0x04003075 RID: 12405
		[Token(Token = "0x4003075")]
		[FieldOffset(Offset = "0x70")]
		[FormerlySerializedAs("TurboTorqueCurve")]
		public AnimationCurve BoostTorqueCurve;

		// Token: 0x04003076 RID: 12406
		[Token(Token = "0x4003076")]
		[FieldOffset(Offset = "0x78")]
		public float WheelProfileBaseSpeed;

		// Token: 0x04003077 RID: 12407
		[Token(Token = "0x4003077")]
		[FieldOffset(Offset = "0x7C")]
		public float WheelProfileHighSpeed;

		// Token: 0x04003078 RID: 12408
		[Token(Token = "0x4003078")]
		[FieldOffset(Offset = "0x80")]
		public WheelCollider FrontWheelBaseProfile;

		// Token: 0x04003079 RID: 12409
		[Token(Token = "0x4003079")]
		[FieldOffset(Offset = "0x88")]
		public WheelCollider RearWheelBaseProfile;

		// Token: 0x0400307A RID: 12410
		[Token(Token = "0x400307A")]
		[FieldOffset(Offset = "0x90")]
		public WheelCollider FrontWheelHighSpeedProfile;

		// Token: 0x0400307B RID: 12411
		[Token(Token = "0x400307B")]
		[FieldOffset(Offset = "0x98")]
		public WheelCollider RearWheelHighSpeedProfile;

		// Token: 0x0400307C RID: 12412
		[Token(Token = "0x400307C")]
		[FieldOffset(Offset = "0xA0")]
		public WheelCollider FrontWheelDeepWaterProfile;

		// Token: 0x0400307D RID: 12413
		[Token(Token = "0x400307D")]
		[FieldOffset(Offset = "0xA8")]
		public WheelCollider RearWheelDeepWaterProfile;

		// Token: 0x0400307E RID: 12414
		[Token(Token = "0x400307E")]
		[FieldOffset(Offset = "0xB0")]
		public float BushBreakerMinSpeed;

		// Token: 0x0400307F RID: 12415
		[Token(Token = "0x400307F")]
		[FieldOffset(Offset = "0xB4")]
		public float KnockdownDamageMinSpeed;

		// Token: 0x04003080 RID: 12416
		[Token(Token = "0x4003080")]
		[FieldOffset(Offset = "0xB8")]
		public float ShoveCooldownTimer;

		// Token: 0x04003081 RID: 12417
		[Token(Token = "0x4003081")]
		[FieldOffset(Offset = "0xBC")]
		public float ShoveForce;

		// Token: 0x04003082 RID: 12418
		[Token(Token = "0x4003082")]
		[FieldOffset(Offset = "0xC0")]
		public float ShoveUpForce;

		// Token: 0x04003083 RID: 12419
		[Token(Token = "0x4003083")]
		[FieldOffset(Offset = "0xC4")]
		public float ShoveTorque;

		// Token: 0x04003084 RID: 12420
		[Token(Token = "0x4003084")]
		[FieldOffset(Offset = "0xC8")]
		public float ShoveAccelerationFactor;

		// Token: 0x04003085 RID: 12421
		[Token(Token = "0x4003085")]
		[FieldOffset(Offset = "0xCC")]
		public float AudioAccelerationMin;

		// Token: 0x04003086 RID: 12422
		[Token(Token = "0x4003086")]
		[FieldOffset(Offset = "0xD0")]
		public float AudioAccelerationMax;

		// Token: 0x04003087 RID: 12423
		[Token(Token = "0x4003087")]
		[FieldOffset(Offset = "0xD4")]
		public float AudioBrakingMin;

		// Token: 0x04003088 RID: 12424
		[Token(Token = "0x4003088")]
		[FieldOffset(Offset = "0xD8")]
		public float AudioBrakingMax;

		// Token: 0x04003089 RID: 12425
		[Token(Token = "0x4003089")]
		[FieldOffset(Offset = "0xDC")]
		public float AudioSpeedMin;

		// Token: 0x0400308A RID: 12426
		[Token(Token = "0x400308A")]
		[FieldOffset(Offset = "0xE0")]
		public float AudioSpeedMax;

		// Token: 0x0400308B RID: 12427
		[Token(Token = "0x400308B")]
		[FieldOffset(Offset = "0xE8")]
		[EventRef]
		public string AudioEngineEvent;

		// Token: 0x0400308C RID: 12428
		[Token(Token = "0x400308C")]
		[FieldOffset(Offset = "0xF0")]
		[EventRef]
		public string AudioWheelEvent;

		// Token: 0x0400308D RID: 12429
		[Token(Token = "0x400308D")]
		[FieldOffset(Offset = "0xF8")]
		[EventRef]
		public string AudioBeepEvent;

		// Token: 0x0400308E RID: 12430
		[Token(Token = "0x400308E")]
		[FieldOffset(Offset = "0x100")]
		public float AudioBeepMinTime;

		// Token: 0x0400308F RID: 12431
		[Token(Token = "0x400308F")]
		[FieldOffset(Offset = "0x108")]
		public string GolfCartRpmParamString;

		// Token: 0x04003090 RID: 12432
		[Token(Token = "0x4003090")]
		[FieldOffset(Offset = "0x110")]
		public string TractionParamString;

		// Token: 0x04003091 RID: 12433
		[Token(Token = "0x4003091")]
		[FieldOffset(Offset = "0x118")]
		public string AudioAccelerationParamString;

		// Token: 0x04003092 RID: 12434
		[Token(Token = "0x4003092")]
		[FieldOffset(Offset = "0x120")]
		public string AudioEngineLoadParamString;

		// Token: 0x04003093 RID: 12435
		[Token(Token = "0x4003093")]
		[FieldOffset(Offset = "0x128")]
		public string AudioTerrainParamString;

		// Token: 0x04003094 RID: 12436
		[Token(Token = "0x4003094")]
		[FieldOffset(Offset = "0x130")]
		public float EngineLoadRpmThreshold;

		// Token: 0x04003095 RID: 12437
		[Token(Token = "0x4003095")]
		[FieldOffset(Offset = "0x134")]
		[SerializeField]
		public float WheelAudioWaterLevel;

		// Token: 0x04003096 RID: 12438
		[Token(Token = "0x4003096")]
		[FieldOffset(Offset = "0x138")]
		public float DeepWaterLevel;

		// Token: 0x04003097 RID: 12439
		[Token(Token = "0x4003097")]
		[FieldOffset(Offset = "0x13C")]
		[SerializeField]
		public float MaxPower;

		// Token: 0x04003098 RID: 12440
		[Token(Token = "0x4003098")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		public float MinPowerUsage;

		// Token: 0x04003099 RID: 12441
		[Token(Token = "0x4003099")]
		[FieldOffset(Offset = "0x144")]
		[SerializeField]
		public float MaxPowerUsage;

		// Token: 0x0400309A RID: 12442
		[Token(Token = "0x400309A")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		public float SolarRechargeMultiplier;

		// Token: 0x0400309B RID: 12443
		[Token(Token = "0x400309B")]
		[FieldOffset(Offset = "0x14C")]
		[SerializeField]
		public float SolarRechargeMax;

		// Token: 0x0400309C RID: 12444
		[Token(Token = "0x400309C")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		public float SolarRechargeMin;
	}
}
