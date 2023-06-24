using System;
using FMOD.Studio;
using Il2CppDummyDll;

namespace FMOD
{
	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	public static class FMODExtensions
	{
		// Token: 0x0600002F RID: 47 RVA: 0x0000221C File Offset: 0x0000041C
		[Token(Token = "0x600002F")]
		[Address(RVA = "0xB0C720", Offset = "0xB0AD20", VA = "0x180B0C720")]
		public static RESULT SetParameterByIndex(this EventInstance eventInstance, int index, float value, bool ignoreSeekSpeed = false)
		{
			return RESULT.OK;
		}
	}
}
