using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.World
{
	// Token: 0x0200038F RID: 911
	[Token(Token = "0x200038F")]
	public class MaterialSlideShow : MonoBehaviour
	{
		// Token: 0x060017C6 RID: 6086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017C6")]
		[Address(RVA = "0x2CB4940", Offset = "0x2CB3940", VA = "0x182CB4940")]
		private void OnEnable()
		{
		}

		// Token: 0x060017C7 RID: 6087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017C7")]
		[Address(RVA = "0x2CB48C0", Offset = "0x2CB38C0", VA = "0x182CB48C0")]
		private void OnDisable()
		{
		}

		// Token: 0x060017C8 RID: 6088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017C8")]
		[Address(RVA = "0x2CB4720", Offset = "0x2CB3720", VA = "0x182CB4720")]
		private void CheckNextImage()
		{
		}

		// Token: 0x060017C9 RID: 6089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017C9")]
		[Address(RVA = "0x2CB4A70", Offset = "0x2CB3A70", VA = "0x182CB4A70")]
		public MaterialSlideShow()
		{
		}

		// Token: 0x040016D2 RID: 5842
		[Token(Token = "0x40016D2")]
		[FieldOffset(Offset = "0x20")]
		public Renderer _targetRenderer;

		// Token: 0x040016D3 RID: 5843
		[Token(Token = "0x40016D3")]
		[FieldOffset(Offset = "0x28")]
		public Material[] _slidesMaterials;

		// Token: 0x040016D4 RID: 5844
		[Token(Token = "0x40016D4")]
		[FieldOffset(Offset = "0x30")]
		public float _scrollingDelay;

		// Token: 0x040016D5 RID: 5845
		[Token(Token = "0x40016D5")]
		[FieldOffset(Offset = "0x34")]
		public float _restartDelay;

		// Token: 0x040016D6 RID: 5846
		[Token(Token = "0x40016D6")]
		[FieldOffset(Offset = "0x38")]
		public Transform _sfxPosition;

		// Token: 0x040016D7 RID: 5847
		[Token(Token = "0x40016D7")]
		[FieldOffset(Offset = "0x40")]
		private int _wsToken;

		// Token: 0x040016D8 RID: 5848
		[Token(Token = "0x40016D8")]
		[FieldOffset(Offset = "0x44")]
		private int _lastMaterialNum;

		// Token: 0x040016D9 RID: 5849
		[Token(Token = "0x40016D9")]
		[FieldOffset(Offset = "0x48")]
		private float _lastSwapTime;

		// Token: 0x040016DA RID: 5850
		[Token(Token = "0x40016DA")]
		private const string _swapEvent = "event:/endgame/sfx_endgame/projector_click";
	}
}
