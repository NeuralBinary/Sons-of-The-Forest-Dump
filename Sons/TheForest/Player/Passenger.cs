using System;
using Il2CppDummyDll;

namespace TheForest.Player
{
	// Token: 0x0200044E RID: 1102
	[Token(Token = "0x200044E")]
	[Serializable]
	public class Passenger
	{
		// Token: 0x06001C91 RID: 7313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C91")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public Passenger()
		{
		}

		// Token: 0x04001B23 RID: 6947
		[Token(Token = "0x4001B23")]
		[FieldOffset(Offset = "0x10")]
		public int _id;

		// Token: 0x04001B24 RID: 6948
		[Token(Token = "0x4001B24")]
		[FieldOffset(Offset = "0x14")]
		public int _zoneId;

		// Token: 0x04001B25 RID: 6949
		[Token(Token = "0x4001B25")]
		[FieldOffset(Offset = "0x18")]
		public string _path;
	}
}
