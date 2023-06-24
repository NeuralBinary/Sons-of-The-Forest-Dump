using System;
using Il2CppDummyDll;
using Sons.Ai.Vail.Influences;
using UnityEngine;

namespace Sons.Ai.Vail.Memory
{
	// Token: 0x02000215 RID: 533
	[Token(Token = "0x2000215")]
	[Serializable]
	public class StimuliInfluenceTarget
	{
		// Token: 0x06000F1E RID: 3870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F1E")]
		[Address(RVA = "0x2BB5480", Offset = "0x2BB3A80", VA = "0x182BB5480")]
		public StimuliInfluenceTarget(MonoBehaviourStimuli stimuli, StimuliInfluenceValues values)
		{
		}

		// Token: 0x06000F1F RID: 3871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F1F")]
		[Address(RVA = "0x2BB55A0", Offset = "0x2BB3BA0", VA = "0x182BB55A0")]
		public void OnValidate()
		{
		}

		// Token: 0x06000F20 RID: 3872 RVA: 0x00008568 File Offset: 0x00006768
		[Token(Token = "0x6000F20")]
		[Address(RVA = "0x2BB5660", Offset = "0x2BB3C60", VA = "0x182BB5660")]
		public bool Matches(IStimuli target)
		{
			return default(bool);
		}

		// Token: 0x06000F21 RID: 3873 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000F21")]
		[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
		public StimuliInfluenceValues GetValues()
		{
			return null;
		}

		// Token: 0x06000F22 RID: 3874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F22")]
		public void Adjust<T>(float amount) where T : Influence
		{
		}

		// Token: 0x04000933 RID: 2355
		[Token(Token = "0x4000933")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private MonoBehaviourStimuli _target;

		// Token: 0x04000934 RID: 2356
		[Token(Token = "0x4000934")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private StimuliInfluenceValues _values;
	}
}
