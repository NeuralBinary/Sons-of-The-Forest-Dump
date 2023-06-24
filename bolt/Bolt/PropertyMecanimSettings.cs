using System;
using Il2CppDummyDll;

namespace Bolt
{
	// Token: 0x020000D1 RID: 209
	[Token(Token = "0x20000D1")]
	internal struct PropertyMecanimSettings
	{
		// Token: 0x17000124 RID: 292
		// (get) Token: 0x0600066B RID: 1643 RVA: 0x000041B8 File Offset: 0x000023B8
		[Token(Token = "0x17000124")]
		public bool Enabled
		{
			[Token(Token = "0x600066B")]
			[Address(RVA = "0x8FE420", Offset = "0x8FCA20", VA = "0x1808FE420")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x040002E8 RID: 744
		[Token(Token = "0x40002E8")]
		[FieldOffset(Offset = "0x0")]
		public MecanimMode Mode;

		// Token: 0x040002E9 RID: 745
		[Token(Token = "0x40002E9")]
		[FieldOffset(Offset = "0x4")]
		public MecanimDirection Direction;

		// Token: 0x040002EA RID: 746
		[Token(Token = "0x40002EA")]
		[FieldOffset(Offset = "0x8")]
		public int Layer;

		// Token: 0x040002EB RID: 747
		[Token(Token = "0x40002EB")]
		[FieldOffset(Offset = "0xC")]
		public float Damping;
	}
}
