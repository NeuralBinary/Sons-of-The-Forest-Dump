using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace MTAssets.UltimateLODSystem
{
	// Token: 0x02000052 RID: 82
	[Token(Token = "0x2000052")]
	[AddComponentMenu("")]
	public class RuntimeCameraDetector : MonoBehaviour
	{
		// Token: 0x0600011B RID: 283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011B")]
		[Address(RVA = "0x5ED5C0", Offset = "0x5EBBC0", VA = "0x1805ED5C0")]
		public void Awake()
		{
		}

		// Token: 0x0600011C RID: 284 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x600011C")]
		[Address(RVA = "0x5ED760", Offset = "0x5EBD60", VA = "0x1805ED760")]
		private IEnumerator ArrayOfCamerasDelayedUpdater()
		{
			return null;
		}

		// Token: 0x0600011D RID: 285 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x600011D")]
		[Address(RVA = "0x5ED7F0", Offset = "0x5EBDF0", VA = "0x1805ED7F0")]
		private IEnumerator CurrentCameraOnScreenDetector()
		{
			return null;
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011E")]
		[Address(RVA = "0x5ED880", Offset = "0x5EBE80", VA = "0x1805ED880")]
		public RuntimeCameraDetector()
		{
		}

		// Token: 0x04000257 RID: 599
		[Token(Token = "0x4000257")]
		[FieldOffset(Offset = "0x20")]
		private WaitForSecondsRealtime DELAY_BETWEEN_ARRAY_OF_CAMERAS_UPDATE;

		// Token: 0x04000258 RID: 600
		[Token(Token = "0x4000258")]
		[FieldOffset(Offset = "0x28")]
		private WaitForSecondsRealtime DELAY_BETWEEN_CURRENT_CAMERA_DETECTOR;

		// Token: 0x04000259 RID: 601
		[Token(Token = "0x4000259")]
		[FieldOffset(Offset = "0x30")]
		private Camera[] currentArrayOfCameras;
	}
}
