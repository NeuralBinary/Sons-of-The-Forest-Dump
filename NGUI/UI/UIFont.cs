using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using NGUI.Internal;
using UnityEngine;

namespace NGUI.UI
{
	// Token: 0x02000026 RID: 38
	[Token(Token = "0x2000026")]
	[ExecuteInEditMode]
	[AddComponentMenu("NGUI/UI/NGUI Font")]
	public class UIFont : MonoBehaviour
	{
		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x060000D8 RID: 216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000028")]
		public BMFont bmFont
		{
			[Token(Token = "0x60000D7")]
			[Address(RVA = "0x262C980", Offset = "0x262AF80", VA = "0x18262C980")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D8")]
			[Address(RVA = "0x262CA60", Offset = "0x262B060", VA = "0x18262CA60")]
			set
			{
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x000024D8 File Offset: 0x000006D8
		// (set) Token: 0x060000DA RID: 218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000029")]
		public int texWidth
		{
			[Token(Token = "0x60000D9")]
			[Address(RVA = "0x262CBA0", Offset = "0x262B1A0", VA = "0x18262CBA0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60000DA")]
			[Address(RVA = "0x262CCA0", Offset = "0x262B2A0", VA = "0x18262CCA0")]
			set
			{
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000DB RID: 219 RVA: 0x000024F0 File Offset: 0x000006F0
		// (set) Token: 0x060000DC RID: 220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002A")]
		public int texHeight
		{
			[Token(Token = "0x60000DB")]
			[Address(RVA = "0x262CDA0", Offset = "0x262B3A0", VA = "0x18262CDA0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60000DC")]
			[Address(RVA = "0x262CEA0", Offset = "0x262B4A0", VA = "0x18262CEA0")]
			set
			{
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000DD RID: 221 RVA: 0x00002508 File Offset: 0x00000708
		[Token(Token = "0x1700002B")]
		public bool hasSymbols
		{
			[Token(Token = "0x60000DD")]
			[Address(RVA = "0x262CFA0", Offset = "0x262B5A0", VA = "0x18262CFA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000DE RID: 222 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700002C")]
		public List<BMSymbol> symbols
		{
			[Token(Token = "0x60000DE")]
			[Address(RVA = "0x262D0B0", Offset = "0x262B6B0", VA = "0x18262D0B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000DF RID: 223 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x060000E0 RID: 224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002D")]
		public UIAtlas atlas
		{
			[Token(Token = "0x60000DF")]
			[Address(RVA = "0x262D190", Offset = "0x262B790", VA = "0x18262D190")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000E0")]
			[Address(RVA = "0x262D270", Offset = "0x262B870", VA = "0x18262D270")]
			set
			{
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x060000E2 RID: 226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002E")]
		public Material material
		{
			[Token(Token = "0x60000E1")]
			[Address(RVA = "0x262D560", Offset = "0x262BB60", VA = "0x18262D560")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000E2")]
			[Address(RVA = "0x262DA10", Offset = "0x262C010", VA = "0x18262DA10")]
			set
			{
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x00002520 File Offset: 0x00000720
		[Token(Token = "0x1700002F")]
		[Obsolete("Use UIFont.premultipliedAlphaShader instead")]
		public bool premultipliedAlpha
		{
			[Token(Token = "0x60000E3")]
			[Address(RVA = "0x262DC30", Offset = "0x262C230", VA = "0x18262DC30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x00002538 File Offset: 0x00000738
		[Token(Token = "0x17000030")]
		public bool premultipliedAlphaShader
		{
			[Token(Token = "0x60000E4")]
			[Address(RVA = "0x262DC40", Offset = "0x262C240", VA = "0x18262DC40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x00002550 File Offset: 0x00000750
		[Token(Token = "0x17000031")]
		public bool packedFontShader
		{
			[Token(Token = "0x60000E5")]
			[Address(RVA = "0x262DF60", Offset = "0x262C560", VA = "0x18262DF60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000032")]
		public Texture2D texture
		{
			[Token(Token = "0x60000E6")]
			[Address(RVA = "0x262E270", Offset = "0x262C870", VA = "0x18262E270")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x00002568 File Offset: 0x00000768
		// (set) Token: 0x060000E8 RID: 232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000033")]
		public Rect uvRect
		{
			[Token(Token = "0x60000E7")]
			[Address(RVA = "0x262E420", Offset = "0x262CA20", VA = "0x18262E420")]
			get
			{
				return default(Rect);
			}
			[Token(Token = "0x60000E8")]
			[Address(RVA = "0x262E5F0", Offset = "0x262CBF0", VA = "0x18262E5F0")]
			set
			{
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x060000EA RID: 234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000034")]
		public string spriteName
		{
			[Token(Token = "0x60000E9")]
			[Address(RVA = "0x262E760", Offset = "0x262CD60", VA = "0x18262E760")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000EA")]
			[Address(RVA = "0x262E850", Offset = "0x262CE50", VA = "0x18262E850")]
			set
			{
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000EB RID: 235 RVA: 0x00002580 File Offset: 0x00000780
		[Token(Token = "0x17000035")]
		public bool isValid
		{
			[Token(Token = "0x60000EB")]
			[Address(RVA = "0x262E990", Offset = "0x262CF90", VA = "0x18262E990")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000EC RID: 236 RVA: 0x00002598 File Offset: 0x00000798
		// (set) Token: 0x060000ED RID: 237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000036")]
		[Obsolete("Use UIFont.defaultSize instead")]
		public int size
		{
			[Token(Token = "0x60000EC")]
			[Address(RVA = "0x262EAA0", Offset = "0x262D0A0", VA = "0x18262EAA0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60000ED")]
			[Address(RVA = "0x262EAB0", Offset = "0x262D0B0", VA = "0x18262EAB0")]
			set
			{
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000EE RID: 238 RVA: 0x000025B0 File Offset: 0x000007B0
		// (set) Token: 0x060000EF RID: 239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000037")]
		public int defaultSize
		{
			[Token(Token = "0x60000EE")]
			[Address(RVA = "0x262EAC0", Offset = "0x262D0C0", VA = "0x18262EAC0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60000EF")]
			[Address(RVA = "0x262EBD0", Offset = "0x262D1D0", VA = "0x18262EBD0")]
			set
			{
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000038")]
		public UISpriteData sprite
		{
			[Token(Token = "0x60000F0")]
			[Address(RVA = "0x262ECC0", Offset = "0x262D2C0", VA = "0x18262ECC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x060000F2 RID: 242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000039")]
		public UIFont replacement
		{
			[Token(Token = "0x60000F1")]
			[Address(RVA = "0x6710C0", Offset = "0x66F6C0", VA = "0x1806710C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000F2")]
			[Address(RVA = "0x262EF70", Offset = "0x262D570", VA = "0x18262EF70")]
			set
			{
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x000025C8 File Offset: 0x000007C8
		[Token(Token = "0x1700003A")]
		public bool isDynamic
		{
			[Token(Token = "0x60000F3")]
			[Address(RVA = "0x262F520", Offset = "0x262DB20", VA = "0x18262F520")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x060000F5 RID: 245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003B")]
		public Font dynamicFont
		{
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0x262F6A0", Offset = "0x262DCA0", VA = "0x18262F6A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000F5")]
			[Address(RVA = "0x262F780", Offset = "0x262DD80", VA = "0x18262F780")]
			set
			{
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x000025E0 File Offset: 0x000007E0
		// (set) Token: 0x060000F7 RID: 247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003C")]
		public FontStyle dynamicFontStyle
		{
			[Token(Token = "0x60000F6")]
			[Address(RVA = "0x262FA30", Offset = "0x262E030", VA = "0x18262FA30")]
			get
			{
				return FontStyle.Normal;
			}
			[Token(Token = "0x60000F7")]
			[Address(RVA = "0x262FB10", Offset = "0x262E110", VA = "0x18262FB10")]
			set
			{
			}
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x262FC10", Offset = "0x262E210", VA = "0x18262FC10")]
		private void Trim()
		{
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x000025F8 File Offset: 0x000007F8
		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x262FFE0", Offset = "0x262E5E0", VA = "0x18262FFE0")]
		private bool References(UIFont font)
		{
			return default(bool);
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00002610 File Offset: 0x00000810
		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x2630210", Offset = "0x262E810", VA = "0x182630210")]
		public static bool CheckIfRelated(UIFont a, UIFont b)
		{
			return default(bool);
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000FB RID: 251 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700003D")]
		private Texture dynamicTexture
		{
			[Token(Token = "0x60000FB")]
			[Address(RVA = "0x26304E0", Offset = "0x262EAE0", VA = "0x1826304E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x2630630", Offset = "0x262EC30", VA = "0x182630630")]
		public void MarkAsChanged()
		{
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x2630920", Offset = "0x262EF20", VA = "0x182630920")]
		public void UpdateUVRect()
		{
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x2630C20", Offset = "0x262F220", VA = "0x182630C20")]
		private BMSymbol GetSymbol(string sequence, bool createIfMissing)
		{
			return null;
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x2630E20", Offset = "0x262F420", VA = "0x182630E20")]
		public BMSymbol MatchSymbol(string text, int offset, int textLength)
		{
			return null;
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000100")]
		[Address(RVA = "0x2630FE0", Offset = "0x262F5E0", VA = "0x182630FE0")]
		public void AddSymbol(string sequence, string spriteName)
		{
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000101")]
		[Address(RVA = "0x2631070", Offset = "0x262F670", VA = "0x182631070")]
		public void RemoveSymbol(string sequence)
		{
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000102")]
		[Address(RVA = "0x26310F0", Offset = "0x262F6F0", VA = "0x1826310F0")]
		public void RenameSymbol(string before, string after)
		{
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00002628 File Offset: 0x00000828
		[Token(Token = "0x6000103")]
		[Address(RVA = "0x2631180", Offset = "0x262F780", VA = "0x182631180")]
		public bool UsesSprite(string s)
		{
			return default(bool);
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000104")]
		[Address(RVA = "0x26312D0", Offset = "0x262F8D0", VA = "0x1826312D0")]
		public UIFont()
		{
		}

		// Token: 0x040000DB RID: 219
		[Token(Token = "0x40000DB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[HideInInspector]
		private Material mMat;

		// Token: 0x040000DC RID: 220
		[Token(Token = "0x40000DC")]
		[FieldOffset(Offset = "0x28")]
		[HideInInspector]
		[SerializeField]
		private Rect mUVRect;

		// Token: 0x040000DD RID: 221
		[Token(Token = "0x40000DD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[HideInInspector]
		private BMFont mFont;

		// Token: 0x040000DE RID: 222
		[Token(Token = "0x40000DE")]
		[FieldOffset(Offset = "0x40")]
		[HideInInspector]
		[SerializeField]
		private UIAtlas mAtlas;

		// Token: 0x040000DF RID: 223
		[Token(Token = "0x40000DF")]
		[FieldOffset(Offset = "0x48")]
		[HideInInspector]
		[SerializeField]
		private UIFont mReplacement;

		// Token: 0x040000E0 RID: 224
		[Token(Token = "0x40000E0")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		private List<BMSymbol> mSymbols;

		// Token: 0x040000E1 RID: 225
		[Token(Token = "0x40000E1")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[HideInInspector]
		private Font mDynamicFont;

		// Token: 0x040000E2 RID: 226
		[Token(Token = "0x40000E2")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[HideInInspector]
		private int mDynamicFontSize;

		// Token: 0x040000E3 RID: 227
		[Token(Token = "0x40000E3")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		[HideInInspector]
		private FontStyle mDynamicFontStyle;

		// Token: 0x040000E4 RID: 228
		[Token(Token = "0x40000E4")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		private UISpriteData mSprite;

		// Token: 0x040000E5 RID: 229
		[Token(Token = "0x40000E5")]
		[FieldOffset(Offset = "0x70")]
		private int mPMA;

		// Token: 0x040000E6 RID: 230
		[Token(Token = "0x40000E6")]
		[FieldOffset(Offset = "0x74")]
		private int mPacked;
	}
}
