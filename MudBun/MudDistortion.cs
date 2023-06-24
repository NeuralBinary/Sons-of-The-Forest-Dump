using System;
using Il2CppDummyDll;

namespace MudBun
{
	// Token: 0x02000060 RID: 96
	[Token(Token = "0x2000060")]
	public class MudDistortion : MudBrush
	{
		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060002AA RID: 682 RVA: 0x000036C0 File Offset: 0x000018C0
		[Token(Token = "0x17000060")]
		public override bool IsSuccessorModifier
		{
			[Token(Token = "0x60002AA")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060002AB RID: 683 RVA: 0x000036D8 File Offset: 0x000018D8
		[Token(Token = "0x17000061")]
		public virtual float MaxDistortion
		{
			[Token(Token = "0x60002AB")]
			[Address(RVA = "0x620A90", Offset = "0x61F090", VA = "0x180620A90", Slot = "30")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060002AC RID: 684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x23C8890", Offset = "0x23C6E90", VA = "0x1823C8890", Slot = "20")]
		public override void FillBrushData(ref SdfBrush brush, int iBrush)
		{
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x23C88E0", Offset = "0x23C6EE0", VA = "0x1823C88E0", Slot = "27")]
		public override void DrawGizmosRs()
		{
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x23C8A70", Offset = "0x23C7070", VA = "0x1823C8A70")]
		public MudDistortion()
		{
		}

		// Token: 0x02000061 RID: 97
		[Token(Token = "0x2000061")]
		public enum OperatorEnum
		{
			// Token: 0x040000C4 RID: 196
			[Token(Token = "0x40000C4")]
			Distort = -100
		}
	}
}
