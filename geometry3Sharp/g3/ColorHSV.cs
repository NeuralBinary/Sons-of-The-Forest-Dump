using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000048 RID: 72
	[Token(Token = "0x2000048")]
	public class ColorHSV
	{
		// Token: 0x06000156 RID: 342 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000156")]
		[Address(RVA = "0x1E20800", Offset = "0x1E1EE00", VA = "0x181E20800")]
		public ColorHSV(float h, float s, float v, float a = 1f)
		{
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000157")]
		[Address(RVA = "0x1E20820", Offset = "0x1E1EE20", VA = "0x181E20820")]
		public ColorHSV(Colorf rgb)
		{
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000158 RID: 344 RVA: 0x00002C6C File Offset: 0x00000E6C
		// (set) Token: 0x06000159 RID: 345 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700001C")]
		public Colorf RGBA
		{
			[Token(Token = "0x6000158")]
			[Address(RVA = "0x1E20840", Offset = "0x1E1EE40", VA = "0x181E20840")]
			get
			{
				return default(Colorf);
			}
			[Token(Token = "0x6000159")]
			[Address(RVA = "0x1E20820", Offset = "0x1E1EE20", VA = "0x181E20820")]
			set
			{
			}
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00002C84 File Offset: 0x00000E84
		[Token(Token = "0x600015A")]
		[Address(RVA = "0x1E20870", Offset = "0x1E1EE70", VA = "0x181E20870")]
		public Colorf ConvertToRGB()
		{
			return default(Colorf);
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600015B")]
		[Address(RVA = "0x1E20AB0", Offset = "0x1E1F0B0", VA = "0x181E20AB0")]
		public void ConvertFromRGB(Colorf rgb)
		{
		}

		// Token: 0x04000193 RID: 403
		[Token(Token = "0x4000193")]
		[FieldOffset(Offset = "0x10")]
		public float h;

		// Token: 0x04000194 RID: 404
		[Token(Token = "0x4000194")]
		[FieldOffset(Offset = "0x14")]
		public float s;

		// Token: 0x04000195 RID: 405
		[Token(Token = "0x4000195")]
		[FieldOffset(Offset = "0x18")]
		public float v;

		// Token: 0x04000196 RID: 406
		[Token(Token = "0x4000196")]
		[FieldOffset(Offset = "0x1C")]
		public float a;
	}
}
