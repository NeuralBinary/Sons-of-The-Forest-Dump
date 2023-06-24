using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Physics
{
	// Token: 0x0200000F RID: 15
	[Token(Token = "0x200000F")]
	public class Buoyancy : MonoBehaviour
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600003F RID: 63 RVA: 0x000021D4 File Offset: 0x000003D4
		[Token(Token = "0x17000004")]
		public bool InWater
		{
			[Token(Token = "0x600003F")]
			[Address(RVA = "0x30FB970", Offset = "0x30F9F70", VA = "0x1830FB970")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000040 RID: 64 RVA: 0x000021EC File Offset: 0x000003EC
		[Token(Token = "0x17000005")]
		public float WaterLevel
		{
			[Token(Token = "0x6000040")]
			[Address(RVA = "0x30FB9D0", Offset = "0x30F9FD0", VA = "0x1830FB9D0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000041 RID: 65 RVA: 0x00002204 File Offset: 0x00000404
		[Token(Token = "0x17000006")]
		public Vector3 WaterNormal
		{
			[Token(Token = "0x6000041")]
			[Address(RVA = "0x30FBA40", Offset = "0x30FA040", VA = "0x1830FBA40")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000042 RID: 66 RVA: 0x0000221A File Offset: 0x0000041A
		[Token(Token = "0x17000007")]
		public Collider WaterCollider
		{
			[Token(Token = "0x6000042")]
			[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000043 RID: 67 RVA: 0x00002220 File Offset: 0x00000420
		// (set) Token: 0x06000044 RID: 68 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000008")]
		public float LastWaterEnterSpeed
		{
			[Token(Token = "0x6000043")]
			[Address(RVA = "0x623B80", Offset = "0x622180", VA = "0x180623B80")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000044")]
			[Address(RVA = "0x623B90", Offset = "0x622190", VA = "0x180623B90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000045 RID: 69 RVA: 0x00002238 File Offset: 0x00000438
		// (set) Token: 0x06000046 RID: 70 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000009")]
		public bool IsImmersed
		{
			[Token(Token = "0x6000045")]
			[Address(RVA = "0x9DD210", Offset = "0x9DB810", VA = "0x1809DD210")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000046")]
			[Address(RVA = "0x9DD220", Offset = "0x9DB820", VA = "0x1809DD220")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002250 File Offset: 0x00000450
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x993BD0", Offset = "0x9921D0", VA = "0x180993BD0")]
		public bool GetIsOcean()
		{
			return default(bool);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x30FBAF0", Offset = "0x30FA0F0", VA = "0x1830FBAF0")]
		public void SetIgnoreOceanTriggers(bool value)
		{
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x620370", Offset = "0x61E970", VA = "0x180620370")]
		public void SetInCave(bool value)
		{
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x30FBB00", Offset = "0x30FA100", VA = "0x1830FBB00")]
		private void Awake()
		{
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x30FBC50", Offset = "0x30FA250", VA = "0x1830FBC50")]
		private void GetRigidBody()
		{
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x30FBD90", Offset = "0x30FA390", VA = "0x1830FBD90")]
		private void GetCollider()
		{
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x30FBED0", Offset = "0x30FA4D0", VA = "0x1830FBED0")]
		private void OnValidate()
		{
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x30FBEF0", Offset = "0x30FA4F0", VA = "0x1830FBEF0")]
		public void Voxelize()
		{
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x30FBF50", Offset = "0x30FA550", VA = "0x1830FBF50")]
		public void SingleVoxel()
		{
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x30FC640", Offset = "0x30FAC40", VA = "0x1830FC640")]
		public void Clear()
		{
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x30FC6A0", Offset = "0x30FACA0", VA = "0x1830FC6A0")]
		public void Voxelize(Transform collidersRoot, float minBoundsYOffset = 0f)
		{
		}

		// Token: 0x06000052 RID: 82 RVA: 0x0000221A File Offset: 0x0000041A
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x30FDA60", Offset = "0x30FC060", VA = "0x1830FDA60")]
		private List<Vector3> SliceIntoVoxels(Transform collidersRoot, List<Collider> colliders, Bounds bounds)
		{
			return null;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002268 File Offset: 0x00000468
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x30FE570", Offset = "0x30FCB70", VA = "0x1830FE570")]
		private static bool PointInsideMeshCollider(Collider c, Vector3 p)
		{
			return default(bool);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x30FE7F0", Offset = "0x30FCDF0", VA = "0x1830FE7F0")]
		private static void FindClosestPoints(IList<Vector3> list, out int firstIndex, out int secondIndex)
		{
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x30FE980", Offset = "0x30FCF80", VA = "0x1830FE980")]
		private static void WeldPoints(IList<Vector3> list, int targetCount)
		{
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x30FEFC0", Offset = "0x30FD5C0", VA = "0x1830FEFC0")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x30FF5B0", Offset = "0x30FDBB0", VA = "0x1830FF5B0")]
		private void CheckForIgnoreColliders(Collider other)
		{
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002280 File Offset: 0x00000480
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x30FF810", Offset = "0x30FDE10", VA = "0x1830FF810")]
		private bool MatchesTag(Collider other)
		{
			return default(bool);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x30FF850", Offset = "0x30FDE50", VA = "0x1830FF850")]
		private void OnTriggerExit(Collider other)
		{
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000221A File Offset: 0x0000041A
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x30FFBF0", Offset = "0x30FE1F0", VA = "0x1830FFBF0")]
		public IEnumerator ResetRigidbody()
		{
			return null;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x30FFC80", Offset = "0x30FE280", VA = "0x1830FFC80")]
		private void ValidateTriggers()
		{
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x31001F0", Offset = "0x30FE7F0", VA = "0x1831001F0")]
		private void FixedUpdate()
		{
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002298 File Offset: 0x00000498
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x3100890", Offset = "0x30FEE90", VA = "0x183100890")]
		private float RayCastHeight(Vector3 wp)
		{
			return 0f;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x3100ED0", Offset = "0x30FF4D0", VA = "0x183100ED0")]
		private void OnSpawned()
		{
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x3100EE0", Offset = "0x30FF4E0", VA = "0x183100EE0")]
		public Buoyancy()
		{
		}

		// Token: 0x0400004F RID: 79
		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x20")]
		public bool isPlayer;

		// Token: 0x04000050 RID: 80
		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x21")]
		public bool isPlayerNet;

		// Token: 0x04000051 RID: 81
		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x22")]
		public bool CheckPlayerDiving;

		// Token: 0x04000052 RID: 82
		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x23")]
		public bool ForceValidateTriggers;

		// Token: 0x04000053 RID: 83
		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool _skipChildren;

		// Token: 0x04000056 RID: 86
		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x30")]
		private List<Collider> _waterTriggers;

		// Token: 0x04000057 RID: 87
		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool _autoManageEnable;

		// Token: 0x04000058 RID: 88
		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x3C")]
		private int inWaterCounter;

		// Token: 0x04000059 RID: 89
		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x40")]
		private Collider _lastWaterCollider;

		// Token: 0x0400005A RID: 90
		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private bool _isOcean;

		// Token: 0x0400005B RID: 91
		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x49")]
		public bool ResetVelocityOnExitWater;

		// Token: 0x0400005C RID: 92
		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x4A")]
		public bool SkipAwakeVoxelise;

		// Token: 0x0400005D RID: 93
		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x4B")]
		[SerializeField]
		private bool _ignoreOceanTriggers;

		// Token: 0x0400005E RID: 94
		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x4C")]
		private bool _inCave;

		// Token: 0x0400005F RID: 95
		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x4D")]
		public bool DisableIfClient;

		// Token: 0x04000060 RID: 96
		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x4E")]
		[SerializeField]
		private bool _rayCastHeight;

		// Token: 0x04000061 RID: 97
		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x50")]
		public float density;

		// Token: 0x04000062 RID: 98
		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x54")]
		public int slicesPerAxis;

		// Token: 0x04000063 RID: 99
		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x58")]
		public int voxelsLimit;

		// Token: 0x04000064 RID: 100
		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x60")]
		public Transform OverrideCenterOfMass;

		// Token: 0x04000065 RID: 101
		[Token(Token = "0x4000065")]
		private const float DAMPFER = 0.15f;

		// Token: 0x04000066 RID: 102
		[Token(Token = "0x4000066")]
		private const float WATER_DENSITY = 1000f;

		// Token: 0x04000067 RID: 103
		[Token(Token = "0x4000067")]
		private const float DefaultWaterLevel = -99999f;

		// Token: 0x04000068 RID: 104
		[Token(Token = "0x4000068")]
		private const float DefaultGizmoSize = 0.05f;

		// Token: 0x04000069 RID: 105
		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0x68")]
		private float _lastWaterHeight;

		// Token: 0x0400006A RID: 106
		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0x6C")]
		private Vector3 _lastWaterNormal;

		// Token: 0x0400006B RID: 107
		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0x78")]
		[HideInInspector]
		public float voxelHalfHeight;

		// Token: 0x0400006C RID: 108
		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private bool _lockLocalArchimedesForce;

		// Token: 0x0400006D RID: 109
		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0x80")]
		[FormerlySerializedAs("localArchimedesForce")]
		[SerializeField]
		private Vector3 _localArchimedesForce;

		// Token: 0x0400006E RID: 110
		[Token(Token = "0x400006E")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private string _waterColliderTag;

		// Token: 0x0400006F RID: 111
		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Rigidbody _rigidBody;

		// Token: 0x04000070 RID: 112
		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Collider _collider;

		// Token: 0x04000071 RID: 113
		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private List<Collider> _ignoreColliders;

		// Token: 0x04000072 RID: 114
		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[FormerlySerializedAs("Voxels")]
		private Vector3[] _voxels;

		// Token: 0x04000073 RID: 115
		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0xB8")]
		private Rigidbody _cachedRigidbody;

		// Token: 0x04000074 RID: 116
		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private bool _overrideGizmos;

		// Token: 0x04000075 RID: 117
		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0xC4")]
		[SerializeField]
		private float _gizmoSize;

		// Token: 0x04000076 RID: 118
		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Vector3[] _directions;

		// Token: 0x04000077 RID: 119
		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private float _waterHeightCheck;
	}
}
