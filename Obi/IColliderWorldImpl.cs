using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x020000E1 RID: 225
	[Token(Token = "0x20000E1")]
	public interface IColliderWorldImpl
	{
		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000442 RID: 1090
		[Token(Token = "0x17000084")]
		int referenceCount { [Token(Token = "0x6000442")] get; }

		// Token: 0x06000443 RID: 1091
		[Token(Token = "0x6000443")]
		void UpdateWorld(float deltaTime);

		// Token: 0x06000444 RID: 1092
		[Token(Token = "0x6000444")]
		void SetColliders(ObiNativeColliderShapeList shapes, ObiNativeAabbList bounds, ObiNativeAffineTransformList transforms, int count);

		// Token: 0x06000445 RID: 1093
		[Token(Token = "0x6000445")]
		void SetRigidbodies(ObiNativeRigidbodyList rigidbody);

		// Token: 0x06000446 RID: 1094
		[Token(Token = "0x6000446")]
		void SetCollisionMaterials(ObiNativeCollisionMaterialList materials);

		// Token: 0x06000447 RID: 1095
		[Token(Token = "0x6000447")]
		void SetTriangleMeshData(ObiNativeTriangleMeshHeaderList headers, ObiNativeBIHNodeList nodes, ObiNativeTriangleList triangles, ObiNativeVector3List vertices);

		// Token: 0x06000448 RID: 1096
		[Token(Token = "0x6000448")]
		void SetEdgeMeshData(ObiNativeEdgeMeshHeaderList headers, ObiNativeBIHNodeList nodes, ObiNativeEdgeList triangles, ObiNativeVector2List vertices);

		// Token: 0x06000449 RID: 1097
		[Token(Token = "0x6000449")]
		void SetDistanceFieldData(ObiNativeDistanceFieldHeaderList headers, ObiNativeDFNodeList nodes);

		// Token: 0x0600044A RID: 1098
		[Token(Token = "0x600044A")]
		void SetHeightFieldData(ObiNativeHeightFieldHeaderList headers, ObiNativeFloatList samples);
	}
}
