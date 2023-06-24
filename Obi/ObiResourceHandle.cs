using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x02000154 RID: 340
	[Token(Token = "0x2000154")]
	public class ObiResourceHandle<T> where T : class
	{
		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060006BD RID: 1725 RVA: 0x000043C4 File Offset: 0x000025C4
		[Token(Token = "0x170000ED")]
		public bool isValid
		{
			[Token(Token = "0x60006BD")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60006BE")]
		public void Invalidate()
		{
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60006BF")]
		public void Reference()
		{
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x000043DC File Offset: 0x000025DC
		[Token(Token = "0x60006C0")]
		public bool Dereference()
		{
			return default(bool);
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60006C1")]
		public ObiResourceHandle(int index = -1)
		{
		}

		// Token: 0x040005B8 RID: 1464
		[Token(Token = "0x40005B8")]
		[FieldOffset(Offset = "0x0")]
		public T owner;

		// Token: 0x040005B9 RID: 1465
		[Token(Token = "0x40005B9")]
		[FieldOffset(Offset = "0x0")]
		public int index;

		// Token: 0x040005BA RID: 1466
		[Token(Token = "0x40005BA")]
		[FieldOffset(Offset = "0x0")]
		private int referenceCount;
	}
}
