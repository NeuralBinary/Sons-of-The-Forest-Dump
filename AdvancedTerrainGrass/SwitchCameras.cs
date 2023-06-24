using System;
using Il2CppDummyDll;
using UnityEngine;

namespace AdvancedTerrainGrass
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	public class SwitchCameras : MonoBehaviour
	{
		// Token: 0x06000003 RID: 3 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x59F170", Offset = "0x59D770", VA = "0x18059F170")]
		private void Update()
		{
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public SwitchCameras()
		{
		}

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x20")]
		public GameObject firstCam;

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x28")]
		public GameObject secondCam;

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x30")]
		public GrassManager GrassManager;
	}
}
