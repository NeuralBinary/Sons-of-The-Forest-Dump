using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;

namespace Shapes
{
	// Token: 0x02000025 RID: 37
	[Token(Token = "0x2000025")]
	public class DrawCommand : IDisposable
	{
		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000A6D RID: 2669 RVA: 0x000044CC File Offset: 0x000026CC
		[Token(Token = "0x1700015D")]
		internal static bool IsAddingDrawCommandsToBuffer
		{
			[Token(Token = "0x6000A6D")]
			[Address(RVA = "0x2A34870", Offset = "0x2A32E70", VA = "0x182A34870")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000A6E RID: 2670 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x1700015E")]
		internal static DrawCommand CurrentWritingCommandBuffer
		{
			[Token(Token = "0x6000A6E")]
			[Address(RVA = "0x2A348D0", Offset = "0x2A32ED0", VA = "0x182A348D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000A70 RID: 2672 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A70")]
		[Address(RVA = "0x2A34B70", Offset = "0x2A33170", VA = "0x182A34B70")]
		public static void ClearAllCommands()
		{
		}

		// Token: 0x06000A71 RID: 2673 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A71")]
		[Address(RVA = "0x2A34F40", Offset = "0x2A33540", VA = "0x182A34F40")]
		public static void FlushNullCameras()
		{
		}

		// Token: 0x06000A72 RID: 2674 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A72")]
		[Address(RVA = "0x2A353D0", Offset = "0x2A339D0", VA = "0x182A353D0")]
		private static void RegisterCommand(DrawCommand cmd)
		{
		}

		// Token: 0x06000A73 RID: 2675 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A73")]
		[Address(RVA = "0x2A355C0", Offset = "0x2A33BC0", VA = "0x182A355C0")]
		internal static void OnCommandRendered(DrawCommand cmd)
		{
		}

		// Token: 0x06000A74 RID: 2676 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x6000A74")]
		[Address(RVA = "0x2A35710", Offset = "0x2A33D10", VA = "0x182A35710")]
		internal DrawCommand Initialize(Camera cam, CustomPassInjectionPoint cameraEvent = CustomPassInjectionPoint.BeforePostProcess)
		{
			return null;
		}

		// Token: 0x06000A75 RID: 2677 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A75")]
		[Address(RVA = "0x2A35A60", Offset = "0x2A34060", VA = "0x182A35A60")]
		internal void AppendToBuffer(CommandBuffer cmd)
		{
		}

		// Token: 0x06000A76 RID: 2678 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A76")]
		[Address(RVA = "0x2A35D20", Offset = "0x2A34320", VA = "0x182A35D20")]
		private void Clear()
		{
		}

		// Token: 0x06000A77 RID: 2679 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A77")]
		[Address(RVA = "0x2A35ED0", Offset = "0x2A344D0", VA = "0x182A35ED0")]
		private void CleanupCachedAssetsAndMeshes()
		{
		}

		// Token: 0x06000A78 RID: 2680 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A78")]
		[Address(RVA = "0x2A363C0", Offset = "0x2A349C0", VA = "0x182A363C0", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06000A79 RID: 2681 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A79")]
		[Address(RVA = "0x2A365C0", Offset = "0x2A34BC0", VA = "0x182A365C0")]
		public DrawCommand()
		{
		}

		// Token: 0x040000EA RID: 234
		[Token(Token = "0x40000EA")]
		[FieldOffset(Offset = "0x0")]
		private static int bufferID;

		// Token: 0x040000EB RID: 235
		[Token(Token = "0x40000EB")]
		[FieldOffset(Offset = "0x4")]
		private static int drawCommandWriteNestLevel;

		// Token: 0x040000EC RID: 236
		[Token(Token = "0x40000EC")]
		[FieldOffset(Offset = "0x8")]
		private static Stack<DrawCommand> cBuffersWriting;

		// Token: 0x040000ED RID: 237
		[Token(Token = "0x40000ED")]
		[FieldOffset(Offset = "0x10")]
		internal static Dictionary<Camera, List<DrawCommand>> cBuffersRendering;

		// Token: 0x040000EE RID: 238
		[Token(Token = "0x40000EE")]
		[FieldOffset(Offset = "0x10")]
		private bool hasValidCamera;

		// Token: 0x040000EF RID: 239
		[Token(Token = "0x40000EF")]
		[FieldOffset(Offset = "0x11")]
		internal bool hasRendered;

		// Token: 0x040000F0 RID: 240
		[Token(Token = "0x40000F0")]
		[FieldOffset(Offset = "0x14")]
		internal int id;

		// Token: 0x040000F1 RID: 241
		[Token(Token = "0x40000F1")]
		[FieldOffset(Offset = "0x18")]
		private bool pushPopState;

		// Token: 0x040000F2 RID: 242
		[Token(Token = "0x40000F2")]
		[FieldOffset(Offset = "0x20")]
		private Camera cam;

		// Token: 0x040000F3 RID: 243
		[Token(Token = "0x40000F3")]
		[FieldOffset(Offset = "0x28")]
		internal readonly List<UnityEngine.Object> cachedAssets;

		// Token: 0x040000F4 RID: 244
		[Token(Token = "0x40000F4")]
		[FieldOffset(Offset = "0x30")]
		internal readonly List<DisposableMesh> cachedMeshes;

		// Token: 0x040000F5 RID: 245
		[Token(Token = "0x40000F5")]
		[FieldOffset(Offset = "0x38")]
		internal readonly List<ShapeDrawCall> drawCalls;

		// Token: 0x040000F6 RID: 246
		[Token(Token = "0x40000F6")]
		[FieldOffset(Offset = "0x40")]
		public CustomPassInjectionPoint camEvt;
	}
}
