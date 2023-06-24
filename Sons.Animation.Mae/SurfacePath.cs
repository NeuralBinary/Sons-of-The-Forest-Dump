using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Animation.Mae
{
	// Token: 0x0200002D RID: 45
	[Token(Token = "0x200002D")]
	[Serializable]
	public class SurfacePath : ActionTemplate
	{
		// Token: 0x060000AC RID: 172 RVA: 0x00002804 File Offset: 0x00000A04
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x2D208D0", Offset = "0x2D1EED0", VA = "0x182D208D0", Slot = "5")]
		public override Color GetGuiColor()
		{
			return default(Color);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x2D208F0", Offset = "0x2D1EEF0", VA = "0x182D208F0", Slot = "4")]
		public override void Reset()
		{
		}

		// Token: 0x060000AE RID: 174 RVA: 0x0000281C File Offset: 0x00000A1C
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x2D20960", Offset = "0x2D1EF60", VA = "0x182D20960", Slot = "11")]
		internal override bool Start()
		{
			return default(bool);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00002834 File Offset: 0x00000A34
		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x2D20BE0", Offset = "0x2D1F1E0", VA = "0x182D20BE0", Slot = "16")]
		protected override bool AllPassed()
		{
			return default(bool);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0xABE1F0", Offset = "0xABC7F0", VA = "0x180ABE1F0")]
		private void CompletedCallback()
		{
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x2D1C040", Offset = "0x2D1A640", VA = "0x182D1C040")]
		private void InterruptedCallback()
		{
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x2D20C00", Offset = "0x2D1F200", VA = "0x182D20C00")]
		public SurfacePath()
		{
		}

		// Token: 0x0400010C RID: 268
		[Token(Token = "0x400010C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private SpeedRangeSet _speeds;

		// Token: 0x0400010D RID: 269
		[Token(Token = "0x400010D")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _stopDistance;

		// Token: 0x0400010E RID: 270
		[Token(Token = "0x400010E")]
		[FieldOffset(Offset = "0x6C")]
		private bool _passed;
	}
}
