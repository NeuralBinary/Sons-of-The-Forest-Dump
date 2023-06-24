using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x02000116 RID: 278
	[Token(Token = "0x2000116")]
	public class OniColliderWorld : MonoBehaviour, IColliderWorldImpl
	{
		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060004EF RID: 1263 RVA: 0x00003CD4 File Offset: 0x00001ED4
		[Token(Token = "0x17000090")]
		public int referenceCount
		{
			[Token(Token = "0x60004EF")]
			[Address(RVA = "0x5FD580", Offset = "0x5FBB80", VA = "0x1805FD580", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x27ADE30", Offset = "0x27AC430", VA = "0x1827ADE30")]
		public void Awake()
		{
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x27ADE60", Offset = "0x27AC460", VA = "0x1827ADE60")]
		public void OnDestroy()
		{
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x276AEB0", Offset = "0x27694B0", VA = "0x18276AEB0")]
		public void IncreaseReferenceCount()
		{
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x27ADED0", Offset = "0x27AC4D0", VA = "0x1827ADED0")]
		public void DecreaseReferenceCount()
		{
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x27AE050", Offset = "0x27AC650", VA = "0x1827AE050", Slot = "5")]
		public void UpdateWorld(float deltaTime)
		{
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x27AE0D0", Offset = "0x27AC6D0", VA = "0x1827AE0D0", Slot = "6")]
		public void SetColliders(ObiNativeColliderShapeList shapes, ObiNativeAabbList bounds, ObiNativeAffineTransformList transforms, int count)
		{
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x27AE1E0", Offset = "0x27AC7E0", VA = "0x1827AE1E0", Slot = "7")]
		public void SetRigidbodies(ObiNativeRigidbodyList rigidbody)
		{
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x27AE290", Offset = "0x27AC890", VA = "0x1827AE290", Slot = "8")]
		public void SetCollisionMaterials(ObiNativeCollisionMaterialList materials)
		{
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x27AE340", Offset = "0x27AC940", VA = "0x1827AE340", Slot = "9")]
		public void SetTriangleMeshData(ObiNativeTriangleMeshHeaderList headers, ObiNativeBIHNodeList nodes, ObiNativeTriangleList triangles, ObiNativeVector3List vertices)
		{
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x27AE470", Offset = "0x27ACA70", VA = "0x1827AE470", Slot = "10")]
		public void SetEdgeMeshData(ObiNativeEdgeMeshHeaderList headers, ObiNativeBIHNodeList nodes, ObiNativeEdgeList edges, ObiNativeVector2List vertices)
		{
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x27AE5A0", Offset = "0x27ACBA0", VA = "0x1827AE5A0", Slot = "11")]
		public void SetDistanceFieldData(ObiNativeDistanceFieldHeaderList headers, ObiNativeDFNodeList nodes)
		{
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x27AE670", Offset = "0x27ACC70", VA = "0x1827AE670", Slot = "12")]
		public void SetHeightFieldData(ObiNativeHeightFieldHeaderList headers, ObiNativeFloatList samples)
		{
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public OniColliderWorld()
		{
		}

		// Token: 0x04000538 RID: 1336
		[Token(Token = "0x4000538")]
		[FieldOffset(Offset = "0x20")]
		private int refCount;
	}
}
