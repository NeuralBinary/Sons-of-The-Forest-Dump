using System;
using Il2CppDummyDll;

namespace Sons.Ai.Vail.Memory
{
	// Token: 0x02000212 RID: 530
	[Token(Token = "0x2000212")]
	[Serializable]
	public class EventStat
	{
		// Token: 0x06000F11 RID: 3857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F11")]
		[Address(RVA = "0x1316420", Offset = "0x1314A20", VA = "0x181316420")]
		public void Reset()
		{
		}

		// Token: 0x06000F12 RID: 3858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F12")]
		[Address(RVA = "0x2BB4E00", Offset = "0x2BB3400", VA = "0x182BB4E00")]
		public void Increment(float timeInHours)
		{
		}

		// Token: 0x06000F13 RID: 3859 RVA: 0x00008538 File Offset: 0x00006738
		[Token(Token = "0x6000F13")]
		[Address(RVA = "0x2BB4E10", Offset = "0x2BB3410", VA = "0x182BB4E10")]
		public float Sample()
		{
			return 0f;
		}

		// Token: 0x06000F14 RID: 3860 RVA: 0x00008550 File Offset: 0x00006750
		[Token(Token = "0x6000F14")]
		[Address(RVA = "0x2BB4EF0", Offset = "0x2BB34F0", VA = "0x182BB4EF0")]
		public bool SampleMaxTime(float maxTimeSince)
		{
			return default(bool);
		}

		// Token: 0x06000F15 RID: 3861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F15")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public EventStat()
		{
		}

		// Token: 0x0400092D RID: 2349
		[Token(Token = "0x400092D")]
		[FieldOffset(Offset = "0x10")]
		public int _count;

		// Token: 0x0400092E RID: 2350
		[Token(Token = "0x400092E")]
		[FieldOffset(Offset = "0x14")]
		public float _timeInHours;
	}
}
