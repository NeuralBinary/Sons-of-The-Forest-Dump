using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace NGUI.Internal
{
	// Token: 0x02000063 RID: 99
	[Token(Token = "0x2000063")]
	[Serializable]
	public class BMFont
	{
		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000358 RID: 856 RVA: 0x000033F0 File Offset: 0x000015F0
		[Token(Token = "0x170000D6")]
		public bool isValid
		{
			[Token(Token = "0x6000358")]
			[Address(RVA = "0x2661E30", Offset = "0x2660430", VA = "0x182661E30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000359 RID: 857 RVA: 0x00003408 File Offset: 0x00001608
		// (set) Token: 0x0600035A RID: 858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000D7")]
		public int charSize
		{
			[Token(Token = "0x6000359")]
			[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600035A")]
			[Address(RVA = "0x5EDA40", Offset = "0x5EC040", VA = "0x1805EDA40")]
			set
			{
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x0600035B RID: 859 RVA: 0x00003420 File Offset: 0x00001620
		// (set) Token: 0x0600035C RID: 860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000D8")]
		public int baseOffset
		{
			[Token(Token = "0x600035B")]
			[Address(RVA = "0x66F500", Offset = "0x66DB00", VA = "0x18066F500")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600035C")]
			[Address(RVA = "0x66F510", Offset = "0x66DB10", VA = "0x18066F510")]
			set
			{
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x0600035D RID: 861 RVA: 0x00003438 File Offset: 0x00001638
		// (set) Token: 0x0600035E RID: 862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000D9")]
		public int texWidth
		{
			[Token(Token = "0x600035D")]
			[Address(RVA = "0x66F520", Offset = "0x66DB20", VA = "0x18066F520")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600035E")]
			[Address(RVA = "0x6DDE70", Offset = "0x6DC470", VA = "0x1806DDE70")]
			set
			{
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x0600035F RID: 863 RVA: 0x00003450 File Offset: 0x00001650
		// (set) Token: 0x06000360 RID: 864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000DA")]
		public int texHeight
		{
			[Token(Token = "0x600035F")]
			[Address(RVA = "0x9FA1D0", Offset = "0x9F87D0", VA = "0x1809FA1D0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000360")]
			[Address(RVA = "0xA7FDD0", Offset = "0xA7E3D0", VA = "0x180A7FDD0")]
			set
			{
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000361 RID: 865 RVA: 0x00003468 File Offset: 0x00001668
		[Token(Token = "0x170000DB")]
		public int glyphCount
		{
			[Token(Token = "0x6000361")]
			[Address(RVA = "0x2661E80", Offset = "0x2660480", VA = "0x182661E80")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000362 RID: 866 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000363 RID: 867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000DC")]
		public string spriteName
		{
			[Token(Token = "0x6000362")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000363")]
			[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
			set
			{
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000364 RID: 868 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000DD")]
		public List<BMGlyph> glyphs
		{
			[Token(Token = "0x6000364")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000365 RID: 869 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000365")]
		[Address(RVA = "0x2661EF0", Offset = "0x26604F0", VA = "0x182661EF0")]
		public BMGlyph GetGlyph(int index, bool createIfMissing)
		{
			return null;
		}

		// Token: 0x06000366 RID: 870 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000366")]
		[Address(RVA = "0x26621B0", Offset = "0x26607B0", VA = "0x1826621B0")]
		public BMGlyph GetGlyph(int index)
		{
			return null;
		}

		// Token: 0x06000367 RID: 871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000367")]
		[Address(RVA = "0x26621C0", Offset = "0x26607C0", VA = "0x1826621C0")]
		public void Clear()
		{
		}

		// Token: 0x06000368 RID: 872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000368")]
		[Address(RVA = "0x2662250", Offset = "0x2660850", VA = "0x182662250")]
		public void Trim(int xMin, int yMin, int xMax, int yMax)
		{
		}

		// Token: 0x06000369 RID: 873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000369")]
		[Address(RVA = "0x2662360", Offset = "0x2660960", VA = "0x182662360")]
		public BMFont()
		{
		}

		// Token: 0x04000299 RID: 665
		[Token(Token = "0x4000299")]
		[FieldOffset(Offset = "0x10")]
		[HideInInspector]
		[SerializeField]
		private int mSize;

		// Token: 0x0400029A RID: 666
		[Token(Token = "0x400029A")]
		[FieldOffset(Offset = "0x14")]
		[HideInInspector]
		[SerializeField]
		private int mBase;

		// Token: 0x0400029B RID: 667
		[Token(Token = "0x400029B")]
		[FieldOffset(Offset = "0x18")]
		[HideInInspector]
		[SerializeField]
		private int mWidth;

		// Token: 0x0400029C RID: 668
		[Token(Token = "0x400029C")]
		[FieldOffset(Offset = "0x1C")]
		[HideInInspector]
		[SerializeField]
		private int mHeight;

		// Token: 0x0400029D RID: 669
		[Token(Token = "0x400029D")]
		[FieldOffset(Offset = "0x20")]
		[HideInInspector]
		[SerializeField]
		private string mSpriteName;

		// Token: 0x0400029E RID: 670
		[Token(Token = "0x400029E")]
		[FieldOffset(Offset = "0x28")]
		[HideInInspector]
		[SerializeField]
		private List<BMGlyph> mSaved;

		// Token: 0x0400029F RID: 671
		[Token(Token = "0x400029F")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<int, BMGlyph> mDict;
	}
}
