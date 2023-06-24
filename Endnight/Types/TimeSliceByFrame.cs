using System;
using Il2CppDummyDll;

namespace Endnight.Types
{
	// Token: 0x02000076 RID: 118
	[Token(Token = "0x2000076")]
	[Serializable]
	public class TimeSliceByFrame : TimeSliceInt
	{
		// Token: 0x060002A2 RID: 674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A2")]
		[Address(RVA = "0xA910E0", Offset = "0xA8F6E0", VA = "0x180A910E0")]
		public TimeSliceByFrame(int range, bool renderFrame = false)
		{
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x000034E0 File Offset: 0x000016E0
		[Token(Token = "0x60002A3")]
		[Address(RVA = "0xA91140", Offset = "0xA8F740", VA = "0x180A91140", Slot = "6")]
		internal override int GetCurrent()
		{
			return 0;
		}

		// Token: 0x04000187 RID: 391
		[Token(Token = "0x4000187")]
		[FieldOffset(Offset = "0x28")]
		private readonly bool _renderFrame;
	}
}
