using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Shapes
{
	// Token: 0x0200009A RID: 154
	[Token(Token = "0x200009A")]
	internal static class ShapesMeshUtils
	{
		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000CA4 RID: 3236 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x170001D5")]
		public static Mesh[] QuadMesh
		{
			[Token(Token = "0x6000CA4")]
			[Address(RVA = "0x2A56190", Offset = "0x2A54790", VA = "0x182A56190")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000CA5 RID: 3237 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x170001D6")]
		public static Mesh[] TriangleMesh
		{
			[Token(Token = "0x6000CA5")]
			[Address(RVA = "0x2A561B0", Offset = "0x2A547B0", VA = "0x182A561B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06000CA6 RID: 3238 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x170001D7")]
		public static Mesh[] SphereMesh
		{
			[Token(Token = "0x6000CA6")]
			[Address(RVA = "0x2A561D0", Offset = "0x2A547D0", VA = "0x182A561D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x06000CA7 RID: 3239 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x170001D8")]
		public static Mesh[] CuboidMesh
		{
			[Token(Token = "0x6000CA7")]
			[Address(RVA = "0x2A561F0", Offset = "0x2A547F0", VA = "0x182A561F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06000CA8 RID: 3240 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x170001D9")]
		public static Mesh[] TorusMesh
		{
			[Token(Token = "0x6000CA8")]
			[Address(RVA = "0x2A56210", Offset = "0x2A54810", VA = "0x182A56210")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06000CA9 RID: 3241 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x170001DA")]
		public static Mesh[] ConeMesh
		{
			[Token(Token = "0x6000CA9")]
			[Address(RVA = "0x2A56230", Offset = "0x2A54830", VA = "0x182A56230")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06000CAA RID: 3242 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x170001DB")]
		public static Mesh[] ConeMeshUncapped
		{
			[Token(Token = "0x6000CAA")]
			[Address(RVA = "0x2A56250", Offset = "0x2A54850", VA = "0x182A56250")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x06000CAB RID: 3243 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x170001DC")]
		public static Mesh[] CylinderMesh
		{
			[Token(Token = "0x6000CAB")]
			[Address(RVA = "0x2A56270", Offset = "0x2A54870", VA = "0x182A56270")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x06000CAC RID: 3244 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x170001DD")]
		public static Mesh[] CapsuleMesh
		{
			[Token(Token = "0x6000CAC")]
			[Address(RVA = "0x2A56290", Offset = "0x2A54890", VA = "0x182A56290")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000CAD RID: 3245 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x6000CAD")]
		[Address(RVA = "0x2A562B0", Offset = "0x2A548B0", VA = "0x182A562B0")]
		private static Mesh EnsureValidMeshBounds(Mesh mesh, Bounds bounds)
		{
			return null;
		}

		// Token: 0x06000CAE RID: 3246 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x6000CAE")]
		[Address(RVA = "0x2A56380", Offset = "0x2A54980", VA = "0x182A56380")]
		public static Mesh GetLineMesh(LineGeometry geometry, LineEndCap endCaps, DetailLevel detail)
		{
			return null;
		}

		// Token: 0x04000397 RID: 919
		[Token(Token = "0x4000397")]
		[FieldOffset(Offset = "0x0")]
		private static Mesh quadMesh;

		// Token: 0x04000398 RID: 920
		[Token(Token = "0x4000398")]
		[FieldOffset(Offset = "0x8")]
		private static Mesh triangleMesh;

		// Token: 0x04000399 RID: 921
		[Token(Token = "0x4000399")]
		[FieldOffset(Offset = "0x10")]
		private static Mesh sphereMesh;

		// Token: 0x0400039A RID: 922
		[Token(Token = "0x400039A")]
		[FieldOffset(Offset = "0x18")]
		private static Mesh cuboidMesh;

		// Token: 0x0400039B RID: 923
		[Token(Token = "0x400039B")]
		[FieldOffset(Offset = "0x20")]
		private static Mesh torusMesh;

		// Token: 0x0400039C RID: 924
		[Token(Token = "0x400039C")]
		[FieldOffset(Offset = "0x28")]
		private static Mesh coneMesh;

		// Token: 0x0400039D RID: 925
		[Token(Token = "0x400039D")]
		[FieldOffset(Offset = "0x30")]
		private static Mesh coneMeshUncapped;

		// Token: 0x0400039E RID: 926
		[Token(Token = "0x400039E")]
		[FieldOffset(Offset = "0x38")]
		private static Mesh cylinderMesh;

		// Token: 0x0400039F RID: 927
		[Token(Token = "0x400039F")]
		[FieldOffset(Offset = "0x40")]
		private static Mesh capsuleMesh;
	}
}
