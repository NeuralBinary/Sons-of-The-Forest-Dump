using System;
using Il2CppDummyDll;
using Sons.Ai.Vail.Influences;
using UnityEngine;

namespace Sons.Ai.Vail.Memory
{
	// Token: 0x02000216 RID: 534
	[Token(Token = "0x2000216")]
	[Serializable]
	public class StimuliInfluenceValues
	{
		// Token: 0x06000F23 RID: 3875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F23")]
		[Address(RVA = "0x2BB57D0", Offset = "0x2BB3DD0", VA = "0x182BB57D0")]
		public void OnValidate()
		{
		}

		// Token: 0x06000F24 RID: 3876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F24")]
		[Address(RVA = "0x2BB5A00", Offset = "0x2BB4000", VA = "0x182BB5A00")]
		public StimuliInfluenceValues()
		{
		}

		// Token: 0x06000F25 RID: 3877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F25")]
		[Address(RVA = "0x2BB5BC0", Offset = "0x2BB41C0", VA = "0x182BB5BC0")]
		public StimuliInfluenceValues(StimuliInfluenceValues values)
		{
		}

		// Token: 0x06000F26 RID: 3878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F26")]
		[Address(RVA = "0x2BB5F30", Offset = "0x2BB4530", VA = "0x182BB5F30")]
		public void Save(ActorMemoryManager.InfluenceSaveData saveData)
		{
		}

		// Token: 0x06000F27 RID: 3879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F27")]
		[Address(RVA = "0x2BB5F80", Offset = "0x2BB4580", VA = "0x182BB5F80")]
		public void Load(ActorMemoryManager.InfluenceSaveData saveData)
		{
		}

		// Token: 0x06000F28 RID: 3880 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000F28")]
		public T Get<T>() where T : Influence
		{
			return null;
		}

		// Token: 0x06000F29 RID: 3881 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000F29")]
		[Address(RVA = "0x2BB60A0", Offset = "0x2BB46A0", VA = "0x182BB60A0")]
		public Influence Get(Type influenceType)
		{
			return null;
		}

		// Token: 0x06000F2A RID: 3882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F2A")]
		public void Adjust<T>(float amount) where T : Influence
		{
		}

		// Token: 0x04000935 RID: 2357
		[Token(Token = "0x4000935")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private FearInfluence _fear;

		// Token: 0x04000936 RID: 2358
		[Token(Token = "0x4000936")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SentimentInfluence _sentiment;

		// Token: 0x04000937 RID: 2359
		[Token(Token = "0x4000937")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AngerInfluence _anger;
	}
}
