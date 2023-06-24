using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Bolt;
using Endnight.Animation;
using Endnight.Utilities.Timer;
using FMOD.Studio;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.Atmosphere;
using Sons.Environment;
using Sons.Gameplay.Swimming;
using Sons.Inventory;
using Sons.Multiplayer;
using Sons.Physics;
using Sons.Utils;
using TheForest.Utils;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Gameplay
{
	// Token: 0x0200080B RID: 2059
	[Token(Token = "0x200080B")]
	public class GolfCartController : BoltEntityListenerBehaviourWrapper<IGolfCartState>, IPriorityCalculator, ILastUpdateProxyReceiver, ICloudReceiver, ITimeOfDayReceiver
	{
		// Token: 0x0600377D RID: 14205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600377D")]
		[Address(RVA = "0x3540290", Offset = "0x353E890", VA = "0x183540290")]
		private void UpdateAudio()
		{
		}

		// Token: 0x0600377E RID: 14206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600377E")]
		[Address(RVA = "0x3540660", Offset = "0x353EC60", VA = "0x183540660")]
		private void UpdateAudioFromTerrain()
		{
		}

		// Token: 0x0600377F RID: 14207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600377F")]
		[Address(RVA = "0x3540820", Offset = "0x353EE20", VA = "0x183540820")]
		private void UpdateReverseBeeping()
		{
		}

		// Token: 0x06003780 RID: 14208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003780")]
		[Address(RVA = "0x3540AB0", Offset = "0x353F0B0", VA = "0x183540AB0")]
		private void UpdateEngineAudioEvents()
		{
		}

		// Token: 0x06003781 RID: 14209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003781")]
		[Address(RVA = "0x3540C30", Offset = "0x353F230", VA = "0x183540C30")]
		private void UpdateWheelAudioEvents()
		{
		}

		// Token: 0x06003782 RID: 14210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003782")]
		[Address(RVA = "0x3540E80", Offset = "0x353F480", VA = "0x183540E80")]
		private void ApplyWheelEvent(int wheelArrayIndex, float wheelRpm, int terrainAudioType, Transform transformSource, float wheelTraction)
		{
		}

		// Token: 0x06003783 RID: 14211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003783")]
		[Address(RVA = "0x3541130", Offset = "0x353F730", VA = "0x183541130")]
		private void SetupEventAndSetState(string eventPath, ref EventInstance eventInstance, bool playEventValue)
		{
		}

		// Token: 0x06003784 RID: 14212 RVA: 0x00010830 File Offset: 0x0000EA30
		[Token(Token = "0x6003784")]
		[Address(RVA = "0x35412D0", Offset = "0x353F8D0", VA = "0x1835412D0")]
		private bool InitializeAudioEvent(ref EventInstance eventInstance, string eventPath)
		{
			return default(bool);
		}

		// Token: 0x06003785 RID: 14213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003785")]
		[Address(RVA = "0x3541380", Offset = "0x353F980", VA = "0x183541380")]
		private void UpdateAudioFromRpm()
		{
		}

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x06003786 RID: 14214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006D7")]
		public GolfCartControllerDefinition Definition
		{
			[Token(Token = "0x6003786")]
			[Address(RVA = "0x620F10", Offset = "0x61F510", VA = "0x180620F10")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003787 RID: 14215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003787")]
		[Address(RVA = "0x3541690", Offset = "0x353FC90", VA = "0x183541690")]
		private void Start()
		{
		}

		// Token: 0x06003788 RID: 14216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003788")]
		[Address(RVA = "0x35418A0", Offset = "0x353FEA0", VA = "0x1835418A0")]
		private void OnSerialize(WorldItemState obj)
		{
		}

		// Token: 0x06003789 RID: 14217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003789")]
		[Address(RVA = "0x3541A30", Offset = "0x3540030", VA = "0x183541A30")]
		private void OnDeserialize(WorldItemState obj)
		{
		}

		// Token: 0x0600378A RID: 14218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600378A")]
		[Address(RVA = "0x3541AE0", Offset = "0x35400E0", VA = "0x183541AE0")]
		private void FixedUpdate()
		{
		}

		// Token: 0x0600378B RID: 14219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600378B")]
		[Address(RVA = "0x3541F60", Offset = "0x3540560", VA = "0x183541F60")]
		private void LateUpdate()
		{
		}

		// Token: 0x0600378C RID: 14220 RVA: 0x00010848 File Offset: 0x0000EA48
		[Token(Token = "0x600378C")]
		[Address(RVA = "0x3542590", Offset = "0x3540B90", VA = "0x183542590")]
		private bool ActivatedOrActiveSlot()
		{
			return default(bool);
		}

		// Token: 0x0600378D RID: 14221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600378D")]
		[Address(RVA = "0x35425D0", Offset = "0x3540BD0", VA = "0x1835425D0")]
		private void UpdateInteractionObjects()
		{
		}

		// Token: 0x0600378E RID: 14222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600378E")]
		[Address(RVA = "0x3542900", Offset = "0x3540F00", VA = "0x183542900")]
		private void OnEnable()
		{
		}

		// Token: 0x0600378F RID: 14223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600378F")]
		[Address(RVA = "0x3542A80", Offset = "0x3541080", VA = "0x183542A80")]
		private void OnDisable()
		{
		}

		// Token: 0x06003790 RID: 14224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003790")]
		[Address(RVA = "0x3542BD0", Offset = "0x35411D0", VA = "0x183542BD0")]
		private void OnValidate()
		{
		}

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x06003791 RID: 14225 RVA: 0x00010860 File Offset: 0x0000EA60
		[Token(Token = "0x170006D8")]
		public int LastUpdatePriority
		{
			[Token(Token = "0x6003791")]
			[Address(RVA = "0x6C1D40", Offset = "0x6C0340", VA = "0x1806C1D40", Slot = "326")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x06003792 RID: 14226 RVA: 0x00010878 File Offset: 0x0000EA78
		[Token(Token = "0x170006D9")]
		public bool IsInDeepWater
		{
			[Token(Token = "0x6003792")]
			[Address(RVA = "0x3542FE0", Offset = "0x35415E0", VA = "0x183542FE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003793 RID: 14227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003793")]
		[Address(RVA = "0x3542FF0", Offset = "0x35415F0", VA = "0x183542FF0", Slot = "325")]
		public void LastUpdate()
		{
		}

		// Token: 0x06003794 RID: 14228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003794")]
		[Address(RVA = "0x3543330", Offset = "0x3541930", VA = "0x183543330")]
		private void CheckPlayersDisconnected()
		{
		}

		// Token: 0x06003795 RID: 14229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003795")]
		[Address(RVA = "0x35434B0", Offset = "0x3541AB0", VA = "0x1835434B0")]
		private void SetToKinematic(bool shouldBeKinematic)
		{
		}

		// Token: 0x06003796 RID: 14230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003796")]
		[Address(RVA = "0x3543680", Offset = "0x3541C80", VA = "0x183543680")]
		private void ToggleWithKinematic(bool toggleValue, List<UnityEngine.Object> targetList)
		{
		}

		// Token: 0x06003797 RID: 14231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003797")]
		[Address(RVA = "0x35437E0", Offset = "0x3541DE0", VA = "0x1835437E0")]
		private static void ToggleWithKinematic(bool toggleValue, UnityEngine.Object eachItem)
		{
		}

		// Token: 0x06003798 RID: 14232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003798")]
		[Address(RVA = "0x3543A40", Offset = "0x3542040", VA = "0x183543A40")]
		private void EnableShoveInteractions(bool force = false)
		{
		}

		// Token: 0x06003799 RID: 14233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003799")]
		[Address(RVA = "0x3543D00", Offset = "0x3542300", VA = "0x183543D00")]
		private void DisableShoveInteractions()
		{
		}

		// Token: 0x0600379A RID: 14234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600379A")]
		[Address(RVA = "0x3543F80", Offset = "0x3542580", VA = "0x183543F80")]
		private void OnShovedInteraction()
		{
		}

		// Token: 0x0600379B RID: 14235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600379B")]
		[Address(RVA = "0x35441C0", Offset = "0x35427C0", VA = "0x1835441C0")]
		private void TriggerShove(Vector3 sourceForward)
		{
		}

		// Token: 0x0600379C RID: 14236 RVA: 0x00010890 File Offset: 0x0000EA90
		[Token(Token = "0x600379C")]
		[Address(RVA = "0x35449E0", Offset = "0x3542FE0", VA = "0x1835449E0")]
		private bool IsInShoveCooldown()
		{
			return default(bool);
		}

		// Token: 0x0600379D RID: 14237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600379D")]
		[Address(RVA = "0x3544A00", Offset = "0x3543000", VA = "0x183544A00")]
		private void StartShoveCooldown()
		{
		}

		// Token: 0x0600379E RID: 14238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600379E")]
		[Address(RVA = "0x3544B50", Offset = "0x3543150", VA = "0x183544B50")]
		private void OnDriverInteraction()
		{
		}

		// Token: 0x0600379F RID: 14239 RVA: 0x000108A8 File Offset: 0x0000EAA8
		[Token(Token = "0x600379F")]
		[Address(RVA = "0x3544E10", Offset = "0x3543410", VA = "0x183544E10")]
		private bool HasLocalConnectedDriver()
		{
			return default(bool);
		}

		// Token: 0x060037A0 RID: 14240 RVA: 0x000108C0 File Offset: 0x0000EAC0
		[Token(Token = "0x60037A0")]
		[Address(RVA = "0x3544E20", Offset = "0x3543420", VA = "0x183544E20")]
		private bool HasLocalConnectedPassengerA()
		{
			return default(bool);
		}

		// Token: 0x060037A1 RID: 14241 RVA: 0x000108D8 File Offset: 0x0000EAD8
		[Token(Token = "0x60037A1")]
		[Address(RVA = "0x3544E30", Offset = "0x3543430", VA = "0x183544E30")]
		private bool HasConnectedDriver()
		{
			return default(bool);
		}

		// Token: 0x060037A2 RID: 14242 RVA: 0x000108F0 File Offset: 0x0000EAF0
		[Token(Token = "0x60037A2")]
		[Address(RVA = "0x3544E50", Offset = "0x3543450", VA = "0x183544E50")]
		private bool HasConnectedPassengerA()
		{
			return default(bool);
		}

		// Token: 0x060037A3 RID: 14243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037A3")]
		[Address(RVA = "0x3544F30", Offset = "0x3543530", VA = "0x183544F30")]
		private void OnPassengerAInteraction()
		{
		}

		// Token: 0x060037A4 RID: 14244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037A4")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void TryConnectDriverInitialize()
		{
		}

		// Token: 0x060037A5 RID: 14245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037A5")]
		[Address(RVA = "0x35451A0", Offset = "0x35437A0", VA = "0x1835451A0")]
		public void GetWheelRpms(out float frontLeftWheelRpm, out float frontRightWheelRpm, out float rearLeftWheelRpm, out float rearRightWheelRpm)
		{
		}

		// Token: 0x060037A6 RID: 14246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037A6")]
		[Address(RVA = "0x3545320", Offset = "0x3543920", VA = "0x183545320")]
		private void ApplyForces(float accelerationFactor, float targetWheelSteerAngle, float brakeTorque, bool handBrake)
		{
		}

		// Token: 0x060037A7 RID: 14247 RVA: 0x00010908 File Offset: 0x0000EB08
		[Token(Token = "0x60037A7")]
		[Address(RVA = "0x3545AC0", Offset = "0x35440C0", VA = "0x183545AC0")]
		private float CalculateEngineLoad()
		{
			return 0f;
		}

		// Token: 0x060037A8 RID: 14248 RVA: 0x00010920 File Offset: 0x0000EB20
		[Token(Token = "0x60037A8")]
		[Address(RVA = "0x3545B40", Offset = "0x3544140", VA = "0x183545B40")]
		private float GetMinAbsWheelRpm()
		{
			return 0f;
		}

		// Token: 0x060037A9 RID: 14249 RVA: 0x00010938 File Offset: 0x0000EB38
		[Token(Token = "0x60037A9")]
		[Address(RVA = "0x3545B70", Offset = "0x3544170", VA = "0x183545B70")]
		private float CheckAccelerationBrakeForce(float accelerationFactor, float wheelRpm, out bool rollingAgainstAcceleration)
		{
			return 0f;
		}

		// Token: 0x060037AA RID: 14250 RVA: 0x00010950 File Offset: 0x0000EB50
		[Token(Token = "0x60037AA")]
		[Address(RVA = "0x3545BA0", Offset = "0x35441A0", VA = "0x183545BA0")]
		private float CalculateWheelTraction(WheelCollider wheelCollider)
		{
			return 0f;
		}

		// Token: 0x060037AB RID: 14251 RVA: 0x00010968 File Offset: 0x0000EB68
		[Token(Token = "0x60037AB")]
		[Address(RVA = "0x3545E70", Offset = "0x3544470", VA = "0x183545E70")]
		private float CalculateTractionToVelocityRatio(Vector3 wheelSurfaceVelocity, Vector3 bodyVelocity)
		{
			return 0f;
		}

		// Token: 0x060037AC RID: 14252 RVA: 0x00010980 File Offset: 0x0000EB80
		[Token(Token = "0x60037AC")]
		[Address(RVA = "0x3545F60", Offset = "0x3544560", VA = "0x183545F60")]
		private static Vector3 CalculateSurfaceVelocity(float rpm, float radius, Vector3 wheelForward)
		{
			return default(Vector3);
		}

		// Token: 0x060037AD RID: 14253 RVA: 0x00010998 File Offset: 0x0000EB98
		[Token(Token = "0x60037AD")]
		[Address(RVA = "0x3545FC0", Offset = "0x35445C0", VA = "0x183545FC0")]
		private float GetMaxWheelRpm()
		{
			return 0f;
		}

		// Token: 0x060037AE RID: 14254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037AE")]
		[Address(RVA = "0x3545FF0", Offset = "0x35445F0", VA = "0x183545FF0")]
		private void ApplyForces(WheelCollider targetWheel, float targetWheelMotorTorque, float targetWheelSteerAngle, float brakeTorque)
		{
		}

		// Token: 0x060037AF RID: 14255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037AF")]
		[Address(RVA = "0x3546100", Offset = "0x3544700", VA = "0x183546100")]
		private void UpdateInWater()
		{
		}

		// Token: 0x060037B0 RID: 14256 RVA: 0x000109B0 File Offset: 0x0000EBB0
		[Token(Token = "0x60037B0")]
		[Address(RVA = "0x3546160", Offset = "0x3544760", VA = "0x183546160")]
		private bool GetIsInDeepWater()
		{
			return default(bool);
		}

		// Token: 0x060037B1 RID: 14257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037B1")]
		[Address(RVA = "0x3546580", Offset = "0x3544B80", VA = "0x183546580")]
		private void ActivateWaterLevelSensor(WaterLevelSensor waterLevelSensor)
		{
		}

		// Token: 0x060037B2 RID: 14258 RVA: 0x000109C8 File Offset: 0x0000EBC8
		[Token(Token = "0x60037B2")]
		[Address(RVA = "0x3546890", Offset = "0x3544E90", VA = "0x183546890")]
		private bool GetIsInDeepWaterFromSensor(WaterLevelSensor waterLevelSensor)
		{
			return default(bool);
		}

		// Token: 0x060037B3 RID: 14259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037B3")]
		[Address(RVA = "0x3546990", Offset = "0x3544F90", VA = "0x183546990")]
		private void UpdateBushBreaker(float velocitySqrMagnitude)
		{
		}

		// Token: 0x060037B4 RID: 14260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037B4")]
		[Address(RVA = "0x3546A50", Offset = "0x3545050", VA = "0x183546A50")]
		private void UpdateSmallDamage(float velocitySqrMagnitude)
		{
		}

		// Token: 0x060037B5 RID: 14261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037B5")]
		[Address(RVA = "0x3546B70", Offset = "0x3545170", VA = "0x183546B70")]
		private void UpdateKnockdownDamage(float velocitySqrMagnitude)
		{
		}

		// Token: 0x060037B6 RID: 14262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037B6")]
		[Address(RVA = "0x3546C90", Offset = "0x3545290", VA = "0x183546C90")]
		private void UpdateWheelProfiles(float velocitySqrMagnitude)
		{
		}

		// Token: 0x060037B7 RID: 14263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037B7")]
		[Address(RVA = "0x3546E10", Offset = "0x3545410", VA = "0x183546E10")]
		private void UpdateSteeringFactor()
		{
		}

		// Token: 0x060037B8 RID: 14264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037B8")]
		[Address(RVA = "0x3546EE0", Offset = "0x35454E0", VA = "0x183546EE0")]
		private void UpdateAccelerationFactor()
		{
		}

		// Token: 0x060037B9 RID: 14265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037B9")]
		[Address(RVA = "0x3547200", Offset = "0x3545800", VA = "0x183547200")]
		private void UpdateLocalDynamicTransforms()
		{
		}

		// Token: 0x060037BA RID: 14266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037BA")]
		[Address(RVA = "0x35475C0", Offset = "0x3545BC0", VA = "0x1835475C0")]
		private void UpdateLocalDynamicTransformsFromGhost()
		{
		}

		// Token: 0x060037BB RID: 14267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037BB")]
		[Address(RVA = "0x3547720", Offset = "0x3545D20", VA = "0x183547720")]
		private void UpdateTransform(Transform source, Transform target)
		{
		}

		// Token: 0x060037BC RID: 14268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037BC")]
		[Address(RVA = "0x3547820", Offset = "0x3545E20", VA = "0x183547820")]
		private void UpdateSteeringWheelTransform()
		{
		}

		// Token: 0x060037BD RID: 14269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037BD")]
		[Address(RVA = "0x3547930", Offset = "0x3545F30", VA = "0x183547930")]
		private void UpdateWheelTransform(WheelCollider sourceCollider, Transform targetTransform, Transform targetColliderTransform)
		{
		}

		// Token: 0x060037BE RID: 14270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037BE")]
		[Address(RVA = "0x3547D40", Offset = "0x3546340", VA = "0x183547D40")]
		private void GetWheelPositionAndRotation(WheelCollider sourceCollider, Transform targetTransform, out Vector3 position, out Quaternion rotation)
		{
		}

		// Token: 0x060037BF RID: 14271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037BF")]
		[Address(RVA = "0x3547F60", Offset = "0x3546560", VA = "0x183547F60")]
		public void GetDriverPositionAndRotation(out Vector3 returnPosition, out Quaternion returnRotation)
		{
		}

		// Token: 0x060037C0 RID: 14272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037C0")]
		[Address(RVA = "0x3547F90", Offset = "0x3546590", VA = "0x183547F90")]
		public void GetPassengerAPositionAndRotation(out Vector3 returnPosition, out Quaternion returnRotation)
		{
		}

		// Token: 0x060037C1 RID: 14273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037C1")]
		[Address(RVA = "0x3547FC0", Offset = "0x35465C0", VA = "0x183547FC0")]
		public void SetForwardAccelerationFactorGoal(float accelerationFactor)
		{
		}

		// Token: 0x060037C2 RID: 14274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037C2")]
		[Address(RVA = "0x3547FD0", Offset = "0x35465D0", VA = "0x183547FD0")]
		private void UpdateBrakeTorque()
		{
		}

		// Token: 0x060037C3 RID: 14275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037C3")]
		[Address(RVA = "0x3548020", Offset = "0x3546620", VA = "0x183548020")]
		public void SetSteeringFactorGoal(float factor)
		{
		}

		// Token: 0x060037C4 RID: 14276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037C4")]
		[Address(RVA = "0x3548030", Offset = "0x3546630", VA = "0x183548030")]
		public void SetBoosting(bool stateBoostInput)
		{
		}

		// Token: 0x060037C5 RID: 14277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037C5")]
		[Address(RVA = "0x3548040", Offset = "0x3546640", VA = "0x183548040")]
		private void UpdateSteeringAngle()
		{
		}

		// Token: 0x060037C6 RID: 14278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037C6")]
		[Address(RVA = "0x3548070", Offset = "0x3546670", VA = "0x183548070")]
		public void DisconnectDriver(bool sendDisconnectEvent = true)
		{
		}

		// Token: 0x060037C7 RID: 14279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037C7")]
		[Address(RVA = "0x3548330", Offset = "0x3546930", VA = "0x183548330")]
		private void SetShoveInteractionEnabled(bool value)
		{
		}

		// Token: 0x060037C8 RID: 14280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037C8")]
		[Address(RVA = "0x3548350", Offset = "0x3546950", VA = "0x183548350")]
		private void SetPassengerAInteractionEnabled(bool value)
		{
		}

		// Token: 0x060037C9 RID: 14281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037C9")]
		[Address(RVA = "0x35484C0", Offset = "0x3546AC0", VA = "0x1835484C0")]
		private void SetDriverInteractionEnabled(bool value)
		{
		}

		// Token: 0x060037CA RID: 14282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037CA")]
		[Address(RVA = "0x3548630", Offset = "0x3546C30", VA = "0x183548630")]
		private void StartIdleBrakeTimer(float multiplier = 1f)
		{
		}

		// Token: 0x060037CB RID: 14283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037CB")]
		[Address(RVA = "0x35487A0", Offset = "0x3546DA0", VA = "0x1835487A0")]
		public void DisconnectPassengerA(bool sendDisconnectEvent = true)
		{
		}

		// Token: 0x060037CC RID: 14284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037CC")]
		[Address(RVA = "0x3548940", Offset = "0x3546F40", VA = "0x183548940")]
		public void SetHandBrake(bool stateHandBrakeInput)
		{
		}

		// Token: 0x060037CD RID: 14285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037CD")]
		[Address(RVA = "0x3548950", Offset = "0x3546F50", VA = "0x183548950")]
		public void GetPositionAndRotation(out Vector3 outPosition, out Quaternion outRotation)
		{
		}

		// Token: 0x060037CE RID: 14286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037CE")]
		[Address(RVA = "0x35489E0", Offset = "0x3546FE0", VA = "0x1835489E0")]
		public void GetDriverTransitionPositionAndRotation(out Vector3 position, out Quaternion rotation)
		{
		}

		// Token: 0x060037CF RID: 14287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037CF")]
		[Address(RVA = "0x3548A10", Offset = "0x3547010", VA = "0x183548A10")]
		public void GetPassengerATransitionPositionAndRotation(out Vector3 position, out Quaternion rotation)
		{
		}

		// Token: 0x060037D0 RID: 14288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037D0")]
		[Address(RVA = "0x3548A40", Offset = "0x3547040", VA = "0x183548A40", Slot = "327")]
		public void UpdateCloud(float density)
		{
		}

		// Token: 0x060037D1 RID: 14289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037D1")]
		[Address(RVA = "0x3548A50", Offset = "0x3547050", VA = "0x183548A50", Slot = "328")]
		public void UpdateTime(TimeOfDay time, TimeOfDay realTime)
		{
		}

		// Token: 0x060037D2 RID: 14290 RVA: 0x000109E0 File Offset: 0x0000EBE0
		[Token(Token = "0x60037D2")]
		[Address(RVA = "0x2612650", Offset = "0x2610C50", VA = "0x182612650", Slot = "329")]
		public bool ShouldRun()
		{
			return default(bool);
		}

		// Token: 0x060037D3 RID: 14291 RVA: 0x000109F8 File Offset: 0x0000EBF8
		[Token(Token = "0x60037D3")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "330")]
		public bool ShouldRunTimeSliced()
		{
			return default(bool);
		}

		// Token: 0x060037D4 RID: 14292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037D4")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "331")]
		public void SetLastUpdate(int frame, float time)
		{
		}

		// Token: 0x060037D5 RID: 14293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037D5")]
		[Address(RVA = "0x8ECC80", Offset = "0x8EB280", VA = "0x1808ECC80")]
		public List<GameObject> GetPlayerIkArmTargets()
		{
			return null;
		}

		// Token: 0x060037D6 RID: 14294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037D6")]
		[Address(RVA = "0x3548A70", Offset = "0x3547070", VA = "0x183548A70")]
		public void SetupDriverIkChains(IkTargetsController ikTargetsController)
		{
		}

		// Token: 0x060037D7 RID: 14295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037D7")]
		[Address(RVA = "0x3548C50", Offset = "0x3547250", VA = "0x183548C50")]
		public void DisconnectDriverIkChains(IkTargetsController ikTargetsController)
		{
		}

		// Token: 0x060037D8 RID: 14296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037D8")]
		[Address(RVA = "0x3548E40", Offset = "0x3547440", VA = "0x183548E40")]
		public void OnActivated()
		{
		}

		// Token: 0x060037D9 RID: 14297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037D9")]
		[Address(RVA = "0x3548E50", Offset = "0x3547450", VA = "0x183548E50")]
		public void OnDeactivated()
		{
		}

		// Token: 0x060037DA RID: 14298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037DA")]
		[Address(RVA = "0x3548E60", Offset = "0x3547460", VA = "0x183548E60")]
		private void TriggerActivated(bool value)
		{
		}

		// Token: 0x060037DB RID: 14299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037DB")]
		[Address(RVA = "0x3549170", Offset = "0x3547770", VA = "0x183549170")]
		private static void EnableObject(UnityEngine.Object eachObject, bool value)
		{
		}

		// Token: 0x060037DC RID: 14300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037DC")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void OnValidateLodding()
		{
		}

		// Token: 0x060037DD RID: 14301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037DD")]
		[Address(RVA = "0x3549450", Offset = "0x3547A50", VA = "0x183549450")]
		private void UpdateDistanceActivatorPosition()
		{
		}

		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x060037DE RID: 14302 RVA: 0x00010A10 File Offset: 0x0000EC10
		[Token(Token = "0x170006DA")]
		public bool Always
		{
			[Token(Token = "0x60037DE")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "324")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060037DF RID: 14303 RVA: 0x00010A28 File Offset: 0x0000EC28
		[Token(Token = "0x60037DF")]
		[Address(RVA = "0x35019B0", Offset = "0x34FFFB0", VA = "0x1835019B0", Slot = "323")]
		private float CalculateEventPriority(BoltConnection connection, Bolt.Event evnt)
		{
			return 0f;
		}

		// Token: 0x060037E0 RID: 14304 RVA: 0x00010A40 File Offset: 0x0000EC40
		[Token(Token = "0x60037E0")]
		[Address(RVA = "0x35019F0", Offset = "0x34FFFF0", VA = "0x1835019F0", Slot = "322")]
		private float CalculateStatePriority(BoltConnection connection, int skipped)
		{
			return 0f;
		}

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x060037E1 RID: 14305 RVA: 0x00010A58 File Offset: 0x0000EC58
		// (set) Token: 0x060037E2 RID: 14306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006DB")]
		public bool IsNetworkProxy
		{
			[Token(Token = "0x60037E1")]
			[Address(RVA = "0x3549690", Offset = "0x3547C90", VA = "0x183549690")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60037E2")]
			[Address(RVA = "0x35496A0", Offset = "0x3547CA0", VA = "0x1835496A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060037E3 RID: 14307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037E3")]
		[Address(RVA = "0x35496B0", Offset = "0x3547CB0", VA = "0x1835496B0", Slot = "16")]
		public override void Attached()
		{
		}

		// Token: 0x060037E4 RID: 14308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037E4")]
		[Address(RVA = "0x3549850", Offset = "0x3547E50", VA = "0x183549850")]
		private void SetupNetworkProxy()
		{
		}

		// Token: 0x060037E5 RID: 14309 RVA: 0x00010A70 File Offset: 0x0000EC70
		[Token(Token = "0x60037E5")]
		[Address(RVA = "0x3549870", Offset = "0x3547E70", VA = "0x183549870")]
		private bool ShouldProxyTransforms()
		{
			return default(bool);
		}

		// Token: 0x060037E6 RID: 14310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037E6")]
		[Address(RVA = "0x35498D0", Offset = "0x3547ED0", VA = "0x1835498D0")]
		private void NetworkLastUpdate()
		{
		}

		// Token: 0x060037E7 RID: 14311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037E7")]
		[Address(RVA = "0x3549A60", Offset = "0x3548060", VA = "0x183549A60")]
		private void UpdateExternalPassengers()
		{
		}

		// Token: 0x060037E8 RID: 14312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037E8")]
		[Address(RVA = "0x3549BD0", Offset = "0x35481D0", VA = "0x183549BD0")]
		private void UpdateOwnedGolfCartGhost()
		{
		}

		// Token: 0x060037E9 RID: 14313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037E9")]
		[Address(RVA = "0x3549F30", Offset = "0x3548530", VA = "0x183549F30")]
		private void NetworkLateUpdate()
		{
		}

		// Token: 0x060037EA RID: 14314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037EA")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void NetworkFixedUpdate()
		{
		}

		// Token: 0x060037EB RID: 14315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037EB")]
		[Address(RVA = "0x3549F40", Offset = "0x3548540", VA = "0x183549F40")]
		private void UpdateExternalGhostConstraint()
		{
		}

		// Token: 0x060037EC RID: 14316 RVA: 0x00010A88 File Offset: 0x0000EC88
		[Token(Token = "0x60037EC")]
		[Address(RVA = "0x354A500", Offset = "0x3548B00", VA = "0x18354A500")]
		private bool IsPositionZero(Vector3 position)
		{
			return default(bool);
		}

		// Token: 0x060037ED RID: 14317 RVA: 0x00010AA0 File Offset: 0x0000ECA0
		[Token(Token = "0x60037ED")]
		[Address(RVA = "0x354A580", Offset = "0x3548B80", VA = "0x18354A580")]
		private bool HasExternalGhostDisconnected()
		{
			return default(bool);
		}

		// Token: 0x060037EE RID: 14318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037EE")]
		[Address(RVA = "0x354A880", Offset = "0x3548E80", VA = "0x18354A880")]
		private void OnConnectedSlotChanged(IState sourceState, string propertypath, ArrayIndices arrayIndices)
		{
		}

		// Token: 0x060037EF RID: 14319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037EF")]
		[Address(RVA = "0x354AAB0", Offset = "0x35490B0", VA = "0x18354AAB0")]
		private void OnConnectedSlotChanged(BoltEntity slotValue, int arrayIndex)
		{
		}

		// Token: 0x060037F0 RID: 14320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037F0")]
		[Address(RVA = "0x354AC90", Offset = "0x3549290", VA = "0x18354AC90")]
		private void OnPassengerASlotChanged(BoltEntity slotValue)
		{
		}

		// Token: 0x060037F1 RID: 14321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037F1")]
		[Address(RVA = "0x354AEE0", Offset = "0x35494E0", VA = "0x18354AEE0")]
		private void OnDriverSlotChanged(BoltEntity slotValue)
		{
		}

		// Token: 0x060037F2 RID: 14322 RVA: 0x00010AB8 File Offset: 0x0000ECB8
		[Token(Token = "0x60037F2")]
		[Address(RVA = "0x354B000", Offset = "0x3549600", VA = "0x18354B000")]
		private bool VerifyPassengerAIsLocalPlayer(BoltEntity boltEntity)
		{
			return default(bool);
		}

		// Token: 0x060037F3 RID: 14323 RVA: 0x00010AD0 File Offset: 0x0000ECD0
		[Token(Token = "0x60037F3")]
		[Address(RVA = "0x354B140", Offset = "0x3549740", VA = "0x18354B140")]
		private bool VerifyDriverIsLocalPlayer(BoltEntity boltEntity)
		{
			return default(bool);
		}

		// Token: 0x060037F4 RID: 14324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037F4")]
		[Address(RVA = "0x354B300", Offset = "0x3549900", VA = "0x18354B300")]
		private void UnconstrainToGhost()
		{
		}

		// Token: 0x060037F5 RID: 14325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037F5")]
		[Address(RVA = "0x354B6D0", Offset = "0x3549CD0", VA = "0x18354B6D0")]
		private IEnumerator DelayedFixPlayerProxyRotation(Transform targetTransform)
		{
			return null;
		}

		// Token: 0x060037F6 RID: 14326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037F6")]
		[Address(RVA = "0x354B7D0", Offset = "0x3549DD0", VA = "0x18354B7D0")]
		private void UnconstrainPassengerA()
		{
		}

		// Token: 0x060037F7 RID: 14327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037F7")]
		[Address(RVA = "0x354B850", Offset = "0x3549E50", VA = "0x18354B850")]
		private void FixPlayerProxyRotation(Transform externalPlayerTransform)
		{
		}

		// Token: 0x060037F8 RID: 14328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037F8")]
		[Address(RVA = "0x354BB30", Offset = "0x354A130", VA = "0x18354BB30")]
		private void ConstrainToGhost(BoltEntity ghostGolfCartEntity)
		{
		}

		// Token: 0x060037F9 RID: 14329 RVA: 0x00010AE8 File Offset: 0x0000ECE8
		[Token(Token = "0x60037F9")]
		[Address(RVA = "0x354BDA0", Offset = "0x354A3A0", VA = "0x18354BDA0")]
		private bool SetupExternalDriver(BoltEntity ghostGolfCartEntity)
		{
			return default(bool);
		}

		// Token: 0x060037FA RID: 14330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037FA")]
		[Address(RVA = "0x354C0A0", Offset = "0x354A6A0", VA = "0x18354C0A0")]
		private void ConstrainPassengerA(BoltEntity passengerAEntity)
		{
		}

		// Token: 0x060037FB RID: 14331 RVA: 0x00010B00 File Offset: 0x0000ED00
		[Token(Token = "0x60037FB")]
		[Address(RVA = "0x354C2F0", Offset = "0x354A8F0", VA = "0x18354C2F0")]
		private static bool GetConnectedTransform(BoltEntity ghostGolfCartEntity, out IPlayerState playerState, out IGolfCartState golfCartState, out IkTargetsController playerIkTargetsController)
		{
			return default(bool);
		}

		// Token: 0x060037FC RID: 14332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037FC")]
		[Address(RVA = "0x354C740", Offset = "0x354AD40", VA = "0x18354C740")]
		public void SetRootTransformSynced(bool value)
		{
		}

		// Token: 0x060037FD RID: 14333 RVA: 0x00010B18 File Offset: 0x0000ED18
		[Token(Token = "0x60037FD")]
		[Address(RVA = "0x354CBA0", Offset = "0x354B1A0", VA = "0x18354CBA0")]
		private bool HasNetworkConnectedDriver()
		{
			return default(bool);
		}

		// Token: 0x060037FE RID: 14334 RVA: 0x00010B30 File Offset: 0x0000ED30
		[Token(Token = "0x60037FE")]
		[Address(RVA = "0x354CC70", Offset = "0x354B270", VA = "0x18354CC70")]
		private bool HasNetworkConnectedPassengerA()
		{
			return default(bool);
		}

		// Token: 0x060037FF RID: 14335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037FF")]
		[Address(RVA = "0x354CD40", Offset = "0x354B340", VA = "0x18354CD40")]
		private BoltEntity GetNetworkDriverEntity()
		{
			return null;
		}

		// Token: 0x06003800 RID: 14336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003800")]
		[Address(RVA = "0x354CD50", Offset = "0x354B350", VA = "0x18354CD50")]
		private BoltEntity GetNetworkPassengerAEntity()
		{
			return null;
		}

		// Token: 0x06003801 RID: 14337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003801")]
		[Address(RVA = "0x354CD60", Offset = "0x354B360", VA = "0x18354CD60")]
		private BoltEntity GetConnectedSlot(int slotIndex)
		{
			return null;
		}

		// Token: 0x06003802 RID: 14338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003802")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void OnDriverNetworkConnected()
		{
		}

		// Token: 0x06003803 RID: 14339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003803")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void OnDriverNetworkDisconnected()
		{
		}

		// Token: 0x06003804 RID: 14340 RVA: 0x00010B48 File Offset: 0x0000ED48
		[Token(Token = "0x6003804")]
		[Address(RVA = "0x354CF60", Offset = "0x354B560", VA = "0x18354CF60")]
		private bool TryDestroyGolfCartGhost()
		{
			return default(bool);
		}

		// Token: 0x06003805 RID: 14341 RVA: 0x00010B60 File Offset: 0x0000ED60
		[Token(Token = "0x6003805")]
		[Address(RVA = "0x354D060", Offset = "0x354B660", VA = "0x18354D060")]
		private bool TrySetupGolfCartGhost(out GameObject golfCartInstance, out GolfCartGhostController golfCartGhostController, out BoltEntity golfCartEntity)
		{
			return default(bool);
		}

		// Token: 0x06003806 RID: 14342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003806")]
		[Address(RVA = "0x354DC80", Offset = "0x354C280", VA = "0x18354DC80")]
		private void UpdateEntityWheelRpms()
		{
		}

		// Token: 0x06003807 RID: 14343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003807")]
		[Address(RVA = "0x354DE30", Offset = "0x354C430", VA = "0x18354DE30")]
		public static void SetEntityWheelRpms(BoltEntityListenerBehaviourWrapper<IGolfCartState> target, float frontLeftWheelRpm, float frontRightWheelRpm, float rearLeftWheelRpm, float rearRightWheelRpm)
		{
		}

		// Token: 0x06003808 RID: 14344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003808")]
		[Address(RVA = "0x354E070", Offset = "0x354C670", VA = "0x18354E070")]
		public static void GetEntityWheelRpms(BoltEntityListenerBehaviourWrapper<IGolfCartState> target, out float frontLeftWheelRpm, out float frontRightWheelRpm, out float rearLeftWheelRpm, out float rearRightWheelRpm)
		{
		}

		// Token: 0x06003809 RID: 14345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003809")]
		[Address(RVA = "0x354E260", Offset = "0x354C860", VA = "0x18354E260")]
		private void SendGolfCartShoveEvent(Vector3 sourceForward)
		{
		}

		// Token: 0x0600380A RID: 14346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600380A")]
		[Address(RVA = "0x354E3A0", Offset = "0x354C9A0", VA = "0x18354E3A0")]
		private void SendConnectDriverEvent()
		{
		}

		// Token: 0x0600380B RID: 14347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600380B")]
		[Address(RVA = "0x354E3D0", Offset = "0x354C9D0", VA = "0x18354E3D0")]
		private void SendDisconnectDriverEvent()
		{
		}

		// Token: 0x0600380C RID: 14348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600380C")]
		[Address(RVA = "0x354E400", Offset = "0x354CA00", VA = "0x18354E400")]
		private void SendConnectPassengerAEvent()
		{
		}

		// Token: 0x0600380D RID: 14349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600380D")]
		[Address(RVA = "0x354E460", Offset = "0x354CA60", VA = "0x18354E460")]
		private void SendDisconnectPassengerAEvent()
		{
		}

		// Token: 0x0600380E RID: 14350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600380E")]
		[Address(RVA = "0x354E4C0", Offset = "0x354CAC0", VA = "0x18354E4C0")]
		private void SendConnectSlotEvent(int boltEventSlotIndex, BoltEntity boltEventOccupiedEntity, bool disconnect = false)
		{
		}

		// Token: 0x0600380F RID: 14351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600380F")]
		[Address(RVA = "0x354E6B0", Offset = "0x354CCB0", VA = "0x18354E6B0", Slot = "317")]
		public override void OnEvent(GolfCartShoveEvent shoveEvent)
		{
		}

		// Token: 0x06003810 RID: 14352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003810")]
		[Address(RVA = "0x354E7A0", Offset = "0x354CDA0", VA = "0x18354E7A0", Slot = "318")]
		public override void OnEvent(GolfCartConnectSlotEvent slotEvent)
		{
		}

		// Token: 0x06003811 RID: 14353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003811")]
		[Address(RVA = "0x354E890", Offset = "0x354CE90", VA = "0x18354E890")]
		private void ConnectSlot(GolfCartConnectSlotEvent slotEvent)
		{
		}

		// Token: 0x06003812 RID: 14354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003812")]
		[Address(RVA = "0x354EAB0", Offset = "0x354D0B0", VA = "0x18354EAB0")]
		private void DisconnectSlot(GolfCartConnectSlotEvent slotEvent)
		{
		}

		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x06003813 RID: 14355 RVA: 0x00010B78 File Offset: 0x0000ED78
		[Token(Token = "0x170006DC")]
		private bool HasPower
		{
			[Token(Token = "0x6003813")]
			[Address(RVA = "0x354ED20", Offset = "0x354D320", VA = "0x18354ED20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003814 RID: 14356 RVA: 0x00010B90 File Offset: 0x0000ED90
		[Token(Token = "0x6003814")]
		[Address(RVA = "0x354ED70", Offset = "0x354D370", VA = "0x18354ED70")]
		private float GetPowerFactorRemaining()
		{
			return 0f;
		}

		// Token: 0x06003815 RID: 14357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003815")]
		[Address(RVA = "0x354EDB0", Offset = "0x354D3B0", VA = "0x18354EDB0")]
		private void UpdatePower()
		{
		}

		// Token: 0x06003816 RID: 14358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003816")]
		[Address(RVA = "0x354F160", Offset = "0x354D760", VA = "0x18354F160")]
		private void UpdatePowerIndicator()
		{
		}

		// Token: 0x06003817 RID: 14359 RVA: 0x00010BA8 File Offset: 0x0000EDA8
		[Token(Token = "0x6003817")]
		[Address(RVA = "0x354F1C0", Offset = "0x354D7C0", VA = "0x18354F1C0")]
		private bool ShouldSetFromNetworkState()
		{
			return default(bool);
		}

		// Token: 0x06003818 RID: 14360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003818")]
		[Address(RVA = "0x354F270", Offset = "0x354D870", VA = "0x18354F270")]
		private void ChargeBattery()
		{
		}

		// Token: 0x06003819 RID: 14361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003819")]
		[Address(RVA = "0x354F380", Offset = "0x354D980", VA = "0x18354F380")]
		private void DrainBattery()
		{
		}

		// Token: 0x0600381A RID: 14362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600381A")]
		[Address(RVA = "0x354F460", Offset = "0x354DA60", VA = "0x18354F460")]
		public GolfCartController()
		{
		}

		// Token: 0x04002FE4 RID: 12260
		[Token(Token = "0x4002FE4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _audioEventLocator;

		// Token: 0x04002FE5 RID: 12261
		[Token(Token = "0x4002FE5")]
		[FieldOffset(Offset = "0x38")]
		private float _speedAudioFactor;

		// Token: 0x04002FE6 RID: 12262
		[Token(Token = "0x4002FE6")]
		[FieldOffset(Offset = "0x40")]
		private EventInstance _engineAudioEventInstance;

		// Token: 0x04002FE7 RID: 12263
		[Token(Token = "0x4002FE7")]
		[FieldOffset(Offset = "0x48")]
		private EventInstance _beepAudioEventInstance;

		// Token: 0x04002FE8 RID: 12264
		[Token(Token = "0x4002FE8")]
		[FieldOffset(Offset = "0x50")]
		private List<EventInstance> _wheelEventInstances;

		// Token: 0x04002FE9 RID: 12265
		[Token(Token = "0x4002FE9")]
		[FieldOffset(Offset = "0x58")]
		private AutoTimer _reverseBeepTimer;

		// Token: 0x04002FEA RID: 12266
		[Token(Token = "0x4002FEA")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GolfCartControllerDefinition _definition;

		// Token: 0x04002FEB RID: 12267
		[Token(Token = "0x4002FEB")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private WorldItemSaver _saver;

		// Token: 0x04002FEC RID: 12268
		[Token(Token = "0x4002FEC")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private List<GenericInteraction> _shoveInteractions;

		// Token: 0x04002FED RID: 12269
		[Token(Token = "0x4002FED")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Transform _shovePullUpTransform;

		// Token: 0x04002FEE RID: 12270
		[Token(Token = "0x4002FEE")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GenericInteraction _driverInteraction;

		// Token: 0x04002FEF RID: 12271
		[Token(Token = "0x4002FEF")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Transform _driverLocator;

		// Token: 0x04002FF0 RID: 12272
		[Token(Token = "0x4002FF0")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Transform _transitionDriverLocator;

		// Token: 0x04002FF1 RID: 12273
		[Token(Token = "0x4002FF1")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private List<GameObject> _disableWhenHasLocalDriver;

		// Token: 0x04002FF2 RID: 12274
		[Token(Token = "0x4002FF2")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GenericInteraction _passengerAInteraction;

		// Token: 0x04002FF3 RID: 12275
		[Token(Token = "0x4002FF3")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Transform _passengerALocator;

		// Token: 0x04002FF4 RID: 12276
		[Token(Token = "0x4002FF4")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Transform _transitionPassengerALocator;

		// Token: 0x04002FF5 RID: 12277
		[Token(Token = "0x4002FF5")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Transform _steeringWheelCtrl;

		// Token: 0x04002FF6 RID: 12278
		[Token(Token = "0x4002FF6")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[FormerlySerializedAs("_playerIkArmTargets")]
		private List<GameObject> _playerDriverIkArmTargets;

		// Token: 0x04002FF7 RID: 12279
		[Token(Token = "0x4002FF7")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private WheelCollider _frontLeftWheelCollider;

		// Token: 0x04002FF8 RID: 12280
		[Token(Token = "0x4002FF8")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private WheelCollider _frontRightWheelCollider;

		// Token: 0x04002FF9 RID: 12281
		[Token(Token = "0x4002FF9")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private WheelCollider _rearLeftWheelCollider;

		// Token: 0x04002FFA RID: 12282
		[Token(Token = "0x4002FFA")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private WheelCollider _rearRightWheelCollider;

		// Token: 0x04002FFB RID: 12283
		[Token(Token = "0x4002FFB")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private List<Transform> _localDynamicTransforms;

		// Token: 0x04002FFC RID: 12284
		[Token(Token = "0x4002FFC")]
		[FieldOffset(Offset = "0xF0")]
		[FormerlySerializedAs("_frontLeftWheelTransform")]
		[SerializeField]
		private Transform _frontLeftWheelRendererTransform;

		// Token: 0x04002FFD RID: 12285
		[Token(Token = "0x4002FFD")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private Transform _frontLeftWheelColliderTransform;

		// Token: 0x04002FFE RID: 12286
		[Token(Token = "0x4002FFE")]
		[FieldOffset(Offset = "0x100")]
		[FormerlySerializedAs("_frontRightWheelTransform")]
		[SerializeField]
		private Transform _frontRightWheelRendererTransform;

		// Token: 0x04002FFF RID: 12287
		[Token(Token = "0x4002FFF")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private Transform _frontRightWheelColliderTransform;

		// Token: 0x04003000 RID: 12288
		[Token(Token = "0x4003000")]
		[FieldOffset(Offset = "0x110")]
		[FormerlySerializedAs("_rearLeftWheelTransform")]
		[SerializeField]
		private Transform _rearLeftWheelRendererTransform;

		// Token: 0x04003001 RID: 12289
		[Token(Token = "0x4003001")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private Transform _rearLeftWheelColliderTransform;

		// Token: 0x04003002 RID: 12290
		[Token(Token = "0x4003002")]
		[FieldOffset(Offset = "0x120")]
		[FormerlySerializedAs("_rearRightWheelTransform")]
		[SerializeField]
		private Transform _rearRightWheelRendererTransform;

		// Token: 0x04003003 RID: 12291
		[Token(Token = "0x4003003")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private Transform _rearRightWheelColliderTransform;

		// Token: 0x04003004 RID: 12292
		[Token(Token = "0x4003004")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private GameObject _bushBreakerObject;

		// Token: 0x04003005 RID: 12293
		[Token(Token = "0x4003005")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private List<GameObject> _smallDamageColliders;

		// Token: 0x04003006 RID: 12294
		[Token(Token = "0x4003006")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private List<GameObject> _playerSmallDamageColliders;

		// Token: 0x04003007 RID: 12295
		[Token(Token = "0x4003007")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		[FormerlySerializedAs("_knockdownDamageColliders")]
		private List<GameObject> _enemyKnockdownDamageColliders;

		// Token: 0x04003008 RID: 12296
		[Token(Token = "0x4003008")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		private List<GameObject> _playerKnockdownDamageColliders;

		// Token: 0x04003009 RID: 12297
		[Token(Token = "0x4003009")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		private List<UnityEngine.Object> _disableOnKinematic;

		// Token: 0x0400300A RID: 12298
		[Token(Token = "0x400300A")]
		[FieldOffset(Offset = "0x160")]
		[SerializeField]
		private List<UnityEngine.Object> _enableOnKinematic;

		// Token: 0x0400300B RID: 12299
		[Token(Token = "0x400300B")]
		[FieldOffset(Offset = "0x168")]
		[FormerlySerializedAs("_waterLevelSensor")]
		[SerializeField]
		private WaterLevelSensor _vacantWaterLevelSensor;

		// Token: 0x0400300C RID: 12300
		[Token(Token = "0x400300C")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		private WaterLevelSensor _activeWaterLevelSensor;

		// Token: 0x0400300D RID: 12301
		[Token(Token = "0x400300D")]
		[FieldOffset(Offset = "0x178")]
		[SerializeField]
		private Quaternion _activeWaterLevelSensorOffsetRotation;

		// Token: 0x0400300E RID: 12302
		[Token(Token = "0x400300E")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		private FloatController _floatController;

		// Token: 0x0400300F RID: 12303
		[Token(Token = "0x400300F")]
		[FieldOffset(Offset = "0x190")]
		private IkTargetsController _currentDriverIkTargetsController;

		// Token: 0x04003010 RID: 12304
		[Token(Token = "0x4003010")]
		[FieldOffset(Offset = "0x198")]
		private AutoTimer _idleBrakeTimer;

		// Token: 0x04003011 RID: 12305
		[Token(Token = "0x4003011")]
		[FieldOffset(Offset = "0x1A0")]
		private PlayerGolfCartDriverAction _localPlayerDriverController;

		// Token: 0x04003012 RID: 12306
		[Token(Token = "0x4003012")]
		[FieldOffset(Offset = "0x1A8")]
		private PlayerGolfCartPassengerAction _localPlayerPassengerAController;

		// Token: 0x04003013 RID: 12307
		[Token(Token = "0x4003013")]
		[FieldOffset(Offset = "0x1B0")]
		private Rigidbody _rigidbody;

		// Token: 0x04003014 RID: 12308
		[Token(Token = "0x4003014")]
		[FieldOffset(Offset = "0x1B8")]
		private AutoTimer _shoveCooldownTimer;

		// Token: 0x04003015 RID: 12309
		[Token(Token = "0x4003015")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string HasDismountedFromGolfCartBeforeKey;

		// Token: 0x04003016 RID: 12310
		[Token(Token = "0x4003016")]
		[FieldOffset(Offset = "0x1C0")]
		[SerializeField]
		private GenericDistanceActivator _distanceActivator;

		// Token: 0x04003017 RID: 12311
		[Token(Token = "0x4003017")]
		[FieldOffset(Offset = "0x1C8")]
		[SerializeField]
		private List<UnityEngine.Object> _objectsToEnableOnActivated;

		// Token: 0x04003018 RID: 12312
		[Token(Token = "0x4003018")]
		[FieldOffset(Offset = "0x1D0")]
		[SerializeField]
		private List<UnityEngine.Object> _objectsToDisableOnActivated;

		// Token: 0x04003019 RID: 12313
		[Token(Token = "0x4003019")]
		public const int DriverSlotIndex = 0;

		// Token: 0x0400301A RID: 12314
		[Token(Token = "0x400301A")]
		public const int PassengerASlotIndex = 1;

		// Token: 0x0400301B RID: 12315
		[Token(Token = "0x400301B")]
		[FieldOffset(Offset = "0x1D8")]
		[SerializeField]
		private GameObject _ghostGolfCartPrefabSource;

		// Token: 0x0400301C RID: 12316
		[Token(Token = "0x400301C")]
		[FieldOffset(Offset = "0x1E0")]
		private bool? _currentRootTransformSyncedValue;

		// Token: 0x0400301D RID: 12317
		[Token(Token = "0x400301D")]
		[FieldOffset(Offset = "0x1E8")]
		private Transform _externalPassengerAPlayerTransform;

		// Token: 0x0400301E RID: 12318
		[Token(Token = "0x400301E")]
		[FieldOffset(Offset = "0x1F0")]
		private GameObject _ownedGolfCartGhost;

		// Token: 0x0400301F RID: 12319
		[Token(Token = "0x400301F")]
		[FieldOffset(Offset = "0x1F8")]
		private GolfCartGhostController _ownedGolfCartGhostController;

		// Token: 0x04003020 RID: 12320
		[Token(Token = "0x4003020")]
		[FieldOffset(Offset = "0x200")]
		private BoltEntity _ownedGolfCartGhostEntity;

		// Token: 0x04003021 RID: 12321
		[Token(Token = "0x4003021")]
		[FieldOffset(Offset = "0x208")]
		private IGolfCartState _externalGolfCartGhostState;

		// Token: 0x04003022 RID: 12322
		[Token(Token = "0x4003022")]
		[FieldOffset(Offset = "0x210")]
		private GolfCartGhostController _externalGolfCartGhostController;

		// Token: 0x04003023 RID: 12323
		[Token(Token = "0x4003023")]
		[FieldOffset(Offset = "0x218")]
		private BoltEntity _externalGolfCartGhostEntity;

		// Token: 0x04003024 RID: 12324
		[Token(Token = "0x4003024")]
		[FieldOffset(Offset = "0x220")]
		private Transform _externalGolfCartGhostTransform;

		// Token: 0x04003025 RID: 12325
		[Token(Token = "0x4003025")]
		[FieldOffset(Offset = "0x228")]
		private bool _externalDriverPlayerInitialized;

		// Token: 0x04003026 RID: 12326
		[Token(Token = "0x4003026")]
		[FieldOffset(Offset = "0x230")]
		private IPlayerState _externalDriverPlayerState;

		// Token: 0x04003027 RID: 12327
		[Token(Token = "0x4003027")]
		[FieldOffset(Offset = "0x238")]
		private IkTargetsController _externalDriverIkTargetsController;

		// Token: 0x04003028 RID: 12328
		[Token(Token = "0x4003028")]
		[FieldOffset(Offset = "0x240")]
		private Transform _externalDriverPlayerTransform;

		// Token: 0x04003029 RID: 12329
		[Token(Token = "0x4003029")]
		[FieldOffset(Offset = "0x248")]
		private BoltEntityDynamicSmooth _externalDriverPlayerSmoothScript;

		// Token: 0x0400302A RID: 12330
		[Token(Token = "0x400302A")]
		[FieldOffset(Offset = "0x250")]
		private bool _logFixPlayerProxyRotation;

		// Token: 0x0400302C RID: 12332
		[Token(Token = "0x400302C")]
		[FieldOffset(Offset = "0x258")]
		[SerializeField]
		private BatteryIndicator _batteryIndicator;

		// Token: 0x0400302D RID: 12333
		[Token(Token = "0x400302D")]
		[FieldOffset(Offset = "0x260")]
		private bool _distanceActivated;

		// Token: 0x0400302E RID: 12334
		[Token(Token = "0x400302E")]
		[FieldOffset(Offset = "0x261")]
		private bool _setToKinematic;

		// Token: 0x0400302F RID: 12335
		[Token(Token = "0x400302F")]
		[FieldOffset(Offset = "0x264")]
		private Vector3 _rigidBodyVelocity;

		// Token: 0x04003030 RID: 12336
		[Token(Token = "0x4003030")]
		[FieldOffset(Offset = "0x270")]
		private float _rigidBodyVelocitySqrMagnitude;

		// Token: 0x04003031 RID: 12337
		[Token(Token = "0x4003031")]
		[FieldOffset(Offset = "0x274")]
		private bool _isInDeepWater;

		// Token: 0x04003032 RID: 12338
		[Token(Token = "0x4003032")]
		[FieldOffset(Offset = "0x275")]
		private bool _isLocalPlayerConnectedDriver;

		// Token: 0x04003033 RID: 12339
		[Token(Token = "0x4003033")]
		[FieldOffset(Offset = "0x276")]
		private bool _isLocalPlayerConnectedPassengerA;

		// Token: 0x04003034 RID: 12340
		[Token(Token = "0x4003034")]
		[FieldOffset(Offset = "0x277")]
		private bool _boostInput;

		// Token: 0x04003035 RID: 12341
		[Token(Token = "0x4003035")]
		[FieldOffset(Offset = "0x278")]
		private bool _handBrakeInput;

		// Token: 0x04003036 RID: 12342
		[Token(Token = "0x4003036")]
		[FieldOffset(Offset = "0x27C")]
		private float _accelerationFactor;

		// Token: 0x04003037 RID: 12343
		[Token(Token = "0x4003037")]
		[FieldOffset(Offset = "0x280")]
		private float _engineLoadFactor;

		// Token: 0x04003038 RID: 12344
		[Token(Token = "0x4003038")]
		[FieldOffset(Offset = "0x284")]
		private float _engineLoadFactorSmoothed;

		// Token: 0x04003039 RID: 12345
		[Token(Token = "0x4003039")]
		[FieldOffset(Offset = "0x288")]
		private float _accelerationFactorGoal;

		// Token: 0x0400303A RID: 12346
		[Token(Token = "0x400303A")]
		[FieldOffset(Offset = "0x28C")]
		private float _accelerationFactorVel;

		// Token: 0x0400303B RID: 12347
		[Token(Token = "0x400303B")]
		[FieldOffset(Offset = "0x290")]
		private float _brakeTorque;

		// Token: 0x0400303C RID: 12348
		[Token(Token = "0x400303C")]
		[FieldOffset(Offset = "0x294")]
		private float _brakingFactor;

		// Token: 0x0400303D RID: 12349
		[Token(Token = "0x400303D")]
		[FieldOffset(Offset = "0x298")]
		private float _maxWheelRpm;

		// Token: 0x0400303E RID: 12350
		[Token(Token = "0x400303E")]
		[FieldOffset(Offset = "0x29C")]
		private float _steeringAngle;

		// Token: 0x0400303F RID: 12351
		[Token(Token = "0x400303F")]
		[FieldOffset(Offset = "0x2A0")]
		private float _steeringFactor;

		// Token: 0x04003040 RID: 12352
		[Token(Token = "0x4003040")]
		[FieldOffset(Offset = "0x2A4")]
		private float _steeringFactorGoal;

		// Token: 0x04003041 RID: 12353
		[Token(Token = "0x4003041")]
		[FieldOffset(Offset = "0x2A8")]
		private float _steeringFactorVel;

		// Token: 0x04003042 RID: 12354
		[Token(Token = "0x4003042")]
		[FieldOffset(Offset = "0x2AC")]
		private float _frontLeftFinalTorque;

		// Token: 0x04003043 RID: 12355
		[Token(Token = "0x4003043")]
		[FieldOffset(Offset = "0x2B0")]
		private float _frontLeftWheelRpm;

		// Token: 0x04003044 RID: 12356
		[Token(Token = "0x4003044")]
		[FieldOffset(Offset = "0x2B4")]
		private float _frontLeftWheelRpmAbs;

		// Token: 0x04003045 RID: 12357
		[Token(Token = "0x4003045")]
		[FieldOffset(Offset = "0x2B8")]
		private float _frontLeftWheelTraction;

		// Token: 0x04003046 RID: 12358
		[Token(Token = "0x4003046")]
		[FieldOffset(Offset = "0x2BC")]
		private float _frontRightFinalTorque;

		// Token: 0x04003047 RID: 12359
		[Token(Token = "0x4003047")]
		[FieldOffset(Offset = "0x2C0")]
		private float _frontRightWheelRpm;

		// Token: 0x04003048 RID: 12360
		[Token(Token = "0x4003048")]
		[FieldOffset(Offset = "0x2C4")]
		private float _frontRightWheelRpmAbs;

		// Token: 0x04003049 RID: 12361
		[Token(Token = "0x4003049")]
		[FieldOffset(Offset = "0x2C8")]
		private float _frontRightWheelTraction;

		// Token: 0x0400304A RID: 12362
		[Token(Token = "0x400304A")]
		[FieldOffset(Offset = "0x2CC")]
		private float _rearLeftFinalTorque;

		// Token: 0x0400304B RID: 12363
		[Token(Token = "0x400304B")]
		[FieldOffset(Offset = "0x2D0")]
		private float _rearLeftWheelRpm;

		// Token: 0x0400304C RID: 12364
		[Token(Token = "0x400304C")]
		[FieldOffset(Offset = "0x2D4")]
		private float _rearLeftWheelRpmAbs;

		// Token: 0x0400304D RID: 12365
		[Token(Token = "0x400304D")]
		[FieldOffset(Offset = "0x2D8")]
		private float _rearLeftWheelTraction;

		// Token: 0x0400304E RID: 12366
		[Token(Token = "0x400304E")]
		[FieldOffset(Offset = "0x2DC")]
		private float _rearRightFinalTorque;

		// Token: 0x0400304F RID: 12367
		[Token(Token = "0x400304F")]
		[FieldOffset(Offset = "0x2E0")]
		private float _rearRightWheelRpm;

		// Token: 0x04003050 RID: 12368
		[Token(Token = "0x4003050")]
		[FieldOffset(Offset = "0x2E4")]
		private float _rearRightWheelRpmAbs;

		// Token: 0x04003051 RID: 12369
		[Token(Token = "0x4003051")]
		[FieldOffset(Offset = "0x2E8")]
		private float _rearRightWheelTraction;

		// Token: 0x04003052 RID: 12370
		[Token(Token = "0x4003052")]
		[FieldOffset(Offset = "0x2EC")]
		private float _cloudFactor;

		// Token: 0x04003053 RID: 12371
		[Token(Token = "0x4003053")]
		[FieldOffset(Offset = "0x2F0")]
		private float _currentPower;

		// Token: 0x04003054 RID: 12372
		[Token(Token = "0x4003054")]
		[FieldOffset(Offset = "0x2F4")]
		private TerrainUtils.AudioTextureType _terrainAudioType;

		// Token: 0x04003055 RID: 12373
		[Token(Token = "0x4003055")]
		[FieldOffset(Offset = "0x2F8")]
		private TimeOfDay _currentTimeOfDay;
	}
}
