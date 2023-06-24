using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gui.Options
{
	// Token: 0x0200006A RID: 106
	[Token(Token = "0x200006A")]
	public class SfxVolumeSamplePlayer : MonoBehaviour
	{
		// Token: 0x060002AA RID: 682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x722560", Offset = "0x720B60", VA = "0x180722560")]
		public void SetMasterVolume(float value)
		{
		}

		// Token: 0x060002AB RID: 683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x620AB0", Offset = "0x61F0B0", VA = "0x180620AB0")]
		public void SetSfxVolume(float value)
		{
		}

		// Token: 0x060002AC RID: 684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x30529D0", Offset = "0x3050FD0", VA = "0x1830529D0")]
		private void OnValidate()
		{
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x3052C10", Offset = "0x3051210", VA = "0x183052C10")]
		public void Play()
		{
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00002AD8 File Offset: 0x00000CD8
		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x3052CE0", Offset = "0x30512E0", VA = "0x183052CE0")]
		private float CalculateVolume()
		{
			return 0f;
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x3052D60", Offset = "0x3051360", VA = "0x183052D60")]
		public SfxVolumeSamplePlayer()
		{
		}

		// Token: 0x040000E2 RID: 226
		[Token(Token = "0x40000E2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SonsFMODEventEmitter _sampleEventEmitter;

		// Token: 0x040000E3 RID: 227
		[Token(Token = "0x40000E3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private FmodEmitterBuffer _sampleEventEmitterBuffer;

		// Token: 0x040000E4 RID: 228
		[Token(Token = "0x40000E4")]
		[FieldOffset(Offset = "0x30")]
		private float _masterVolume;

		// Token: 0x040000E5 RID: 229
		[Token(Token = "0x40000E5")]
		[FieldOffset(Offset = "0x34")]
		private float _sfxVolume;
	}
}
