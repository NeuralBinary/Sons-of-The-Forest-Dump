using System;
using System.Collections.Generic;
using g3;
using Il2CppDummyDll;

namespace gs
{
	// Token: 0x02000030 RID: 48
	[Token(Token = "0x2000030")]
	public class EditMeshSpatial : ISpatial
	{
		// Token: 0x060000D1 RID: 209 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x1E12740", Offset = "0x1E10D40", VA = "0x181E12740")]
		public void RemoveTriangle(int tid)
		{
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x1E12800", Offset = "0x1E10E00", VA = "0x181E12800")]
		public void AddTriangle(int tid)
		{
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x000027A4 File Offset: 0x000009A4
		[Token(Token = "0x1700000A")]
		public bool SupportsNearestTriangle
		{
			[Token(Token = "0x60000D3")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x000027BC File Offset: 0x000009BC
		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x634E60", Offset = "0x633460", VA = "0x180634E60", Slot = "5")]
		public int FindNearestTriangle(Vector3d p, double fMaxDist = 1.7976931348623157E+308)
		{
			return 0;
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x000027D4 File Offset: 0x000009D4
		[Token(Token = "0x1700000B")]
		public bool SupportsPointContainment
		{
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x000027EC File Offset: 0x000009EC
		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "9")]
		public bool IsInside(Vector3d p)
		{
			return default(bool);
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x00002804 File Offset: 0x00000A04
		[Token(Token = "0x1700000C")]
		public bool SupportsTriangleRayIntersection
		{
			[Token(Token = "0x60000D7")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x0000281C File Offset: 0x00000A1C
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x1E12870", Offset = "0x1E10E70", VA = "0x181E12870", Slot = "7")]
		public int FindNearestHitTriangle(Ray3d ray, double fMaxDist = 1.7976931348623157E+308)
		{
			return 0;
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00002834 File Offset: 0x00000A34
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x1E12AC0", Offset = "0x1E110C0", VA = "0x181E12AC0")]
		private bool source_filter(int tid)
		{
			return default(bool);
		}

		// Token: 0x060000DA RID: 218 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x1E12B20", Offset = "0x1E11120", VA = "0x181E12B20")]
		private IntrRay3Triangle3 find_added_hit(ref Ray3d ray, out int hit_tid)
		{
			return null;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x1E12E60", Offset = "0x1E11460", VA = "0x181E12E60")]
		public EditMeshSpatial()
		{
		}

		// Token: 0x040000E5 RID: 229
		[Token(Token = "0x40000E5")]
		[FieldOffset(Offset = "0x10")]
		public DMesh3 SourceMesh;

		// Token: 0x040000E6 RID: 230
		[Token(Token = "0x40000E6")]
		[FieldOffset(Offset = "0x18")]
		public DMeshAABBTree3 SourceSpatial;

		// Token: 0x040000E7 RID: 231
		[Token(Token = "0x40000E7")]
		[FieldOffset(Offset = "0x20")]
		public DMesh3 EditMesh;

		// Token: 0x040000E8 RID: 232
		[Token(Token = "0x40000E8")]
		[FieldOffset(Offset = "0x28")]
		private HashSet<int> RemovedT;

		// Token: 0x040000E9 RID: 233
		[Token(Token = "0x40000E9")]
		[FieldOffset(Offset = "0x30")]
		private HashSet<int> AddedT;
	}
}
