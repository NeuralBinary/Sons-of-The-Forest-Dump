using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x020001C7 RID: 455
	[Token(Token = "0x20001C7")]
	[RequireComponent(typeof(ObiSolver))]
	public class ObiParticleGridDebugger : MonoBehaviour
	{
		// Token: 0x060008DA RID: 2266 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60008DA")]
		[Address(RVA = "0x27FBA10", Offset = "0x27FA010", VA = "0x1827FBA10")]
		private void OnEnable()
		{
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60008DB")]
		[Address(RVA = "0x27FBB30", Offset = "0x27FA130", VA = "0x1827FBB30")]
		private void OnDisable()
		{
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60008DC")]
		[Address(RVA = "0x27FBB70", Offset = "0x27FA170", VA = "0x1827FBB70")]
		private void LateUpdate()
		{
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60008DD")]
		[Address(RVA = "0x27FBCC0", Offset = "0x27FA2C0", VA = "0x1827FBCC0")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60008DE")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public ObiParticleGridDebugger()
		{
		}

		// Token: 0x04000769 RID: 1897
		[Token(Token = "0x4000769")]
		[FieldOffset(Offset = "0x20")]
		private ObiSolver solver;

		// Token: 0x0400076A RID: 1898
		[Token(Token = "0x400076A")]
		[FieldOffset(Offset = "0x28")]
		private ObiNativeAabbList cells;
	}
}
