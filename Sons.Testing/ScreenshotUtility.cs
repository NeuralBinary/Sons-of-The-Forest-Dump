using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Testing
{
	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	public static class ScreenshotUtility
	{
		// Token: 0x06000009 RID: 9 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x31482D0", Offset = "0x31468D0", VA = "0x1831482D0")]
		public static void Screenshot(Camera camera, Vector3 position, Quaternion rotation, int superSize, string path, string comment)
		{
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x3148520", Offset = "0x3146B20", VA = "0x183148520")]
		private static void StartScreenshotWorker(Camera camera, Vector3 position, Quaternion rotation, int superSize, Action<Screenshot> finalize)
		{
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x3148820", Offset = "0x3146E20", VA = "0x183148820")]
		private static void CreateWorkerMono()
		{
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x3148910", Offset = "0x3146F10", VA = "0x183148910")]
		private static IEnumerator ScreenshotWorker(Camera camera, Vector3 position, Quaternion rotation, int superSize, Action<Screenshot> finalize)
		{
			return null;
		}

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x0")]
		private static MonoBehaviour _workerMono;
	}
}
