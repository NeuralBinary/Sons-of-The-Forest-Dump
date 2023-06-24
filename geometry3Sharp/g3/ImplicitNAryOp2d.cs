using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000178 RID: 376
	[Token(Token = "0x2000178")]
	public abstract class ImplicitNAryOp2d : ImplicitOperator2d, ImplicitField2d
	{
		// Token: 0x06000A07 RID: 2567 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A07")]
		[Address(RVA = "0x1FF3E70", Offset = "0x1FF2470", VA = "0x181FF3E70")]
		public ImplicitNAryOp2d()
		{
		}

		// Token: 0x06000A08 RID: 2568 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A08")]
		[Address(RVA = "0x1FF3F20", Offset = "0x1FF2520", VA = "0x181FF3F20", Slot = "4")]
		public void AddChild(ImplicitField2d pField)
		{
		}

		// Token: 0x06000A09 RID: 2569 RVA: 0x000078D4 File Offset: 0x00005AD4
		[Token(Token = "0x6000A09")]
		[Address(RVA = "0x620A90", Offset = "0x61F090", VA = "0x180620A90", Slot = "8")]
		public virtual float Value(float fX, float fY)
		{
			return 0f;
		}

		// Token: 0x06000A0A RID: 2570 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A0A")]
		[Address(RVA = "0x1FF3FC0", Offset = "0x1FF25C0", VA = "0x181FF3FC0", Slot = "9")]
		public virtual void Gradient(float fX, float fY, ref float fGX, ref float fGY)
		{
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06000A0B RID: 2571 RVA: 0x000078EC File Offset: 0x00005AEC
		[Token(Token = "0x170001C2")]
		public virtual AxisAlignedBox2f Bounds
		{
			[Token(Token = "0x6000A0B")]
			[Address(RVA = "0x1FF40A0", Offset = "0x1FF26A0", VA = "0x181FF40A0", Slot = "10")]
			get
			{
				return default(AxisAlignedBox2f);
			}
		}

		// Token: 0x040005A7 RID: 1447
		[Token(Token = "0x40005A7")]
		[FieldOffset(Offset = "0x10")]
		protected List<ImplicitField2d> m_vChildren;
	}
}
