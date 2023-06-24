using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000251 RID: 593
	[Token(Token = "0x2000251")]
	public class MeshConstraints
	{
		// Token: 0x06001505 RID: 5381 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001505")]
		[Address(RVA = "0x1E8C910", Offset = "0x1E8AF10", VA = "0x181E8C910")]
		public MeshConstraints()
		{
		}

		// Token: 0x06001506 RID: 5382 RVA: 0x000103F4 File Offset: 0x0000E5F4
		[Token(Token = "0x6001506")]
		[Address(RVA = "0x1E8CB60", Offset = "0x1E8B160", VA = "0x181E8CB60")]
		public int AllocateSetID()
		{
			return 0;
		}

		// Token: 0x06001507 RID: 5383 RVA: 0x0001040C File Offset: 0x0000E60C
		[Token(Token = "0x6001507")]
		[Address(RVA = "0x1E8CB70", Offset = "0x1E8B170", VA = "0x181E8CB70")]
		public bool HasEdgeConstraint(int eid)
		{
			return default(bool);
		}

		// Token: 0x06001508 RID: 5384 RVA: 0x00010424 File Offset: 0x0000E624
		[Token(Token = "0x6001508")]
		[Address(RVA = "0x1E8CBE0", Offset = "0x1E8B1E0", VA = "0x181E8CBE0")]
		public EdgeConstraint GetEdgeConstraint(int eid)
		{
			return default(EdgeConstraint);
		}

		// Token: 0x06001509 RID: 5385 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001509")]
		[Address(RVA = "0x1E8CD40", Offset = "0x1E8B340", VA = "0x181E8CD40")]
		public void SetOrUpdateEdgeConstraint(int eid, EdgeConstraint ec)
		{
		}

		// Token: 0x0600150A RID: 5386 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600150A")]
		[Address(RVA = "0x1E8CDE0", Offset = "0x1E8B3E0", VA = "0x181E8CDE0")]
		public void ClearEdgeConstraint(int eid)
		{
		}

		// Token: 0x0600150B RID: 5387 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600150B")]
		[Address(RVA = "0x1E8CE40", Offset = "0x1E8B440", VA = "0x181E8CE40")]
		public List<int> FindConstrainedEdgesBySetID(int setID)
		{
			return null;
		}

		// Token: 0x0600150C RID: 5388 RVA: 0x0001043C File Offset: 0x0000E63C
		[Token(Token = "0x600150C")]
		[Address(RVA = "0x1E8D040", Offset = "0x1E8B640", VA = "0x181E8D040")]
		public bool HasVertexConstraint(int vid)
		{
			return default(bool);
		}

		// Token: 0x0600150D RID: 5389 RVA: 0x00010454 File Offset: 0x0000E654
		[Token(Token = "0x600150D")]
		[Address(RVA = "0x1E8D0B0", Offset = "0x1E8B6B0", VA = "0x181E8D0B0")]
		public VertexConstraint GetVertexConstraint(int vid)
		{
			return default(VertexConstraint);
		}

		// Token: 0x0600150E RID: 5390 RVA: 0x0001046C File Offset: 0x0000E66C
		[Token(Token = "0x600150E")]
		[Address(RVA = "0x1E8D160", Offset = "0x1E8B760", VA = "0x181E8D160")]
		public bool GetVertexConstraint(int vid, ref VertexConstraint vc)
		{
			return default(bool);
		}

		// Token: 0x0600150F RID: 5391 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600150F")]
		[Address(RVA = "0x1E8D1C0", Offset = "0x1E8B7C0", VA = "0x181E8D1C0")]
		public void SetOrUpdateVertexConstraint(int vid, VertexConstraint vc)
		{
		}

		// Token: 0x06001510 RID: 5392 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001510")]
		[Address(RVA = "0x1E8D250", Offset = "0x1E8B850", VA = "0x181E8D250")]
		public void ClearVertexConstraint(int vid)
		{
		}

		// Token: 0x06001511 RID: 5393 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001511")]
		[Address(RVA = "0x1E8D2B0", Offset = "0x1E8B8B0", VA = "0x181E8D2B0")]
		public IEnumerable VertexConstraintsItr()
		{
			return null;
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06001512 RID: 5394 RVA: 0x00010484 File Offset: 0x0000E684
		[Token(Token = "0x17000356")]
		public bool HasConstraints
		{
			[Token(Token = "0x6001512")]
			[Address(RVA = "0x1E8D350", Offset = "0x1E8B950", VA = "0x181E8D350")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x040009D3 RID: 2515
		[Token(Token = "0x40009D3")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<int, EdgeConstraint> Edges;

		// Token: 0x040009D4 RID: 2516
		[Token(Token = "0x40009D4")]
		[FieldOffset(Offset = "0x18")]
		private int set_id_counter;

		// Token: 0x040009D5 RID: 2517
		[Token(Token = "0x40009D5")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<int, VertexConstraint> Vertices;
	}
}
