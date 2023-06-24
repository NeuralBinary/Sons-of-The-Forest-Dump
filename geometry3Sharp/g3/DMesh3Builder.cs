using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000231 RID: 561
	[Token(Token = "0x2000231")]
	public class DMesh3Builder : IMeshBuilder
	{
		// Token: 0x06001430 RID: 5168 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001430")]
		[Address(RVA = "0x1E7AD40", Offset = "0x1E79340", VA = "0x181E7AD40")]
		public DMesh3Builder()
		{
		}

		// Token: 0x06001431 RID: 5169 RVA: 0x0000FDF4 File Offset: 0x0000DFF4
		[Token(Token = "0x6001431")]
		[Address(RVA = "0x1E7AFA0", Offset = "0x1E795A0", VA = "0x181E7AFA0", Slot = "4")]
		public int AppendNewMesh(bool bHaveVtxNormals, bool bHaveVtxColors, bool bHaveVtxUVs, bool bHaveFaceGroups)
		{
			return 0;
		}

		// Token: 0x06001432 RID: 5170 RVA: 0x0000FE0C File Offset: 0x0000E00C
		[Token(Token = "0x6001432")]
		[Address(RVA = "0x1E7B1D0", Offset = "0x1E797D0", VA = "0x181E7B1D0", Slot = "5")]
		public int AppendNewMesh(DMesh3 existingMesh)
		{
			return 0;
		}

		// Token: 0x06001433 RID: 5171 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001433")]
		[Address(RVA = "0x1E7B3A0", Offset = "0x1E799A0", VA = "0x181E7B3A0", Slot = "6")]
		public void SetActiveMesh(int id)
		{
		}

		// Token: 0x06001434 RID: 5172 RVA: 0x0000FE24 File Offset: 0x0000E024
		[Token(Token = "0x6001434")]
		[Address(RVA = "0x1E7B440", Offset = "0x1E79A40", VA = "0x181E7B440", Slot = "9")]
		public int AppendTriangle(int i, int j, int k)
		{
			return 0;
		}

		// Token: 0x06001435 RID: 5173 RVA: 0x0000FE3C File Offset: 0x0000E03C
		[Token(Token = "0x6001435")]
		[Address(RVA = "0x1E7B5A0", Offset = "0x1E79BA0", VA = "0x181E7B5A0", Slot = "10")]
		public int AppendTriangle(int i, int j, int k, int g)
		{
			return 0;
		}

		// Token: 0x06001436 RID: 5174 RVA: 0x0000FE54 File Offset: 0x0000E054
		[Token(Token = "0x6001436")]
		[Address(RVA = "0x1E7B730", Offset = "0x1E79D30", VA = "0x181E7B730")]
		private int append_duplicate_triangle(int i, int j, int k, int g)
		{
			return 0;
		}

		// Token: 0x06001437 RID: 5175 RVA: 0x0000FE6C File Offset: 0x0000E06C
		[Token(Token = "0x6001437")]
		[Address(RVA = "0x1E7BA70", Offset = "0x1E7A070", VA = "0x181E7BA70", Slot = "7")]
		public int AppendVertex(double x, double y, double z)
		{
			return 0;
		}

		// Token: 0x06001438 RID: 5176 RVA: 0x0000FE84 File Offset: 0x0000E084
		[Token(Token = "0x6001438")]
		[Address(RVA = "0x1E7BBA0", Offset = "0x1E7A1A0", VA = "0x181E7BBA0", Slot = "8")]
		public int AppendVertex(NewVertexInfo info)
		{
			return 0;
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06001439 RID: 5177 RVA: 0x0000FE9C File Offset: 0x0000E09C
		[Token(Token = "0x17000341")]
		public bool SupportsMetaData
		{
			[Token(Token = "0x6001439")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600143A RID: 5178 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600143A")]
		[Address(RVA = "0x1E7BC50", Offset = "0x1E7A250", VA = "0x181E7BC50", Slot = "14")]
		public void AppendMetaData(string identifier, object data)
		{
		}

		// Token: 0x0600143B RID: 5179 RVA: 0x0000FEB4 File Offset: 0x0000E0B4
		[Token(Token = "0x600143B")]
		[Address(RVA = "0x1E7BD10", Offset = "0x1E7A310", VA = "0x181E7BD10", Slot = "11")]
		public int BuildMaterial(GenericMaterial m)
		{
			return 0;
		}

		// Token: 0x0600143C RID: 5180 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600143C")]
		[Address(RVA = "0x1E7BDC0", Offset = "0x1E7A3C0", VA = "0x181E7BDC0", Slot = "12")]
		public void AssignMaterial(int materialID, int meshID)
		{
		}

		// Token: 0x0600143D RID: 5181 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600143D")]
		public static DMesh3 Build<VType, TType, NType>(IEnumerable<VType> Vertices, IEnumerable<TType> Triangles, [Optional] IEnumerable<NType> Normals, [Optional] IEnumerable<int> TriGroups)
		{
			return null;
		}

		// Token: 0x0400094C RID: 2380
		[Token(Token = "0x400094C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DMesh3Builder.AddTriangleFailBehaviors NonManifoldTriBehavior;

		// Token: 0x0400094D RID: 2381
		[Token(Token = "0x400094D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public DMesh3Builder.AddTriangleFailBehaviors DuplicateTriBehavior;

		// Token: 0x0400094E RID: 2382
		[Token(Token = "0x400094E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<DMesh3> Meshes;

		// Token: 0x0400094F RID: 2383
		[Token(Token = "0x400094F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<GenericMaterial> Materials;

		// Token: 0x04000950 RID: 2384
		[Token(Token = "0x4000950")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<int> MaterialAssignment;

		// Token: 0x04000951 RID: 2385
		[Token(Token = "0x4000951")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public List<Dictionary<string, object>> Metadata;

		// Token: 0x04000952 RID: 2386
		[Token(Token = "0x4000952")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int nActiveMesh;

		// Token: 0x02000232 RID: 562
		[Token(Token = "0x2000232")]
		public enum AddTriangleFailBehaviors
		{
			// Token: 0x04000954 RID: 2388
			[Token(Token = "0x4000954")]
			DiscardTriangle,
			// Token: 0x04000955 RID: 2389
			[Token(Token = "0x4000955")]
			DuplicateAllVertices
		}
	}
}
