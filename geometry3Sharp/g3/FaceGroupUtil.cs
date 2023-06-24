using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000246 RID: 582
	[Token(Token = "0x2000246")]
	public static class FaceGroupUtil
	{
		// Token: 0x060014C8 RID: 5320 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014C8")]
		[Address(RVA = "0x1E89C50", Offset = "0x1E88250", VA = "0x181E89C50")]
		public static void SetGroupID(DMesh3 mesh, int to)
		{
		}

		// Token: 0x060014C9 RID: 5321 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014C9")]
		[Address(RVA = "0x1E89E30", Offset = "0x1E88430", VA = "0x181E89E30")]
		public static void SetGroupID(DMesh3 mesh, IEnumerable<int> triangles, int to)
		{
		}

		// Token: 0x060014CA RID: 5322 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014CA")]
		[Address(RVA = "0x1E8A000", Offset = "0x1E88600", VA = "0x181E8A000")]
		public static void SetGroupToGroup(DMesh3 mesh, int from, int to)
		{
		}

		// Token: 0x060014CB RID: 5323 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60014CB")]
		[Address(RVA = "0x1E8A190", Offset = "0x1E88790", VA = "0x181E8A190")]
		public static HashSet<int> FindAllGroups(DMesh3 mesh)
		{
			return null;
		}

		// Token: 0x060014CC RID: 5324 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60014CC")]
		[Address(RVA = "0x1E8A380", Offset = "0x1E88980", VA = "0x181E8A380")]
		public static SparseList<int> CountAllGroups(DMesh3 mesh)
		{
			return null;
		}

		// Token: 0x060014CD RID: 5325 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60014CD")]
		[Address(RVA = "0x1E8A5A0", Offset = "0x1E88BA0", VA = "0x181E8A5A0")]
		public static int[][] FindTriangleSetsByGroup(DMesh3 mesh, int ignoreGID = -2147483648)
		{
			return null;
		}

		// Token: 0x060014CE RID: 5326 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60014CE")]
		[Address(RVA = "0x1E8AD70", Offset = "0x1E89370", VA = "0x181E8AD70")]
		public static List<int> FindTrianglesByGroup(IMesh mesh, int findGroupID)
		{
			return null;
		}

		// Token: 0x060014CF RID: 5327 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60014CF")]
		[Address(RVA = "0x1E8B070", Offset = "0x1E89670", VA = "0x181E8B070")]
		public static DMesh3[] SeparateMeshByGroups(DMesh3 mesh, out int[] groupIDs)
		{
			return null;
		}

		// Token: 0x060014D0 RID: 5328 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60014D0")]
		[Address(RVA = "0x1E8B910", Offset = "0x1E89F10", VA = "0x181E8B910")]
		public static DMesh3[] SeparateMeshByGroups(DMesh3 mesh)
		{
			return null;
		}
	}
}
