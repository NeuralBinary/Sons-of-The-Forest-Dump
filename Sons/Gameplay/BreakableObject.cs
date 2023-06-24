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
	// Token: 0x0200074C RID: 1868
	[Token(Token = "0x200074C")]
	[AddComponentMenu("Sons/Gameplay/BreakableObject")]
	public class BreakableObject : MonoBehaviour
	{
		// Token: 0x14000021 RID: 33
		// (add) Token: 0x06003250 RID: 12880 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06003251 RID: 12881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000021")]
		private event Action _onBrokenCallback
		{
			[Token(Token = "0x6003250")]
			[Address(RVA = "0x349C3F0", Offset = "0x349A9F0", VA = "0x18349C3F0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003251")]
			[Address(RVA = "0x349C4E0", Offset = "0x349AAE0", VA = "0x18349C4E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x06003252 RID: 12882 RVA: 0x0000F348 File Offset: 0x0000D548
		[Token(Token = "0x17000684")]
		private bool HasBrokenChild
		{
			[Token(Token = "0x6003252")]
			[Address(RVA = "0x349C5D0", Offset = "0x349ABD0", VA = "0x18349C5D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x06003253 RID: 12883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000685")]
		public GameObject OriginalObject
		{
			[Token(Token = "0x6003253")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x06003254 RID: 12884 RVA: 0x0000F360 File Offset: 0x0000D560
		[Token(Token = "0x17000686")]
		public bool IsBroken
		{
			[Token(Token = "0x6003254")]
			[Address(RVA = "0xA03DE0", Offset = "0xA023E0", VA = "0x180A03DE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003255 RID: 12885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003255")]
		[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
		public void SetOriginalObject(GameObject root)
		{
		}

		// Token: 0x06003256 RID: 12886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003256")]
		[Address(RVA = "0x349C690", Offset = "0x349AC90", VA = "0x18349C690")]
		public void SetHitBreakSounds(string hitEvent, string breakEvent)
		{
		}

		// Token: 0x06003257 RID: 12887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003257")]
		[Address(RVA = "0x349C740", Offset = "0x349AD40", VA = "0x18349C740")]
		public void SetBreakHealth(float breakHealth)
		{
		}

		// Token: 0x06003258 RID: 12888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003258")]
		[Address(RVA = "0x6306D0", Offset = "0x62ECD0", VA = "0x1806306D0")]
		public List<BreakableObject.SpawnDefinition> GetSpawnDefinitions()
		{
			return null;
		}

		// Token: 0x06003259 RID: 12889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003259")]
		[Address(RVA = "0x349C760", Offset = "0x349AD60", VA = "0x18349C760")]
		private void Awake()
		{
		}

		// Token: 0x0600325A RID: 12890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600325A")]
		[Address(RVA = "0x349C830", Offset = "0x349AE30", VA = "0x18349C830")]
		private void OnValidate()
		{
		}

		// Token: 0x0600325B RID: 12891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600325B")]
		[Address(RVA = "0x349CEB0", Offset = "0x349B4B0", VA = "0x18349CEB0")]
		public void OnEnable()
		{
		}

		// Token: 0x0600325C RID: 12892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600325C")]
		[Address(RVA = "0x349D230", Offset = "0x349B830", VA = "0x18349D230")]
		private void InitializeWorldObjectLocatorHolder()
		{
		}

		// Token: 0x0600325D RID: 12893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600325D")]
		[Address(RVA = "0x349D420", Offset = "0x349BA20", VA = "0x18349D420")]
		public void OnDisable()
		{
		}

		// Token: 0x0600325E RID: 12894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600325E")]
		[Address(RVA = "0x349D610", Offset = "0x349BC10", VA = "0x18349D610")]
		private void OnWorldObjectLocatorStateChanged(WorldObjectState state, bool fromSave)
		{
		}

		// Token: 0x0600325F RID: 12895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600325F")]
		[Address(RVA = "0x349D710", Offset = "0x349BD10", VA = "0x18349D710")]
		private void SetBrokenWorldObjectState()
		{
		}

		// Token: 0x06003260 RID: 12896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003260")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void RegisterCheckConvert()
		{
		}

		// Token: 0x06003261 RID: 12897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003261")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void UnregisterCheckConvert()
		{
		}

		// Token: 0x06003262 RID: 12898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003262")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void OnDestroy()
		{
		}

		// Token: 0x06003263 RID: 12899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003263")]
		[Address(RVA = "0x349D790", Offset = "0x349BD90", VA = "0x18349D790")]
		private void CheckForConvert()
		{
		}

		// Token: 0x06003264 RID: 12900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003264")]
		[Address(RVA = "0x349DD40", Offset = "0x349C340", VA = "0x18349DD40")]
		private void Start()
		{
		}

		// Token: 0x06003265 RID: 12901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003265")]
		[Address(RVA = "0x349E1C0", Offset = "0x349C7C0", VA = "0x18349E1C0")]
		public void OnBrokenViaNetwork()
		{
		}

		// Token: 0x06003266 RID: 12902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003266")]
		[Address(RVA = "0x349C4E0", Offset = "0x349AAE0", VA = "0x18349C4E0")]
		public void UnregisterOnBrokenCallback(Action onBreak)
		{
		}

		// Token: 0x06003267 RID: 12903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003267")]
		[Address(RVA = "0x349C3F0", Offset = "0x349A9F0", VA = "0x18349C3F0")]
		public void RegisterOnBrokenCallback(Action onBreak)
		{
		}

		// Token: 0x06003268 RID: 12904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003268")]
		[Address(RVA = "0x349E2F0", Offset = "0x349C8F0", VA = "0x18349E2F0")]
		private void OnImpact(IImpactSender sender, IImpactData impactData)
		{
		}

		// Token: 0x06003269 RID: 12905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003269")]
		[Address(RVA = "0x349E5F0", Offset = "0x349CBF0", VA = "0x18349E5F0")]
		private void TestBreak()
		{
		}

		// Token: 0x0600326A RID: 12906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600326A")]
		[Address(RVA = "0x349E6E0", Offset = "0x349CCE0", VA = "0x18349E6E0")]
		private void OnBreak(IBreakSender breakSender, IImpactData impactData)
		{
		}

		// Token: 0x0600326B RID: 12907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600326B")]
		[Address(RVA = "0x349F6D0", Offset = "0x349DCD0", VA = "0x18349F6D0")]
		private void SpawnBreakFXPrefab(IImpactData impactData)
		{
		}

		// Token: 0x0600326C RID: 12908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600326C")]
		[Address(RVA = "0x349FE90", Offset = "0x349E490", VA = "0x18349FE90")]
		private void ApplyPhysicsHit(IImpactData impactData)
		{
		}

		// Token: 0x0600326D RID: 12909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600326D")]
		[Address(RVA = "0x34A0220", Offset = "0x349E820", VA = "0x1834A0220")]
		private void SpawnDrops(Vector3 hitVelocity)
		{
		}

		// Token: 0x0600326E RID: 12910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600326E")]
		[Address(RVA = "0x34A05F0", Offset = "0x349EBF0", VA = "0x1834A05F0")]
		public void VirtualTriggerBreak()
		{
		}

		// Token: 0x0600326F RID: 12911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600326F")]
		[Address(RVA = "0x34A0710", Offset = "0x349ED10", VA = "0x1834A0710")]
		public void HideOriginalObject()
		{
		}

		// Token: 0x06003270 RID: 12912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003270")]
		[Address(RVA = "0x34A0820", Offset = "0x349EE20", VA = "0x1834A0820")]
		public void SetWorldObjectLocatorHolder(WorldObjectLocatorHolder source)
		{
		}

		// Token: 0x06003271 RID: 12913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003271")]
		[Address(RVA = "0x34A0A80", Offset = "0x349F080", VA = "0x1834A0A80")]
		public BreakableObject()
		{
		}

		// Token: 0x04002B5E RID: 11102
		[Token(Token = "0x4002B5E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _originalObject;

		// Token: 0x04002B5F RID: 11103
		[Token(Token = "0x4002B5F")]
		[FieldOffset(Offset = "0x28")]
		[HideInInspector]
		[SerializeField]
		[Obsolete]
		private GameObject _brokenPrefab;

		// Token: 0x04002B60 RID: 11104
		[Token(Token = "0x4002B60")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _brokenShowObject;

		// Token: 0x04002B61 RID: 11105
		[Token(Token = "0x4002B61")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool _brokenTransformMatchOriginal;

		// Token: 0x04002B62 RID: 11106
		[Token(Token = "0x4002B62")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private DamageNode _damageNode;

		// Token: 0x04002B63 RID: 11107
		[Token(Token = "0x4002B63")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private bool _isStump;

		// Token: 0x04002B64 RID: 11108
		[Token(Token = "0x4002B64")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject[] _destroyObjects;

		// Token: 0x04002B65 RID: 11109
		[Token(Token = "0x4002B65")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private DamageNode[] _extraDamageNodes;

		// Token: 0x04002B66 RID: 11110
		[Token(Token = "0x4002B66")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private string _forceTag;

		// Token: 0x04002B67 RID: 11111
		[Token(Token = "0x4002B67")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Rigidbody _rigidBody;

		// Token: 0x04002B68 RID: 11112
		[Token(Token = "0x4002B68")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float _physicsHitMultiplier;

		// Token: 0x04002B69 RID: 11113
		[Token(Token = "0x4002B69")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private List<BreakableObject.SpawnDefinition> _spawnDefinitions;

		// Token: 0x04002B6A RID: 11114
		[Token(Token = "0x4002B6A")]
		[FieldOffset(Offset = "0x80")]
		[HideInInspector]
		[SerializeField]
		private bool _converted;

		// Token: 0x04002B6B RID: 11115
		[Token(Token = "0x4002B6B")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		[Obsolete]
		[HideInInspector]
		private int _spawnCount;

		// Token: 0x04002B6C RID: 11116
		[Token(Token = "0x4002B6C")]
		[FieldOffset(Offset = "0x88")]
		[HideInInspector]
		[SerializeField]
		[Obsolete]
		private GameObject _pickupPrefab;

		// Token: 0x04002B6D RID: 11117
		[Token(Token = "0x4002B6D")]
		[FieldOffset(Offset = "0x90")]
		[HideInInspector]
		[SerializeField]
		[Obsolete]
		private Vector3 _rotation;

		// Token: 0x04002B6E RID: 11118
		[Token(Token = "0x4002B6E")]
		[FieldOffset(Offset = "0x9C")]
		[HideInInspector]
		[Obsolete]
		[SerializeField]
		private float _startHeightOffset;

		// Token: 0x04002B6F RID: 11119
		[Token(Token = "0x4002B6F")]
		[FieldOffset(Offset = "0xA0")]
		[HideInInspector]
		[Obsolete]
		[SerializeField]
		private bool _shouldStackSpawns;

		// Token: 0x04002B70 RID: 11120
		[Token(Token = "0x4002B70")]
		[FieldOffset(Offset = "0xA4")]
		[HideInInspector]
		[SerializeField]
		private float _stackHeightOffset;

		// Token: 0x04002B71 RID: 11121
		[Token(Token = "0x4002B71")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[FormerlySerializedAs("_breakPrefabSource")]
		private GameObject _breakFXPrefabSource;

		// Token: 0x04002B72 RID: 11122
		[Token(Token = "0x4002B72")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Vector3 _breakPrefabOffset;

		// Token: 0x04002B73 RID: 11123
		[Token(Token = "0x4002B73")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[EventRef]
		private string _hitEvent;

		// Token: 0x04002B74 RID: 11124
		[Token(Token = "0x4002B74")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[EventRef]
		private string _breakEvent;

		// Token: 0x04002B75 RID: 11125
		[Token(Token = "0x4002B75")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private VailAudioManager.Noise _breakNoiseStimuli;

		// Token: 0x04002B76 RID: 11126
		[Token(Token = "0x4002B76")]
		[FieldOffset(Offset = "0xD8")]
		[FormerlySerializedAs("OnBreak")]
		[FormerlySerializedAs("_unityEventOnBroken")]
		[SerializeField]
		private UnityEvent _unityEventOnBreak;

		// Token: 0x04002B77 RID: 11127
		[Token(Token = "0x4002B77")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[FormerlySerializedAs("OnBreak")]
		[FormerlySerializedAs("_unityEventOnBroken")]
		private UnityEvent _unityEventOnImpact;

		// Token: 0x04002B78 RID: 11128
		[Token(Token = "0x4002B78")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private WorldObjectLocatorHolder _worldObjectLocatorHolder;

		// Token: 0x04002B79 RID: 11129
		[Token(Token = "0x4002B79")]
		[FieldOffset(Offset = "0xF0")]
		private bool _isBroken;

		// Token: 0x04002B7A RID: 11130
		[Token(Token = "0x4002B7A")]
		[FieldOffset(Offset = "0xF1")]
		private bool _isBurning;

		// Token: 0x04002B7C RID: 11132
		[Token(Token = "0x4002B7C")]
		[FieldOffset(Offset = "0x100")]
		private SyncBreakableObject _syncBreakableObject;

		// Token: 0x0200074D RID: 1869
		[Token(Token = "0x200074D")]
		[Serializable]
		public class SpawnDefinition
		{
			// Token: 0x06003272 RID: 12914 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003272")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			public GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x06003273 RID: 12915 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003273")]
			[Address(RVA = "0x34A0C10", Offset = "0x349F210", VA = "0x1834A0C10")]
			public SpawnDefinition()
			{
			}

			// Token: 0x06003274 RID: 12916 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003274")]
			[Address(RVA = "0x34A0C40", Offset = "0x349F240", VA = "0x1834A0C40")]
			public SpawnDefinition(int spawnCount, GameObject prefab, Vector3 rotation, float startHeightOffset, bool shouldStackSpawns, float stackHeightOffset, bool makeRigidBodyDynamic = true, bool copyOriginalObjectsScale = false)
			{
			}

			// Token: 0x06003275 RID: 12917 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003275")]
			[Address(RVA = "0x34A0D00", Offset = "0x349F300", VA = "0x1834A0D00")]
			public void SpawnDrops(Vector3 hitVelocity, Vector3 worldPosition, Quaternion parentWorldRotation, Vector3 scale)
			{
			}

			// Token: 0x06003276 RID: 12918 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003276")]
			[Address(RVA = "0x34A1780", Offset = "0x349FD80", VA = "0x1834A1780")]
			private void AddExplosiveForceRigidBodies(Vector3 hitVelocity, GameObject newSpawn)
			{
			}

			// Token: 0x06003277 RID: 12919 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003277")]
			[Address(RVA = "0x34A1C30", Offset = "0x34A0230", VA = "0x1834A1C30")]
			private static void MakeRigidBodyDynamic(Vector3 hitVelocity, GameObject newSpawn)
			{
			}

			// Token: 0x04002B7D RID: 11133
			[Token(Token = "0x4002B7D")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			internal int _spawnCount;

			// Token: 0x04002B7E RID: 11134
			[Token(Token = "0x4002B7E")]
			[FieldOffset(Offset = "0x18")]
			[FormerlySerializedAs("_pickupPrefab")]
			[SerializeField]
			internal GameObject _prefab;

			// Token: 0x04002B7F RID: 11135
			[Token(Token = "0x4002B7F")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			internal Vector3 _rotation;

			// Token: 0x04002B80 RID: 11136
			[Token(Token = "0x4002B80")]
			[FieldOffset(Offset = "0x2C")]
			[SerializeField]
			internal float _startHeightOffset;

			// Token: 0x04002B81 RID: 11137
			[Token(Token = "0x4002B81")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			internal bool _shouldStackSpawns;

			// Token: 0x04002B82 RID: 11138
			[Token(Token = "0x4002B82")]
			[FieldOffset(Offset = "0x34")]
			[SerializeField]
			internal float _stackHeightOffset;

			// Token: 0x04002B83 RID: 11139
			[Token(Token = "0x4002B83")]
			[FieldOffset(Offset = "0x38")]
			[SerializeField]
			internal bool _makeRigidBodyDynamic;

			// Token: 0x04002B84 RID: 11140
			[Token(Token = "0x4002B84")]
			[FieldOffset(Offset = "0x39")]
			[SerializeField]
			internal bool _copyOriginalObjectsScale;

			// Token: 0x04002B85 RID: 11141
			[Token(Token = "0x4002B85")]
			[FieldOffset(Offset = "0x3A")]
			[SerializeField]
			private bool _addExplosiveForceRigidBodies;

			// Token: 0x04002B86 RID: 11142
			[Token(Token = "0x4002B86")]
			[FieldOffset(Offset = "0x3C")]
			[SerializeField]
			private float _explosionForce;

			// Token: 0x04002B87 RID: 11143
			[Token(Token = "0x4002B87")]
			[FieldOffset(Offset = "0x40")]
			[SerializeField]
			private float _explosiveUpwardsModifier;
		}
	}
}
