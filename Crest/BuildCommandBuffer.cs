using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace Crest
{
	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	public class BuildCommandBuffer : BuildCommandBufferBase
	{
		// Token: 0x06000007 RID: 7 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x9C6530", Offset = "0x9C4B30", VA = "0x1809C6530")]
		private void BuildLodData(OceanRenderer ocean, CommandBuffer buf)
		{
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x9C6650", Offset = "0x9C4C50", VA = "0x1809C6650")]
		public void BuildAndExecute()
		{
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x9C69C0", Offset = "0x9C4FC0", VA = "0x1809C69C0")]
		public void BuildAndExecuteBuf(ScriptableRenderContext context, Camera camera)
		{
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x9C6CA0", Offset = "0x9C52A0", VA = "0x1809C6CA0")]
		public BuildCommandBuffer()
		{
		}

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x10")]
		private CommandBuffer _buf;
	}
}
