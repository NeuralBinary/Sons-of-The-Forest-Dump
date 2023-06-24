using System;
using Il2CppDummyDll;
using Pathfinding.RVO;
using UnityEngine;

namespace Pathfinding.Examples
{
	// Token: 0x02000184 RID: 388
	[Token(Token = "0x2000184")]
	[RequireComponent(typeof(RVOController))]
	[HelpURL("http://arongranberg.com/astar/documentation/stable/class_pathfinding_1_1_examples_1_1_manual_r_v_o_agent.php")]
	public class ManualRVOAgent : MonoBehaviour
	{
		// Token: 0x06000BDF RID: 3039 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000BDF")]
		[Address(RVA = "0x655490", Offset = "0x653A90", VA = "0x180655490")]
		private void Awake()
		{
		}

		// Token: 0x06000BE0 RID: 3040 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000BE0")]
		[Address(RVA = "0x655520", Offset = "0x653B20", VA = "0x180655520")]
		private void Update()
		{
		}

		// Token: 0x06000BE1 RID: 3041 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000BE1")]
		[Address(RVA = "0x5C7240", Offset = "0x5C5840", VA = "0x1805C7240")]
		public ManualRVOAgent()
		{
		}

		// Token: 0x040008B7 RID: 2231
		[Token(Token = "0x40008B7")]
		[FieldOffset(Offset = "0x20")]
		private RVOController rvo;

		// Token: 0x040008B8 RID: 2232
		[Token(Token = "0x40008B8")]
		[FieldOffset(Offset = "0x28")]
		public float speed;
	}
}
