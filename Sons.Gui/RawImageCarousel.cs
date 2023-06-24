using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Sons.Gui
{
	// Token: 0x0200002C RID: 44
	[Token(Token = "0x200002C")]
	[AddComponentMenu("Sons/Gui/RawImageCarousel")]
	public class RawImageCarousel : Carousel<RawImage>
	{
		// Token: 0x06000104 RID: 260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000104")]
		[Address(RVA = "0x300D2D0", Offset = "0x300B8D0", VA = "0x18300D2D0", Slot = "4")]
		internal override void Start()
		{
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000105")]
		[Address(RVA = "0x300D410", Offset = "0x300BA10", VA = "0x18300D410")]
		private void DisplayVisibilityUpdate(int index, RawImage image, float factor)
		{
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000106")]
		[Address(RVA = "0x300D4B0", Offset = "0x300BAB0", VA = "0x18300D4B0")]
		public RawImage AddOption(Texture2D sourceTexture, int newId)
		{
			return null;
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000107")]
		[Address(RVA = "0x300D530", Offset = "0x300BB30", VA = "0x18300D530")]
		public RawImage AddOption(Texture2D sourceTexture)
		{
			return null;
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000108")]
		[Address(RVA = "0x300D5C0", Offset = "0x300BBC0", VA = "0x18300D5C0")]
		public RawImageCarousel()
		{
		}
	}
}
