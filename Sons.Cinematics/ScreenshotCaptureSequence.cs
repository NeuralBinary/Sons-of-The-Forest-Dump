using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Cinematics
{
	// Token: 0x02000011 RID: 17
	[Token(Token = "0x2000011")]
	public class ScreenshotCaptureSequence : MonoBehaviour
	{
		// Token: 0x0600003E RID: 62 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x2D58850", Offset = "0x2D56E50", VA = "0x182D58850")]
		private void Awake()
		{
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x2D58980", Offset = "0x2D56F80", VA = "0x182D58980")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000040 RID: 64 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x2D589E0", Offset = "0x2D56FE0", VA = "0x182D589E0")]
		private IEnumerator CaptureWorker()
		{
			return null;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x2D58A70", Offset = "0x2D57070", VA = "0x182D58A70")]
		public ScreenshotCaptureSequence()
		{
		}

		// Token: 0x0400003A RID: 58
		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Min(1f)]
		private int _frameStep;

		// Token: 0x0400003B RID: 59
		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		[Min(1f)]
		private int _superSize;

		// Token: 0x0400003C RID: 60
		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int _stopFrame;

		// Token: 0x0400003D RID: 61
		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _startTime;

		// Token: 0x0400003E RID: 62
		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _stopTime;

		// Token: 0x0400003F RID: 63
		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string _outPath;

		// Token: 0x04000040 RID: 64
		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private string _filename;

		// Token: 0x04000041 RID: 65
		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private string _suffixFormat;

		// Token: 0x04000042 RID: 66
		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x50")]
		private List<string> _generatedFiles;

		// Token: 0x04000043 RID: 67
		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x58")]
		private int _lastFrame;

		// Token: 0x04000044 RID: 68
		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x5C")]
		private int _firstFrame;

		// Token: 0x04000045 RID: 69
		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _currentDeltaTime;
	}
}
