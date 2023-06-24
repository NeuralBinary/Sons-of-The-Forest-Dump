using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NWH.DWP2
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	[AddComponentMenu("Rendering/SetRenderQueue")]
	public class SetRenderQueue : MonoBehaviour
	{
		// Token: 0x06000003 RID: 3 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x26FB380", Offset = "0x26F9980", VA = "0x1826FB380")]
		protected void Awake()
		{
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public SetRenderQueue()
		{
		}

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x20")]
		public int queue;
	}
}
