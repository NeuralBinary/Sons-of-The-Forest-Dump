using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Shapes
{
	// Token: 0x0200001F RID: 31
	[Token(Token = "0x200001F")]
	public class DisposableMesh : IDisposable
	{
		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000283 RID: 643 RVA: 0x00003AF4 File Offset: 0x00001CF4
		[Token(Token = "0x170000F9")]
		public static int ActiveMeshCount
		{
			[Token(Token = "0x6000283")]
			[Address(RVA = "0x2A33E50", Offset = "0x2A32450", VA = "0x182A33E50")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000284")]
		[Address(RVA = "0x2A33E90", Offset = "0x2A32490", VA = "0x182A33E90")]
		protected void EnsureMeshExists()
		{
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000285")]
		[Address(RVA = "0x2A340B0", Offset = "0x2A326B0", VA = "0x182A340B0")]
		internal void RegisterToCommandBuffer(DrawCommand cmd)
		{
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000286")]
		[Address(RVA = "0x2A342D0", Offset = "0x2A328D0", VA = "0x182A342D0")]
		internal void ReleaseFromCommand(DrawCommand cmd)
		{
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000287")]
		[Address(RVA = "0x2A34350", Offset = "0x2A32950", VA = "0x182A34350", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000288")]
		[Address(RVA = "0x2A345A0", Offset = "0x2A32BA0", VA = "0x182A345A0")]
		protected void ClearMesh()
		{
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00003B0C File Offset: 0x00001D0C
		[Token(Token = "0x6000289")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "5")]
		protected virtual bool ExternallyDirty()
		{
			return default(bool);
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600028A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "6")]
		protected virtual void UpdateMesh()
		{
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00003B24 File Offset: 0x00001D24
		[Token(Token = "0x600028B")]
		[Address(RVA = "0x2A34620", Offset = "0x2A32C20", VA = "0x182A34620")]
		protected bool EnsureMeshIsReadyToRender(out Mesh outMesh, Action updateMesh)
		{
			return default(bool);
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600028C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public DisposableMesh()
		{
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600028D")]
		[Address(RVA = "0x2A34760", Offset = "0x2A32D60", VA = "0x182A34760")]
		[CompilerGenerated]
		private void <RegisterToCommandBuffer>g__Add|10_0(ref DisposableMesh.<>c__DisplayClass10_0 A_1)
		{
		}

		// Token: 0x040000B7 RID: 183
		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0x0")]
		private static int activeMeshCount;

		// Token: 0x040000B8 RID: 184
		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0x10")]
		protected Mesh mesh;

		// Token: 0x040000B9 RID: 185
		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0x18")]
		protected bool meshDirty;

		// Token: 0x040000BA RID: 186
		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0x19")]
		protected bool hasData;

		// Token: 0x040000BB RID: 187
		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0x1A")]
		private bool hasMesh;

		// Token: 0x040000BC RID: 188
		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0x1B")]
		private bool disposeWhenFullyReleased;

		// Token: 0x040000BD RID: 189
		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0x20")]
		internal List<DrawCommand> usedByCommands;
	}
}
