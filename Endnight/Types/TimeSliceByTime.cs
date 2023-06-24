using System;
using Il2CppDummyDll;

namespace Endnight.Types
{
	// Token: 0x02000077 RID: 119
	[Token(Token = "0x2000077")]
	public class TimeSliceByTime : TimeSliceFloat
	{
		// Token: 0x060002A4 RID: 676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A4")]
		[Address(RVA = "0xA911D0", Offset = "0xA8F7D0", VA = "0x180A911D0")]
		public TimeSliceByTime(int range, bool realtime = false)
		{
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x000034F8 File Offset: 0x000016F8
		[Token(Token = "0x60002A5")]
		[Address(RVA = "0xA91230", Offset = "0xA8F830", VA = "0x180A91230", Slot = "6")]
		internal override float GetCurrent()
		{
			return 0f;
		}

		// Token: 0x04000188 RID: 392
		[Token(Token = "0x4000188")]
		[FieldOffset(Offset = "0x28")]
		private readonly bool _realtime;
	}
}
