using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons
{
	// Token: 0x020004CF RID: 1231
	[Token(Token = "0x20004CF")]
	public class ObjectCategory : MonoBehaviour
	{
		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06002034 RID: 8244 RVA: 0x00009618 File Offset: 0x00007818
		[Token(Token = "0x1700047D")]
		public ObjectCategory.Categories Category
		{
			[Token(Token = "0x6002034")]
			[Address(RVA = "0x5FD580", Offset = "0x5FBB80", VA = "0x1805FD580")]
			get
			{
				return ObjectCategory.Categories.Tree;
			}
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06002035 RID: 8245 RVA: 0x00009630 File Offset: 0x00007830
		[Token(Token = "0x1700047E")]
		public bool IsTree
		{
			[Token(Token = "0x6002035")]
			[Address(RVA = "0x74DB00", Offset = "0x74C100", VA = "0x18074DB00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06002036 RID: 8246 RVA: 0x00009648 File Offset: 0x00007848
		[Token(Token = "0x1700047F")]
		public bool IsBush
		{
			[Token(Token = "0x6002036")]
			[Address(RVA = "0x30EF1C0", Offset = "0x30ED7C0", VA = "0x1830EF1C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06002037 RID: 8247 RVA: 0x00009660 File Offset: 0x00007860
		[Token(Token = "0x17000480")]
		public bool IsSapling
		{
			[Token(Token = "0x6002037")]
			[Address(RVA = "0x2AE38E0", Offset = "0x2AE1EE0", VA = "0x182AE38E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06002038 RID: 8248 RVA: 0x00009678 File Offset: 0x00007878
		[Token(Token = "0x17000481")]
		public bool IsStump
		{
			[Token(Token = "0x6002038")]
			[Address(RVA = "0x2AE38D0", Offset = "0x2AE1ED0", VA = "0x182AE38D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06002039 RID: 8249 RVA: 0x00009690 File Offset: 0x00007890
		[Token(Token = "0x17000482")]
		public bool IsCliffRock
		{
			[Token(Token = "0x6002039")]
			[Address(RVA = "0x30EF1B0", Offset = "0x30ED7B0", VA = "0x1830EF1B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x0600203A RID: 8250 RVA: 0x000096A8 File Offset: 0x000078A8
		[Token(Token = "0x17000483")]
		public bool IsCaveRock
		{
			[Token(Token = "0x600203A")]
			[Address(RVA = "0x3312330", Offset = "0x3310930", VA = "0x183312330")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600203B RID: 8251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600203B")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public ObjectCategory()
		{
		}

		// Token: 0x04001DA1 RID: 7585
		[Token(Token = "0x4001DA1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ObjectCategory.Categories _category;

		// Token: 0x020004D0 RID: 1232
		[Token(Token = "0x20004D0")]
		public enum Categories
		{
			// Token: 0x04001DA3 RID: 7587
			[Token(Token = "0x4001DA3")]
			Tree,
			// Token: 0x04001DA4 RID: 7588
			[Token(Token = "0x4001DA4")]
			Bush,
			// Token: 0x04001DA5 RID: 7589
			[Token(Token = "0x4001DA5")]
			Sapling,
			// Token: 0x04001DA6 RID: 7590
			[Token(Token = "0x4001DA6")]
			Stump,
			// Token: 0x04001DA7 RID: 7591
			[Token(Token = "0x4001DA7")]
			CliffRock,
			// Token: 0x04001DA8 RID: 7592
			[Token(Token = "0x4001DA8")]
			CaveRock
		}
	}
}
