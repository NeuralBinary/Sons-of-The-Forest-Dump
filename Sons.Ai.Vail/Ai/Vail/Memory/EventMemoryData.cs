using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Sons.Ai.Vail.Memory
{
	// Token: 0x02000211 RID: 529
	[Token(Token = "0x2000211")]
	[Serializable]
	internal class EventMemoryData
	{
		// Token: 0x06000F0B RID: 3851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F0B")]
		[Address(RVA = "0x2BB46C0", Offset = "0x2BB2CC0", VA = "0x182BB46C0")]
		public EventMemoryData()
		{
		}

		// Token: 0x06000F0C RID: 3852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F0C")]
		[Address(RVA = "0x2BB4810", Offset = "0x2BB2E10", VA = "0x182BB4810")]
		public void Increment(MemoryEvent eventType, float timeInHours)
		{
		}

		// Token: 0x06000F0D RID: 3853 RVA: 0x00008508 File Offset: 0x00006708
		[Token(Token = "0x6000F0D")]
		[Address(RVA = "0x2BB48A0", Offset = "0x2BB2EA0", VA = "0x182BB48A0")]
		public float Sample(MemoryEvent eventType)
		{
			return 0f;
		}

		// Token: 0x06000F0E RID: 3854 RVA: 0x00008520 File Offset: 0x00006720
		[Token(Token = "0x6000F0E")]
		[Address(RVA = "0x2BB4A00", Offset = "0x2BB3000", VA = "0x182BB4A00")]
		public int Count(MemoryEvent eventType)
		{
			return 0;
		}

		// Token: 0x06000F0F RID: 3855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F0F")]
		[Address(RVA = "0x2BB4A80", Offset = "0x2BB3080", VA = "0x182BB4A80")]
		public void Save(ActorMemoryManager.ActorEventSaveData memSaveData)
		{
		}

		// Token: 0x06000F10 RID: 3856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F10")]
		[Address(RVA = "0x2BB4C90", Offset = "0x2BB3290", VA = "0x182BB4C90")]
		public void Load(ActorMemoryManager.ActorEventSaveData memSaveData)
		{
		}

		// Token: 0x0400092C RID: 2348
		[Token(Token = "0x400092C")]
		[FieldOffset(Offset = "0x10")]
		private readonly List<EventStat> _events;
	}
}
