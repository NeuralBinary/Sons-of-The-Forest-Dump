using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Cutscenes
{
	// Token: 0x02000773 RID: 1907
	[Token(Token = "0x2000773")]
	public class IntroAudioController : MonoBehaviour
	{
		// Token: 0x06003214 RID: 12820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003214")]
		[Address(RVA = "0x2E467D0", Offset = "0x2E457D0", VA = "0x182E467D0")]
		private void OnEnable()
		{
		}

		// Token: 0x06003215 RID: 12821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003215")]
		[Address(RVA = "0x2E46A40", Offset = "0x2E45A40", VA = "0x182E46A40")]
		public void StopHelicopterAudio()
		{
		}

		// Token: 0x06003216 RID: 12822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003216")]
		[Address(RVA = "0x2E46940", Offset = "0x2E45940", VA = "0x182E46940")]
		public void StartManoeuvre()
		{
		}

		// Token: 0x06003217 RID: 12823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003217")]
		[Address(RVA = "0x2E46750", Offset = "0x2E45750", VA = "0x182E46750")]
		public void EndManoeuvre()
		{
		}

		// Token: 0x06003218 RID: 12824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003218")]
		[Address(RVA = "0x2E469C0", Offset = "0x2E459C0", VA = "0x182E469C0")]
		private IEnumerator StartStingAudio(float stingStartDelay)
		{
			return null;
		}

		// Token: 0x06003219 RID: 12825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003219")]
		[Address(RVA = "0x2E466F0", Offset = "0x2E456F0", VA = "0x182E466F0")]
		public void Dispose()
		{
		}

		// Token: 0x0600321A RID: 12826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600321A")]
		[Address(RVA = "0x2E46860", Offset = "0x2E45860", VA = "0x182E46860")]
		public void StartCrash()
		{
		}

		// Token: 0x0600321B RID: 12827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600321B")]
		[Address(RVA = "0x2E46B30", Offset = "0x2E45B30", VA = "0x182E46B30")]
		public IntroAudioController()
		{
		}

		// Token: 0x04002BA8 RID: 11176
		[Token(Token = "0x4002BA8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		public FMOD_StudioEventEmitter _secondHeliExtEmitter;

		// Token: 0x04002BA9 RID: 11177
		[Token(Token = "0x4002BA9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		public FMOD_StudioEventEmitter _primaryHeliIntEmitter;

		// Token: 0x04002BAA RID: 11178
		[Token(Token = "0x4002BAA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		public FMOD_StudioEventEmitter _rainAudioEmitter;

		// Token: 0x04002BAB RID: 11179
		[Token(Token = "0x4002BAB")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private FMOD_StudioEventEmitter _stingEmitter;

		// Token: 0x04002BAC RID: 11180
		[Token(Token = "0x4002BAC")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _stingStartDelay;

		// Token: 0x04002BAD RID: 11181
		[Token(Token = "0x4002BAD")]
		[FieldOffset(Offset = "0x44")]
		private float _stingStartTime;
	}
}
