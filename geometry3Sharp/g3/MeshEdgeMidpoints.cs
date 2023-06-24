using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000270 RID: 624
	[Token(Token = "0x2000270")]
	public class MeshEdgeMidpoints : IPointSet
	{
		// Token: 0x060015F6 RID: 5622 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015F6")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
		public MeshEdgeMidpoints(DMesh3 mesh)
		{
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x060015F7 RID: 5623 RVA: 0x00010AE4 File Offset: 0x0000ECE4
		[Token(Token = "0x17000374")]
		public int VertexCount
		{
			[Token(Token = "0x60015F7")]
			[Address(RVA = "0x1EA2BE0", Offset = "0x1EA11E0", VA = "0x181EA2BE0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x060015F8 RID: 5624 RVA: 0x00010AFC File Offset: 0x0000ECFC
		[Token(Token = "0x17000375")]
		public int MaxVertexID
		{
			[Token(Token = "0x60015F8")]
			[Address(RVA = "0x1EA2C10", Offset = "0x1EA1210", VA = "0x181EA2C10", Slot = "5")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x060015F9 RID: 5625 RVA: 0x00010B14 File Offset: 0x0000ED14
		[Token(Token = "0x17000376")]
		public bool HasVertexNormals
		{
			[Token(Token = "0x60015F9")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x060015FA RID: 5626 RVA: 0x00010B2C File Offset: 0x0000ED2C
		[Token(Token = "0x17000377")]
		public bool HasVertexColors
		{
			[Token(Token = "0x60015FA")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060015FB RID: 5627 RVA: 0x00010B44 File Offset: 0x0000ED44
		[Token(Token = "0x60015FB")]
		[Address(RVA = "0x1EA2C70", Offset = "0x1EA1270", VA = "0x181EA2C70", Slot = "8")]
		public Vector3d GetVertex(int i)
		{
			return default(Vector3d);
		}

		// Token: 0x060015FC RID: 5628 RVA: 0x00010B5C File Offset: 0x0000ED5C
		[Token(Token = "0x60015FC")]
		[Address(RVA = "0x1EA2CC0", Offset = "0x1EA12C0", VA = "0x181EA2CC0", Slot = "9")]
		public Vector3f GetVertexNormal(int i)
		{
			return default(Vector3f);
		}

		// Token: 0x060015FD RID: 5629 RVA: 0x00010B74 File Offset: 0x0000ED74
		[Token(Token = "0x60015FD")]
		[Address(RVA = "0x1EA2D30", Offset = "0x1EA1330", VA = "0x181EA2D30", Slot = "10")]
		public Vector3f GetVertexColor(int i)
		{
			return default(Vector3f);
		}

		// Token: 0x060015FE RID: 5630 RVA: 0x00010B8C File Offset: 0x0000ED8C
		[Token(Token = "0x60015FE")]
		[Address(RVA = "0x1EA2DA0", Offset = "0x1EA13A0", VA = "0x181EA2DA0", Slot = "11")]
		public bool IsVertex(int vID)
		{
			return default(bool);
		}

		// Token: 0x060015FF RID: 5631 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60015FF")]
		[Address(RVA = "0x1EA2DD0", Offset = "0x1EA13D0", VA = "0x181EA2DD0", Slot = "12")]
		public IEnumerable<int> VertexIndices()
		{
			return null;
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06001600 RID: 5632 RVA: 0x00010BA4 File Offset: 0x0000EDA4
		[Token(Token = "0x17000378")]
		public int Timestamp
		{
			[Token(Token = "0x6001600")]
			[Address(RVA = "0x1E0FA40", Offset = "0x1E0E040", VA = "0x181E0FA40", Slot = "13")]
			get
			{
				return 0;
			}
		}

		// Token: 0x04000A5F RID: 2655
		[Token(Token = "0x4000A5F")]
		[FieldOffset(Offset = "0x10")]
		public DMesh3 Mesh;
	}
}
