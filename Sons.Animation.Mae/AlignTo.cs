using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Animation.Mae
{
	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000008")]
	[Serializable]
	public class AlignTo : ActionTemplate
	{
		// Token: 0x06000022 RID: 34 RVA: 0x000021A4 File Offset: 0x000003A4
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x2D1CE00", Offset = "0x2D1B400", VA = "0x182D1CE00", Slot = "5")]
		public override Color GetGuiColor()
		{
			return default(Color);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x2D1CE20", Offset = "0x2D1B420", VA = "0x182D1CE20", Slot = "4")]
		public override void Reset()
		{
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000021BC File Offset: 0x000003BC
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x2D1CE90", Offset = "0x2D1B490", VA = "0x182D1CE90", Slot = "11")]
		internal override bool Start()
		{
			return default(bool);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000021D4 File Offset: 0x000003D4
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x2D1D0D0", Offset = "0x2D1B6D0", VA = "0x182D1D0D0", Slot = "16")]
		protected override bool AllPassed()
		{
			return default(bool);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x2D1D0F0", Offset = "0x2D1B6F0", VA = "0x182D1D0F0")]
		private void CompletedCallback()
		{
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x2D1C040", Offset = "0x2D1A640", VA = "0x182D1C040")]
		private void InterruptedCallback()
		{
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x2D1D100", Offset = "0x2D1B700", VA = "0x182D1D100")]
		public AlignTo()
		{
		}

		// Token: 0x0400002B RID: 43
		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private AlignToType _alignType;

		// Token: 0x0400002C RID: 44
		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float _speed;

		// Token: 0x0400002D RID: 45
		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _angleThreshold;

		// Token: 0x0400002E RID: 46
		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float _cancelAngleThreshold;

		// Token: 0x0400002F RID: 47
		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x70")]
		private bool _passed;
	}
}
