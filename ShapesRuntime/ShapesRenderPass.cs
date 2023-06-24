using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;

namespace Shapes
{
	// Token: 0x0200004C RID: 76
	[Token(Token = "0x200004C")]
	public class ShapesRenderPass : CustomPass
	{
		// Token: 0x06000B7A RID: 2938 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B7A")]
		[Address(RVA = "0x2A45260", Offset = "0x2A43860", VA = "0x182A45260", Slot = "8")]
		protected override void Execute(ScriptableRenderContext context, CommandBuffer cmd, HDCamera hdCamera, CullingResults cullingResult)
		{
		}

		// Token: 0x06000B7B RID: 2939 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B7B")]
		[Address(RVA = "0x5D6C10", Offset = "0x5D5210", VA = "0x1805D6C10")]
		public ShapesRenderPass()
		{
		}

		// Token: 0x040001D3 RID: 467
		[Token(Token = "0x40001D3")]
		[FieldOffset(Offset = "0x0")]
		private static List<DrawCommand> executingCommands;
	}
}
