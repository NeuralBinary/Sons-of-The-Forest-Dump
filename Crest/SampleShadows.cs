using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;

namespace Crest
{
	// Token: 0x02000057 RID: 87
	[Token(Token = "0x2000057")]
	internal class SampleShadows : CustomPass
	{
		// Token: 0x060001FE RID: 510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x9FD4E0", Offset = "0x9FBAE0", VA = "0x1809FD4E0", Slot = "8")]
		protected override void Execute(ScriptableRenderContext context, CommandBuffer cmd, HDCamera hdCamera, CullingResults cullingResult)
		{
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x9FD990", Offset = "0x9FBF90", VA = "0x1809FD990")]
		public static void Enable()
		{
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000200")]
		[Address(RVA = "0x9FE200", Offset = "0x9FC800", VA = "0x1809FE200")]
		public static void Disable()
		{
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000201")]
		[Address(RVA = "0x5D6C10", Offset = "0x5D5210", VA = "0x1805D6C10")]
		public SampleShadows()
		{
		}

		// Token: 0x0400017D RID: 381
		[Token(Token = "0x400017D")]
		[FieldOffset(Offset = "0x0")]
		private static GameObject gameObject;

		// Token: 0x0400017E RID: 382
		[Token(Token = "0x400017E")]
		[FieldOffset(Offset = "0x8")]
		private static readonly string GameObjectName;

		// Token: 0x0400017F RID: 383
		[Token(Token = "0x400017F")]
		[FieldOffset(Offset = "0x10")]
		private static readonly string CustomPassName;
	}
}
