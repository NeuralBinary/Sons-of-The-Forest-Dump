using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai
{
	// Token: 0x0200000B RID: 11
	[Token(Token = "0x200000B")]
	[AddComponentMenu("Sons/Ai/AstarPreRuntimeSetup")]
	public class AstarPreRuntimeSetup : MonoBehaviour
	{
		// Token: 0x06000047 RID: 71 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x2A92650", Offset = "0x2A90C50", VA = "0x182A92650")]
		private static void MarkUnWalkableNodes()
		{
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x2A92750", Offset = "0x2A90D50", VA = "0x182A92750")]
		private void SetObjectsActive(GameObject[] gameObjects, bool active)
		{
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public AstarPreRuntimeSetup()
		{
		}

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x20")]
		public GameObject[] _disableObjects;
	}
}
