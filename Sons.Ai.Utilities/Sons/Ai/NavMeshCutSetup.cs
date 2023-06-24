using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Pathfinding;
using UnityEngine;

namespace Sons.Ai
{
	// Token: 0x02000011 RID: 17
	[Token(Token = "0x2000011")]
	[AddComponentMenu("Sons/Ai/NavMesh Cut Setup")]
	public class NavMeshCutSetup : MonoBehaviour
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000061 RID: 97 RVA: 0x000024EC File Offset: 0x000006EC
		[Token(Token = "0x17000003")]
		public bool Baked
		{
			[Token(Token = "0x6000061")]
			[Address(RVA = "0x620AC0", Offset = "0x61F0C0", VA = "0x180620AC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x2A94B40", Offset = "0x2A93140", VA = "0x182A94B40")]
		private void Start()
		{
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x2A94D00", Offset = "0x2A93300", VA = "0x182A94D00")]
		public void Bake(Transform targetTr, float heightMargin = 0f)
		{
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x2A94F70", Offset = "0x2A93570", VA = "0x182A94F70")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x2A950B0", Offset = "0x2A936B0", VA = "0x182A950B0")]
		private void SetFromCollider()
		{
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002504 File Offset: 0x00000704
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x2A950E0", Offset = "0x2A936E0", VA = "0x182A950E0")]
		private bool ValidateSetup(Collider cutCollider)
		{
			return default(bool);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0000246E File Offset: 0x0000066E
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x2A95350", Offset = "0x2A93950", VA = "0x182A95350")]
		private static NavmeshCut GetOrAddNavMeshCut(Transform tr)
		{
			return null;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x0000246E File Offset: 0x0000066E
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x2A95490", Offset = "0x2A93A90", VA = "0x182A95490")]
		private static NavMeshCutSetup GetOrAddNavMeshCutSetup(Transform tr)
		{
			return null;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x2A955D0", Offset = "0x2A93BD0", VA = "0x182A955D0")]
		private static void TryRemoveNavMeshCutSetup(Transform tr)
		{
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0000246E File Offset: 0x0000066E
		[Token(Token = "0x600006A")]
		[Address(RVA = "0x2A956D0", Offset = "0x2A93CD0", VA = "0x182A956D0")]
		public static NavMeshCutSetup CreateFromTransformExtent(Transform ourTr, Transform tr, Vector3 extent, float extraHeight = 0.2f, float margin = 0.2f, bool checkTerrainDist = true, bool checkTerrainDistMinHeight = true)
		{
			return null;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0000246E File Offset: 0x0000066E
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x2A95C90", Offset = "0x2A94290", VA = "0x182A95C90")]
		public static NavMeshCutSetup CreateFromWorldPoints(Transform setupTr, Vector3 lengthAxis, Vector3[] points, float extraHeight = 0.2f, float margin = 0.2f, bool checkTerrainDist = true, bool checkTerrainDistMinHeight = true)
		{
			return null;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x0000251C File Offset: 0x0000071C
		[Token(Token = "0x600006C")]
		[Address(RVA = "0x2A96000", Offset = "0x2A94600", VA = "0x182A96000")]
		public static bool TryCreateFromWorldPoints(Transform cutTr, Vector3[] points, out NavmeshCut navCut, float extraHeight = 0.2f, float margin = 0.2f, bool checkTerrainDist = true, bool checkTerrainDistMinHeight = true)
		{
			return default(bool);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x2A965A0", Offset = "0x2A94BA0", VA = "0x182A965A0")]
		public void SetFromCapsuleCollider(NavmeshCut cut, CapsuleCollider capsuleCollider, float margin = 0.1f, float additionalHeight = 0.1f)
		{
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x2A968E0", Offset = "0x2A94EE0", VA = "0x182A968E0")]
		public void SetFromBoxCollider(BoxCollider boxCollider, float margin = 0f, float additionalHeight = 0f)
		{
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x2A96B40", Offset = "0x2A95140", VA = "0x182A96B40")]
		public void CreateNavMeshCut(NavmeshCut cut, Vector3 boxSize, [Optional] Vector3 boxCenter, float maxDepth = 0f)
		{
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x2A96DA0", Offset = "0x2A953A0", VA = "0x182A96DA0")]
		public void SetCutEnabled(bool value)
		{
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x2A96EC0", Offset = "0x2A954C0", VA = "0x182A96EC0")]
		public NavMeshCutSetup()
		{
		}

		// Token: 0x04000028 RID: 40
		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Nav mesh cutter from box collider will be adjusted down by max depth.")]
		public float _maxDepth;

		// Token: 0x04000029 RID: 41
		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool _cutEnabled;

		// Token: 0x0400002A RID: 42
		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private BoxCollider _boxCollider;

		// Token: 0x0400002B RID: 43
		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _baked;

		// Token: 0x0400002C RID: 44
		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private NavmeshCut _navmeshCut;

		// Token: 0x0400002D RID: 45
		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool _newCutTransform;

		// Token: 0x0400002E RID: 46
		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Vector3[] NavMeshPointsCache;

		// Token: 0x0400002F RID: 47
		[Token(Token = "0x400002F")]
		public const float MinDistAboveTerrain = 0.7f;

		// Token: 0x04000030 RID: 48
		[Token(Token = "0x4000030")]
		public const float MaxDistAboveTerrain = 2.2f;
	}
}
