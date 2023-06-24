using System;
using Il2CppDummyDll;

namespace TheForest.Utils
{
	// Token: 0x020003C9 RID: 969
	[Token(Token = "0x20003C9")]
	[Serializable]
	public class SerializableTimer
	{
		// Token: 0x06001A83 RID: 6787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A83")]
		[Address(RVA = "0x32A3B60", Offset = "0x32A2160", VA = "0x1832A3B60")]
		public void Start()
		{
		}

		// Token: 0x06001A84 RID: 6788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A84")]
		[Address(RVA = "0x32A3BC0", Offset = "0x32A21C0", VA = "0x1832A3BC0")]
		public void OnSerializing()
		{
		}

		// Token: 0x06001A85 RID: 6789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A85")]
		[Address(RVA = "0x32A3C70", Offset = "0x32A2270", VA = "0x1832A3C70")]
		public void OnDeserialized()
		{
		}

		// Token: 0x06001A86 RID: 6790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A86")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public SerializableTimer()
		{
		}

		// Token: 0x0400199D RID: 6557
		[Token(Token = "0x400199D")]
		[FieldOffset(Offset = "0x10")]
		public float _startTime;

		// Token: 0x0400199E RID: 6558
		[Token(Token = "0x400199E")]
		[FieldOffset(Offset = "0x14")]
		public float _doneTime;
	}
}
