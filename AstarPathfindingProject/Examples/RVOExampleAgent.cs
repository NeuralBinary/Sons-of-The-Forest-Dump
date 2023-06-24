using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Pathfinding.RVO;
using UnityEngine;

namespace Pathfinding.Examples
{
	// Token: 0x0200016A RID: 362
	[Token(Token = "0x200016A")]
	[HelpURL("http://arongranberg.com/astar/documentation/stable/class_pathfinding_1_1_examples_1_1_r_v_o_example_agent.php")]
	[RequireComponent(typeof(RVOController))]
	[RequireComponent(typeof(Seeker))]
	public class RVOExampleAgent : MonoBehaviour
	{
		// Token: 0x06000B5E RID: 2910 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B5E")]
		[Address(RVA = "0x7319E0", Offset = "0x72FFE0", VA = "0x1807319E0")]
		public void Awake()
		{
		}

		// Token: 0x06000B5F RID: 2911 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B5F")]
		[Address(RVA = "0x731AF0", Offset = "0x7300F0", VA = "0x180731AF0")]
		public void SetTarget(Vector3 target)
		{
		}

		// Token: 0x06000B60 RID: 2912 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B60")]
		[Address(RVA = "0x731B10", Offset = "0x730110", VA = "0x180731B10")]
		public void SetColor(Color color)
		{
		}

		// Token: 0x06000B61 RID: 2913 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B61")]
		[Address(RVA = "0x7322B0", Offset = "0x7308B0", VA = "0x1807322B0")]
		public void RecalculatePath()
		{
		}

		// Token: 0x06000B62 RID: 2914 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B62")]
		[Address(RVA = "0x732550", Offset = "0x730B50", VA = "0x180732550")]
		public void OnPathComplete(Path _p)
		{
		}

		// Token: 0x06000B63 RID: 2915 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B63")]
		[Address(RVA = "0x732AE0", Offset = "0x7310E0", VA = "0x180732AE0")]
		public void Update()
		{
		}

		// Token: 0x06000B64 RID: 2916 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B64")]
		[Address(RVA = "0x734020", Offset = "0x732620", VA = "0x180734020")]
		public RVOExampleAgent()
		{
		}

		// Token: 0x04000816 RID: 2070
		[Token(Token = "0x4000816")]
		[FieldOffset(Offset = "0x20")]
		public float repathRate;

		// Token: 0x04000817 RID: 2071
		[Token(Token = "0x4000817")]
		[FieldOffset(Offset = "0x24")]
		private float nextRepath;

		// Token: 0x04000818 RID: 2072
		[Token(Token = "0x4000818")]
		[FieldOffset(Offset = "0x28")]
		private Vector3 target;

		// Token: 0x04000819 RID: 2073
		[Token(Token = "0x4000819")]
		[FieldOffset(Offset = "0x34")]
		private bool canSearchAgain;

		// Token: 0x0400081A RID: 2074
		[Token(Token = "0x400081A")]
		[FieldOffset(Offset = "0x38")]
		private RVOController controller;

		// Token: 0x0400081B RID: 2075
		[Token(Token = "0x400081B")]
		[FieldOffset(Offset = "0x40")]
		public float maxSpeed;

		// Token: 0x0400081C RID: 2076
		[Token(Token = "0x400081C")]
		[FieldOffset(Offset = "0x48")]
		private Path path;

		// Token: 0x0400081D RID: 2077
		[Token(Token = "0x400081D")]
		[FieldOffset(Offset = "0x50")]
		private List<Vector3> vectorPath;

		// Token: 0x0400081E RID: 2078
		[Token(Token = "0x400081E")]
		[FieldOffset(Offset = "0x58")]
		private int wp;

		// Token: 0x0400081F RID: 2079
		[Token(Token = "0x400081F")]
		[FieldOffset(Offset = "0x5C")]
		public float moveNextDist;

		// Token: 0x04000820 RID: 2080
		[Token(Token = "0x4000820")]
		[FieldOffset(Offset = "0x60")]
		public float slowdownDistance;

		// Token: 0x04000821 RID: 2081
		[Token(Token = "0x4000821")]
		[FieldOffset(Offset = "0x64")]
		public LayerMask groundMask;

		// Token: 0x04000822 RID: 2082
		[Token(Token = "0x4000822")]
		[FieldOffset(Offset = "0x68")]
		private Seeker seeker;

		// Token: 0x04000823 RID: 2083
		[Token(Token = "0x4000823")]
		[FieldOffset(Offset = "0x70")]
		private MeshRenderer[] rends;
	}
}
