using System;
using Il2CppDummyDll;

namespace Endnight.Types
{
	// Token: 0x02000078 RID: 120
	[Token(Token = "0x2000078")]
	public abstract class TimeSliceFloat : TimeSlice<float>
	{
		// Token: 0x060002A6 RID: 678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A6")]
		[Address(RVA = "0xA912C0", Offset = "0xA8F8C0", VA = "0x180A912C0")]
		protected TimeSliceFloat(int range)
		{
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00003510 File Offset: 0x00001710
		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x620A90", Offset = "0x61F090", VA = "0x180620A90", Slot = "6")]
		internal override float GetCurrent()
		{
			return 0f;
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A8")]
		[Address(RVA = "0xA91310", Offset = "0xA8F910", VA = "0x180A91310", Slot = "4")]
		internal override void Initialize()
		{
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00003528 File Offset: 0x00001728
		[Token(Token = "0x60002A9")]
		[Address(RVA = "0xA913A0", Offset = "0xA8F9A0", VA = "0x180A913A0", Slot = "5")]
		public override bool Ready()
		{
			return default(bool);
		}
	}
}
