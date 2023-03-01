using System;
using Il2CppDummyDll;

namespace TheForest.Player
{
	// Token: 0x0200045C RID: 1116
	[Token(Token = "0x200045C")]
	[Serializable]
	public class Passenger
	{
		// Token: 0x06001C53 RID: 7251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C53")]
		[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
		public Passenger()
		{
		}

		// Token: 0x04001AFF RID: 6911
		[Token(Token = "0x4001AFF")]
		[FieldOffset(Offset = "0x10")]
		public int _id;

		// Token: 0x04001B00 RID: 6912
		[Token(Token = "0x4001B00")]
		[FieldOffset(Offset = "0x14")]
		public int _zoneId;

		// Token: 0x04001B01 RID: 6913
		[Token(Token = "0x4001B01")]
		[FieldOffset(Offset = "0x18")]
		public string _path;
	}
}
