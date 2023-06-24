using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight.Environment
{
	// Token: 0x0200000C RID: 12
	[Token(Token = "0x200000C")]
	public class HoudiniDetailData
	{
		// Token: 0x06000037 RID: 55 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x2F91F50", Offset = "0x2F90550", VA = "0x182F91F50")]
		public void Sort(out int dupeCount)
		{
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002174 File Offset: 0x00000374
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x2F928A0", Offset = "0x2F90EA0", VA = "0x182F928A0")]
		private int EvalSort(int valueA, int valueB, ref List<int> dupeIndexes)
		{
			return 0;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x0000218C File Offset: 0x0000038C
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x2F92EB0", Offset = "0x2F914B0", VA = "0x182F92EB0")]
		private static int EvalSortVec3(Vector3 valueAPos, Vector3 valueBPos)
		{
			return 0;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000021A4 File Offset: 0x000003A4
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x2F92F60", Offset = "0x2F91560", VA = "0x182F92F60")]
		private static int EvalSortQuaternion(Quaternion valueAPos, Quaternion valueBPos)
		{
			return 0;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x2F92FC0", Offset = "0x2F915C0", VA = "0x182F92FC0")]
		public string GetHLodId(int i, string defaultResult = "")
		{
			return null;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public HoudiniDetailData()
		{
		}

		// Token: 0x04000089 RID: 137
		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0x10")]
		public List<Vector3> positions;

		// Token: 0x0400008A RID: 138
		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0x18")]
		public List<string> guids;

		// Token: 0x0400008B RID: 139
		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0x20")]
		public List<Quaternion> rotations;

		// Token: 0x0400008C RID: 140
		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0x28")]
		public List<Vector3> scales;

		// Token: 0x0400008D RID: 141
		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0x30")]
		public List<string> worldGroupIds;

		// Token: 0x0400008E RID: 142
		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0x38")]
		public List<string> hlodIds;
	}
}
