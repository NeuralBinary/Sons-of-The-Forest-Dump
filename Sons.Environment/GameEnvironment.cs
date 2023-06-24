using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Environment
{
	// Token: 0x0200000E RID: 14
	[Token(Token = "0x200000E")]
	public class GameEnvironment : MonoBehaviour
	{
		// Token: 0x0600003F RID: 63 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x2F93090", Offset = "0x2F91690", VA = "0x182F93090")]
		private void Awake()
		{
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x2F93180", Offset = "0x2F91780", VA = "0x182F93180")]
		private void Update()
		{
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public GameEnvironment()
		{
		}

		// Token: 0x04000091 RID: 145
		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private uint _upTime;

		// Token: 0x04000092 RID: 146
		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private uint _frameCount;

		// Token: 0x04000093 RID: 147
		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0x28")]
		private long _startTime;
	}
}
