using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding.Examples
{
	// Token: 0x02000168 RID: 360
	[Token(Token = "0x2000168")]
	[HelpURL("http://arongranberg.com/astar/documentation/stable/class_pathfinding_1_1_examples_1_1_r_v_o_agent_placer.php")]
	public class RVOAgentPlacer : MonoBehaviour
	{
		// Token: 0x06000B55 RID: 2901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B55")]
		[Address(RVA = "0x731300", Offset = "0x72F900", VA = "0x180731300")]
		private IEnumerator Start()
		{
			return null;
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x00006D64 File Offset: 0x00004F64
		[Token(Token = "0x6000B56")]
		[Address(RVA = "0x72DCC0", Offset = "0x72C2C0", VA = "0x18072DCC0")]
		public Color GetColor(float angle)
		{
			return default(Color);
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B57")]
		[Address(RVA = "0x731390", Offset = "0x72F990", VA = "0x180731390")]
		public RVOAgentPlacer()
		{
		}

		// Token: 0x0400080C RID: 2060
		[Token(Token = "0x400080C")]
		[FieldOffset(Offset = "0x20")]
		public int agents;

		// Token: 0x0400080D RID: 2061
		[Token(Token = "0x400080D")]
		[FieldOffset(Offset = "0x24")]
		public float ringSize;

		// Token: 0x0400080E RID: 2062
		[Token(Token = "0x400080E")]
		[FieldOffset(Offset = "0x28")]
		public LayerMask mask;

		// Token: 0x0400080F RID: 2063
		[Token(Token = "0x400080F")]
		[FieldOffset(Offset = "0x30")]
		public GameObject prefab;

		// Token: 0x04000810 RID: 2064
		[Token(Token = "0x4000810")]
		[FieldOffset(Offset = "0x38")]
		public Vector3 goalOffset;

		// Token: 0x04000811 RID: 2065
		[Token(Token = "0x4000811")]
		[FieldOffset(Offset = "0x44")]
		public float repathRate;

		// Token: 0x04000812 RID: 2066
		[Token(Token = "0x4000812")]
		private const float rad2Deg = 57.295776f;
	}
}
