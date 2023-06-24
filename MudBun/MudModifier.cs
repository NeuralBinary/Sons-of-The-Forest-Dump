using System;
using Il2CppDummyDll;

namespace MudBun
{
	// Token: 0x02000066 RID: 102
	[Token(Token = "0x2000066")]
	public class MudModifier : MudBrush
	{
		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060002D4 RID: 724 RVA: 0x000037C8 File Offset: 0x000019C8
		[Token(Token = "0x1700006C")]
		public override bool ShouldUseAccumulatedBounds
		{
			[Token(Token = "0x60002D4")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060002D5 RID: 725 RVA: 0x000037E0 File Offset: 0x000019E0
		[Token(Token = "0x1700006D")]
		public virtual float MaxModification
		{
			[Token(Token = "0x60002D5")]
			[Address(RVA = "0x620A90", Offset = "0x61F090", VA = "0x180620A90", Slot = "30")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x23F3830", Offset = "0x23F1E30", VA = "0x1823F3830", Slot = "20")]
		public override void FillBrushData(ref SdfBrush brush, int iBrush)
		{
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x23F3880", Offset = "0x23F1E80", VA = "0x1823F3880", Slot = "27")]
		public override void DrawGizmosRs()
		{
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x23C8A70", Offset = "0x23C7070", VA = "0x1823C8A70")]
		public MudModifier()
		{
		}

		// Token: 0x02000067 RID: 103
		[Token(Token = "0x2000067")]
		public enum OperatorEnum
		{
			// Token: 0x040000ED RID: 237
			[Token(Token = "0x40000ED")]
			Modify = 100
		}
	}
}
