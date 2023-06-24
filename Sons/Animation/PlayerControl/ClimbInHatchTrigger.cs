using System;
using Il2CppDummyDll;

namespace Sons.Animation.PlayerControl
{
	// Token: 0x02000939 RID: 2361
	[Token(Token = "0x2000939")]
	public class ClimbInHatchTrigger : ClimbUpHatchTrigger
	{
		// Token: 0x170008B8 RID: 2232
		// (get) Token: 0x060043F2 RID: 17394 RVA: 0x00014B38 File Offset: 0x00012D38
		[Token(Token = "0x170008B8")]
		internal override int ClimbUpHatchHash
		{
			[Token(Token = "0x60043F2")]
			[Address(RVA = "0x364D580", Offset = "0x364BB80", VA = "0x18364D580", Slot = "15")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170008B9 RID: 2233
		// (get) Token: 0x060043F3 RID: 17395 RVA: 0x00014B50 File Offset: 0x00012D50
		[Token(Token = "0x170008B9")]
		internal override int ClimbUpHatchHashB
		{
			[Token(Token = "0x60043F3")]
			[Address(RVA = "0x364D5E0", Offset = "0x364BBE0", VA = "0x18364D5E0", Slot = "16")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170008BA RID: 2234
		// (get) Token: 0x060043F4 RID: 17396 RVA: 0x00014B68 File Offset: 0x00012D68
		[Token(Token = "0x170008BA")]
		internal override int DismountLadderHash
		{
			[Token(Token = "0x60043F4")]
			[Address(RVA = "0x364D640", Offset = "0x364BC40", VA = "0x18364D640", Slot = "17")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170008BB RID: 2235
		// (get) Token: 0x060043F5 RID: 17397 RVA: 0x00014B80 File Offset: 0x00012D80
		[Token(Token = "0x170008BB")]
		internal override int DismountLadderOutroHash
		{
			[Token(Token = "0x60043F5")]
			[Address(RVA = "0x364D6A0", Offset = "0x364BCA0", VA = "0x18364D6A0", Slot = "18")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060043F6 RID: 17398 RVA: 0x00014B98 File Offset: 0x00012D98
		[Token(Token = "0x60043F6")]
		[Address(RVA = "0x364D700", Offset = "0x364BD00", VA = "0x18364D700", Slot = "19")]
		internal override bool ShouldDismount()
		{
			return default(bool);
		}

		// Token: 0x060043F7 RID: 17399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043F7")]
		[Address(RVA = "0x364D7B0", Offset = "0x364BDB0", VA = "0x18364D7B0")]
		public ClimbInHatchTrigger()
		{
		}

		// Token: 0x04004712 RID: 18194
		[Token(Token = "0x4004712")]
		private const float FloorDismountOffset = 1.348f;
	}
}
