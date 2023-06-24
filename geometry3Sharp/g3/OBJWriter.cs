using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020001A1 RID: 417
	[Token(Token = "0x20001A1")]
	public class OBJWriter : IMeshWriter
	{
		// Token: 0x06000B51 RID: 2897 RVA: 0x000084D4 File Offset: 0x000066D4
		[Token(Token = "0x6000B51")]
		[Address(RVA = "0x2010B30", Offset = "0x200F130", VA = "0x182010B30", Slot = "5")]
		public IOWriteResult Write(BinaryWriter writer, List<WriteMesh> vMeshes, WriteOptions options)
		{
			return default(IOWriteResult);
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x000084EC File Offset: 0x000066EC
		[Token(Token = "0x6000B52")]
		[Address(RVA = "0x2010B70", Offset = "0x200F170", VA = "0x182010B70", Slot = "4")]
		public IOWriteResult Write(TextWriter writer, List<WriteMesh> vMeshes, WriteOptions options)
		{
			return default(IOWriteResult);
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B53")]
		[Address(RVA = "0x2011DF0", Offset = "0x20103F0", VA = "0x182011DF0")]
		private void write_triangles_bygroup(TextWriter writer, IMesh mesh, int[] mapV, DenseUVMesh uvSet, IIndexMap mapUV, bool bNormals)
		{
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B54")]
		[Address(RVA = "0x20128A0", Offset = "0x2010EA0", VA = "0x1820128A0")]
		private void write_triangles_flat(TextWriter writer, WriteMesh write_mesh, int[] mapV, DenseUVMesh uvSet, IIndexMap mapUV, bool bNormals, bool bMaterials)
		{
		}

		// Token: 0x06000B55 RID: 2901 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B55")]
		[Address(RVA = "0x2012EB0", Offset = "0x20114B0", VA = "0x182012EB0")]
		public void set_current_material(TextWriter writer, int ti, WriteMesh mesh, ref int cur_material)
		{
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B56")]
		[Address(RVA = "0x2012FE0", Offset = "0x20115E0", VA = "0x182012FE0")]
		private void write_tri(TextWriter writer, ref Index3i t, bool bNormals, bool bUVs, ref Index3i tuv)
		{
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x00008504 File Offset: 0x00006704
		[Token(Token = "0x6000B57")]
		[Address(RVA = "0x2013610", Offset = "0x2011C10", VA = "0x182013610")]
		private IOWriteResult write_materials(List<GenericMaterial> vMaterials, WriteOptions options)
		{
			return default(IOWriteResult);
		}

		// Token: 0x06000B58 RID: 2904 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B58")]
		[Address(RVA = "0x2014680", Offset = "0x2012C80", VA = "0x182014680")]
		public OBJWriter()
		{
		}

		// Token: 0x0400069A RID: 1690
		[Token(Token = "0x400069A")]
		[FieldOffset(Offset = "0x10")]
		public Func<string, Stream> OpenStreamF;

		// Token: 0x0400069B RID: 1691
		[Token(Token = "0x400069B")]
		[FieldOffset(Offset = "0x18")]
		public Action<Stream> CloseStreamF;

		// Token: 0x0400069C RID: 1692
		[Token(Token = "0x400069C")]
		[FieldOffset(Offset = "0x20")]
		public string GroupNamePrefix;

		// Token: 0x0400069D RID: 1693
		[Token(Token = "0x400069D")]
		[FieldOffset(Offset = "0x28")]
		public Func<int, string> GroupNameF;
	}
}
