using System;
using Il2CppDummyDll;

namespace Sons.Atmosphere
{
	// Token: 0x02000033 RID: 51
	[Token(Token = "0x2000033")]
	public interface ISeasonsReceiver
	{
		// Token: 0x0600016A RID: 362
		[Token(Token = "0x600016A")]
		void SeasonChanged(SeasonProperties seasonProperties);

		// Token: 0x0600016B RID: 363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600016B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "1")]
		void SnowHeightChanged(float newSnowHeight)
		{
		}
	}
}
