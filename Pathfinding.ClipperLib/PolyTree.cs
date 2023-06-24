using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Pathfinding.ClipperLib
{
	// Token: 0x02000003 RID: 3
	[Token(Token = "0x2000003")]
	public class PolyTree : PolyNode
	{
		// Token: 0x06000004 RID: 4 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x28393D0", Offset = "0x28379D0", VA = "0x1828393D0")]
		public PolyTree()
		{
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x2839490", Offset = "0x2837A90", VA = "0x182839490", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x28394D0", Offset = "0x2837AD0", VA = "0x1828394D0")]
		public void Clear()
		{
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x28395F0", Offset = "0x2837BF0", VA = "0x1828395F0")]
		public PolyNode GetFirst()
		{
			return null;
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00002058 File Offset: 0x00000258
		[Token(Token = "0x17000001")]
		public int Total
		{
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x2839670", Offset = "0x2837C70", VA = "0x182839670")]
			get
			{
				return 0;
			}
		}

		// Token: 0x04000003 RID: 3
		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x38")]
		internal List<PolyNode> m_AllPolys;
	}
}
