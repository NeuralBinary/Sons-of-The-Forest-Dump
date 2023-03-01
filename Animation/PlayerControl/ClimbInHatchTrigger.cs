using System;
using Il2CppDummyDll;

namespace Sons.Animation.PlayerControl
{
	// Token: 0x020008C4 RID: 2244
	[Token(Token = "0x20008C4")]
	public class ClimbInHatchTrigger : ClimbUpHatchTrigger
	{
		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x06003C9D RID: 15517 RVA: 0x00011BC8 File Offset: 0x0000FDC8
		[Token(Token = "0x1700078A")]
		internal override int ClimbUpHatchHash
		{
			[Token(Token = "0x6003C9D")]
			[Address(RVA = "0x2F14910", Offset = "0x2F13910", VA = "0x182F14910", Slot = "15")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x06003C9E RID: 15518 RVA: 0x00011BE0 File Offset: 0x0000FDE0
		[Token(Token = "0x1700078B")]
		internal override int ClimbUpHatchHashB
		{
			[Token(Token = "0x6003C9E")]
			[Address(RVA = "0x2F148B0", Offset = "0x2F138B0", VA = "0x182F148B0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x06003C9F RID: 15519 RVA: 0x00011BF8 File Offset: 0x0000FDF8
		[Token(Token = "0x1700078C")]
		internal override int DismountLadderHash
		{
			[Token(Token = "0x6003C9F")]
			[Address(RVA = "0x2F14970", Offset = "0x2F13970", VA = "0x182F14970", Slot = "17")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x06003CA0 RID: 15520 RVA: 0x00011C10 File Offset: 0x0000FE10
		[Token(Token = "0x1700078D")]
		internal override int DismountLadderOutroHash
		{
			[Token(Token = "0x6003CA0")]
			[Address(RVA = "0x2F149D0", Offset = "0x2F139D0", VA = "0x182F149D0", Slot = "18")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x06003CA1 RID: 15521 RVA: 0x00011C28 File Offset: 0x0000FE28
		[Token(Token = "0x6003CA1")]
		[Address(RVA = "0x2F14830", Offset = "0x2F13830", VA = "0x182F14830", Slot = "19")]
		internal override bool ShouldDismount()
		{
			return default(bool);
		}

		// Token: 0x06003CA2 RID: 15522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CA2")]
		[Address(RVA = "0x2F14890", Offset = "0x2F13890", VA = "0x182F14890")]
		public ClimbInHatchTrigger()
		{
		}

		// Token: 0x040040CC RID: 16588
		[Token(Token = "0x40040CC")]
		private const float FloorDismountOffset = 1.348f;
	}
}
