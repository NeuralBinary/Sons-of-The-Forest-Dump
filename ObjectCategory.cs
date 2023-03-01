using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons
{
	// Token: 0x020004DA RID: 1242
	[Token(Token = "0x20004DA")]
	public class ObjectCategory : MonoBehaviour
	{
		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x06001FD0 RID: 8144 RVA: 0x000092B8 File Offset: 0x000074B8
		[Token(Token = "0x1700046E")]
		public ObjectCategory.Categories Category
		{
			[Token(Token = "0x6001FD0")]
			[Address(RVA = "0x576330", Offset = "0x575330", VA = "0x180576330")]
			get
			{
				return ObjectCategory.Categories.Tree;
			}
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06001FD1 RID: 8145 RVA: 0x000092D0 File Offset: 0x000074D0
		[Token(Token = "0x1700046F")]
		public bool IsTree
		{
			[Token(Token = "0x6001FD1")]
			[Address(RVA = "0x6A78F0", Offset = "0x6A68F0", VA = "0x1806A78F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06001FD2 RID: 8146 RVA: 0x000092E8 File Offset: 0x000074E8
		[Token(Token = "0x17000470")]
		public bool IsBush
		{
			[Token(Token = "0x6001FD2")]
			[Address(RVA = "0x2AD1B00", Offset = "0x2AD0B00", VA = "0x182AD1B00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06001FD3 RID: 8147 RVA: 0x00009300 File Offset: 0x00007500
		[Token(Token = "0x17000471")]
		public bool IsSapling
		{
			[Token(Token = "0x6001FD3")]
			[Address(RVA = "0x2613110", Offset = "0x2612110", VA = "0x182613110")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06001FD4 RID: 8148 RVA: 0x00009318 File Offset: 0x00007518
		[Token(Token = "0x17000472")]
		public bool IsStump
		{
			[Token(Token = "0x6001FD4")]
			[Address(RVA = "0x2613120", Offset = "0x2612120", VA = "0x182613120")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06001FD5 RID: 8149 RVA: 0x00009330 File Offset: 0x00007530
		[Token(Token = "0x17000473")]
		public bool IsCliffRock
		{
			[Token(Token = "0x6001FD5")]
			[Address(RVA = "0x2AD1B30", Offset = "0x2AD0B30", VA = "0x182AD1B30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06001FD6 RID: 8150 RVA: 0x00009348 File Offset: 0x00007548
		[Token(Token = "0x17000474")]
		public bool IsCaveRock
		{
			[Token(Token = "0x6001FD6")]
			[Address(RVA = "0x2D2C0C0", Offset = "0x2D2B0C0", VA = "0x182D2C0C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001FD7 RID: 8151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FD7")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public ObjectCategory()
		{
		}

		// Token: 0x04001D65 RID: 7525
		[Token(Token = "0x4001D65")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ObjectCategory.Categories _category;

		// Token: 0x020004DB RID: 1243
		[Token(Token = "0x20004DB")]
		public enum Categories
		{
			// Token: 0x04001D67 RID: 7527
			[Token(Token = "0x4001D67")]
			Tree,
			// Token: 0x04001D68 RID: 7528
			[Token(Token = "0x4001D68")]
			Bush,
			// Token: 0x04001D69 RID: 7529
			[Token(Token = "0x4001D69")]
			Sapling,
			// Token: 0x04001D6A RID: 7530
			[Token(Token = "0x4001D6A")]
			Stump,
			// Token: 0x04001D6B RID: 7531
			[Token(Token = "0x4001D6B")]
			CliffRock,
			// Token: 0x04001D6C RID: 7532
			[Token(Token = "0x4001D6C")]
			CaveRock
		}
	}
}
