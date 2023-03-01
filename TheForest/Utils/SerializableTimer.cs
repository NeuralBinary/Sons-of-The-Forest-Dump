using System;
using Il2CppDummyDll;

namespace TheForest.Utils
{
	// Token: 0x020003D7 RID: 983
	[Token(Token = "0x20003D7")]
	[Serializable]
	public class SerializableTimer
	{
		// Token: 0x06001A45 RID: 6725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A45")]
		[Address(RVA = "0x2CEC300", Offset = "0x2CEB300", VA = "0x182CEC300")]
		public void Start()
		{
		}

		// Token: 0x06001A46 RID: 6726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A46")]
		[Address(RVA = "0x2CEC2C0", Offset = "0x2CEB2C0", VA = "0x182CEC2C0")]
		public void OnSerializing()
		{
		}

		// Token: 0x06001A47 RID: 6727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A47")]
		[Address(RVA = "0x2CEC2A0", Offset = "0x2CEB2A0", VA = "0x182CEC2A0")]
		public void OnDeserialized()
		{
		}

		// Token: 0x06001A48 RID: 6728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A48")]
		[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
		public SerializableTimer()
		{
		}

		// Token: 0x04001979 RID: 6521
		[Token(Token = "0x4001979")]
		[FieldOffset(Offset = "0x10")]
		public float _startTime;

		// Token: 0x0400197A RID: 6522
		[Token(Token = "0x400197A")]
		[FieldOffset(Offset = "0x14")]
		public float _doneTime;
	}
}
