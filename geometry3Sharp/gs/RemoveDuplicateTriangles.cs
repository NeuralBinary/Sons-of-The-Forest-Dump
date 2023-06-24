using System;
using System.Collections.Generic;
using g3;
using Il2CppDummyDll;

namespace gs
{
	// Token: 0x02000029 RID: 41
	[Token(Token = "0x2000029")]
	public class RemoveDuplicateTriangles
	{
		// Token: 0x060000B4 RID: 180 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x1E0EDC0", Offset = "0x1E0D3C0", VA = "0x181E0EDC0")]
		public RemoveDuplicateTriangles(DMesh3 mesh)
		{
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00002624 File Offset: 0x00000824
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x1E0EE20", Offset = "0x1E0D420", VA = "0x181E0EE20", Slot = "4")]
		public virtual bool Apply()
		{
			return default(bool);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0000263C File Offset: 0x0000083C
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x1E0F540", Offset = "0x1E0DB40", VA = "0x181E0F540")]
		private bool is_same_triangle(ref Vector3d a, ref Vector3d b, ref Vector3d c, ref Vector3d x, ref Vector3d y, ref Vector3d z, double tolSqr)
		{
			return default(bool);
		}

		// Token: 0x040000B8 RID: 184
		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0x10")]
		public DMesh3 Mesh;

		// Token: 0x040000B9 RID: 185
		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0x18")]
		public double VertexTolerance;

		// Token: 0x040000BA RID: 186
		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0x20")]
		public bool CheckOrientation;

		// Token: 0x040000BB RID: 187
		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0x24")]
		public int Removed;

		// Token: 0x0200002A RID: 42
		[Token(Token = "0x200002A")]
		private class TriCentroids : IPointSet
		{
			// Token: 0x17000005 RID: 5
			// (get) Token: 0x060000B7 RID: 183 RVA: 0x00002654 File Offset: 0x00000854
			[Token(Token = "0x17000005")]
			public int VertexCount
			{
				[Token(Token = "0x60000B7")]
				[Address(RVA = "0x1E0F840", Offset = "0x1E0DE40", VA = "0x181E0F840", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000006 RID: 6
			// (get) Token: 0x060000B8 RID: 184 RVA: 0x0000266C File Offset: 0x0000086C
			[Token(Token = "0x17000006")]
			public int MaxVertexID
			{
				[Token(Token = "0x60000B8")]
				[Address(RVA = "0x1E0F870", Offset = "0x1E0DE70", VA = "0x181E0F870", Slot = "5")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000007 RID: 7
			// (get) Token: 0x060000B9 RID: 185 RVA: 0x00002684 File Offset: 0x00000884
			[Token(Token = "0x17000007")]
			public bool HasVertexNormals
			{
				[Token(Token = "0x60000B9")]
				[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "6")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000008 RID: 8
			// (get) Token: 0x060000BA RID: 186 RVA: 0x0000269C File Offset: 0x0000089C
			[Token(Token = "0x17000008")]
			public bool HasVertexColors
			{
				[Token(Token = "0x60000BA")]
				[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x060000BB RID: 187 RVA: 0x000026B4 File Offset: 0x000008B4
			[Token(Token = "0x60000BB")]
			[Address(RVA = "0x1E0F8D0", Offset = "0x1E0DED0", VA = "0x181E0F8D0", Slot = "8")]
			public Vector3d GetVertex(int i)
			{
				return default(Vector3d);
			}

			// Token: 0x060000BC RID: 188 RVA: 0x000026CC File Offset: 0x000008CC
			[Token(Token = "0x60000BC")]
			[Address(RVA = "0x1E0F910", Offset = "0x1E0DF10", VA = "0x181E0F910", Slot = "9")]
			public Vector3f GetVertexNormal(int i)
			{
				return default(Vector3f);
			}

			// Token: 0x060000BD RID: 189 RVA: 0x000026E4 File Offset: 0x000008E4
			[Token(Token = "0x60000BD")]
			[Address(RVA = "0x1E0F980", Offset = "0x1E0DF80", VA = "0x181E0F980", Slot = "10")]
			public Vector3f GetVertexColor(int i)
			{
				return default(Vector3f);
			}

			// Token: 0x060000BE RID: 190 RVA: 0x000026FC File Offset: 0x000008FC
			[Token(Token = "0x60000BE")]
			[Address(RVA = "0x1E0F9F0", Offset = "0x1E0DFF0", VA = "0x181E0F9F0", Slot = "11")]
			public bool IsVertex(int tID)
			{
				return default(bool);
			}

			// Token: 0x060000BF RID: 191 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x60000BF")]
			[Address(RVA = "0x1E0FA20", Offset = "0x1E0E020", VA = "0x181E0FA20", Slot = "12")]
			public IEnumerable<int> VertexIndices()
			{
				return null;
			}

			// Token: 0x17000009 RID: 9
			// (get) Token: 0x060000C0 RID: 192 RVA: 0x00002714 File Offset: 0x00000914
			[Token(Token = "0x17000009")]
			public int Timestamp
			{
				[Token(Token = "0x60000C0")]
				[Address(RVA = "0x1E0FA40", Offset = "0x1E0E040", VA = "0x181E0FA40", Slot = "13")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060000C1 RID: 193 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60000C1")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public TriCentroids()
			{
			}

			// Token: 0x040000BC RID: 188
			[Token(Token = "0x40000BC")]
			[FieldOffset(Offset = "0x10")]
			public DMesh3 Mesh;
		}
	}
}
