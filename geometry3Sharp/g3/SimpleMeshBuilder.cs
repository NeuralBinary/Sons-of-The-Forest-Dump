using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200029F RID: 671
	[Token(Token = "0x200029F")]
	public class SimpleMeshBuilder : IMeshBuilder
	{
		// Token: 0x06001811 RID: 6161 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001811")]
		[Address(RVA = "0x1ECCA60", Offset = "0x1ECB060", VA = "0x181ECCA60")]
		public SimpleMeshBuilder()
		{
		}

		// Token: 0x06001812 RID: 6162 RVA: 0x00011F3C File Offset: 0x0001013C
		[Token(Token = "0x6001812")]
		[Address(RVA = "0x1ECCC30", Offset = "0x1ECB230", VA = "0x181ECCC30", Slot = "4")]
		public int AppendNewMesh(bool bHaveVtxNormals, bool bHaveVtxColors, bool bHaveVtxUVs, bool bHaveFaceGroups)
		{
			return 0;
		}

		// Token: 0x06001813 RID: 6163 RVA: 0x00011F54 File Offset: 0x00010154
		[Token(Token = "0x6001813")]
		[Address(RVA = "0x1ECCDE0", Offset = "0x1ECB3E0", VA = "0x181ECCDE0", Slot = "5")]
		public int AppendNewMesh(DMesh3 existingMesh)
		{
			return 0;
		}

		// Token: 0x06001814 RID: 6164 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001814")]
		[Address(RVA = "0x1ECCF40", Offset = "0x1ECB540", VA = "0x181ECCF40", Slot = "6")]
		public void SetActiveMesh(int id)
		{
		}

		// Token: 0x06001815 RID: 6165 RVA: 0x00011F6C File Offset: 0x0001016C
		[Token(Token = "0x6001815")]
		[Address(RVA = "0x1ECCFE0", Offset = "0x1ECB5E0", VA = "0x181ECCFE0", Slot = "9")]
		public int AppendTriangle(int i, int j, int k)
		{
			return 0;
		}

		// Token: 0x06001816 RID: 6166 RVA: 0x00011F84 File Offset: 0x00010184
		[Token(Token = "0x6001816")]
		[Address(RVA = "0x1ECD090", Offset = "0x1ECB690", VA = "0x181ECD090", Slot = "10")]
		public int AppendTriangle(int i, int j, int k, int g)
		{
			return 0;
		}

		// Token: 0x06001817 RID: 6167 RVA: 0x00011F9C File Offset: 0x0001019C
		[Token(Token = "0x6001817")]
		[Address(RVA = "0x1ECD140", Offset = "0x1ECB740", VA = "0x181ECD140", Slot = "7")]
		public int AppendVertex(double x, double y, double z)
		{
			return 0;
		}

		// Token: 0x06001818 RID: 6168 RVA: 0x00011FB4 File Offset: 0x000101B4
		[Token(Token = "0x6001818")]
		[Address(RVA = "0x1ECD1F0", Offset = "0x1ECB7F0", VA = "0x181ECD1F0", Slot = "8")]
		public int AppendVertex(NewVertexInfo info)
		{
			return 0;
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06001819 RID: 6169 RVA: 0x00011FCC File Offset: 0x000101CC
		[Token(Token = "0x170003C3")]
		public bool SupportsMetaData
		{
			[Token(Token = "0x6001819")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600181A RID: 6170 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600181A")]
		[Address(RVA = "0x1ECD2A0", Offset = "0x1ECB8A0", VA = "0x181ECD2A0", Slot = "14")]
		public void AppendMetaData(string identifier, object data)
		{
		}

		// Token: 0x0600181B RID: 6171 RVA: 0x00011FE4 File Offset: 0x000101E4
		[Token(Token = "0x600181B")]
		[Address(RVA = "0x1ECD2F0", Offset = "0x1ECB8F0", VA = "0x181ECD2F0", Slot = "11")]
		public int BuildMaterial(GenericMaterial m)
		{
			return 0;
		}

		// Token: 0x0600181C RID: 6172 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600181C")]
		[Address(RVA = "0x1ECD3A0", Offset = "0x1ECB9A0", VA = "0x181ECD3A0", Slot = "12")]
		public void AssignMaterial(int materialID, int meshID)
		{
		}

		// Token: 0x04000B77 RID: 2935
		[Token(Token = "0x4000B77")]
		[FieldOffset(Offset = "0x10")]
		public List<SimpleMesh> Meshes;

		// Token: 0x04000B78 RID: 2936
		[Token(Token = "0x4000B78")]
		[FieldOffset(Offset = "0x18")]
		public List<GenericMaterial> Materials;

		// Token: 0x04000B79 RID: 2937
		[Token(Token = "0x4000B79")]
		[FieldOffset(Offset = "0x20")]
		public List<int> MaterialAssignment;

		// Token: 0x04000B7A RID: 2938
		[Token(Token = "0x4000B7A")]
		[FieldOffset(Offset = "0x28")]
		private int nActiveMesh;
	}
}
