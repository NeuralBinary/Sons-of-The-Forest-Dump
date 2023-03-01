using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Environment
{
	// Token: 0x02000741 RID: 1857
	[Token(Token = "0x2000741")]
	public class EnvironmentAudioTimeOfDay : TimeOfDayBehaviour
	{
		// Token: 0x06003056 RID: 12374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003056")]
		[Address(RVA = "0x2E2A1D0", Offset = "0x2E291D0", VA = "0x182E2A1D0")]
		private void OnValidate()
		{
		}

		// Token: 0x06003057 RID: 12375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003057")]
		[Address(RVA = "0x2E2A290", Offset = "0x2E29290", VA = "0x182E2A290", Slot = "8")]
		public override void UpdateTime(TimeOfDay time, TimeOfDay realTime)
		{
		}

		// Token: 0x06003058 RID: 12376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003058")]
		[Address(RVA = "0x2E2A2F0", Offset = "0x2E292F0", VA = "0x182E2A2F0")]
		public EnvironmentAudioTimeOfDay()
		{
		}

		// Token: 0x04002A4E RID: 10830
		[Token(Token = "0x4002A4E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string _eventPath;

		// Token: 0x04002A4F RID: 10831
		[Token(Token = "0x4002A4F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private FMOD_StudioEventEmitter _attachedEmitter;

		// Token: 0x04002A50 RID: 10832
		[Token(Token = "0x4002A50")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _currentTime;
	}
}
