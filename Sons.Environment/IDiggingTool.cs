using System;
using Il2CppDummyDll;
using Sons.Environment.Digging;

namespace Sons.Environment
{
	// Token: 0x0200000F RID: 15
	[Token(Token = "0x200000F")]
	public interface IDiggingTool
	{
		// Token: 0x06000042 RID: 66
		[Token(Token = "0x6000042")]
		void AddActiveDiggingGroup(DiggingTileGroup groupValue);

		// Token: 0x06000043 RID: 67
		[Token(Token = "0x6000043")]
		void RemoveActiveDiggingGroup(DiggingTileGroup groupValue);
	}
}
