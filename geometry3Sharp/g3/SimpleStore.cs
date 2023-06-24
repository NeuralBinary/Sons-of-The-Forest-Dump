using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000191 RID: 401
	[Token(Token = "0x2000191")]
	public class SimpleStore
	{
		// Token: 0x06000B06 RID: 2822 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B06")]
		[Address(RVA = "0x2009100", Offset = "0x2007700", VA = "0x182009100")]
		public SimpleStore()
		{
		}

		// Token: 0x06000B07 RID: 2823 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B07")]
		[Address(RVA = "0x2009360", Offset = "0x2007960", VA = "0x182009360")]
		public SimpleStore(object[] objs)
		{
		}

		// Token: 0x06000B08 RID: 2824 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B08")]
		[Address(RVA = "0x20095E0", Offset = "0x2007BE0", VA = "0x1820095E0")]
		public void Add(object[] objs)
		{
		}

		// Token: 0x06000B09 RID: 2825 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B09")]
		[Address(RVA = "0x2009970", Offset = "0x2007F70", VA = "0x182009970")]
		public static void Store(string sPath, object[] objs)
		{
		}

		// Token: 0x06000B0A RID: 2826 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B0A")]
		[Address(RVA = "0x20099E0", Offset = "0x2007FE0", VA = "0x1820099E0")]
		public static void Store(string sPath, SimpleStore s)
		{
		}

		// Token: 0x06000B0B RID: 2827 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000B0B")]
		[Address(RVA = "0x200A0C0", Offset = "0x20086C0", VA = "0x18200A0C0")]
		public static SimpleStore Restore(string sPath)
		{
			return null;
		}

		// Token: 0x04000639 RID: 1593
		[Token(Token = "0x4000639")]
		[FieldOffset(Offset = "0x10")]
		public List<DMesh3> Meshes;

		// Token: 0x0400063A RID: 1594
		[Token(Token = "0x400063A")]
		[FieldOffset(Offset = "0x18")]
		public List<Vector3d> Points;

		// Token: 0x0400063B RID: 1595
		[Token(Token = "0x400063B")]
		[FieldOffset(Offset = "0x20")]
		public List<string> Strings;

		// Token: 0x0400063C RID: 1596
		[Token(Token = "0x400063C")]
		[FieldOffset(Offset = "0x28")]
		public List<List<int>> IntLists;
	}
}
