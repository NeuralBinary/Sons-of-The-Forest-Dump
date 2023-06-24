using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x02000104 RID: 260
	[Token(Token = "0x2000104")]
	public class OniConstraintsBatchImpl : IConstraintsBatchImpl
	{
		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060004B6 RID: 1206 RVA: 0x00003C44 File Offset: 0x00001E44
		[Token(Token = "0x1700008A")]
		public IntPtr oniBatch
		{
			[Token(Token = "0x60004B6")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060004B7 RID: 1207 RVA: 0x00003C5C File Offset: 0x00001E5C
		[Token(Token = "0x1700008B")]
		public Oni.ConstraintType constraintType
		{
			[Token(Token = "0x60004B7")]
			[Address(RVA = "0x66F520", Offset = "0x66DB20", VA = "0x18066F520", Slot = "4")]
			get
			{
				return Oni.ConstraintType.Tether;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060004B8 RID: 1208 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x1700008C")]
		public IConstraints constraints
		{
			[Token(Token = "0x60004B8")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060004BA RID: 1210 RVA: 0x00003C74 File Offset: 0x00001E74
		// (set) Token: 0x060004B9 RID: 1209 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x1700008D")]
		public bool enabled
		{
			[Token(Token = "0x60004BA")]
			[Address(RVA = "0x6599C0", Offset = "0x657FC0", VA = "0x1806599C0", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004B9")]
			[Address(RVA = "0x27ABAD0", Offset = "0x27AA0D0", VA = "0x1827ABAD0", Slot = "6")]
			set
			{
			}
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x27ABB70", Offset = "0x27AA170", VA = "0x1827ABB70")]
		public OniConstraintsBatchImpl(IConstraints constraints, Oni.ConstraintType type)
		{
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x27ABC50", Offset = "0x27AA250", VA = "0x1827ABC50", Slot = "8")]
		public void Destroy()
		{
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x27ABC60", Offset = "0x27AA260", VA = "0x1827ABC60", Slot = "9")]
		public void SetConstraintCount(int constraintCount)
		{
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x00003C8C File Offset: 0x00001E8C
		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x27ABCF0", Offset = "0x27AA2F0", VA = "0x1827ABCF0", Slot = "10")]
		public int GetConstraintCount()
		{
			return 0;
		}

		// Token: 0x04000531 RID: 1329
		[Token(Token = "0x4000531")]
		[FieldOffset(Offset = "0x10")]
		protected IConstraints m_Constraints;

		// Token: 0x04000532 RID: 1330
		[Token(Token = "0x4000532")]
		[FieldOffset(Offset = "0x18")]
		protected Oni.ConstraintType m_ConstraintType;

		// Token: 0x04000533 RID: 1331
		[Token(Token = "0x4000533")]
		[FieldOffset(Offset = "0x20")]
		protected IntPtr m_OniBatch;

		// Token: 0x04000534 RID: 1332
		[Token(Token = "0x4000534")]
		[FieldOffset(Offset = "0x28")]
		protected bool m_Enabled;
	}
}
