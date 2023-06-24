using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.World
{
	// Token: 0x02000381 RID: 897
	[Token(Token = "0x2000381")]
	public class MaterialSlideShow : MonoBehaviour
	{
		// Token: 0x06001801 RID: 6145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001801")]
		[Address(RVA = "0x3277CA0", Offset = "0x32762A0", VA = "0x183277CA0")]
		private void OnEnable()
		{
		}

		// Token: 0x06001802 RID: 6146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001802")]
		[Address(RVA = "0x3277F20", Offset = "0x3276520", VA = "0x183277F20")]
		private void OnDisable()
		{
		}

		// Token: 0x06001803 RID: 6147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001803")]
		[Address(RVA = "0x3277FA0", Offset = "0x32765A0", VA = "0x183277FA0")]
		private void CheckNextImage()
		{
		}

		// Token: 0x06001804 RID: 6148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001804")]
		[Address(RVA = "0x32782B0", Offset = "0x32768B0", VA = "0x1832782B0")]
		public MaterialSlideShow()
		{
		}

		// Token: 0x040016F1 RID: 5873
		[Token(Token = "0x40016F1")]
		[FieldOffset(Offset = "0x20")]
		public Renderer _targetRenderer;

		// Token: 0x040016F2 RID: 5874
		[Token(Token = "0x40016F2")]
		[FieldOffset(Offset = "0x28")]
		public Material[] _slidesMaterials;

		// Token: 0x040016F3 RID: 5875
		[Token(Token = "0x40016F3")]
		[FieldOffset(Offset = "0x30")]
		public float _scrollingDelay;

		// Token: 0x040016F4 RID: 5876
		[Token(Token = "0x40016F4")]
		[FieldOffset(Offset = "0x34")]
		public float _restartDelay;

		// Token: 0x040016F5 RID: 5877
		[Token(Token = "0x40016F5")]
		[FieldOffset(Offset = "0x38")]
		public Transform _sfxPosition;

		// Token: 0x040016F6 RID: 5878
		[Token(Token = "0x40016F6")]
		[FieldOffset(Offset = "0x40")]
		private int _wsToken;

		// Token: 0x040016F7 RID: 5879
		[Token(Token = "0x40016F7")]
		[FieldOffset(Offset = "0x44")]
		private int _lastMaterialNum;

		// Token: 0x040016F8 RID: 5880
		[Token(Token = "0x40016F8")]
		[FieldOffset(Offset = "0x48")]
		private float _lastSwapTime;

		// Token: 0x040016F9 RID: 5881
		[Token(Token = "0x40016F9")]
		private const string _swapEvent = "event:/endgame/sfx_endgame/projector_click";
	}
}
