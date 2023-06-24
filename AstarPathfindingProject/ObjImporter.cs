using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x020000C1 RID: 193
	[Token(Token = "0x20000C1")]
	public class ObjImporter
	{
		// Token: 0x0600072A RID: 1834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600072A")]
		[Address(RVA = "0x6B6680", Offset = "0x6B4C80", VA = "0x1806B6680")]
		public static Mesh ImportFile(string filePath)
		{
			return null;
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x0000569C File Offset: 0x0000389C
		[Token(Token = "0x600072B")]
		[Address(RVA = "0x6B6B70", Offset = "0x6B5170", VA = "0x1806B6B70")]
		private static ObjImporter.meshStruct createMeshStruct(string filename)
		{
			return default(ObjImporter.meshStruct);
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600072C")]
		[Address(RVA = "0x6B7370", Offset = "0x6B5970", VA = "0x1806B7370")]
		private static void populateMeshStruct(ref ObjImporter.meshStruct mesh)
		{
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600072D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public ObjImporter()
		{
		}

		// Token: 0x020000C2 RID: 194
		[Token(Token = "0x20000C2")]
		private struct meshStruct
		{
			// Token: 0x040004B3 RID: 1203
			[Token(Token = "0x40004B3")]
			[FieldOffset(Offset = "0x0")]
			public Vector3[] vertices;

			// Token: 0x040004B4 RID: 1204
			[Token(Token = "0x40004B4")]
			[FieldOffset(Offset = "0x8")]
			public Vector3[] normals;

			// Token: 0x040004B5 RID: 1205
			[Token(Token = "0x40004B5")]
			[FieldOffset(Offset = "0x10")]
			public Vector2[] uv;

			// Token: 0x040004B6 RID: 1206
			[Token(Token = "0x40004B6")]
			[FieldOffset(Offset = "0x18")]
			public int[] triangles;

			// Token: 0x040004B7 RID: 1207
			[Token(Token = "0x40004B7")]
			[FieldOffset(Offset = "0x20")]
			public Vector3[] faceData;

			// Token: 0x040004B8 RID: 1208
			[Token(Token = "0x40004B8")]
			[FieldOffset(Offset = "0x28")]
			public string fileName;
		}
	}
}
