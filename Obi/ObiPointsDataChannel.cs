using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x020001EE RID: 494
	[Token(Token = "0x20001EE")]
	[Serializable]
	public class ObiPointsDataChannel : ObiPathDataChannel<ObiWingedPoint, Vector3>
	{
		// Token: 0x06000A0B RID: 2571 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000A0B")]
		[Address(RVA = "0x2812710", Offset = "0x2810D10", VA = "0x182812710")]
		public ObiPointsDataChannel()
		{
		}

		// Token: 0x06000A0C RID: 2572 RVA: 0x000052C4 File Offset: 0x000034C4
		[Token(Token = "0x6000A0C")]
		[Address(RVA = "0x2812870", Offset = "0x2810E70", VA = "0x182812870")]
		public Vector3 GetTangent(int index)
		{
			return default(Vector3);
		}

		// Token: 0x06000A0D RID: 2573 RVA: 0x000052DC File Offset: 0x000034DC
		[Token(Token = "0x6000A0D")]
		[Address(RVA = "0x2812AA0", Offset = "0x28110A0", VA = "0x182812AA0")]
		public Vector3 GetAcceleration(int index)
		{
			return default(Vector3);
		}

		// Token: 0x06000A0E RID: 2574 RVA: 0x000052F4 File Offset: 0x000034F4
		[Token(Token = "0x6000A0E")]
		[Address(RVA = "0x2812CD0", Offset = "0x28112D0", VA = "0x182812CD0")]
		public Vector3 GetPositionAtMu(bool closed, float mu)
		{
			return default(Vector3);
		}

		// Token: 0x06000A0F RID: 2575 RVA: 0x0000530C File Offset: 0x0000350C
		[Token(Token = "0x6000A0F")]
		[Address(RVA = "0x2813060", Offset = "0x2811660", VA = "0x182813060")]
		public Vector3 GetTangentAtMu(bool closed, float mu)
		{
			return default(Vector3);
		}

		// Token: 0x06000A10 RID: 2576 RVA: 0x00005324 File Offset: 0x00003524
		[Token(Token = "0x6000A10")]
		[Address(RVA = "0x2813340", Offset = "0x2811940", VA = "0x182813340")]
		public Vector3 GetAccelerationAtMu(bool closed, float mu)
		{
			return default(Vector3);
		}
	}
}
