using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using Sons.TerrainDetail;
using Sons.Weapon;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace Sons.Gameplay
{
	// Token: 0x02000630 RID: 1584
	[Token(Token = "0x2000630")]
	[AddComponentMenu("Sons/Gameplay/BreakableObject")]
	public class BreakableObject : MonoBehaviour
	{
		// Token: 0x14000019 RID: 25
		// (add) Token: 0x0600287B RID: 10363 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600287C RID: 10364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000019")]
		private event Action _onBrokenCallback
		{
			[Token(Token = "0x600287B")]
			[Address(RVA = "0x2DAEEB0", Offset = "0x2DADEB0", VA = "0x182DAEEB0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600287C")]
			[Address(RVA = "0x2DAFBF0", Offset = "0x2DAEBF0", VA = "0x182DAFBF0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x0600287D RID: 10365 RVA: 0x0000BC88 File Offset: 0x00009E88
		[Token(Token = "0x17000559")]
		private bool HasBrokenChild
		{
			[Token(Token = "0x600287D")]
			[Address(RVA = "0x2DAFE50", Offset = "0x2DAEE50", VA = "0x182DAFE50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x0600287E RID: 10366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700055A")]
		public GameObject OriginalObject
		{
			[Token(Token = "0x600287E")]
			[Address(RVA = "0x541200", Offset = "0x540200", VA = "0x180541200")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x0600287F RID: 10367 RVA: 0x0000BCA0 File Offset: 0x00009EA0
		[Token(Token = "0x1700055B")]
		public bool IsBroken
		{
			[Token(Token = "0x600287F")]
			[Address(RVA = "0x22EB760", Offset = "0x22EA760", VA = "0x1822EB760")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002880 RID: 10368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002880")]
		[Address(RVA = "0x541240", Offset = "0x540240", VA = "0x180541240")]
		public void SetOriginalObject(GameObject root)
		{
		}

		// Token: 0x06002881 RID: 10369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002881")]
		[Address(RVA = "0x2DAEFD0", Offset = "0x2DADFD0", VA = "0x182DAEFD0")]
		public void SetHitBreakSounds(string hitEvent, string breakEvent)
		{
		}

		// Token: 0x06002882 RID: 10370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002882")]
		[Address(RVA = "0x2DAEF50", Offset = "0x2DADF50", VA = "0x182DAEF50")]
		public void SetBreakHealth(float breakHealth)
		{
		}

		// Token: 0x06002883 RID: 10371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002883")]
		[Address(RVA = "0x656130", Offset = "0x655130", VA = "0x180656130")]
		public List<BreakableObject.SpawnDefinition> GetSpawnDefinitions()
		{
			return null;
		}

		// Token: 0x06002884 RID: 10372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002884")]
		[Address(RVA = "0x2DAD810", Offset = "0x2DAC810", VA = "0x182DAD810")]
		private void Awake()
		{
		}

		// Token: 0x06002885 RID: 10373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002885")]
		[Address(RVA = "0x2DAEAA0", Offset = "0x2DADAA0", VA = "0x182DAEAA0")]
		private void OnValidate()
		{
		}

		// Token: 0x06002886 RID: 10374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002886")]
		[Address(RVA = "0x2DAE800", Offset = "0x2DAD800", VA = "0x182DAE800")]
		public void OnEnable()
		{
		}

		// Token: 0x06002887 RID: 10375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002887")]
		[Address(RVA = "0x2DADC30", Offset = "0x2DACC30", VA = "0x182DADC30")]
		private void InitializeWorldObjectLocatorHolder()
		{
		}

		// Token: 0x06002888 RID: 10376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002888")]
		[Address(RVA = "0x2DAE6C0", Offset = "0x2DAD6C0", VA = "0x182DAE6C0")]
		public void OnDisable()
		{
		}

		// Token: 0x06002889 RID: 10377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002889")]
		[Address(RVA = "0x2DAEDB0", Offset = "0x2DADDB0", VA = "0x182DAEDB0")]
		private void OnWorldObjectLocatorStateChanged(WorldObjectState state)
		{
		}

		// Token: 0x0600288A RID: 10378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600288A")]
		[Address(RVA = "0x2DAEF70", Offset = "0x2DADF70", VA = "0x182DAEF70")]
		private void SetBrokenWorldObjectState()
		{
		}

		// Token: 0x0600288B RID: 10379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600288B")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		private void RegisterCheckConvert()
		{
		}

		// Token: 0x0600288C RID: 10380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600288C")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		private void UnregisterCheckConvert()
		{
		}

		// Token: 0x0600288D RID: 10381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600288D")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600288E RID: 10382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600288E")]
		[Address(RVA = "0x2DAD880", Offset = "0x2DAC880", VA = "0x182DAD880")]
		private void CheckForConvert()
		{
		}

		// Token: 0x0600288F RID: 10383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600288F")]
		[Address(RVA = "0x2DAF800", Offset = "0x2DAE800", VA = "0x182DAF800")]
		private void Start()
		{
		}

		// Token: 0x06002890 RID: 10384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002890")]
		[Address(RVA = "0x2DAE580", Offset = "0x2DAD580", VA = "0x182DAE580")]
		public void OnBrokenViaNetwork()
		{
		}

		// Token: 0x06002891 RID: 10385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002891")]
		[Address(RVA = "0x2DAFBF0", Offset = "0x2DAEBF0", VA = "0x182DAFBF0")]
		public void UnregisterOnBrokenCallback(Action onBreak)
		{
		}

		// Token: 0x06002892 RID: 10386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002892")]
		[Address(RVA = "0x2DAEEB0", Offset = "0x2DADEB0", VA = "0x182DAEEB0")]
		public void RegisterOnBrokenCallback(Action onBreak)
		{
		}

		// Token: 0x06002893 RID: 10387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002893")]
		[Address(RVA = "0x2DAE950", Offset = "0x2DAD950", VA = "0x182DAE950")]
		private void OnImpact(IImpactSender sender, IImpactData impactData)
		{
		}

		// Token: 0x06002894 RID: 10388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002894")]
		[Address(RVA = "0x2DAFAF0", Offset = "0x2DAEAF0", VA = "0x182DAFAF0")]
		private void TestBreak()
		{
		}

		// Token: 0x06002895 RID: 10389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002895")]
		[Address(RVA = "0x2DADD70", Offset = "0x2DACD70", VA = "0x182DADD70")]
		private void OnBreak(IBreakSender breakSender, IImpactData impactData)
		{
		}

		// Token: 0x06002896 RID: 10390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002896")]
		[Address(RVA = "0x2DAF180", Offset = "0x2DAE180", VA = "0x182DAF180")]
		private void SpawnBreakFXPrefab(IImpactData impactData)
		{
		}

		// Token: 0x06002897 RID: 10391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002897")]
		[Address(RVA = "0x2DAD5A0", Offset = "0x2DAC5A0", VA = "0x182DAD5A0")]
		private void ApplyPhysicsHit(IImpactData impactData)
		{
		}

		// Token: 0x06002898 RID: 10392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002898")]
		[Address(RVA = "0x2DAF570", Offset = "0x2DAE570", VA = "0x182DAF570")]
		private void SpawnDrops(Vector3 hitVelocity)
		{
		}

		// Token: 0x06002899 RID: 10393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002899")]
		[Address(RVA = "0x2DAFC90", Offset = "0x2DAEC90", VA = "0x182DAFC90")]
		public void VirtualTriggerBreak()
		{
		}

		// Token: 0x0600289A RID: 10394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600289A")]
		[Address(RVA = "0x2DADBB0", Offset = "0x2DACBB0", VA = "0x182DADBB0")]
		public void HideOriginalObject()
		{
		}

		// Token: 0x0600289B RID: 10395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600289B")]
		[Address(RVA = "0x2DAF010", Offset = "0x2DAE010", VA = "0x182DAF010")]
		public void SetWorldObjectLocatorHolder(WorldObjectLocatorHolder source)
		{
		}

		// Token: 0x0600289C RID: 10396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600289C")]
		[Address(RVA = "0x2DAFD80", Offset = "0x2DAED80", VA = "0x182DAFD80")]
		public BreakableObject()
		{
		}

		// Token: 0x04002420 RID: 9248
		[Token(Token = "0x4002420")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _originalObject;

		// Token: 0x04002421 RID: 9249
		[Token(Token = "0x4002421")]
		[FieldOffset(Offset = "0x28")]
		[HideInInspector]
		[Obsolete]
		[SerializeField]
		private GameObject _brokenPrefab;

		// Token: 0x04002422 RID: 9250
		[Token(Token = "0x4002422")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _brokenShowObject;

		// Token: 0x04002423 RID: 9251
		[Token(Token = "0x4002423")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool _brokenTransformMatchOriginal;

		// Token: 0x04002424 RID: 9252
		[Token(Token = "0x4002424")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private DamageNode _damageNode;

		// Token: 0x04002425 RID: 9253
		[Token(Token = "0x4002425")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private bool _isStump;

		// Token: 0x04002426 RID: 9254
		[Token(Token = "0x4002426")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private DamageNode[] _extraDamageNodes;

		// Token: 0x04002427 RID: 9255
		[Token(Token = "0x4002427")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private string _forceTag;

		// Token: 0x04002428 RID: 9256
		[Token(Token = "0x4002428")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Rigidbody _rigidBody;

		// Token: 0x04002429 RID: 9257
		[Token(Token = "0x4002429")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _physicsHitMultiplier;

		// Token: 0x0400242A RID: 9258
		[Token(Token = "0x400242A")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private List<BreakableObject.SpawnDefinition> _spawnDefinitions;

		// Token: 0x0400242B RID: 9259
		[Token(Token = "0x400242B")]
		[FieldOffset(Offset = "0x78")]
		[HideInInspector]
		[SerializeField]
		private bool _converted;

		// Token: 0x0400242C RID: 9260
		[Token(Token = "0x400242C")]
		[FieldOffset(Offset = "0x7C")]
		[Obsolete]
		[SerializeField]
		[HideInInspector]
		private int _spawnCount;

		// Token: 0x0400242D RID: 9261
		[Token(Token = "0x400242D")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Obsolete]
		[HideInInspector]
		private GameObject _pickupPrefab;

		// Token: 0x0400242E RID: 9262
		[Token(Token = "0x400242E")]
		[FieldOffset(Offset = "0x88")]
		[Obsolete]
		[HideInInspector]
		[SerializeField]
		private Vector3 _rotation;

		// Token: 0x0400242F RID: 9263
		[Token(Token = "0x400242F")]
		[FieldOffset(Offset = "0x94")]
		[HideInInspector]
		[SerializeField]
		[Obsolete]
		private float _startHeightOffset;

		// Token: 0x04002430 RID: 9264
		[Token(Token = "0x4002430")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Obsolete]
		[HideInInspector]
		private bool _shouldStackSpawns;

		// Token: 0x04002431 RID: 9265
		[Token(Token = "0x4002431")]
		[FieldOffset(Offset = "0x9C")]
		[HideInInspector]
		[SerializeField]
		private float _stackHeightOffset;

		// Token: 0x04002432 RID: 9266
		[Token(Token = "0x4002432")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[FormerlySerializedAs("_breakPrefabSource")]
		private GameObject _breakFXPrefabSource;

		// Token: 0x04002433 RID: 9267
		[Token(Token = "0x4002433")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Vector3 _breakPrefabOffset;

		// Token: 0x04002434 RID: 9268
		[Token(Token = "0x4002434")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[EventRef]
		private string _hitEvent;

		// Token: 0x04002435 RID: 9269
		[Token(Token = "0x4002435")]
		[FieldOffset(Offset = "0xC0")]
		[EventRef]
		[SerializeField]
		private string _breakEvent;

		// Token: 0x04002436 RID: 9270
		[Token(Token = "0x4002436")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private VailAudioManager.Noise _breakNoiseStimuli;

		// Token: 0x04002437 RID: 9271
		[Token(Token = "0x4002437")]
		[FieldOffset(Offset = "0xD0")]
		[FormerlySerializedAs("OnBreak")]
		[FormerlySerializedAs("_unityEventOnBroken")]
		[SerializeField]
		private UnityEvent _unityEventOnBreak;

		// Token: 0x04002438 RID: 9272
		[Token(Token = "0x4002438")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[FormerlySerializedAs("OnBreak")]
		[FormerlySerializedAs("_unityEventOnBroken")]
		private UnityEvent _unityEventOnImpact;

		// Token: 0x04002439 RID: 9273
		[Token(Token = "0x4002439")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private WorldObjectLocatorHolder _worldObjectLocatorHolder;

		// Token: 0x0400243A RID: 9274
		[Token(Token = "0x400243A")]
		[FieldOffset(Offset = "0xE8")]
		private bool _isBroken;

		// Token: 0x0400243B RID: 9275
		[Token(Token = "0x400243B")]
		[FieldOffset(Offset = "0xE9")]
		private bool _isBurning;

		// Token: 0x0400243D RID: 9277
		[Token(Token = "0x400243D")]
		[FieldOffset(Offset = "0xF8")]
		private SyncBreakableObject _syncBreakableObject;

		// Token: 0x02000631 RID: 1585
		[Token(Token = "0x2000631")]
		[Serializable]
		public class SpawnDefinition
		{
			// Token: 0x0600289D RID: 10397 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600289D")]
			[Address(RVA = "0x57B1D0", Offset = "0x57A1D0", VA = "0x18057B1D0")]
			public GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x0600289E RID: 10398 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600289E")]
			[Address(RVA = "0x2DC3E50", Offset = "0x2DC2E50", VA = "0x182DC3E50")]
			public SpawnDefinition()
			{
			}

			// Token: 0x0600289F RID: 10399 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600289F")]
			[Address(RVA = "0x2DC3D90", Offset = "0x2DC2D90", VA = "0x182DC3D90")]
			public SpawnDefinition(int spawnCount, GameObject prefab, Vector3 rotation, float startHeightOffset, bool shouldStackSpawns, float stackHeightOffset, bool makeRigidBodyDynamic = true, bool copyOriginalObjectsScale = false)
			{
			}

			// Token: 0x060028A0 RID: 10400 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60028A0")]
			[Address(RVA = "0x2DC3AE0", Offset = "0x2DC2AE0", VA = "0x182DC3AE0")]
			public void SpawnDrops(Vector3 hitVelocity, Vector3 worldPosition, Quaternion parentWorldRotation, Vector3 scale)
			{
			}

			// Token: 0x060028A1 RID: 10401 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60028A1")]
			[Address(RVA = "0x2DC3750", Offset = "0x2DC2750", VA = "0x182DC3750")]
			private void AddExplosiveForceRigidBodies(Vector3 hitVelocity, GameObject newSpawn)
			{
			}

			// Token: 0x060028A2 RID: 10402 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60028A2")]
			[Address(RVA = "0x2DC39F0", Offset = "0x2DC29F0", VA = "0x182DC39F0")]
			private static void MakeRigidBodyDynamic(Vector3 hitVelocity, GameObject newSpawn)
			{
			}

			// Token: 0x0400243E RID: 9278
			[Token(Token = "0x400243E")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			internal int _spawnCount;

			// Token: 0x0400243F RID: 9279
			[Token(Token = "0x400243F")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			[FormerlySerializedAs("_pickupPrefab")]
			internal GameObject _prefab;

			// Token: 0x04002440 RID: 9280
			[Token(Token = "0x4002440")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			internal Vector3 _rotation;

			// Token: 0x04002441 RID: 9281
			[Token(Token = "0x4002441")]
			[FieldOffset(Offset = "0x2C")]
			[SerializeField]
			internal float _startHeightOffset;

			// Token: 0x04002442 RID: 9282
			[Token(Token = "0x4002442")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			internal bool _shouldStackSpawns;

			// Token: 0x04002443 RID: 9283
			[Token(Token = "0x4002443")]
			[FieldOffset(Offset = "0x34")]
			[SerializeField]
			internal float _stackHeightOffset;

			// Token: 0x04002444 RID: 9284
			[Token(Token = "0x4002444")]
			[FieldOffset(Offset = "0x38")]
			[SerializeField]
			internal bool _makeRigidBodyDynamic;

			// Token: 0x04002445 RID: 9285
			[Token(Token = "0x4002445")]
			[FieldOffset(Offset = "0x39")]
			[SerializeField]
			internal bool _copyOriginalObjectsScale;

			// Token: 0x04002446 RID: 9286
			[Token(Token = "0x4002446")]
			[FieldOffset(Offset = "0x3A")]
			[SerializeField]
			private bool _addExplosiveForceRigidBodies;

			// Token: 0x04002447 RID: 9287
			[Token(Token = "0x4002447")]
			[FieldOffset(Offset = "0x3C")]
			[SerializeField]
			private float _explosionForce;

			// Token: 0x04002448 RID: 9288
			[Token(Token = "0x4002448")]
			[FieldOffset(Offset = "0x40")]
			[SerializeField]
			private float _explosiveUpwardsModifier;
		}
	}
}
