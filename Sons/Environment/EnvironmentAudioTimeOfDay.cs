using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Environment
{
	// Token: 0x0200064B RID: 1611
	[Token(Token = "0x200064B")]
	public class EnvironmentAudioTimeOfDay : TimeOfDayBehaviour
	{
		// Token: 0x060029B1 RID: 10673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029B1")]
		[Address(RVA = "0x33EFD30", Offset = "0x33EE330", VA = "0x1833EFD30")]
		private void OnValidate()
		{
		}

		// Token: 0x060029B2 RID: 10674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029B2")]
		[Address(RVA = "0x33EFEF0", Offset = "0x33EE4F0", VA = "0x1833EFEF0", Slot = "8")]
		public override void UpdateTime(TimeOfDay time, TimeOfDay realTime)
		{
		}

		// Token: 0x060029B3 RID: 10675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029B3")]
		[Address(RVA = "0x33EFF80", Offset = "0x33EE580", VA = "0x1833EFF80")]
		public EnvironmentAudioTimeOfDay()
		{
		}

		// Token: 0x04002514 RID: 9492
		[Token(Token = "0x4002514")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string _eventPath;

		// Token: 0x04002515 RID: 9493
		[Token(Token = "0x4002515")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private FMOD_StudioEventEmitter _attachedEmitter;

		// Token: 0x04002516 RID: 9494
		[Token(Token = "0x4002516")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _currentTime;
	}
}
