using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Endnight.Physics
{
	// Token: 0x02000094 RID: 148
	[Token(Token = "0x2000094")]
	[CreateAssetMenu(fileName = "PhysicsSettingsUpdateDefinition", menuName = "Sons/PhysicsSettingsUpdateDefinition", order = 1)]
	public class PhysicsSettingsUpdateDefinition : ScriptableObject
	{
		// Token: 0x06000330 RID: 816 RVA: 0x00003768 File Offset: 0x00001968
		[Token(Token = "0x6000330")]
		[Address(RVA = "0xA9B830", Offset = "0xA99E30", VA = "0x180A9B830")]
		public ValueTuple<int, PhysicsSettingsUpdateDefinition.FrameRateUpdateRange> FindSettings(float fps)
		{
			return default(ValueTuple<int, PhysicsSettingsUpdateDefinition.FrameRateUpdateRange>);
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000331")]
		[Address(RVA = "0x5AC330", Offset = "0x5AA930", VA = "0x1805AC330")]
		public PhysicsSettingsUpdateDefinition()
		{
		}

		// Token: 0x0400020D RID: 525
		[Token(Token = "0x400020D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[FormerlySerializedAs("UpdateSettings")]
		private List<PhysicsSettingsUpdateDefinition.FrameRateUpdateRange> _updateSettings;

		// Token: 0x0400020E RID: 526
		[Token(Token = "0x400020E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[FormerlySerializedAs("_defaultSettingIndex")]
		private int _fallbackSettingIndex;

		// Token: 0x02000095 RID: 149
		[Token(Token = "0x2000095")]
		[Serializable]
		public class FrameRateUpdateRange
		{
			// Token: 0x06000332 RID: 818 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000332")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public FrameRateUpdateRange()
			{
			}

			// Token: 0x0400020F RID: 527
			[Token(Token = "0x400020F")]
			[FieldOffset(Offset = "0x10")]
			public int From;

			// Token: 0x04000210 RID: 528
			[Token(Token = "0x4000210")]
			[FieldOffset(Offset = "0x14")]
			public int To;

			// Token: 0x04000211 RID: 529
			[Token(Token = "0x4000211")]
			[FieldOffset(Offset = "0x18")]
			public float FixedDeltaTime;
		}
	}
}
