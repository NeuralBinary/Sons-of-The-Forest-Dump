using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Cutscenes
{
	// Token: 0x0200067E RID: 1662
	[Token(Token = "0x200067E")]
	public class IntroAudioController : MonoBehaviour
	{
		// Token: 0x06002B8B RID: 11147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B8B")]
		[Address(RVA = "0x3410590", Offset = "0x340EB90", VA = "0x183410590")]
		private void OnEnable()
		{
		}

		// Token: 0x06002B8C RID: 11148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B8C")]
		[Address(RVA = "0x3410650", Offset = "0x340EC50", VA = "0x183410650")]
		public void StopHelicopterAudio()
		{
		}

		// Token: 0x06002B8D RID: 11149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B8D")]
		[Address(RVA = "0x3410860", Offset = "0x340EE60", VA = "0x183410860")]
		public void StartManoeuvre()
		{
		}

		// Token: 0x06002B8E RID: 11150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B8E")]
		[Address(RVA = "0x3410940", Offset = "0x340EF40", VA = "0x183410940")]
		public void EndManoeuvre()
		{
		}

		// Token: 0x06002B8F RID: 11151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B8F")]
		[Address(RVA = "0x3410A20", Offset = "0x340F020", VA = "0x183410A20")]
		private IEnumerator StartStingAudio(float stingStartDelay)
		{
			return null;
		}

		// Token: 0x06002B90 RID: 11152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B90")]
		[Address(RVA = "0x3410AE0", Offset = "0x340F0E0", VA = "0x183410AE0")]
		public void Dispose()
		{
		}

		// Token: 0x06002B91 RID: 11153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B91")]
		[Address(RVA = "0x3410BB0", Offset = "0x340F1B0", VA = "0x183410BB0")]
		public void StartCrash()
		{
		}

		// Token: 0x06002B92 RID: 11154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B92")]
		[Address(RVA = "0x3410DC0", Offset = "0x340F3C0", VA = "0x183410DC0")]
		public IntroAudioController()
		{
		}

		// Token: 0x0400267B RID: 9851
		[Token(Token = "0x400267B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		public FMOD_StudioEventEmitter _secondHeliExtEmitter;

		// Token: 0x0400267C RID: 9852
		[Token(Token = "0x400267C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		public FMOD_StudioEventEmitter _primaryHeliIntEmitter;

		// Token: 0x0400267D RID: 9853
		[Token(Token = "0x400267D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		public FMOD_StudioEventEmitter _rainAudioEmitter;

		// Token: 0x0400267E RID: 9854
		[Token(Token = "0x400267E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private FMOD_StudioEventEmitter _stingEmitter;

		// Token: 0x0400267F RID: 9855
		[Token(Token = "0x400267F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _stingStartDelay;

		// Token: 0x04002680 RID: 9856
		[Token(Token = "0x4002680")]
		[FieldOffset(Offset = "0x44")]
		private float _stingStartTime;
	}
}
