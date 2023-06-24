using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200034E RID: 846
	[Token(Token = "0x200034E")]
	public class BiGrid3<BlockType> where BlockType : class, IGridElement3, IFixedGrid3
	{
		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06001BE4 RID: 7140 RVA: 0x00013D0C File Offset: 0x00011F0C
		[Token(Token = "0x17000428")]
		public Vector3i BlockSize
		{
			[Token(Token = "0x6001BE4")]
			get
			{
				return default(Vector3i);
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06001BE5 RID: 7141 RVA: 0x00013D24 File Offset: 0x00011F24
		[Token(Token = "0x17000429")]
		public MultigridIndexer3 Indexer
		{
			[Token(Token = "0x6001BE5")]
			get
			{
				return default(MultigridIndexer3);
			}
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06001BE6 RID: 7142 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700042A")]
		public DSparseGrid3<BlockType> BlockGrid
		{
			[Token(Token = "0x6001BE6")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001BE7 RID: 7143 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001BE7")]
		public BiGrid3(BlockType exemplar)
		{
		}

		// Token: 0x06001BE8 RID: 7144 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001BE8")]
		public void Update(Index3i index, Action<BlockType, Vector3i> UpdateF)
		{
		}

		// Token: 0x06001BE9 RID: 7145 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001BE9")]
		public IEnumerable<KeyValuePair<Vector3i, BlockType>> AllocatedBlocks()
		{
			return null;
		}

		// Token: 0x04000EE5 RID: 3813
		[Token(Token = "0x4000EE5")]
		[FieldOffset(Offset = "0x0")]
		private Vector3i block_size;

		// Token: 0x04000EE6 RID: 3814
		[Token(Token = "0x4000EE6")]
		[FieldOffset(Offset = "0x0")]
		private MultigridIndexer3 indexer;

		// Token: 0x04000EE7 RID: 3815
		[Token(Token = "0x4000EE7")]
		[FieldOffset(Offset = "0x0")]
		private DSparseGrid3<BlockType> sparse_grid;
	}
}
