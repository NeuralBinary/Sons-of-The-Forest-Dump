using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020001AC RID: 428
	[Token(Token = "0x20001AC")]
	public class StandardMeshWriter : IDisposable
	{
		// Token: 0x06000B8B RID: 2955 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B8B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06000B8C RID: 2956 RVA: 0x000086B4 File Offset: 0x000068B4
		[Token(Token = "0x6000B8C")]
		[Address(RVA = "0x20193C0", Offset = "0x20179C0", VA = "0x1820193C0")]
		public static IOWriteResult WriteMeshes(string sFilename, List<DMesh3> vMeshes, WriteOptions options)
		{
			return default(IOWriteResult);
		}

		// Token: 0x06000B8D RID: 2957 RVA: 0x000086CC File Offset: 0x000068CC
		[Token(Token = "0x6000B8D")]
		[Address(RVA = "0x2019780", Offset = "0x2017D80", VA = "0x182019780")]
		public static IOWriteResult WriteFile(string sFilename, List<WriteMesh> vMeshes, WriteOptions options)
		{
			return default(IOWriteResult);
		}

		// Token: 0x06000B8E RID: 2958 RVA: 0x000086E4 File Offset: 0x000068E4
		[Token(Token = "0x6000B8E")]
		[Address(RVA = "0x2019860", Offset = "0x2017E60", VA = "0x182019860")]
		public static IOWriteResult WriteMesh(string sFilename, IMesh mesh, WriteOptions options)
		{
			return default(IOWriteResult);
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x000086FC File Offset: 0x000068FC
		[Token(Token = "0x6000B8F")]
		[Address(RVA = "0x2019A00", Offset = "0x2018000", VA = "0x182019A00")]
		public IOWriteResult Write(string sFilename, List<WriteMesh> vMeshes, WriteOptions options)
		{
			return default(IOWriteResult);
		}

		// Token: 0x06000B90 RID: 2960 RVA: 0x00008714 File Offset: 0x00006914
		[Token(Token = "0x6000B90")]
		[Address(RVA = "0x2019FF0", Offset = "0x20185F0", VA = "0x182019FF0")]
		private IOWriteResult Write_OBJ(string sFilename, List<WriteMesh> vMeshes, WriteOptions options)
		{
			return default(IOWriteResult);
		}

		// Token: 0x06000B91 RID: 2961 RVA: 0x0000872C File Offset: 0x0000692C
		[Token(Token = "0x6000B91")]
		[Address(RVA = "0x201A340", Offset = "0x2018940", VA = "0x18201A340")]
		private IOWriteResult Write_OFF(string sFilename, List<WriteMesh> vMeshes, WriteOptions options)
		{
			return default(IOWriteResult);
		}

		// Token: 0x06000B92 RID: 2962 RVA: 0x00008744 File Offset: 0x00006944
		[Token(Token = "0x6000B92")]
		[Address(RVA = "0x201A5C0", Offset = "0x2018BC0", VA = "0x18201A5C0")]
		private IOWriteResult Write_STL(string sFilename, List<WriteMesh> vMeshes, WriteOptions options)
		{
			return default(IOWriteResult);
		}

		// Token: 0x06000B93 RID: 2963 RVA: 0x0000875C File Offset: 0x0000695C
		[Token(Token = "0x6000B93")]
		[Address(RVA = "0x201A960", Offset = "0x2018F60", VA = "0x18201A960")]
		private IOWriteResult Write_G3Mesh(string sFilename, List<WriteMesh> vMeshes, WriteOptions options)
		{
			return default(IOWriteResult);
		}

		// Token: 0x06000B94 RID: 2964 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B94")]
		[Address(RVA = "0x201ABE0", Offset = "0x20191E0", VA = "0x18201ABE0")]
		public StandardMeshWriter()
		{
		}

		// Token: 0x040006A7 RID: 1703
		[Token(Token = "0x40006A7")]
		[FieldOffset(Offset = "0x10")]
		public bool WriteInvariantCulture;

		// Token: 0x040006A8 RID: 1704
		[Token(Token = "0x40006A8")]
		[FieldOffset(Offset = "0x18")]
		public Func<string, Stream> OpenStreamF;

		// Token: 0x040006A9 RID: 1705
		[Token(Token = "0x40006A9")]
		[FieldOffset(Offset = "0x20")]
		public Action<Stream> CloseStreamF;
	}
}
