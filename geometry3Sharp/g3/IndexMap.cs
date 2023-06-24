using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020000A4 RID: 164
	[Token(Token = "0x20000A4")]
	public class IndexMap : IIndexMap
	{
		// Token: 0x0600037C RID: 892 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600037C")]
		[Address(RVA = "0x1F443A0", Offset = "0x1F429A0", VA = "0x181F443A0")]
		public IndexMap(bool bForceSparse, int MaxIndex = -1)
		{
		}

		// Token: 0x0600037D RID: 893 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600037D")]
		[Address(RVA = "0x1F44530", Offset = "0x1F42B30", VA = "0x181F44530")]
		public IndexMap(int[] use_dense_map, int MaxIndex = -1)
		{
		}

		// Token: 0x0600037E RID: 894 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600037E")]
		[Address(RVA = "0x1F44590", Offset = "0x1F42B90", VA = "0x181F44590")]
		public IndexMap(int MaxIndex, int SubsetCountEst)
		{
		}

		// Token: 0x0600037F RID: 895 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600037F")]
		[Address(RVA = "0x1F44740", Offset = "0x1F42D40", VA = "0x181F44740")]
		public void SetToInvalid()
		{
		}

		// Token: 0x06000380 RID: 896 RVA: 0x00003B0C File Offset: 0x00001D0C
		[Token(Token = "0x6000380")]
		[Address(RVA = "0x1F447B0", Offset = "0x1F42DB0", VA = "0x181F447B0")]
		public bool Contains(int index)
		{
			return default(bool);
		}

		// Token: 0x17000072 RID: 114
		[Token(Token = "0x17000072")]
		public int this[int index]
		{
			[Token(Token = "0x6000381")]
			[Address(RVA = "0x1F44860", Offset = "0x1F42E60", VA = "0x181F44860", Slot = "4")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000382")]
			[Address(RVA = "0x1F44930", Offset = "0x1F42F30", VA = "0x181F44930")]
			set
			{
			}
		}

		// Token: 0x0400029F RID: 671
		[Token(Token = "0x400029F")]
		[FieldOffset(Offset = "0x10")]
		public readonly int InvalidIndex;

		// Token: 0x040002A0 RID: 672
		[Token(Token = "0x40002A0")]
		[FieldOffset(Offset = "0x18")]
		private int[] dense_map;

		// Token: 0x040002A1 RID: 673
		[Token(Token = "0x40002A1")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<int, int> sparse_map;

		// Token: 0x040002A2 RID: 674
		[Token(Token = "0x40002A2")]
		[FieldOffset(Offset = "0x28")]
		private int MaxIndex;
	}
}
