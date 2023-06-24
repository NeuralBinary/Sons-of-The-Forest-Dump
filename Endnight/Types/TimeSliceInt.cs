using System;
using Il2CppDummyDll;

namespace Endnight.Types
{
	// Token: 0x02000079 RID: 121
	[Token(Token = "0x2000079")]
	public abstract class TimeSliceInt : TimeSlice<int>
	{
		// Token: 0x060002AA RID: 682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002AA")]
		[Address(RVA = "0xA91430", Offset = "0xA8FA30", VA = "0x180A91430")]
		protected TimeSliceInt(int range)
		{
		}

		// Token: 0x060002AB RID: 683 RVA: 0x00003540 File Offset: 0x00001740
		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "6")]
		internal override int GetCurrent()
		{
			return 0;
		}

		// Token: 0x060002AC RID: 684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002AC")]
		[Address(RVA = "0xA91490", Offset = "0xA8FA90", VA = "0x180A91490", Slot = "4")]
		internal override void Initialize()
		{
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00003558 File Offset: 0x00001758
		[Token(Token = "0x60002AD")]
		[Address(RVA = "0xA91510", Offset = "0xA8FB10", VA = "0x180A91510", Slot = "5")]
		public override bool Ready()
		{
			return default(bool);
		}
	}
}
