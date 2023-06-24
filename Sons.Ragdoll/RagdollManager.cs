using System;
using System.Collections;
using System.Collections.Generic;
using Endnight.Types;
using Il2CppDummyDll;
using Sons.Physics;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Ragdoll
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	[AddComponentMenu("Sons/Ragdoll/RagdollManager")]
	public class RagdollManager : MonoBehaviour
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000006 RID: 6 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000001")]
		public bool IsRagdollEnabled
		{
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x7282E0", Offset = "0x7268E0", VA = "0x1807282E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000007 RID: 7 RVA: 0x00002080 File Offset: 0x00000280
		[Token(Token = "0x17000002")]
		public RagdollManager.RagdollState RagdollType
		{
			[Token(Token = "0x6000007")]
			[Address(RVA = "0xAFF310", Offset = "0xAFD910", VA = "0x180AFF310")]
			get
			{
				return RagdollManager.RagdollState.Off;
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x3118350", Offset = "0x3116950", VA = "0x183118350")]
		public void SetInCave(bool value)
		{
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x3118360", Offset = "0x3116960", VA = "0x183118360")]
		private void OnValidate()
		{
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x3118370", Offset = "0x3116970", VA = "0x183118370")]
		private void OnDisable()
		{
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x3118380", Offset = "0x3116980", VA = "0x183118380")]
		private void CollectFromRigidBodies()
		{
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x3118530", Offset = "0x3116B30", VA = "0x183118530")]
		private void Enable()
		{
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x3118550", Offset = "0x3116B50", VA = "0x183118550")]
		private void Disable()
		{
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x3118560", Offset = "0x3116B60", VA = "0x183118560")]
		private void FindRootRigidBody()
		{
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x3118910", Offset = "0x3116F10", VA = "0x183118910")]
		public Transform TryFind(string ragdollSection)
		{
			return null;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x3118C50", Offset = "0x3117250", VA = "0x183118C50")]
		private void Start()
		{
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x3118E00", Offset = "0x3117400", VA = "0x183118E00")]
		private void SetEnabledStatic(bool value)
		{
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x31192B0", Offset = "0x31178B0", VA = "0x1831192B0")]
		public void VerifyAnimator()
		{
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x3119460", Offset = "0x3117A60", VA = "0x183119460")]
		private IEnumerator DelayEnable(float enableAfter)
		{
			return null;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x3119520", Offset = "0x3117B20", VA = "0x183119520")]
		private void InitBaseTransformsIfNeeded()
		{
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x31199B0", Offset = "0x3117FB0", VA = "0x1831199B0")]
		public static void DestroyAllComponents()
		{
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x3119A50", Offset = "0x3118050", VA = "0x183119A50")]
		public void DestroyComponents()
		{
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x3119C80", Offset = "0x3118280", VA = "0x183119C80")]
		private void DestroyComponent(GameObject eachObject)
		{
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x3119F40", Offset = "0x3118540", VA = "0x183119F40")]
		private void InitPreviousLocations()
		{
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x311A3D0", Offset = "0x31189D0", VA = "0x18311A3D0")]
		public void ClearPreviousLocations()
		{
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x311A4E0", Offset = "0x3118AE0", VA = "0x18311A4E0")]
		public void UpdateVelocities(float deltaTime)
		{
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x311A8E0", Offset = "0x3118EE0", VA = "0x18311A8E0")]
		public void SetEnabledObjectOn(string objectName)
		{
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x311A8F0", Offset = "0x3118EF0", VA = "0x18311A8F0")]
		public void SetEnabledObjectOff(string objectName)
		{
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x311A900", Offset = "0x3118F00", VA = "0x18311A900")]
		public void SetEnabledObject(string objectName, bool value)
		{
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x311ABD0", Offset = "0x31191D0", VA = "0x18311ABD0")]
		public void HideNamedObjects()
		{
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x311ADD0", Offset = "0x31193D0", VA = "0x18311ADD0")]
		public Transform GetRootTransform()
		{
			return null;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x0000209C File Offset: 0x0000029C
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x311AEF0", Offset = "0x31194F0", VA = "0x18311AEF0")]
		public Vector3 GetRootPosition(Vector3 defaultPos)
		{
			return default(Vector3);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x311B0A0", Offset = "0x31196A0", VA = "0x18311B0A0")]
		public void SetEnabled(bool value, RagdollManager.RagdollState state = RagdollManager.RagdollState.Enabled)
		{
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x311BE10", Offset = "0x311A410", VA = "0x18311BE10")]
		public void AddVelocityToAll(Vector3 velocity)
		{
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x311C0F0", Offset = "0x311A6F0", VA = "0x18311C0F0")]
		private static Collider[] GetCompoundColliders(GameObject go)
		{
			return null;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x311C4F0", Offset = "0x311AAF0", VA = "0x18311C4F0")]
		private void SetEnabled(GameObject eachObject, bool value, Vector3 initialVelocity)
		{
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x311CE20", Offset = "0x311B420", VA = "0x18311CE20")]
		private void SetEnabledBuoyancy(Buoyancy targetComponent, bool value)
		{
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x311CF40", Offset = "0x311B540", VA = "0x18311CF40")]
		private static void SetEnabledColliders(GameObject eachObject, bool value)
		{
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x311D0A0", Offset = "0x311B6A0", VA = "0x18311D0A0")]
		private void SetEnabledRigidBody(bool value, Vector3 initialVelocity, Rigidbody rigidBodyTarget)
		{
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x311D430", Offset = "0x311BA30", VA = "0x18311D430")]
		public void IgnoreCollision(Collider ignoreCollider, bool ignore)
		{
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x311D690", Offset = "0x311BC90", VA = "0x18311D690")]
		public void ApplyForceAtPosition(Vector3 velocity, Vector3 hitPosition)
		{
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x311DBA0", Offset = "0x311C1A0", VA = "0x18311DBA0")]
		public void ApplyExplosionForce(Vector3 center, float radius, float forceMultiplier, float upModifier = 0.5f)
		{
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x311DF20", Offset = "0x311C520", VA = "0x18311DF20")]
		public void ApplyTorque(Vector3 torque)
		{
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x311E060", Offset = "0x311C660", VA = "0x18311E060")]
		public void ApplyRotationalVelocities(float velocityChange, Vector3 forwards, Vector3 right)
		{
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x311E810", Offset = "0x311CE10", VA = "0x18311E810")]
		private void SetAllDrag()
		{
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x311E830", Offset = "0x311CE30", VA = "0x18311E830")]
		private void SetAllMass()
		{
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x311E850", Offset = "0x311CE50", VA = "0x18311E850")]
		private void SetAllProjection()
		{
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x311E870", Offset = "0x311CE70", VA = "0x18311E870")]
		private void SetRagdollLayer()
		{
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x311EB40", Offset = "0x311D140", VA = "0x18311EB40")]
		private void AutoConfigureAnchors()
		{
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x311EFD0", Offset = "0x311D5D0", VA = "0x18311EFD0")]
		private void SetAllProperties(bool setDrag, bool setMass, bool setProjection)
		{
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x311F300", Offset = "0x311D900", VA = "0x18311F300")]
		public void SyncPosition(Vector3 targetPosition)
		{
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x311F410", Offset = "0x311DA10", VA = "0x18311F410")]
		private void CreateSpringJoint(GameObject draggerGo, Rigidbody connectedBody)
		{
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x311F8D0", Offset = "0x311DED0", VA = "0x18311F8D0")]
		private void CreateDriveJoint(GameObject draggerGo, Rigidbody connectedBody)
		{
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x311FFB0", Offset = "0x311E5B0", VA = "0x18311FFB0")]
		private GameObject CreateSyncJoint(Rigidbody connectedBody)
		{
			return null;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x31200B0", Offset = "0x311E6B0", VA = "0x1831200B0")]
		public void ClearSyncJoint()
		{
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x31201E0", Offset = "0x311E7E0", VA = "0x1831201E0")]
		private void CreateSyncJoint()
		{
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x3120340", Offset = "0x311E940", VA = "0x183120340")]
		private void DoJointSync(Vector3 targetPosition)
		{
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x3120610", Offset = "0x311EC10", VA = "0x183120610")]
		public RagdollManager()
		{
		}

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _startDisabled;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x21")]
		[SerializeField]
		private bool _startEnabledStatic;

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _enableAfter;

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<GameObject> _ragdollObjects;

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Animator _animator;

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Rigidbody _rootRigidBody;

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<Behaviour> _disabledComponents;

		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private List<Collider> _disabledColliders;

		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private List<Rigidbody> _disabledRigidBodies;

		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private List<CharacterController> _disabledControllers;

		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private List<NamedGameObject> _namedObjects;

		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x68")]
		[FormerlySerializedAs("_forceOnMultiplier")]
		[SerializeField]
		private float _downForceOn;

		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float _velocityOnMultiplier;

		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float _maxDepenetrationVelocity;

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x78")]
		private Dictionary<GameObject, RagdollManager.PositionRotation> _baseTransforms;

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x80")]
		private Dictionary<Transform, RagdollManager.PositionVelocity> _prevLocations;

		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x88")]
		private List<Transform> _ragdollTransforms;

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x90")]
		private bool _isRagdollEnabled;

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x94")]
		private RagdollManager.RagdollState _ragdollState;

		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private int _maxHitsOnFrame;

		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x9C")]
		[SerializeField]
		private float _hitForceMultiplier;

		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private float _hitForceRadius;

		// Token: 0x0400001F RID: 31
		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0xA4")]
		private int _lastForceFrame;

		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0xA8")]
		private int _forcesOnFrame;

		// Token: 0x04000021 RID: 33
		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0xAC")]
		private bool _inCave;

		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private float _drag;

		// Token: 0x04000023 RID: 35
		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0xB4")]
		[SerializeField]
		private float _angularDrag;

		// Token: 0x04000024 RID: 36
		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private float _mass;

		// Token: 0x04000025 RID: 37
		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0xBC")]
		[SerializeField]
		private bool _enableProjection;

		// Token: 0x04000026 RID: 38
		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private float _syncSpringStrength;

		// Token: 0x04000027 RID: 39
		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0xC4")]
		[SerializeField]
		private float _syncMaxDistance;

		// Token: 0x04000028 RID: 40
		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private float _syncDamper;

		// Token: 0x04000029 RID: 41
		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0xCC")]
		[SerializeField]
		private float _syncDriveStrength;

		// Token: 0x0400002A RID: 42
		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0xD0")]
		private bool _syncActive;

		// Token: 0x0400002B RID: 43
		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0xD8")]
		private GameObject _springJointGo;

		// Token: 0x02000006 RID: 6
		[Token(Token = "0x2000006")]
		private struct PositionVelocity
		{
			// Token: 0x0400002C RID: 44
			[Token(Token = "0x400002C")]
			[FieldOffset(Offset = "0x0")]
			public Vector3 position;

			// Token: 0x0400002D RID: 45
			[Token(Token = "0x400002D")]
			[FieldOffset(Offset = "0xC")]
			public Vector3 velocity;
		}

		// Token: 0x02000007 RID: 7
		[Token(Token = "0x2000007")]
		private struct PositionRotation
		{
			// Token: 0x0400002E RID: 46
			[Token(Token = "0x400002E")]
			[FieldOffset(Offset = "0x0")]
			public Vector3 position;

			// Token: 0x0400002F RID: 47
			[Token(Token = "0x400002F")]
			[FieldOffset(Offset = "0xC")]
			public Quaternion rotation;
		}

		// Token: 0x02000008 RID: 8
		[Token(Token = "0x2000008")]
		public enum RagdollState
		{
			// Token: 0x04000031 RID: 49
			[Token(Token = "0x4000031")]
			Off,
			// Token: 0x04000032 RID: 50
			[Token(Token = "0x4000032")]
			Enabled,
			// Token: 0x04000033 RID: 51
			[Token(Token = "0x4000033")]
			DroppedByPlayer,
			// Token: 0x04000034 RID: 52
			[Token(Token = "0x4000034")]
			SpringTrap
		}
	}
}
