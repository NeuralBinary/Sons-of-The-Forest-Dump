using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Ai.Vail.Memory;
using Sons.StatSystem;

namespace Sons.Ai.Vail.StimuliTypes
{
	// Token: 0x0200019C RID: 412
	[Token(Token = "0x200019C")]
	[Serializable]
	public class StatAdjustmentsByClass
	{
		// Token: 0x06000CA7 RID: 3239 RVA: 0x000075F0 File Offset: 0x000057F0
		[Token(Token = "0x6000CA7")]
		[Address(RVA = "0x2B9CF40", Offset = "0x2B9B540", VA = "0x182B9CF40")]
		public bool AffectsActorType(VailActor actor)
		{
			return default(bool);
		}

		// Token: 0x06000CA8 RID: 3240 RVA: 0x00007608 File Offset: 0x00005808
		[Token(Token = "0x6000CA8")]
		[Address(RVA = "0x2B9D370", Offset = "0x2B9B970", VA = "0x182B9D370")]
		public float GetMemoryFactor(VailActor actor)
		{
			return 0f;
		}

		// Token: 0x06000CA9 RID: 3241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CA9")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public StatAdjustmentsByClass()
		{
		}

		// Token: 0x04000868 RID: 2152
		[Token(Token = "0x4000868")]
		[FieldOffset(Offset = "0x10")]
		public List<VailActorClassId> _affectsActorClasses;

		// Token: 0x04000869 RID: 2153
		[Token(Token = "0x4000869")]
		[FieldOffset(Offset = "0x18")]
		public List<VailActorTypeId> _affectsActorTypes;

		// Token: 0x0400086A RID: 2154
		[Token(Token = "0x400086A")]
		[FieldOffset(Offset = "0x20")]
		public List<StatAdjustment> _adjustments;

		// Token: 0x0400086B RID: 2155
		[Token(Token = "0x400086B")]
		[FieldOffset(Offset = "0x28")]
		public List<StatAdjustmentsByClass.MemoryFactor> _memoryFactors;

		// Token: 0x0200019D RID: 413
		[Token(Token = "0x200019D")]
		[Serializable]
		public class MemoryFactor
		{
			// Token: 0x06000CAA RID: 3242 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000CAA")]
			[Address(RVA = "0x2B9D650", Offset = "0x2B9BC50", VA = "0x182B9D650")]
			public MemoryFactor()
			{
			}

			// Token: 0x0400086C RID: 2156
			[Token(Token = "0x400086C")]
			[FieldOffset(Offset = "0x10")]
			public MemoryEvent _memory;

			// Token: 0x0400086D RID: 2157
			[Token(Token = "0x400086D")]
			[FieldOffset(Offset = "0x14")]
			public float _mapToOne;

			// Token: 0x0400086E RID: 2158
			[Token(Token = "0x400086E")]
			[FieldOffset(Offset = "0x18")]
			public float _mapToZero;
		}
	}
}
