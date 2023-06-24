using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using NGUI.Internal;
using UnityEngine;

namespace NGUI.UI
{
	// Token: 0x0200000A RID: 10
	[Token(Token = "0x200000A")]
	[AddComponentMenu("NGUI/UI/Atlas")]
	public class UIAtlas : MonoBehaviour
	{
		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600002C RID: 44 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x0600002D RID: 45 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000B")]
		public Material spriteMaterial
		{
			[Token(Token = "0x600002C")]
			[Address(RVA = "0x26149E0", Offset = "0x2612FE0", VA = "0x1826149E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600002D")]
			[Address(RVA = "0x2614AC0", Offset = "0x26130C0", VA = "0x182614AC0")]
			set
			{
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600002E RID: 46 RVA: 0x00002118 File Offset: 0x00000318
		[Token(Token = "0x1700000C")]
		public bool premultipliedAlpha
		{
			[Token(Token = "0x600002E")]
			[Address(RVA = "0x2614D10", Offset = "0x2613310", VA = "0x182614D10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600002F RID: 47 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000030 RID: 48 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000D")]
		public List<UISpriteData> spriteList
		{
			[Token(Token = "0x600002F")]
			[Address(RVA = "0x2614F90", Offset = "0x2613590", VA = "0x182614F90")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000030")]
			[Address(RVA = "0x26150A0", Offset = "0x26136A0", VA = "0x1826150A0")]
			set
			{
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000031 RID: 49 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700000E")]
		public Texture texture
		{
			[Token(Token = "0x6000031")]
			[Address(RVA = "0x26151E0", Offset = "0x26137E0", VA = "0x1826151E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000032 RID: 50 RVA: 0x00002130 File Offset: 0x00000330
		// (set) Token: 0x06000033 RID: 51 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000F")]
		public float pixelSize
		{
			[Token(Token = "0x6000032")]
			[Address(RVA = "0x2615370", Offset = "0x2613970", VA = "0x182615370")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000033")]
			[Address(RVA = "0x2615450", Offset = "0x2613A50", VA = "0x182615450")]
			set
			{
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000034 RID: 52 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000035 RID: 53 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000010")]
		public UIAtlas replacement
		{
			[Token(Token = "0x6000034")]
			[Address(RVA = "0x5B2EF0", Offset = "0x5B14F0", VA = "0x1805B2EF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x2615580", Offset = "0x2613B80", VA = "0x182615580")]
			set
			{
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x2615A80", Offset = "0x2614080", VA = "0x182615A80")]
		public UISpriteData GetSprite(string name)
		{
			return null;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x2615D90", Offset = "0x2614390", VA = "0x182615D90")]
		public string GetRandomSprite(string startsWith)
		{
			return null;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x2616050", Offset = "0x2614650", VA = "0x182616050")]
		public void MarkSpriteListAsChanged()
		{
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x2616160", Offset = "0x2614760", VA = "0x182616160")]
		public void SortAlphabetically()
		{
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x26162C0", Offset = "0x26148C0", VA = "0x1826162C0")]
		public BetterList<string> GetListOfSprites()
		{
			return null;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x2616490", Offset = "0x2614A90", VA = "0x182616490")]
		public BetterList<string> GetListOfSprites(string match)
		{
			return null;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002148 File Offset: 0x00000348
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x2616940", Offset = "0x2614F40", VA = "0x182616940")]
		private bool References(UIAtlas atlas)
		{
			return default(bool);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002160 File Offset: 0x00000360
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x2616B70", Offset = "0x2615170", VA = "0x182616B70")]
		public static bool CheckIfRelated(UIAtlas a, UIAtlas b)
		{
			return default(bool);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x2616D60", Offset = "0x2615360", VA = "0x182616D60")]
		public void MarkAsChanged()
		{
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002178 File Offset: 0x00000378
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x2617240", Offset = "0x2615840", VA = "0x182617240")]
		private bool Upgrade()
		{
			return default(bool);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x26178C0", Offset = "0x2615EC0", VA = "0x1826178C0")]
		public UIAtlas()
		{
		}

		// Token: 0x04000034 RID: 52
		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[HideInInspector]
		private Material material;

		// Token: 0x04000035 RID: 53
		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x28")]
		[HideInInspector]
		[SerializeField]
		private List<UISpriteData> mSprites;

		// Token: 0x04000036 RID: 54
		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[HideInInspector]
		private float mPixelSize;

		// Token: 0x04000037 RID: 55
		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[HideInInspector]
		private UIAtlas mReplacement;

		// Token: 0x04000038 RID: 56
		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		private UIAtlas.Coordinates mCoordinates;

		// Token: 0x04000039 RID: 57
		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x48")]
		[HideInInspector]
		[SerializeField]
		private List<UIAtlas.Sprite> sprites;

		// Token: 0x0400003A RID: 58
		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x50")]
		private int mPMA;

		// Token: 0x0400003B RID: 59
		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x58")]
		private Dictionary<string, int> mSpriteIndices;

		// Token: 0x0200000B RID: 11
		[Token(Token = "0x200000B")]
		[Serializable]
		private class Sprite
		{
			// Token: 0x17000011 RID: 17
			// (get) Token: 0x06000041 RID: 65 RVA: 0x00002190 File Offset: 0x00000390
			[Token(Token = "0x17000011")]
			public bool hasPadding
			{
				[Token(Token = "0x6000041")]
				[Address(RVA = "0x2617AC0", Offset = "0x26160C0", VA = "0x182617AC0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06000042 RID: 66 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000042")]
			[Address(RVA = "0x2617B00", Offset = "0x2616100", VA = "0x182617B00")]
			public Sprite()
			{
			}

			// Token: 0x0400003C RID: 60
			[Token(Token = "0x400003C")]
			[FieldOffset(Offset = "0x10")]
			public string name;

			// Token: 0x0400003D RID: 61
			[Token(Token = "0x400003D")]
			[FieldOffset(Offset = "0x18")]
			public Rect outer;

			// Token: 0x0400003E RID: 62
			[Token(Token = "0x400003E")]
			[FieldOffset(Offset = "0x28")]
			public Rect inner;

			// Token: 0x0400003F RID: 63
			[Token(Token = "0x400003F")]
			[FieldOffset(Offset = "0x38")]
			public bool rotated;

			// Token: 0x04000040 RID: 64
			[Token(Token = "0x4000040")]
			[FieldOffset(Offset = "0x3C")]
			public float paddingLeft;

			// Token: 0x04000041 RID: 65
			[Token(Token = "0x4000041")]
			[FieldOffset(Offset = "0x40")]
			public float paddingRight;

			// Token: 0x04000042 RID: 66
			[Token(Token = "0x4000042")]
			[FieldOffset(Offset = "0x44")]
			public float paddingTop;

			// Token: 0x04000043 RID: 67
			[Token(Token = "0x4000043")]
			[FieldOffset(Offset = "0x48")]
			public float paddingBottom;
		}

		// Token: 0x0200000C RID: 12
		[Token(Token = "0x200000C")]
		private enum Coordinates
		{
			// Token: 0x04000045 RID: 69
			[Token(Token = "0x4000045")]
			Pixels,
			// Token: 0x04000046 RID: 70
			[Token(Token = "0x4000046")]
			TexCoords
		}
	}
}
