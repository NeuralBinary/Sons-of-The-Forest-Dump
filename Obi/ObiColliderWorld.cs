using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x02000158 RID: 344
	[Token(Token = "0x2000158")]
	[ExecuteInEditMode]
	public class ObiColliderWorld
	{
		// Token: 0x060006C5 RID: 1733 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x27CABB0", Offset = "0x27C91B0", VA = "0x1827CABB0")]
		public static ObiColliderWorld GetInstance()
		{
			return null;
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x27CAC90", Offset = "0x27C9290", VA = "0x1827CAC90")]
		private void Initialize()
		{
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x27CB3F0", Offset = "0x27C99F0", VA = "0x1827CB3F0")]
		private void Destroy()
		{
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x27CBE50", Offset = "0x27CA450", VA = "0x1827CBE50")]
		private void DestroyIfUnused()
		{
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x27CBEF0", Offset = "0x27CA4F0", VA = "0x1827CBEF0")]
		public void RegisterImplementation(IColliderWorldImpl impl)
		{
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x27CBFF0", Offset = "0x27CA5F0", VA = "0x1827CBFF0")]
		public void UnregisterImplementation(IColliderWorldImpl impl)
		{
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x27CC050", Offset = "0x27CA650", VA = "0x1827CC050")]
		public ObiColliderHandle CreateCollider()
		{
			return null;
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x27CC2C0", Offset = "0x27CA8C0", VA = "0x1827CC2C0")]
		public ObiRigidbodyHandle CreateRigidbody()
		{
			return null;
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x27CC430", Offset = "0x27CAA30", VA = "0x1827CC430")]
		public ObiCollisionMaterialHandle CreateCollisionMaterial()
		{
			return null;
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x27CC5A0", Offset = "0x27CABA0", VA = "0x1827CC5A0")]
		public ObiTriangleMeshHandle GetOrCreateTriangleMesh(Mesh mesh)
		{
			return null;
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x27CC5C0", Offset = "0x27CABC0", VA = "0x1827CC5C0")]
		public void DestroyTriangleMesh(ObiTriangleMeshHandle meshHandle)
		{
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x27CC5E0", Offset = "0x27CABE0", VA = "0x1827CC5E0")]
		public ObiEdgeMeshHandle GetOrCreateEdgeMesh(EdgeCollider2D collider)
		{
			return null;
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x27CC600", Offset = "0x27CAC00", VA = "0x1827CC600")]
		public void DestroyEdgeMesh(ObiEdgeMeshHandle meshHandle)
		{
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x27CC620", Offset = "0x27CAC20", VA = "0x1827CC620")]
		public ObiDistanceFieldHandle GetOrCreateDistanceField(ObiDistanceField df)
		{
			return null;
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x27CC640", Offset = "0x27CAC40", VA = "0x1827CC640")]
		public void DestroyDistanceField(ObiDistanceFieldHandle dfHandle)
		{
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x27CC660", Offset = "0x27CAC60", VA = "0x1827CC660")]
		public ObiHeightFieldHandle GetOrCreateHeightField(TerrainData hf)
		{
			return null;
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x27CC680", Offset = "0x27CAC80", VA = "0x1827CC680")]
		public void DestroyHeightField(ObiHeightFieldHandle hfHandle)
		{
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x27CC6A0", Offset = "0x27CACA0", VA = "0x1827CC6A0")]
		public void DestroyCollider(ObiColliderHandle handle)
		{
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x27CCBB0", Offset = "0x27CB1B0", VA = "0x1827CCBB0")]
		public void DestroyRigidbody(ObiRigidbodyHandle handle)
		{
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x27CCF50", Offset = "0x27CB550", VA = "0x1827CCF50")]
		public void DestroyCollisionMaterial(ObiCollisionMaterialHandle handle)
		{
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x27CD220", Offset = "0x27CB820", VA = "0x1827CD220")]
		public void UpdateColliders()
		{
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x27CD410", Offset = "0x27CBA10", VA = "0x1827CD410")]
		public void UpdateRigidbodies(List<ObiSolver> solvers, float stepTime)
		{
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x27CD750", Offset = "0x27CBD50", VA = "0x1827CD750")]
		public void UpdateWorld(float deltaTime)
		{
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x27CDAC0", Offset = "0x27CC0C0", VA = "0x1827CDAC0")]
		public void UpdateRigidbodyVelocities(List<ObiSolver> solvers)
		{
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public ObiColliderWorld()
		{
		}

		// Token: 0x040005BB RID: 1467
		[Token(Token = "0x40005BB")]
		[FieldOffset(Offset = "0x10")]
		[NonSerialized]
		public List<IColliderWorldImpl> implementations;

		// Token: 0x040005BC RID: 1468
		[Token(Token = "0x40005BC")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public List<ObiColliderHandle> colliderHandles;

		// Token: 0x040005BD RID: 1469
		[Token(Token = "0x40005BD")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public ObiNativeColliderShapeList colliderShapes;

		// Token: 0x040005BE RID: 1470
		[Token(Token = "0x40005BE")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		public ObiNativeAabbList colliderAabbs;

		// Token: 0x040005BF RID: 1471
		[Token(Token = "0x40005BF")]
		[FieldOffset(Offset = "0x30")]
		[NonSerialized]
		public ObiNativeAffineTransformList colliderTransforms;

		// Token: 0x040005C0 RID: 1472
		[Token(Token = "0x40005C0")]
		[FieldOffset(Offset = "0x38")]
		[NonSerialized]
		public List<ObiCollisionMaterialHandle> materialHandles;

		// Token: 0x040005C1 RID: 1473
		[Token(Token = "0x40005C1")]
		[FieldOffset(Offset = "0x40")]
		[NonSerialized]
		public ObiNativeCollisionMaterialList collisionMaterials;

		// Token: 0x040005C2 RID: 1474
		[Token(Token = "0x40005C2")]
		[FieldOffset(Offset = "0x48")]
		[NonSerialized]
		public List<ObiRigidbodyHandle> rigidbodyHandles;

		// Token: 0x040005C3 RID: 1475
		[Token(Token = "0x40005C3")]
		[FieldOffset(Offset = "0x50")]
		[NonSerialized]
		public ObiNativeRigidbodyList rigidbodies;

		// Token: 0x040005C4 RID: 1476
		[Token(Token = "0x40005C4")]
		[FieldOffset(Offset = "0x58")]
		[NonSerialized]
		public ObiTriangleMeshContainer triangleMeshContainer;

		// Token: 0x040005C5 RID: 1477
		[Token(Token = "0x40005C5")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		public ObiEdgeMeshContainer edgeMeshContainer;

		// Token: 0x040005C6 RID: 1478
		[Token(Token = "0x40005C6")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		public ObiDistanceFieldContainer distanceFieldContainer;

		// Token: 0x040005C7 RID: 1479
		[Token(Token = "0x40005C7")]
		[FieldOffset(Offset = "0x70")]
		[NonSerialized]
		public ObiHeightFieldContainer heightFieldContainer;

		// Token: 0x040005C8 RID: 1480
		[Token(Token = "0x40005C8")]
		[FieldOffset(Offset = "0x0")]
		private static ObiColliderWorld instance;
	}
}
