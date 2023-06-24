using System;
using System.Collections.Generic;
using Endnight.Types;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Environment.Digging.TerrainDig
{
	// Token: 0x02000047 RID: 71
	[Token(Token = "0x2000047")]
	[AddComponentMenu("Sons/Environment/Digging/TerrainDigManager")]
	public class TerrainDigManager : SingletonBehaviour<TerrainDigManager>
	{
		// Token: 0x060001EF RID: 495 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x2FC0520", Offset = "0x2FBEB20", VA = "0x182FC0520")]
		private void Update()
		{
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x2FC0660", Offset = "0x2FBEC60", VA = "0x182FC0660")]
		public void RegisterLocation(TerrainDigNode node)
		{
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x2FC0860", Offset = "0x2FBEE60", VA = "0x182FC0860")]
		private void RemoveOldestTemporaryNode()
		{
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x2FC0A60", Offset = "0x2FBF060", VA = "0x182FC0A60")]
		private void AddToDigDetectionAreas(TerrainDigNode node)
		{
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x000028DC File Offset: 0x00000ADC
		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x2FC0C80", Offset = "0x2FBF280", VA = "0x182FC0C80")]
		private bool IsInDigThroughArea(TerrainDigNode node)
		{
			return default(bool);
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x2FC0EA0", Offset = "0x2FBF4A0", VA = "0x182FC0EA0")]
		private void AddToClusters(TerrainDigNode node)
		{
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x2FC1090", Offset = "0x2FBF690", VA = "0x182FC1090")]
		private void UpdateClusterObjects(int index)
		{
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x2FC16D0", Offset = "0x2FBFCD0", VA = "0x182FC16D0")]
		private static void InitializeTerrainCollider(Vector3 meshPosition, TerrainDigCollision terrainDigCollision)
		{
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x2FC18B0", Offset = "0x2FBFEB0", VA = "0x182FC18B0")]
		private static void UpdateSwitchCollider(Bounds bounds, BoxCollider boxCollider, float nodeSize)
		{
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x2FC1A40", Offset = "0x2FC0040", VA = "0x182FC1A40")]
		private void SetupNewCluster(ref List<TerrainDigCluster> foundClusters)
		{
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x2FC2140", Offset = "0x2FC0740", VA = "0x182FC2140")]
		private void MergeClusters(List<TerrainDigCluster> foundClusters)
		{
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x2FC2400", Offset = "0x2FC0A00", VA = "0x182FC2400")]
		private void RemoveCluster(TerrainDigCluster foundCluster)
		{
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x2FC2530", Offset = "0x2FC0B30", VA = "0x182FC2530")]
		private List<TerrainDigCluster> FindClusters(TerrainDigNode node)
		{
			return null;
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x2FC2700", Offset = "0x2FC0D00", VA = "0x182FC2700")]
		public void UnregisterLocation(TerrainDigNode node)
		{
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x2FC2780", Offset = "0x2FC0D80", VA = "0x182FC2780")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x2FC28C0", Offset = "0x2FC0EC0", VA = "0x182FC28C0")]
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x2FC2A00", Offset = "0x2FC1000", VA = "0x182FC2A00")]
		public void UpdateNodePositionNormal(TerrainDigNode node)
		{
		}

		// Token: 0x06000200 RID: 512 RVA: 0x000028F4 File Offset: 0x00000AF4
		[Token(Token = "0x6000200")]
		[Address(RVA = "0x2FC2CC0", Offset = "0x2FC12C0", VA = "0x182FC2CC0")]
		private static Vector3 SnapPosition(Vector3 transformPosition, Vector3 positionalSnap)
		{
			return default(Vector3);
		}

		// Token: 0x06000201 RID: 513 RVA: 0x0000290C File Offset: 0x00000B0C
		[Token(Token = "0x6000201")]
		[Address(RVA = "0x26F9A60", Offset = "0x26F8060", VA = "0x1826F9A60")]
		private static float Snap(float value, float snap)
		{
			return 0f;
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x6000202")]
		[Address(RVA = "0x2DC3B50", Offset = "0x2DC2150", VA = "0x182DC3B50")]
		public GameObject GetInstanceParent()
		{
			return null;
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000203")]
		[Address(RVA = "0x2FC2D60", Offset = "0x2FC1360", VA = "0x182FC2D60")]
		public void RegisterDigThroughArea(TerrainDigThroughArea source)
		{
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000204")]
		[Address(RVA = "0x2FC2E70", Offset = "0x2FC1470", VA = "0x182FC2E70")]
		public void UnregisterDigThroughArea(TerrainDigThroughArea source)
		{
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000205")]
		[Address(RVA = "0x2FC2EE0", Offset = "0x2FC14E0", VA = "0x182FC2EE0")]
		public void RegisterDigDetectionArea(TerrainDigDetectionArea source)
		{
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000206")]
		[Address(RVA = "0x2FC2FF0", Offset = "0x2FC15F0", VA = "0x182FC2FF0")]
		public void UnregisterDigDetectionArea(TerrainDigDetectionArea source)
		{
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000207")]
		[Address(RVA = "0x2FC3060", Offset = "0x2FC1660", VA = "0x182FC3060")]
		public void RegisterAttackOverrideArea(ShovelAttackOverrideArea source)
		{
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000208")]
		[Address(RVA = "0x2FC3170", Offset = "0x2FC1770", VA = "0x182FC3170")]
		public void UnregisterAttackOverrideArea(ShovelAttackOverrideArea source)
		{
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00002924 File Offset: 0x00000B24
		[Token(Token = "0x6000209")]
		[Address(RVA = "0x2FC31E0", Offset = "0x2FC17E0", VA = "0x182FC31E0")]
		public bool IsShovelAttackOverrideArea(Vector3 point)
		{
			return default(bool);
		}

		// Token: 0x0600020A RID: 522 RVA: 0x0000293C File Offset: 0x00000B3C
		[Token(Token = "0x600020A")]
		[Address(RVA = "0x2FC3400", Offset = "0x2FC1A00", VA = "0x182FC3400")]
		public bool IsBlocked(Vector3 point)
		{
			return default(bool);
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600020B")]
		[Address(RVA = "0x2FC35F0", Offset = "0x2FC1BF0", VA = "0x182FC35F0")]
		public static void RegisterOnNodeAdded(Action<TerrainDigNode> onNodeAdded)
		{
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600020C")]
		[Address(RVA = "0x2FC3720", Offset = "0x2FC1D20", VA = "0x182FC3720")]
		public static void UnregisterOnNodeAdded(Action<TerrainDigNode> onNodeAdded)
		{
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600020D")]
		[Address(RVA = "0x2FC3850", Offset = "0x2FC1E50", VA = "0x182FC3850")]
		public TerrainDigManager()
		{
		}

		// Token: 0x040001FB RID: 507
		[Token(Token = "0x40001FB")]
		private const string DynamicMeshColliderName = "DynamicMeshCollider";

		// Token: 0x040001FC RID: 508
		[Token(Token = "0x40001FC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int _maxTemporaryNodes;

		// Token: 0x040001FD RID: 509
		[Token(Token = "0x40001FD")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Vector3 _positionalSnap;

		// Token: 0x040001FE RID: 510
		[Token(Token = "0x40001FE")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _colliderSwitcherSource;

		// Token: 0x040001FF RID: 511
		[Token(Token = "0x40001FF")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _nodeSize;

		// Token: 0x04000200 RID: 512
		[Token(Token = "0x4000200")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float[] _nodeDepths;

		// Token: 0x04000201 RID: 513
		[Token(Token = "0x4000201")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _mergeThreshold;

		// Token: 0x04000202 RID: 514
		[Token(Token = "0x4000202")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float _mergeSecondaryThreshold;

		// Token: 0x04000203 RID: 515
		[Token(Token = "0x4000203")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private List<Vector3> _locations;

		// Token: 0x04000204 RID: 516
		[Token(Token = "0x4000204")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private List<Quaternion> _orientations;

		// Token: 0x04000205 RID: 517
		[Token(Token = "0x4000205")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private List<TerrainDigNode> _nodes;

		// Token: 0x04000206 RID: 518
		[Token(Token = "0x4000206")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private List<TerrainDigCluster> _clusters;

		// Token: 0x04000207 RID: 519
		[Token(Token = "0x4000207")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private List<ClusterObjectRefs> _clusterObjectRefs;

		// Token: 0x04000208 RID: 520
		[Token(Token = "0x4000208")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Material _debugMeshMaterial;

		// Token: 0x04000209 RID: 521
		[Token(Token = "0x4000209")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private float _debugMeshOffset;

		// Token: 0x0400020A RID: 522
		[Token(Token = "0x400020A")]
		[FieldOffset(Offset = "0x8C")]
		[SerializeField]
		private bool _debugVisual;

		// Token: 0x0400020B RID: 523
		[Token(Token = "0x400020B")]
		[FieldOffset(Offset = "0x90")]
		private List<TerrainDigThroughArea> _terrainDigThroughAreas;

		// Token: 0x0400020C RID: 524
		[Token(Token = "0x400020C")]
		[FieldOffset(Offset = "0x98")]
		private List<TerrainDigDetectionArea> _terrainDigDetectionAreas;

		// Token: 0x0400020D RID: 525
		[Token(Token = "0x400020D")]
		[FieldOffset(Offset = "0xA0")]
		private List<ShovelAttackOverrideArea> _shovelAttackOverrideAreas;

		// Token: 0x0400020E RID: 526
		[Token(Token = "0x400020E")]
		[FieldOffset(Offset = "0xA8")]
		private Action<TerrainDigNode> _onNodeAdded;

		// Token: 0x0400020F RID: 527
		[Token(Token = "0x400020F")]
		[FieldOffset(Offset = "0xB0")]
		private int _temporaryNodeCount;
	}
}
